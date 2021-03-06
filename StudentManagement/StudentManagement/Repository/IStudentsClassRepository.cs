﻿using StudentManagement.Models;
using StudentManagement.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
    public interface IStudentsClassRepository 
    {
        WatchStudentsView GetWatchStudentView(int id);
        List<StudentsClassRoom> ClassList();
        
    }
}
