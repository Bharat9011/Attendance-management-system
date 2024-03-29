using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class CourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Title = "Course Title";
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, System.Web.UI.WebControls.GridViewSelectEventArgs e)
        {
            if (GridView1.SelectedIndex >= 0 && GridView1.SelectedIndex < GridView1.Rows.Count)
            {

                int SelectRowIndes = GridView1.SelectedIndex;

                int cellIndex = 0;

                string cellText = GridView1.Rows[SelectRowIndes].Cells[cellIndex].Text;

                Response.Redirect("CourseFrom.aspx?id=" + cellText);
            }
        }
    }
}