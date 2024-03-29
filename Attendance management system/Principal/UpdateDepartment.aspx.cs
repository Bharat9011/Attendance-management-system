using Attendance_management_system.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class UpdateDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                Database db = new Database();
                string value = db.get_value("DepartmentName", "DepartmentDetail", DataVariable.ID);

                UDNameDepartment.Text = value.Trim();
            }
        }
    }
}