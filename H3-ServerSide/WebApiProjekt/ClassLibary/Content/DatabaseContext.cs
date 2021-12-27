using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibary.Models;

namespace ClassLibary.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EUDStudent> EUDStudents { get; set; }
        public DbSet<HTXStudent> HTXStudents { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options,
                               IConfiguration configuration) : base(options)
        {
            this._configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .HasOne(s => s.School)
            .WithMany(p => p.Persons)
            .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<HTXStudent>()
            .HasOne(c => c.Course)
            .WithMany(h => h.HTXStudents)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<School>().ToTable("Schools");
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<EUDStudent>().ToTable("EUDStudents");
            modelBuilder.Entity<HTXStudent>().ToTable("HTXStudents");
            modelBuilder.Entity<Course>().ToTable("Courses");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if ENABLED_FOR_LAZY_LOADING_USAGE
            string connectionString;

            connectionString = this._configuration.GetConnectionString("DBConnectionString");
            
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString);
#endif
        }
    }
}
