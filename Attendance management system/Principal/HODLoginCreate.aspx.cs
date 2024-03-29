using Attendance_management_system.DataBase;
using System;

namespace Attendance_management_system.Principal
{
    public partial class HODLoginCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void createLogin(object sender, EventArgs e)
        {
            /*string name = NameTeacher.Text;
            string email = EmailTeacher.Text;
            string password = PasswordTeacher.Text;
            string role1 = Role1.SelectedItem.Text.Trim();
            string role2 = Role2.SelectedItem.Text.Trim();
            string department = DName.SelectedItem.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                if (!string.IsNullOrEmpty(email))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        if (!string.IsNullOrEmpty(role1))
                        {
                            if (!string.IsNullOrEmpty(role2))
                            {
                                if (!string.IsNullOrEmpty(department))
                                {

                                    Database database = new Database();
                                    int deresult = database.selectQuary("select DepatmentName from TeacherstaffDetail where DepatmentName='" + department + "'");
                                    if (deresult == 0)
                                    {
                                        int result = database.checkexit("TeacherstaffDetail", "email", "email='" + email + "'");
                                        if (result == 0)
                                        {
                                            string sql = "insert into TeacherstaffDetail ([name],[email],[password],[role1],[role2],[DepatmentName],[permission]) values"
                                                + "('" + name + "','" + email + "','" + password + "','" + role1 + "','" + role2 + "','" + department + "','YES')";
                                            Database database1 = new Database();
                                            int resultex = database.Execute_Sql(sql);
                                            if (resultex == 1)
                                            {
                                                MessageBox.Visible = true;
                                                massage.Style.Add("color", "#87A330");
                                                massage.Text = "Data Save";
                                            }
                                            else
                                            {
                                                MessageBox.Visible = true;
                                                massage.Style.Add("color", "#FF0000");
                                                massage.Text = "SomeThing wants wrong";
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Visible = true;
                                            massage.Style.Add("color", "#FF0000");
                                            massage.Text = "Email is not avaliable";
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Visible = true;
                                        massage.Style.Add("color", "#FF0000");
                                        massage.Text = "department is allready allocated";
                                    }

                                }
                                else
                                {
                                    MessageBox.Visible = true;
                                    massage.Style.Add("color", "#FF0000");
                                    massage.Text = "Department is Empty";
                                }
                            }
                            else
                            {
                                MessageBox.Visible = true;
                                massage.Style.Add("color", "#FF0000");
                                massage.Text = "Role 2 is Empty";
                            }
                        }
                        else
                        {
                            MessageBox.Visible = true;
                            massage.Style.Add("color", "#FF0000");
                            massage.Text = "Role is Empty";
                        }
                    }
                    else
                    {
                        MessageBox.Visible = true;
                        massage.Style.Add("color", "#FF0000");
                        massage.Text = "Password is Empty";
                    }
                }
                else
                {
                    MessageBox.Visible = true;
                    massage.Style.Add("color", "#FF0000");
                    massage.Text = "Email is Empty";
                }

            }
            else
            {
                MessageBox.Visible = true;
                massage.Style.Add("color", "#FF0000");
                massage.Text = "Name is Empty";
            }
        }*/
        }
    }
}