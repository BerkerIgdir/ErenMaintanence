using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class Machine : EntityBase
    {

        public string Name { get; set; }

        public ICollection<DateTime> MaintenanceDates { get; set; }
        public decimal Cost { get; set; }
        public virtual ICollection<CostRegister> RegisteredCosts { get; set; }
        public int CrashCount { get; set; }
        public virtual ICollection<CrashRegister> RegisteredCrashes { get; set; }

        public virtual ICollection<MachineComponent> MachineComponents { get; set; }
        public Guid FactoryId { get; set; }
        public virtual Factory RelatedFactory { get; set; }
        
    }
}
