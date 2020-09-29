using Core.Extensions;
using DataAccess.Contexts.KumasAndIplik;
using DataAccess.DAL;
using DataAccess.DAL.Base;
using DataAccess.Interfaces;
using DataAccess.Interfaces.Base;
using DataAccess.Unit_Of_Work.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.Unit_Of_Work
{
    public class KumasAndIplikUOW : IUnitOfWork
    {

        private readonly KumasAndIplikContext Context;

        public ICrashRegister CrashRegister { get; set; }
        public IFactory Factory { get; set; }
        public IMachineDAL Machine { get; set; }
        public IMachineComponent MachineComponent { get; set; }
        public IStenterMachineDal StenterMachine { get; set; }
        public IEmployee Employee { get; set; }
        public IManipulatorEmployee ManipulatorEmployee { get; set; }


       public KumasAndIplikUOW(string ConnectionString = null)
        {
            if(ConnectionString == null)
            {
                Context = new KumasAndIplikContext(ConnectionStringGetter.Get());
            }
            else
            {
                Context = new KumasAndIplikContext(ConnectionString);
            }

            CrashRegister = new CrashRegisterDAL(Context);
            Factory = new FactoryDAL(Context);
            Machine = new MachineDAL(Context);
            MachineComponent = new MachineComponentDAL(Context);
            StenterMachine = new StenterMachineDAL(Context);
            Employee = new EmployeeDAL(Context);
            ManipulatorEmployee = new ManipulatorEmployeeDAL(Context);
            
            
        }

        public bool Commit()
        {
            //EntityBaseInfo.Add(Context);
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public void DetectChanges()
        {
             Context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            return Context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.DAL<TEntity>()
        {
            return new Repository<TEntity>(Context);

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~KumasAndIplikUOW() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
