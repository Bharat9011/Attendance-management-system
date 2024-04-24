using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Attendance_management_system.Co_ordinator
{
    public partial class ShowStudentDeatail : System.Web.UI.Page
    {
        string _departmentName = "";
        string _Name = "";
        string _CourseName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartmentINfo();
                GetCourseInfo();
                GetData();
            }
        }

        private void GetCourseInfo()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select CourseName from CourseDeatil where Co_ordinator='" + _Name + "'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                _CourseName = reader[0].ToString();
            }
            reader.Close();
        }

        private void GetDepartmentINfo()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select name,DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _Name = reader[0].ToString();
                _departmentName = reader[1].ToString();
            }
            reader.Close();
        }

        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT n.id, n.StudentName, n.StudentEmail, n.StudentContactNumber, n.StudentDepartment, n.StudentCourse, n.StudentClass, n.StudentSeesionYear, n.StudentPassword FROM StudentDetails n JOIN TeacherstaffDetail t ON n.CreateBy = t.id WHERE n.CreateBy = '" + Session["AccountID"] +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(s,sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }
    }
}