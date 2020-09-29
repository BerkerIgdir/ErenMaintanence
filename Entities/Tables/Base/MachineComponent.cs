using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables.Base
{
    public class MachineComponent : EntityBase
    {
        public Guid MachineId { get; set; }
        public virtual Machine RelatedMachine { get; set; }

        public ICollection<CrashRegister> RegistedCrashes { get; set; }
        public ICollection<CostRegister> RegisteredCosts{ get; set; }

    }
}
