using System;
using System.Data;
using System.Data.SqlClient;

namespace Attendance_management_system.HOD
{
    public partial class AllocatesCo_Ordinator : System.Web.UI.Page
    {
        string DepartmentName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartmentData();
                if (!IsPostBack)
                {
                    GetCourseData();
                    GetTeacherData();
                }
            }
        }

        private void GetTeacherData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT [id],[name] FROM [TeacherstaffDetail] where DepatmentName='" + DepartmentName + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DropDownList2.DataSource = dataSet;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
        }

        private void GetCourseData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT [id],[CourseName] FROM [CourseDeatil] where DepartmentName='" + DepartmentName + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DropDownList1.DataSource = dataSet;
            DropDownList1.DataTextField = "CourseName";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        private void GetDepartmentData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT [DepatmentName] FROM [TeacherstaffDetail] where id='" + Session["AccountID"] + "'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DepartmentName = reader[0].ToString();
            }
            reader.Close();
        }

        protected void allocate_Click(object sender, EventArgs e)
        {

            string coursename = DropDownList1.SelectedValue;
            string departmentName = DropDownList2.SelectedValue;

            string course = getCourseName(coursename);
            string department = getDepartmentName(departmentName);

            if (CheckAllreadyAllocate(course, department) == 0)
            {
                if (CheckCourseAllocates(course))
                {
                    if (CheckCo_OrdinatorAllocated(department))
                    {
                        SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
                        sqlConnection.Open();
                        string u = "UPDATE [dbo].[CourseDeatil] SET [Co_ordinator] = '" + department + "' WHERE CourseName='" + course + "' and DepartmentName='" + DepartmentName + "'";
                        SqlCommand sqlCommand = new SqlCommand(u, sqlConnection);
                        sqlCommand.ExecuteReader();
                        Response.Write("<script>alert('co-ordinator are allocated')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Co-ordinator are  Allocated')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('course are Allocated')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Both are Allready Allocated')</script>");
            }
        }

        private bool CheckCo_OrdinatorAllocated(string DepartmentName)
        {
            bool pass = false;

            string course = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select * from CourseDeatil where Co_ordinator='"+DepartmentName+"' and CourseName IS NOT NULL";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                course = reader[2].ToString();
            }

            if (course == "NULL")
            {
                pass = true;
            }

            return pass;
        }

        private bool CheckCourseAllocates(string coursename)
        {
            bool pass = false;

            string course = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select * from CourseDeatil where CourseName='"+ coursename + "' and Co_ordinator IS NOT NULL and DepartmentName='"+ DepartmentName + "'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                course = reader[2].ToString();
            }

            if(course == "NULL")
            {
                pass = true;
            }

            return pass;
        }

        private string getCourseName(string coursename)
        {
            string course = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select CourseName from CourseDeatil where id=" + coursename;
            SqlCommand sqlCommand = new SqlCommand(s,sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                course = reader[0].ToString();
            }

            return course;
            
        }

        private string getDepartmentName(string department)
        {
            string Department = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select name from TeacherstaffDetail where id=" + department;
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Department = reader[0].ToString();
            }

            return Department;
        }

        protected int CheckAllreadyAllocate(string CName, string COOrdinator)
        {
            int i = 0;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "SELECT [CourseName],[Co_ordinator] FROM [CourseDeatil] where CourseName='" + CName + "' and Co_ordinator='"+COOrdinator+"'";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                i++;
            }

            return i;
        }
    }
}