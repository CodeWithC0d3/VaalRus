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

            //aplytheme(pnlViewBookings);
            aplytheme(pnlViewBookings);

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
            for (int i = 0; i < dataGridViewBookings.Columns.Count; i++)
            {
                dataGridViewBookings.Columns[i].MinimumWidth = 100;
            }
        }
        private void frmViewBookings_Load(object sender, EventArgs e)
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

        private void radbViewAllBookings_CheckedChanged(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void populateDataGrid()
        {
            //populate the data grid
            if (conDB())
            {
                string queryText = $"SELECT dbo.Booking.Booking_ID, dbo.Customer.Customer_FirstName, dbo.Customer.Customer_LastName, dbo.Booking.StartDate, dbo.Booking.EndDate, dbo.Quotationstatus.Status_Type FROM dbo.Booking INNER JOIN Quotation ON dbo.Booking.Quotation_ID = dbo.Quotation.Quotation_ID INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID AND Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.PaymentStatus = Quotationstatus.Status_ID WHERE (Quotation.PaymentStatus = 1)";
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
            if (chkBoxPending.Checked)
            {
                chkBoxPayed.Checked = false;

                string queryText = $"SELECT dbo.Booking.Booking_ID, dbo.Customer.Customer_FirstName, dbo.Customer.Customer_LastName, dbo.Booking.StartDate, dbo.Booking.EndDate, dbo.Quotationstatus.Status_Type FROM dbo.Booking INNER JOIN Quotation ON dbo.Booking.Quotation_ID = dbo.Quotation.Quotation_ID INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID AND Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.PaymentStatus = Quotationstatus.Status_ID WHERE (Quotation.PaymentStatus = 1)";
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                command = new SqlCommand(queryText, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Booking");
                dataGridViewBookings.DataSource = ds;
                dataGridViewBookings.DataMember = "Booking";
                con.Close();
            }

            if (chkBoxPayed.Checked)
            {

                chkBoxPending.Checked = false;

                string queryText = $"SELECT dbo.Booking.Booking_ID, dbo.Customer.Customer_FirstName, dbo.Customer.Customer_LastName, dbo.Booking.StartDate, dbo.Booking.EndDate, dbo.Quotationstatus.Status_Type FROM dbo.Booking INNER JOIN Quotation ON dbo.Booking.Quotation_ID = dbo.Quotation.Quotation_ID INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID AND Quotation.Customer_ID = Customer.Customer_ID INNER JOIN Quotationstatus ON Quotation.PaymentStatus = Quotationstatus.Status_ID WHERE (Quotation.PaymentStatus = 1)";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            populateDataGrid();
            chkBoxPayed.Checked = false;
            chkBoxPending.Checked = false;
            dateTimePickerStart.Enabled = true;
            dateTimePickerEnd.Enabled = true;

        }
    }
}
