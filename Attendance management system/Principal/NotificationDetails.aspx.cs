using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class NotificationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                ShowNotificationdetails();
            }
        }

        private void ShowNotificationdetails()
        {
            string id = Request.QueryString["id"];

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select * from Notification where id="+id;
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Notification_Title.Text = reader[1].ToString();
                Notification_Desciption.Text = reader[2].ToString();
                To.Text = reader[4].ToString();
            }
            sqlConnection.Close();
        }
    }
}