using Attendance_management_system.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('hi')</script>");

            Database database = new Database();
            var result = database.login(email.Text, password.Text);

            Session["AccountID"] = result.Item1;
            
            if (result.Item2 == "Principal")
            {
                Response.Redirect("Principal/DashBoard.aspx");
            } else if (result.Item2 == "HOD")
            {
                Response.Redirect("HOD/DashBoard.aspx");
            }
        }
    }
}