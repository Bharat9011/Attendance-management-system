using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Attendance_management_system.Co_ordinator
{
    public partial class StudentAccountCreate : System.Web.UI.Page
    {
        string courses = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartmentName();
                GetCourse();
            }
        }

        private void GetCourse()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select CourseName from CourseDeatil where Co_ordinator='" + courses+ "'";
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                course.Text = reader[0].ToString();
            }
            sqlConnection.Close();
        }

        private void GetDepartmentName()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select name,DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand cmd = new SqlCommand(s,sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                courses = reader[0].ToString();
                department.Text = reader[1].ToString();
            }
            sqlConnection.Close();
        }



        protected void createstudentAccount_click(object sender, EventArgs e)
        {
            string subjectname = SubjectName.Text;
            string Email = email.Text;
            string Number = number.Text;
            string Department = department.Text;
            string Course = course.Text;
            string Classes = classes.Text;
            string sessionyear = sessionYear.Text;
            string password = Password.Text;

            if ( subjectname != string.Empty || Email != string.Empty ||
                Number != string.Empty || Department != string.Empty ||
                Course != string.Empty || Classes != string.Empty ||
                sessionyear != string.Empty || password != string.Empty)
            {
                if (subjectname != string.Empty)
                {
                    if (Email != string.Empty)
                    {
                        if (Number != string.Empty)
                        {
                            if (Department != string.Empty)
                            {
                                if (Course != string.Empty)
                                {
                                    if (Classes != string.Empty)
                                    {
                                        if (sessionyear != string.Empty)
                                        {
                                            if (password != string.Empty)
                                            {
                                                SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
                                                sqlConnection.Open();
                                                string insert = "INSERT INTO [dbo].[StudentDetails] ([StudentName],[StudentEmail],[StudentContactNumber],[StudentDepartment],[StudentCourse],[StudentClass],[StudentSeesionYear],[StudentPassword],[CreateBy]) VALUES ('" + subjectname + "','" + Email + "','" + Number + "','" + Department + "','" + Course + "','" + Classes + "','" + sessionyear + "','" + password + "'," + Session["AccountID"] +")";
                                                SqlCommand sqlCommand = new SqlCommand(insert,sqlConnection);
                                                int result = sqlCommand.ExecuteNonQuery();
                                                if(result == -1) {
                                                    Response.Write("<script>alert('something want wrong')</script>");
                                                } else
                                                {
                                                    Response.Write("<script>alert('data save')</script>");
                                                }
                                            }
                                            else
                                            {
                                                Response.Write("<script>alert('Password Field are empty')</script>");
                                            }
                                        }
                                        else
                                        {
                                            Response.Write("<script>alert('Session Year Field are empty')</script>");
                                        }
                                    }
                                    else
                                    {
                                        Response.Write("<script>alert('class Field are empty')</script>");
                                    }
                                }
                                else
                                {
                                    Response.Write("<script>alert('Course Field are empty')</script>");
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('Department Field are empty')</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Number Field are empty')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Email Field are empty')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Student Field are empty')</script>");
                }
            } else
            {
                Response.Write("<script>alert('All Field are empty')</script>");
            }
        }

    }
}