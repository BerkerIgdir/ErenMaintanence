using DataAccess.DAL.Base;
using DataAccess.Interfaces;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class MachineComponentDAL : Repository<MachineComponent> , IMachineComponent
    {
        public MachineComponentDAL(DbContext Context) : base(Context)
        {


        }


    }
}
