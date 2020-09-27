using Microsoft.EntityFrameworkCore;
using StudentManagement.Configurations;
using StudentManagement.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentsClassRoom> StudentsClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentsClassConfigurations());
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            modelBuilder.Seed();

        }
    }
}
