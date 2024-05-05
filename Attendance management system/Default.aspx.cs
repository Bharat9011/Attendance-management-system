using Attendance_management_system.DataBase;
using Attendance_management_system.Principal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {

            Database database = new Database();
            var result = database.Login(email.Text, password.Text);

            Session["AccountID"] = result.Item1;
            int id = result.Item1;

            string permission = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select permission from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(s,sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                permission = reader[0].ToString();
            }
            reader.Close();

            if (permission == "YES")
            {
                if (result.Item2 == "Principal")
                {
                    Response.Redirect("Principal/DashBoard.aspx");
                }
                else if (result.Item2 == "HOD")
                {
                    Response.Redirect("HOD/DashBoard.aspx");
                }
                else if (result.Item2 == "co-ordinator")
                {
                    Response.Redirect("Co_ordinator/DashBoard.aspx");
                }
                else if (result.Item2 == "Teacher")
                {
                    Response.Redirect("~/Teacher/DashBoard.aspx");
                }
            } else if(permission == "NOT")
            {
                Response.Write("<script>alert('You have not permission to access this Account, Content Respestive HOD')</script>");
                Session.Abandon();
            }
        }
    }
}