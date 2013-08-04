
// This file has been generated by the GUI designer. Do not modify.
namespace bazar
{
	public partial class MassAccrualCreation
	{
		private global::Gtk.HBox hbox2;
		private global::Gtk.Image image1579;
		private global::Gtk.Label label1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.CheckButton checkAll;
		private global::Gtk.Label label3;
		private global::Gtk.ComboBox comboMonth;
		private global::Gtk.ComboBox comboYear;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewContracts;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label labelSelected;
		private global::Gtk.Label labelTotal;
		private global::Gtk.ProgressBar progressOperation;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget bazar.MassAccrualCreation
			this.Name = "bazar.MassAccrualCreation";
			this.Title = "Выполнение массового начисления";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child bazar.MassAccrualCreation.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image1579 = new global::Gtk.Image ();
			this.image1579.Name = "image1579";
			this.image1579.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Dialog);
			this.hbox2.Add (this.image1579);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image1579]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = "Выберите месяц за который необходимо произвести начисления. Потом \nотметьте договора, по которым необходимо начислить ежемесячную плату.";
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			w1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.checkAll = new global::Gtk.CheckButton ();
			this.checkAll.CanFocus = true;
			this.checkAll.Name = "checkAll";
			this.checkAll.Label = "Выбрать все";
			this.checkAll.DrawIndicator = true;
			this.checkAll.UseUnderline = true;
			this.hbox3.Add (this.checkAll);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.checkAll]));
			w5.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = "Месяц:";
			this.hbox3.Add (this.label3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboMonth = global::Gtk.ComboBox.NewText ();
			this.comboMonth.AppendText ("Нет");
			this.comboMonth.AppendText ("Январь");
			this.comboMonth.AppendText ("Февраль");
			this.comboMonth.AppendText ("Март");
			this.comboMonth.AppendText ("Апрель");
			this.comboMonth.AppendText ("Май");
			this.comboMonth.AppendText ("Июнь");
			this.comboMonth.AppendText ("Июль");
			this.comboMonth.AppendText ("Август");
			this.comboMonth.AppendText ("Сентябрь");
			this.comboMonth.AppendText ("Октябрь");
			this.comboMonth.AppendText ("Ноябрь");
			this.comboMonth.AppendText ("Декабрь");
			this.comboMonth.Name = "comboMonth";
			this.hbox3.Add (this.comboMonth);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboMonth]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboYear = global::Gtk.ComboBox.NewText ();
			this.comboYear.Name = "comboYear";
			this.hbox3.Add (this.comboYear);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboYear]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			w1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox3]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewContracts = new global::Gtk.TreeView ();
			this.treeviewContracts.CanFocus = true;
			this.treeviewContracts.Name = "treeviewContracts";
			this.GtkScrolledWindow.Add (this.treeviewContracts);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w11.Position = 2;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			this.hbox4.BorderWidth = ((uint)(3));
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelSelected = new global::Gtk.Label ();
			this.labelSelected.Name = "labelSelected";
			this.labelSelected.LabelProp = "label2";
			this.hbox4.Add (this.labelSelected);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelSelected]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Xalign = 1F;
			this.labelTotal.LabelProp = "label4";
			this.hbox4.Add (this.labelTotal);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelTotal]));
			w13.Position = 1;
			w1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox4]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.progressOperation = new global::Gtk.ProgressBar ();
			this.progressOperation.Name = "progressOperation";
			this.progressOperation.Text = "";
			w1.Add (this.progressOperation);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(w1 [this.progressOperation]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Internal child bazar.MassAccrualCreation.ActionArea
			global::Gtk.HButtonBox w16 = this.ActionArea;
			w16.Name = "dialog1_ActionArea";
			w16.Spacing = 10;
			w16.BorderWidth = ((uint)(5));
			w16.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w17 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w18 = new global::Gtk.HBox ();
			w18.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w19 = new global::Gtk.Image ();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w18.Add (w19);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w21 = new global::Gtk.Label ();
			w21.LabelProp = "О_тменить";
			w21.UseUnderline = true;
			w18.Add (w21);
			w17.Add (w18);
			this.buttonCancel.Add (w17);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w25 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w16 [this.buttonCancel]));
			w25.Expand = false;
			w25.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w26 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w27 = new global::Gtk.HBox ();
			w27.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w28 = new global::Gtk.Image ();
			w28.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w27.Add (w28);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w30 = new global::Gtk.Label ();
			w30.LabelProp = "_OK";
			w30.UseUnderline = true;
			w27.Add (w30);
			w26.Add (w27);
			this.buttonOk.Add (w26);
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w16 [this.buttonOk]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 591;
			this.DefaultHeight = 380;
			this.Show ();
			this.checkAll.Clicked += new global::System.EventHandler (this.OnCheckAllClicked);
			this.comboMonth.Changed += new global::System.EventHandler (this.OnComboMonthChanged);
			this.comboYear.Changed += new global::System.EventHandler (this.OnComboYearChanged);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
