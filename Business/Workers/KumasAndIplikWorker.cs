using Business.Base;
using Business.Managers;
using Business.Services;
using Business.Services.Base;
using Business.Workers.Base;
using DataAccess.Unit_Of_Work;
using DataAccess.Unit_Of_Work.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workers
{
    public class KumasAndIplikWorker : IWorker
    {
        private IUnitOfWork UoW;

        public IMachineService MachineService { get; set; }
        public IMachineComponentService MachineComponentService { get; set; }
        public ICrashRegisterService CrashService { get; set; }
        public IFactoryService FactoryService { get; set; }
        public IStenterMachineService StenterService { get; set; }
        public ICostRegisterService CostService { get; set; }
        public IEmployeeService EmployeeService { get; set; }
        public IManipulatorEmployeeService ManipulatorEmployeeService { get; set; }

        public KumasAndIplikWorker(string ConnectionString = null)
        {
            UoW = new KumasAndIplikUOW(ConnectionString);

            MachineService = new MachineManager(UoW);
            MachineComponentService = new MachineComponentManager(UoW);
            CrashService = new CrashRegisterManager(UoW);
            FactoryService = new FactoryManager(UoW);
            StenterService = new StenterManager(UoW);
            CostService = new CostRegisterManager(UoW);
            EmployeeService = new EmployeeManager(UoW);
            ManipulatorEmployeeService = new ManipulatorEmployeeManager(UoW);

        }
        public bool Commit()
        {
           return UoW.Commit();
        }

        public void DetectChanges()
        {
            UoW.DetectChanges();
        }

        public bool HasChanges()
        {
           return  UoW.HasChanges();
        }
    }
}
