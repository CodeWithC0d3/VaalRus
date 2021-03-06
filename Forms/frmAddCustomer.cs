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

        bool errorFlagFirstName = false;
        bool errorFlagLastName = false;
        bool errorFlagID = false;
        bool errorFlagEmail = false;
        bool errorFlagContactNo = false;

        bool IDUnique = false;
        bool emailUnique = false;


        //globals
        string firstName, lastName, idNo, contactNo, email, address1, address2, address3, addressConcact;

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
            aplytheme(panel2);
            aplytheme(panel3);
            //aplytheme(panel4);
            //aplytheme(panel5);
            //aplytheme(panel6);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtID.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
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
            //set
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            idNo = txtID.Text;
            contactNo = txtContactNumber.Text;
            email = txtEmail.Text;

            address1 = txtAddress1.Text;
            address2 = txtAddress2.Text;
            address3 = txtAddress3.Text;

            addressConcact = address1 + ", " + address2 + ", " + address3;

            firstNameValidate(firstName);
            lastNameValidate(lastName);
            IDValidate(idNo);
            contactNoValidate(contactNo);
            emailValidate(email);




            if (conDB() && errorFlagFirstName && errorFlagLastName && errorFlagID && errorFlagEmail && errorFlagContactNo)
            {


                //address can be null
                //string address = rtbAddress.Text;

                //con.Open();

                //check if id is unique


                conDB();
                //see if there is such an entry
                string queryText = $"SELECT COUNT(Customer_IDNumber)  " +
                    $"FROM Customer WHERE Customer_IDNumber = '" + idNo + "'";

                SqlCommand SQLQuery = new SqlCommand(queryText, con);

                //read from db
                Int32 IDCount = Convert.ToInt32(SQLQuery.ExecuteScalar()); // will return the number of vlaues 
                SQLQuery.Dispose();
                con.Close();


                
                //check if email is unique
                conDB();
                string queryText2 = $"SELECT COUNT(Customer_Email)  " +
                                        $"FROM Customer WHERE Customer_Email = '" + email + "'";

                SqlCommand SQLQuery2 = new SqlCommand(queryText2, con);

                //read from db
                Int32 emailCount = Convert.ToInt32(SQLQuery2.ExecuteScalar()); // will return the number of vlaues 
                SQLQuery2.Dispose();
                con.Close();
                


                //if not bigger than 0 then it is unique
                if (IDCount > 0)
                {
                    eProviderID.SetError(txtID, "ID alraedy in use");
                    IDUnique = false;

                }
                else 
                {
                    eProviderID.SetError(txtID, "");
                    IDUnique = true;
                }

                //if not bigger than 0 then it is unique
                if (emailCount > 0)
                {
                    eProviderID.SetError(txtEmail, "Email alraedy in use");
                    emailUnique = false;

                }
                else
                {
                    eProviderID.SetError(txtEmail, "");
                    emailUnique = true;
                }








                if (conDB() && IDUnique && emailUnique)
                { 

                    //create the query
                    string insertQuery = "INSERT INTO Customer(Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address) " +
                        "Values (@firstName, @lastName, @idNo,  @email, @contactNo, @addressConcact)";

                SqlCommand SQLQuery3 = new SqlCommand(insertQuery, con);

                //insert the data

                SQLQuery3.Parameters.AddWithValue("@firstName", firstName);
                SQLQuery3.Parameters.AddWithValue("@lastName", lastName);
                SQLQuery3.Parameters.AddWithValue("@idNo", idNo);
                SQLQuery3.Parameters.AddWithValue("@contactNo", contactNo);
                SQLQuery3.Parameters.AddWithValue("@email", email);
                SQLQuery3.Parameters.AddWithValue("@addressConcact", addressConcact);

                SQLQuery3.ExecuteNonQuery();

                con.Close();

                //message for success
                MessageBox.Show("Data successfully inserted");

                //reset texboxes
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtID.Text = "";
                txtContactNumber.Text = "";
                txtEmail.Text = "";
                txtAddress1.Text = "";
                txtAddress2.Text = "";
                txtAddress3.Text = "";
            }

            }

            }


        /*
         * * Validation errors
         */

        private void firstNameValidate(String firstName)
        {
            //check if empty
            if (string.IsNullOrEmpty(firstName))
            {
                // e.Cancel = true;
                txtFirstName.Focus();
                eProviderFN.SetError(txtFirstName, "Customer first name required");

                //set error flag
                errorFlagFirstName = false;
            }
            else
            {
                //set error flag
                errorFlagFirstName = true;
                eProviderFN.SetError(txtFirstName, "");

                if (firstName.Length < 2) //check if longer than 2 characters
                {
                    // e.Cancel = true;
                    txtFirstName.Focus();
                    eProviderFN.SetError(txtFirstName, "Customer first name must be longer than 2 characters");

                    //set error flag
                    errorFlagFirstName = false;

                }
                else
                {
                    //set error flag
                    errorFlagFirstName = true;
                    eProviderFN.SetError(txtFirstName, "");
                }
            }




        }


        private void lastNameValidate(String lastName)
        {
            //check if empty
            if (string.IsNullOrEmpty(lastName))
            {
                //e.Cancel = true;
                txtLastName.Focus();
                eProviderLN.SetError(txtLastName, "Customer last name required");

                //set error flag
                errorFlagLastName = false;
            }
            else
            {
                //set error flag
                errorFlagLastName = true;
                eProviderLN.SetError(txtLastName, "");

                if (lastName.Length < 2) //check if longer than 2 characters
                {
                    //e.Cancel = true;
                    txtLastName.Focus();
                    eProviderLN.SetError(txtLastName, "Customer last name must be longer than 2 characters");

                    //set error flag
                    errorFlagLastName = false;
                }
                else
                {
                    //set error flag
                    errorFlagLastName = true;
                    eProviderLN.SetError(txtLastName, "");
                }
            }




        }


        private void IDValidate(String idNo)
        {

            string regex = @"^[0-9]+$"; // regular expression for matching only numbers

            //check if empty
            if (string.IsNullOrEmpty(idNo))
            {
                //e.Cancel = true;
                txtID.Focus();
                eProviderID.SetError(txtID, "Customer ID number required");

                //set error flag
                errorFlagID = false;
            }
            else
            {
                //set error flag
                errorFlagID = true;
                eProviderID.SetError(txtID, "");

                if (idNo.Length != 13) //check if longer than 2 characters
                {
                    //e.Cancel = true;
                    txtID.Focus();
                    eProviderID.SetError(txtID, "An South African ID needs to be exactly 13 characters");

                    //set error flag
                    errorFlagID = false;
                }
                else
                {
                    //set error flag
                    errorFlagID = true;
                    eProviderID.SetError(txtID, "");

                    if (!Regex.IsMatch(idNo, regex)) //check that input is only numbers
                    {
                        //e.Cancel = true;
                        txtID.Focus();
                        eProviderCN.SetError(txtID, "Only numbers for Identity numbers");

                        //set error flag
                        errorFlagContactNo = false;
                    }
                    else
                    {
                        //set error flag
                        errorFlagContactNo = true;
                        eProviderCN.SetError(txtID, "");
                    }
                }
            }


        }


        private void contactNoValidate(String contactNo)
        {
            string regex = @"^[0-9]+$"; // regular expression for matching only numbers

            //check if empty
            if (string.IsNullOrEmpty(contactNo))
            {
                //e.Cancel = true;
                txtContactNumber.Focus();
                eProviderCN.SetError(txtContactNumber, "Customer Contact NUmber required");

                //set error flag
                errorFlagContactNo = false;
            }
            else
            {
                //set error flag
                errorFlagContactNo = true;
                eProviderCN.SetError(txtContactNumber, "");

                if (contactNo.Length < 6) //check if longer than 5 characters
                {
                    //e.Cancel = true;
                    txtContactNumber.Focus();
                    eProviderCN.SetError(txtContactNumber, "Contact number must be atleast 6 digits");

                    //set error flag
                    errorFlagContactNo = false;
                }
                else
                {
                    //set error flag
                    errorFlagContactNo = true;
                    eProviderCN.SetError(txtContactNumber, "");

                    if (!Regex.IsMatch(contactNo, regex)) //check that input is only numbers
                    {
                        //e.Cancel = true;
                        txtContactNumber.Focus();
                        eProviderCN.SetError(txtContactNumber, "Only numbers for contact numbers");

                        //set error flag
                        errorFlagContactNo = false;
                    }
                    else
                    {
                        //set error flag
                        errorFlagContactNo = true;
                        eProviderCN.SetError(txtContactNumber, "");
                    }
                }
            }

            




        }


        private void emailValidate(String email)
        {
            //regular expression for matching email valid characters
            string regex2 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            //check if empty
            if (string.IsNullOrEmpty(email))
            {
                //e.Cancel = true;
                txtEmail.Focus();
                eProviderEmail.SetError(txtEmail, "Email address required");

                //set error flag
                errorFlagEmail = false;
            }
            else
            {
                //set error flag
                errorFlagEmail = true;
                eProviderEmail.SetError(txtEmail, "");

                if (email.Length < 4) //check if longer than 4 characters
                {
                    //e.Cancel = true;
                    txtEmail.Focus();
                    eProviderEmail.SetError(txtEmail, "An email address must be atleast 3 characters long");

                    //set error flag
                    errorFlagEmail = false;
                }
                else
                {
                    //set error flag
                    errorFlagEmail = true;
                    eProviderEmail.SetError(txtEmail, "");

                    if (!Regex.IsMatch(email, regex2)) //check that input is only numbers
                    {
                        //e.Cancel = true;
                        txtEmail.Focus();
                        eProviderEmail.SetError(txtEmail, "Not a valid email address");

                        //set error flag
                        errorFlagEmail = false;
                    }
                    else
                    {
                        //set error flag
                        errorFlagEmail = true;
                        eProviderEmail.SetError(txtEmail, "");
                    }
                }
            }
            



        }


    }
}
