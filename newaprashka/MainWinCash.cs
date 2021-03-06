using System;
using Gtk;
using MySql.Data.MySqlClient;
using bazar;
using QSProjectsLib;

public partial class MainWindow : Gtk.Window
{
	Gtk.ListStore CashIncomeListStore;
	Gtk.TreeModelFilter CashIncomeFilter;
	Gtk.ListStore CashExpenseListStore;
	Gtk.TreeModelFilter CashExpenseFilter;
	Gtk.ListStore CashAdvanceListStore;
	Gtk.TreeModelFilter CashAdvanceFilter;

	void PrepareCash()
	{
		//Заполняем комбобокс
		ComboWorks.ComboFillReference(comboCashOrg, "organizations", 1);
		ComboWorks.ComboFillReference(comboCashCash,"cash",1);
		
		//Создаем таблицу "Приходных ордеров"
		CashIncomeListStore = new Gtk.ListStore (typeof (int), // 0-id
		                                         typeof (string), // 1-date
		                                         typeof (int), // 2 - id cash
		                                         typeof (string), // 3 - cash
		                                         typeof (int), // 4 - id org
		                                         typeof (string), // 5 - org
		                                         typeof (int), // 6 - lessee id
		                                         typeof (string), // 7 - lessee
		                                         typeof (int), // 8 - id employer
		                                         typeof (string), // 9 - employer 
		                                         typeof (int), // 10 - id income
		                                         typeof (string), // 11 - income
		                                         typeof (string), // 12 - text sum
		                                         typeof (decimal), // 13 - sum
		                                         typeof (decimal),  // 14 - income sum
		                                         typeof (string)   //15 - operation
		                                         );
		
		treeviewIncome.AppendColumn("Номер", new Gtk.CellRendererText (), "text", 0);
		treeviewIncome.AppendColumn("Дата", new Gtk.CellRendererText (), "text", 1);
		//ID кассы - 2
		treeviewIncome.AppendColumn("Касса", new Gtk.CellRendererText (), "text", 3);
		//ID Организации - 4
		treeviewIncome.AppendColumn("Организация", new Gtk.CellRendererText (), "text", 5);
		//ID Арендатора - 6
		treeviewIncome.AppendColumn("Арендатор", new Gtk.CellRendererText (), "text", 7);
		//ID Сотрудника - 8
		treeviewIncome.AppendColumn("Сотрудник", new Gtk.CellRendererText (), "text", 9);
		//ID Статьи дохода - 10
		treeviewIncome.AppendColumn("Статья дохода", new Gtk.CellRendererText (), "text", 11);
		treeviewIncome.AppendColumn("Сумма", new Gtk.CellRendererText (), "text", 12);

		CashIncomeFilter = new Gtk.TreeModelFilter (CashIncomeListStore, null);
		CashIncomeFilter.VisibleFunc = new Gtk.TreeModelFilterVisibleFunc (FilterTreeIncome);
		treeviewIncome.Model = CashIncomeFilter;
		treeviewIncome.ShowAll();

		//Создаем таблицу "Расходных ордеров"
		CashExpenseListStore = new Gtk.ListStore (typeof (int), typeof (string), typeof (int), typeof (string), typeof (int), typeof (string),
		                                          typeof (int), typeof (string), typeof (int), typeof (string), typeof (int), typeof (string), typeof (string), typeof (decimal));
		
		treeviewExpense.AppendColumn("Номер", new Gtk.CellRendererText (), "text", 0);
		treeviewExpense.AppendColumn("Дата", new Gtk.CellRendererText (), "text", 1);
		//ID кассы - 2
		treeviewExpense.AppendColumn("Касса", new Gtk.CellRendererText (), "text", 3);
		//ID Организации - 4
		treeviewExpense.AppendColumn("Организация", new Gtk.CellRendererText (), "text", 5);
		//ID Контрагента - 6
		treeviewExpense.AppendColumn("Контрагент", new Gtk.CellRendererText (), "text", 7);
		//ID Сотрудника - 8
		treeviewExpense.AppendColumn("Сотрудник", new Gtk.CellRendererText (), "text", 9);
		//ID Статьи расхода -10
		treeviewExpense.AppendColumn("Статья расхода", new Gtk.CellRendererText (), "text", 11);
		treeviewExpense.AppendColumn("Сумма", new Gtk.CellRendererText (), "text", 12);
		
		CashExpenseFilter = new Gtk.TreeModelFilter (CashExpenseListStore, null);
		CashExpenseFilter.VisibleFunc = new Gtk.TreeModelFilterVisibleFunc (FilterTreeExpense);
		treeviewExpense.Model = CashExpenseFilter;
		treeviewExpense.ShowAll();

		//Создаем таблицу "Авансовых отчетов"
		CashAdvanceListStore = new Gtk.ListStore (typeof (int), typeof (string), typeof (int), typeof (string), typeof (int), typeof (string),
		                                          typeof (int), typeof (string), typeof (int), typeof (string), typeof (int), typeof (string), typeof (string), typeof (decimal));
		
		treeviewAdvance.AppendColumn("Номер", new Gtk.CellRendererText (), "text", 0);
		treeviewAdvance.AppendColumn("Дата", new Gtk.CellRendererText (), "text", 1);
		//ID Кассы - 2
		treeviewAdvance.AppendColumn("Касса", new Gtk.CellRendererText (), "text", 3);
		//ID Организации - 4
		treeviewAdvance.AppendColumn("Организация", new Gtk.CellRendererText (), "text", 5);
		//ID Контрагента - 6
		treeviewAdvance.AppendColumn("Контрагент", new Gtk.CellRendererText (), "text", 7);
		//ID Сотрудника - 8
		treeviewAdvance.AppendColumn("Сотрудник", new Gtk.CellRendererText (), "text", 9);
		//ID Статьи расхода - 10
		treeviewAdvance.AppendColumn("Статья расхода", new Gtk.CellRendererText (), "text", 11);
		treeviewAdvance.AppendColumn("Сумма", new Gtk.CellRendererText (), "text", 12);
		
		CashAdvanceFilter = new Gtk.TreeModelFilter (CashAdvanceListStore, null);
		CashAdvanceFilter.VisibleFunc = new Gtk.TreeModelFilterVisibleFunc (FilterTreeAdvance);
		treeviewAdvance.Model = CashAdvanceFilter;
		treeviewAdvance.ShowAll();

		radioCashWeek.Click();
		OnNotebook1SwitchPage (null, null);
	}

