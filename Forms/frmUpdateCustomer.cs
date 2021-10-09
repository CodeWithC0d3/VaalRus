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

        private void cbSearchCustNo_SelectedValueChanged(object sender, EventArgs e)
        {


        }
    }
}
