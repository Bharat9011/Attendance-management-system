using Attendance_management_system.DataBase;
using Attendance_management_system.HOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Co_ordinator
{
    public partial class SubjectCreate : System.Web.UI.Page
    {
        string departmentName = "";
        int ID = 0;
        string name = "";
        int courseID = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                getDepartmentName();
                GetDepartmentID();
                GetCourseName();
                Page.Title = "Subject Create";
            }
        }

        private void GetCourseName()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select id,CourseName from CourseDeatil where Co_ordinator='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                courseID = Convert.ToInt32(reader[0].ToString());
                course.Text = reader[1].ToString();
            }
            reader.Close();
        }

        private void GetDepartmentID()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select id from DepartmentDetail where DepartmentName='" + departmentName + "'";
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader[0]);
            }
            reader.Close();
        }

        private void getDepartmentName()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select name,DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = (string)reader[0];
                Department.Text = reader[1].ToString();
                departmentName = reader[1].ToString();
            }
            reader.Close();
        }

        protected void createSubject_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            string Subjectname = SubjectName.Text;
            string subjectteacher = SubjectTeacher.Text;
            string department = Department.Text;
            string year = Year.Text;
            string semister = Semister.Text;
            string Course = course.Text;

            if (Subjectname != string.Empty || subjectteacher != string.Empty ||
                department != string.Empty || year != string.Empty ||
                semister != string.Empty || Course != string.Empty)
            {
                if (Subjectname != string.Empty)
                {
                    if (subjectteacher != string.Empty)
                    {
                        if (department != string.Empty)
                        {
                            if (year != string.Empty)
                            {
                                if (semister != string.Empty)
                                {
                                    if (Course != string.Empty)
                                    {
                                        SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
                                        sqlConnection.Open();
                                        string s = "insert into SubjectTable ([SubjectName],[SubjectTeacher],[Year],[Semister],[SubjectCreateBy],[SubjectDepartmentID],[SubjctCourseID]) values ('" + Subjectname + "', '" + subjectteacher + "' ,'" + year + "', '" + semister + "' ," + Session["AccountID"] + "," + ID + "," + courseID + ") ";
                                        SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
                                        int reult = sqlCommand.ExecuteNonQuery();
                                        if (reult == -1)
                                        {
                                            Response.Write("<script>alert('something want wrong')</script>");
                                        }
                                        else
                                        {
                                            Response.Write("<script>alert('Subject is created')</script>");
                                        }
                                    }
                                    else
                                    {
                                        Response.Write("<script>alert('Course are empty')</script>");
                                    }
                                }
                                else
                                {
                                    Response.Write("<script>alert('semister are empty')</script>");
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('Year are empty')</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Department are empty')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('subject Teacher are empty')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Subject are empty')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('All field are empty')</script>");
            }
        }

        public int CheckTeacherAllocateOrNot(string SName, string STeacher)
        {
            int i = 0;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select SubjectName,SubjectTeacher from SubjectTable where SubjectName='" + SName + "' or SubjectTeacher='" + STeacher + "'";
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader sqlr = cmd.ExecuteReader();
            while (sqlr.Read())
            {
                i++;
            }
            sqlr.Close();
            return i;

        }

    }
}