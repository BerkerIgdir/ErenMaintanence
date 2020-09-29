using Core.Extensions;
using DataAccess.Interfaces.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Base   
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }


        public void Add(TEntity Entity)
        {
            Context.Entry(Entity).State = EntityState.Added;
        }

        public void Add(IEnumerable<TEntity> Entities)
        {
            foreach(var ent in Entities)
            {
                Context.Entry(ent).State = EntityState.Added;
            }
        }

        public void AddOrUpdate(TEntity Entity)
        {
            Context.Set<TEntity>().AddOrUpdate(Entity);
        }

        public void AddOrUpdate(IEnumerable<TEntity> Entity)
        {
            foreach (var ent in Entity)
            {

                Context.Set<TEntity>().AddOrUpdate(ent);
                
            }
        }

        public BindingList<TEntity> BindingList_()
        {
            return Context.Set<TEntity>().Local.ToBindingList();
        }

        public void Delete(TEntity Entity)
        {
            Context.Entry(Entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<TEntity> Entities)
        {
            foreach (var ent in Entities)
            {
                Context.Entry(ent).State = EntityState.Deleted;
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> Filter)
        {
            Context.Set<TEntity>().RemoveRange(Context.Set<TEntity>().Where(Filter));
        }

        public bool Exist(Expression<Func<TEntity, bool>> Filter)
        {
            return Context.Set<TEntity>().Any(Filter);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes)
        {

           
            return Context.Set<TEntity>().MultipleInclude(Includes).SingleOrDefault(Filter);

        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes)
        {
            return Filter == null ? Context.Set<TEntity>().MultipleInclude(Includes).AsNoTracking().ToList() : Context.Set<TEntity>().Where(Filter).AsNoTracking().ToList();
        }

        public bool HasChanges()
        {
            return Context.ChangeTracker.Entries<TEntity>().Any();
        }

        public void Load(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity,object>>[] Includes)
        {

            if (Filter == null)
            {
                Context.Set<TEntity>().Load();
            }
            else
            {
                Context.Set<TEntity>().Where(Filter).Load();
            }
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity, TEntity>> Selector, params Expression<Func<TEntity, object>>[] Includes)
        {
            return Filter == null ? Context.Set<TEntity>().MultipleInclude(Includes).Select(Selector) :
                Context.Set<TEntity>().Where(Filter).Select(Selector);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity, TResult>> Selector, params Expression<Func<TEntity, object>>[] Includes)
        {
            return Filter == null ? Context.Set<TEntity>().MultipleInclude(Includes).Select(Selector) :
               Context.Set<TEntity>().Where(Filter).Select(Selector);
        }

            public void Update(TEntity Entity)
        {
            Context.Entry(Entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> Entities)
        {
            foreach  (var ent in Entities)
            {
                Context.Entry(ent).State  = EntityState.Modified;
            }
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
        // ~Repository() {
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
