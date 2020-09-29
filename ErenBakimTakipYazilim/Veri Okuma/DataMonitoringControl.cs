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

namespace ErenBakimTakipYazilim.Veri_Okuma
{
    public partial class DataMonitoringControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly string MachineName;
        public DataMonitoringControl(string Machine, KumasAndIplikWorker worker)
        {
            InitializeComponent();
            MachineName = Machine;

            worker.CrashService.Load(null);
            CrashCountChart.DataSource = worker.CrashService.BindingList_();
            MessageBox.Show(worker.CrashService.BindingList_().Count.ToString());
            MessageBox.Show(MachineName);

        }



    }
}
