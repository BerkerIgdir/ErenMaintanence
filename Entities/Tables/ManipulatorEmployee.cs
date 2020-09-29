using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Tables
{
    public class ManipulatorEmployee : Employee
    {

        public Guid FactoryId { get; set; }
        public Factory RelatedFactory { get; set; }

        public int Age { get; set; }
        public int FixageCount { get; set; }

        public MaintanenceType Crew { get; set; }

        public virtual ICollection<CrashRegister> RegisteredCrashes { get; set; }
        public virtual ICollection<CostRegister> RegisteredCosts { get; set; }

    }
}
