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
    public partial class frmQuotation : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql = "";

        public frmQuotation()
        {
            InitializeComponent();
        }
        
        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {
               
                    if (co.GetType() == typeof(Panel))
                    {
                        co.Parent = this;
                        co.BackColor = Color.Transparent;
                    }
                    if (co.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)co;
                        //lbl.Font = GlobalSettings.font;
                        lbl.Parent = this;
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.BackColor = Color.Transparent;

                    }            
            } 
            //pnlMain.BackColor = Color.Transparent;
           
           aplytheme(pnlMain);
           aplytheme(pnlBookingDetails);
           aplytheme(pnlavailibleAccommodation);
            //aplytheme(pnl_main);
            timer1.Start();
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
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.BackColor = Color.Transparent;

                    }
                    if (co.GetType() == typeof(DataGridView))
                    {
                        DataGridView dtgg = (DataGridView)co;
                        dtgg.ForeColor = Color.White;
                        dtgg.BackgroundColor = SystemColors.Control;
                        dtgg.DefaultCellStyle.BackColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.Font = new Font("Arial", float.Parse("10"), FontStyle.Regular);

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

        private void frmQuotation_Load(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            LoadTheme();
            loadCmbCustomers();
            loadcmbFilter();
            //timer1.Start();

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // pnlMain.Visible = true;
            pictureBox1.Visible = false;
           timer1.Stop();
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
        
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void cmbCustomer_Enter(object sender, EventArgs e)
        {
           
        }
        private void loadCmbCustomers()
        {
            if (conDB())
            {
                sql = "SELECT 	Customer_FirstName + ' - ' +  Customer_LastName As Contact FROM Customer";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Contact");
                cmbCustomer.DisplayMember = "Contact";
                cmbCustomer.DataSource = ds.Tables[0];
                con.Close();

            }
        }
        private void loadcmbFilter()
        {
            if (conDB())
            {
                sql = "select AccommodationType from Accommodationtype";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "AccommodationType");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbFilter.Items.Add(row.ItemArray[0]);
                }
               
                con.Close();

            }
        }
        private void loadCmbAcc()
        {
            if (conDB())
            {
                cmbAccommodation.Items.Clear();
                DateTime startDT = dpFrom.Value;
                DateTime endDT = dpTo.Value;
                sql = "SELECT Accommodation.Accommodation_ID, Accommodationtype.AccommodationType FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
                command = new SqlCommand(sql,con);
                adapter = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds1);

                sql = $"SELECT 	Accommodation_ID, AccommodationType FROM accAvailibility WHERE StartDate >= '{startDT.Date.ToString("yyyy/MM/dd")}' and EndDate <= '{endDT.Date.ToString("yyyy/MM/dd")}'";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                foreach (DataRow row1 in ds1.Tables[0].Rows) // save rows to array
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
                   // row1.AcceptChanges();
                }
                ds1.AcceptChanges();
               foreach(DataRow row in ds1.Tables[0].Rows)
                {
                    cmbAccommodation.Items.Add(row.ItemArray[0].ToString() + " - " + row.ItemArray[1].ToString());
                }
                //cmbAccommodation.DataSource = ds1.Tables[0];
                con.Close();

            }
        }

        private void cmbAccommodation_Enter(object sender, EventArgs e)
        {
            loadCmbAcc();
        }

        private void cmbAccommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAccommodation.Items.Add(cmbAccommodation.SelectedItem);
        }
    }
}
