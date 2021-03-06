using System;
using System.Data;
using System.Collections.Generic;
using Gtk;
using MySql.Data;
using MySql.Data.MySqlClient;
using QSProjectsLib;

namespace bazar
{
	public partial class Accrual : Gtk.Dialog
	{
		public bool NewAccrual;

		Gtk.ListStore ServiceListStore, ServiceRefListStore, IncomeListStore;
		TreeModel ServiceNameList, CashNameList;
		List<long> DeletedRowId = new List<long>();

		decimal AccrualTotal = 0, IncomeTotal = 0;
		int Place_type_id;
		string Place_no;
		bool NotComplete;

		float area = 0;

		public Accrual ()
		{
			this.Build ();

			MainClass.ComboAccrualYearsFill (comboAccuralYear);

			ComboBox ServiceCombo = new ComboBox();
			ComboWorks.ComboFillReference(ServiceCombo,"services",0);
			ServiceNameList = ServiceCombo.Model;
			ServiceCombo.Destroy ();
			
			ComboBox CashCombo = new ComboBox();
			ComboWorks.ComboFillReference(CashCombo,"cash",0);
			CashNameList = CashCombo.Model;
			CashCombo.Destroy ();
			
			MainClass.FillServiceListStore(out ServiceRefListStore);
			
			//Создаем таблицу "Услуги"
			ServiceListStore = new Gtk.ListStore (typeof (int), 	//0 - service id
			                                      typeof (string),	//1 - service name
			                                      typeof (int),		//2 - cash id
			                                      typeof (string),	//3 - cash name
			                                      typeof (int),		//4 - units id
			                                      typeof (string),	//5 - units name
			                                      typeof (double),	//6 - quantity
			                                      typeof (double),	//7 - price
			                                      typeof (double),	//8 - summa
			                                      typeof (long),	//9 - row id
			                                      typeof (string),	//10 - paid text
			                                      typeof (decimal),	//11 - paid value
			                                      typeof(bool),		//12 - from area
			                                      typeof(int)		//13 - number of counters
			                                      );

			Gtk.TreeViewColumn ServiceColumn = new Gtk.TreeViewColumn ();
			ServiceColumn.Title = "Наименование";
			Gtk.CellRendererCombo CellService = new CellRendererCombo();
			CellService.TextColumn = 0;
			CellService.Editable = true;
			CellService.Model = ServiceNameList;
			CellService.HasEntry = false;
			CellService.Edited += OnServiceComboEdited;
			ServiceColumn.PackStart (CellService, true);
			
			Gtk.TreeViewColumn CashColumn = new Gtk.TreeViewColumn ();
			CashColumn.Title = "Касса";
			CashColumn.MinWidth = 130;
			Gtk.CellRendererCombo CellCash = new CellRendererCombo();
			CellCash.TextColumn = 0;
			CellCash.Editable = true;
			CellCash.Model = CashNameList;
			CellCash.HasEntry = false;
			CellCash.Edited += OnCashComboEdited;
			CashColumn.PackStart (CellCash, true);

			Gtk.TreeViewColumn CountColumn = new Gtk.TreeViewColumn ();
			CountColumn.Title = "Количество";
			Gtk.CellRendererSpin CellCount = new CellRendererSpin();
			CellCount.Editable = true;
            CellCount.Digits = 2;
            Adjustment adjCount = new Adjustment(0, 0, 1000000, 1, 10, 0);
			CellCount.Adjustment = adjCount;
			CellCount.Edited += OnCountSpinEdited;
			CountColumn.PackStart (CellCount, true);

			Gtk.TreeViewColumn PriceColumn = new Gtk.TreeViewColumn ();
			PriceColumn.Title = "Цена";
			PriceColumn.MinWidth = 90;
			Gtk.CellRendererSpin CellPrice = new CellRendererSpin();
			CellPrice.Editable = true;
			CellPrice.Digits = 4;
			Adjustment adjPrice = new Adjustment(0,0,100000000,10,1000,0);
			CellPrice.Adjustment = adjPrice;
			CellPrice.Edited += OnPriceSpinEdited;
			PriceColumn.PackStart (CellPrice, true);

			Gtk.TreeViewColumn SumColumn = new Gtk.TreeViewColumn ();
			SumColumn.Title = "Сумма";
			Gtk.CellRendererText CellSum = new CellRendererText();
			SumColumn.PackStart (CellSum, true);
			
			treeviewServices.AppendColumn (ServiceColumn);
			ServiceColumn.AddAttribute (CellService,"text", 1);
			treeviewServices.AppendColumn (CashColumn);
			CashColumn.AddAttribute (CellCash,"text", 3);
			treeviewServices.AppendColumn ("Ед. изм.", new Gtk.CellRendererText (), "text", 5);
			treeviewServices.AppendColumn (CountColumn);
			CountColumn.AddAttribute (CellCount,"text", 6);
			treeviewServices.AppendColumn (PriceColumn);
			PriceColumn.AddAttribute (CellPrice,"text", 7);
			treeviewServices.AppendColumn (SumColumn);
			SumColumn.AddAttribute (CellSum,"text", 8);
			// ID long - 9
			treeviewServices.AppendColumn("Оплачено", new Gtk.CellRendererText (), "text", 10);
			//Оплачено цифровое - 11

			CountColumn.SetCellDataFunc(CellCount, RenderCountColumn);
			PriceColumn.SetCellDataFunc (CellPrice, RenderPriceColumn);
			SumColumn.SetCellDataFunc (CellSum, RenderSumColumn);
			
			treeviewServices.Model = ServiceListStore;
			treeviewServices.ShowAll();

			//Создаем таблицу оплат
			IncomeListStore = new Gtk.ListStore (typeof (int), typeof (string), typeof (string), typeof (string),
			                                     typeof (string), typeof (string), typeof (decimal));

			//ID -0
			treeviewIncomes.AppendColumn("Документ", new Gtk.CellRendererText (), "text", 1);
			treeviewIncomes.AppendColumn("Дата", new Gtk.CellRendererText (), "text", 2);
			treeviewIncomes.AppendColumn("Касса", new Gtk.CellRendererText (), "text", 3);
			// пусто
			treeviewIncomes.AppendColumn("Сумма", new Gtk.CellRendererText (), "text", 5);
			//Сумма цифровое -6
			
			treeviewIncomes.Model = IncomeListStore;
			treeviewIncomes.ShowAll();

			treeviewServices.Columns[2].Visible=false;

			OnTreeviewServicesCursorChanged(null, null);
		}

