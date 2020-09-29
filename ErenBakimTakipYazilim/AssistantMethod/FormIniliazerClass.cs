using Business.Workers;
using Entities.Tables;
using ErenBakimTakipYazilim.Veri_Okuma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErenBakimTakipYazilim.AssistantMethod
{
    public abstract class FormIniliazerClass
    {
        WindowsIdentity MyIdentity;

        public FormIniliazerClass(WindowsIdentity Identity)
        {
            MyIdentity = Identity;
        }
        public abstract DevExpress.XtraEditors.XtraUserControl Initialize(string Config, KumasAndIplikWorker Worker);
        }
}

