using Business.Services.Base;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class MachineComponentManager : BaseManager<MachineComponent>,IMachineComponentService
    {
        public MachineComponentManager(IUnitOfWork UoW):base(UoW)
        {

        }
    }
}
