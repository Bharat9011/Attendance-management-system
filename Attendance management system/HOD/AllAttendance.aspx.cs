using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class AllAttendance : System.Web.UI.Page
    {
        string department = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                GetDataTeacher();
                ShowDepartmentAttendance();
            }
        }

        private void ShowDepartmentAttendance()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select DISTINCT StudentName,Attendance,Time,LectureTopic,course,Department,studentYear," +
                "semister,AttendanBy,SubjectName from Attendance where Department='" + department + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }

        private void GetDataTeacher()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                department = reader[0].ToString();
            }
            reader.Close();
        }
    }
}