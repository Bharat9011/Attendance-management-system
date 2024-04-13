using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class ShowCourseDetails : System.Web.UI.Page
    {
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("Default.aspx");
            } else
            {
                GetAllData();
            }
        }

        private void GetAllData()
        {
            id = Request.QueryString["id"];

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();

            string s = "Select * from CourseDeatil where id="+id;
            SqlCommand cmd = new SqlCommand(s,sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CourseName.Text = reader[1].ToString();
                Co_ordinator.Text = reader[2].ToString();
                DepartmentName.Text = reader[3].ToString();
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();

            string u = "UPDATE [dbo].[CourseDeatil] SET [CourseName] = '" + CourseName.Text + "' ,[Co_ordinator] = '" + Co_ordinator.Text + "' ,[DepartmentName] = '" + DepartmentName.Text + "' WHERE id=" + id;
            SqlCommand cmd = new SqlCommand(u,sqlConnection);
            cmd.ExecuteReader();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();

            string u = "DELETE FROM [dbo].[CourseDeatil] WHERE id=" + id;
            SqlCommand cmd = new SqlCommand(u, sqlConnection);
            cmd.ExecuteReader();
        }
    }
}