using Attendance_management_system.Principal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Attendance_management_system.HOD
{
    public partial class teacherDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetAllData();
            }
        }

        private void GetAllData()
        {

            string id = Request.QueryString["id"];

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string getData = "select * from TeacherstaffDetail where id=" + id;
            SqlCommand sqlCommand = new SqlCommand(getData, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Name.Text = reader[1].ToString();
                EmailID.Text = reader[2].ToString();
                Role.Text = reader[4].ToString();
                DepartmentName.Text = reader[5].ToString();
                permission.Text = reader[6].ToString();
            }

            sqlConnection.Close();

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string update = "UPDATE [dbo].[TeacherstaffDetail] SET [name] = '' ,[email] = '',[password] = '',[role1] = '',[DepatmentName] = '',[permission] = '' WHERE id=''";
            SqlCommand sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}