		protected void OnComboAccrualMonthChanged (object sender, EventArgs e)
		{
			if( comboAccrualMonth.Active > 0 && comboAccuralYear.Active >= 0)
				MainClass.ComboContractFill(comboContract, comboAccrualMonth.Active, Convert.ToInt32(comboAccuralYear.ActiveText));
			TestCanSave ();
		}

		protected void OnComboAccuralYearChanged (object sender, EventArgs e)
		{
			if( comboAccrualMonth.Active > 0 && comboAccuralYear.Active >= 0)
				MainClass.ComboContractFill(comboContract, comboAccrualMonth.Active, Convert.ToInt32(comboAccuralYear.ActiveText));
			TestCanSave ();
		}

		void OnServiceComboEdited (object o, EditedArgs args)
		{
			TreeIter iter;
			if (!ServiceListStore.GetIterFromString (out iter, args.Path))
				return;
			if(args.NewText == null)
			{
				Console.WriteLine("newtext is empty");
				return;
			}
			ServiceListStore.SetValue(iter, 1, args.NewText);
			TreeIter ServiceIter;
			if (!ServiceRefListStore.GetIterFirst (out ServiceIter))
				return;
			do
			{
				if(args.NewText.Equals (ServiceRefListStore.GetValue (ServiceIter, 1).ToString ()))
				{
					ServiceListStore.SetValue (iter, 0, ServiceRefListStore.GetValue (ServiceIter,0));
					ServiceListStore.SetValue (iter, 4, ServiceRefListStore.GetValue (ServiceIter,2));
					ServiceListStore.SetValue (iter, 5, ServiceRefListStore.GetValue (ServiceIter,3));

					bool choice = (bool) ServiceRefListStore.GetValue (ServiceIter,4);
					ServiceListStore.SetValue (iter, 12, choice);
					if(choice)
						ServiceListStore.SetValue (iter, 6, (int) area);
					break;
				}
			}
			while(ServiceRefListStore.IterNext (ref ServiceIter));
			TestCanSave ();
		}
		
		void OnCashComboEdited (object o, EditedArgs args)
		{
			TreeIter iter;
			if (!ServiceListStore.GetIterFromString (out iter, args.Path))
				return;
			if(args.NewText == null)
			{
				Console.WriteLine("newtext is empty");
				return;
			}
			ServiceListStore.SetValue(iter, 3, args.NewText);
			TreeIter CashIter;
			if (!CashNameList.GetIterFirst (out CashIter))
				return;
			do
			{
				if(CashNameList.GetValue (CashIter,0).ToString () == args.NewText)
				{
					ServiceListStore.SetValue (iter, 2, CashNameList.GetValue (CashIter, 1));
					break;
				}
			}
			while(CashNameList.IterNext (ref CashIter));
			TestCanSave ();
		}

		void OnCountSpinEdited (object o, EditedArgs args)
		{
			TreeIter iter;
			if (!ServiceListStore.GetIterFromString (out iter, args.Path))
				return;
			double Price = (double)ServiceListStore.GetValue (iter, 7);
			double count;
			if (double.TryParse (args.NewText, out count)) {
				ServiceListStore.SetValue (iter, 6, count);
				ServiceListStore.SetValue (iter, 8, Price * count);
				CalculateServiceSum ();
			}
		}
		
