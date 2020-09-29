using Business.Base;
using Business.Services;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class MachineManager : BaseManager<Machine>, IMachineService
    {
        public MachineManager(IUnitOfWork UoW):base(UoW)
        {

        }
    }
}
