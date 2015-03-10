using ASP_Code_First_Specificities.Contexts;
using ASP_Code_First_Specificities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Code_First_Specificities.Models
{
    public class DashBoardViewModel
    {
        public List<School> Schools;

        public DashBoardViewModel()
        {
            using (var context = new AppContext()){
                Schools = context.Schools.Include("Students").ToList(); 
            }
        }
    }
}