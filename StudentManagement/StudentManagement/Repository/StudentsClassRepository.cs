using StudentManagement.Models;
using StudentManagement.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
    public class StudentsClassRepository : IStudentsClassRepository
    {
        private readonly StudentsDbContext context;

        public StudentsClassRepository(StudentsDbContext context)
        {
            this.context = context;
        }

        public List<StudentsClassRoom> ClassList()
        {
            return context.StudentsClasses.ToList();
        }

        public WatchStudentsView GetWatchStudentView(int id)
        {
            WatchStudentsView watchStudentsView = new WatchStudentsView()
            {
                ClassId = id,
                students = context.Students.Where(el => el.ClassId == id).ToList()
            };
            return watchStudentsView;
        }

    }
}
