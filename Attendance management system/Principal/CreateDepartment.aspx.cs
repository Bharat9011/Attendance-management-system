using System;
using Attendance_management_system.DataBase;

namespace Attendance_management_system.Principal
{
    public partial class CreateDepartment_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            int result = database.createDepartment(NameDepartment.Text);
            if (result == -1)
            {
                string script = "alert('Something want wrong n plz try again later');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                NameDepartment.Text = "";
            } else if (result == 0)
            {
                string script = "alert('Department sccessfully create');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                NameDepartment.Text = "";
            }
        }
    }
}