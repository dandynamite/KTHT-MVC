using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Grade
    {
        public string GradeId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}