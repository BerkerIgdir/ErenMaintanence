using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess.Unit_Of_Work;
using Business.Workers;
using Entities.Tables;

namespace ErenBakimTakipYazilim.Usta_Veri_Giris
{
    public partial class CostControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly KumasAndIplikWorker worker;
        public CostControl(KumasAndIplikWorker Worker)
        {
            InitializeComponent();
            worker = Worker;
            MachineComboBox.Enabled = false;
            FactoryComboBox.Properties.Items.AddRange(worker.FactoryService.Select(null, c => c.FactoryName).ToList());
            GridViewRefresh();
        }

        private void GridViewRefresh()
        {
            gridControl1.DataSource = worker.CostService.GetList(null, c => c.RelatedMachine, c => c.RelatedMachine.RelatedFactory);
            FactoryComboBox.SelectedItem = null;
            MachineComboBox.SelectedItem = null;
        }



        private void FactoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FactoryComboBox.Text)
            {
                case "İplik Boya":
                    MachineComboBox.Properties.Items.Clear();
                    MachineComboBox.Properties.Items.AddRange(worker.MachineService.Select(c => c.RelatedFactory.FactoryName == "İplik Boya", c => c.Name).ToList());
                    MachineComboBox.Enabled = true;
                    break;
                case "Kumaş Boya":
                    MachineComboBox.Properties.Items.Clear();
                    MachineComboBox.Properties.Items.AddRange(worker.MachineService.Select(c => c.RelatedFactory.FactoryName == "Kumaş Boya", c => c.Name).ToList());
                    MachineComboBox.Enabled = true;
                    break;
                default:
                    MachineComboBox.Enabled = false;
                    break;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (FactoryComboBox.SelectedItem == null ||
                MachineComboBox.SelectedItem == null 
                )
            {
                MessageBox.Show("Belirtilen alanlar boş bırakılamaz!");
                return;
            }

            CostRegister TempCost = new CostRegister
            {
                ID = Guid.NewGuid(),
                Name = MachineElementText.Text,
                MachineId = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).ID,
                Date = CostDatePicker.Value,
                RelatedMachine = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()),
               
            };

            worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).Cost ++;
            worker.CostService.Add(TempCost);
            worker.Commit();
            GridViewRefresh();
        }

        private void MachineElementText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void CostText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void ElementCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
