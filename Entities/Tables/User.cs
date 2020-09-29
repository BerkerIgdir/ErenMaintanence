using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class User : EntityBase
    {

        public Role Role_ { get; set; }
            
    }
}
