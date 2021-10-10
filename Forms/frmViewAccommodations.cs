using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace vaalrusGUIPrototype
{
    public partial class frmViewAccommodations : Form
    {
        public DataSet ds;
        public SqlDataAdapter myAdapter;

        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;
        public frmViewAccommodations()
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

            aplytheme(pnlView);
            aplytheme(panel1);
            aplytheme(dtgViewAcc);
            //aplytheme(pnl_accSet);

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

                    dtgViewAcc.DataSource = ds;
                    dtgViewAcc.DataMember = "Accommodation";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }

        private void validateDPFrom()
        {
            if (dpFrom.Value > dpto.Value)
            {
                fromDateErrorProvider.SetError(dpFrom, "From Date can not be after To Date");
                button1.Enabled = false;
                button3.Enabled = false;
                btnBooked.Enabled = false;
                dpFrom.BackColor = Color.IndianRed;
            }
            else
            {
                fromDateErrorProvider.SetError(dpFrom, "");
                button1.Enabled = true;
                button3.Enabled = false;
                btnBooked.Enabled = false;
                dpFrom.BackColor = Color.White;
            }
        }
        private void frmViewAccommodations_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void loadAvailibleAcc()
        {
            string constr = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand command;
            SqlDataAdapter adapter;
          
            DataSet ds;
            string sql = "";
            
                
            DateTime startDT  = dpFrom.Value.Date;
            DateTime endDT = dpto.Value.Date;
            sql = "Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID";
             
            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            DataSet ds1 = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds1,"Accommodation_ID");

           sql = $"SELECT 	Accommodation_ID, AccommodationType FROM accAvailibility WHERE StartDate >= '{startDT.Date.ToString("yyyy/MM/dd")}' and EndDate <= '{endDT.Date.ToString("yyyy/MM/dd")}'";
            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds,"Accommodation_ID");

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
            dtgViewAcc.DataSource = null;
            dtgViewAcc.DataMember = "Accommodation_ID";
            dtgViewAcc.DataSource = ds1;
         
            con.Close();

            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            loadAvailibleAcc();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            Display("SELECT Accommodation.Accommodation_ID AS[Accommodation Number], Accommodationtype.AccommodationType AS Type, Accommodation.Number_Of_Occupants AS [Occupants Number], Accommodation.Accommodation_Price AS Price, Accommodation.Active AS Status FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID ");
        }

        private void button2_Click_1(object sender, EventArgs e)

        {
            DateTime startDT = dpFrom.Value.Date;
            DateTime endDT = dpto.Value.Date;

            try
            {
                sqlConnection = new SqlConnection(connString);
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand myComm = new SqlCommand("SELECT Accommodationset.Accommodation_ID AS[Accommodation Number], Accommodationtype.AccommodationType AS Type, Accommodation.Accommodation_Price AS Price, Booking.StartDate AS[Arrival Date],Booking.EndDate AS[Departure Date] FROM Booking INNER JOIN Accommodationset ON Booking.Quotation_ID = Accommodationset.Quotation_ID INNER JOIN Accommodation ON Accommodationset.Accommodation_ID = Accommodation.Accommodation_ID INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Booking.StartDate >= '" + startDT.Date.ToString("yyyy/MM/dd") + "'AND Booking.EndDate<='"+ endDT.Date.ToString("yyyy/MM/dd") + "' ", sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataSet ds = new DataSet();
                    adapter.SelectCommand = myComm;
                    adapter.Fill(ds, "AccommodationBooked");
                  
                    dtgViewAcc.DataSource = ds;
                    dtgViewAcc.DataMember = "AccommodationBooked";
                }
                sqlConnection.Close();
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show(sqlx.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            //dtgViewAcc.DataSource = null;
            validateDPFrom();
        }

        private void dpto_ValueChanged(object sender, EventArgs e)
        {
            // dtgViewAcc.DataSource = null;
            validateDPFrom();
        }

        private void pnlDate_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
