using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Attendance_management_system.test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string month = DateTime.Now.ToString("MMM");
            string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();


            GridView1.DataSource = Fab(month, year);
            GridView1.DataBind();

        }

        private DataTable Fab(string data, string year)
        {
            DataTable fab = new DataTable(); ;

            if (data == "May")
            {

                for (int j = 1; j <= 31; j++)
                {
                    fab.Columns.Add(j + "/" + data + "/" + year, typeof(string));
                }

                for(int a = 1;  a < 31; a++)
                {
                    /*fab.Rows.Add(k,);
*/
                    /*for (int a = 1; a < 31; a++)
                    {*/
                        /*DataRow row = fab.NewRow();
                        row[a + "/" + data + "/" + year] = a;*/
                        fab.Rows.Add(a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a);
                    /*}*/
                }



                /*List<object[]> list = null;
                for (int k = 1; k <= 31; k++) {
                    list = new List<object[]>
                    {
                        new object[] { 23 }
                    };
                }

                foreach (object[] row in list)
                {
                    DataRow dataRow = fab.NewRow();
                    dataRow.ItemArray = row;
                    fab.Rows.Add(dataRow);
                }*/

            }

            /*                for (int i = 5; i == 5; i++)
                            {
                                DataRow dataRow = fab.NewRow();

                                for (int k = 1; k <= 31; k++)
                                {
                                    dataRow["" + k + "/" + data + "/" + year] = 23;
                                }

                                fab.Rows.Add(dataRow);
                            }*/

            /*                    DataRow dataRow2 = fab.NewRow();

                                for (int j = 1; j <= 31; j++)
                                {
                                    dataRow2["" + j + "/" + data + "/" + year] = 23;
                                }

                                fab.Rows.Add(dataRow2);*/


            /*fab.Columns.Add("1/"+data+"/"+year, typeof(string));
fab.Columns.Add("2/" + data + "/" + year, typeof(string));
fab.Columns.Add("3/" + data + "/" + year, typeof(string));
fab.Columns.Add("4/" + data + "/" + year, typeof(string));
fab.Columns.Add("5/" + data + "/" + year, typeof(string));
fab.Columns.Add("6/" + data + "/" + year, typeof(string));
fab.Columns.Add("7/" + data + "/" + year, typeof(string));
fab.Columns.Add("8/" + data + "/" + year, typeof(string));
fab.Columns.Add("9/" + data + "/" + year, typeof(string));
fab.Columns.Add("10/" + data + "/" + year, typeof(string));
fab.Columns.Add("11/" + data + "/" + year, typeof(string));
fab.Columns.Add("12/" + data + "/" + year, typeof(string));
fab.Columns.Add("13/" + data + "/" + year, typeof(string));
fab.Columns.Add("14/" + data + "/" + year, typeof(string));
fab.Columns.Add("15/" + data + "/" + year, typeof(string));
fab.Columns.Add("16/" + data + "/" + year, typeof(string));
fab.Columns.Add("17/" + data + "/" + year, typeof(string));
fab.Columns.Add("18/" + data + "/" + year, typeof(string));
fab.Columns.Add("19/" + data + "/" + year, typeof(string));
fab.Columns.Add("20/" + data + "/" + year, typeof(string));
fab.Columns.Add("21/" + data + "/" + year, typeof(string));
*/

            /*          dataRow["2/" + data + "/" + year] = 23;
                      dataRow["3/" + data + "/" + year] = 23;
                      dataRow["4/" + data + "/" + year] = 23;
                      dataRow["5/" + data + "/" + year] = 23;
                      dataRow["6/" + data + "/" + year] = 23;
                      dataRow["7/" + data + "/" + year] = 23;
                      dataRow["8/" + data + "/" + year] = 23;
                      dataRow["9/" + data + "/" + year] = 23;
                      dataRow["10/" + data + "/" + year] = 23;
                      dataRow["11/" + data + "/" + year] = 23;
                      dataRow["12/" + data + "/" + year] = 23;
                      dataRow["13/" + data + "/" + year] = 23;
                      dataRow["14/" + data + "/" + year] = 23;
                      dataRow["15/" + data + "/" + year] = 23;
                      dataRow["16/" + data + "/" + year] = 23;
                      dataRow["17/" + data + "/" + year] = 23;
                      dataRow["18/" + data + "/" + year] = 23;
                      dataRow["19/" + data + "/" + year] = 23;
                      dataRow["20/" + data + "/" + year] = 23;
                      dataRow["21/" + data + "/" + year] = 23;
          */

            /*            DataRow dataRow1 = fab.NewRow();

                        dataRow1["1/" + data + "/" + year] = 23;
                        dataRow1["2/" + data + "/" + year] = 23;
                        dataRow1["3/" + data + "/" + year] = 23;
                        dataRow1["4/" + data + "/" + year] = 23;
                        dataRow1["5/" + data + "/" + year] = 23;
                        dataRow1["6/" + data + "/" + year] = 23;
                        dataRow1["7/" + data + "/" + year] = 23;
                        dataRow1["8/" + data + "/" + year] = 23;
                        dataRow1["9/" + data + "/" + year] = 23;
                        dataRow1["10/" + data + "/" + year] = 23;*/
            /*fab.Rows.Add(dataRow1);*/
            return fab;
        }


    }

        /*private void temp()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Data", typeof(string));
            dataTable.Columns.Add("mark", typeof(string));

            dataTable.Rows.Add("hello", 23);
            dataTable.Rows.Add("hello", 23);
            dataTable.Rows.Add("hello", 23);
            dataTable.Rows.Add("hello", 23);
            dataTable.Rows.Add("hello", 23);

            *//*DataRow dataRow = dataTable.NewRow();
            dataRow["Data"] = "Data";
            dataRow["mark"] = "Data";

            DataRow dataRow2 = dataTable.NewRow();
            dataRow2["Data"] = "Data";
            dataRow2["mark"] = "Data";

            dataTable.Rows.Add(dataRow2);*//*

            GridView1.DataSource = dataTable;
            GridView1.DataBind();

            *//*dataTable.Columns.Add("Data");
            for (int i = 0; i < 10; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = "Test";
                dataTable.Rows.Add(dataRow);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }


            dataTable.Columns.Add("Data 1");
            for (int i = 0; i < 10; i++)
            {
                DataRow dataRow2 = dataTable.NewRow();
                dataRow2[0] = "Test";
                dataTable.Rows.Add(dataRow2);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }*//*
        }*/

    
}