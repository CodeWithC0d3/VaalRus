using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQL
using System.Data.SqlClient;
//RGX
using System.Text.RegularExpressions;

namespace vaalrusGUIPrototype.Forms
{



    public partial class frmAddCustomer : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;


        //globals
        string firstName, lastName, idNo, contactNo, email, address;

        public frmAddCustomer()
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

            aplytheme(panel1);
            //aplytheme(panel2);
            //aplytheme(pn_grid);
            //aplytheme(pnl_accSet);
            //timer1.Start();
        }



        private void aplytheme(Control pn)
        {
            if (pn.GetType() == typeof(Panel))
            {
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

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (conDB())
            {
                /*
                    //get
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string idNo = txtID.Text;
                    string contactNo = txtContactNumber.Text;
                    string email = txtEmail.Text;
                    s
                */

                //address can be null
                string address = rtbAddress.Text;

                //con.Open();

                //create the query
                string insertQuery = "INSERT INTO Customer(Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address) " +
                    "Values (@firstName, @lastName, @idNo,  @email, @contactNo, @address)";

                SqlCommand SQLQuery = new SqlCommand(insertQuery, con);

                //insert the data

                SQLQuery.Parameters.AddWithValue("@firstName", firstName);
                SQLQuery.Parameters.AddWithValue("@lastName", lastName);
                SQLQuery.Parameters.AddWithValue("@idNo", idNo);
                SQLQuery.Parameters.AddWithValue("@contactNo", contactNo);
                SQLQuery.Parameters.AddWithValue("@email", email);
                SQLQuery.Parameters.AddWithValue("@address", address);

                SQLQuery.ExecuteNonQuery();

                con.Close();

                //message for success
                MessageBox.Show("Data successfully inserted");


            }

        }

        /**
         *  Validation checking
         */
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            //set
            firstName = txtFirstName.Text;

            //check if empty
            if (string.IsNullOrEmpty(firstName))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                eProviderFN.SetError(txtFirstName, "Customer first name required");
            }
            else if (firstName.Length < 2) //check if longer than 2 characters
            {
                e.Cancel = true;
                txtFirstName.Focus();
                eProviderFN.SetError(txtFirstName, "Customer first name must be longer than 2 characters");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            //set
            lastName = txtLastName.Text;

            //check if empty
            if (string.IsNullOrEmpty(lastName))
            {
                e.Cancel = true;
                txtLastName.Focus();
                eProviderLN.SetError(txtLastName, "Customer last name required");
            }
            else if (lastName.Length < 2) //check if longer than 2 characters
            {
                e.Cancel = true;
                txtLastName.Focus();
                eProviderLN.SetError(txtLastName, "Customer last name must be longer than 2 characters");
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            idNo = txtID.Text;

            //check if empty
            if (string.IsNullOrEmpty(idNo))
            {
                e.Cancel = true;
                txtID.Focus();
                eProviderID.SetError(txtID, "Customer ID number required");
            }
            else if (idNo.Length != 13) //check if longer than 2 characters
            {
                e.Cancel = true;
                txtID.Focus();
                eProviderID.SetError(txtID, "An South African ID needs to be exactly 13 characters");
            }
        }

        private void txtContactNumber_Validating(object sender, CancelEventArgs e)
        {
            contactNo = txtContactNumber.Text;

            string regex = @"^[0-9]+$"; // regular expression for matching only numbers

            //check if empty
            if (string.IsNullOrEmpty(contactNo))
            {
                e.Cancel = true;
                txtContactNumber.Focus();
                eProviderCN.SetError(txtContactNumber, "Customer Contact NUmber required");
            }
            else if (contactNo.Length < 6) //check if longer than 5 characters
            {
                e.Cancel = true;
                txtContactNumber.Focus();
                eProviderCN.SetError(txtContactNumber, "Contact number must be atleast 6 digits");
            }
            else if (!Regex.IsMatch(contactNo, regex)) //check that input is only numbers
            {
                e.Cancel = true;
                txtContactNumber.Focus();
                eProviderCN.SetError(txtContactNumber, "Only numbers for contact numbers");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            email = txtEmail.Text;

            //regular expression for matching email valid characters
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            //check if empty
            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                txtEmail.Focus();
                eProviderEmail.SetError(txtEmail, "Email address required");
            }
            else if (email.Length < 4) //check if longer than 4 characters
            {
                e.Cancel = true;
                txtEmail.Focus();
                eProviderEmail.SetError(txtEmail, "An email address must be atleast 3 characters long");
            }

            else if (!Regex.IsMatch(email, regex)) //check that input is only numbers
            {
                e.Cancel = true;
                txtEmail.Focus();
                eProviderEmail.SetError(txtEmail, "Not a valid email address");
            }
        }
        /** END Validation Checking**/

    }
}
