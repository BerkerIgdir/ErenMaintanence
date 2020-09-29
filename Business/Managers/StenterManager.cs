using Business.Services.Base;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class StenterManager: BaseManager<StenterMachine>, IStenterMachineService
    {
        public StenterManager(IUnitOfWork UoW):base(UoW)
        {

        }
    }
}
