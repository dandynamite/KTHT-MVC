using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}