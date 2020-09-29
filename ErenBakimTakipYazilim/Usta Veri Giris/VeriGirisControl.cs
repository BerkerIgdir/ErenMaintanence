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
using Business.Workers;
using Core.Extensions;
using Entities.Enums;
using Core.Form;
using Entities.Tables;
using Business.Workers.Base;
using System.Threading;
namespace ErenBakimTakipYazilim
{
    public partial class VeriGirisControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly KumasAndIplikWorker worker;
        [Category("İşlem Butonları")]
        public event EventHandler SaveOnClick;
        [Category("İşlem Butonları")]
        public event EventHandler DeleteOnClick;

        public VeriGirisControl(KumasAndIplikWorker Worker,string Factory = null)
        {
            InitializeComponent();

            worker = Worker;
 
            MachineComboBox.Enabled = false;
            if (Factory != null)
                FactoryComboBox.Properties.Items.AddRange(worker.FactoryService.Select(c => c.FactoryName == Factory, c => c.FactoryName).ToList());
            else
                FactoryComboBox.Enabled = false;

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
            CrashExplanation.Text = null;
        }


        


        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteOnClick?.Invoke(this, e);
            if (gridView1.GetFocusedRow() != null && MessageBox.Show("Secili arızayı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CrashRegister RegisterToBeDeleted = new CrashRegister();
                RegisterToBeDeleted = (CrashRegister)gridView1.GetFocusedRow();
                worker.CrashService.Delete(worker.CrashService.Get(c => c.ID == RegisterToBeDeleted.ID));
                worker.MachineService.Get(c => c.ID == RegisterToBeDeleted.RelatedMachine.ID).CrashCount--;
                worker.Commit();
                gridView1.DeleteSelectedRows();
            }

        }

        private void CrashRegisterSave_Click(object sender, EventArgs e)
        {
            SaveOnClick?.Invoke(this, e);
            if (FactoryComboBox.SelectedItem == null ||
                MachineComboBox.SelectedItem == null ||
                CrashTypeControl.SelectedItem == null ||
                ShiftsComboBox.SelectedItem == null
                )
            {
                MessageBox.Show("Belirtilen alanlar boş bırakılamaz!");
                return;
            }

            CrashRegister TempCrash = new CrashRegister
            {
                ID = Guid.NewGuid(),
                Explanation = CrashExplanation.Text,
                MachineId = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).ID,
                CrashDate_ = DateTime.Now,
                RelatedMachine = worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()),
                CrashType = (MaintanenceType)CrashTypeControl.SelectedItem,
                Shift = (Entities.Enums.Shifts)ShiftsComboBox.SelectedItem,
                RelatedPerson = worker.ManipulatorEmployeeService.Get(c=> c.Name == "Berke"),
                EmployeeId = worker.ManipulatorEmployeeService.Get(c=> c.Name == "Berker").ID
        
            };

            worker.MachineService.Get(c => c.Name == MachineComboBox.SelectedItem.ToString()).CrashCount++;
            worker.ManipulatorEmployeeService.Get(c => c.Name == "Berker").FixageCount++;
            worker.CrashService.Add(TempCrash);
            worker.Commit();
            GridViewRefresh();
        }

        private void FactoryComboBox_SelectedValueChanged(object sender, EventArgs e)
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

        private void VeriGirisControl_Load(object sender, EventArgs e)
        {

        }
    }
}
