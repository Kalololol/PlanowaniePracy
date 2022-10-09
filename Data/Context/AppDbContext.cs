using Domain.Entities.Planner;
using Domain.Entities.Team;
using Domain.Entities.Team.WardPreferences;
using Domain.Work;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet'y
        DbSet<PlanDay> PlanDays { get; set; }
        DbSet<PlanMonth> PlanMonths { get; set; }
        DbSet<Contract> Contracts { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Manager> Managers { get; set; }
        DbSet<Ward> Wards { get; set; }
        DbSet<WorkAssumptions> WorkAssumptions { get; set; }
        DbSet<Indisposition> Indispositions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>(eb =>
           {
               eb.Property(x => x.Name).IsRequired().HasMaxLength(50);
               eb.Property(x => x.Surname).IsRequired().HasMaxLength(80);
               eb.Property(x => x.AddressEmail).IsRequired().HasMaxLength(150);
               eb.Property(x => x.LicenseNumber).IsRequired();
               eb.Property(x => x.Password).IsRequired();
               eb.Property(x => x.PhoneNumber).HasMaxLength(12);
               eb.Property(x => x.ActiveAccount).HasDefaultValue(true);
               eb.Property(x => x.Created).HasDefaultValueSql("getutcdate()");
               eb.Property(x => x.LastModified).ValueGeneratedOnUpdate();
               eb.HasOne(x => x.Contract)
               .WithOne(x => x.Employee)
               .HasForeignKey<Contract>(x => x.EmployeeId);
               eb.HasMany(x => x.Indispositions)
               .WithOne(x => x.Employee)
               .HasForeignKey(x => x.EmployeeId);

           });

            modelBuilder.Entity<Contract>(eb =>
            {
                eb.Property(x => x.DeclaredHours).IsRequired();
                eb.Property(x => x.ContractType).IsRequired();
                eb.Property(x => x.Created).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.LastModified).ValueGeneratedOnUpdate();

            });

            modelBuilder.Entity<Indisposition>(eb =>
            {
                eb.Property(x => x.DayIndisposition).IsRequired();
                eb.Property(x => x.Created).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.LastModified).ValueGeneratedOnUpdate();


            });
            modelBuilder.Entity<Ward>(eb =>
            {
                eb.Property(x => x.WardName).IsRequired();
                eb.Property(x => x.Created).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.LastModified).ValueGeneratedOnUpdate();
                eb.HasMany(x => x.Employees)
                .WithOne(x => x.Ward)
                .HasForeignKey(x => x.WardId);
            });
           
            base.OnModelCreating(modelBuilder);

        }
    }
}
