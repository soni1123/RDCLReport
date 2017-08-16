using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ReportViewer.Report;

namespace ReportViewer
{

    public class connection
    {
        public static string con = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;

        public class DataLayer
        {
            public TestDataSet GetData(string query)
            {
                SqlCommand cmd = new SqlCommand(query);
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = conn;
                        sda.SelectCommand = cmd;
                        using (TestDataSet atsi = new TestDataSet())
                        {
                            sda.Fill(atsi, "DataTable1");
                            return atsi;
                        }
                    }
                    //}
                }

            }
        }
    }
}
