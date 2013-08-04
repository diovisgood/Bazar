
// This file has been generated by the GUI designer. Do not modify.
namespace bazar
{
	public partial class IncomeSlip
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboAccrual;
		private global::Gtk.ComboBox comboCash;
		private global::Gtk.ComboBox comboContract;
		private global::Gtk.ComboBox comboOperation;
		private global::Gtk.ComboBox comboOrg;
		private global::Gtk.HBox hboxAccountable;
		private global::Gtk.Entry entryAccountable;
		private global::Gtk.Button buttonAccountableEdit;
		private global::Gtk.HBox hboxLessee;
		private global::Gtk.Entry entryLessee;
		private global::Gtk.Button buttonLesseeEdit;
		private global::Gtk.Label label11;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label labelAccountable;
		private global::Gtk.Label labelAccrual;
		private global::Gtk.Label labelContract;
		private global::Gtk.Label labelLessee;
		private global::Gtk.Table table2;
		private global::Gtk.ComboBox comboIncomeItem;
		private global::QSWidgetLib.DatePicker dateSlip;
		private global::Gtk.Entry entryNumber;
		private global::Gtk.Entry entryUser;
		private global::Gtk.Label label2;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label9;
		private global::Gtk.Label labelIncomeItem;
		private global::Gtk.SpinButton spinSum;
		private global::bazar.SeparationPayment separationpayment;
		private global::Gtk.Label label5;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView textviewDetails;
		private global::Gtk.Button buttonPrint;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget bazar.IncomeSlip
			this.Name = "bazar.IncomeSlip";
			this.Title = "Новый приходный ордер";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child bazar.IncomeSlip.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.comboAccrual = new global::Gtk.ComboBox ();
			this.comboAccrual.Name = "comboAccrual";
			this.table1.Add (this.comboAccrual);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboAccrual]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboCash = new global::Gtk.ComboBox ();
			this.comboCash.Name = "comboCash";
			this.table1.Add (this.comboCash);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboCash]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboContract = global::Gtk.ComboBox.NewText ();
			this.comboContract.Name = "comboContract";
			this.table1.Add (this.comboContract);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboContract]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboOperation = global::Gtk.ComboBox.NewText ();
			this.comboOperation.AppendText ("Прочий приход");
			this.comboOperation.AppendText ("Возврат от подотчетного лица");
			this.comboOperation.AppendText ("Оплата по начислению");
			this.comboOperation.Name = "comboOperation";
			this.comboOperation.Active = 0;
			this.table1.Add (this.comboOperation);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboOperation]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboOrg = new global::Gtk.ComboBox ();
			this.comboOrg.Name = "comboOrg";
			this.table1.Add (this.comboOrg);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboOrg]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hboxAccountable = new global::Gtk.HBox ();
			this.hboxAccountable.Name = "hboxAccountable";
			this.hboxAccountable.Spacing = 6;
			// Container child hboxAccountable.Gtk.Box+BoxChild
			this.entryAccountable = new global::Gtk.Entry ();
			this.entryAccountable.CanFocus = true;
			this.entryAccountable.Name = "entryAccountable";
			this.entryAccountable.IsEditable = false;
			this.entryAccountable.InvisibleChar = '●';
			this.hboxAccountable.Add (this.entryAccountable);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxAccountable [this.entryAccountable]));
			w7.Position = 0;
			// Container child hboxAccountable.Gtk.Box+BoxChild
			this.buttonAccountableEdit = new global::Gtk.Button ();
			this.buttonAccountableEdit.CanFocus = true;
			this.buttonAccountableEdit.Name = "buttonAccountableEdit";
			this.buttonAccountableEdit.UseUnderline = true;
			// Container child buttonAccountableEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w8 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w9 = new global::Gtk.HBox ();
			w9.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w10 = new global::Gtk.Image ();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w9.Add (w10);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w12 = new global::Gtk.Label ();
			w9.Add (w12);
			w8.Add (w9);
			this.buttonAccountableEdit.Add (w8);
			this.hboxAccountable.Add (this.buttonAccountableEdit);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hboxAccountable [this.buttonAccountableEdit]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.table1.Add (this.hboxAccountable);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.hboxAccountable]));
			w17.TopAttach = ((uint)(6));
			w17.BottomAttach = ((uint)(7));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hboxLessee = new global::Gtk.HBox ();
			this.hboxLessee.Name = "hboxLessee";
			this.hboxLessee.Spacing = 6;
			// Container child hboxLessee.Gtk.Box+BoxChild
			this.entryLessee = new global::Gtk.Entry ();
			this.entryLessee.CanFocus = true;
			this.entryLessee.Name = "entryLessee";
			this.entryLessee.IsEditable = false;
			this.entryLessee.InvisibleChar = '●';
			this.hboxLessee.Add (this.entryLessee);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hboxLessee [this.entryLessee]));
			w18.Position = 0;
			// Container child hboxLessee.Gtk.Box+BoxChild
			this.buttonLesseeEdit = new global::Gtk.Button ();
			this.buttonLesseeEdit.TooltipMarkup = "Выбрать контрагента";
			this.buttonLesseeEdit.CanFocus = true;
			this.buttonLesseeEdit.Name = "buttonLesseeEdit";
			this.buttonLesseeEdit.UseUnderline = true;
			// Container child buttonLesseeEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w20.Add (w23);
			w19.Add (w20);
			this.buttonLesseeEdit.Add (w19);
			this.hboxLessee.Add (this.buttonLesseeEdit);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hboxLessee [this.buttonLesseeEdit]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.table1.Add (this.hboxLessee);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.hboxLessee]));
			w28.TopAttach = ((uint)(3));
			w28.BottomAttach = ((uint)(4));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = "<b>Вид операции:</b>";
			this.label11.UseMarkup = true;
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = "Организация<span foreground=\"red\">*</span>:";
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = "Касса<span foreground=\"red\">*</span>:";
			this.label4.UseMarkup = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w31.TopAttach = ((uint)(2));
			w31.BottomAttach = ((uint)(3));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelAccountable = new global::Gtk.Label ();
			this.labelAccountable.Name = "labelAccountable";
			this.labelAccountable.LabelProp = "Подотчетное лицо<span foreground=\"red\">*</span>:";
			this.labelAccountable.UseMarkup = true;
			this.table1.Add (this.labelAccountable);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelAccountable]));
			w32.TopAttach = ((uint)(6));
			w32.BottomAttach = ((uint)(7));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelAccrual = new global::Gtk.Label ();
			this.labelAccrual.Name = "labelAccrual";
			this.labelAccrual.Xalign = 1F;
			this.labelAccrual.LabelProp = "По начислению<span foreground=\"red\">*</span>:";
			this.labelAccrual.UseMarkup = true;
			this.table1.Add (this.labelAccrual);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelAccrual]));
			w33.TopAttach = ((uint)(5));
			w33.BottomAttach = ((uint)(6));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelContract = new global::Gtk.Label ();
			this.labelContract.Name = "labelContract";
			this.labelContract.Xalign = 1F;
			this.labelContract.LabelProp = "Договор:";
			this.table1.Add (this.labelContract);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelContract]));
			w34.TopAttach = ((uint)(4));
			w34.BottomAttach = ((uint)(5));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelLessee = new global::Gtk.Label ();
			this.labelLessee.Name = "labelLessee";
			this.labelLessee.Xalign = 1F;
			this.labelLessee.LabelProp = "Арендатор<span foreground=\"red\">*</span>:";
			this.labelLessee.UseMarkup = true;
			this.table1.Add (this.labelLessee);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelLessee]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.comboIncomeItem = new global::Gtk.ComboBox ();
			this.comboIncomeItem.Name = "comboIncomeItem";
			this.table2.Add (this.comboIncomeItem);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboIncomeItem]));
			w37.TopAttach = ((uint)(3));
			w37.BottomAttach = ((uint)(4));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.dateSlip = new global::QSWidgetLib.DatePicker ();
			this.dateSlip.Sensitive = false;
			this.dateSlip.Events = ((global::Gdk.EventMask)(256));
			this.dateSlip.Name = "dateSlip";
			this.dateSlip.Date = new global::System.DateTime (0);
			this.dateSlip.IsEditable = false;
			this.dateSlip.AutoSeparation = false;
			this.table2.Add (this.dateSlip);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table2 [this.dateSlip]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryNumber = new global::Gtk.Entry ();
			this.entryNumber.Sensitive = false;
			this.entryNumber.CanFocus = true;
			this.entryNumber.Name = "entryNumber";
			this.entryNumber.Text = "Не назначен";
			this.entryNumber.IsEditable = false;
			this.entryNumber.InvisibleChar = '●';
			this.table2.Add (this.entryNumber);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryNumber]));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryUser = new global::Gtk.Entry ();
			this.entryUser.Sensitive = false;
			this.entryUser.CanFocus = true;
			this.entryUser.Name = "entryUser";
			this.entryUser.IsEditable = true;
			this.entryUser.InvisibleChar = '●';
			this.table2.Add (this.entryUser);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryUser]));
			w40.TopAttach = ((uint)(2));
			w40.BottomAttach = ((uint)(3));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = "Номер ордера:";
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = "Дата документа:";
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w42.TopAttach = ((uint)(1));
			w42.BottomAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = "Пользователь:";
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
			w43.TopAttach = ((uint)(2));
			w43.BottomAttach = ((uint)(3));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = "Сумма<span foreground=\"red\">*</span>:";
			this.label9.UseMarkup = true;
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w44.TopAttach = ((uint)(4));
			w44.BottomAttach = ((uint)(5));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelIncomeItem = new global::Gtk.Label ();
			this.labelIncomeItem.Name = "labelIncomeItem";
			this.labelIncomeItem.Xalign = 1F;
			this.labelIncomeItem.LabelProp = "Статья дохода<span foreground=\"red\">*</span>:";
			this.labelIncomeItem.UseMarkup = true;
			this.table2.Add (this.labelIncomeItem);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelIncomeItem]));
			w45.TopAttach = ((uint)(3));
			w45.BottomAttach = ((uint)(4));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.spinSum = new global::Gtk.SpinButton (0, 100000000, 100);
			this.spinSum.CanFocus = true;
			this.spinSum.Name = "spinSum";
			this.spinSum.Adjustment.PageIncrement = 1000;
			this.spinSum.ClimbRate = 1;
			this.spinSum.Digits = ((uint)(2));
			this.spinSum.Numeric = true;
			this.table2.Add (this.spinSum);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table2 [this.spinSum]));
			w46.TopAttach = ((uint)(4));
			w46.BottomAttach = ((uint)(5));
			w46.LeftAttach = ((uint)(1));
			w46.RightAttach = ((uint)(2));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table2]));
			w47.Position = 1;
			w47.Expand = false;
			w47.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w48.Position = 0;
			w48.Expand = false;
			w48.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.separationpayment = new global::bazar.SeparationPayment ();
			this.separationpayment.Events = ((global::Gdk.EventMask)(256));
			this.separationpayment.Name = "separationpayment";
			this.separationpayment.PaymentSum = 0m;
			this.separationpayment.PaymentId = 0;
			this.separationpayment.AccrualId = 0;
			this.vbox2.Add (this.separationpayment);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.separationpayment]));
			w49.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = "Основание:";
			this.vbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label5]));
			w50.Position = 2;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow1.BorderWidth = ((uint)(3));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewDetails = new global::Gtk.TextView ();
			this.textviewDetails.CanFocus = true;
			this.textviewDetails.Name = "textviewDetails";
			this.textviewDetails.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow1.Add (this.textviewDetails);
			this.vbox2.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow1]));
			w52.Position = 3;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w53.Position = 0;
			// Internal child bazar.IncomeSlip.ActionArea
			global::Gtk.HButtonBox w54 = this.ActionArea;
			w54.Name = "dialog1_ActionArea";
			w54.Spacing = 10;
			w54.BorderWidth = ((uint)(5));
			w54.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPrint = new global::Gtk.Button ();
			this.buttonPrint.Sensitive = false;
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			// Container child buttonPrint.Gtk.Container+ContainerChild
			global::Gtk.Alignment w55 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w56 = new global::Gtk.HBox ();
			w56.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w57 = new global::Gtk.Image ();
			w57.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Button);
			w56.Add (w57);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w59 = new global::Gtk.Label ();
			w59.LabelProp = "Печать";
			w59.UseUnderline = true;
			w56.Add (w59);
			w55.Add (w56);
			this.buttonPrint.Add (w55);
			this.AddActionWidget (this.buttonPrint, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w63 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w54 [this.buttonPrint]));
			w63.Expand = false;
			w63.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w64 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w65 = new global::Gtk.HBox ();
			w65.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w66 = new global::Gtk.Image ();
			w66.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w65.Add (w66);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w68 = new global::Gtk.Label ();
			w68.LabelProp = "О_тменить";
			w68.UseUnderline = true;
			w65.Add (w68);
			w64.Add (w65);
			this.buttonCancel.Add (w64);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w72 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w54 [this.buttonCancel]));
			w72.Position = 1;
			w72.Expand = false;
			w72.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w73 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w74 = new global::Gtk.HBox ();
			w74.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w75 = new global::Gtk.Image ();
			w75.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w74.Add (w75);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w77 = new global::Gtk.Label ();
			w77.LabelProp = "_OK";
			w77.UseUnderline = true;
			w74.Add (w77);
			w73.Add (w74);
			this.buttonOk.Add (w73);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w81 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w54 [this.buttonOk]));
			w81.Position = 2;
			w81.Expand = false;
			w81.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 704;
			this.DefaultHeight = 568;
			this.Show ();
			this.buttonLesseeEdit.Clicked += new global::System.EventHandler (this.OnButtonLesseeEditClicked);
			this.buttonAccountableEdit.Clicked += new global::System.EventHandler (this.OnButtonAccountableEditClicked);
			this.comboOrg.Changed += new global::System.EventHandler (this.OnComboOrgChanged);
			this.comboOperation.Changed += new global::System.EventHandler (this.OnComboOperationChanged);
			this.comboContract.Changed += new global::System.EventHandler (this.OnComboContractChanged);
			this.comboCash.Changed += new global::System.EventHandler (this.OnComboCashChanged);
			this.comboAccrual.Changed += new global::System.EventHandler (this.OnComboAccrualChanged);
			this.spinSum.ValueChanged += new global::System.EventHandler (this.OnSpinSumValueChanged);
			this.comboIncomeItem.Changed += new global::System.EventHandler (this.OnComboIncomeItemChanged);
			this.separationpayment.CanSaveStateChanged += new global::System.EventHandler (this.OnSeparationpaymentCanSaveStateChanged);
			this.buttonPrint.Clicked += new global::System.EventHandler (this.OnButtonPrintClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
