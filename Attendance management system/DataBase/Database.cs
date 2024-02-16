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
                cmd.CommandText = "insert into TeacherstaffDetail (name,email,password,role1,role2,DepatmentName) values ('" + name + "','" + email + "','" + password + "','" + role1 + "','" + role2 + "','" + departmentName + "')";
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

        public int insertDepartment(int DapatmentName,int HODname) {

            int result = -1;

            int exit = allreadyExit(DapatmentName, HODname);

            /*return result = exit;*/

            if (exit == 0)
            {
                return result = 0;
            }

            if (exit == 1)
            {
                try
                {
                    cmd.CommandText = "insert into DepartmentAllocation (DepartmentName,HODName) values (@DepartmentName1, @HODName1)";
                    cmd.Parameters.AddWithValue("@DepartmentName1", DapatmentName);
                    cmd.Parameters.AddWithValue("@HODName1", HODname);
                    cmd.ExecuteNonQuery();
                    
                    return result = 1;
                }
                catch (Exception)
                {
                    return result = -1;
                }
            }

            if (exit == -1)
            {
                return result = -1;
            }

            return result;

        }

        public int allreadyExit(int DepartmentNO, int HODno)
        {
            int result = -1;

            cmd.CommandText = "select DepartmentName,HODName from [DepartmentAllocation] where DepartmentName=@DepartmentName2 and HODName=@HODno2";
            cmd.Parameters.AddWithValue("@DepartmentName2", DepartmentNO);
            cmd.Parameters.AddWithValue("@HODno2", HODno);
            sqlr = cmd.ExecuteReader();

            int i = 0;

            while (sqlr.Read())
            {
                i++;
            }
            sqlr.Close();

            if (i > 0)
            {
                return result = 0;
            }
            else
            {
                return result = departmentAllreadyExit(DepartmentNO,HODno);
            }
            return result;
        }

        public int departmentAllreadyExit(int DepartmentNO,int HOD)
        {
            int result = -1;

            cmd.CommandText = "select DepartmentName from [DepartmentAllocation] where DepartmentName=@DepartmentName3";
            cmd.Parameters.AddWithValue("@DepartmentName3", DepartmentNO);
            sqlr = cmd.ExecuteReader();

            int i = 0;

            while (sqlr.Read())
            {
                i++;
            }
            sqlr.Close();

            if (i > 0)
            {
                return result = 0;
            }
            else
            {
                return HODAllreadyExit(HOD);
            }

            return -1;

        }


        public int HODAllreadyExit(int HODNo)
        {
            int result = -1;

            cmd.CommandText = "select HODName from [DepartmentAllocation] where HODName=@HOD3";
            cmd.Parameters.AddWithValue("@HOD3", HODNo);
            sqlr = cmd.ExecuteReader();

            int i = 0;

            while (sqlr.Read())
            {
                i++;
            }
            sqlr.Close();

            if (i > 0)
            {
                return result = 0;
            }
            else
            {
                return result = 1;
            }

            return -1;

        }
    }
}