		void OnPriceSpinEdited (object o, EditedArgs args)
		{
			TreeIter iter;
			if (!ServiceListStore.GetIterFromString (out iter, args.Path))
				return;
			double count = (double)ServiceListStore.GetValue (iter, 6);
			double Price;
			if (double.TryParse (args.NewText, out Price)) {
				ServiceListStore.SetValue (iter, 7, Price);
				ServiceListStore.SetValue (iter, 8, Price * count);
				CalculateServiceSum ();
			}
		}

		private void RenderPriceColumn (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			double Price = (double) model.GetValue (iter, 7);
			(cell as Gtk.CellRendererSpin).Text = String.Format("{0:0.00}", Price);
		}

		private void RenderCountColumn (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			string Unit;
			double Count = (double) model.GetValue (iter, 6);

			if(model.GetValue(iter,5) != null)
				Unit = (string) model.GetValue(iter,5);
			else
				Unit = "";

			(cell as Gtk.CellRendererSpin).Text = String.Format("{0:N} {1}", Count, Unit);
		}
		
		private void RenderSumColumn (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			double Sum = (double) model.GetValue (iter, 8);
			decimal Paid ;
			if(model.GetValue (iter, 11) != null)
				Paid = (decimal) model.GetValue (iter, 11);
			else
				Paid = 0;
			decimal Debt = Convert.ToDecimal (Sum) - Paid;
			if (Debt <= 0 && Sum != 0) 
			{
				(cell as Gtk.CellRendererText).Foreground = "darkgreen";
			} 
			else
			{
				(cell as Gtk.CellRendererText).Foreground = "black";
			}
			(cell as Gtk.CellRendererText).Text = String.Format("{0:0.00}", Sum);
		}

		public void AccrualFill(int AccrualId)
		{
			NewAccrual = false;
			TreeIter iter;
			
			MainClass.StatusMessage("Запрос начисления №" + AccrualId +"...");
			string sql = "SELECT accrual.*, users.name as user FROM accrual " +
				"LEFT JOIN users ON users.id = accrual.user_id " +
				"WHERE accrual.id = @id";
			try
			{
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
				cmd.Parameters.AddWithValue("@id", AccrualId);
				MySqlDataReader rdr = cmd.ExecuteReader();
		
				if(!rdr.Read())
					return;
				
				entryNumber.Text = rdr["id"].ToString();
				entryUser.Text = rdr["user"].ToString ();
				textviewComments.Buffer.Text = rdr["comments"].ToString ();

				//запоминаем переменные что бы освободить соединение
				object DBContract_id = rdr["contract_id"];
				object DBMonth = rdr["month"];
				object DBYear = rdr["year"];

				rdr.Close();

				comboAccrualMonth.Active = Convert.ToInt32(DBMonth);
				ListStoreWorks.SearchListStore ((ListStore)comboAccuralYear.Model, DBYear.ToString (), out iter);
				comboAccuralYear.SetActiveIter (iter);
				if(DBContract_id != DBNull.Value)
				{
					if(ListStoreWorks.SearchListStore((ListStore)comboContract.Model, Convert.ToInt32(DBContract_id), out iter))
					{
						comboContract.SetActiveIter (iter);
						comboContract.Sensitive = false;
					}
				}
				this.Title = "Начисление №" + entryNumber.Text;
				
				//Получаем таблицу услуг
				sql = "SELECT accrual_pays.*, cash.name as cash, services.name as service, " +
					"units.id as units_id, units.name as units, paysum.sum as paid, metercount.number FROM accrual_pays " +
						"LEFT JOIN cash ON cash.id = accrual_pays.cash_id " +
						"LEFT JOIN services ON accrual_pays.service_id = services.id " +
						"LEFT JOIN units ON services.units_id = units.id " +
						"LEFT JOIN (" +
						"SELECT accrual_pay_id, SUM(sum) as sum FROM payment_details GROUP BY accrual_pay_id) as paysum " +
						"ON paysum.accrual_pay_id = accrual_pays.id " +
						"LEFT JOIN (" +
						"SELECT meter_tariffs.service_id, count(meter_tariffs.id) as number FROM meter_tariffs " +
						"LEFT JOIN meter_types ON meter_types.id = meter_tariffs.meter_type_id " +
						"LEFT JOIN meters ON meters.meter_type_id = meter_types.id " +
						"WHERE meters.place_type_id = @place_type_id AND meters.place_no = @place_no " +
						"GROUP BY service_id) as metercount ON metercount.service_id = accrual_pays.service_id " +
						"WHERE accrual_pays.accrual_id = @accrual_id";
				
				cmd = new MySqlCommand(sql, QSMain.connectionDB);
				cmd.Parameters.AddWithValue("@accrual_id", AccrualId);
				cmd.Parameters.AddWithValue("@place_type_id", Place_type_id);
				cmd.Parameters.AddWithValue("@place_no", Place_no);
				rdr = cmd.ExecuteReader();
				
				int cash_id, units_id;
				double count, price, sum;
				decimal paid;
				
				while (rdr.Read())
				{
					if(rdr["cash_id"] != DBNull.Value)
						cash_id = int.Parse(rdr["cash_id"].ToString());
					else
						cash_id = -1;
					if(rdr["units_id"] != DBNull.Value)
						units_id = int.Parse(rdr["units_id"].ToString());
					else
						units_id = -1;
					if(rdr["paid"] != DBNull.Value)
						paid = rdr.GetDecimal ("paid");
					else
						paid = 0;
					count = double.Parse(rdr["count"].ToString());
					price = double.Parse(rdr["price"].ToString());
					sum = count * price;
					
					ServiceListStore.AppendValues(int.Parse(rdr["service_id"].ToString()),
					                              rdr["service"].ToString(),
					                              cash_id,
					                              rdr["cash"].ToString(),
					                              units_id,
					                              rdr["units"].ToString(),
					                              count,
					                              price,
					                              sum,
					                              (object) rdr.GetInt64("id"),
					                              String.Format ("{0:0.00}", paid),
					                              paid,
					                              null,
					                              DBWorks.GetInt (rdr, "number", 0));
				}
				rdr.Close();
				MainClass.StatusMessage("Ok");

				CalculateServiceSum();
				UpdateIncomes ();
				ShowOldDebts ();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка получения информации о начисление!");
				QSMain.ErrorMessage(this,ex);
			}
			
			TestCanSave();
			OnTreeviewServicesCursorChanged(null, null);
		}

