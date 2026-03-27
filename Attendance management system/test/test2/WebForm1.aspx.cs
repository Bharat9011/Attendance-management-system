using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.test.test2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string s = "select [StudentName],[Time] from [Attendance]";
            SqlCommand cmd = new SqlCommand(s,sqlConnection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while(sqlDataReader.Read())
            {
                ShowData(sqlDataReader[0].ToString(), sqlDataReader[1].ToString());
            }
        }

        private void ShowData(string names,string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            string month = dateTime.Day.ToString();

            

        }
    }
}