using Attendance_management_system.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class HODAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void allocatedHOD(object sender, EventArgs e)
        {

            Database DB = new Database();

            int result = DB.getCourseID("DepartmentDetail", "DepartmentName", DropDownList1.Text);

            int Role = DB.getCourseID("TeacherstaffDetail", "name", "bharat sanjay chaudhari");

            Response.Write("<script>console.log('" + result + "')</script>");
        }

    }
}