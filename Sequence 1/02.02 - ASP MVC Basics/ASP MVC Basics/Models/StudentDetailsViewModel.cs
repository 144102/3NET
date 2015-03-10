using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_Basics.Models
{
    public class StudentDetailsViewModel
    {
        public Student MyStudent { get; set; }
        public String SchoolName { get; set; }

        public StudentDetailsViewModel()
        {
            
        }
    }
}