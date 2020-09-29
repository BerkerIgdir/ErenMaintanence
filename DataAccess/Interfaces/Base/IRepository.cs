using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces.Base    
{
   public interface IRepository<TEntity>:IDisposable where TEntity: class,IEntity,new()
    {

        void Add(TEntity Entity);

        void Add(IEnumerable<TEntity> Entities);

        void AddOrUpdate(TEntity Entity);

        void AddOrUpdate(IEnumerable<TEntity> Entity);

        void Update(TEntity Entity);

        void Update(IEnumerable<TEntity> Entities);

        void Delete(TEntity Entity);

        void Delete(IEnumerable<TEntity> Entities);

        void Delete(Expression<Func<TEntity, bool>> Filter);


        TEntity Get(Expression<Func<TEntity, bool>> Filter,params Expression<Func<TEntity, object>>[] Includes);

        bool Exist(Expression<Func<TEntity, bool>> Filter);

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> Filter,params Expression<Func<TEntity,  object>>[] Includes);

        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> Filter, Expression<Func<TEntity, TEntity>> Selector, params Expression<Func<TEntity, object>>[] Includes);

        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> Filter,  Expression<Func<TEntity, TResult>> Selector,params Expression<Func<TEntity, object>>[] Includes);

        void Load(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] Includes);

        bool HasChanges();

        BindingList<TEntity> BindingList_();

    }
}
