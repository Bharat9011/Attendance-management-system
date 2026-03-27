using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class DashBoard : System.Web.UI.Page
    {
        private static readonly string connections = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                GetDCount();
                GetTeacher();
                GetCountPresnt();
            }
        }

        private void GetCountPresnt()
        {

            string time = DateTime.Now.ToString();

            SqlConnection connection = new SqlConnection(connections);
            connection.Open();
            string s = "select * from AttendanceRecord";
            SqlCommand sqlCommand = new SqlCommand(s, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                showCount(time, reader[2].ToString());
            }
            connection.Close();
        }

        private void showCount(string time,string ctime)
        {

            int count = 0;

            string[] day = time.Split(' ');
            string[] cday = ctime.Split(' ');

            if (day[0] == cday[0])
            {
                count++;
            }

            presents.Text = count.ToString();

        }

        private void GetTeacher()
        {
            SqlConnection connection = new SqlConnection(connections);
            connection.Open();
            string s = "select count(*) from TeacherstaffDetail";
            SqlCommand sqlCommand = new SqlCommand(s, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TCount.Text = reader[0].ToString();
            }
            connection.Close();

        }

        private void GetDCount()
        {
            
            SqlConnection sqlConnection = new SqlConnection(connections);
            sqlConnection.Open();
            string s = "SELECT COUNT(*) from DepartmentDetail";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();
        }
    }
}