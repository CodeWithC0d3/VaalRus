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

        public frmUpdateCustomer()
        {
            InitializeComponent();

            populateCombo("search");

            populateCombo("update");


            populateDataGrid();



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
            /*
            if (conDB())
            {

                string lastName = txtLastName.Text;

                string queryText = $"SELECT * FROM Customer";


                adapter = new SqlDataAdapter();
                ds = new DataSet();


                command = new SqlCommand(queryText, con);

                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer");

                dgView.DataSource = ds;
                dgView.DataMember = "Customer";


                con.Close();


            }
            */
        }

        

        private void txtSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            if (conDB())
            {

                //con.Open();

                string firstName = txtSearchFirstName.Text;

                string queryText = $"SELECT * " +
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

                string queryText = $"SELECT * " +
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

                string queryText = $"SELECT * " +
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
            populateCombo("update");


        }

        private void cbSearchCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {

                
                string searchCustNo = cbSearchCustNo.SelectedItem.ToString(); 

                lblOutput.Text = searchCustNo.ToString();

                if (conDB())
                {
                    string queryText = $"SELECT * FROM Customer WHERE Customer_ID = '{searchCustNo}'";

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
            populateCombo("update");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;


            //the custoemr number
            string searchCustNo = cbCustNo.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(searchCustNo))
            {
                int.Parse(searchCustNo);
            }
            

            if (conDB())
            {
                //string queryText = $"UPDATE Customer SET Customer_FirstName = '" + firstName + "' WHERE Customer_ID = '" + searchCustNo + "'";
                string queryText = $"UPDATE Customer SET Customer_FirstName = '{firstName }' WHERE Customer_ID = '{searchCustNo}'";

                SqlCommand SQLQuery = new SqlCommand(queryText, con);

                SQLQuery.ExecuteNonQuery();

                //testc to see output
                //lblOutput.Text = searchCustNo.ToString();


                con.Close();

            }
        }


        private void cbCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text;


            //the custoemr number
            string searchCustNo = cbCustNo.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(searchCustNo))
            {
                int.Parse(searchCustNo);
            }


            if (conDB())
            {
                

                string queryText = $"SELECT Customer_FirstName, Customer_LastName, Customer_IDNumber, Customer_Email, Customer_Cell, Customer_Address FROM Customer WHERE Customer_ID = '{searchCustNo}'";
                
                
                SqlCommand SQLQuery = new SqlCommand(queryText, con);

                dataReader = SQLQuery.ExecuteReader();

                while (dataReader.Read())
                {
                   
                    txtFirstName.Text = dataReader.GetValue(0).ToString();
                    txtLastName.Text = dataReader.GetValue(1).ToString();
                    txtID.Text = dataReader.GetValue(2).ToString();
                    txtEmail.Text = dataReader.GetValue(3).ToString();
                    txtContact.Text = dataReader.GetValue(4).ToString();
                    txtAddress.Text = dataReader.GetValue(5).ToString();

                }

                //testc to see output
                //lblOutput.Text = searchCustNo.ToString();


                con.Close();

            }




        }




/*
 will populate the various combo boxes
 */
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





        }



/*
will reset the update texboxes
*/
        private void resetTexboxes()
        {


            txtFirstName.Text = "";
            txtLastName.Text = ""; ;
            txtID.Text = ""; ;
            txtEmail.Text = ""; ;
            txtContact.Text = ""; ;
            txtAddress.Text = "";



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


        }




    }
}
