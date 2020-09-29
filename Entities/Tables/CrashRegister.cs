using Entities.Enums;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class CrashRegister : EntityBase
    {

        public Guid MachineId { get; set; }
        public virtual Machine RelatedMachine { get; set; }

        public Guid? MachineComponentId { get; set; }
        public virtual MachineComponent RelatedMachineComponent { get; set; }

        public Guid EmployeeId { get; set; }
        public virtual ManipulatorEmployee RelatedPerson { get; set; }

        public string Explanation { get; set; }
        public DateTime CrashDate_ { get; set; }
       
        public MaintanenceType CrashType { get; set; }
        public Shifts Shift { get; set; }

    }
}
