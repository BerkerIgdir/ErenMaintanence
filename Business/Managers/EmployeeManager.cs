using Business.Services;
using DataAccess.Unit_Of_Work.Base;
using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class EmployeeManager : BaseManager<Employee>,IEmployeeService
    {
        public EmployeeManager(IUnitOfWork UoW): base(UoW)
        {

        }
    }
}
