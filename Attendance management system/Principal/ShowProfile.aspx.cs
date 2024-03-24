using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Attendance_management_system.Principal
{
    public partial class ShowProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetInfoProfile();
        }

        private void GetInfoProfile()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            string value = Session["UpdateProfile"].ToString();
            cmd.CommandText = "select * from TeacherstaffDetail where id='" + value + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name.Text = reader["name"].ToString();
                Email.Text = reader["email"].ToString();
                Role1.SelectedItem.Text = reader["role1"].ToString();
                Role2.SelectedItem.Text = reader["role2"].ToString();
                Password.Text = reader["password"].ToString();
                Department.Text = reader["DepatmentName"].ToString();
            }
            reader.Close();
        }
    }
}