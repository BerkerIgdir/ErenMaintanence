using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts.KumasAndIplik
{
    public class KumasAndIplikConfig: DbMigrationsConfiguration<KumasAndIplikContext>
    {
        public KumasAndIplikConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
