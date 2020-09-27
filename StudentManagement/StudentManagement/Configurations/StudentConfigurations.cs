using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(el => el.FullName).HasMaxLength(50).IsRequired();
            builder.Property(el => el.DateOfBirth).IsRequired();
            builder.Property(el => el.Gender).IsRequired().HasMaxLength(20);
            builder.Property(el => el.Email).IsRequired().HasMaxLength(100);
        }
    }
}
