using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class CourseList : System.Web.UI.Page
    {

        string departmentName = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Title = "Course List";
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
            string q = "SELECT [id], [CourseName], [Co_ordinator], [DepartmentName] FROM [CourseDeatil] where DepartmentName='" + departmentName + "'";
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
            while(reader.Read())
            {
                departmentName = reader.GetString(0);
            }
            reader.Close();
        }

        protected void GridView1_SelectedIndexChanging(object sender, System.Web.UI.WebControls.GridViewSelectEventArgs e)
        {
            int index = Convert.ToInt32(e.NewSelectedIndex);
            GridViewRow row = GridView2.Rows[index];
            string value = (row.FindControl("Label1") as Label).Text;

            Response.Redirect("ShowCourseDetails.aspx?id=" + value);
        }
    }
}