using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace vaalrusGUIPrototype.Forms
{
    public partial class frmNewBooking : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql = "";
        int qid;
        int duration = 0;
        string cusID;
        string name;
        string lastName;
        string idNumber;
        string cell;
        string email;
        string startDate;
        string endDate;
        decimal amount;

        /*private ErrorProvider userErrorProvider;
        private ErrorProvider customerErrorProvider;
        private ErrorProvider fromDateErrorProvider;
        private ErrorProvider toDateErrorProvider;
        private ErrorProvider typeErrorProvider;
        private ErrorProvider accListErrorProvider;*/
        public frmNewBooking()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {

                // if (co.GetType() == typeof(Panel))
                // {
                //    co.Parent = this;
                //   co.BackColor = Color.FromArgb(58, 93, 117);
                //}
                if (co.GetType() == typeof(Label))
                {
                    Label lbl = (Label)co;
                    lbl.Font = GlobalSettings.font;
                    lbl.Font = new Font("Microsoft Sans Serif", 12);
                    lbl.Parent = this;
                    lbl.ForeColor = GlobalSettings.SecondaryColor;
                    lbl.BackColor = Color.Transparent;

                }
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
            }
            //pnlMain.BackColor = Color.Transparent;

            aplytheme(pnlMain);
            aplytheme(pnlFilter);
            aplytheme(pnlGrid);
            aplytheme(pnlBookDetail);
            aplytheme(pnlButtons);
            aplytheme(pnlCusInformation);
            aplytheme(pnlPayment);

            //aplytheme(pnl_accSet);
            //timer1.Start();
        }
        private void aplytheme(Control pn)
        {
            if (pn.GetType() == typeof(Panel))
            {
                pn.BackColor = Color.FromArgb(58, 93, 117);
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
        private void frmNewBooking_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private Boolean conDB()
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        private void loadGrid()
        {
            DateTime startDate = dp_filterFrom.Value.Date;
            DateTime endDate = dp_filterTo.Value.Date;
            string stDate = startDate.Date.ToString("yyyy/MM/dd");
            string eDate = endDate.Date.ToString("yyyy/MM/dd");
            
            if (conDB())
            {
                //$" and Customer_IDNumber = '" + txtFilterID.Text + "'"
                int duration = (endDate.Date - startDate.Date).Days;
                string strduration = ch_to.Checked ? $" and Quotation.Duration <= {duration}" : "";
                string cusID = txtFilterID.Text != "" ? ch_dateRange.Checked ? $" and Customer_IDNumber = '" + txtFilterID.Text + "'" : $" Customer_IDNumber = '" + txtFilterID.Text + "'" : "";
                string qID = txtFilterQuote.Text != "" ? $" Quotation_ID = '" + txtFilterQuote.Text + "'" : "";
                string fdate = txtFilterQuote.Text == "" ? $"Quotation.Reservation_Date >= '{stDate}'" : "";

                //sql = $"select * from Booking where StartDate >@stdate and EndDate < @edate ";                
                sql = $"SELECT Quotation.Quotation_ID, Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name],Customer.Customer_IDNumber, Quotation.Reservation_Date AS [Reservation Date], Quotation.Duration, Quotation.TotalPrice, Quotationstatus.Status_Type AS Status FROM Quotation INNER JOIN Customer ON dbo.Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.PaymentStatus = Quotationstatus.Status_ID WHERE {fdate} {qID} {cusID} {strduration} ";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@stdate", stDate);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");
                //adapter.Fill(ds, "CustomerID");

                grid.DataSource = ds;
                grid.DataMember = "Quotation_ID";
                con.Close();
            }
        }
        private void createErProviders()
        {
            /*userErrorProvider = new ErrorProvider();

            userErrorProvider.SetIconAlignment(txtUser, ErrorIconAlignment.MiddleRight);
            userErrorProvider.SetIconPadding(txtUser, 2);
            userErrorProvider.BlinkRate = 1000;
            userErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            customerErrorProvider = new ErrorProvider();
            customerErrorProvider.SetIconAlignment(cmbCustomer, ErrorIconAlignment.MiddleRight);
            customerErrorProvider.SetIconPadding(cmbCustomer, 2);
            customerErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            fromDateErrorProvider = new ErrorProvider();
            fromDateErrorProvider.SetIconAlignment(dpFrom, ErrorIconAlignment.MiddleRight);
            fromDateErrorProvider.SetIconPadding(dpFrom, 2);
            fromDateErrorProvider.BlinkRate = 1000;
            fromDateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            toDateErrorProvider = new ErrorProvider();
            toDateErrorProvider.SetIconAlignment(dpTo, ErrorIconAlignment.MiddleRight);
            toDateErrorProvider.SetIconPadding(dpTo, 2);
            toDateErrorProvider.BlinkRate = 1000;
            toDateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            typeErrorProvider = new ErrorProvider();
            typeErrorProvider.SetIconAlignment(cmbFilter, ErrorIconAlignment.MiddleRight);
            typeErrorProvider.SetIconPadding(cmbFilter, 2);
            typeErrorProvider.BlinkRate = 1000;
            typeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            accListErrorProvider = new ErrorProvider();
            accListErrorProvider.SetIconAlignment(lstAccommodation, ErrorIconAlignment.MiddleRight);
            accListErrorProvider.SetIconPadding(lstAccommodation, 2);
            accListErrorProvider.BlinkRate = 1000;
            accListErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;*/

        }

        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void ch_to_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_to.Checked)
                dp_filterTo.Enabled = true;
            else
                dp_filterTo.Enabled = false;
        }

        private void ch_dateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_dateRange.Checked)
                dp_filterFrom.Enabled = true;
            else
            {
                dp_filterFrom.Enabled = false;
                ch_to.Checked = false;
            }
                
        }

        private void fillInFormation()
        {
            if (conDB())
            {

                //int duration = 0;
                DateTime sdate = DateTime.Now.Date;
                sql = $" SELECT Quotation.Quotation_ID, Customer.Customer_FirstName, Customer.Customer_LastName, Customer.Customer_IDNumber, Customer.Customer_Cell, Customer.Customer_Email, Quotation.Reservation_Date, Quotation.Duration, Quotation.TotalPrice FROM Quotation INNER JOIN Customer ON Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.PaymentStatus = Quotationstatus.Status_ID WHERE Quotation_ID = @qid";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@qid", qid);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");

                duration = int.Parse(ds.Tables[0].Rows[0].ItemArray[7].ToString());
                name = txtname.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                lastName = txtlastName.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                idNumber = txtIdNumber.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                cell =  txtCell.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                email = txtemail.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                txtQuotenr.Text = qid.ToString(); 
                startDate = txtStartDate.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                endDate = txtEndDate.Text = sdate.Date.AddDays(duration).ToString();
                txtAmount.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
                amount = decimal.Parse(ds.Tables[0].Rows[0].ItemArray[8].ToString());
                sql = $"SELECT Accommodation_ID from Accommodationset WHERE Quotation_ID = @qid ";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@qid", qid);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");
                lsAcc.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lsAcc.Items.Add(row.ItemArray[0] );
                }
                con.Close();
            }

        }
        private void grid_SelectionChanged(object sender, EventArgs e)
        {

            qid = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            
            fillInFormation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conDB())
            {
                sql = "SELECT Customer_ID FROM Quotation WHERE Quotation_ID = @qid";
                command = new SqlCommand(sql,con);
                command.Parameters.AddWithValue("@qid",qid);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                cusID = dataReader.GetValue(0).ToString();
                dataReader.Close();
                sql = "Insert Into Booking(Customer_ID, Quotation_ID, StartDate,EndDate) Values(@cid, @qid, @startDate,@endDate)";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@cid", cusID );
                command.Parameters.AddWithValue("@qid", qid);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.ExecuteNonQuery();

                sql = "UPDATE Quotation SET PaymentStatus = @complete WHERE Quotation_ID = @qid";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@complete", 2);
                command.Parameters.AddWithValue("@qid",qid);
                command.ExecuteNonQuery();

                sql = "INSERT INTO Payment(Quotation_ID, ReceivedAmount ,Payment_Date,Payment_Status) Values(@qid,@amount,@paymentdate,@paymentstatus)";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@amount", txtRecievedAmount.Text);
                command.Parameters.AddWithValue("@paymentdate", dpRecieved.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("@paymentstatus", 1);
                command.Parameters.AddWithValue("@qid", qid);
                
                
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Booking created");
            loadGrid();

        }
    }
}
