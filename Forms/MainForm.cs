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

namespace vaalrusGUIPrototype
{
    public partial class MainForm : Form
    {
        Button currentButton;
        public MainForm()
        {
            InitializeComponent();
            customDesign();
        }
        private void changeButtonBrightness(object btn)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(91, 194, 214);
                currentButton = (Button)btn;
                currentButton.BackColor = GlobalSettings.ChangeColorBrightness(Color.FromArgb(91, 194, 214), -0.2);
            }
            else
            {
                currentButton = (Button)btn;
                currentButton.BackColor = GlobalSettings.ChangeColorBrightness(Color.FromArgb(91, 194, 214), -0.2);
            }
        }
        private void customDesign()
        {
            panelSubMenuBooking.Visible = false;
            panelSubMenuCustomer.Visible = false;
            panelSubMenuAccommodation.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuBooking.Visible == true)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = Color.FromArgb(91, 194, 214);
                    currentButton = null;
                }                
                panelSubMenuBooking.Visible = false;
            }                
            if (panelSubMenuCustomer.Visible == true)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = Color.FromArgb(91, 194, 214);
                    currentButton = null;
                }                
                panelSubMenuCustomer.Visible = false;
            }               
            if (panelSubMenuAccommodation.Visible == true)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = Color.FromArgb(91, 194, 214);
                    currentButton = null;
                }                
                panelSubMenuAccommodation.Visible = false;
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
            //code
            openChildForm(new testTheme());
            hideSubMenu();
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
            //openChildForm(new Test());
            //hideSubMenu();
            changeButtonBrightness(sender);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            changeButtonBrightness(sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(54, 77, 91);
            GlobalSettings.PrimaryColor = color;
            GlobalSettings.SecondaryColor = GlobalSettings.ChangeColorBrightness(color, -0.3);
            //GlobalSettings.thirdColor = GlobalSettings.ChangeColorBrightness(color, -0.9);
            //GlobalSettings.thirdColor = Color.FromArgb(236, 236, 225);
            GlobalSettings.thirdColor = GlobalSettings.ChangeColorBrightness(Color.FromArgb(236, 236, 225), -0.2);
            GlobalSettings.font = new Font("Microsoft Sans Serif", 10);
    }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSettings());
            hideSubMenu();
            lblHeading.Text = "Settings";
            changeButtonBrightness(sender);

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
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
    }
}
