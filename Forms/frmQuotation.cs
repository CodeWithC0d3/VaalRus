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
    public partial class frmQuotation : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        //Boolean isLoad =false;
        string sql = "";
        private int customerID;
        private List<int> accList = new List<int>();
        private decimal totalPrice;
        private string createdDate;
        private String createdBy;
        private Boolean selectFirst = false;
        private int quoteId;
        private string startDate;
        private string endDate;
        private int Bookdays;
        private string selectedQuoteID;
        private string selectedCustomerID;

        private ErrorProvider userErrorProvider;
        private ErrorProvider customerErrorProvider;
        private ErrorProvider fromDateErrorProvider;
        private ErrorProvider toDateErrorProvider;
        private ErrorProvider typeErrorProvider;
        private ErrorProvider accListErrorProvider;

        public frmQuotation()
        {
            InitializeComponent();
            pictureBox1.Dock = DockStyle.Fill;
            //pnlMain.Parent = this;
            //pnlMain.BackColor = Color.Transparent;
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
          aplytheme(pn_grid);
           aplytheme(pnl_accSet);
            timer1.Start();
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

        private void createErProviders()
        {
            userErrorProvider = new ErrorProvider();
            userErrorProvider.SetIconAlignment(txtUser, ErrorIconAlignment.MiddleRight);
            userErrorProvider.SetIconPadding(txtUser, 2);
            userErrorProvider.BlinkRate = 1000;
            userErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            customerErrorProvider = new ErrorProvider();
            customerErrorProvider.SetIconAlignment(cmbCustomer, ErrorIconAlignment.MiddleRight);
            customerErrorProvider.SetIconPadding(cmbCustomer, 2);
            customerErrorProvider.BlinkRate = 1000;
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
            accListErrorProvider.SetIconAlignment(lstAccommodation, ErrorIconAlignment.BottomRight);
            accListErrorProvider.SetIconPadding(lstAccommodation, 2);
            accListErrorProvider.BlinkRate = 1000;
            accListErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

        }
        private void validatetxtUser()
        {
            if (txtUser.Text == "")
            {
                userErrorProvider.SetError(txtUser, "Please provide User");
                btnGeneratQuote.Enabled = false;
                txtUser.BackColor = Color.IndianRed;
            }
            else
            {
                userErrorProvider.SetError(txtUser, "");
                btnGeneratQuote.Enabled = true;
                txtUser.BackColor = Color.White;
            }
            if (txtUser.Text.Length < 2 && txtUser.Text != "")
            {
                userErrorProvider.SetError(txtUser, "User name must be atleast 2 characters");
                btnGeneratQuote.Enabled = false;
                txtUser.BackColor = Color.IndianRed;
            }
            else
            {
                userErrorProvider.SetError(txtUser, "");
                btnGeneratQuote.Enabled = true;
                txtUser.BackColor = Color.White;
            }
        }
        private void validatecmbCustomer()
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                customerErrorProvider.SetError(cmbCustomer, "Please Choose a Customer");
                btnGeneratQuote.Enabled = false;
                cmbCustomer.BackColor = Color.IndianRed;
            }
            else
            {
                customerErrorProvider.SetError(cmbCustomer, "2");
                btnGeneratQuote.Enabled = true;
                cmbCustomer.BackColor = Color.White;
            }
        }
        private void validateDPFrom()
        {
            if (dpFrom.Value > dpTo.Value)
            {
                fromDateErrorProvider.SetError(dpFrom, "From Date can not be after TO date");
                btnGeneratQuote.Enabled = false;
                dpFrom.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(dpFrom, "");
                btnGeneratQuote.Enabled = true;
                dpFrom.BackColor = Color.White;
            }
        }
        private void validateType()
        {
            if (cmbFilter.Text == "")
            {
                typeErrorProvider.SetError(cmbFilter, "From Date can not be after TO date");
                btnGeneratQuote.Enabled = false;
                cmbFilter.BackColor = Color.IndianRed;
            }
            else
            {
                typeErrorProvider.SetError(cmbFilter, "");
                btnGeneratQuote.Enabled = true;
                cmbFilter.BackColor = Color.White;
            }
        }
        private void validateList()
        {
           
                if (lstAccommodation.Items.Count == 0)
                {
                    accListErrorProvider.SetError(lstAccommodation, "Please select atleast one accommodation");
                    btnGeneratQuote.Enabled = false;
                    lstAccommodation.BackColor = Color.IndianRed;
                }
                else
                {
                    accListErrorProvider.SetError(lstAccommodation, "");
                    btnGeneratQuote.Enabled = true;
                    lstAccommodation.BackColor = Color.White;
                }
           
            
                
                
        }
        private void frmQuotation_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            pnlMain.Visible = true;
            LoadTheme();
            cmbFilter.SelectedIndex = -1;
            dp_filterTo.Value = dp_filterFrom.Value.AddDays(14);
            loadCmbCustomers();
            loadcmbFilter();
            if (rb_booking.Checked || rb_quote.Checked)
            {
                
                DateTime startDate = DateTime.Now.Date;
                DateTime endDate = DateTime.Now.AddDays(14);
                updateGrid(startDate, endDate);
            }
            
            //timer1.Start();
            createErProviders();


            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            txtUser.Focus();
            //sizeGrid();

        }
        private void updateGrid(DateTime startDate,DateTime endDate)
        {
            string stDate = startDate.Date.ToString("yyyy/MM/dd");
            string eDate = endDate.Date.ToString("yyyy/MM/dd");
            if (conDB())
            {
                string strto = ch_to.Checked ? $"and Booking.EndDate < '{eDate}';" : "";
                int duration = (endDate.Date - startDate.Date).Days;
                string strduration = ch_to.Checked ? $"and Quotation.Duration < {duration}" : "";
                //sql = $"select * from Booking where StartDate >@stdate and EndDate < @edate ";
                if (rb_booking.Checked)
                {
                    sql = $"SELECT Booking.Booking_ID, Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name], Booking.StartDate, Booking.EndDate, Accommodationset.Quotation_ID FROM Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID INNER JOIN Accommodationset ON Booking.Quotation_ID = Accommodationset.Quotation_ID where Booking.StartDate > @stdate {strto}";
                }
                   
                if (rb_quote.Checked)
                {
                    sql = $"SELECT Quotation.Quotation_ID, Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name], Quotation.Reservation_Date AS [Reservation Date], Quotation.Duration, Quotation.TotalPrice, Quotationstatus.Status_Type AS Status FROM Quotation INNER JOIN Customer ON dbo.Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID WHERE Quotation.Reservation_Date > @stdate {strduration}";
                }
                   
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@stdate", stDate);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Booking_ID");
                //adapter.Fill(ds, "CustomerID");
               
                grid_main.DataSource = ds;
                grid_main.DataMember = "Booking_ID";
                con.Close();
            }
            sizeGrid();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // pnlMain.Visible = true;
            pictureBox1.Visible = false;
           timer1.Stop();
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
        
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null)
            {
                customerID = int.Parse(cmbCustomer.SelectedValue.ToString());
            }                 
            //customerErrorProvider.SetError(cmbCustomer,"");
            
        }

        private void cmbCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void cmbCustomer_Enter(object sender, EventArgs e)
        {
           
        }
        private void loadCmbCustomers()
        {
            if (conDB())
            {
                sql = "SELECT 	Customer_ID,Customer_FirstName + ' - ' +  Customer_LastName As Contact FROM Customer";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer_ID");
                //adapter.Fill(ds, "CustomerID");
                cmbCustomer.ValueMember = "Customer_ID";
                cmbCustomer.DisplayMember = "Contact";                
                cmbCustomer.DataSource = ds.Tables[0];
                con.Close();

            }
        }
        private void loadcmbFilter()
        {
            if (conDB())
            {
                sql = "select AccommodationType from Accommodationtype";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "AccommodationType");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbFilter.Items.Add(row.ItemArray[0]);
                }
               
                con.Close();

            }
        }
       
        private void loadCmbAcc()
        {
            if (conDB() && cmbFilter.SelectedIndex != -1)
            {
                if (cmbAccommodation.DataSource == null)
                {                      
                    cmbAccommodation.Items.Clear();
                }
                else
                {
                    
                    cmbAccommodation.DataSource = null;
                    cmbAccommodation.Items.Clear();
                }
               
                DateTime startDT = dpFrom.Value;
                DateTime endDT = dpTo.Value;
                string typeValue = cmbFilter.SelectedItem.ToString();
                if (cmbFilter.SelectedIndex == 0)
                {
                    sql = $"SELECT Accommodation.Accommodation_ID, cast(Accommodation.Accommodation_ID as varchar) + '-' + Accommodationtype.AccommodationType As accmerge FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
                }
                else
                {
                    sql = $"SELECT Accommodation.Accommodation_ID, cast(Accommodation.Accommodation_ID as varchar) + '-' + Accommodationtype.AccommodationType As accmerge FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID WHERE (dbo.Accommodationtype.AccommodationType = '{typeValue}');";
                }                
 
                command = new SqlCommand(sql,con);
                adapter = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds1);

                sql = $"SELECT 	Accommodation_ID, AccommodationType FROM accAvailibility WHERE StartDate >= '{startDT.Date.ToString("yyyy/MM/dd")}' and EndDate <= '{endDT.Date.ToString("yyyy/MM/dd")}'";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                foreach (DataRow row1 in ds1.Tables[0].Rows) 
                {
                    foreach (DataRow row2 in ds.Tables[0].Rows)
                    {
                        string st1 = row1.ItemArray[0].ToString();
                        string st2 = row2.ItemArray[0].ToString();
                        if (row1.ItemArray[0].ToString() == row2.ItemArray[0].ToString())
                        {
                            row1.Delete();                            
                            break; // break inner loop
                        }
                    }
                  
                }
                ds1.AcceptChanges();
                foreach (var it in lstAccommodation.Items)
                {
                    foreach (DataRow row2 in ds1.Tables[0].Rows)
                    {
                        if (row2.ItemArray[0].ToString() == it.ToString())
                            row2.Delete();
                    }
                }
                ds1.AcceptChanges();
                cmbAccommodation.DisplayMember = "accmerge";
                cmbAccommodation.ValueMember = "Accommodation_ID";
                cmbAccommodation.DataSource = ds1.Tables[0];
                cmbAccommodation.SelectedIndex = -1;

                //cmbAccommodation.DataSource = ds1.Tables[0];
                con.Close();

            }
        }

        private void cmbAccommodation_Enter(object sender, EventArgs e)
        {
            //loadCmbAcc();
        }        
        private void cmbAccommodation_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView row = (DataRowView)cmbAccommodation.SelectedItem;
            if (cmbAccommodation.SelectedIndex != -1)
            {
                if (selectFirst)
                {
                    string s = row["accmerge"].ToString();
                    lstAccommodation.Items.Add(s);
                    //string substring = st.Substring(0,st.IndexOf(' '));
                    string t = cmbAccommodation.SelectedValue.ToString();
                    accList.Add(int.Parse(t));
                }               
                else
                    selectFirst = true;
                loadCmbAcc();
            }

            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmbAccommodation.SelectedIndex = -1;
            selectFirst = false;
            loadCmbAcc();
            cmbAccommodation.Enabled = true;

           
        }
        private decimal getTotalPrice(List<int> ls)
        {
            decimal price = 0;

            con = new SqlConnection(constr);            
            for (int i = 0; i < ls.Count; i++)
            {
                con.Open();
                sql = "SELECT Accommodation_price  from Accommodation where Accommodation_ID = @id";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@id", ls[i].ToString()); ;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                price += (decimal)dataReader.GetValue(0);
                con.Close();
            }           
         
            return price;
        }
        private void clearControls()
        {
            txtUser.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbFilter.SelectedIndex = -1;
            cmbAccommodation.Enabled = false;
            lstAccommodation.Items.Clear();
        }
        private void btnGeneratQuote_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || cmbCustomer.SelectedIndex < 0 || lstAccommodation.Items.Count < 1)
            {
                validateList();
                return;
            }
                
            totalPrice = getTotalPrice(accList);
            createdBy = txtUser.Text;
            createdDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            startDate = dpFrom.Value.ToString("yyyy/MM/dd");
            endDate = dpTo.Value.ToString("yyyy/MM/dd");
            Bookdays = (dpTo.Value.Date - dpFrom.Value.Date).Days;
            if (conDB())
            {
                sql = "Insert Into Quotation(Customer_ID, Reservation_Date, Duration,TotalPrice,QuoteStatus,QuoteCreated_DateTime,CreatedBy) Values(@cid, @rdate, @duration,@tp,@ps,@Qdate,@cBy)";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@cid", customerID);
                command.Parameters.AddWithValue("@rdate", startDate);
                command.Parameters.AddWithValue("@duration", Bookdays);
                command.Parameters.AddWithValue("@tp", totalPrice);
                command.Parameters.AddWithValue("@ps", "1");
                command.Parameters.AddWithValue("@Qdate", createdDate);
                command.Parameters.AddWithValue("@cBy", createdBy);
                command.ExecuteNonQuery();
                sql = "select Quotation_ID from Quotation where Customer_ID = @Cid And Reservation_Date = @start";
                command = new SqlCommand(sql,con);
                command.Parameters.AddWithValue("@Cid",customerID);
                command.Parameters.AddWithValue("@start", startDate);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                quoteId = (int)dataReader.GetValue(0);
                con.Close();
                addAccSet(accList);


                if (rb_booking.Checked || rb_quote.Checked)
                {

                    DateTime startDate = DateTime.Now.Date;
                    DateTime endDate = DateTime.Now.AddDays(14);
                    updateGrid(startDate, endDate);
                }
                //sizeGrid();

            }
        }
        
        private int getID(String col1, string table, string col2, string value)
        {
            int i = 0;
            if (conDB())
            {
                sql = $"select '{col1}' from '{table}' where '{col2}' = '{value}'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                i = (int)dataReader.GetValue(0);
                con.Close();

            }
            return i;

        }
        private void addAccSet(List<int> ls)
        {
            con = new SqlConnection(constr);
            for (int i = 0;i< accList.Count;i++)
            {
            con.Open();
            sql = $"Insert Into Accommodationset(Quotation_ID, Accommodation_ID, startDate,endDate) Values(@Qid, @Accid, @start,@end)";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Qid", quoteId);
            command.Parameters.AddWithValue("@Accid", ls[i]);
            command.Parameters.AddWithValue("@start", startDate);
            command.Parameters.AddWithValue("@end", endDate);
            command.ExecuteNonQuery();
            con.Close();
            }
            clearControls();
        }
        private void cmbAccommodation_DropDown(object sender, EventArgs e)
        {
            cmbAccommodation.SelectedIndex = -1;
        }

        private void cmbAccommodation_DropDownClosed(object sender, EventArgs e)
        {
           // cmbAccommodation.SelectedIndex = -1;
        }

        private void btnClearLst_Click(object sender, EventArgs e)
        {
            lstAccommodation.Items.Clear();
            totalPrice = 0;
            cmbAccommodation.SelectedIndex = -1;           
            //selectFirst = false;
        }

        private void dp_filterFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dp_filterFrom.Value.Date,dp_filterTo.Value.Date) == -1)
            {
                updateGrid(dp_filterFrom.Value.Date,dp_filterTo.Value.Date);
                //sizeGrid();
            }
        }

        private void dp_filterTo_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dp_filterFrom.Value.Date, dp_filterTo.Value.Date) == -1 && ch_to.Checked)
            {
                updateGrid(dp_filterFrom.Value.Date, dp_filterTo.Value.Date);
                //sizeGrid();
            }
        }

        private void txtUser_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            validatetxtUser();
            
        }        

        private void cmbCustomer_Validated(object sender, EventArgs e)
        {
            
        }

        private void rb_quote_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_quote.Checked)
            {
                dp_filterFrom.Enabled = true;
                DateTime startDate = DateTime.Now.Date;
                DateTime endDate = DateTime.Now.AddDays(14);
                updateGrid(startDate, endDate);
                //dp_filterTo.Enabled = true;
            }                
        }

        private void rb_booking_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_booking.Checked)
            {
                dp_filterFrom.Enabled = true;
                DateTime startDate = DateTime.Now.Date;
                DateTime endDate = DateTime.Now.AddDays(14);
                updateGrid(startDate, endDate);
                // dp_filterTo.Enabled = true;
            }
        }

        private void ch_to_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_to.Checked)
                dp_filterTo.Enabled = true;
            else
                dp_filterTo.Enabled = false;
        }

        private void updateAccGrid(string Quot)
        {           
            if (conDB())
            {
                //string strto = ch_to.Checked ? $"and Booking.EndDate < '{eDate}';" : "";
               // int duration = (endDate.Date - startDate.Date).Days;
                //string strduration = ch_to.Checked ? $"and Quotation.Duration < {duration}" : "";
                //sql = $"select * from Booking where StartDate >@stdate and EndDate < @edate ";
       

     
                sql = $"SELECT Accommodationset.Quotation_ID AS [Quote Number], Accommodationset.Accommodation_ID AS [Acc Number], Accommodationtype.AccommodationType AS Type, Accommodationset.startDate, Quotation.Duration AS[Duration / days] FROM Accommodationset INNER JOIN Accommodation ON Accommodationset.Accommodation_ID = Accommodation.Accommodation_ID INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID INNER JOIN Quotation ON Accommodationset.Quotation_ID = Quotation.Quotation_ID WHERE Quotation.Quotation_ID = @idd";
   
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@idd", Quot);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");
                //adapter.Fill(ds, "CustomerID");

                grid_accSet.DataSource = ds;
                grid_accSet.DataMember = "Quotation_ID";
                con.Close();
            }
            sizeAccgrid();
        }

        private void grid_main_SelectionChanged(object sender, EventArgs e)
        {

            if (grid_main.CurrentRow != null)
            {
                try
                {
                    string id = grid_main.CurrentRow.Cells[0].Value.ToString();
                    updateAccGrid(id);
                }
                catch (Exception)
                {

                }
            }
            //if (grid_main.CurrentRow.Index )    
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlReport.Visible = false;
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            genQuote();
        }
        private void genQuote()
        {
            reportViewer1.LocalReport.ReportPath = @"Reports\Quote.rdlc";
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new Margins(1,1,1,1);
            reportViewer1.SetPageSettings(setup);
            
            ReportDataSource rds = new ReportDataSource("DataSet1", qlist());
            ReportDataSource rds2 = new ReportDataSource("Accl", accListreport());
            ReportDataSource rds3 = new ReportDataSource("Customer", customerReport());
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
            pnlReport.Parent = this;
            pnlReport.BringToFront();
            pnlReport.Dock = DockStyle.Fill;
            pnlReport.Visible = true;
        }    
       
        private List<quoteDetail> qlist()
        {
            List<quoteDetail> list = new List<quoteDetail>();
            if (conDB())
            {
                sql = $"SELECT Quotation_ID, Reservation_Date,Duration,TotalPrice FROM Quotation WHERE Quotation_ID = @qID";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@qID", selectedQuoteID);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");
                con.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    quoteDetail ls = new quoteDetail();
                    ls.QuoteNr = row.ItemArray[0].ToString();
                    ls.Booked = row.ItemArray[1].ToString().Substring(0, row.ItemArray[1].ToString().IndexOf(" "));
                    ls.Duration = row.ItemArray[2].ToString();
                    ls.Price = row.ItemArray[3].ToString();                    
                    list.Add(ls);
                }
            }
            return list;
        }
        private List<accListReport> accListreport()
        {
            List<accListReport> list = new List<accListReport>();
            if (conDB())
            {
                sql = $"SELECT Accommodationset.Quotation_ID, Accommodationset.Accommodation_ID, Accommodationtype.AccommodationType, Accommodationset.startDate, Accommodationset.endDate, Accommodation.Accommodation_Price FROM Accommodationset INNER JOIN Accommodation ON Accommodationset.Accommodation_ID = Accommodation.Accommodation_ID INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID WHERE Quotation_ID = @qID";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@qID", selectedQuoteID);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Quotation_ID");
                con.Close();                
                 
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    accListReport ls = new accListReport();
                    ls.QuoteID = row.ItemArray[0].ToString();
                    ls.AccommodationID = row.ItemArray[1].ToString();
                    ls.Type = row.ItemArray[2].ToString();
                    ls.StartDate = row.ItemArray[3].ToString().Substring(0, row.ItemArray[3].ToString().LastIndexOf(" "));
                    ls.EndDate = row.ItemArray[4].ToString().Substring(0, row.ItemArray[4].ToString().IndexOf(" "));
                    ls.Price = row.ItemArray[5].ToString();
                    list.Add(ls);
                }

            }
            return list;
        }
        private List<CustomerDetail> customerReport()
        {
            List<CustomerDetail> list = new List<CustomerDetail>();
            if (conDB())
            {
                sql = $"SELECT Quotation.Quotation_ID, Customer.Customer_ID FROM Quotation INNER JOIN Customer ON Quotation.Customer_ID = Customer.Customer_ID WHERE Quotation_ID = @qid";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@qID", selectedQuoteID);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                selectedCustomerID = dataReader.GetValue(0).ToString();
                con.Close();
                con.Open();
                sql = $"SELECT Customer_FirstName, Customer_LastName, Customer_Cell, Customer_Email FROM Customer WHERE Customer_ID = @cID";
                command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@cID", selectedQuoteID);
                //command.Parameters.AddWithValue("@edate", eDate);
                //command.Parameters.AddWithValue("@to", strto);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer_FirstName");
                con.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    CustomerDetail ls = new CustomerDetail();
                    ls.FirstName = row.ItemArray[0].ToString();
                    ls.LastName = row.ItemArray[1].ToString();
                    ls.Cell = row.ItemArray[2].ToString();
                    ls.email = row.ItemArray[3].ToString();
                    
                    list.Add(ls);
                }

            }
            return list;
        }

        private void grid_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_main.CurrentCell != null)
            {
                btnQuote.Enabled = true;
                selectedQuoteID = grid_main.SelectedCells[0].Value.ToString();
            }
            
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
           // validatecmbCustomer();
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            validateDPFrom();
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            validateDPFrom();
        }

        private void lstAccommodation_Validated(object sender, EventArgs e)
        {
            //validateList();
        }

        private void cmbAccommodation_Validated(object sender, EventArgs e)
        {

        }

        private void grid_main_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

           // e.Column.FillWeight = 500;
        }
        private void sizeGrid()
        {
            for (int i =0; i< grid_main.Columns.Count;i++)
            {
               grid_main.Columns[i].MinimumWidth = 100;


            }
           
        }
        private void sizeAccgrid()
        {
            for (int i = 0; i < grid_accSet.Columns.Count; i++)
            {
                grid_accSet.Columns[i].MinimumWidth = 100;


            }
        }

        private void lstAccommodation_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void lstAccommodation_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lstAccommodation.Items.Count > 0)
            {
                accListErrorProvider.SetError(lstAccommodation, "");
                btnGeneratQuote.Enabled = true;
                lstAccommodation.BackColor = Color.White;
                
            }
            
        }
    }
}
