using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class TeacherPermission : System.Web.UI.Page
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
                GetData();
            }
        }

        private void GetData()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string q = "SELECT [id],[name] FROM [dbo].[TeacherstaffDetail] where DepatmentName='" + departmentName + "' AND (role1 = 'teacher' OR role1 = 'co-ordinator')";
            SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();

            DropDownList1.DataSource = dataSet;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

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

        protected void FindTeacher_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            string s = "select id,name,permission from TeacherstaffDetail where id=" + id;
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = dataSet.Tables[0];
                    GridView1.DataBind();
                }
            }

            NotAllow.Visible = true;
            Allow.Visible = true;
        }

        protected void Allow_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "UPDATE TeacherstaffDetail SET [permission]='YES' WHERE id=" + id;
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        protected void NotAllow_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = "UPDATE TeacherstaffDetail SET [permission]='NOT' WHERE id=" + id;
            SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}