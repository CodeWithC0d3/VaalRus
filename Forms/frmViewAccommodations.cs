using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace vaalrusGUIPrototype
{
    public partial class frmViewAccommodations : Form
    {
        public DataSet ds;
        public SqlDataAdapter myAdapter;

        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;
        public frmViewAccommodations()
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
                    adapter.Fill(ds, "Accommodation");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Accommodation";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }


        private void frmViewAccommodations_Load(object sender, EventArgs e)
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


            DateTime startDT = dpFrom.Value.Date;
            DateTime endDT = dpto.Value.Date;
            sql = "SELECT * FROM Accommodation";

            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            DataSet ds1 = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds1, "Accommodation_ID");

            sql = $"SELECT 	Accommodation_ID, AccommodationType FROM accAvailibility WHERE StartDate >= '{startDT.Date.ToString("yyyy/MM/dd")}' and EndDate <= '{endDT.Date.ToString("yyyy/MM/dd")}'";
            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Accommodation_ID");

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
            dataGridView1.DataMember = "Accommodation_ID";
            dataGridView1.DataSource = ds1;
            //cmbAccommodation.DataSource = ds1.Tables[0];
            con.Close();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            Display("Select * from Booking ");
            //readData("Select TOP 1 * from Accommodation");
            // dIndex = 1;
            // readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
            //loadTemp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAvailibleAcc();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             //string strDisplay = "Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
            try
            {
                sqlConnection = new SqlConnection(connString);
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand myComm = new SqlCommand("Select Accommodationset.Accommodation_ID as [CurrentBooked AID] from Booking INNER JOIN Accommodationset on Booking.Quotation_ID = Accommodationset.Quotation_ID where Accommodationset.Quotation_ID = Booking.Quotation_ID AND Booking.EndDate >= '"+DateTime.Today+"'", sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataSet ds = new DataSet();
                    adapter.SelectCommand = myComm;
                    adapter.Fill(ds, "AccommodationBooked");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "AccommodationBooked";
                }
                sqlConnection.Close();
            }
            catch(SqlException sqlx)
            {
                MessageBox.Show(sqlx.ToString());
            }
                /*int totalCounter = 0;
                sqlConnection = new SqlConnection(connString);
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using(SqlCommand myComm = new SqlCommand("Select * from Booking", sqlConnection))
                {
                    SqlDataReader dReader = myComm.ExecuteReader();

                    while(dReader.Read())
                    {
                        totalCounter++;
                    }
                    dReader.Close();
                    myComm.Dispose();
                }
                sqlConnection.Close();
                int[] qID = new int[totalCounter];
                int index = 0;
                sqlConnection = new SqlConnection(connString);
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand myComm = new SqlCommand("Select * from Booking", sqlConnection))
                {
                    SqlDataReader dReader = myComm.ExecuteReader();

                    while (dReader.Read())
                    {
                        qID[index] = (int)dReader.GetValue(0);
                    }
                    dReader.Close();
                    myComm.Dispose();
                }
                sqlConnection.Close();
                int bookedCounter = 0;
                sqlConnection = new SqlConnection(connString);
                for (int i = 0; i < qID.Length; i++)
                {
                    if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                    using (SqlCommand myComm = new SqlCommand("Select DISTINCT(QuotationID) from Accommodationset where QuotationID = '"+qID[i]+"'", sqlConnection))
                    {
                        SqlDataReader dReader = myComm.ExecuteReader();

                        while (dReader.Read())
                        {
                            bookedCounter++;
                        }
                        dReader.Close();
                        myComm.Dispose();
                    }
                    sqlConnection.Close();
                }
                int[] bookedAccomID = new int[bookedCounter];
                int counterx = 0;
                sqlConnection = new SqlConnection(connString);
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                for (int i = 0; i < qID.Length; i++)
                {
                    using (SqlCommand myComm = new SqlCommand("Select DISTINCT(Accommodation_ID) from Accommodationset where QuotationID = '" + qID[i] + "'", sqlConnection))
                    {
                        SqlDataReader dReader = myComm.ExecuteReader();

                        while (dReader.Read())
                        {
                            bookedAccomID[counterx] = (int)dReader.GetValue(0);
                        }
                        dReader.Close();
                        myComm.Dispose();
                    }
                }
                sqlConnection.Close();*/

            }
        
    }
}
