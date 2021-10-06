using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaalrusGUIPrototype
{
    public partial class frmReport : Form
    {
        public string connString = Properties.Settings.Default.conString;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);
            //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
            SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID FROM Accommodationset GROUP BY Accommodation_ID ORDER BY  count(*) DESC;", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            this.reportViewer.LocalReport.ReportPath = @"listAccomReport.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
            conn.Close();
            loadDataSet2();
        }
        public void loadDataSet2()
        {
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);
            //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
            SqlCommand myComm = new SqlCommand("SELECT * FROM Accommodationset;", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(myComm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            this.reportViewer.LocalReport.ReportPath = @"listAccomReport.rdlc";
            ReportDataSource rds2 = new ReportDataSource("DataSet2", dt);
            this.reportViewer.LocalReport.DataSources.Add(rds2);
            this.reportViewer.RefreshReport();
            conn.Close();
        }
    }
}
