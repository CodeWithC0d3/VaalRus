using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vaalrusGUIPrototype.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace vaalrusGUIPrototype
{
    public partial class MainForm : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        //public string sqlCommand;
        //public string dataFDB;
        public string connString = Properties.Settings.Default.conString;

        Button currentButton;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainForm()
        {
            InitializeComponent();
            customDesign();
        }
        private void changeButtonBrightness(object btn)
        {
            Button cbtn = (Button)btn;
            Color vara1 = new Color();
            Color vara2 = new Color();
            Color varb1 = new Color();
            Color varb2 = new Color();
            vara1 = Color.FromArgb(91, 194, 214);
            vara2 = GlobalSettings.ChangeColorBrightness(Color.FromArgb(91, 194, 214), -0.2);
            varb1 = Color.FromArgb(3, 19, 70);
            varb2 = GlobalSettings.ChangeColorBrightness(Color.FromArgb(3, 19, 70), -0.2);
            Color col = cbtn.BackColor;

            if (currentButton == null)
            {
                if (col == vara1)
                    cbtn.BackColor = vara2;
                else if (col == vara2)
                    cbtn.BackColor = vara1;
                else if (col == varb1)
                    cbtn.BackColor = varb2;
                else if (col == varb2)
                    cbtn.BackColor = varb1;

                currentButton = cbtn;
            }
            else
            {
                if (currentButton.BackColor == vara1)
                    currentButton.BackColor = vara2;
                else if (currentButton.BackColor == vara2)
                    currentButton.BackColor = vara1;
                else if (currentButton.BackColor == varb2)
                    currentButton.BackColor = varb1;
                else if (currentButton.BackColor == varb2)
                    currentButton.BackColor = varb1;

                if (col == vara1)
                    cbtn.BackColor = vara2;
                else if (col == vara2)
                    cbtn.BackColor = vara1;
                else if (col == varb1)
                    cbtn.BackColor = varb2;
                else if (col == varb2)
                    cbtn.BackColor = varb1;
                currentButton = cbtn;
            }

        }
        private void customDesign()
        {
            panelSubMenuBooking.Visible = false;
            panelSubMenuCustomer.Visible = false;
            panelSubMenuAccommodation.Visible = false;
            panelSubReports.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuBooking.Visible == true)
            {
                panelSubMenuBooking.Visible = false;
            }
            if (panelSubMenuCustomer.Visible == true)
            {
                panelSubMenuCustomer.Visible = false;
            }
            if (panelSubMenuAccommodation.Visible == true)
            {
                panelSubMenuAccommodation.Visible = false;
            }
            if (panelSubReports.Visible == true)
            {
                panelSubReports.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuBooking);
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewBookings());
            lblHeading.Text = "View Booking";
            changeButtonBrightness(sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCustomer);
        }

        private void btnAccomodations_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAccommodation);          


        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNewBooking());
            lblHeading.Text = "Create Booking";
            changeButtonBrightness(sender);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCheckOut());
            lblHeading.Text = "Check - Out";
            changeButtonBrightness(sender);
        }
        public void dbRequired()
        {
            if (conDB())
            {
                btnAccomodations.Enabled = true;
                btnBookings.Enabled = true;
                btnCustomers.Enabled = true;
                btnQoutation.Enabled = true;
                btnReports.Enabled = true;

            }
            else
            {
                btnAccomodations.Enabled = false;
                btnBookings.Enabled = false;
                btnCustomers.Enabled = false;
                btnQoutation.Enabled = false;
                btnReports.Enabled = false;
                openChildForm(new frmSettings());
                hideSubMenu();
                lblHeading.Text = "Settings";
                //changeButtonBrightness(sender);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //pictureBoxMax.SizeMode = PictureBoxSizeMode.StretchImage;
            //Bitmap bt = Properties.Resources.expand2; 
           
            //pictureBoxMax.Image = bt;
            
            this.StartPosition = FormStartPosition.CenterScreen;
            Color color = Color.FromArgb(54, 77, 91);
            GlobalSettings.PrimaryColor = color;
            GlobalSettings.SecondaryColor = GlobalSettings.ChangeColorBrightness(color, -0.3);
            //GlobalSettings.thirdColor = GlobalSettings.ChangeColorBrightness(color, -0.9);
            //GlobalSettings.thirdColor = Color.FromArgb(236, 236, 225);
            GlobalSettings.thirdColor = GlobalSettings.ChangeColorBrightness(Color.FromArgb(236, 236, 225), -0.2);
            GlobalSettings.font = new Font("Microsoft Sans Serif", 10);
            dbRequired();
            removeOldQuotes();


           
        }

        

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateCustomer());
            lblHeading.Text = "Update a Customers information";
            changeButtonBrightness(sender);
        }

        private void btnUpdateAccommodation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateAccommodations());       
            lblHeading.Text = "Update Existing Accommodations";
            changeButtonBrightness(sender);
        }

        private void pictureBoxMainFormBackground_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            lblHeading.Text = "Vaalrus Recreational Resort";
            hideSubMenu();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAddCustomer());
            lblHeading.Text = "Add a new Customer";
            changeButtonBrightness(sender);
        }

        private void btnAddAccommodation_Click(object sender, EventArgs e)
        {

            openChildForm(new frmAddAccommodation());
            lblHeading.Text = "New Accommodation details";         
            changeButtonBrightness(sender);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDeleteCustomer());
            lblHeading.Text = "Delete Customer";
            changeButtonBrightness(sender);
        }

        private void btnDeleteAccommodation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDeleteAccommodation());
            lblHeading.Text = "Delete Accommodation";

            changeButtonBrightness(sender);
        }

        private void btnQoutation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuotation());
            lblHeading.Text = "Create Quotation";
            hideSubMenu();
            changeButtonBrightness(sender);
        }

        private void pnlLabelHeading_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCheckIn());
            lblHeading.Text = "Check - In";
            changeButtonBrightness(sender);
        }

        private void btnViewAccommodations_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewAccommodations());
            lblHeading.Text = "View Accommodations";
            changeButtonBrightness(sender);
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubReports);

            //openChildForm(new frmReport());
            //lblHeading.Text = "Reports";
            //hideSubMenu();
            //changeButtonBrightness(sender);
        }

        private void btnViewAccommodations_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmViewAccommodations());
            lblHeading.Text = "View Accommodation";
            //hideSubMenu();
            changeButtonBrightness(sender);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSettings());
            hideSubMenu();
            lblHeading.Text = "Settings";
            changeButtonBrightness(sender);   
        }

        private void btnTop10Accom_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReport());
            lblHeading.Text = "Reports";
            //hideSubMenu();
            changeButtonBrightness(sender);
        }

        private void btnBookingsPerPeriod_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReportBookings());
            lblHeading.Text = "Reports";
            //hideSubMenu();
            changeButtonBrightness(sender);
        }

        private void btnViewCustomers_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmViewCustomer());
            lblHeading.Text = "View Customers";
            changeButtonBrightness(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            //this.WindowState = FormWindowState.Maximized;
        }
        public void removeOldQuotes()
        {
            if (conDB())
            {
                try
                {
                    sqlConnection = new SqlConnection(connString);
                    if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();//UPDATE table1 SET table1.name = table2.nameFROM table1, table2WHERE table1.id = table2.idAND table2.foobar = 'stuff';
                    sqlCmd = new SqlCommand($"Update Quotation SET QuoteStatus = '" + 3 + "' where Reservation_Date < '" + DateTime.Today + "' OR QuoteCreated_DateTime < '" + DateTime.Today.AddDays(-3) + "' ", sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                    sqlConnection.Close();


                }
                catch (Exception sqlx)
                {
                    MessageBox.Show(sqlx.ToString());
                }
            }
            
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
        private void pictureBoxMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
