using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class DashBoard : System.Web.UI.Page
    {
        String departmentname = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                getSessionDetails();
                getCourseNumber();
                getTeacherCount();
            }
        }

        private void getTeacherCount()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            connection.Open();
            string s = "select count(*) from TeacherstaffDetail where DepatmentName='" + departmentname + "' AND (role1='co-ordinator' OR role1='Teacher')";
            SqlCommand sqlCommand = new SqlCommand(s, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                tacherCount.Text = reader[0].ToString();
            }
            connection.Close();
        }

        private void getSessionDetails()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            connection.Open();
            String s = "select DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                departmentname = reader[0].ToString();
            }

            connection.Close();
        }

        private void getCourseNumber()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            connection.Open();
            string s = "select count(*) from CourseDeatil where DepartmentName='"+departmentname+"'";
            SqlCommand sqlCommand = new SqlCommand(s, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DepartmentCount.Text = reader[0].ToString();
            }
            connection.Close();
        }
    }
}