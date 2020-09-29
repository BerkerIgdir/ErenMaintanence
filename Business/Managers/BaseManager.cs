using Business.Base;
using DataAccess.Unit_Of_Work.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private IUnitOfWork UoW;
        public BaseManager(IUnitOfWork UnitOfWork)
        {
            UoW = UnitOfWork;
        }
        public virtual void Add(TEntity Entity)
        {
            UoW.DAL<TEntity>().Add(Entity);
        }

        public virtual void Add(IEnumerable<TEntity> Entities)
        {
            UoW.DAL<TEntity>().Add(Entities);
        }

        public virtual void AddOrUpdate(TEntity Entity)
        {
            UoW.DAL<TEntity>().AddOrUpdate(Entity);
        }

        public virtual void AddOrUpdate(IEnumerable<TEntity> Entity)
        {
            UoW.DAL<TEntity>().AddOrUpdate(Entity);
        }

        public virtual BindingList<TEntity> BindingList_()
        {
           return  UoW.DAL<TEntity>().BindingList_();
        }

        public virtual void Delete(TEntity Entity)
        {
            UoW.DAL<TEntity>().Delete(Entity);

        }

        public virtual void Delete(IEnumerable<TEntity> Entities)
        {
            UoW.DAL<TEntity>().Delete(Entities);

        }

        public virtual void Delete(Expression<Func<TEntity, bool>> Filter)
        {
            UoW.DAL<TEntity>().Delete(Filter);

        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> Filter)
        {
            return UoW.DAL<TEntity>().Exist(Filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes)
        {
            return UoW.DAL<TEntity>().Get(Filter,Includes);

        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes)
        {
            return UoW.DAL<TEntity>().GetList(Filter,Includes);

        }

        public virtual bool HasChanges()
        {
            return UoW.DAL<TEntity>().HasChanges();
        }

        public virtual void Load(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes)
        {
            UoW.DAL<TEntity>().Load(Filter,Includes);

        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity, TEntity>> Selector, params Expression<Func<TEntity, object>>[] Includes)
        {
           return UoW.DAL<TEntity>().Select(Filter,Selector,Includes);

        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity, TResult>> Selector, params Expression<Func<TEntity, object>>[] Includes)
        {
            return UoW.DAL<TEntity>().Select(Filter,Selector,Includes);
        }

        public virtual void Update(TEntity Entity)
        {
            UoW.DAL<TEntity>().Update(Entity);

        }

        public virtual void Update(IEnumerable<TEntity> Entities)
        {
            UoW.DAL<TEntity>().Update(Entities);

        }
    }
}
