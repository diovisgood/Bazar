using System;
using Gtk;
using MySql.Data.MySqlClient;
using QSProjectsLib;

namespace bazar
{
	public partial class MeterReading : Gtk.Dialog
	{
		int MeterId;

		public MeterReading (int MeterID)
		{
			this.Build ();

			MeterId = MeterID;
			dateReading.Date = DateTime.Today;

			//Fill combo
			ListStore store = new ListStore (typeof (string), // 0- name
			                                 typeof (int), // 1 - id
			                                 typeof(string) // 2 - units
			                                 );
			CellRendererText text = new CellRendererText ();
			comboTariff.Model = store;
			comboTariff.PackStart (text, false);
			comboTariff.AddAttribute (text, "text", 0);
			try
			{
				string SqlSelect = "SELECT meter_tariffs.id, meter_tariffs.name, units.name as unit FROM meter_tariffs " +
					"LEFT JOIN services ON services.id = meter_tariffs.service_id " +
					"LEFT JOIN units ON units.id = services.units_id " +
					"WHERE meter_type_id = (" +
					"SELECT meter_type_id FROM meters WHERE id = @id)";
				MySqlCommand cmd = new MySqlCommand(SqlSelect, QSMain.connectionDB);
				cmd.Parameters.AddWithValue("@id", MeterID);
				using(MySqlDataReader rdr = cmd.ExecuteReader())
				{
					while (rdr.Read())
					{
						store.AppendValues(String.Format("{0}", rdr["name"]),
						                   rdr.GetInt32 ("id"),
						                   rdr["unit"].ToString ());
					}
				}
				comboTariff.Active = 0;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка получения тарифов счётчика!");
				QSMain.ErrorMessage(this, ex);
			}

		}

		protected void OnComboTariffChanged(object sender, EventArgs e)
		{
			TreeIter iter;
			comboTariff.GetActiveIter (out iter);
			labelUnits.LabelProp = comboTariff.Model.GetValue (iter, 2).ToString ();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			string sql;
			sql = "INSERT INTO meter_reading (meter_id, meter_tariff_id, date, value) " +
				"VALUES (@meter_id, @meter_tariff_id, @date, @value)";
			MainClass.StatusMessage("Запись показаний счётчика...");
			try 
			{
				MySqlCommand cmd = new MySqlCommand(sql, QSMain.connectionDB);

				cmd.Parameters.AddWithValue("@meter_id", MeterId);
				cmd.Parameters.AddWithValue("@meter_tariff_id", ComboWorks.GetActiveId (comboTariff));
				cmd.Parameters.AddWithValue("@date", dateReading.Date);
				cmd.Parameters.AddWithValue("@value", spinValue.ValueAsInt);

				cmd.ExecuteNonQuery();
				MainClass.StatusMessage("Ok");
				Respond (Gtk.ResponseType.Ok);
			} 
			catch (Exception ex) 
			{
				Console.WriteLine(ex.ToString());
				MainClass.StatusMessage("Ошибка записи показаний счётчика!");
				QSMain.ErrorMessage(this,ex);
			}
		}
	}
}

