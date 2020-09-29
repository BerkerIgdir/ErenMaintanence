using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class IncludeMultiple
    {

        public static IQueryable<TEntity> MultipleInclude<TEntity>(this IQueryable<TEntity> Query, params Expression<Func<TEntity,object>>[] Includes) where TEntity : class,IEntity, new()
        {
            if (Includes != null)
            {
                Query = Includes.Aggregate(Query, (current, include) => current.Include(include));
            }

            return Query;

        }

    }
}