		protected void UpdateIncomes()
		{
			if(NewAccrual)
				return;

			MainClass.StatusMessage("Получаем таблицу приходных ордеров...");
			
			string sql = "SELECT credit_slips.*, cash.name as cash " +
					"FROM credit_slips " +
					"LEFT JOIN cash ON credit_slips.cash_id = cash.id " +
					"WHERE credit_slips.accrual_id = @id";

			MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
			cmd.Parameters.AddWithValue("@id", entryNumber.Text);
			
			MySqlDataReader rdr = cmd.ExecuteReader();
			
			IncomeListStore.Clear();
			while (rdr.Read())
			{
				IncomeListStore.AppendValues(rdr.GetInt32("id"),
				                             String.Format ("Приходный ордер № {0}", rdr["id"]),
				                             DateTime.Parse(rdr["date"].ToString()).ToShortDateString(),
				                             rdr["cash"].ToString (),
				                             null,
				                             String.Format ("{0:C}",rdr.GetDecimal ("sum")),
				                             rdr.GetDecimal ("sum"));
			}
			rdr.Close();
			
			MainClass.StatusMessage("Ok");
			CalculateIncomeSum ();
		}

		protected void OnComboContractChanged (object sender, EventArgs e)
		{
			TestCanSave();
			if(comboContract.Active < 0)
			{
				labelLessee.LabelProp = "--";
				labelOrg.LabelProp = "--";
				labelPlace.LabelProp = "--";
				buttonOpenContract.Sensitive = false;
				return;
			}
			try
			{
				TreeIter iter;
				string sql = "SELECT lessees.name as lessee, organizations.name as organization, contracts.place_no, contracts.place_type_id, place_types.name as place_type, places.area as area FROM contracts " +
					"LEFT JOIN lessees ON contracts.lessee_id = lessees.id " +
					"LEFT JOIN organizations ON contracts.org_id = organizations.id " +
					"LEFT JOIN place_types ON contracts.place_type_id = place_types.id " +
					"LEFT JOIN places ON places.type_id = contracts.place_type_id AND places.place_no=contracts.place_no " +
					"WHERE contracts.id = @contract_id";
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
				comboContract.GetActiveIter ( out iter);
				cmd.Parameters.AddWithValue("@contract_id", comboContract.Model.GetValue (iter, 1));
				using(MySqlDataReader rdr = cmd.ExecuteReader())
				{
					rdr.Read();

					labelLessee.LabelProp = rdr["lessee"].ToString();
					labelOrg.LabelProp = rdr["organization"].ToString();
					labelPlace.LabelProp = rdr["place_type"].ToString () + " - " + rdr["place_no"].ToString ();
					Place_type_id = rdr.GetInt32 ("place_type_id");
					Place_no = rdr["place_no"].ToString ();

					float old_area = area;
					area = DBWorks.GetFloat (rdr, "area", 0.0f);

					TreeIter ServiceIter;
					if (ServiceListStore.GetIterFirst (out ServiceIter))
					{
						do
						{
							bool b = (bool) ServiceListStore.GetValue(ServiceIter, 12);
							int i = (int) ServiceListStore.GetValue(ServiceIter, 6);
							if( b && i == old_area)
							{
								int ar = (int) area;
								ServiceListStore.SetValue(ServiceIter, 6, ar);
								double Price = (double)ServiceListStore.GetValue (ServiceIter, 7);
								ServiceListStore.SetValue(ServiceIter, 8, Price * ar);
							}
						}
						while(ServiceListStore.IterNext (ref ServiceIter));
						CalculateServiceSum ();
					}
				}
				buttonOpenContract.Sensitive = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка получения информации о договоре!");
				QSMain.ErrorMessage(this,ex);
			}
		}

