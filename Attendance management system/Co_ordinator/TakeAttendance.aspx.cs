using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Co_ordinator
{
    public partial class TakeAttendance1 : System.Web.UI.Page
    {
        string id;
        string StudentDepartment, StudentCourse;
        string year, semister;
        string studentID;
        int StudentCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    id = Request.QueryString["id"];
                    GetData();
                    GetAttendanceData();
                    GetTime();
                    GetIDName();
                }
            }
        }
        private string GetIDName()
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

        private void GetTime()
        {
            time.Text = DateTime.Now.ToString();
        }

        private void GetAttendanceData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT n.[id],n.[StudentName],t.DepartmentName,p.CourseName from [StudentDetails] n join DepartmentDetail t on n.StudentDepartment = t.id join CourseDeatil p on n.StudentCourse = p.id where n.StudentDepartment='" + StudentDepartment + "' or n.StudentCourse='" + StudentCourse + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select [SubjectDepartmentID],[SubjctCourseID] from SubjectTable where id=" + Request.QueryString["id"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reas = sqlCommand.ExecuteReader();
            while (reas.Read())
            {
                StudentDepartment = reas[0].ToString();
                StudentCourse = reas[1].ToString();
            }
            reas.Close();
        }

        private string GetDataName()
        {
            string SubjectName = "";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select [SubjectName] from SubjectTable where id=" + Request.QueryString["id"];
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reas = sqlCommand.ExecuteReader();
            while (reas.Read())
            {
                SubjectName = reas[0].ToString();
            }
            reas.Close();
            return SubjectName;
        }

        public void TakeAttendances(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();

            string LtopicName = Lecture_Topic.Text;
            string Time = time.Text;
            int result = 0;

            if (LtopicName != string.Empty)
            {
                if (Time != string.Empty)
                {
                    foreach (GridViewRow gridViewRow in GridView1.Rows)
                    {
                        studentID = (gridViewRow.Cells[0].FindControl("Label1") as Label).Text;
                        string studentName = (gridViewRow.Cells[1].FindControl("Label2") as Label).Text;
                        string department = (gridViewRow.Cells[2].FindControl("Label3") as Label).Text;
                        string course = (gridViewRow.Cells[3].FindControl("Label4") as Label).Text;

                        GetStudentData();

                        StudentCount++;

                        string status = "Absent";
                        CheckBox checkBox = (gridViewRow.Cells[4].FindControl("CheckBox1") as CheckBox);
                        if (checkBox.Checked == true) status = "present"; else status = "Absent";

                        string q = "INSERT INTO [dbo].[Attendance]([LectureTopic],[Time],[StudentName],[Department],[course],[Attendance],[studentYear],[semister],[CourseYear],[AttendanBy],[SubjectName]) " +
                            "VALUES ('" + LtopicName + "','" + Time + "','" + studentName + "','" + department + "','" + course + "'," +
                            "'" + status + "','" + year + "','" + semister + "','" + StudentCourse + "','" + GetIDName() + "','" + GetDataName() + "')";
                        SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
                        result = sqlCommand.ExecuteNonQuery();

                    }// foreach loop

                }
                else
                {
                    Response.Write("<script>alert('Time is empty')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Lecture topic is empty')</script>");
            }
            if (result == 1)
            {
                Response.Write("<script>alert('Attendance are save')</script>");
            }
            else
            {
                Response.Write("<script>alert('Something want wrong')</script>");
            }
        }

        private void GetStudentData()
        {
            if (StudentCount == 1)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
                sqlConnection.Open();
                string s = "select [StudentClass],[Semister],[StudentSeesionYear] from [StudentDetails] where id=" + studentID;
                SqlCommand cmd = new SqlCommand(s, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    year = sqlDataReader[0].ToString();
                    semister = sqlDataReader[1].ToString();
                    StudentCourse = sqlDataReader[2].ToString();
                }
                sqlDataReader.Close();
            }
            else
            {
                return;
            }
        }
    }
}