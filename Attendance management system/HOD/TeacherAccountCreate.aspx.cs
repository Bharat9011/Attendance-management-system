using Attendance_management_system.DataBase;
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
    public partial class TeacherAccountCreate : System.Web.UI.Page
    {
        string departmentName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartment();
                GetDataItemForDropdownList();
            }
        }

        private void GetDataItemForDropdownList()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SHRIKHRISHNA\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
            string q = "SELECT [CourseName] FROM [dbo].[CourseDeatil] where DepartmentName='" + departmentName + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DropDownList1.DataSource = dataSet;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "CourseName";
            DropDownList1.DataBind();
        }

        private void GetDepartment()
        {
            string sessionval = Session["AccountID"].ToString();

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SHRIKHRISHNA\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
            sqlConnection.Open();
            string q = "SELECT [DepatmentName] FROM [TeacherstaffDetail] where id=" + sessionval;
            SqlCommand cmd = new SqlCommand(q, sqlConnection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                DepartmentName.Text = sqlDataReader.GetString(0);
                departmentName = sqlDataReader.GetString(0);

            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string Name = FullName.Text.Trim();
            string email = Emails.Text.Trim();
            string password = Password.Text.Trim();
            string role = RadioButtonList1.SelectedItem.Value;
            string department = DepartmentName.Text.Trim();
            string co_ordintor_name = DropDownList1.SelectedItem.Text;

            if (!string.IsNullOrEmpty(Name))
            {
                if (!string.IsNullOrEmpty(email))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        if (!string.IsNullOrEmpty(role))
                        {
                            if (!string.IsNullOrEmpty(department))
                            {
                                SqlConnection sqlConnection = new SqlConnection();
                                sqlConnection.ConnectionString = "Data Source=SHRIKHRISHNA\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
                                sqlConnection.Open();
                                string q = "INSERT INTO [dbo].[TeacherstaffDetail] ([name],[email],[password],[role1],[DepatmentName],[permission]) VALUES ('" + Name + "','" + email + "','" + password + "','" + role + "','" + department + "','YES')";
                                SqlCommand cmd = new SqlCommand(q, sqlConnection);
                                int result = cmd.ExecuteNonQuery();
                                if (result == -1)
                                {
                                    Response.Write("<script>alert('something wants wrong')</script>");
                                }
                                else if (result == 1)
                                {
                                    Database database = new Database();
                                    int results = database.Execute_Sql("UPDATE [dbo].[CourseDeatil] SET [Co_ordinator] = '" + Name + "' WHERE CourseName='" + co_ordintor_name + "'");
                                    Response.Write("<script>alert('Data save')</script>");
                                }
                            }
                            else
                            {
                                massage.Text = "Department is empty";
                                MessageBox1.Visible = true;
                            }
                        }
                        else
                        {
                            massage.Text = "Role is not selected";
                            MessageBox1.Visible = true;
                        }
                    }
                    else
                    {
                        massage.Text = "Password is empty";
                        MessageBox1.Visible = true;
                    }
                }
                else
                {
                    massage.Text = "email is empty";
                    MessageBox1.Visible = true;
                }
            }
            else
            {
                massage.Text = "Name is empty";
                MessageBox1.Visible = true;
            }
        }
    }
}