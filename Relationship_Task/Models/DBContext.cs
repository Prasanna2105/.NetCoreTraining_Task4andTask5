using Microsoft.EntityFrameworkCore;
using System;
using Relationship_Task.Models;

namespace Relationship_Task.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Skillmaps> Skillmaps { get; set; }
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureModels(modelBuilder);
        }
        private static void ConfigureModels(ModelBuilder modelBuilder)
        {

            #region Entity: Employees
            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<Employees>().Property(x => x.employee_name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.status).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.manager).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.wfm_manager).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.email).HasMaxLength(100).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.lockstatus).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.experience).HasColumnType("decimal(5,0)");
            #endregion


            #region Entity: Skills
            modelBuilder.Entity<Skills>().ToTable("Skills");
            modelBuilder.Entity<Skills>().Property(x => x.skillname).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            #endregion


            #region Entity: Skillmaps
            modelBuilder.Entity<Skillmaps>().ToTable("Skillmaps");
            modelBuilder.Entity<Skillmaps>().HasKey(sm => new { sm.employee_id, sm.skillid });
            modelBuilder.Entity<Skillmaps>().HasOne(sm => sm.employees).WithMany(sm => sm.Skillmaps).HasForeignKey(sm => sm.employee_id);
            modelBuilder.Entity<Skillmaps>().HasOne(sm => sm.skills).WithMany(sm => sm.Skillmaps).HasForeignKey(sm => sm.skillid);
            #endregion
        }
        public DbSet<Relationship_Task.Models.Employeeswithskills> Employeeswithskills { get; set; }
    }
}
