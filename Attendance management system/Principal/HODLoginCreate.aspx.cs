﻿using Attendance_management_system.DataBase;
using System;

namespace Attendance_management_system.Principal
{
    public partial class HODLoginCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createLogin(object sender,EventArgs e)
        {
            Database db = new Database();

            int result = db.CreateHODLogin(NameTeacher.Text, EmailTeacher.Text, PasswordTeacher.Text, Role1.Text, Role2.Text, DName.Text);

            //int result = DB.insertDepartment(department, Role);

            if (result == -1)
            {
                Response.Write("<script>alert('Something want wrong')</script>");
            }
            else if (result == 1)
            {
                Response.Write("<script>alert('Successfully Allocation')</script>");
            }
            else if (result == 0)
            {
                Response.Write("<script>alert('This is allready HOD')</script>");
            }

            /*if (result == -1)
            {
                string script = "alert('Something want wrong n plz try again later');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                NameTeacher.Text = "";
                EmailTeacher.Text = "";
                PasswordTeacher.Text = "";
                Role1.Text = "";
                Role2.Text = "";
            }
            else if (result == 0)
            {
                string script = "alert('Department sccessfully create');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                
                NameTeacher.Text = "";
                EmailTeacher.Text = "";
                PasswordTeacher.Text = "";
                Role1.Text = "";
                Role2.Text = "";
            }*/
        }
    }
}