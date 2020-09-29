using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Business.Workers;
using DevExpress.XtraEditors;

namespace ErenBakimTakipYazilim.AssistantMethod
{
    public class ManipulatorInitializer : FormIniliazerClass
    {
        public ManipulatorInitializer(WindowsIdentity Identity): base(Identity)
        {

        }

        public override XtraUserControl Initialize(string Config, KumasAndIplikWorker Worker)
        {
            throw new NotImplementedException();
        }
    }
}
