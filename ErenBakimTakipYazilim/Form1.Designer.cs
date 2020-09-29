namespace ErenBakimTakipYazilim
{
    partial class VeriGirisForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Machine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArizaTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vardiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArizaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FactoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CrashTypeControl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ExplanationEdit = new DevExpress.XtraEditors.TextEdit();
            this.CrashRegisterSave = new DevExpress.XtraEditors.SimpleButton();
            this.Factories = new DevExpress.XtraEditors.LabelControl();
            this.Machines = new DevExpress.XtraEditors.LabelControl();
            this.MaintanenceTypes = new DevExpress.XtraEditors.LabelControl();
            this.ShiftsComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Shifts = new DevExpress.XtraEditors.LabelControl();
            this.Explanation = new DevExpress.XtraEditors.LabelControl();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashTypeControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplanationEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(898, 351);
            this.gridControl1.TabIndex = 0;
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
            // MachineComboBox
            // 
            this.MachineComboBox.Location = new System.Drawing.Point(26, 449);
            this.MachineComboBox.Name = "MachineComboBox";
            this.MachineComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MachineComboBox.Size = new System.Drawing.Size(168, 20);
            this.MachineComboBox.TabIndex = 1;
            // 
            // FactoryComboBox
            // 
            this.FactoryComboBox.Location = new System.Drawing.Point(26, 401);
            this.FactoryComboBox.Name = "FactoryComboBox";
            this.FactoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FactoryComboBox.Size = new System.Drawing.Size(168, 20);
            this.FactoryComboBox.TabIndex = 2;
            this.FactoryComboBox.SelectedValueChanged += new System.EventHandler(this.FactoryComboBox_SelectedValueChanged);
            // 
            // CrashTypeControl
            // 
            this.CrashTypeControl.Location = new System.Drawing.Point(26, 497);
            this.CrashTypeControl.Name = "CrashTypeControl";
            this.CrashTypeControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CrashTypeControl.Size = new System.Drawing.Size(168, 20);
            this.CrashTypeControl.TabIndex = 3;
            // 
            // ExplanationEdit
            // 
            this.ExplanationEdit.Location = new System.Drawing.Point(261, 400);
            this.ExplanationEdit.Name = "ExplanationEdit";
            this.ExplanationEdit.Properties.AutoHeight = false;
            this.ExplanationEdit.Size = new System.Drawing.Size(268, 110);
            this.ExplanationEdit.TabIndex = 4;
            // 
            // CrashRegisterSave
            // 
            this.CrashRegisterSave.Location = new System.Drawing.Point(608, 446);
            this.CrashRegisterSave.Name = "CrashRegisterSave";
            this.CrashRegisterSave.Size = new System.Drawing.Size(173, 59);
            this.CrashRegisterSave.TabIndex = 5;
            this.CrashRegisterSave.Text = "Kaydet";
            this.CrashRegisterSave.Click += new System.EventHandler(this.CrashRegisterSave_Click);
            // 
            // Factories
            // 
            this.Factories.Location = new System.Drawing.Point(26, 381);
            this.Factories.Name = "Factories";
            this.Factories.Size = new System.Drawing.Size(35, 13);
            this.Factories.TabIndex = 6;
            this.Factories.Text = "Fabrika";
            // 
            // Machines
            // 
            this.Machines.Location = new System.Drawing.Point(26, 429);
            this.Machines.Name = "Machines";
            this.Machines.Size = new System.Drawing.Size(33, 13);
            this.Machines.TabIndex = 7;
            this.Machines.Text = "Makine";
            // 
            // MaintanenceTypes
            // 
            this.MaintanenceTypes.Location = new System.Drawing.Point(26, 477);
            this.MaintanenceTypes.Name = "MaintanenceTypes";
            this.MaintanenceTypes.Size = new System.Drawing.Size(46, 13);
            this.MaintanenceTypes.TabIndex = 8;
            this.MaintanenceTypes.Text = "Bakım Tipi";
            // 
            // ShiftsComboBox
            // 
            this.ShiftsComboBox.Location = new System.Drawing.Point(26, 545);
            this.ShiftsComboBox.Name = "ShiftsComboBox";
            this.ShiftsComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ShiftsComboBox.Size = new System.Drawing.Size(168, 20);
            this.ShiftsComboBox.TabIndex = 9;
            // 
            // Shifts
            // 
            this.Shifts.Location = new System.Drawing.Point(26, 525);
            this.Shifts.Name = "Shifts";
            this.Shifts.Size = new System.Drawing.Size(36, 13);
            this.Shifts.TabIndex = 10;
            this.Shifts.Text = "Vardiya";
            // 
            // Explanation
            // 
            this.Explanation.Location = new System.Drawing.Point(261, 381);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(41, 13);
            this.Explanation.TabIndex = 11;
            this.Explanation.Text = "Açıklama";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(608, 525);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(173, 59);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // VeriGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 644);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.Shifts);
            this.Controls.Add(this.ShiftsComboBox);
            this.Controls.Add(this.MaintanenceTypes);
            this.Controls.Add(this.Machines);
            this.Controls.Add(this.Factories);
            this.Controls.Add(this.CrashRegisterSave);
            this.Controls.Add(this.ExplanationEdit);
            this.Controls.Add(this.CrashTypeControl);
            this.Controls.Add(this.FactoryComboBox);
            this.Controls.Add(this.MachineComboBox);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.Name = "VeriGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Giriş ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashTypeControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplanationEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Machine;
        private DevExpress.XtraGrid.Columns.GridColumn ArizaTip;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Factory;
        private DevExpress.XtraEditors.ComboBoxEdit MachineComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit FactoryComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit CrashTypeControl;
        private DevExpress.XtraEditors.TextEdit ExplanationEdit;
        private DevExpress.XtraEditors.SimpleButton CrashRegisterSave;
        private DevExpress.XtraEditors.LabelControl Factories;
        private DevExpress.XtraEditors.LabelControl Machines;
        private DevExpress.XtraEditors.LabelControl MaintanenceTypes;
        private DevExpress.XtraEditors.ComboBoxEdit ShiftsComboBox;
        private DevExpress.XtraEditors.LabelControl Shifts;
        private DevExpress.XtraEditors.LabelControl Explanation;
        private DevExpress.XtraGrid.Columns.GridColumn Vardiya;
        private DevExpress.XtraGrid.Columns.GridColumn ArizaID;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
    }
}

