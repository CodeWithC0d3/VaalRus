using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaalrusGUIPrototype.Forms
{
    public partial class frmAddAccommodation : Form
    {
        public DataSet ds;
        public SqlDataAdapter myAdapter;

        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;
        public int dIndex;
        public frmAddAccommodation()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                foreach (Control pnl in this.Controls)
                {
                    if (pnl.GetType() == typeof(Panel))
                    {
                        if (pnl.Name != "pnlLabelHeading")
                        {
                            pnl.Parent = pictureBoxViewAllBookingsBackground;
                            pnl.BackColor = Color.Transparent;
                        }
                    }
                }
                foreach (Control lbls in this.Controls)
                {
                    if (lbls.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)lbls;
                        //lbl.Font = GlobalSettings.font;
                        lbl.Parent = pictureBoxViewAllBookingsBackground;
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.BackColor = Color.Transparent;

                    }
                }

            }

            aplytheme(pnlNewAccom);
            aplytheme(pnlNewAccomDetails);
            aplytheme(pnlDelete);
            aplytheme(pnlDeleteDetails);
            aplytheme(pnlDGrid);

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
        public void setType()
        {
            try
            {
                if(sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Select AccommodationType from Accommodationtype", sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        cbAccomType.Items.Add(dReader.GetValue(0).ToString());
                    }

                    dReader.Close();
                    sqlCommand.Dispose();
                }

                sqlConnection.Close();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            //loadTemp();
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

                    dataGridAccommodations.DataSource = ds;
                    dataGridAccommodations.DataMember = "Accommodation";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void frmAddAccommodation_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
                setType();
                Display("Select * from Accommodation");
                cbAccomType.Items.Add("");
                //readData("Select TOP 1 * from Accommodation");
                dIndex = 1;
                sqlConnection.Close();
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            
        }
    }
}
