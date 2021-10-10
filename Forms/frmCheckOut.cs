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

namespace vaalrusGUIPrototype
{
    public partial class frmCheckOut : Form
    {
        public DataSet ds;
        public SqlDataAdapter myAdapter;

        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;

        public frmCheckOut()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {

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
           
            aplytheme(pnlCheckOut);
            aplytheme(pnlSearch);
            aplytheme(pnlDisplay);
            aplytheme(panel2);
            aplytheme(gbSearch);

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
                      
                        btn.BackColor = GlobalSettings.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.Font = GlobalSettings.font;
                     
                        btn.FlatAppearance.BorderColor = Color.White;
                        btn.FlatAppearance.BorderSize = 2;
                    }
                    if (co.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)co;
                        lbl.Font = GlobalSettings.font;
                    
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
        public void Display(string command)
        {
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(command, sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Accommodation");

                    dtgCheckOut.DataSource = ds;
                    dtgCheckOut.DataMember = "Accommodation";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Chekout = DateTime.Now;
            sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            sqlCmd = new SqlCommand($"Update Booking Set Checkin_Out ='" + Chekout + "'  where Booking_ID = " + Convert.ToInt32(tbBookID.Text) + "", sqlConnection);

            sqlCmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Successfully Checked Out");
            //this.Close();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            LoadTheme();

            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS[First Name], Customer.Customer_LastName AS[Last Name], Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM Customer INNER JOIN Booking ON Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Checkin_Out IS NULL");

        }


        private void btnDisplayBook_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS[First Name], Customer.Customer_LastName AS[Last Name], Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM Customer INNER JOIN Booking ON Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Checkin_Out IS NULL");
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            if (rbLastName.Checked == true)
            {

                if (string.IsNullOrEmpty(tbLastName.Text))
                {

                    // e.Cancel = true;
                    tbLastName.Focus();
                    epLastName.SetError(tbLastName, "Customer Last name required");


                }
                else
                {
                    Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name],Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM  dbo.Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID WHERE Customer.Customer_LastName='" + tbLastName.Text + "'");
                    
                }
            }

            else if (rbIDnum.Checked == true)

            {
                if (tbIDNum.Text.Length == 13)
                {

                    Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name],Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM  dbo.Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID WHERE Customer.Customer_IDNumber='" + tbIDNum.Text + "'");
                }
                else
                {
                    tbIDNum.Focus();
                    epIDNumber.SetError(tbIDNum, "Customer ID Number must 13 digits long ");
                }

            }
            else
            {
                MessageBox.Show("ENTER CUSTOMER LAST NAME OR ID NUMBER");
            }


        }

        private void dtgCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbIDnum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLastName.Checked)
            {
                tbIDNum.Text = "";
                epIDNumber.Clear();
            }
            else
                tbLastName.Text = "";
            epLastName.Clear();
        }

        private void dtgCheckOut_SelectionChanged_1(object sender, EventArgs e)
        {
            tbBookID.Text = dtgCheckOut.CurrentRow.Cells[0].Value.ToString();
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}

