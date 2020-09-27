using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Configurations
{
    public class StudentsClassConfigurations : IEntityTypeConfiguration<StudentsClassRoom>
    {
        public void Configure(EntityTypeBuilder<StudentsClassRoom> builder)
        {
            builder.Property(el => el.ClassName).HasMaxLength(100).IsRequired();

        }
    }
}