		protected void TestCanSave ()
		{
			bool Contractok = comboContract.Active >= 0;
			bool Monthok = comboAccrualMonth.Active > 0 && comboAccuralYear.Active >= 0;
			bool SumOk = AccrualTotal > 0;
			bool ServicesOk = TestServiceAndCash ();
			
			buttonMakePayment.Sensitive = Contractok && Monthok && SumOk && ServicesOk;
			buttonOk.Sensitive = Contractok && Monthok && ServicesOk;
		}

		protected bool TestServiceAndCash()
		{
			TreeIter iter;

			if(ServiceListStore == null)
				return true;

			if(ServiceListStore.GetIterFirst(out iter))
			{
				if((int)ServiceListStore.GetValue(iter,0) <= 0 || (int)ServiceListStore.GetValue(iter, 2) <= 0)
					return false;
				while(ServiceListStore.IterNext(ref iter))
					if((int)ServiceListStore.GetValue(iter,0) <= 0 || (int)ServiceListStore.GetValue(iter, 2) <= 0)
						return false;
			}
			return true;
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			if(SaveAccountable ())
				Respond (ResponseType.Ok);
		}

		bool SaveAccountable()
		{
			TreeIter iter;
			long NewAccrual_id = 0;
			MainClass.StatusMessage("Запись начисления...");
			try 
			{
				// Проверка нет ли уже начисления по этому договору
				string sql = "SELECT id FROM accrual WHERE contract_id = @contract AND month = @month AND year = @year";
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
				comboContract.GetActiveIter ( out iter);
				cmd.Parameters.AddWithValue("@contract", comboContract.Model.GetValue (iter, 1));
				cmd.Parameters.AddWithValue("@month", comboAccrualMonth.Active);
				cmd.Parameters.AddWithValue("@year", comboAccuralYear.ActiveText);
				MySqlDataReader rdr = cmd.ExecuteReader();
				
				if(rdr.Read() && rdr["id"].ToString () != entryNumber.Text)
				{
					MainClass.StatusMessage("Начисление уже существует!");
					MessageDialog md = new MessageDialog( this, DialogFlags.Modal,
					                                     MessageType.Error, 
					                                     ButtonsType.Ok,"ошибка");
					md.UseMarkup = false;
					md.Text = "Начисление на указанный месяц по этому договору уже произведено. Начисление имеет номер " + rdr["id"].ToString ();
					md.Run ();
					md.Destroy();
					rdr.Close();
					return false;
				}
				rdr.Close();
				// записываем
				if(NewAccrual)
				{
					sql = "INSERT INTO accrual (contract_id, month, year, user_id, no_complete, comments) " +
						"VALUES (@contract_id, @month, @year, @user_id, @no_complete, @comments)";
				}
				else
				{
					sql = "UPDATE accrual SET contract_id = @contract_id, month = @month, year = @year, " +
						"no_complete = @no_complete, paid = @paid, comments = @comments " +
						"WHERE id = @id";
				}
				
				cmd = new MySqlCommand(sql, QSMain.connectionDB);
				
				cmd.Parameters.AddWithValue("@id", entryNumber.Text);
				comboContract.GetActiveIter ( out iter);
				cmd.Parameters.AddWithValue("@contract_id", comboContract.Model.GetValue (iter, 1));
				cmd.Parameters.AddWithValue("@month", comboAccrualMonth.Active);
				cmd.Parameters.AddWithValue("@year", comboAccuralYear.ActiveText);
				cmd.Parameters.AddWithValue("@user_id", QSMain.User.id);
				if(textviewComments.Buffer.Text != "")
					cmd.Parameters.AddWithValue ("@comments", textviewComments.Buffer.Text);
				else
					cmd.Parameters.AddWithValue ("@comments", DBNull.Value);
				cmd.Parameters.AddWithValue("@no_complete", NotComplete);
				if(AccrualTotal - IncomeTotal > 0)
					cmd.Parameters.AddWithValue("@paid", false);
				else
					cmd.Parameters.AddWithValue("@paid", true);
				cmd.ExecuteNonQuery();
				if(NewAccrual)
				{
					NewAccrual_id = cmd.LastInsertedId;
					entryNumber.Text = NewAccrual_id.ToString ();
					NewAccrual = false;
				}
				
				//записываем таблицу услуг
				ServiceListStore.GetIterFirst(out iter);
				do
				{
					if(!ServiceListStore.IterIsValid (iter))
						break;
					if((int)ServiceListStore.GetValue(iter,0) < 1)
						break; // не указано название услуги
					if((long)ServiceListStore.GetValue(iter,9) > 0)
						sql = "UPDATE accrual_pays SET accrual_id = @accrual_id, service_id = @service_id, " +
							"cash_id = @cash_id, count = @count, price = @price " +
							"WHERE id = @id";
					else
						sql = "INSERT INTO accrual_pays (accrual_id, service_id, cash_id, count, price) " +
							"VALUES (@accrual_id, @service_id, @cash_id, @count, @price)";
					cmd = new MySqlCommand(sql, QSMain.connectionDB);
					if(NewAccrual)
						cmd.Parameters.AddWithValue("@accrual_id", NewAccrual_id);
					else
						cmd.Parameters.AddWithValue("@accrual_id", entryNumber.Text);
					cmd.Parameters.AddWithValue("@service_id", ServiceListStore.GetValue(iter,0));
					if((int)ServiceListStore.GetValue(iter,2) > 0)
						cmd.Parameters.AddWithValue("@cash_id", ServiceListStore.GetValue(iter,2));
					else
						cmd.Parameters.AddWithValue("@cash_id", DBNull.Value);
					cmd.Parameters.AddWithValue("@count", ServiceListStore.GetValue(iter,6));
					cmd.Parameters.AddWithValue("@price", ServiceListStore.GetValue(iter,7));
					cmd.Parameters.AddWithValue("@id", ServiceListStore.GetValue(iter,9));
					cmd.ExecuteNonQuery();

					if((long)ServiceListStore.GetValue(iter,9) <= 0)
						ServiceListStore.SetValue(iter, 9, (object) cmd.LastInsertedId);
				}
				while(ServiceListStore.IterNext(ref iter));
				
				//Удаляем удаленные строки из базы данных
				sql = "DELETE FROM accrual_pays WHERE id = @id";
				foreach( long id in DeletedRowId)
				{
					cmd = new MySqlCommand(sql, QSMain.connectionDB);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
				DeletedRowId.Clear ();
				MainClass.StatusMessage("Ok");
				return true;
			} 
			catch (Exception ex) 
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка записи начисления!");
				QSMain.ErrorMessage(this,ex);
				return false;
			}
		}

