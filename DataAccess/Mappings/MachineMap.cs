using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MachineMap : EntityTypeConfiguration<Machine>
    {
        public MachineMap()
        {
            Property(c => c.Name).HasMaxLength(40);
            Property(c => c.Cost).HasPrecision(10, 2);


            ToTable("Makineler");
            Property(c => c.ID).HasColumnName("MakineID");
            Property(c => c.Name).HasColumnName("MakineIsim");
            Property(c => c.Cost).HasColumnName("MakineMasraf");
            Property(c => c.FactoryId).HasColumnName("FabrikaID");
            Property(c => c.CrashCount).HasColumnName("Arıza Sayısı");
        }


    }
}
