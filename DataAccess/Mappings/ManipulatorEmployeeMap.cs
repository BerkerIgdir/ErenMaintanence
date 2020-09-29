using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class ManipulatorEmployeeMap: EntityTypeConfiguration<ManipulatorEmployee>
    {
        public ManipulatorEmployeeMap()
        {
            Property(c => c.Name).HasMaxLength(40);
            Property(c => c.Surname).HasMaxLength(40);
            Property(c => c.Password).HasMaxLength(10);

            ToTable("Ustalar");
            Property(c => c.ID).HasColumnName("PersonelID");
            Property(c => c.Authority).HasColumnName("Yetki");
            Property(c => c.IsOnline).HasColumnName("Cevrimici");
            Property(c => c.FactoryId).HasColumnName("BagliOlduguFabrika");
            Property(c => c.FixageCount).HasColumnName("ArizaaMudaheleSayisi");
            Property(c => c.Crew).HasColumnName("Ekip");
            Property(c => c.Password).HasColumnName("Sifre");


        }
    }
}
