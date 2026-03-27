using System;
using System.Data.SqlClient;

namespace Attendance_management_system.Co_ordinator
{
    public partial class Co_ordinator : System.Web.UI.MasterPage
    {
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetTeacherName();
            }
        }

        private void GetTeacherName()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select name from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand cmd = new SqlCommand(s,sqlConnection);
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