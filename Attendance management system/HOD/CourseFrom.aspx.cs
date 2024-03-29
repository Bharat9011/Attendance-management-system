using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class CourseFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else {
                string idval = Request.QueryString["id"];
                showData(idval);
            }
            
        }

        private void showData(string id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SHRIKHRISHNA\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
            sqlConnection.Open();
            string q = "SELECT [id], [CourseName], [Co_ordinator], [DepartmentName] FROM [CourseDeatil] where id="+ id;
            SqlCommand cmd = new SqlCommand(q,sqlConnection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CourseName.Text = sqlDataReader[1].ToString();
                co_ordinator.Items.Add(sqlDataReader[2].ToString());
                Department.Items.Add(sqlDataReader[3].ToString());
            }
            sqlDataReader.Close();
        }
    }
}