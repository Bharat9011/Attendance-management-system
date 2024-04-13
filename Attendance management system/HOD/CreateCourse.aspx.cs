﻿using Attendance_management_system.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.HOD
{
    public partial class CreateCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                GetDepartment();
            }
        }

        private void GetDepartment()
        {
            string sessionval = Session["AccountID"].ToString();

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SHRIKHRISHNA\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;";
            sqlConnection.Open();
            string q = "SELECT [DepatmentName] FROM [TeacherstaffDetail] where id=" + sessionval;
            SqlCommand cmd = new SqlCommand(q, sqlConnection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Department.Text = sqlDataReader.GetString(0);
            }
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            string coursename = CourseName.Text.Trim();
            string department = Department.Text.Trim();

            Database database = new Database();
            int result = database.Execute_Sql("INSERT INTO[dbo].[CourseDeatil]([CourseName],[Co_ordinator],[DepartmentName]) VALUES('" + coursename + "','NULL' ,'" + department + "')");
            if (result == 1)
            {
                Response.Write("<script>alert('Data Save')</script>");
            }
            else
            {
                Response.Write("<script>alert('SomeThing Want wrong')</script>");
            }
        }
    }
}