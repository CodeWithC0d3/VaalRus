using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaalrusGUIPrototype
{
    public partial class frmReportBookings : Form
    {
        public string connString = Properties.Settings.Default.conString;
        public DateTime selectedMonth = new DateTime();
        public DateTime selectYear = new DateTime();
        public DateTime selectStart = new DateTime();
        public DateTime selectEnd = new DateTime();
        public frmReportBookings()
        {
            InitializeComponent();
        }
        /*public void testDataViewload()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            Server server = new Server(new ServerConnection(con));
            //string str = File.ReadAllText(@"_SQL\InitialData.txt");
            //server.ConnectionContext.ExecuteNonQuery(str);
            //str = File.ReadAllText(@"_SQL\ViewsLocal.txt");
            //server.ConnectionContext.ExecuteNonQuery(str);
            string str = File.ReadAllText(@"_SQL\viewReportBookings.txt");
            server.ConnectionContext.ExecuteNonQuery(str);

            con.Close();
        }*/
        private void frmReportBookings_Load(object sender, EventArgs e)
        {
            //DateTime year = new DateTime();
            //string yearval = DateTime.Now.Year.ToString();
            //string lastyear = DateTime.Now.AddYears(-1).ToString();
            //comboBoxYear.Items.Add(lastyear);
            //comboBoxYear.Items.Add(yearval);
            //for (int i = 0; i < 12; i++)
            //{
                //comboBoxMonth.Items.Add(i);
            //}
            //comboBoxYear
            this.reportViewer1.RefreshReport();
            
        }
        public void loadDataSet2()
        {
            try
            {
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);

                //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
                DateTime StartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime EndDate = new DateTime();
                EndDate = DateTime.Today.AddMonths(1);
                SqlCommand myComm = new SqlCommand("SELECT * FROM Quotation where Quotation_ID = '" +StartDate+ "' AND startDate < '" + EndDate + "' ;", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(myComm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                this.reportViewer1.LocalReport.ReportPath = @"Bookings.rdlc";
                ReportDataSource rds3 = new ReportDataSource("DataSetBooking", dt);
                this.reportViewer1.LocalReport.DataSources.Add(rds3);
                this.reportViewer1.RefreshReport();
                conn.Close();
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show(sqlx.ToString());
            }
        }
        public void loadDataSet3()
        {
            try
            {
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);

                //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
                DateTime StartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime EndDate = new DateTime();
                EndDate = DateTime.Today.AddMonths(1);
                SqlCommand myComm = new SqlCommand("SELECT * FROM Booking where startDate >= '" + StartDate + "' AND startDate < '" + EndDate + "' ;", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(myComm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //t
                SqlCommand myComm2 = new SqlCommand("SELECT * FROM Quotation", conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(myComm2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                //
                //
                SqlCommand myComm3 = new SqlCommand("SELECT * FROM Accommodationset", conn);
                SqlDataAdapter adapter3 = new SqlDataAdapter(myComm3);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                //
                //
                StartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                EndDate = new DateTime();
                EndDate = DateTime.Today.AddMonths(1);
                SqlCommand myComm4 = new SqlCommand("SELECT * FROM viewBookingReport where startDate >= '" + selectStart + "' AND startDate < '" + selectEnd + "' ;", conn);
                SqlDataAdapter adapter4 = new SqlDataAdapter(myComm4);
                DataTable dt4 = new DataTable();
                adapter4.Fill(dt4);
                //
                this.reportViewer1.LocalReport.ReportPath = @"Bookings.rdlc";
                ReportDataSource rds3 = new ReportDataSource("DataSetBooking", dt);
                ReportDataSource rds4 = new ReportDataSource("DataSetQ", dt2);
                ReportDataSource rds5 = new ReportDataSource("DataSetASet", dt3);
                ReportDataSource rds6 = new ReportDataSource("DataSet1", dt4);
                this.reportViewer1.LocalReport.DataSources.Add(rds3);
                this.reportViewer1.LocalReport.DataSources.Add(rds4);
                this.reportViewer1.LocalReport.DataSources.Add(rds5);
                this.reportViewer1.LocalReport.DataSources.Add(rds6);
                this.reportViewer1.RefreshReport();
                conn.Close();
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show(sqlx.ToString());
            }
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            if (true)
            {

                selectStart = dpStart.Value;
                selectEnd = dpEnd.Value;
                loadDataSet3();
            }
            else
            {
                MessageBox.Show("Please select Year and Month paramaters for the report");
            }
        }
    }
}
