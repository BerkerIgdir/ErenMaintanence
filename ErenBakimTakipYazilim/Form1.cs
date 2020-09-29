using Business.Workers;
using Core.Extensions;
using Core.Form;
using Entities.Enums;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErenBakimTakipYazilim
{
    public partial class VeriGirisForm : DevExpress.XtraEditors.XtraForm
    {
        
        KumasAndIplikWorker worker = new KumasAndIplikWorker();

        public Factory KumasBoya = new Factory
        {
            FactoryName = "Kumaş Boya",
            ID = Guid.NewGuid(),
            Machines = new List<Machine>(),

        };

        Factory IplikBoya = new Factory
        {
            FactoryName = "İplik Boya",
            ID = Guid.NewGuid(),
            Machines = new List<Machine>(),

        };

        List<string> FactoryNames = new List<string>
        {
            "Kumaş Boya",
            "İplik Boya"
        };

        List<string> KumasMachineNames = new List<string>
        {
            "Ram 1",
            "Ram 2",
            "Ram 3",
            "Santex",
            "200/1",
            "200/2"
        };

        List<string> IplikMachineNames = new List<string>
        {
            "25/1",
            "25/2",
            "25/3",
            "50/1",
            "50/2",
            "50/3"
        };

        public VeriGirisForm()
        {
            InitializeComponent();
            if (!ConnectionStringGetter.Check())
            {
                ConnectionForm ConnectionForm = new ConnectionForm();
                ConnectionForm.ShowDialog();
            }
            
            MachineComboBox.Enabled = false;
            FactoryComboBox.Properties.Items.AddRange(worker.FactoryService.Select(null, c => c.FactoryName).ToList());
            ShiftsComboBox.Properties.Items.AddRange(Enum.GetValues(typeof(Shifts)).Cast<Shifts>().ToList());
            GridViewRefresh();            
            
            CrashTypeControl.Properties.Items.AddRange(Enum.GetValues(typeof(MaintanenceType)).Cast<MaintanenceType>().ToList());
        }

        private void GridViewRefresh()
        {
            gridControl1.DataSource = worker.CrashService.GetList(null, c => c.RelatedMachine, c => c.RelatedMachine.RelatedFactory);
            FactoryComboBox.SelectedItem = null;
            MachineComboBox.SelectedItem = null;
            CrashTypeControl.SelectedItem = null;
            ShiftsComboBox.SelectedItem = null;

        }

        private void FactoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            switch (FactoryComboBox.Text) {
                case "İplik Boya":
                    MachineComboBox.Properties.Items.Clear();
                    MachineComboBox.Properties.Items.AddRange(worker.MachineService.Select(c=> c.RelatedFactory.FactoryName == "İplik Boya",c=> c.Name).ToList());
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

        private void CrashRegisterSave_Click(object sender, EventArgs e)
        {

            if (FactoryComboBox.SelectedItem == null ||
                MachineComboBox.SelectedItem == null ||
                CrashTypeControl.SelectedItem == null||
                ShiftsComboBox.SelectedItem == null
                )
            {
                MessageBox.Show("Belirtilen alanlar boş bırakılamaz!");
                return;
            }

            CrashRegister TempCrash = new CrashRegister
            {
                ID = Guid.NewGuid(),
                Explanation = ExplanationEdit.Text,
                MachineId = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).ID,
                CrashDate_ = DateTime.Now,
                RelatedMachine = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()),
                CrashType = (MaintanenceType)CrashTypeControl.SelectedItem,
                Shift = (Entities.Enums.Shifts)ShiftsComboBox.SelectedItem
            };

            worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).CrashCount++;
            worker.CrashService.Add(TempCrash);
            MessageBox.Show(TempCrash.RelatedMachine.Name);
            worker.Commit();
            GridViewRefresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if( gridView1.GetFocusedRow() != null && MessageBox.Show("Secili arızayı silmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CrashRegister RegisterToBeDeleted = new CrashRegister();
                RegisterToBeDeleted = (CrashRegister)gridView1.GetFocusedRow();
                worker.CrashService.Delete(worker.CrashService.Get(c => c.ID == RegisterToBeDeleted.ID));
                worker.MachineService.Get(c => c.ID == RegisterToBeDeleted.RelatedMachine.ID).CrashCount--;
                worker.Commit();
                gridView1.DeleteSelectedRows();
            }
        }
    }


}
