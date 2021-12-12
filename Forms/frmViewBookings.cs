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

namespace vaalrusGUIPrototype.Forms
{
    public partial class frmViewBookings : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        public frmViewBookings()
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

            aplytheme(panel1);
            aplytheme(pnlViewBookings);

            aplytheme(panel2);
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
            for (int i = 0; i < dataGridViewBookings.Columns.Count; i++)
            {
                dataGridViewBookings.Columns[i].MinimumWidth = 100;
            }
        }
        private void frmViewBookings_Load(object sender, EventArgs e)
        {
            LoadTheme();
            rdPending.Checked = true;
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

        private void radbViewAllBookings_CheckedChanged(object sender, EventArgs e)
        {
            populateDataGrid();
            grpBoxSelectPeriod.Enabled = false;

        }

        private void populateDataGrid()
        {
            //populate the data grid
            if (conDB())
            {
                string queryText = $"SELECT Booking.Booking_ID, Booking.Quotation_ID, Customer.Customer_FirstName AS Name, Customer.Customer_LastName AS Surname, Booking.StartDate, Booking.EndDate,Booking.Checkin_Time AS [Check in], Booking.Checkin_Out AS [Check out] FROM Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID";
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                command = new SqlCommand(queryText, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Booking");
                dataGridViewBookings.DataSource = ds;
                dataGridViewBookings.DataMember = "Booking";
                con.Close();
            }
        }

        private void rdbSelectPeriod_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxSelectPeriod.Enabled = true;
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            string queryText2 = $"SELECT Quotation.Quotation_ID, Quotation.Reservation_Date AS [Start date], Customer.Customer_FirstName AS Name, Customer.Customer_LastName AS Surname, Quotationstatus.Status_Type AS Status FROM Quotation INNER JOIN Customer ON Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID WHERE  (Quotation.QuoteStatus = @status) AND (Quotation.Reservation_Date >= @frDate) AND (Quotation.Duration <= @duration)";
            string queryText = $"SELECT Booking.Booking_ID, Quotation.Quotation_ID, Customer.Customer_FirstName AS Name, Customer.Customer_LastName AS Surname, Booking.StartDate, Booking.EndDate, Booking.Checkin_Time AS [Check in], Booking.Checkin_Out AS [Check out], Quotationstatus.Status_Type AS Status FROM Booking INNER JOIN Quotation ON Booking.Quotation_ID = Quotation.Quotation_ID INNER JOIN Quotationstatus ON Quotation.QuoteStatus = Quotationstatus.Status_ID INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID AND Quotation.Customer_ID = Customer.Customer_ID WHERE  (Booking.StartDate >= @frDate) AND (Booking.EndDate <= @toDate) AND (Quotation.QuoteStatus = @status)";
            
            adapter = new SqlDataAdapter();
            if (conDB())
            {
                if (rdPending.Checked)
                {
                    ds = new DataSet();
                    command = new SqlCommand(queryText2, con);
                    command.Parameters.AddWithValue("@frDate", dateTimePickerStart.Value.Date.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("@duration", (dateTimePickerEnd.Value.Date - dateTimePickerStart.Value.Date).Days);
                    command.Parameters.AddWithValue("@status", 1);
                    adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Quotation_ID");
                    dataGridViewBookings.DataSource = ds;
                    dataGridViewBookings.DataMember = "Quotation_ID";
                    con.Close();
                }
                else if (rdPayed.Checked)
                {
                    ds = new DataSet();
                    command = new SqlCommand(queryText, con);
                    command.Parameters.AddWithValue("@frDate", dateTimePickerStart.Value.Date.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("@toDate", dateTimePickerEnd.Value.Date.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("@status", 2);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Booking");
                    dataGridViewBookings.DataSource = ds;
                    dataGridViewBookings.DataMember = "Booking";
                    con.Close();
                }
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            populateDataGrid();
            rdPending.Checked = true;
            rdPayed.Checked = false;
            dateTimePickerStart.Value = DateTime.Today.Date;
            dateTimePickerEnd.Value = DateTime.Today.Date;
        }
       
        private void dataGridViewBookings_SelectionChanged(object sender, EventArgs e)
        {
            string id = "";
            try
            {
              
                if (rdPending.Checked)
                {
                    id = dataGridViewBookings.CurrentRow.Cells[0].Value.ToString();
                }
                else if (rdPayed.Checked)
                {
                    id = dataGridViewBookings.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    //id = dataGridViewBookings.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {

           
            }
            
            if (conDB() && id.All(Char.IsDigit) )
            {
                try
                {
                    string sql = "SELECT Accommodation.Accommodation_ID AS [ID],Accommodation.Common_Name AS [Name], Accommodationtype.AccommodationType AS [Type], Accommodationset.startDate AS [Start Date], Accommodationset.endDate AS [End Date] FROM Accommodation INNER JOIN Accommodationset ON Accommodation.Accommodation_ID = Accommodationset.Accommodation_ID INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID INNER JOIN Quotation ON dbo.Accommodationset.Quotation_ID = Quotation.Quotation_ID WHERE (Accommodationset.Quotation_ID = @id)";
                    command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@id", id);
                    ds = new DataSet();
                    adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Accommodation_ID");
                    gridACC.DataMember = "Accommodation_ID";
                    gridACC.DataSource = ds;
                    con.Close();
                }
                catch (Exception)
                {

                   
                }
                
            }
        }
    }
}
