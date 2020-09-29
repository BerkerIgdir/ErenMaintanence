namespace ErenBakimTakipYazilim
{
    partial class VeriGirisControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.Shifts = new DevExpress.XtraEditors.LabelControl();
            this.ShiftsComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MaintanenceTypes = new DevExpress.XtraEditors.LabelControl();
            this.Machines = new DevExpress.XtraEditors.LabelControl();
            this.Factories = new DevExpress.XtraEditors.LabelControl();
            this.CrashRegisterSave = new DevExpress.XtraEditors.SimpleButton();
            this.CrashTypeControl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FactoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MachineComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Machine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArizaTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vardiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArizaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.CrashExplanation = new System.Windows.Forms.TextBox();
            this.Explanation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.MachineComponentText = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashTypeControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComponentText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(780, 594);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(173, 59);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // Shifts
            // 
            this.Shifts.Location = new System.Drawing.Point(-47, 567);
            this.Shifts.Name = "Shifts";
            this.Shifts.Size = new System.Drawing.Size(36, 13);
            this.Shifts.TabIndex = 23;
            this.Shifts.Text = "Vardiya";
            // 
            // ShiftsComboBox
            // 
            this.ShiftsComboBox.Location = new System.Drawing.Point(27, 591);
            this.ShiftsComboBox.Name = "ShiftsComboBox";
            this.ShiftsComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ShiftsComboBox.Size = new System.Drawing.Size(168, 20);
            this.ShiftsComboBox.TabIndex = 22;
            // 
            // MaintanenceTypes
            // 
            this.MaintanenceTypes.Location = new System.Drawing.Point(-47, 519);
            this.MaintanenceTypes.Name = "MaintanenceTypes";
            this.MaintanenceTypes.Size = new System.Drawing.Size(46, 13);
            this.MaintanenceTypes.TabIndex = 21;
            this.MaintanenceTypes.Text = "Bakım Tipi";
            // 
            // Machines
            // 
            this.Machines.Location = new System.Drawing.Point(-47, 471);
            this.Machines.Name = "Machines";
            this.Machines.Size = new System.Drawing.Size(33, 13);
            this.Machines.TabIndex = 20;
            this.Machines.Text = "Makine";
            // 
            // Factories
            // 
            this.Factories.Location = new System.Drawing.Point(-47, 423);
            this.Factories.Name = "Factories";
            this.Factories.Size = new System.Drawing.Size(35, 13);
            this.Factories.TabIndex = 19;
            this.Factories.Text = "Fabrika";
            // 
            // CrashRegisterSave
            // 
            this.CrashRegisterSave.Location = new System.Drawing.Point(780, 506);
            this.CrashRegisterSave.Name = "CrashRegisterSave";
            this.CrashRegisterSave.Size = new System.Drawing.Size(173, 59);
            this.CrashRegisterSave.TabIndex = 18;
            this.CrashRegisterSave.Text = "Kaydet";
            this.CrashRegisterSave.Click += new System.EventHandler(this.CrashRegisterSave_Click);
            // 
            // CrashTypeControl
            // 
            this.CrashTypeControl.Location = new System.Drawing.Point(27, 543);
            this.CrashTypeControl.Name = "CrashTypeControl";
            this.CrashTypeControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CrashTypeControl.Size = new System.Drawing.Size(168, 20);
            this.CrashTypeControl.TabIndex = 16;
            // 
            // FactoryComboBox
            // 
            this.FactoryComboBox.Location = new System.Drawing.Point(27, 401);
            this.FactoryComboBox.Name = "FactoryComboBox";
            this.FactoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FactoryComboBox.Size = new System.Drawing.Size(168, 20);
            this.FactoryComboBox.TabIndex = 15;
            this.FactoryComboBox.SelectedValueChanged += new System.EventHandler(this.FactoryComboBox_SelectedValueChanged);
            // 
            // MachineComboBox
            // 
            this.MachineComboBox.Location = new System.Drawing.Point(27, 449);
            this.MachineComboBox.Name = "MachineComboBox";
            this.MachineComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MachineComboBox.Size = new System.Drawing.Size(168, 20);
            this.MachineComboBox.TabIndex = 14;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(983, 351);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Machine,
            this.ArizaTip,
            this.Date,
            this.Aciklama,
            this.Factory,
            this.Vardiya,
            this.ArizaID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Machine
            // 
            this.Machine.Caption = "Makine";
            this.Machine.CustomizationCaption = "Makine";
            this.Machine.FieldName = "RelatedMachine.Name";
            this.Machine.Name = "Machine";
            this.Machine.OptionsColumn.AllowEdit = false;
            this.Machine.OptionsColumn.ReadOnly = true;
            this.Machine.Visible = true;
            this.Machine.VisibleIndex = 0;
            // 
            // ArizaTip
            // 
            this.ArizaTip.Caption = "Arıza Tipi";
            this.ArizaTip.FieldName = "CrashType";
            this.ArizaTip.Name = "ArizaTip";
            this.ArizaTip.OptionsColumn.AllowEdit = false;
            this.ArizaTip.OptionsColumn.ReadOnly = true;
            this.ArizaTip.Visible = true;
            this.ArizaTip.VisibleIndex = 1;
            // 
            // Date
            // 
            this.Date.Caption = "Tarih";
            this.Date.DisplayFormat.FormatString = "d";
            this.Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Date.FieldName = "CrashDate_";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.OptionsColumn.ReadOnly = true;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 2;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Explanation";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.ReadOnly = true;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 3;
            // 
            // Factory
            // 
            this.Factory.Caption = "Fabrika";
            this.Factory.FieldName = "RelatedMachine.RelatedFactory.FactoryName";
            this.Factory.Name = "Factory";
            this.Factory.OptionsColumn.AllowEdit = false;
            this.Factory.Visible = true;
            this.Factory.VisibleIndex = 4;
            // 
            // Vardiya
            // 
            this.Vardiya.Caption = "Vardiya";
            this.Vardiya.FieldName = "Shift";
            this.Vardiya.Name = "Vardiya";
            this.Vardiya.OptionsColumn.AllowEdit = false;
            this.Vardiya.OptionsColumn.ReadOnly = true;
            this.Vardiya.Visible = true;
            this.Vardiya.VisibleIndex = 5;
            // 
            // ArizaID
            // 
            this.ArizaID.Caption = "Arıza ID";
            this.ArizaID.FieldName = "ID";
            this.ArizaID.Name = "ArizaID";
            this.ArizaID.OptionsColumn.AllowEdit = false;
            this.ArizaID.OptionsColumn.ReadOnly = true;
            this.ArizaID.Visible = true;
            this.ArizaID.VisibleIndex = 6;
            // 
            // CrashExplanation
            // 
            this.CrashExplanation.Location = new System.Drawing.Point(264, 404);
            this.CrashExplanation.Multiline = true;
            this.CrashExplanation.Name = "CrashExplanation";
            this.CrashExplanation.Size = new System.Drawing.Size(333, 161);
            this.CrashExplanation.TabIndex = 25;
            // 
            // Explanation
            // 
            this.Explanation.Location = new System.Drawing.Point(262, 382);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(41, 13);
            this.Explanation.TabIndex = 30;
            this.Explanation.Text = "Açıklama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 572);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Vardiya";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 524);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Bakım Tipi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 430);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Makine";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 382);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Fabrika";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 479);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Makine Alt Bileşeni";
            // 
            // MachineComponentText
            // 
            this.MachineComponentText.Location = new System.Drawing.Point(27, 498);
            this.MachineComponentText.Name = "MachineComponentText";
            this.MachineComponentText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MachineComponentText.Size = new System.Drawing.Size(168, 20);
            this.MachineComponentText.TabIndex = 31;
            // 
            // VeriGirisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.MachineComponentText);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.CrashExplanation);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Shifts);
            this.Controls.Add(this.ShiftsComboBox);
            this.Controls.Add(this.MaintanenceTypes);
            this.Controls.Add(this.Machines);
            this.Controls.Add(this.Factories);
            this.Controls.Add(this.CrashRegisterSave);
            this.Controls.Add(this.CrashTypeControl);
            this.Controls.Add(this.FactoryComboBox);
            this.Controls.Add(this.MachineComboBox);
            this.Controls.Add(this.gridControl1);
            this.Name = "VeriGirisControl";
            this.Size = new System.Drawing.Size(983, 672);
            this.Load += new System.EventHandler(this.VeriGirisControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashTypeControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComponentText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.LabelControl Shifts;
        private DevExpress.XtraEditors.ComboBoxEdit ShiftsComboBox;
        private DevExpress.XtraEditors.LabelControl MaintanenceTypes;
        private DevExpress.XtraEditors.LabelControl Machines;
        private DevExpress.XtraEditors.LabelControl Factories;
        private DevExpress.XtraEditors.SimpleButton CrashRegisterSave;
        private DevExpress.XtraEditors.ComboBoxEdit CrashTypeControl;
        private DevExpress.XtraEditors.ComboBoxEdit FactoryComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit MachineComboBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Machine;
        private DevExpress.XtraGrid.Columns.GridColumn ArizaTip;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Factory;
        private DevExpress.XtraGrid.Columns.GridColumn Vardiya;
        private DevExpress.XtraGrid.Columns.GridColumn ArizaID;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox CrashExplanation;
        private DevExpress.XtraEditors.LabelControl Explanation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit MachineComponentText;
    }
}
