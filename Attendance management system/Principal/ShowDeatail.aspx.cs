using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.Principal
{
    public partial class ShowDeatail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            System.Web.UI.WebControls.Label id = GridView1.Rows[e.RowIndex].FindControl("Label8") as System.Web.UI.WebControls.Label;

            string deleting = "delete from TeacherstaffDetail where id='" + id.Text + "'";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleting;
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();

            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }


        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            System.Web.UI.WebControls.Label id = GridView1.Rows[e.RowIndex].FindControl("Label9") as System.Web.UI.WebControls.Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox password = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox role1 = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox role2 = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox dwpartment = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
            TextBox permission = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;

            string update = "Update TeacherstaffDetail set [name] = '" + name.Text + "',[email] = '" + email.Text + "',[password] = '" + password.Text + "',[role1] = '" + role1.Text + "',[role2] = '" + role2.Text + "',[DepatmentName] = '" + dwpartment.Text + "',[permission] = '" + permission.Text + "' where id=" + id.Text;

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = update;
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();

            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }
    }
}