using Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
   public class CrashRegisterMap:EntityTypeConfiguration<CrashRegister>
    {

        public CrashRegisterMap()
        {
            Property(c => c.Explanation).HasMaxLength(200);
            Property(c => c.ID).IsRequired();

            ToTable("Ariza Kayit");
            Property(c => c.Explanation).HasColumnName("Aciklama");
            Property(c => c.CrashDate_).HasColumnName("Tarih");
            Property(c => c.ID).HasColumnName("ArızaID");
            Property(c => c.MachineId).HasColumnName("İlgiliMakine");
            Property(c => c.MachineComponentId).HasColumnName("IlgiliMakineParcasi");
            Property(c => c.Shift).HasColumnName("Vardiya");
            Property(c => c.EmployeeId).HasColumnName("IlgiliPersonel");
        }

    }
}
