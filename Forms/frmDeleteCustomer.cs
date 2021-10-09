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

namespace vaalrusGUIPrototype
{
    public partial class frmDeleteCustomer : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;

        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;


        bool searchFlag = false;
        bool countFlag = false;

        bool overrideCheck = false;

        int qid;

        public frmDeleteCustomer()
        {
            InitializeComponent();

            populateDataGrid();

            txtCustNo.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;

            populateCombo("search");

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
            aplytheme(panel6);

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

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
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
        private void btnDelete_Click(object sender, EventArgs e)
        {

            string lastName = txtLastName.Text;
            string ID = txtCustNo.Text;

            if (!string.IsNullOrEmpty(lastName))
            {
                countFlag = true;
            }

            
                if (conDB() && overrideCheck)
                {
                    
                    //see if there is such an entry
                    string queryText = $"SELECT COUNT(Customer_LastName)  " +
                        $"FROM Customer WHERE Customer_LastName = '" + lastName + "'";

                    SqlCommand SQLQuery = new SqlCommand(queryText, con);

                    //read from db
                    Int32 entryCount = Convert.ToInt32(SQLQuery.ExecuteScalar()); // will return the number of vlaues 
                    SQLQuery.Dispose();
                    con.Close();




                //if bigger than 0 then there is a record
                if (entryCount > 0)
                {
                    //request user to confirm that they want to delete
                    DialogResult promptResult = MessageBox.Show("Are you sure you want to delete: \"" + lastName + "\" from the system", "Delete Customer", MessageBoxButtons.YesNoCancel);

                    //if confirmed to be deleted ru nthe next code
                    if (promptResult == DialogResult.Yes)
                    {

                        con.Open();

                        string deleteQuery = "DELETE FROM Customer WHERE Customer_ID = '" + ID + "'";

                        SqlCommand cmd = new SqlCommand(deleteQuery, con);

                        SqlDataAdapter myAdapter = new SqlDataAdapter();

                        myAdapter.DeleteCommand = cmd;

                        myAdapter.DeleteCommand.ExecuteNonQuery();

                        //output to user
                        lblOutput.Text = lastName + ", has been deleted!";
                    }
                }
                else 
                {
                    if (!countFlag)
                    {
                        lblOutput.Text = "You havent picked a customer to be deleted"; 
                        
                    }
                    else 
                    {
                        lblOutput.Text = lastName + ", does not exist in the system!";
                    }
                    
                }
                cbOverride.Checked = false;
                overrideCheck = false;

                /*


                string deleteQuery = "DELETE FROM Customer WHERE Customer_LastName = '" + lastName + "'";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);

                SqlDataAdapter myAdapter = new SqlDataAdapter();

                myAdapter.DeleteCommand = cmd;

                myAdapter.DeleteCommand.ExecuteNonQuery();

                var effectedRows = Convert.ToInt32(cmd.Parameters["@rowCount"].Value);

                if (effectedRows > 0)
                {
                    lblOutput.Text = " was deleted succesfully";
                }

                /*
                //query did not execute because no values matching
                if (cmd.ExecuteNonQuery() == 0)
                {
                    lblOutput.Text = "No matching records";
                }
                if (cmd.ExecuteNonQuery() > 0)
                {
                    lblOutput.Text =  lastName + " was deleted succesfully";
                }
                */

                con.Close();
                
            }


            
         }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            

            if (conDB())
            {

                //con.Open();
                
                string lastName = txtLastName.Text;

                string queryText = $"SELECT Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address " +
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

                searchFlag = true;
            }
            


        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

            if (conDB() && searchFlag)
            {

                //con.Open();

                string lastName = txtLastName.Text;

                string queryText = $"SELECT Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address " +
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
        }

       private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

                }

                //testc to see output
                //lblOutput.Text = searchCustNo.ToString();


                con.Close();

            }

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
            cbOverride.Checked = false;
            overrideCheck = false;
            //populateCombo("update");
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
            cbOverride.Checked = false;
            overrideCheck = false;
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
            cbOverride.Checked = false;
            overrideCheck = false;
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
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
            cbOverride.Checked = false;
            overrideCheck = false;
        }
    }
}