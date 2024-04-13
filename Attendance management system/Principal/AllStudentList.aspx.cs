using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class AllStudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    GridView3.DataSource = SqlDataSource1;
                    GridView3.DataBind();
                }
            }
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            GridView3.DataSource = SqlDataSource1;
            GridView3.DataBind();
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView3.Rows[e.RowIndex].FindControl("Label1") as Label;

            string deleting = "delete from StudentDetails where id='" + id.Text + "'";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleting;
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();

            GridView3.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView3.DataSource = SqlDataSource1;
            GridView3.DataBind();
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            GridView3.DataSource = SqlDataSource1;
            GridView3.DataBind();
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            System.Web.UI.WebControls.Label id = GridView3.Rows[e.RowIndex].FindControl("Label9") as System.Web.UI.WebControls.Label;
            TextBox name = GridView3.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox email = GridView3.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox Contact = GridView3.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox Department = GridView3.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox Course = GridView3.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox Class = GridView3.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox SeesionYear = GridView3.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;

            string update = "UPDATE [dbo].[StudentDetails] SET"
                + " [StudentName] = '" + name.Text + "',[StudentEmail] = '" + email.Text + "',[StudentContactNumber] = '" + Contact.Text + "',"
                + "[StudentDepartment] = '" + Department.Text + "',[StudentCourse] = '" + Course.Text + "',[StudentClass] = '" + Class.Text + "',"
                + "[StudentSeesionYear] = '" + SeesionYear.Text + "' WHERE id=" + id.Text;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = update;
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();

            GridView3.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView3.DataSource = SqlDataSource1;
            GridView3.DataBind();
        }
    }
}