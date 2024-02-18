using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_DataAccess.Context
{
    public class SchoolBusDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = new ConfigurationManager().AddJsonFile("appsettings.json").Build().GetConnectionString("DefaultConnection");

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
