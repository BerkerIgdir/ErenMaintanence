namespace ErenBakimTakipYazilim.Usta_Veri_Giris
{
    partial class CostControl
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Machine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DegisenParca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.MachineComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CostDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FactoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Fiyat = new DevExpress.XtraEditors.LabelControl();
            this.MachineElementText = new DevExpress.XtraEditors.TextEdit();
            this.CostText = new DevExpress.XtraEditors.TextEdit();
            this.ElementCount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineElementText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(983, 393);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Machine,
            this.DegisenParca,
            this.Cost,
            this.Date,
            this.Count});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Machine
            // 
            this.Machine.Caption = "Makine";
            this.Machine.FieldName = "RelatedMachine.Name";
            this.Machine.Name = "Machine";
            this.Machine.OptionsColumn.AllowEdit = false;
            this.Machine.OptionsColumn.ReadOnly = true;
            this.Machine.Visible = true;
            this.Machine.VisibleIndex = 0;
            // 
            // DegisenParca
            // 
            this.DegisenParca.Caption = "Değişen Parça";
            this.DegisenParca.FieldName = "Name";
            this.DegisenParca.Name = "DegisenParca";
            this.DegisenParca.OptionsColumn.AllowEdit = false;
            this.DegisenParca.OptionsColumn.ReadOnly = true;
            this.DegisenParca.Visible = true;
            this.DegisenParca.VisibleIndex = 1;
            // 
            // Cost
            // 
            this.Cost.Caption = "Fiyat";
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.OptionsColumn.AllowEdit = false;
            this.Cost.OptionsColumn.ReadOnly = true;
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 2;
            // 
            // Date
            // 
            this.Date.Caption = "Tarih";
            this.Date.DisplayFormat.FormatString = "d";
            this.Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.OptionsColumn.AllowEdit = false;
            this.Date.OptionsColumn.ReadOnly = true;
            this.Date.Visible = true;
            this.Date.VisibleIndex = 4;
            // 
            // Count
            // 
            this.Count.Caption = "Adet";
            this.Count.Name = "Count";
            this.Count.OptionsColumn.AllowEdit = false;
            this.Count.OptionsColumn.ReadOnly = true;
            this.Count.Visible = true;
            this.Count.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 459);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Makine";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(796, 591);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 58);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Excel\'e Aktar";
            // 
            // MachineComboBox
            // 
            this.MachineComboBox.Location = new System.Drawing.Point(15, 477);
            this.MachineComboBox.Name = "MachineComboBox";
            this.MachineComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MachineComboBox.Size = new System.Drawing.Size(100, 20);
            this.MachineComboBox.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 502);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Parça İsim";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(591, 590);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(171, 58);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Sil";
            // 
            // CostDatePicker
            // 
            this.CostDatePicker.Location = new System.Drawing.Point(15, 606);
            this.CostDatePicker.Name = "CostDatePicker";
            this.CostDatePicker.Size = new System.Drawing.Size(200, 21);
            this.CostDatePicker.TabIndex = 7;
            // 
            // FactoryComboBox
            // 
            this.FactoryComboBox.Location = new System.Drawing.Point(15, 434);
            this.FactoryComboBox.Name = "FactoryComboBox";
            this.FactoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FactoryComboBox.Size = new System.Drawing.Size(100, 20);
            this.FactoryComboBox.TabIndex = 9;
            this.FactoryComboBox.SelectedIndexChanged += new System.EventHandler(this.FactoryComboBox_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 416);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Fabrika";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 588);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "İşlem Tarihi";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(386, 588);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(171, 58);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "Kaydet";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(134, 545);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Adet";
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(15, 545);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(24, 13);
            this.Fiyat.TabIndex = 15;
            this.Fiyat.Text = "Fiyat";
            // 
            // MachineElementText
            // 
            this.MachineElementText.Location = new System.Drawing.Point(15, 519);
            this.MachineElementText.Name = "MachineElementText";
            this.MachineElementText.Size = new System.Drawing.Size(100, 20);
            this.MachineElementText.TabIndex = 17;
            this.MachineElementText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MachineElementText_KeyPress);
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(15, 564);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(100, 20);
            this.CostText.TabIndex = 18;
            this.CostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostText_KeyPress);
            // 
            // ElementCount
            // 
            this.ElementCount.Location = new System.Drawing.Point(134, 564);
            this.ElementCount.Name = "ElementCount";
            this.ElementCount.Size = new System.Drawing.Size(23, 20);
            this.ElementCount.TabIndex = 19;
            this.ElementCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ElementCount_KeyPress);
            // 
            // CostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ElementCount);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.MachineElementText);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.FactoryComboBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.CostDatePicker);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.MachineComboBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "CostControl";
            this.Size = new System.Drawing.Size(983, 670);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineElementText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementCount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn Machine;
        private DevExpress.XtraGrid.Columns.GridColumn DegisenParca;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraEditors.ComboBoxEdit MachineComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DateTimePicker CostDatePicker;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraEditors.ComboBoxEdit FactoryComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl Fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraEditors.TextEdit MachineElementText;
        private DevExpress.XtraEditors.TextEdit CostText;
        private DevExpress.XtraEditors.TextEdit ElementCount;
    }
}
