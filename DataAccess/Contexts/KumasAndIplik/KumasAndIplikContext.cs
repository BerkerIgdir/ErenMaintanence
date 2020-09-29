using DataAccess.Contexts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using Entities.Tables;
using System.Threading.Tasks;
using Entities.Tables.Base;
using DataAccess.Mappings;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.Contexts.KumasAndIplik
{
    public class KumasAndIplikContext : BaseContext<KumasAndIplikContext>
    {
        
        public KumasAndIplikContext() 
        {

        }

        public KumasAndIplikContext(string ConnectionString ) : base(ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KumasAndIplikContext, KumasAndIplikConfig>());
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineComponent> MachineComponents { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<CrashRegister> CrashRegisters { get; set; }
        public DbSet<CostRegister> CostRegisters { get; set; }
        public DbSet<StenterMachine> Stenters { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ManipulatorEmployee> ManipulatorEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                c.HasKey(e => e.ID);
                c.Property(e => e.ID).HasColumnName("ID");
            });

            modelBuilder.Entity<CrashRegister>().HasRequired(c => c.RelatedMachine).WithMany(c => c.RegisteredCrashes).HasForeignKey(c => c.MachineId);
            modelBuilder.Entity<CrashRegister>().HasRequired(c => c.RelatedMachineComponent).WithMany(c => c.RegistedCrashes).HasForeignKey(c => c.MachineComponentId);
            modelBuilder.Entity<CrashRegister>().HasRequired(c => c.RelatedPerson).WithMany(c => c.RegisteredCrashes).HasForeignKey(c => c.EmployeeId);

            modelBuilder.Entity<Machine>().HasRequired(c => c.RelatedFactory).WithMany(c => c.Machines).HasForeignKey(c => c.FactoryId);

            modelBuilder.Entity<MachineComponent>().HasRequired(c => c.RelatedMachine).WithMany(c => c.MachineComponents).HasForeignKey(c => c.MachineId);

            modelBuilder.Entity<CostRegister>().HasRequired(c => c.RelatedMachine).WithMany(c => c.RegisteredCosts).HasForeignKey(c => c.MachineId);
            modelBuilder.Entity<CostRegister>().HasRequired(c => c.RelatedMachineComponent).WithMany(c => c.RegisteredCosts).HasForeignKey(c => c.MachineComponentId);
            modelBuilder.Entity<CostRegister>().HasRequired(c => c.RelatedPerson).WithMany(c => c.RegisteredCosts).HasForeignKey(c => c.EmployeeId);

            modelBuilder.Entity<ManipulatorEmployee>().HasRequired(c => c.RelatedFactory).WithMany(c => c.Employees).HasForeignKey(c => c.FactoryId);
           

            modelBuilder.Configurations.Add(new CrashRegisterMap());
            modelBuilder.Configurations.Add(new FactoryMap());
            modelBuilder.Configurations.Add(new MachineMap());
            modelBuilder.Configurations.Add(new StenterMachineMapping());
            modelBuilder.Configurations.Add(new CostRegisterMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ManipulatorEmployeeMap());
 
            
        }
       
    }
}
