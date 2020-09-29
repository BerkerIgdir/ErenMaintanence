using Entities.Enums;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tables
{
    public class Role : EntityBase
    {
        public AuthorityTypes Authority { get; set; }


        public virtual Guid UserId { get; set; }
        public virtual User RelatedUser { get; set; }

    }
}
