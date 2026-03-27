using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Co_ordinator
{
    public partial class DashBoard : System.Web.UI.Page
    {
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetTotalSubject();
                GetTotalStudent();
            }
        }

        private void GetTotalStudent()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select COUNT(*) from StudentDetails where CreateBy=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                tacherCount.Text = reader[0].ToString();
            }
            reader.Close();
        }

        private void GetTotalSubject()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select COUNT(*) from SubjectTable where SubjectCreateBy=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DepartmentCount.Text = reader[0].ToString();
            }
            reader.Close();
        }
    }
}