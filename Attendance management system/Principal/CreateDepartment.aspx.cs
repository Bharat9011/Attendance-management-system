using System;
using Attendance_management_system.DataBase;

namespace Attendance_management_system.Principal
{
    public partial class CreateDepartment_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            int result = database.CheckExit("DepartmentDetail", "DepartmentName", "DepartmentName='" + NameDepartment.Text+"'");

            if (result > 0)
            {
                Response.Write("<script>alert('"+ NameDepartment.Text + " is Already exits');</script>");
                NameDepartment.Text = "";
            } else if (result == 0)
            {
                int result2 = database.CreateDepartment(NameDepartment.Text);
                if (result2 == 0)
                {
                    Response.Write("<script>alert('Department Created');</script>");
                    NameDepartment.Text = "";
                } else
                {
                    Response.Write("<script>alert('SomeThing Wants wrong');</script>");
                }
            }
        }
    }
}