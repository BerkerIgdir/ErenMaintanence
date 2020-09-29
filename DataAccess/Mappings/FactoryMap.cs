using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class FactoryMap : EntityTypeConfiguration<Factory>
    {
        public FactoryMap()
        {

            ToTable("Fabrikalar");
            Property(c => c.FactoryName).HasColumnName("FabrikaIsim");
            Property(c => c.ID).HasColumnName("FabrikaID");

        }


    }
}
