using DataAccess.Interfaces.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Unit_Of_Work.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> DAL<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}
