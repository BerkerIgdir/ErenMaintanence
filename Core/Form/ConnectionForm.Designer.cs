namespace Core.Form
{
    partial class ConnectionForm
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
            this.WindowsCheck = new DevExpress.XtraEditors.CheckButton();
            this.SqlCheck = new DevExpress.XtraEditors.CheckButton();
            this.textServer = new DevExpress.XtraEditors.TextEdit();
            this.textUser = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.ConnectionCheck = new DevExpress.XtraEditors.SimpleButton();
            this.ConnectionSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsCheck
            // 
            this.WindowsCheck.GroupIndex = 1;
            this.WindowsCheck.Location = new System.Drawing.Point(35, 52);
            this.WindowsCheck.Name = "WindowsCheck";
            this.WindowsCheck.Size = new System.Drawing.Size(160, 118);
            this.WindowsCheck.TabIndex = 0;
            this.WindowsCheck.TabStop = false;
            this.WindowsCheck.Text = "Windows Oturumu";
            // 
            // SqlCheck
            // 
            this.SqlCheck.GroupIndex = 1;
            this.SqlCheck.Location = new System.Drawing.Point(247, 52);
            this.SqlCheck.Name = "SqlCheck";
            this.SqlCheck.Size = new System.Drawing.Size(160, 118);
            this.SqlCheck.TabIndex = 1;
            this.SqlCheck.TabStop = false;
            this.SqlCheck.Text = "SQL Server Oturumu";
            this.SqlCheck.CheckedChanged += new System.EventHandler(this.SqlCheck_CheckedChanged);
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(35, 233);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(372, 20);
            this.textServer.TabIndex = 2;
            // 
            // textUser
            // 
            this.textUser.Enabled = false;
            this.textUser.Location = new System.Drawing.Point(35, 278);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(372, 20);
            this.textUser.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Location = new System.Drawing.Point(35, 323);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(372, 20);
            this.textPassword.TabIndex = 4;
            // 
            // ConnectionCheck
            // 
            this.ConnectionCheck.Location = new System.Drawing.Point(29, 382);
            this.ConnectionCheck.Name = "ConnectionCheck";
            this.ConnectionCheck.Size = new System.Drawing.Size(108, 39);
            this.ConnectionCheck.TabIndex = 5;
            this.ConnectionCheck.Text = "Bağlantı Test";
            this.ConnectionCheck.Click += new System.EventHandler(this.ConnectionCheck_Click);
            // 
            // ConnectionSave
            // 
            this.ConnectionSave.Location = new System.Drawing.Point(167, 382);
            this.ConnectionSave.Name = "ConnectionSave";
            this.ConnectionSave.Size = new System.Drawing.Size(108, 39);
            this.ConnectionSave.TabIndex = 6;
            this.ConnectionSave.Text = "Ayarları Kaydet";
            this.ConnectionSave.Click += new System.EventHandler(this.ConnectionSave_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(305, 382);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(108, 39);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Kapat";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 501);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.ConnectionSave);
            this.Controls.Add(this.ConnectionCheck);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.SqlCheck);
            this.Controls.Add(this.WindowsCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.textServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton WindowsCheck;
        private DevExpress.XtraEditors.CheckButton SqlCheck;
        private DevExpress.XtraEditors.TextEdit textServer;
        private DevExpress.XtraEditors.TextEdit textUser;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.SimpleButton ConnectionCheck;
        private DevExpress.XtraEditors.SimpleButton ConnectionSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}