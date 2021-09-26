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
        private int customerID;
        private List<int> accList = new List<int>();
        private decimal totalPrice;
        private string createdDate;
        private String createdBy;
        private Boolean selectFirst = false;

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
            cmbFilter.SelectedIndex = -1;
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
            customerID = int.Parse(cmbCustomer.SelectedValue.ToString());
            
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
                sql = "SELECT 	Customer_ID,Customer_FirstName + ' - ' +  Customer_LastName As Contact FROM Customer";
                command = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Customer_ID");
                //adapter.Fill(ds, "CustomerID");
                cmbCustomer.DisplayMember = "Contact";
                cmbCustomer.ValueMember = "Customer_ID";
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
        private int getID(String col1,string table,string col2, string value )
        {
            int i = 0;
            if (conDB())
            {
                sql = $"select '{col1}' from '{table}' where '{col2}' = '{value}'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                i = (int)dataReader.GetValue(0);
                con.Close();

            }
            return i;

        }
        private void loadCmbAcc()
        {
            if (conDB())
            {
                if (cmbAccommodation.DataSource == null)
                {                   
                    cmbAccommodation.Items.Clear();
                }
                else
                {
                    cmbAccommodation.DataSource = null;
                    cmbAccommodation.Items.Clear();
                }
               
                DateTime startDT = dpFrom.Value;
                DateTime endDT = dpTo.Value;
                string typeValue = cmbFilter.SelectedItem.ToString();
                if (cmbFilter.SelectedIndex == 0)
                {
                    sql = $"SELECT Accommodation.Accommodation_ID, cast(Accommodation.Accommodation_ID as varchar) + '-' + Accommodationtype.AccommodationType As accmerge FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
                }
                else
                {
                    sql = $"SELECT Accommodation.Accommodation_ID, cast(Accommodation.Accommodation_ID as varchar) + '-' + Accommodationtype.AccommodationType As accmerge FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID WHERE (dbo.Accommodationtype.AccommodationType = '{typeValue}');";
                }                
 
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
              
                cmbAccommodation.DisplayMember = "accmerge";
                cmbAccommodation.ValueMember = "Accommodation_ID";
                cmbAccommodation.DataSource = ds1.Tables[0];
                cmbAccommodation.SelectedIndex = -1;

                //cmbAccommodation.DataSource = ds1.Tables[0];
                con.Close();

            }
        }

        private void cmbAccommodation_Enter(object sender, EventArgs e)
        {
            //loadCmbAcc();
        }

        private void cmbAccommodation_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView row = (DataRowView)cmbAccommodation.SelectedItem;
            if (cmbAccommodation.SelectedIndex != -1)
            {
                if (selectFirst)
                {
                    string s = row["accmerge"].ToString();
                    lstAccommodation.Items.Add(s);
                    //string substring = st.Substring(0,st.IndexOf(' '));
                    string t = cmbAccommodation.SelectedValue.ToString();
                    accList.Add(int.Parse(t));
                }
                else
                    selectFirst = true;
            }
            
               
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAccommodation.SelectedIndex = -1;
            selectFirst = false;
            loadCmbAcc();
            cmbAccommodation.Enabled = true;
            
            
        }

        private void btnGeneratQuote_Click(object sender, EventArgs e)
        {
            createdBy = txtUser.Text;
            createdDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string startDate = dpFrom.Value.ToString("yyyy/MM/dd");
            string endDate = dpTo.Value.ToString("yyyy/MM/dd");
            int days = (dpTo.Value.Date - dpFrom.Value.Date).Days;
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

        private void cmbAccommodation_DropDown(object sender, EventArgs e)
        {
            cmbAccommodation.SelectedIndex = -1;
        }

        private void cmbAccommodation_DropDownClosed(object sender, EventArgs e)
        {
           // cmbAccommodation.SelectedIndex = -1;
        }

        private void btnClearLst_Click(object sender, EventArgs e)
        {
            lstAccommodation.Items.Clear();
            cmbAccommodation.SelectedIndex = -1;
            //selectFirst = false;
        }
    }
}
