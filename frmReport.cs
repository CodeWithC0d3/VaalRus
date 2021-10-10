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
        public DateTime selectStart = new DateTime();
        public DateTime selectEnd = new DateTime();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
            this.reportViewer.RefreshReport();
            LoadTheme();
            //loadDataSet2();
            //loadDataSet3();
        }
        public void loadDSet()
        {
            this.reportViewer.RefreshReport();
            //ReportParameterCollection reportParameters = new ReportParameterCollection();
            //reportParameters.Add(new ReportParameter("sDate", dpStart.Value.ToString()));
            //reportParameters.Add(new ReportParameter("sDate", "test"));
            //this.reportViewer.LocalReport.SetParameters(reportParameters);
            //this.reportViewer.RefreshReport();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SqlCommand myComm = new SqlCommand("Select * from Accommodation", conn);
            //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID, COUNT(Accommodation_ID) AS [value_occurrence] FROM Accommodationset GROUP BY Accommodation_ID ORDER BY [value_occurrence] DESC LIMIT 1;",conn);
            //SqlCommand myComm = new SqlCommand("SELECT Accommodation_ID FROM Accommodationset GROUP BY Accommodation_ID ORDER BY  count(*) DESC;", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(myComm);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            SqlCommand myComm2 = new SqlCommand("SELECT TOP 10 Accommodation_ID, AccommodationType FROM viewBookingReport1 where startDate >= '" + selectStart + "' AND startDate < '" + selectEnd + "' GROUP BY Accommodation_ID, AccommodationType ORDER BY  count(*) DESC ;", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(myComm2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            this.reportViewer.LocalReport.ReportPath = @"listAccomReport.rdlc";
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSet3", dt2);
            //this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.LocalReport.DataSources.Add(rds2);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("sDate", dpStart.Value.Date.ToShortDateString()));
            reportParameters.Add(new ReportParameter("eDate", dpEnd.Value.Date.ToShortDateString()));
            this.reportViewer.LocalReport.SetParameters(reportParameters);
            this.reportViewer.RefreshReport();

            this.reportViewer.RefreshReport();
            conn.Close();

        }
        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {

                // if (co.GetType() == typeof(Panel))
                // {
                //    co.Parent = this;
                //    co.BackColor = Color.Transparent;
                // }
                if (co.GetType() == typeof(Label))
                {
                    Label lbl = (Label)co;
                    lbl.Font = GlobalSettings.font;
                    lbl.Font = new Font("Microsoft Sans Serif", 12);
                    lbl.Parent = this;
                    lbl.ForeColor = GlobalSettings.SecondaryColor;
                    lbl.BackColor = Color.Transparent;

                }
                /*if (co.GetType() == typeof(Button))
                {
                    Button btn = (Button)co;
                    btn.FlatStyle = FlatStyle.Flat;
                    //btn.Parent = pictureBox1;
                    btn.BackColor = GlobalSettings.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = GlobalSettings.font;
                    //btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 2;
                }*/
            }


            aplytheme(panelInput);

        }
        private void aplytheme(Control pn)
        {
            if (pn.GetType() == typeof(Panel))
            {
                foreach (Control co in pn.Controls)
                {
                    if (co.GetType() == typeof(Button))
                    {
                        Button btn = (Button)co;
                        btn.FlatStyle = FlatStyle.Flat;
                        //btn.Parent = pictureBox1;
                        btn.BackColor = GlobalSettings.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.Font = GlobalSettings.font;
                        //btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                        btn.FlatAppearance.BorderColor = Color.White;
                        btn.FlatAppearance.BorderSize = 2;
                    }
                    if (co.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)co;
                        lbl.Font = GlobalSettings.font;
                        //lbl.Parent = picBackground;
                        //lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.ForeColor = Color.White;
                        lbl.BackColor = Color.Transparent;

                    }
                    if (co.GetType() == typeof(DataGridView))
                    {
                        DataGridView dtgg = (DataGridView)co;
                        dtgg.ForeColor = Color.White;
                        dtgg.BackgroundColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.BackColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.Font = new Font("Arial", float.Parse("10"), FontStyle.Regular);
                        dtgg.DefaultCellStyle.SelectionBackColor = GlobalSettings.ChangeColorBrightness(GlobalSettings.PrimaryColor, -0.2);
                        dtgg.ColumnHeadersDefaultCellStyle.BackColor = GlobalSettings.ChangeColorBrightness(GlobalSettings.PrimaryColor, -0.2);
                        dtgg.ColumnHeadersDefaultCellStyle.SelectionBackColor = GlobalSettings.ChangeColorBrightness(GlobalSettings.PrimaryColor, -0.2);
                        dtgg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dtgg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dtgg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    }
                    if (co.GetType() == typeof(CheckBox))
                    {
                        CheckBox chkk = (CheckBox)co;
                        chkk.ForeColor = GlobalSettings.SecondaryColor;

                    }
                    if (co.GetType() == typeof(TextBox))
                    {
                        TextBox txtC = (TextBox)co;
                        txtC.ForeColor = GlobalSettings.SecondaryColor;

                    }
                    if (co.GetType() == typeof(ComboBox))
                    {
                        ComboBox cmbc = (ComboBox)co;
                        cmbc.ForeColor = GlobalSettings.SecondaryColor;
                        cmbc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(DateTimePicker))
                    {
                        DateTimePicker dtpc = (DateTimePicker)co;
                        dtpc.ForeColor = GlobalSettings.SecondaryColor;
                        dtpc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(GroupBox))
                    {
                        GroupBox gpc = (GroupBox)co;
                        gpc.ForeColor = GlobalSettings.SecondaryColor;
                        gpc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(ListBox))
                    {
                        ListBox lsc = (ListBox)co;
                        lsc.ForeColor = GlobalSettings.SecondaryColor;
                        lsc.Font = GlobalSettings.font;

                    }
                }

            }
        }
        

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.RefreshReport();
                selectStart = dpStart.Value;
                selectEnd = dpEnd.Value;
                loadDSet();
                
                //ReportParameter p1 = new ReportParameter("sDate", dpStart.Value.ToString());
                //ReportParameter p2 = new ReportParameter("eDate", selectEnd.ToString());
                //this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
                //loadDataSet3();
            }
            else
            {
                MessageBox.Show("Please select Year and Month paramaters for the report");
            }
        }
    }
}
