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
    public partial class StudentList : System.Web.UI.Page
    {
        string department = "";
        int DepartmentID;
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartment();
                GetDepartmentID();
                GetStudentList();
            }
        }

        private void GetDepartmentID()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select id from DepartmentDetail where DepartmentName='"+ department +"'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DepartmentID = reader.GetInt32(0);
            }
        }

        private void GetDepartment()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                department = reader.GetString(0);
            }
        }

        private void GetStudentList()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "SELECT n.[id],n.[StudentName],n.[StudentEmail],n.[StudentContactNumber],f.DepartmentName,c.CourseName,n.[StudentClass],n.[StudentSeesionYear],n.[StudentPassword],n.[Semister] FROM [StudentDetails] n join DepartmentDetail f on n.StudentDepartment = f.id join CourseDeatil c on n.StudentCourse = c.id where n.StudentDepartment = '"+ DepartmentID +"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s,sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }
    }
}