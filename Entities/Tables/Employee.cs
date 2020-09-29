using Entities.Enums;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class Employee : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public AuthorityTypes Authority { get; set; }
        public bool IsOnline { get; set; }
        public string Password { get; set; }
        public string ComputerIdentity { get; set; }
    }
}
