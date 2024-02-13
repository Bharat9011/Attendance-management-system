using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Attendance_management_system.DataBase
{
    public class Database
    {
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString"].ConnectionString;
        SqlConnection sql;
        SqlCommand cmd;

        public Database()
        {
            SqlConnection sql = new SqlConnection(connection);
            sql.Open();
            cmd = sql.CreateCommand();
        }

        public (int, string) login(string Email, string password)
        {
            int id = 0;
            String type = "none";
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select id,email,password,role1 from TeacherstaffDetail where email='" + Email + "' and password='" + password + "'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString().Trim());
                        type = reader[3].ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                return (0, "Account Not Found");
            }
            return (id, type);
        }

        public int createDepartment(string name)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into DepartmentDetail (DepartmentName,DepartmentHODName) values ('" + name + "',' ')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }

            return 0;
        }

        public int CreateHODLogin(string name, string email, string password, string role1, string role2, string departmentName)
        {
            int result = -1;
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into TeacherstaffDetail (name,email,password,role1,role2,DepatmentName) values ('" + name + "','" + email + "','" + password + "','" + role1 + "','" + role2 + "','" + departmentName + "')";
                cmd.ExecuteNonQuery();
                result = 0;
            }
            catch (Exception ex)
            {
                return -1;
            }

            return result;
        }

        public int getCourseID(string TableName, string columeName, string columeValue)
        {
            try
            {
                
                cmd.CommandText = "select id from " + TableName + " where " + columeName + "='" + columeValue.Trim() + "'";
                SqlDataReader sqlr = cmd.ExecuteReader();
                while (sqlr.Read()) {
                    return Convert.ToInt32(sqlr["id"]);
                }
            }
            catch (Exception ex)
            {
            }
            return -1;
        }
    }
}