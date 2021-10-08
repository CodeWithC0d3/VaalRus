using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vaalrusGUIPrototype.Forms
{
    public partial class frmViewBookings : Form
    {
        public DataSet ds;
        public SqlDataAdapter myAdapter;
        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;

        public frmViewBookings()
        {
            InitializeComponent();
        }
        public void Display(string command)
        {
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(command, sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Bookings");

                    dataGridViewBookings.DataSource = ds;
                    dataGridViewBookings.DataMember = "Bookings";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }
        private void frmViewBookings_Load(object sender, EventArgs e)
        {

        }

        private void loadAvailibleAcc()
        {
            string constr = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand command;
            SqlDataAdapter adapter;
            SqlDataReader dataReader;
            DataSet ds;
            string sql = "";


            DateTime startDT = dateTimePickerStart.Value.Date;
            DateTime endDT = dateTimePickerEnd.Value.Date;
            sql = "SELECT * FROM Bookings";

            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            DataSet ds1 = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds1, "Bookings");

            sql = $"SELECT 	Accommodation_ID, AccommodationType FROM accAvailibility WHERE StartDate >= '{startDT.Date.ToString("yyyy/MM/dd")}' and EndDate <= '{endDT.Date.ToString("yyyy/MM/dd")}'";
            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Bookings");

            foreach (DataRow row1 in ds1.Tables[0].Rows)
            {
                foreach (DataRow row2 in ds.Tables[0].Rows)
                {
                    string st1 = row1.ItemArray[0].ToString();
                    string st2 = row2.ItemArray[0].ToString();
                    if (row1.ItemArray[0].ToString() == row2.ItemArray[0].ToString())
                    {
                        row1.Delete();
                        break; // break inner loop
                    }
                }

            }
            ds1.AcceptChanges();
            dataGridViewBookings.DataMember = "Accommodation_ID";
            dataGridViewBookings.DataSource = ds1;
            //cmbAccommodation.DataSource = ds1.Tables[0];
            con.Close();
        }
    }
}
