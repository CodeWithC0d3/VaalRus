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

        public frmUpdateCustomer()
        {
            InitializeComponent();

            //populate the customer number drop down search box
            if (conDB())
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

            //populate the customer number drop down search box
            if (conDB())
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

            //populate the data grid
            if (conDB())
            {

                //string lastName = txtLastName.Text;

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

            
        }

       

        
    }
}
