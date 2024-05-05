using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class LectureAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                GetDataTeacher();
            }
        }

        private void GetDataTeacher()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select * from Attendance where AttendanBy='" + GetTeacherName() + "'";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(s, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }

        private string GetTeacherName()
        {
            string TeacherName = "";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select [name] from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reas = sqlCommand.ExecuteReader();
            while (reas.Read())
            {
                TeacherName = reas[0].ToString();
            }
            reas.Close();
            return TeacherName;
        }

    }
}