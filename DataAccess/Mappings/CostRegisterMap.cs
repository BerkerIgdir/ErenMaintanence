using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class CostRegisterMap : EntityTypeConfiguration<CostRegister>
    {
        public CostRegisterMap()
        {
            Property(c => c.Name).HasMaxLength(200);
            Property(c => c.ID).IsRequired();

            ToTable("Masraf Kayit");
            Property(c => c.Name).HasColumnName("Değişen Parça İsim");
            Property(c => c.Date).HasColumnName("Tarih");
            Property(c => c.ID).HasColumnName("İşlem ID");
            Property(c => c.MachineId).HasColumnName("MakineID");
            Property(c => c.EmployeeId).HasColumnName("UstaID");
            


            //Property(c => c.RoleId).HasColumnName("ElemanID");
        }
    }
}
