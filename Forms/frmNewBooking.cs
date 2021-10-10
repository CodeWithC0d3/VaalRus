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

        private ErrorProvider customerIDErrorProvider;
        private ErrorProvider quoteTextErrorProvider;
        private ErrorProvider fromDateErrorProvider;
        private ErrorProvider amountrecievedErrorProvider;
        /*private ErrorProvider userErrorProvider;          
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
                        dtgg.AllowUserToAddRows = false;
                        dtgg.AllowUserToDeleteRows = false;
                        dtgg.AllowUserToOrderColumns = false;
                        dtgg.AllowUserToResizeRows = false;
                        dtgg.AllowUserToResizeColumns = true;
                        dtgg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        dtgg.RowHeadersVisible = false;
                        dtgg.ColumnHeadersHeight = 4;
                        dtgg.EnableHeadersVisualStyles = false;


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
                        gpc.ForeColor = Color.White;
                        gpc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(ListBox))
                    {
                        ListBox lsc = (ListBox)co;
                        lsc.ForeColor = GlobalSettings.SecondaryColor;
                        lsc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(CheckBox))
                    {
                        CheckBox ch = (CheckBox)co;
                        ch.ForeColor = Color.White;
                        ch.Font = GlobalSettings.font;

                    }
                }

            }
        }
        private void sizeGrid()
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].MinimumWidth = 100;
            }

        }
        private void frmNewBooking_Load(object sender, EventArgs e)
        {
            LoadTheme();
            createErProviders();
            if(conDB())
            {
                sql = $"SELECT Quotation.Quotation_ID, Customer.Customer_FirstName AS [First name], Customer.Customer_LastName AS [Last name],Customer.Customer_IDNumber AS [ID], Quotation.Reservation_Date AS [Start date], Quotation.TotalPrice AS [Total price], Quotationstatus.Status_Type AS [Status] FROM Quotation INNER JOIN Customer ON Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID WHERE (Quotation.QuoteStatus = 1)";
                command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@stdate", stDate);
                
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");         

                grid.DataSource = ds;
                grid.DataMember = "Quotation_ID";
                con.Close();
            }
            sizeGrid();
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
                string strduration = "";
                string cusID = "";
                string qID = "";
                string fdate = "";
                string andd = "";

                int duration = (endDate.Date - startDate.Date).Days;
                if (ch_to.Checked)
                    strduration = $" and Quotation.Duration <= {duration}";
                if (txtFilterID.Text != "")
                {
                    if (ch_dateRange.Checked || txtFilterQuote.Text != "")
                        cusID = $" and Customer_IDNumber = '" + txtFilterID.Text + "'";
                    else
                        cusID = $" Customer_IDNumber = '" + txtFilterID.Text + "'";
                }
                if (txtFilterQuote.Text != "")
                {
                    if (ch_dateRange.Checked)
                        qID = $" and Quotation_ID = '" + txtFilterQuote.Text + "'";
                    else
                        qID = $" Quotation_ID = '" + txtFilterQuote.Text + "'";
                }
                if (ch_dateRange.Checked)
                    fdate = $"Quotation.Reservation_Date >= '{stDate}'";
                if (strduration == "" && cusID == "" && qID == "" && fdate == "")
                    andd = "";
                else
                    andd = " and ";


                //sql = $"select * from Booking where StartDate >@stdate and EndDate < @edate ";                
                sql = $"SELECT Quotation.Quotation_ID, Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name],Customer.Customer_IDNumber AS [ID], Quotation.Reservation_Date AS [Start date], Quotation.Duration, Quotation.TotalPrice AS [TotalPrice], Quotationstatus.Status_Type AS Status FROM Quotation INNER JOIN Customer ON dbo.Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID WHERE QuoteStatus = 1 {andd} {fdate} {qID} {cusID} {strduration} ";
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
            sizeGrid();
        }
        private void createErProviders()
        {
            customerIDErrorProvider = new ErrorProvider();
            customerIDErrorProvider.SetIconAlignment(txtFilterID, ErrorIconAlignment.MiddleRight);
            customerIDErrorProvider.SetIconPadding(txtFilterID, 2);
            customerIDErrorProvider.BlinkRate = 1000;
            customerIDErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            quoteTextErrorProvider = new ErrorProvider();
            quoteTextErrorProvider.SetIconAlignment(txtFilterQuote, ErrorIconAlignment.MiddleRight);
            quoteTextErrorProvider.SetIconPadding(txtFilterQuote, 2);
            quoteTextErrorProvider.BlinkRate = 1000;
            quoteTextErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
 
            fromDateErrorProvider = new ErrorProvider();
            fromDateErrorProvider.SetIconAlignment(dp_filterFrom, ErrorIconAlignment.MiddleRight);
            fromDateErrorProvider.SetIconPadding(dp_filterFrom, 2);
            fromDateErrorProvider.BlinkRate = 1000;
            fromDateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            amountrecievedErrorProvider = new ErrorProvider();
            amountrecievedErrorProvider.SetIconAlignment(txtRecievedAmount, ErrorIconAlignment.MiddleRight);
            amountrecievedErrorProvider.SetIconPadding(txtRecievedAmount, 2);
            amountrecievedErrorProvider.BlinkRate = 1000;
            amountrecievedErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
/*

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

        

        private void ch_to_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_to.Checked)
            {
                dp_filterTo.Enabled = true;
                if (dp_filterFrom.Value > dp_filterTo.Value && dp_filterTo.Enabled == true)
                {
                    fromDateErrorProvider.SetError(dp_filterFrom, "From Date can not be after TO date");
                    btnFilter.Enabled = false;
                    dp_filterFrom.BackColor = Color.IndianRed;
                }
                else
                {
                    fromDateErrorProvider.SetError(dp_filterFrom, "");
                    btnFilter.Enabled = true;
                    dp_filterFrom.BackColor = Color.White;
                }
            }
                
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
                sql = $" SELECT Quotation.Quotation_ID, Customer.Customer_FirstName, Customer.Customer_LastName, Customer.Customer_IDNumber, Customer.Customer_Cell, Customer.Customer_Email, Quotation.Reservation_Date, Quotation.Duration, Quotation.TotalPrice FROM Quotation INNER JOIN Customer ON Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID WHERE Quotation_ID = @qid";
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
            if (grid.CurrentRow != null)
            {
                qid = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());

                fillInFormation();
            }           
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            loadGrid();
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
            clearControls();
            loadGrid();

        }
        private void clearControls()
        {
            txtname.Text = "";
            txtlastName.Text = "";
            txtIdNumber.Text = "";
            txtCell.Text = "";
            txtemail.Text = "";
            txtQuotenr.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtAmount.Text = "";
            lsAcc.Items.Clear();
            dpRecieved.Value = DateTime.Now.Date;
            txtRecievedAmount.Text = "";
            txtRecievedAmount.Focus();
        }

        private void txtFilterID_TextChanged(object sender, EventArgs e)
        {
            if ((!txtFilterID.Text.All(char.IsDigit) && txtFilterID.Text != "") || (txtFilterID.Text.Length != 13 && txtFilterID.Text != ""))
            {
                customerIDErrorProvider.SetError(txtFilterID, "ID Number only contains Digits and need to be 13 Characters");
                btnFilter.Enabled = false;
                txtFilterID.BackColor = Color.IndianRed;
            }
            else
            {
                customerIDErrorProvider.SetError(txtFilterID, "");
                btnFilter.Enabled = true;
                txtFilterID.BackColor = Color.White;
            }
            
        }

        private void txtFilterID_Validating(object sender, CancelEventArgs e)
        {
            if (txtFilterID.Text.Length != 13 && txtFilterID.Text != "")
            {
                customerIDErrorProvider.SetError(txtFilterID, "ID Number need 13 numbers");
                btnFilter.Enabled = false;
                txtFilterID.BackColor = Color.IndianRed;
            }
            else if (txtFilterID.Text != "")
            {
               // customerIDErrorProvider.SetError(txtFilterID, "");        
                //btnFilter.Enabled = true;
               // txtFilterID.BackColor = Color.Wheat;
                if (conDB())
                {
                    sql = $"SELECT Customer_IDNumber from Customer where Customer_IDNumber = @cusid";
                    command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@cusid",txtFilterID.Text);
                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    adapter.SelectCommand = command;                  
                    adapter.Fill(ds, "Customer_ID");                 
                    con.Close();
                }
                if (ds.Tables[0].Rows.Count <1)
                {
                    customerIDErrorProvider.SetError(txtFilterID, "The Customer IDnumber does no match any Customer");
                    btnFilter.Enabled = false;
                    txtFilterID.BackColor = Color.IndianRed;
                }
                else
                {
                    customerIDErrorProvider.SetError(txtFilterID, "");
                    btnFilter.Enabled = true;
                    txtFilterID.BackColor = Color.White;
                }
            }
            

        }

        private void txtFilterQuote_TextChanged(object sender, EventArgs e)
        {
            if (!txtFilterQuote.Text.All(char.IsDigit) && txtFilterQuote.Text != "")
            {
                quoteTextErrorProvider.SetError(txtFilterQuote, "Quote Numbers only contains Digits");
                btnFilter.Enabled = false;
                txtFilterQuote.BackColor = Color.IndianRed;
            }
            else
            {
                quoteTextErrorProvider.SetError(txtFilterQuote, "");
                btnFilter.Enabled = true;
                txtFilterQuote.BackColor = Color.White;
            }
        }

        private void txtFilterQuote_Validated(object sender, EventArgs e)
        {
            if (txtFilterQuote.Text != "")
            {
                if (conDB())
                {
                    sql = $"SELECT Quotation_ID from Quotation WHERE Quotation_ID = @qid";
                    command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@qid", txtFilterQuote.Text);
                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adapter.Fill(ds, "Quotation_ID");
                    con.Close();
                }
                if (ds.Tables[0].Rows.Count < 1)
                {
                    quoteTextErrorProvider.SetError(txtFilterQuote, "The Quote number does no match any Quote");
                    btnFilter.Enabled = false;
                    txtFilterQuote.BackColor = Color.IndianRed;
                }
                else
                {
                    quoteTextErrorProvider.SetError(txtFilterQuote, "");
                    btnFilter.Enabled = true;
                    txtFilterQuote.BackColor = Color.White;
                }
            }
            else if (txtFilterQuote.Text == "")
            {
                quoteTextErrorProvider.SetError(txtFilterQuote, "");
                btnFilter.Enabled = true;
                txtFilterQuote.BackColor = Color.White;
            }
            


            
        }

        private void dp_filterFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dp_filterFrom.Value > dp_filterTo.Value && dp_filterTo.Enabled == true)
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "From Date can not be after TO date");
                btnFilter.Enabled = false;
                dp_filterFrom.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "");
                btnFilter.Enabled = true;
                dp_filterFrom.BackColor = Color.White;
            }
        }

        private void dp_filterTo_ValueChanged(object sender, EventArgs e)
        {
            if (dp_filterFrom.Value > dp_filterTo.Value && dp_filterTo.Enabled == true)
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "From Date can not be after TO date");
                btnFilter.Enabled = false;
                dp_filterFrom.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "");
                btnFilter.Enabled = true;
                dp_filterFrom.BackColor = Color.White;
            }
        }

        private void dp_filterFrom_Validated(object sender, EventArgs e)
        {
            if (dp_filterFrom.Value > dp_filterTo.Value && dp_filterTo.Enabled == true)
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "From Date can not be after to date");
                btnFilter.Enabled = false;
                dp_filterFrom.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(dp_filterFrom, "");
                btnFilter.Enabled = true;
                dp_filterFrom.BackColor = Color.White;
            }
        }

        private void txtRecievedAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtRecievedAmount.Text.All(char.IsLetter) && txtRecievedAmount.Text != "")
            {
                fromDateErrorProvider.SetError(txtRecievedAmount, "Please enter valid price");
                btnCreate.Enabled = false;
                txtRecievedAmount.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(txtRecievedAmount, "");
                btnCreate.Enabled = true;
                txtRecievedAmount.BackColor = Color.White;
            }
        }

        private void grid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 500;
        }
    }
}
