using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class EmployeeMap: EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            Property(c => c.Name).HasMaxLength(40);
            Property(c => c.Surname).HasMaxLength(40);
            Property(c => c.Password).HasMaxLength(10);

            ToTable("Calisanlar");
            Property(c => c.ID).HasColumnName("PersonelID");
            Property(c => c.Name).HasColumnName("PersonelIsim");
            Property(c => c.Surname).HasColumnName("PersonelSoyisim");
            Property(c => c.Authority).HasColumnName("Yetki");
            Property(c => c.IsOnline).HasColumnName("Cevrimici");
            Property(c => c.ComputerIdentity).HasColumnName("BilgisayarAgIsmi");
            
            
        }
    }
}
