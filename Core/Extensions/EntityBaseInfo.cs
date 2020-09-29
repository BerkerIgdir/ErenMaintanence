using Entities.Tables;
using Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext Context)
        {
            foreach(var Ent in Context.ChangeTracker.Entries())
            {
                CrashRegister ChangedEntity = (CrashRegister)Ent.Entity;
                switch (Ent.State)
                {
                    case EntityState.Added:
                        ChangedEntity.ID = Guid.NewGuid();
                        ChangedEntity.CrashDate_ = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        ChangedEntity.CrashDate_ = DateTime.Now;
                        break;
                }
            }

        }
    }
}