		protected void OnButtonAddServiceClicked (object sender, EventArgs e)
		{
			TreeIter iter, CashIter;
			iter = ServiceListStore.Append();
			ServiceListStore.SetValue(iter, 6, 1);
			ServiceListStore.SetValue(iter, 10, String.Format ("{0:0.00}", 0));
			if(CashNameList.IterNChildren() == 1)
			{
				CashNameList.GetIterFirst (out CashIter);
				ServiceListStore.SetValue(iter, 3, CashNameList.GetValue (CashIter, 0));
				ServiceListStore.SetValue (iter, 2, CashNameList.GetValue (CashIter, 1));
			}
			//FIXME Добавить вставку информации о счетчиках. Что бы кнопка зажигалась сразу после добавления услуги.
			TestCanSave ();
			ShowStatus ();
		}

		protected void CalculateServiceSum ()
		{
			TreeIter iter;
			AccrualTotal = 0m;
			NotComplete = false;

			if (ServiceListStore.GetIterFirst(out iter))
			{
				AccrualTotal = Convert.ToDecimal(ServiceListStore.GetValue(iter,8));
				if (Convert.ToDecimal(ServiceListStore.GetValue(iter,8)) == 0)
					NotComplete = true;
				while (ServiceListStore.IterNext(ref iter)) 
				{
					AccrualTotal += Convert.ToDecimal(ServiceListStore.GetValue(iter,8));
					if (Convert.ToDecimal(ServiceListStore.GetValue(iter,8)) == 0)
						NotComplete = true;
				}
			}
			else
				NotComplete = true;
			labelSum.Text = string.Format("Сумма: {0:C} ", AccrualTotal);
			TestCanSave ();
			ShowStatus ();
		}

		protected void CalculateIncomeSum ()
		{
			TreeIter iter;
			IncomeTotal = 0m;
			
			if(IncomeListStore.GetIterFirst(out iter))
			{
				IncomeTotal = Convert.ToDecimal(IncomeListStore.GetValue(iter,6));
				while (IncomeListStore.IterNext(ref iter)) 
				{
					IncomeTotal += Convert.ToDecimal(IncomeListStore.GetValue(iter,6));
				}
			}
			labelIncomeSum.Text = string.Format("Сумма: {0:C} ", IncomeTotal);
			ShowStatus ();
		}

