
// This file has been generated by the GUI designer. Do not modify.
namespace bazar
{
	public partial class Contract
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Table table2;
		private global::Gtk.ComboBox comboOrg;
		private global::Gtk.ComboBox comboPayDay;
		private global::QSWidgetLib.DatePicker datepickerSign;
		private global::Gtk.Entry entryNumber;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entryLessee;
		private global::Gtk.Button buttonLesseeOpen;
		private global::Gtk.Button buttonLesseeEdit;
		private global::Gtk.HBox hbox5;
		private global::Gtk.ComboBox comboPlaceT;
		private global::Gtk.Label label1;
		private global::Gtk.ComboBox comboPlaceNo;
		private global::Gtk.Label labelArea;
		private global::Gtk.Label label10;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table3;
		private global::QSWidgetLib.DatePicker datepickerCancel;
		private global::QSWidgetLib.DatePicker datepickerEnd;
		private global::QSWidgetLib.DatePicker datepickerStart;
		private global::Gtk.Label label11;
		private global::Gtk.Label label12;
		private global::Gtk.Label label13;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment8;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textComments;
		private global::Gtk.Label GtkLabel8;
		private global::Gtk.Label label14;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeviewServices;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Button buttonAddService;
		private global::Gtk.Button buttonDelService;
		private global::Gtk.Label labelSum;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget bazar.Contract
			this.Name = "bazar.Contract";
			this.Title = "Новый договор";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child bazar.Contract.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.comboOrg = new global::Gtk.ComboBox ();
			this.comboOrg.Name = "comboOrg";
			this.table2.Add (this.comboOrg);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboOrg]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboPayDay = global::Gtk.ComboBox.NewText ();
			this.comboPayDay.AppendText ("Не установлен");
			this.comboPayDay.AppendText ("1");
			this.comboPayDay.AppendText ("2");
			this.comboPayDay.AppendText ("3");
			this.comboPayDay.AppendText ("4");
			this.comboPayDay.AppendText ("5");
			this.comboPayDay.AppendText ("6");
			this.comboPayDay.AppendText ("7");
			this.comboPayDay.AppendText ("8");
			this.comboPayDay.AppendText ("9");
			this.comboPayDay.AppendText ("10");
			this.comboPayDay.AppendText ("11");
			this.comboPayDay.AppendText ("12");
			this.comboPayDay.AppendText ("13");
			this.comboPayDay.AppendText ("14");
			this.comboPayDay.AppendText ("15");
			this.comboPayDay.AppendText ("16");
			this.comboPayDay.AppendText ("17");
			this.comboPayDay.AppendText ("18");
			this.comboPayDay.AppendText ("19");
			this.comboPayDay.AppendText ("20");
			this.comboPayDay.AppendText ("21");
			this.comboPayDay.AppendText ("22");
			this.comboPayDay.AppendText ("23");
			this.comboPayDay.AppendText ("24");
			this.comboPayDay.AppendText ("25");
			this.comboPayDay.AppendText ("26");
			this.comboPayDay.AppendText ("27");
			this.comboPayDay.AppendText ("28");
			this.comboPayDay.AppendText ("29");
			this.comboPayDay.AppendText ("30");
			this.comboPayDay.AppendText ("31");
			this.comboPayDay.Name = "comboPayDay";
			this.comboPayDay.Active = 0;
			this.table2.Add (this.comboPayDay);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboPayDay]));
			w3.TopAttach = ((uint)(5));
			w3.BottomAttach = ((uint)(6));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.datepickerSign = new global::QSWidgetLib.DatePicker ();
			this.datepickerSign.Events = ((global::Gdk.EventMask)(256));
			this.datepickerSign.Name = "datepickerSign";
			this.datepickerSign.Date = new global::System.DateTime (0);
			this.datepickerSign.IsEditable = false;
			this.datepickerSign.AutoSeparation = false;
			this.table2.Add (this.datepickerSign);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.datepickerSign]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryNumber = new global::Gtk.Entry ();
			this.entryNumber.CanFocus = true;
			this.entryNumber.Name = "entryNumber";
			this.entryNumber.IsEditable = true;
			this.entryNumber.MaxLength = 15;
			this.entryNumber.InvisibleChar = '•';
			this.table2.Add (this.entryNumber);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryNumber]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryLessee = new global::Gtk.Entry ();
			this.entryLessee.CanFocus = true;
			this.entryLessee.Name = "entryLessee";
			this.entryLessee.IsEditable = false;
			this.entryLessee.InvisibleChar = '•';
			this.hbox1.Add (this.entryLessee);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryLessee]));
			w6.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonLesseeOpen = new global::Gtk.Button ();
			this.buttonLesseeOpen.TooltipMarkup = "Открыть текущего арендатора";
			this.buttonLesseeOpen.Sensitive = false;
			this.buttonLesseeOpen.CanFocus = true;
			this.buttonLesseeOpen.Name = "buttonLesseeOpen";
			this.buttonLesseeOpen.UseUnderline = true;
			// Container child buttonLesseeOpen.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w8.Add (w11);
			w7.Add (w8);
			this.buttonLesseeOpen.Add (w7);
			this.hbox1.Add (this.buttonLesseeOpen);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonLesseeOpen]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonLesseeEdit = new global::Gtk.Button ();
			this.buttonLesseeEdit.TooltipMarkup = "Изменить арендатора";
			this.buttonLesseeEdit.CanFocus = true;
			this.buttonLesseeEdit.Name = "buttonLesseeEdit";
			this.buttonLesseeEdit.UseUnderline = true;
			// Container child buttonLesseeEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w17 = new global::Gtk.HBox ();
			w17.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w18 = new global::Gtk.Image ();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w17.Add (w18);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w20 = new global::Gtk.Label ();
			w17.Add (w20);
			w16.Add (w17);
			this.buttonLesseeEdit.Add (w16);
			this.hbox1.Add (this.buttonLesseeEdit);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonLesseeEdit]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.table2.Add (this.hbox1);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox1]));
			w25.TopAttach = ((uint)(3));
			w25.BottomAttach = ((uint)(4));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.comboPlaceT = new global::Gtk.ComboBox ();
			this.comboPlaceT.Name = "comboPlaceT";
			this.hbox5.Add (this.comboPlaceT);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.comboPlaceT]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = "-";
			this.hbox5.Add (this.label1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label1]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.comboPlaceNo = global::Gtk.ComboBox.NewText ();
			this.comboPlaceNo.Name = "comboPlaceNo";
			this.hbox5.Add (this.comboPlaceNo);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.comboPlaceNo]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.labelArea = new global::Gtk.Label ();
			this.labelArea.TooltipMarkup = "Площадь";
			this.labelArea.Name = "labelArea";
			this.labelArea.UseMarkup = true;
			this.hbox5.Add (this.labelArea);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.labelArea]));
			w29.PackType = ((global::Gtk.PackType)(1));
			w29.Position = 3;
			w29.Fill = false;
			this.table2.Add (this.hbox5);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox5]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = "День оплаты:";
			this.table2.Add (this.label10);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.label10]));
			w31.TopAttach = ((uint)(5));
			w31.BottomAttach = ((uint)(6));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = "Номер договора<span foreground=\"red\">*</span>:";
			this.label5.UseMarkup = true;
			this.table2.Add (this.label5);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.label5]));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = "Организация<span foreground=\"red\">*</span>:";
			this.label6.UseMarkup = true;
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w33.TopAttach = ((uint)(2));
			w33.BottomAttach = ((uint)(3));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = "Место<span foreground=\"red\">*</span>:";
			this.label7.UseMarkup = true;
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = "Арендатор<span foreground=\"red\">*</span>:";
			this.label8.UseMarkup = true;
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = "Дата подписания:";
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w36.TopAttach = ((uint)(4));
			w36.BottomAttach = ((uint)(5));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox8.Add (this.table2);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.table2]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.datepickerCancel = new global::QSWidgetLib.DatePicker ();
			this.datepickerCancel.Events = ((global::Gdk.EventMask)(256));
			this.datepickerCancel.Name = "datepickerCancel";
			this.datepickerCancel.Date = new global::System.DateTime (0);
			this.datepickerCancel.IsEditable = false;
			this.datepickerCancel.AutoSeparation = false;
			this.table3.Add (this.datepickerCancel);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table3 [this.datepickerCancel]));
			w38.TopAttach = ((uint)(2));
			w38.BottomAttach = ((uint)(3));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.datepickerEnd = new global::QSWidgetLib.DatePicker ();
			this.datepickerEnd.Events = ((global::Gdk.EventMask)(256));
			this.datepickerEnd.Name = "datepickerEnd";
			this.datepickerEnd.Date = new global::System.DateTime (0);
			this.datepickerEnd.IsEditable = false;
			this.datepickerEnd.AutoSeparation = false;
			this.table3.Add (this.datepickerEnd);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table3 [this.datepickerEnd]));
			w39.TopAttach = ((uint)(1));
			w39.BottomAttach = ((uint)(2));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.datepickerStart = new global::QSWidgetLib.DatePicker ();
			this.datepickerStart.Events = ((global::Gdk.EventMask)(256));
			this.datepickerStart.Name = "datepickerStart";
			this.datepickerStart.Date = new global::System.DateTime (0);
			this.datepickerStart.IsEditable = false;
			this.datepickerStart.AutoSeparation = false;
			this.table3.Add (this.datepickerStart);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table3 [this.datepickerStart]));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = "Дата начала аренды<span foreground=\"red\">*</span>:";
			this.label11.UseMarkup = true;
			this.table3.Add (this.label11);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table3 [this.label11]));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = "Дата окончания аренды<span foreground=\"red\">*</span>:";
			this.label12.UseMarkup = true;
			this.table3.Add (this.label12);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table3 [this.label12]));
			w42.TopAttach = ((uint)(1));
			w42.BottomAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = "Дата расторжения:";
			this.table3.Add (this.label13);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table3 [this.label13]));
			w43.TopAttach = ((uint)(2));
			w43.BottomAttach = ((uint)(3));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table3);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table3]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment8.Name = "GtkAlignment8";
			this.GtkAlignment8.LeftPadding = ((uint)(12));
			// Container child GtkAlignment8.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textComments = new global::Gtk.TextView ();
			this.textComments.CanFocus = true;
			this.textComments.Name = "textComments";
			this.textComments.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add (this.textComments);
			this.GtkAlignment8.Add (this.GtkScrolledWindow);
			this.frame1.Add (this.GtkAlignment8);
			this.GtkLabel8 = new global::Gtk.Label ();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = "<b>Комментарии</b>";
			this.GtkLabel8.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel8;
			this.vbox3.Add (this.frame1);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame1]));
			w48.Position = 1;
			this.hbox8.Add (this.vbox3);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.vbox3]));
			w49.Position = 1;
			this.vbox2.Add (this.hbox8);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox8]));
			w50.Position = 0;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = "<b>Услуги по договору</b>";
			this.label14.UseMarkup = true;
			this.vbox2.Add (this.label14);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label14]));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewServices = new global::Gtk.TreeView ();
			this.treeviewServices.CanFocus = true;
			this.treeviewServices.Name = "treeviewServices";
			this.GtkScrolledWindow1.Add (this.treeviewServices);
			this.vbox2.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow1]));
			w53.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonAddService = new global::Gtk.Button ();
			this.buttonAddService.CanFocus = true;
			this.buttonAddService.Name = "buttonAddService";
			this.buttonAddService.UseUnderline = true;
			// Container child buttonAddService.Gtk.Container+ContainerChild
			global::Gtk.Alignment w54 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w55 = new global::Gtk.HBox ();
			w55.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w56 = new global::Gtk.Image ();
			w56.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w55.Add (w56);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w58 = new global::Gtk.Label ();
			w58.LabelProp = "Добавить";
			w58.UseUnderline = true;
			w55.Add (w58);
			w54.Add (w55);
			this.buttonAddService.Add (w54);
			this.hbox7.Add (this.buttonAddService);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonAddService]));
			w62.Position = 0;
			w62.Expand = false;
			w62.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonDelService = new global::Gtk.Button ();
			this.buttonDelService.CanFocus = true;
			this.buttonDelService.Name = "buttonDelService";
			this.buttonDelService.UseUnderline = true;
			// Container child buttonDelService.Gtk.Container+ContainerChild
			global::Gtk.Alignment w63 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w64 = new global::Gtk.HBox ();
			w64.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w65 = new global::Gtk.Image ();
			w65.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w64.Add (w65);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w67 = new global::Gtk.Label ();
			w67.LabelProp = "Удалить";
			w67.UseUnderline = true;
			w64.Add (w67);
			w63.Add (w64);
			this.buttonDelService.Add (w63);
			this.hbox7.Add (this.buttonDelService);
			global::Gtk.Box.BoxChild w71 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonDelService]));
			w71.Position = 1;
			w71.Expand = false;
			w71.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelSum = new global::Gtk.Label ();
			this.labelSum.Name = "labelSum";
			this.labelSum.Xalign = 1F;
			this.labelSum.LabelProp = "Сумма: 0 руб.";
			this.hbox7.Add (this.labelSum);
			global::Gtk.Box.BoxChild w72 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.labelSum]));
			w72.Position = 2;
			this.vbox2.Add (this.hbox7);
			global::Gtk.Box.BoxChild w73 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
			w73.Position = 3;
			w73.Expand = false;
			w73.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w74.Position = 0;
			// Internal child bazar.Contract.ActionArea
			global::Gtk.HButtonBox w75 = this.ActionArea;
			w75.Name = "dialog1_ActionArea";
			w75.Spacing = 10;
			w75.BorderWidth = ((uint)(5));
			w75.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w76 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w77 = new global::Gtk.HBox ();
			w77.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w78 = new global::Gtk.Image ();
			w78.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w77.Add (w78);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w80 = new global::Gtk.Label ();
			w80.LabelProp = "О_тменить";
			w80.UseUnderline = true;
			w77.Add (w80);
			w76.Add (w77);
			this.buttonCancel.Add (w76);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w84 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w75 [this.buttonCancel]));
			w84.Expand = false;
			w84.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w85 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w86 = new global::Gtk.HBox ();
			w86.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w87 = new global::Gtk.Image ();
			w87.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w86.Add (w87);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w89 = new global::Gtk.Label ();
			w89.LabelProp = "_OK";
			w89.UseUnderline = true;
			w86.Add (w89);
			w85.Add (w86);
			this.buttonOk.Add (w85);
			w75.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w93 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w75 [this.buttonOk]));
			w93.Position = 1;
			w93.Expand = false;
			w93.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 756;
			this.DefaultHeight = 450;
			this.Show ();
			this.comboPlaceT.Changed += new global::System.EventHandler (this.OnComboPlaceTChanged);
			this.comboPlaceNo.Changed += new global::System.EventHandler (this.OnComboPlaceNoChanged);
			this.buttonLesseeOpen.Clicked += new global::System.EventHandler (this.OnButtonLesseeOpenClicked);
			this.buttonLesseeEdit.Clicked += new global::System.EventHandler (this.OnButtonLesseeEditClicked);
			this.entryNumber.Changed += new global::System.EventHandler (this.OnEntryNumberChanged);
			this.entryNumber.Activated += new global::System.EventHandler (this.OnEntryActivated);
			this.comboOrg.Changed += new global::System.EventHandler (this.OnComboOrgChanged);
			this.datepickerStart.DateChanged += new global::System.EventHandler (this.OnDatepickerStartDateChanged);
			this.datepickerEnd.DateChanged += new global::System.EventHandler (this.OnDatepickerEndDateChanged);
			this.datepickerCancel.DateChanged += new global::System.EventHandler (this.OnDatepickerCancelDateChanged);
			this.treeviewServices.CursorChanged += new global::System.EventHandler (this.OnTreeviewServicesCursorChanged);
			this.buttonAddService.Clicked += new global::System.EventHandler (this.OnButtonAddServiceClicked);
			this.buttonDelService.Clicked += new global::System.EventHandler (this.OnButtonDelServiceClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
