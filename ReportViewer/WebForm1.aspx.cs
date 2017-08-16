using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ReportViewer.Report;
using static ReportViewer.connection;

namespace ReportViewer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
       
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/Report1.rdlc");
                ReportViewer1.LocalReport.EnableExternalImages = true;
                DataLayer dl = new DataLayer();
                TestDataSet atsi = new TestDataSet();
                 atsi = dl.GetData("select * from ViewTesting");
                ReportDataSource datasource = new ReportDataSource("DataSet1", atsi.Tables["DataTable1"]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
             
            }
        }   
    }

 

    
}