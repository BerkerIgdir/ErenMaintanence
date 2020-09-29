        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Core.Extensions;

namespace Core.Form
{
    public partial class ConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder ConnectionBuilder = new SqlConnectionStringBuilder();
        public bool IfSaved = false;

        public ConnectionForm()
        {
            InitializeComponent();
        }

       private void BuildConnection()
        {
            ConnectionBuilder.InitialCatalog = "master";
            ConnectionBuilder.DataSource = textServer.Text;
            if (WindowsCheck.Checked)
            {
                ConnectionBuilder.IntegratedSecurity = true;

            }
            else
            {
                ConnectionBuilder.UserID = textUser.Text;
                ConnectionBuilder.Password = textPassword.Text;
                ConnectionBuilder.IntegratedSecurity = false;
    
            }
        }

        private void SqlCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SqlCheck.Checked)
            {
                textUser.Enabled = true;
                textPassword.Enabled = true;
            }
            else
            {

                textUser.Enabled = false;
                textPassword.Enabled = false;
            }
        }

        private void ConnectionCheck_Click(object sender, EventArgs e)
        {
            BuildConnection();
            if (ConnectionStringGetter.Check(ConnectionBuilder.ConnectionString))
            {
                MessageBox.Show("Connection is successful");
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void ConnectionSave_Click(object sender, EventArgs e)
        {
            BuildConnection();
            if (ConnectionStringGetter.Check(ConnectionBuilder.ConnectionString))
            {
                MessageBox.Show("Check Yapildi.");
                ConnectionBuilder.InitialCatalog = "IplikVeKumas";
                ConnectionStringGetter.Set(ConnectionBuilder.ConnectionString);
                MessageBox.Show("Set Edildi.");
                IfSaved = true;
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }
    }
    }
