
// This file has been generated by the GUI designer. Do not modify.
namespace bazar
{
	public partial class AccountableSlips
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboCash;
		private global::Gtk.ComboBox comboOrg;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Entry entryAccountable;
		private global::Gtk.Button buttonAccountableEdit;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.VBox vbox11;
		private global::Gtk.Label label31;
		private global::Gtk.Table table4;
		private global::Gtk.RadioButton radio3month;
		private global::Gtk.RadioButton radioAll;
		private global::Gtk.RadioButton radioMonth;
		private global::Gtk.RadioButton radioYear;
		private global::Gtk.HBox hbox15;
		private global::QSWidgetLib.DatePicker dateCashStart;
		private global::Gtk.Label label32;
		private global::QSWidgetLib.DatePicker dateCashEnd;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewSlips;
		private global::Gtk.Button buttonClose;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget bazar.AccountableSlips
			this.Name = "bazar.AccountableSlips";
			this.Title = "Движения по подотчетному лицу";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child bazar.AccountableSlips.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboCash = new global::Gtk.ComboBox ();
			this.comboCash.Name = "comboCash";
			this.table1.Add (this.comboCash);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboCash]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboOrg = new global::Gtk.ComboBox ();
			this.comboOrg.Name = "comboOrg";
			this.table1.Add (this.comboOrg);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboOrg]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryAccountable = new global::Gtk.Entry ();
			this.entryAccountable.CanFocus = true;
			this.entryAccountable.Name = "entryAccountable";
			this.entryAccountable.IsEditable = false;
			this.entryAccountable.InvisibleChar = '●';
			this.hbox2.Add (this.entryAccountable);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryAccountable]));
			w4.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonAccountableEdit = new global::Gtk.Button ();
			this.buttonAccountableEdit.CanFocus = true;
			this.buttonAccountableEdit.Name = "buttonAccountableEdit";
			this.buttonAccountableEdit.UseUnderline = true;
			// Container child buttonAccountableEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w6 = new global::Gtk.HBox ();
			w6.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w6.Add (w7);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w9 = new global::Gtk.Label ();
			w6.Add (w9);
			w5.Add (w6);
			this.buttonAccountableEdit.Add (w5);
			this.hbox2.Add (this.buttonAccountableEdit);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonAccountableEdit]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = "Подотчетное лицо:";
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = "Организация:";
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = "Касса:";
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
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
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.label31]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.radio3month = new global::Gtk.RadioButton ("3 месяца");
			this.radio3month.CanFocus = true;
			this.radio3month.Name = "radio3month";
			this.radio3month.DrawIndicator = true;
			this.radio3month.UseUnderline = true;
			this.radio3month.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.table4.Add (this.radio3month);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table4 [this.radio3month]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.radioAll = new global::Gtk.RadioButton ("Весь период");
			this.radioAll.CanFocus = true;
			this.radioAll.Name = "radioAll";
			this.radioAll.DrawIndicator = true;
			this.radioAll.UseUnderline = true;
			this.radioAll.Group = this.radio3month.Group;
			this.table4.Add (this.radioAll);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table4 [this.radioAll]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.radioMonth = new global::Gtk.RadioButton ("Месяц");
			this.radioMonth.CanFocus = true;
			this.radioMonth.Name = "radioMonth";
			this.radioMonth.DrawIndicator = true;
			this.radioMonth.UseUnderline = true;
			this.radioMonth.Group = this.radio3month.Group;
			this.table4.Add (this.radioMonth);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4 [this.radioMonth]));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.radioYear = new global::Gtk.RadioButton ("Год");
			this.radioYear.CanFocus = true;
			this.radioYear.Name = "radioYear";
			this.radioYear.DrawIndicator = true;
			this.radioYear.UseUnderline = true;
			this.radioYear.Group = this.radio3month.Group;
			this.table4.Add (this.radioYear);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4 [this.radioYear]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox11.Add (this.table4);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.table4]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.dateCashStart = new global::QSWidgetLib.DatePicker ();
			this.dateCashStart.Events = ((global::Gdk.EventMask)(256));
			this.dateCashStart.Name = "dateCashStart";
			this.dateCashStart.Date = new global::System.DateTime (0);
			this.dateCashStart.IsEditable = true;
			this.dateCashStart.AutoSeparation = true;
			this.hbox15.Add (this.dateCashStart);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.dateCashStart]));
			w25.Position = 0;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.LabelProp = "-";
			this.hbox15.Add (this.label32);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label32]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.dateCashEnd = new global::QSWidgetLib.DatePicker ();
			this.dateCashEnd.Events = ((global::Gdk.EventMask)(256));
			this.dateCashEnd.Name = "dateCashEnd";
			this.dateCashEnd.Date = new global::System.DateTime (0);
			this.dateCashEnd.IsEditable = true;
			this.dateCashEnd.AutoSeparation = true;
			this.hbox15.Add (this.dateCashEnd);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.dateCashEnd]));
			w27.Position = 2;
			this.vbox11.Add (this.hbox15);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox15]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox1.Add (this.vbox11);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox11]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewSlips = new global::Gtk.TreeView ();
			this.treeviewSlips.CanFocus = true;
			this.treeviewSlips.Name = "treeviewSlips";
			this.GtkScrolledWindow.Add (this.treeviewSlips);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w32.Position = 1;
			// Internal child bazar.AccountableSlips.ActionArea
			global::Gtk.HButtonBox w33 = this.ActionArea;
			w33.Name = "dialog1_ActionArea";
			w33.Spacing = 10;
			w33.BorderWidth = ((uint)(5));
			w33.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button ();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			// Container child buttonClose.Gtk.Container+ContainerChild
			global::Gtk.Alignment w34 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w35 = new global::Gtk.HBox ();
			w35.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w36 = new global::Gtk.Image ();
			w36.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.Menu);
			w35.Add (w36);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w38 = new global::Gtk.Label ();
			w38.LabelProp = "_Закрыть";
			w38.UseUnderline = true;
			w35.Add (w38);
			w34.Add (w35);
			this.buttonClose.Add (w34);
			this.AddActionWidget (this.buttonClose, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w42 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w33 [this.buttonClose]));
			w42.Expand = false;
			w42.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 633;
			this.DefaultHeight = 515;
			this.Show ();
			this.buttonAccountableEdit.Clicked += new global::System.EventHandler (this.OnButtonAccountableEditClicked);
			this.comboOrg.Changed += new global::System.EventHandler (this.OnComboOrgChanged);
			this.comboCash.Changed += new global::System.EventHandler (this.OnComboCashChanged);
			this.radioYear.Clicked += new global::System.EventHandler (this.OnRadioYearClicked);
			this.radioMonth.Clicked += new global::System.EventHandler (this.OnRadioMonthClicked);
			this.radioAll.Clicked += new global::System.EventHandler (this.OnRadioAllClicked);
			this.radio3month.Clicked += new global::System.EventHandler (this.OnRadio3monthClicked);
			this.dateCashStart.DateChanged += new global::System.EventHandler (this.OnDateCashStartDateChanged);
			this.dateCashEnd.DateChanged += new global::System.EventHandler (this.OnDateCashEndDateChanged);
		}
	}
}
