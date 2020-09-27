using StudentManagement.Controllers;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
    public interface IStudentRepository
    {
        int CreateStudent(Student student);
        Student GetStudent(int id);
        List<Student> GetStudentList();
        int EditStudent(Student student);
        int Delete(int id);
    }
}
