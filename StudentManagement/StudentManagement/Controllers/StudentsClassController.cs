using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Repository;

namespace StudentManagement.Controllers
{
    public class StudentsClassController : Controller
    {
        private readonly IStudentsClassRepository studentsClassRepository;

        public StudentsClassController(IStudentsClassRepository studentsClassRepository)
        {
            this.studentsClassRepository = studentsClassRepository;
        }
        public IActionResult Index()
        {
            return View(studentsClassRepository.ClassList());
        }
        public IActionResult Students(int id)
        {
            return View(studentsClassRepository.GetWatchStudentView(id)); 
        }

    }
}