		protected void OnButtonDelServiceClicked (object sender, EventArgs e)
		{
			TreeIter iter;
			treeviewServices.Selection.GetSelected (out iter);
			if (ServiceListStore.GetValue(iter, 11) != null && (decimal) ServiceListStore.GetValue(iter, 11) > 0)
			{
				string mes = "Нельзя удалить уже оплаченную услугу.";
				MessageDialog md = new MessageDialog( this, DialogFlags.Modal,
				                                     MessageType.Warning, 
				                                     ButtonsType.Ok, mes);
				md.Run ();
				md.Destroy();
				return;
			}
			if((long)ServiceListStore.GetValue(iter, 9) > 0)
				DeletedRowId.Add ((long)ServiceListStore.GetValue(iter, 9));
			ServiceListStore.Remove(ref iter);
			CalculateServiceSum ();
			OnTreeviewServicesCursorChanged (null, null);
		}

		protected void OnTreeviewServicesCursorChanged (object sender, EventArgs e)
		{
			TreeIter iter;
			bool isSelect = treeviewServices.Selection.CountSelectedRows() == 1;
			bool MeterOk = false;
			if (isSelect && treeviewServices.Selection.GetSelected (out iter))
				MeterOk = (int)ServiceListStore.GetValue (iter, 13) > 0;
			buttonDelService.Sensitive = isSelect;
			buttonFromMeter.Sensitive = MeterOk;
		}

		protected void ShowStatus()
		{
			string CompleteStatus, BalanceStatus;
			decimal Balance = AccrualTotal - IncomeTotal;
			if(NotComplete)
				CompleteStatus = "<span background=\"Cyan\">Неполное</span>";
			else
				CompleteStatus = "";
			if(AccrualTotal == 0)
				CompleteStatus = "Незаполнено";
			BalanceStatus = "";
			if(Balance == 0)
				BalanceStatus = "<span background=\"green\">Оплачено</span>";
			if(Balance > 0 )
			{
				if(IncomeTotal == 0)
					BalanceStatus = String.Format ("<span background=\"orange\">Не оплачено</span>", Balance);
				else
					BalanceStatus = String.Format ("<span background=\"yellow\">Не оплачено {0:C}</span>", Balance);
			}
			if(Balance < 0)
				BalanceStatus = String.Format ("<span background=\"red\">Переплата {0:C}</span>", Math.Abs (Balance));

			if(AccrualTotal == 0 || (CompleteStatus != "" && Balance >= 0) )
				labelStatus.LabelProp = CompleteStatus;
			else if (Balance < 0)
			{
				labelStatus.LabelProp = CompleteStatus + "\n" + BalanceStatus;
			}
			else
				labelStatus.LabelProp = BalanceStatus;
		}

		public static decimal GetAccrualPaidBalance(int id)
		{
			string sql = "SELECT SUM(money) as balance FROM (" +
				"SELECT SUM(count * price) as money FROM accrual_pays WHERE accrual_id = @id " +
				"UNION ALL SELECT -(sum) as money FROM credit_slips WHERE accrual_id = @id ) as sumtable";
			decimal balance;
			try
			{
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
				cmd.Parameters.AddWithValue("@id", id);
				balance = (decimal) cmd.ExecuteScalar ();

				sql = "UPDATE accrual SET paid = @paid WHERE id = @id";
				cmd = new MySqlCommand(sql, QSMain.connectionDB);
				cmd.Parameters.AddWithValue("@id", id);
				if(balance <= 0)
					cmd.Parameters.AddWithValue("@paid", true);
				else
					cmd.Parameters.AddWithValue("@paid", false);
				cmd.ExecuteNonQuery ();
				return balance;
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка вычисления баланса!");
			}
			return 0m;
		}

		protected void OnButtonMakePaymentClicked (object sender, EventArgs e)
		{
			if(SaveAccountable ())
			{
				PayAccrual winPay = new PayAccrual();
				winPay.FillPayTable (Convert.ToInt32 (entryNumber.Text));
				winPay.ShowAll ();
				if((ResponseType)winPay.Run () == ResponseType.Ok)
				{
					UpdateIncomes ();
					UpdatePaid ();
				}
				winPay.Destroy ();
			}
		}

		protected void OnButtonPrintClicked (object sender, EventArgs e)
		{
			string param = "id=" + entryNumber.Text;
			ViewReportExt.Run ("PayList", param);
		}

