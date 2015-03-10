using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_Basics.Models
{
    public class StudentCreateViewModel
    {
        public Student student { get; set; }

        public StudentCreateViewModel() {
            student = new Student(){
                HasPaid = false,
                JoinDate = DateTime.Now,
                ID = new Random().Next()
            };
        }
    }
}