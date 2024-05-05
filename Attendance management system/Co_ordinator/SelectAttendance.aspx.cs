using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Co_ordinator
{
    public partial class TakeAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                GetDataTeacher();
            }
        }

        private void GetDataTeacher()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "select id,SubjectName,Year,Semister from SubjectTable where SubjectTeacher='" + Session["AccountID"] + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            DataTable dataSet = new DataTable();
            sqlDataAdapter.Fill(dataSet);
            if (dataSet.Rows.Count > 0)
            {
                GridView1.DataSource = dataSet;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int index = Convert.ToInt32(e.NewSelectedIndex);
            GridViewRow gridViewRow = GridView1.Rows[index];
            string value = (gridViewRow.FindControl("Label1") as Label).Text;

            Response.Redirect("TakeAttendance.aspx?id=" + value);
        }
    }
}