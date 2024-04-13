using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class CreateNotification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void send_notification_Click(object sender, EventArgs e)
        {
            string title = Notification_Title.Text;
            string Desciption = Notification_Desciption.Text;
            string to = To.SelectedItem.ToString();

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "insert into Notification ([NotificationTitle],[Notification_Desciption],[Notification_From],[Notofication_To]) values ('" + title + "','" + Desciption + "','" + Session["AccountID"].ToString() + "','" + to + "')";
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            if (result == -1)
            {
                Response.Write("<script>alert('something want wrong')</script>");
            }
            else
            {
                Response.Write("<script>alert('Notification send')</script>");
            }
        }
    }
}