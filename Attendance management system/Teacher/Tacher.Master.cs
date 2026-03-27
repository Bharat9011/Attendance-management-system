using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Attendance_management_system.Teacher
{
    public partial class Tacher : System.Web.UI.MasterPage
    {

        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTeacherName();
        }

        private void GetTeacherName()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select name from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand cmd = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hname.Text = reader[0].ToString();
            }
            reader.Close();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Default.aspx");
        }
    }
}