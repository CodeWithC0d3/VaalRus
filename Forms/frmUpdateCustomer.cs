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
    public partial class frmUpdateCustomer : Form
    {

        string constr = Properties.Settings.Default.conString;
        SqlConnection con;

        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;

        string firstName, lastName, idNo, contactNo, email, address;
        int qid;
        bool overrideCheck = false;

        bool errorFlagFirstName = false;
        bool errorFlagLastName = false;
        bool errorFlagID = false;
        bool errorFlagEmail = false;
        bool errorFlagContactNo = false;

        public frmUpdateCustomer()
        {
            InitializeComponent();

            populateCombo("search");

            //populateCombo("update");


            populateDataGrid();

            txtCustNo.Enabled = false;


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
            aplytheme(panel4);
            aplytheme(panel5);
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
        private void sizeGrid()
        {
            for (int i = 0; i < dgView.Columns.Count; i++)
            {
                dgView.Columns[i].MinimumWidth = 100;
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            populateDataGrid();

            eProviderFN.SetError(txtFirstName, "");
            eProviderLN.SetError(txtLastName, "");
            eProviderCN.SetError(txtID, "");
            eProviderCN.SetError(txtContact, "");
            eProviderEmail.SetError(txtEmail, "");

        }

        

        private void txtSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            if (conDB())
            {

                //con.Open();

                string firstName = txtSearchFirstName.Text;

                string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    $",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' " +
                    $"FROM Customer WHERE Customer_FirstName LIKE '%{firstName}%'";

                SqlCommand SQLQuery = new SqlCommand(queryText, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();


                adapter.SelectCommand = SQLQuery;
                adapter.Fill(ds, "Customer");


                //display in the datagrid
                dgView.DataSource = ds;
                dgView.DataMember = "Customer";

                con.Close();


            }

            //reset the textboxes sothat 



        }

        private void txtSearchLastName_TextChanged(object sender, EventArgs e)
        {
            if (conDB())
            {

                //con.Open();

                string lastName = txtSearchLastName.Text;

                string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    $",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' " +
                    $"FROM Customer WHERE Customer_LastName LIKE '%{lastName}%'";

                SqlCommand SQLQuery = new SqlCommand(queryText, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();


                adapter.SelectCommand = SQLQuery;
                adapter.Fill(ds, "Customer");


                //display in the datagrid
                dgView.DataSource = ds;
                dgView.DataMember = "Customer";

                con.Close();


            }
            resetTexboxes();
            populateCombo("update");
        }

        private void txtSearchID_TextChanged_1(object sender, EventArgs e)
        {
            if (conDB())
            {

                //con.Open();

                string IdNo = txtSearchID.Text;

                string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    $",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' " +
                    $"FROM Customer WHERE Customer_IDNumber LIKE '{IdNo}%'";

                SqlCommand SQLQuery = new SqlCommand(queryText, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();


                adapter.SelectCommand = SQLQuery;
                adapter.Fill(ds, "Customer");


                //display in the datagrid
                dgView.DataSource = ds;
                dgView.DataMember = "Customer";

                con.Close();


            }

            resetTexboxes();
            //populateCombo("update");


        }

        private void cbSearchCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {

                
                string searchCustNo = cbSearchCustNo.SelectedItem.ToString(); 

                lblOutput.Text = searchCustNo.ToString();

                if (conDB())
                {
               // string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    //$",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' FROM Customer";


                string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    $",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' " +
                    $"FROM Customer WHERE Customer_ID = '{searchCustNo}'";

                    SqlCommand SQLQuery = new SqlCommand(queryText, con);

                    adapter = new SqlDataAdapter();
                    ds = new DataSet();


                    command = new SqlCommand(queryText, con);

                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Customer");

                    dgView.DataSource = ds;
                    dgView.DataMember = "Customer";


                    con.Close();

                }
            resetTexboxes();
            //populateCombo("update");

        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {


            if (dgView.CurrentRow != null)
            {
                qid = int.Parse(dgView.CurrentRow.Cells[0].Value.ToString());

                //lblOutput.Text = qid.ToString();
                //fillInFormation();
            }


            //populate the textboxes

            populateTextBoxes(qid);

            //reset the overide checkbox
            cbOverride.Checked = false;
            overrideCheck = false;


        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void cbOverride_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOverride.Checked)
            {
                overrideCheck = true;
                //lblOutput.Text = "checked";
            }
            else 
            {
                overrideCheck = false;
                //lblOutput.Text = "unchecked";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string firstName = txtFirstName.Text;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            idNo = txtID.Text;
            contactNo = txtContact.Text;
            email = txtEmail.Text;
            address = txtAddress.Text;

            firstNameValidate(firstName);
            lastNameValidate(lastName);
            IDValidate(idNo);
            contactNoValidate(contactNo);
            emailValidate(email);








            //the custoemr number
            //string searchCustNo = cbCustNo.SelectedItem.ToString();
            string searchCustNo = txtCustNo.Text;

            if (!string.IsNullOrEmpty(searchCustNo))
            {
                int.Parse(searchCustNo);
            }


            if (conDB() && errorFlagFirstName && errorFlagLastName && errorFlagID && errorFlagEmail && errorFlagContactNo && overrideCheck)
            {
                DialogResult promptResult = MessageBox.Show("Are you sure you want to update: \"" + lastName + "\", Customer number: " + txtCustNo.Text + " on the system", "Update Customer", MessageBoxButtons.YesNoCancel);

                if (promptResult == DialogResult.Yes)
                {

                    //string queryText = $"UPDATE Customer SET Customer_FirstName = '" + firstName + "' WHERE Customer_ID = '" + searchCustNo + "'";
                    string queryText = $"UPDATE Customer " +
                    $"SET Customer_FirstName = '{firstName }', " +
                    $"Customer_LastName = '{lastName}', Customer_IDNumber = '{idNo}', Customer_Email = '{email}', Customer_Cell = '{contactNo}', Customer_Address = '{address}'" +
                    $"WHERE Customer_ID = '{searchCustNo}'";

                    SqlCommand SQLQuery = new SqlCommand(queryText, con);

                    SQLQuery.ExecuteNonQuery();

                    //testc to see output
                    //lblOutput.Text = searchCustNo.ToString();


                    con.Close();



                    resetTexboxes();

                    //populateDataGrid();
                }

            }
        }


        private void populateCombo(String whichComboBox)
        {

            
            if (whichComboBox == "search")
            {

                //populate the customer number drop down search box
                if (conDB() && string.IsNullOrEmpty(cbSearchCustNo.Text))
                {



                    SqlCommand SQLQuery = new SqlCommand(@"Select Distinct Customer_ID FROM Customer ORDER BY Customer_ID", con);
                    dataReader = SQLQuery.ExecuteReader();

                    //loop through the data
                    while (dataReader.Read())
                    {
                        //add to the combo box
                        cbSearchCustNo.Items.Add(dataReader.GetValue(0));

                    }

                    con.Close();

                }
            }

/*
            if (whichComboBox == "update")
            {

                //populate the customer number drop down search box
                if (conDB() && string.IsNullOrEmpty(cbCustNo.Text))
                {



                    SqlCommand SQLQuery2 = new SqlCommand(@"Select Distinct Customer_ID FROM Customer ORDER BY Customer_ID", con);
                    dataReader = SQLQuery2.ExecuteReader();

                    //loop through the data
                    while (dataReader.Read())
                    {
                        //add to the combo box
                        cbCustNo.Items.Add(dataReader.GetValue(0));

                    }

                    con.Close();

                }




            }
*/




        }



/*
will reset the update texboxes
*/
        private void resetTexboxes()
        {

            txtCustNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = ""; ;
            txtID.Text = ""; ;
            txtEmail.Text = ""; ;
            txtContact.Text = ""; ;
            txtAddress.Text = "";

            cbOverride.Checked = false;

        }

        private void populateDataGrid()
        {
            //populate the data grid
            if (conDB())
            {

                //string lastName = txtLastName.Text;

                string queryText = $"SELECT Customer_ID AS 'Customer Number',Customer_FirstName AS 'First name', Customer_LastName AS 'Last name'" +
                    $",Customer_IDNumber AS 'Identity Number', Customer_Email AS 'email', Customer_Cell AS 'Contact number', Customer_Address AS 'Address' FROM Customer";


                adapter = new SqlDataAdapter();
                ds = new DataSet();


                command = new SqlCommand(queryText, con);

                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer");

                dgView.DataSource = ds;
                dgView.DataMember = "Customer";


                con.Close();


            }
            sizeGrid();

        }

        private void populateTextBoxes(int id)
        {

            if (conDB())
            {


                string queryText = $"SELECT Customer_ID,Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address FROM Customer WHERE Customer_ID = '{id}'";


                SqlCommand SQLQuery = new SqlCommand(queryText, con);

                dataReader = SQLQuery.ExecuteReader();

                while (dataReader.Read())
                {
                    //cbCustNo.SelectedIndex = int.Parse(dataReader.GetValue(0).ToString());
                    txtCustNo.Text = dataReader.GetValue(0).ToString();
                    txtFirstName.Text = dataReader.GetValue(1).ToString();
                    txtLastName.Text = dataReader.GetValue(2).ToString();
                    txtID.Text = dataReader.GetValue(3).ToString();
                    txtEmail.Text = dataReader.GetValue(4).ToString();
                    txtContact.Text = dataReader.GetValue(5).ToString();
                    txtAddress.Text = dataReader.GetValue(6).ToString();

                }

                //testc to see output
                //lblOutput.Text = searchCustNo.ToString();


                con.Close();

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
                txtContact.Focus();
                eProviderCN.SetError(txtContact, "Customer Contact NUmber required");

                //set error flag
                errorFlagContactNo = false;
            }
            else
            {
                //set error flag
                errorFlagContactNo = true;
                eProviderCN.SetError(txtContact, "");

                if (contactNo.Length < 6) //check if longer than 5 characters
                {
                    //e.Cancel = true;
                    txtContact.Focus();
                    eProviderCN.SetError(txtContact, "Contact number must be atleast 6 digits");

                    //set error flag
                    errorFlagContactNo = false;
                }
                else
                {
                    //set error flag
                    errorFlagContactNo = true;
                    eProviderCN.SetError(txtContact, "");

                    if (!Regex.IsMatch(contactNo, regex)) //check that input is only numbers
                    {
                        //e.Cancel = true;
                        txtContact.Focus();
                        eProviderCN.SetError(txtContact, "Only numbers for contact numbers");

                        //set error flag
                        errorFlagContactNo = false;
                    }
                    else
                    {
                        //set error flag
                        errorFlagContactNo = true;
                        eProviderCN.SetError(txtContact, "");
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
