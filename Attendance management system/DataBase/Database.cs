using System;
using System.Data;
using System.Data.SqlClient;

namespace Attendance_management_system.DataBase
{
    public class Database
    {
        private static readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["AMSConnectionString"].ConnectionString;
        readonly SqlCommand cmd;
        readonly SqlConnection sql;
        SqlDataReader sqlr;

        public Database()
        {
            sql = new SqlConnection(connection);
            sql.Open();
            cmd = sql.CreateCommand();
        }

        public (int, string) Login(string Email, string password)
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
            sqlr.Close();
            return (id, type);
        }

        public string Permission(int id)
        {
            string permission = "";
            cmd.CommandText = "select permission from TeacherstaffDetail where id=" + id;
            sqlr = cmd.ExecuteReader();
            while (sqlr.Read())
            {
                permission = sqlr[0].ToString().Trim();
            }
            sqlr.Close();
            return permission;
        }

        public int CreateDepartment(string name)
        {
            cmd.CommandText = "insert into DepartmentDetail (DepartmentName) values ('" + name + "')";
            cmd.ExecuteNonQuery();
            return 0;
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
            catch (Exception)
            {
                re = -1;
                return re;
            }
        }

        public int SelectQuary(string sqlS)
        {
            int i = 0;
            if (sqlS != String.Empty)
            {
                cmd.CommandText = sqlS;
                sqlr = cmd.ExecuteReader();
                while (sqlr.Read())
                {
                    i++;
                }
                sqlr.Close();
            }
            return i;
        }

        public String Get_Value(string coloum_name, string table_name, int Condition)
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
            catch (Exception)
            {
                //re = -1;
                return re;
            }
        }

        //to ensure the data value allready exit or not
        public int CheckExit(String tableName, string colume, String condition)
        {
            int i = 0;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select " + colume + " from " + tableName + " where " + condition;
            sqlr = cmd.ExecuteReader();
            while (sqlr.Read())
            {
                i++;
            }
            sqlr.Close();
            return i;
        }



    }
}