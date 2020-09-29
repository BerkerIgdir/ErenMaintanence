using Business.Base;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class CrashRegisterManager:BaseManager<CrashRegister>,ICrashRegisterService
    {
        public CrashRegisterManager(IUnitOfWork UoW):base(UoW)
        {

        }
    }
}
