using Business.Services.Base;
using Business.Workers;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class CostRegisterManager : BaseManager<CostRegister>, ICostRegisterService
    {
        public CostRegisterManager(IUnitOfWork UoW): base(UoW)
        {

        }
    }
}