		private void ShowOldDebts()
		{
			string sql = "SELECT accrual.month, accrual.year, SUM(money) as debt FROM (" +
				"SELECT accrual_id, SUM(count * price) as money FROM accrual_pays WHERE accrual_id IN " +
				"(SELECT id FROM accrual WHERE contract_id = @contract)" +
				"GROUP BY accrual_id " +
				"UNION ALL SELECT accrual_id, -SUM(sum) as money FROM credit_slips WHERE accrual_id IN " +
				"(SELECT id FROM accrual WHERE contract_id = @contract) " +
				"GROUP BY accrual_id ) as sumtable " +
				"LEFT JOIN accrual ON accrual.id = sumtable.accrual_id " +
				"GROUP BY accrual_id";
			decimal TotalDebt = 0;
			int count = 0;
			string DebtsText = "";
			int year = Convert.ToInt32 (comboAccuralYear.ActiveText);
			try
			{
				TreeIter iter;
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
				comboContract.GetActiveIter ( out iter);
				cmd.Parameters.AddWithValue("@contract", comboContract.Model.GetValue (iter, 1));
				MySqlDataReader rdr = cmd.ExecuteReader ();

				while(rdr.Read ())
				{
					if(rdr.GetDecimal ("debt") <= 0)
						continue;
					if( rdr.GetInt32 ("year") > year  || ( rdr.GetInt32 ("year") == year && rdr.GetInt32 ("month") >= comboAccrualMonth.Active))
						continue;
					if(DebtsText != "")
						DebtsText += "\n";
					DateTime Month = new DateTime(rdr.GetInt32 ("year"), rdr.GetInt32("month"), 1);
					if(rdr.GetInt32 ("year") == year)
					{
						DebtsText += String.Format ("{0:MMMM} = <span foreground=\"red\">{1:C}</span>", Month, rdr.GetDecimal ("debt"));
					}
					else
					{
						DebtsText += String.Format ("{0:Y} = <span foreground=\"red\">{1:C}</span>", Month, rdr.GetDecimal ("debt"));
					}
					TotalDebt += rdr.GetDecimal ("debt");
					count ++;
				}
				rdr.Close ();
				if (count == 0)
					return;
				if (count > 5)
				{
					labelDebts.LabelProp = String.Format ("за {0} месяцев - {1:C}", count, TotalDebt);
				}
				else
				{
					labelDebts.LabelProp = DebtsText;
				}
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка вычисления прошлого долга!");
			}
		}

		protected void OnButtonOpenContractClicked (object sender, EventArgs e)
		{
			TreeIter iter;
			comboContract.GetActiveIter(out iter);
			int itemid = (int) comboContract.Model.GetValue (iter, 1);

			Contract winContract = new Contract();
			winContract.ContractFill(itemid);
			winContract.Show();
			winContract.Run();
			winContract.Destroy();
		}

		private void UpdatePaid()
		{
			string sql = "SELECT accrual_pay_id, SUM(sum) as sum FROM payment_details " +
					"WHERE payment_id IN " +
					"(SELECT id FROM payments WHERE accrual_id = @accrual_id) " +
					"GROUP BY accrual_pay_id";
			TreeIter iter;
			
			MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
			cmd.Parameters.AddWithValue("@accrual_id", entryNumber.Text);
			MySqlDataReader rdr = cmd.ExecuteReader();

			decimal paid;
			foreach(object[] row in ServiceListStore)
			{
				row[10] = String.Format ("{0:0.00}", 0);
				row[11] = 0;
			}
			
			while (rdr.Read())
			{
				if( ListStoreWorks.SearchListStore (ServiceListStore, rdr.GetInt64("accrual_pay_id"), 9, out iter))
				{
					paid = rdr.GetDecimal ("sum");
					ServiceListStore.SetValue (iter, 10, String.Format ("{0:0.00}", paid));
					ServiceListStore.SetValue (iter, 10, paid);
				}
			}
			rdr.Close();
		}

		protected void OnTreeviewIncomesRowActivated (object o, RowActivatedArgs args)
		{
			TreeIter iter;
			treeviewIncomes.Selection.GetSelected(out iter);
			int itemid = Convert.ToInt32(IncomeListStore.GetValue(iter,0));
			IncomeSlip winIncome = new IncomeSlip();
			winIncome.SlipFill(itemid, false);
			winIncome.Show();
			ResponseType result = (ResponseType)winIncome.Run();
			winIncome.Destroy();
			if(result == ResponseType.Ok)
			{
				UpdateIncomes();
				UpdatePaid ();
			}

		}

		protected void OnButtonFromMeterClicked(object sender, EventArgs e)
		{
			TreeIter iter;
			treeviewServices.Selection.GetSelected (out iter);

			PayFromMeter WinMeter = new PayFromMeter ();
			WinMeter.Price = (double) ServiceListStore.GetValue (iter, 7);
			WinMeter.Fill (Convert.ToInt32 (ServiceListStore.GetValue (iter, 9)),
			               (int) ServiceListStore.GetValue (iter, 0),
			               Place_type_id,
			               Place_no,
			               ServiceListStore.GetValue (iter, 5).ToString ());
			int result = WinMeter.Run ();
			if(result == (int) ResponseType.Ok)
			{
				ServiceListStore.SetValue (iter, 7, WinMeter.Price);
				ServiceListStore.SetValue (iter, 6, WinMeter.TotalCount);
				ServiceListStore.SetValue (iter, 8, WinMeter.Price * WinMeter.TotalCount);
				CalculateServiceSum ();
			}
			WinMeter.Destroy ();
		}
	}
}
	
