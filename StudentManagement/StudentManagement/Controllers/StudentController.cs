using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Models.ViewModel;
using StudentManagement.Repository;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IStudentsClassRepository studentsClassRepository;

        public StudentController(IStudentRepository studentRepository,IStudentsClassRepository studentsClassRepository)
        {
            this.studentRepository = studentRepository;
            this.studentsClassRepository = studentsClassRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            return View(new CreateStudentView { ClassId=id});
        }
        [HttpPost]
        public IActionResult Create(CreateStudentView createStudentView)
        {
            Student student = new Student();
            if (ModelState.IsValid)
            {
                student = new Student()
                {
                    FullName = createStudentView.FullName,
                    DateOfBirth = createStudentView.DateOfBirth,
                    Gender = createStudentView.Gender,
                    Email = createStudentView.Email,
                    ClassId = createStudentView.ClassId
                };


                if (studentRepository.CreateStudent(student) > 0)
                    return View("Views/StudentsClass/Students.cshtml", studentsClassRepository.GetWatchStudentView(student.ClassId));
                else
                    ModelState.AddModelError("", "some thing wrong");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(studentRepository.GetStudent(id));
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (studentRepository.EditStudent(student) > 0)
                    return RedirectToAction("Index", "StudentsClass");
                else
                    ModelState.AddModelError("", "some thing wrong");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            if (studentRepository.Delete(id) > 0)
                return RedirectToAction("Index", "StudentsClass");
            else
                ModelState.AddModelError("", "some thing wrong");
            return View();
        }
    }
}
