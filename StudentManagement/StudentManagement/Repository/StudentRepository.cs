using StudentManagement.Controllers;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDbContext context;

        public StudentRepository(StudentsDbContext context)
        {
            this.context = context;
        }

        public int CreateStudent(Student student)
        {
            context.Add(student);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            context.Remove(GetStudent(id));
            return context.SaveChanges();
        }

        public int EditStudent(Student student)
        {
            if (context.Students.Contains(student))
                context.Update(student);
            return context.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            return context.Students.FirstOrDefault(p => p.StudentId == id);
        }

        public List<Student> GetStudentList()
        {
            return context.Students.ToList();
        }
    }
}
