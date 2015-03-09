using ASP_MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_Basics.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Details()
        {
            var model = new Student(){
                ID = 1,
                Name ="Pierre Martin",
                JoinDate = DateTime.Now,
                Email = "pmartin@contoso.com",
                HasPaid = false,
                Class = 1
            };
            return View("Detail", "_Layout", model);
        }

    }
}
