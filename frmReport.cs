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
            //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID FROM Accommodationset GROUP BY Accommodation_ID ORDER BY  count(*) DESC;", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(myComm);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            SqlCommand myComm2 = new SqlCommand("SELECT Accommodation_ID, AccommodationType FROM viewBookingReport1 GROUP BY Accommodation_ID, AccommodationType ORDER BY  count(*) DESC;", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(myComm2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            this.reportViewer.LocalReport.ReportPath = @"listAccomReport.rdlc";
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSet3", dt2);
            //this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.LocalReport.DataSources.Add(rds2);
            this.reportViewer.RefreshReport();
            conn.Close();
            loadDataSet2();
            //loadDataSet3();
        }
        public void loadDataSet3()
        {
            try
            {
                this.reportViewer.RefreshReport();
                this.reportViewer.RefreshReport();

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);

                //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
                DateTime StartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime EndDate = new DateTime();
                EndDate = DateTime.Today.AddMonths(1);
                SqlCommand myComm = new SqlCommand("SELECT * FROM Booking where startDate >= '"+StartDate+ "' AND startDate < '" + EndDate + "' ;", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(myComm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                this.reportViewer.LocalReport.ReportPath = @"Bookings.rdlc";
                ReportDataSource rds3 = new ReportDataSource("DataSetBooking", dt);
                this.reportViewer.LocalReport.DataSources.Add(rds3);
                this.reportViewer.RefreshReport();
                conn.Close();
            }catch(SqlException sqlx)
            {
                MessageBox.Show(sqlx.ToString());
            }
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
