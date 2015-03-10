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
            var model = TempData["StudentCreated"]!=null ? TempData["StudentCreated"] as Student :new Student(){
                ID = 1,
                Name ="Pierre Martin",
                JoinDate = DateTime.Now,
                Email = "pmartin@contoso.com",
                HasPaid = false,
                Class = 1
            };
            //ViewBag.SchoolName  ="Supinfo";
            //ViewBag.Student = model;
            var viewModel = new StudentDetailsViewModel{
                MyStudent = model,
                SchoolName = "Supinfo"
            };
            return View("Details", "_Layout", viewModel);
        }


        public ActionResult Create()
        {
            return View(new StudentCreateViewModel());
        }

       
        public ActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["StudentCreated"] = model.student;
                return RedirectToAction("Details");
            }
            else
            {                
                return View(model);
            }
        }

    }
}