	protected void OnRadioCashTodayClicked (object sender, EventArgs e)
	{
		dateCashStart.Date = DateTime.Now.Date;
		dateCashEnd.Date = DateTime.Now.Date;
	}
	
	protected void OnRadioCashWeekClicked (object sender, EventArgs e)
	{
		dateCashStart.Date = DateTime.Now.AddDays(-7);
		dateCashEnd.Date = DateTime.Now.Date;
	}
	
	protected void OnRadioMonthClicked (object sender, EventArgs e)
	{
		dateCashStart.Date = DateTime.Now.AddDays(-30);
		dateCashEnd.Date = DateTime.Now.Date;
	}
	
	protected void OnRadioCash6MonthClicked (object sender, EventArgs e)
	{
		dateCashStart.Date = DateTime.Now.AddDays(-183);
		dateCashEnd.Date = DateTime.Now.Date;
	}

	private bool FilterTreeIncome (Gtk.TreeModel model, Gtk.TreeIter iter)
	{
		if (entryCashContractor.Text == "" && entryCashEmployee.Text == "")
			return true;
		bool filterContractor = true;
		bool filterEmployee = true;		
		string cellvalue;
		
		if(model.GetValue (iter, 7) == null)
			return false;
		
		if (entryCashContractor.Text != "" && model.GetValue (iter, 7) != null)
		{
			cellvalue  = model.GetValue (iter, 7).ToString();
			filterContractor = cellvalue.IndexOf (entryCashContractor.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}
		if (entryCashEmployee.Text != "" && model.GetValue (iter, 9) != null)
		{
			cellvalue  = model.GetValue (iter, 9).ToString();
			filterEmployee = cellvalue.IndexOf (entryCashEmployee.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}
		
		return (filterContractor && filterEmployee);

	}

	private bool FilterTreeExpense (Gtk.TreeModel model, Gtk.TreeIter iter)
	{
		if (entryCashContractor.Text == "" && entryCashEmployee.Text == "")
			return true;
		bool filterContractor = true;
		bool filterEmployee = true;		
		string cellvalue;
		
		if(model.GetValue (iter, 7) == null)
			return false;
		
		if (entryCashContractor.Text != "" && model.GetValue (iter, 7) != null)
		{
			cellvalue  = model.GetValue (iter, 7).ToString();
			filterContractor = cellvalue.IndexOf (entryCashContractor.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}
		if (entryCashEmployee.Text != "" && model.GetValue (iter, 9) != null)
		{
			cellvalue  = model.GetValue (iter, 9).ToString();
			filterEmployee = cellvalue.IndexOf (entryCashEmployee.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}
		
		return (filterContractor && filterEmployee);
	}

	private bool FilterTreeAdvance (Gtk.TreeModel model, Gtk.TreeIter iter)
	{
		if (entryCashContractor.Text == "" && entryCashEmployee.Text == "")
			return true;
		bool filterContractor = true;
		bool filterEmployee = true;		
		string cellvalue;
		
		if(model.GetValue (iter, 7) == null)
			return false;

		if (entryCashContractor.Text != "" && model.GetValue (iter, 7) != null)
		{
			cellvalue  = model.GetValue (iter, 7).ToString();
			filterContractor = cellvalue.IndexOf (entryCashContractor.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}
		if (entryCashEmployee.Text != "" && model.GetValue (iter, 9) != null)
		{
			cellvalue  = model.GetValue (iter, 9).ToString();
			filterEmployee = cellvalue.IndexOf (entryCashEmployee.Text, StringComparison.CurrentCultureIgnoreCase) > -1;
		}

		return (filterContractor && filterEmployee);
	}

	protected void OnNotebook1SwitchPage (object o, SwitchPageArgs args)
	{
		comboCashItem.Clear ();
		switch (notebookCash.CurrentPage) {
		case 0:
			ComboWorks.ComboFillReference(comboCashItem,"income_items",1);
			break;
		case 1:
			ComboWorks.ComboFillReference(comboCashItem,"expense_items",1);
			break;
		case 2:
			ComboWorks.ComboFillReference(comboCashItem,"expense_items",1);
			break;
		default:
			break;
		}
		UpdateCash ();
	}

	void UpdateCashIncome()
	{
		MainClass.StatusMessage("Получаем таблицу приходных ордеров...");

		TreeIter iter;

		string sqlpayments1 = " NULL as item_sum ";
		string sqlpayments2 = "";
		if(comboCashItem.GetActiveIter(out iter) && comboCashItem.Active != 0)
		{
			sqlpayments2 = "LEFT JOIN payments ON payments.credit_slip_id = credit_slips.id " +
				"LEFT JOIN (SELECT payment_id, SUM(sum) as income_sum FROM payment_details WHERE income_id = '" +
					comboCashItem.Model.GetValue(iter,1) + "' GROUP BY payment_id) as payment_sum ON " +
					"payment_sum.payment_id = payments.id ";
			sqlpayments1 = " payment_sum.income_sum as item_sum ";
		}

		string sql = "SELECT credit_slips.*, cash.name as cash, lessees.name as lessee, " +
			"income_items.name as income_item,  organizations.name as organization, employees.name as employee, " +
				sqlpayments1 +
			"FROM credit_slips " +
				sqlpayments2 +
			"LEFT JOIN cash ON credit_slips.cash_id = cash.id " +
			"LEFT JOIN lessees ON credit_slips.lessee_id = lessees.id " +
			"LEFT JOIN organizations ON credit_slips.org_id = organizations.id " +
			"LEFT JOIN income_items ON credit_slips.income_id = income_items.id " +
			"LEFT JOIN employees ON credit_slips.employee_id = employees.id " +
			"WHERE credit_slips.date BETWEEN @start AND @end";
		if(comboCashCash.GetActiveIter(out iter) && comboCashCash.Active != 0)
		{
			sql += " AND credit_slips.cash_id = '" + comboCashCash.Model.GetValue(iter,1) + "'";
		}
		if(comboCashOrg.GetActiveIter(out iter) && comboCashOrg.Active != 0)
		{
			sql += " AND credit_slips.org_id = '" + comboCashOrg.Model.GetValue(iter,1) + "'";
		}
		if(comboCashItem.GetActiveIter(out iter) && comboCashItem.Active != 0)
		{
			sql += " AND ( credit_slips.income_id = '" + comboCashItem.Model.GetValue(iter,1) + "' OR " +
				" payment_sum.income_sum IS NOT NULL)";
		}

		MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
		cmd.Parameters.AddWithValue("@start", dateCashStart.Date);
		cmd.Parameters.AddWithValue("@end", dateCashEnd.Date);
		
		MySqlDataReader rdr = cmd.ExecuteReader();

		CashIncomeListStore.Clear();
		while (rdr.Read())
		{
			decimal item_sum = 0;
			int lessee_id = 0;
			int employee_id = 0;
			string SumFormat = "{0:C}";
			if(rdr["lessee_id"] != DBNull.Value)
				lessee_id = int.Parse (rdr["lessee_id"].ToString ());
			if(rdr["employee_id"] != DBNull.Value)
				employee_id = rdr.GetInt32("employee_id");
			if(rdr["item_sum"] != DBNull.Value)
			{
				item_sum = rdr.GetDecimal("item_sum");
				SumFormat = "{0:C} ({1:C})";
			}
			CashIncomeListStore.AppendValues(int.Parse (rdr["id"].ToString()),
			                               DateTime.Parse(rdr["date"].ToString()).ToShortDateString(),
			                               int.Parse(rdr["cash_id"].ToString ()),
			                               rdr["cash"].ToString (),
			                               int.Parse (rdr["org_id"].ToString ()),
			                               rdr["organization"].ToString(),
			                               lessee_id,
			                               rdr["lessee"].ToString(),
			                               employee_id,
			                               rdr["employee"].ToString (),
			                               0,
			                               rdr["income_item"].ToString(),
			                               String.Format (SumFormat, rdr.GetDecimal ("sum"), item_sum),
			                               rdr.GetDecimal ("sum"),
			                                 item_sum,
			                                 rdr["operation"].ToString());
		}
		rdr.Close();
		
		MainClass.StatusMessage("Ok");
		
		bool isSelect = treeviewIncome.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
		CalculateCashSum ();
	}

	void UpdateCashExpense()
	{
		MainClass.StatusMessage("Получаем таблицу расходных ордеров...");
		
		TreeIter iter;
		
		string sql = "SELECT debit_slips.*, cash.name as cash, contractors.name as contractor, " +
			"expense_items.name as expense_item,  organizations.name as organization, " +
			"employees.name as employee FROM debit_slips " +
				"LEFT JOIN cash ON debit_slips.cash_id = cash.id " +
				"LEFT JOIN contractors ON debit_slips.contractor_id = contractors.id " +
				"LEFT JOIN organizations ON debit_slips.org_id = organizations.id " +
				"LEFT JOIN expense_items ON debit_slips.expense_id = expense_items.id " +
				"LEFT JOIN employees ON debit_slips.employee_id = employees.id " +
				"WHERE debit_slips.date BETWEEN @start AND @end";
		if(comboCashCash.GetActiveIter(out iter) && comboCashCash.Active != 0)
		{
			sql += " AND debit_slips.cash_id = '" + comboCashCash.Model.GetValue(iter,1) + "'";
		}
		if(comboCashOrg.GetActiveIter(out iter) && comboCashOrg.Active != 0)
		{
			sql += " AND debit_slips.org_id = '" + comboCashOrg.Model.GetValue(iter,1) + "'";
		}
		if(comboCashItem.GetActiveIter(out iter) && comboCashItem.Active != 0)
		{
			sql += " AND debit_slips.expense_id = '" + comboCashItem.Model.GetValue(iter,1) + "'";
		}
		
		MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
		cmd.Parameters.AddWithValue("@start", dateCashStart.Date);
		cmd.Parameters.AddWithValue("@end", dateCashEnd.Date);
		
		MySqlDataReader rdr = cmd.ExecuteReader();
		
		CashExpenseListStore.Clear();
		while (rdr.Read())
		{
			int contractor_id = 0;
			int employee_id = 0;
			if(rdr["contractor_id"] != DBNull.Value)
				contractor_id = int.Parse (rdr["contractor_id"].ToString ());
			if(rdr["employee_id"] != DBNull.Value)
				employee_id = rdr.GetInt32("employee_id");
			CashExpenseListStore.AppendValues(int.Parse (rdr["id"].ToString()),
			                                 DateTime.Parse(rdr["date"].ToString()).ToShortDateString(),
			                                 int.Parse(rdr["cash_id"].ToString ()),
			                                 rdr["cash"].ToString (),
			                                 int.Parse (rdr["org_id"].ToString ()),
			                                 rdr["organization"].ToString(),
			                                 contractor_id,
			                                 rdr["contractor"].ToString(),
			                                 employee_id,
			                                 rdr["employee"].ToString (),			                               
			                                 0,
			                                 rdr["expense_item"].ToString(),
			                                 String.Format ("{0:C}",rdr.GetDecimal ("sum")),
			                                 rdr.GetDecimal ("sum"));
		}
		rdr.Close();
		
		MainClass.StatusMessage("Ok");
		
		bool isSelect = treeviewExpense.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
		CalculateCashSum ();
	}

	void UpdateCashAdvance()
	{
		MainClass.StatusMessage("Получаем таблицу авансовых отчетов...");
		
		TreeIter iter;
		
		string sql = "SELECT advance.*, cash.name as cash, contractors.name as contractor, " +
			"expense_items.name as expense_item,  organizations.name as organization, " +
				"employees.name as employee FROM advance " +
				"LEFT JOIN cash ON advance.cash_id = cash.id " +
				"LEFT JOIN contractors ON advance.contractor_id = contractors.id " +
				"LEFT JOIN organizations ON advance.org_id = organizations.id " +
				"LEFT JOIN expense_items ON advance.expense_id = expense_items.id " +
				"LEFT JOIN employees ON advance.employee_id = employees.id " +
				"WHERE advance.date BETWEEN @start AND @end";
		if(comboCashCash.GetActiveIter(out iter) && comboCashCash.Active != 0)
		{
			sql += " AND advance.cash_id = '" + comboCashCash.Model.GetValue(iter,1) + "'";
		}
		if(comboCashOrg.GetActiveIter(out iter) && comboCashOrg.Active != 0)
		{
			sql += " AND advance.org_id = '" + comboCashOrg.Model.GetValue(iter,1) + "'";
		}
		if(comboCashItem.GetActiveIter(out iter) && comboCashItem.Active != 0)
		{
			sql += " AND advance.expense_id = '" + comboCashItem.Model.GetValue(iter,1) + "'";
		}
		
		MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);
		cmd.Parameters.AddWithValue("@start", dateCashStart.Date);
		cmd.Parameters.AddWithValue("@end", dateCashEnd.Date);
		
		MySqlDataReader rdr = cmd.ExecuteReader();
		
		CashAdvanceListStore.Clear();
		while (rdr.Read())
		{
			int contractor_id = 0;
			int employee_id = 0;
			if(rdr["contractor_id"] != DBNull.Value)
				contractor_id = int.Parse (rdr["contractor_id"].ToString ());
			if(rdr["employee_id"] != DBNull.Value)
				employee_id = rdr.GetInt32("employee_id");
			CashAdvanceListStore.AppendValues(int.Parse (rdr["id"].ToString()),
			                                  DateTime.Parse(rdr["date"].ToString()).ToShortDateString(),
			                                  int.Parse(rdr["cash_id"].ToString ()),
			                                  rdr["cash"].ToString (),
			                                  int.Parse (rdr["org_id"].ToString ()),
			                                  rdr["organization"].ToString(),
			                                  contractor_id,
			                                  rdr["contractor"].ToString(),
			                                  employee_id,
			                                  rdr["employee"].ToString (),
			                                  0,
			                                  rdr["expense_item"].ToString(),
			                                  String.Format ("{0:C}",rdr.GetDecimal ("sum")),
			                                  rdr.GetDecimal ("sum"));
		}
		rdr.Close();
		
		MainClass.StatusMessage("Ok");
		
		bool isSelect = treeviewAdvance.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
		CalculateCashSum ();
	}

	public void UpdateCash()
	{
		if(notebookMain.CurrentPage != 4)
			return;
		switch (notebookCash.CurrentPage) {
		case 0:
			UpdateCashIncome();
			break;
		case 1:
			UpdateCashExpense();
			break;
		case 2:
			UpdateCashAdvance();
			break;
		}
	}

	protected void OnComboCashOrgChanged (object sender, EventArgs e)
	{
		UpdateCash ();
		CalculateTotalCash ();
	}
	
	protected void OnComboCashCashChanged (object sender, EventArgs e)
	{
		UpdateCash ();
		CalculateTotalCash();
	}
	
	protected void OnComboCashItemChanged (object sender, EventArgs e)
	{
		UpdateCash ();
	}
	
	protected void OnDateCashStartDateChanged (object sender, EventArgs e)
	{
		UpdateCash ();
	}
	
	protected void OnDateCashEndDateChanged (object sender, EventArgs e)
	{
		UpdateCash ();
	}

	protected void OnEntryCashContractorChanged (object sender, EventArgs e)
	{
		RefilterCashTables ();
	}

	protected void RefilterCashTables()
	{
		switch (notebookCash.CurrentPage) {
		case 0:
			CashIncomeFilter.Refilter ();
			break;
		case 1:
			CashExpenseFilter.Refilter();
			break;
		case 2:
			CashAdvanceFilter.Refilter ();
			break;
		}
		CalculateCashSum ();
	}

	protected void OnTreeviewIncomeCursorChanged (object sender, EventArgs e)
	{
		bool isSelect = treeviewIncome.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
	}

	protected void OnTreeviewExpenseCursorChanged (object sender, EventArgs e)
	{
		bool isSelect = treeviewExpense.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
	}

	protected void OnTreeviewAdvanceCursorChanged (object sender, EventArgs e)
	{
		bool isSelect = treeviewAdvance.Selection.CountSelectedRows() == 1;
		buttonOpen.Sensitive = isSelect;
		if(QSMain.User.Permissions["edit_slips"])
			buttonDel.Sensitive = isSelect;
		else
			buttonDel.Sensitive = false;
	}
	
	protected void OnTreeviewIncomeRowActivated (object o, RowActivatedArgs args)
	{
		OnButtonViewClicked(o,EventArgs.Empty);
	}

	protected void OnTreeviewExpenseRowActivated (object o, RowActivatedArgs args)
	{
		OnButtonViewClicked(o,EventArgs.Empty);
	}

	protected void OnTreeviewAdvanceRowActivated (object o, RowActivatedArgs args)
	{
		OnButtonViewClicked(o,EventArgs.Empty);
	}

	protected void CalculateCashSum ()
	{
		decimal Sum = 0;
		TreeIter iter;
		TreeModelFilter Model;

		switch (notebookCash.CurrentPage)
		{
		case 0:
			Model = CashIncomeFilter;
			break;
		case 1:
			Model = CashExpenseFilter;
			break;
		case 2:
			Model = CashAdvanceFilter;
			break;
		default:
			return;
		}
		if(Model.GetIterFirst(out iter))
		{
			Sum = (decimal)Model.GetValue(iter,13);
			while (Model.IterNext(ref iter)) 
			{
				Sum += (decimal)Model.GetValue(iter,13);
			}
		}
		labelSum.LabelProp = String.Format("Сумма документов: {0:C} ", Sum);
	}

	protected void CalculateTotalCash()
	{
		TreeIter iter;
		decimal SumIncome, SumExpense;

		if(comboCashOrg.Active > 0)
			labelCashSumOrg.LabelProp = comboCashOrg.ActiveText;
		else
			labelCashSumOrg.LabelProp = "Все организации";
		if(comboCashCash.Active > 0)
			labelCashSumCash.LabelProp = comboCashCash.ActiveText;
		else
			labelCashSumCash.LabelProp = "Все кассы";

		string sql = "SELECT SUM(credit_slips.sum) as total FROM credit_slips ";
		string sqlorg = "org_id = @org_id";
		string sqlcash = "cash_id = @cash_id";
		string sqlwhere = "";

		if(comboCashOrg.Active > 0 || comboCashCash.Active > 0)
		{
			sqlwhere += "WHERE ";
			if(comboCashOrg.Active > 0)
			{
				sqlwhere += sqlorg;
				if(comboCashCash.Active > 0)
					sqlwhere += " AND " + sqlcash;
			}
			else
				sqlwhere += sqlcash;
		}

		sql += sqlwhere;

		MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);

		if(comboCashOrg.GetActiveIter (out iter) && comboCashOrg.Active > 0)
			cmd.Parameters.AddWithValue("@org_id", comboCashOrg.Model.GetValue(iter,1));
		if(comboCashCash.GetActiveIter (out iter) && comboCashCash.Active > 0)
			cmd.Parameters.AddWithValue("@cash_id", comboCashCash.Model.GetValue(iter,1));

		MySqlDataReader rdr = cmd.ExecuteReader();
		if(rdr.Read () && rdr["total"] != DBNull.Value)
			SumIncome = rdr.GetDecimal("total");
		else
			SumIncome = 0m;
		rdr.Close ();

		sql = "SELECT SUM(debit_slips.sum) as total FROM debit_slips " + sqlwhere;
		cmd = new MySqlCommand(sql, QSMain.connectionDB);
		if(comboCashOrg.GetActiveIter (out iter) && comboCashOrg.Active > 0)
			cmd.Parameters.AddWithValue("@org_id", comboCashOrg.Model.GetValue(iter,1));
		if(comboCashCash.GetActiveIter (out iter) && comboCashCash.Active > 0)
			cmd.Parameters.AddWithValue("@cash_id", comboCashCash.Model.GetValue(iter,1));
		rdr = cmd.ExecuteReader();
		if(rdr.Read () && rdr["total"] != DBNull.Value)
			SumExpense = rdr.GetDecimal("total");
		else 
			SumExpense = 0m;
		rdr.Close ();

		decimal TotalCash = SumIncome - SumExpense;
		labelCashSum.LabelProp = String.Format("<big>{0:C}</big>", TotalCash);
	}

	protected void OnEntryEmployeeChanged (object sender, EventArgs e)
	{
		RefilterCashTables ();
	}

	protected void OnButtonCashDebtsClicked (object sender, EventArgs e)
	{
		AccountableDebts WinDebts = new AccountableDebts();
		WinDebts.ShowAll ();
		WinDebts.Run ();
		WinDebts.Destroy ();
	}
	
	protected void OnButtonCashBalanceClicked (object sender, EventArgs e)
	{
		CashBalance winBalance = new CashBalance();
		winBalance.Show();
		winBalance.Run();
		winBalance.Destroy();
	}

	protected void OnButtonCashEmployeeClearClicked (object sender, EventArgs e)
	{
		entryCashEmployee.Text = "";
	}
	
	protected void OnButtonCashContractorClearClicked (object sender, EventArgs e)
	{
		entryCashContractor.Text = "";
	}

	protected virtual void ExpenseCopy (object o, EventArgs args)
	{
		TreeIter iter;
		treeviewExpense.Selection.GetSelected(out iter);
		int itemid = Convert.ToInt32(CashExpenseFilter.GetValue(iter,0));

		ExpenseSlip winExpenseSlip = new ExpenseSlip();
		winExpenseSlip.SlipFill(itemid, true);
		winExpenseSlip.Show();
		winExpenseSlip.Run();
		winExpenseSlip.Destroy();
		UpdateCashExpense();
		CalculateTotalCash();
	}

	[GLib.ConnectBefore]
	protected void OnTreeviewExpenseButtonReleaseEvent (object o, ButtonReleaseEventArgs args)
	{
		bool ItemSelected = treeviewExpense.Selection.CountSelectedRows() == 1;

		if((int)args.Event.Button == 3)
		{
			Gtk.Menu popupBox = new Gtk.Menu();
			Gtk.MenuItem MenuItem = new MenuItem("Создать копированием");
			MenuItem.Activated += new EventHandler(ExpenseCopy);
			MenuItem.Sensitive = ItemSelected;
			popupBox.Add(MenuItem);                     
			popupBox.ShowAll();
			popupBox.Popup();
		}
	}

	[GLib.ConnectBefore]
	protected void OnTreeviewIncomeButtonReleaseEvent (object o, ButtonReleaseEventArgs args)
	{
		bool ItemSelected = treeviewIncome.Selection.CountSelectedRows() == 1;

		TreeIter iter;
		if(treeviewIncome.Selection.GetSelected(out iter) && CashIncomeFilter.GetValue(iter,15).ToString() == "payment")
			ItemSelected=false;

		if((int)args.Event.Button == 3)
		{
			Gtk.Menu popupBox = new Gtk.Menu();
			Gtk.MenuItem MenuItem = new MenuItem("Создать копированием");
			MenuItem.Activated += new EventHandler(IncomeCopy);
			MenuItem.Sensitive = ItemSelected;
			popupBox.Add(MenuItem);                     
			popupBox.ShowAll();
			popupBox.Popup();
		}
	}

	protected virtual void IncomeCopy (object o, EventArgs args)
	{
		TreeIter iter;
		treeviewIncome.Selection.GetSelected(out iter);
		int itemid = Convert.ToInt32(CashIncomeFilter.GetValue(iter,0));
		IncomeSlip winIncomeSlip = new IncomeSlip();
		winIncomeSlip.SlipFill(itemid, true);
		winIncomeSlip.Show();
		winIncomeSlip.Run();
		winIncomeSlip.Destroy();
		UpdateCashIncome();
		CalculateTotalCash();
	}	

	[GLib.ConnectBefore]
	protected void OnTreeviewAdvanceButtonReleaseEvent (object o, ButtonReleaseEventArgs args)
	{
		bool ItemSelected = treeviewAdvance.Selection.CountSelectedRows() == 1;

		if((int)args.Event.Button == 3)
		{
			Gtk.Menu popupBox = new Gtk.Menu();
			Gtk.MenuItem MenuItem = new MenuItem("Создать копированием");
			MenuItem.Activated += new EventHandler(AdvanceCopy);
			MenuItem.Sensitive = ItemSelected;
			popupBox.Add(MenuItem);                     
			popupBox.ShowAll();
			popupBox.Popup();
		}
	}

	protected virtual void AdvanceCopy (object o, EventArgs args)
	{
		TreeIter iter;
		treeviewAdvance.Selection.GetSelected(out iter);
		int itemid = Convert.ToInt32(CashAdvanceFilter.GetValue(iter,0));

		AdvanceStatement winAdvance = new AdvanceStatement();
		winAdvance.StatementFill(itemid, true);
		winAdvance.Show();
		winAdvance.Run();
		winAdvance.Destroy();
		UpdateCashAdvance();
	}
}
