using DataAccess.DAL.Base;
using DataAccess.Interfaces;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class ManipulatorEmployeeDAL : Repository<ManipulatorEmployee>,IManipulatorEmployee
    {
        public ManipulatorEmployeeDAL(DbContext Context):base(Context)
        {

        }
    }
}
