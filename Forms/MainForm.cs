using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaalrusGUIPrototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customDesign();
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
                panelSubMenuBooking.Visible = false;
            if (panelSubMenuCustomer.Visible == true)
                panelSubMenuCustomer.Visible = false;
            if (panelSubMenuAccommodation.Visible == true)
                panelSubMenuAccommodation.Visible = false;
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
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

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
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateAccommodation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpdateAccommodations());
            lblHeading.Text = "Update Existing Accommodations";
        }

        private void pictureBoxMainFormBackground_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            lblHeading.Text = "Vaalrus Recreational Resort";
        }
    }
}
