using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models.ViewModel
{
    public class WatchStudentsView
    {
        public List<Student> students { get; set; }
        public int ClassId { get; set; }
    }
}
