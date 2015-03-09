using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_WebForms_Basics
{
    public partial class Student : System.Web.UI.Page
    {
        private string LastName;
        private string FirstName;



        protected void Page_Load(object sender, EventArgs e)
        {
            
            var student = new Student(){ FirstName = txStudentFirstName.Text , LastName = txStudentLastName.Text};
            //todo Add Student to DB;
            lblResponse.Text = string.Format("Added student : {0} {1}",student.FirstName, student.LastName );
        }
    }



}