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

        public frmDeleteCustomer()
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

            //aplytheme(panel1);
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

            if (!string.IsNullOrEmpty(lastName))
            {
                countFlag = true;
            }

            
                if (conDB())
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

                        string deleteQuery = "DELETE FROM Customer WHERE Customer_LastName = '" + lastName + "'";

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
                    if (countFlag)
                    {
                        lblOutput.Text = lastName + ", does not exist in the system!";
                    }
                    else 
                    {
                        lblOutput.Text = "You havent picked a customer to be deleted";
                    }
                    
                }

                    
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
            if (conDB())
            {

                string lastName = txtLastName.Text;

                string queryText = $"SELECT Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address FROM Customer";

                
                adapter = new SqlDataAdapter();
                ds = new DataSet();


                command = new SqlCommand(queryText, con);

                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer");

                dgView.DataSource = ds;
                dgView.DataMember = "Customer";


                con.Close();

                searchFlag = true;

            }
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
    }
}