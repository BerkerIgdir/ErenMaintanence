using Entities.Enums;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class Factory : EntityBase
    {
        public Factory()
        {
            this.ID = new Guid();
         
        }
        public string FactoryName { get; set; }

        public ICollection<Machine> Machines { get; set; }

        public ICollection<ManipulatorEmployee> Employees { get; set; }

    }
}
