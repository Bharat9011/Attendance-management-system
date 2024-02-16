using Attendance_management_system.DataBase;
using System;

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

            int department = DB.getCourseID("DepartmentDetail", "DepartmentName", DepartmentName.Text);

            int Role = DB.getCourseID("TeacherstaffDetail", "name", HODName.Text);

            int result = DB.insertDepartment(department, Role);
            if (result == -1) {
                Response.Write("<script>alert('Something want wrong')</script>");
            } else if (result == 1)
            {
                Response.Write("<script>alert('Successfully Allocation')</script>");
            } else if(result == 0) {
                Response.Write("<script>alert('This is allready HOD')</script>");
            }
        }

    }
}