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
    public partial class frmCheckIn : Form
    {
       
        private SqlConnection sqlConnection;
        private SqlCommand sqlCmd;
        private string connString = Properties.Settings.Default.conString;

        public frmCheckIn()
        {
            InitializeComponent();
        }
        public void Display(string command)
        {
            //if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            if (conDB())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(command, sqlConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        DataSet ds = new DataSet();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds, "Accommodation");

                        dtgCheckIn.DataSource = ds;
                        dtgCheckIn.DataMember = "Accommodation";
                    }
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message.ToString());
                }
                sqlConnection.Close();
            }
            
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
                
                    btn.BackColor = GlobalSettings.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = GlobalSettings.font;
           
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 2;
                }
            }
     
            aplytheme(panel1);
            aplytheme(panel2);
            aplytheme(panel3);
            aplytheme(panel4);
            aplytheme(panel5);
            aplytheme(pnlCheckIn);
       
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
                    if (co.GetType() == typeof(RadioButton))
                    {
                        RadioButton rd = (RadioButton)co;
                        rd.ForeColor = Color.White;
                        rd.Font = GlobalSettings.font;

                    }
                }

            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Boolean conDB()
        {
            try
            {
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
            try
            {
                Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS[First Name], Customer.Customer_LastName AS[Last Name], Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM Customer INNER JOIN Booking ON Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Checkin_Time IS NULL");

            }
            catch (SqlException)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            

            tbBookID.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Chekin = DateTime.Now;
            if (conDB())
            {
                try
                {
                    sqlCmd = new SqlCommand($"Update Booking Set Checkin_Time ='" + Chekin + "'  where Booking_ID = " + Convert.ToInt32(tbBookID.Text) + "", sqlConnection);

                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Successfully Checked In");
                    //this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Select a booking to check in");
                    sqlConnection.Close();

                }
                
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
           
            }
            catch (SqlException)
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
                    Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS [First Name], Customer.Customer_LastName AS [Last Name],Customer.Customer_IDNumber AS [South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM  dbo.Booking INNER JOIN Customer ON Booking.Customer_ID = Customer.Customer_ID WHERE Customer.Customer_LastName='" + tbLastName.Text + "'");

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

        private void btnDisplayBook_Click(object sender, EventArgs e)
        {
            rbIDnum.Checked = false;
            rbLastName.Checked = false;
            tbIDNum.Text = "";
            tbLastName.Text = "";

            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection unsuccesful");
            }
             Display("SELECT Booking.Booking_ID AS[Booking Number], Customer.Customer_FirstName AS[First Name], Customer.Customer_LastName AS[Last Name], Customer.Customer_IDNumber AS[South African ID], Booking.StartDate AS [Arrival Date], Booking.EndDate AS [Departure Date], Booking.Checkin_Time AS [Check in Time], Booking.Checkin_Out AS [Checkout Time] FROM Customer INNER JOIN Booking ON Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Checkin_Time IS NULL");
        }

        private void rbLastName_CheckedChanged(object sender, EventArgs e)
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

        private void dtgCheckIn_SelectionChanged(object sender, EventArgs e)
        {
            tbBookID.Text = dtgCheckIn.CurrentRow.Cells[0].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
