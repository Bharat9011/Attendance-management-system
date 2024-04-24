using System;
using System.Data;
using System.Data.SqlClient;

namespace Attendance_management_system.Co_ordinator
{
    public partial class ShowSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                SetDataInGridView();
            }
        }

        private void SetDataInGridView()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;");
            sqlConnection.Open();
            string s = @"SELECT 
                n.id,
                n.SubjectName,
                t.name AS SubjectTeacher,
                n.Year,
                n.Semister,
                t2.name AS TeacherName,
                d.DepartmentName,
                c.CourseName
            FROM 
                SubjectTable n 
            JOIN 
                TeacherstaffDetail t ON n.SubjectTeacher = t.id
            JOIN 
                TeacherstaffDetail t2 ON n.SubjectCreateBy = t2.id
            JOIN 
                DepartmentDetail d ON n.SubjectDepartmentID = d.id
            JOIN 
                CourseDeatil c ON n.SubjctCourseID = c.id
            WHERE 
                n.SubjectCreateBy = @AccountID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@AccountID", Session["AccountID"]);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }


        }
    }
}