using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentsClassRoom>().HasData(

                new StudentsClassRoom { ClassName = "C0220G1", Id = 1, },
                new StudentsClassRoom { ClassName = "C0520G1", Id = 2, },
                new StudentsClassRoom { ClassName = "C0320K1", Id = 3, },
                new StudentsClassRoom { ClassName = "C0420F1", Id = 4, },
                new StudentsClassRoom { ClassName = "C0620A1", Id = 5, }
                );
        }
    }
}
