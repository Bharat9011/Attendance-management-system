using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class ShowTeacherDeatail : System.Web.UI.Page
    {
        string departmentName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                SessionDetaile();
                ShowDataGridView();
            }
        }

        private void ShowDataGridView()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string q = "SELECT [id],[name],[email],[password],[role1],[DepatmentName],[permission] FROM [dbo].[TeacherstaffDetail] where DepatmentName='" + departmentName + "' AND (role1 = 'teacher' OR role1 = 'co-ordinator')";
            SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            if (dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    GridView2.DataSource = dataSet.Tables[0];
                    GridView2.DataBind();
                }
            }
        }

        private void SessionDetaile()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string q = "select DepatmentName from TeacherstaffDetail where id=" + Session["AccountID"];
            SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                departmentName = reader.GetString(0);
            }
            reader.Close();
        }

        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int index = Convert.ToInt32(e.NewSelectedIndex);
            GridViewRow row = GridView2.Rows[index];
            string value = (row.FindControl("Label1") as Label).Text;

            Response.Redirect("teacherDetails.aspx?id="+value);
        }
    }
}