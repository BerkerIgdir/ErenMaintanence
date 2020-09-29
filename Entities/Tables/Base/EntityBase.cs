using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables.Base
{
    public class EntityBase : IEntity
    {
        public Guid ID { get; set; }
    }
}
