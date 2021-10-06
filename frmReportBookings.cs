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
    public partial class frmReportBookings : Form
    {
        public string connString = Properties.Settings.Default.conString;
        public frmReportBookings()
        {
            InitializeComponent();
        }

        private void frmReportBookings_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            loadDataSet3();
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
    }
}
