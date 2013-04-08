
// This file has been generated by the GUI designer. Do not modify.
namespace bazar
{
	public partial class DocRegister
	{
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboDoc;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox11;
		private global::Gtk.Label label31;
		private global::Gtk.RadioButton radioCashToday;
		private global::Gtk.RadioButton radioCashWeek;
		private global::Gtk.RadioButton radioMonth;
		private global::Gtk.RadioButton radioCash6Month;
		private global::Gtk.HBox hbox15;
		private global::WidgetLib.DatePicker dateCashStart;
		private global::Gtk.Label label32;
		private global::WidgetLib.DatePicker dateCashEnd;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget bazar.DocRegister
			this.Name = "bazar.DocRegister";
			this.Title = "Реестр документов";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child bazar.DocRegister.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboDoc = global::Gtk.ComboBox.NewText ();
			this.comboDoc.AppendText ("Приходный ордер");
			this.comboDoc.AppendText ("Расходный ордер");
			this.comboDoc.Name = "comboDoc";
			this.table1.Add (this.comboDoc);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboDoc]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = "Документ:";
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w4.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox ();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			this.vbox11.BorderWidth = ((uint)(6));
			// Container child vbox11.Gtk.Box+BoxChild
			this.label31 = new global::Gtk.Label ();
			this.label31.Name = "label31";
			this.label31.LabelProp = "<b>Выбор периода</b>";
			this.label31.UseMarkup = true;
			this.vbox11.Add (this.label31);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.label31]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.radioCashToday = new global::Gtk.RadioButton ("Сегодня");
			this.radioCashToday.CanFocus = true;
			this.radioCashToday.Name = "radioCashToday";
			this.radioCashToday.DrawIndicator = true;
			this.radioCashToday.UseUnderline = true;
			this.radioCashToday.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox11.Add (this.radioCashToday);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.radioCashToday]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.radioCashWeek = new global::Gtk.RadioButton ("За неделю");
			this.radioCashWeek.CanFocus = true;
			this.radioCashWeek.Name = "radioCashWeek";
			this.radioCashWeek.DrawIndicator = true;
			this.radioCashWeek.UseUnderline = true;
			this.radioCashWeek.Group = this.radioCashToday.Group;
			this.vbox11.Add (this.radioCashWeek);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.radioCashWeek]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.radioMonth = new global::Gtk.RadioButton ("За месяц");
			this.radioMonth.CanFocus = true;
			this.radioMonth.Name = "radioMonth";
			this.radioMonth.DrawIndicator = true;
			this.radioMonth.UseUnderline = true;
			this.radioMonth.Group = this.radioCashToday.Group;
			this.vbox11.Add (this.radioMonth);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.radioMonth]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.radioCash6Month = new global::Gtk.RadioButton ("За полгода");
			this.radioCash6Month.CanFocus = true;
			this.radioCash6Month.Name = "radioCash6Month";
			this.radioCash6Month.DrawIndicator = true;
			this.radioCash6Month.UseUnderline = true;
			this.radioCash6Month.Group = this.radioCashToday.Group;
			this.vbox11.Add (this.radioCash6Month);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.radioCash6Month]));
			w9.Position = 4;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.dateCashStart = new global::WidgetLib.DatePicker ();
			this.dateCashStart.Events = ((global::Gdk.EventMask)(256));
			this.dateCashStart.Name = "dateCashStart";
			this.dateCashStart.Date = new global::System.DateTime (0);
			this.hbox15.Add (this.dateCashStart);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.dateCashStart]));
			w10.Position = 0;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.LabelProp = "-";
			this.hbox15.Add (this.label32);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label32]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.dateCashEnd = new global::WidgetLib.DatePicker ();
			this.dateCashEnd.Events = ((global::Gdk.EventMask)(256));
			this.dateCashEnd.Name = "dateCashEnd";
			this.dateCashEnd.Date = new global::System.DateTime (0);
			this.hbox15.Add (this.dateCashEnd);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.dateCashEnd]));
			w12.Position = 2;
			this.vbox11.Add (this.hbox15);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox15]));
			w13.Position = 5;
			w13.Expand = false;
			w13.Fill = false;
			w1.Add (this.vbox11);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox11]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Internal child bazar.DocRegister.ActionArea
			global::Gtk.HButtonBox w15 = this.ActionArea;
			w15.Name = "dialog1_ActionArea";
			w15.Spacing = 10;
			w15.BorderWidth = ((uint)(5));
			w15.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonCancel]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15 [this.buttonOk]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 381;
			this.DefaultHeight = 304;
			this.Show ();
			this.radioCashToday.Clicked += new global::System.EventHandler (this.OnRadioCashTodayClicked);
			this.radioCashWeek.Clicked += new global::System.EventHandler (this.OnRadioCashWeekClicked);
			this.radioMonth.Clicked += new global::System.EventHandler (this.OnRadioMonthClicked);
			this.radioCash6Month.Clicked += new global::System.EventHandler (this.OnRadioCash6MonthClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}