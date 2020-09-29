using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class CostRegister : EntityBase
    {
        // Bu ve CrashRegister tek bir sınıftan kalıtılsa daha iyi olabilirdi.

        public Guid EmployeeId { get; set; }
        public virtual ManipulatorEmployee RelatedPerson { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }
        public Guid MachineId { get; set; }
        public virtual Machine RelatedMachine { get; set; }


        public Guid? MachineComponentId { get; set; }
        public virtual MachineComponent RelatedMachineComponent { get; set; }
    }
}
