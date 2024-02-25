using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace Attendance_management_system.DataBase
{
    public class Database
    {
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString"].ConnectionString;
        SqlCommand cmd;
        SqlConnection sql;
        SqlDataReader sqlr;

        public Database()
        {
            sql = new SqlConnection(connection);
            sql.Open();
            cmd = sql.CreateCommand();
        }

        public (int, string) login(string Email, string password)
        {
            int id = 0;
            String type = "none";
            cmd.CommandText = "select id,email,password,role1 from TeacherstaffDetail where email='" + Email + "' and password='" + password + "'";
            sqlr = cmd.ExecuteReader();
            while (sqlr.Read())
            {
                id = int.Parse(sqlr[0].ToString().Trim());
                type = sqlr[3].ToString().Trim();
            }

            return (id, type);
        }

        public int createDepartment(string name)
        {

            cmd.CommandText = "insert into DepartmentDetail (DepartmentName) values ('" + name + "')";
            cmd.ExecuteNonQuery();

            return 0;
        }

        public int CreateHODLogin(string name, string email, string password, string role1, string role2, string departmentName)
        {
            int result = -1;

            try
            {
                cmd.CommandText = "insert into TeacherstaffDetail (name,email,password,role1,role2,DepatmentName,permission) values ('" + name + "','" + email + "','" + password + "','" + role1 + "','" + role2 + "','" + departmentName + "','True')";
                cmd.ExecuteNonQuery();


                result = 0;
            } catch {
                result = -1;
            }

            return result;
        }

        public int getCourseID(string TableName, string columeName, string columeValue)
        {
            int result = -1;

            try
            {
                cmd.CommandText = "select id from " + TableName + " where " + columeName + "='" + columeValue.Trim() + "'";
                sqlr = cmd.ExecuteReader();
                while (sqlr.Read())
                {
                    result = Convert.ToInt32(sqlr["id"]);
                }
                sqlr.Close();
            }
            catch (Exception ex)
            {
                return Convert.ToInt16(ex) ;
            }
            return result;
        }

        public int Execute_Sql(String sql)
        {
            int re = -1;
            try
            {
                if (sql != String.Empty)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    re = 1;
                    
                }
                return re;
            }
            catch (Exception ex)
            {
                re = -1;
                return re;
            }
        }

        public int selectQuary(string sqlS)
        {
            try
            {
                int i = 0;
                if(sqlS != String.Empty)
                {
                    cmd.CommandText = sqlS;
                    sqlr = cmd.ExecuteReader() ;
                    while (sqlr.Read())
                    {
                        i++;
                    }
                    sqlr.Close();

                    if (i > 0)
                    {
                        return -1;
                    } else if (i == 0)
                    {
                        return 1;
                    }
                }
            } catch (Exception ex)
            {
                return -1;
            }
            return -1;
        }

        public String get_value(string coloum_name, string table_name, int Condition)
        {
            String re = "";
            try
            {
                string temp = "select " + coloum_name + " from " + table_name + " where  id=" + Condition;

                cmd.CommandText = temp;
                sqlr = cmd.ExecuteReader();
                while (sqlr.Read())
                {
                    re = Convert.ToString(sqlr["DepartmentName"]);
                }
                sqlr.Close();
                return re;
            }
            catch (Exception ex)
            {
                //re = -1;
                return re;
            }
        }
        
        public int insertDepartment(int departmentID,int RoleID)
        {
            int result = -1;
            try
            {
                string sqlInsert = "insert into DepartmentAllocation (DepartmentName,HODName) values ('" + departmentID + "','" + RoleID + "')";
                cmd.CommandText = sqlInsert;
                cmd.ExecuteNonQuery();

            } catch (Exception) {
                result = -1;
            }
            return 0;
        }

    }
}