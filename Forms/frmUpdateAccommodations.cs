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

namespace vaalrusGUIPrototype
{
    public partial class frmUpdateAccommodations : Form
    {

        public DataSet ds;
        public SqlDataAdapter myAdapter;

        public SqlConnection sqlConnection;
        public SqlCommand sqlCmd;
        public string sqlCommand;
        public string dataFDB;
        public string connString = Properties.Settings.Default.conString;
        public int dIndex;
        public string tempID, tempType, tempOccupants, tempPrice;
        public frmUpdateAccommodations()
        {
            InitializeComponent();
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
                            pnl.Parent = picBackground;
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
                        lbl.Parent = picBackground;
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.BackColor = Color.Transparent;

                    }
                }

            }

            aplytheme(pnlConnetionControls);
            aplytheme(pnlGroupBoxDetails);
            aplytheme(pnlGroupBoxSearch);
            aplytheme(pnlDatagrid);
            //aplytheme2(pnlLabelHeading);
            //aplytheme(pnl_device);
            //aplytheme(pnl_main);

        }
        private void aplytheme(Control co)
        {
            if (co.GetType() == typeof(Panel))
            {
                foreach (Control btns in co.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
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
                foreach (Control lbls in co.Controls)
                {
                    if (lbls.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)lbls;
                        lbl.Font = GlobalSettings.font;
                        //lbl.Parent = picBackground;
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.BackColor = Color.Transparent;

                    }
                }
                foreach (Control dtg in co.Controls)
                {
                    if (dtg.GetType() == typeof(DataGridView))
                    {
                        DataGridView dtgg = (DataGridView)dtg;
                        dtgg.ForeColor = Color.White;
                        dtgg.BackgroundColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.BackColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.Font = new Font("Arial", float.Parse("10"), FontStyle.Regular);

                    }
                }
                foreach (Control chk in co.Controls)
                {
                    if (chk.GetType() == typeof(CheckBox))
                    {
                        CheckBox chkk = (CheckBox)chk;
                        chkk.ForeColor = GlobalSettings.SecondaryColor;

                    }
                }
                foreach (Control txt in co.Controls)
                {
                    if (txt.GetType() == typeof(TextBox))
                    {
                        TextBox txtC = (TextBox)txt;
                        txtC.ForeColor = GlobalSettings.SecondaryColor;

                    }
                }
                foreach (Control grb in co.Controls)
                {
                    if (grb.GetType() == typeof(GroupBox))
                    {
                        GroupBox txtC = (GroupBox)grb;
                        txtC.ForeColor = GlobalSettings.SecondaryColor;
                        txtC.Font = GlobalSettings.font;
                    }
                }
            }
        }
        private void aplytheme2(Control co)
        {
            if (co.GetType() == typeof(Panel))
            {

                foreach (Control btns in co.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
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
                foreach (Control lbls in co.Controls)
                {
                    if (lbls.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)lbls;
                        lbl.Font = GlobalSettings.font;
                        //lbl.Parent = picBackground;
                        //lbl.ForeColor = GlobalSettings.SecondaryColor;
                        //lbl.ForeColor = GlobalSettings.thirdColor;
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("Microsoft Sans Serif", 18);
                        lbl.BackColor = Color.Transparent;

                    }
                }
                foreach (Control dtg in co.Controls)
                {
                    if (dtg.GetType() == typeof(DataGridView))
                    {
                        DataGridView dtgg = (DataGridView)dtg;
                        dtgg.ForeColor = Color.White;
                        dtgg.BackgroundColor = SystemColors.Control;
                        dtgg.DefaultCellStyle.BackColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.Font = new Font("Arial", float.Parse("10"), FontStyle.Regular);

                    }
                }
                foreach (Control chk in co.Controls)
                {
                    if (chk.GetType() == typeof(CheckBox))
                    {
                        CheckBox chkk = (CheckBox)chk;
                        chkk.ForeColor = GlobalSettings.SecondaryColor;

                    }
                }
                foreach (Control txt in co.Controls)
                {
                    if (txt.GetType() == typeof(TextBox))
                    {
                        TextBox txtC = (TextBox)txt;
                        txtC.ForeColor = GlobalSettings.SecondaryColor;

                    }
                }
                foreach (Control grb in co.Controls)
                {
                    if (grb.GetType() == typeof(GroupBox))
                    {
                        GroupBox txtC = (GroupBox)grb;
                        txtC.ForeColor = GlobalSettings.thirdColor;
                        txtC.Font = GlobalSettings.font;
                    }
                }
                foreach (Control pnl in this.Controls)
                {
                    if (pnl.GetType() == typeof(Panel))
                    {
                        //pnl.Parent = picBackground;
                        pnl.BackColor = Color.FromArgb(3, 19, 70);

                    }
                }
            }
        }
        public void loadTemp()
        {
            tempID = txtAID.Text;
            tempType = txtAType.Text;
            tempOccupants = txtAOccupants.Text;
            tempPrice = txtAPrice.Text;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAID.Text = tempID;
            txtAType.Text = tempType;
            txtAOccupants.Text = tempOccupants;
            txtAPrice.Text = tempPrice;
        }

        private void frmUpdateAccommodations_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
            Display("Select * from Accommodation");
            //readData("Select TOP 1 * from Accommodation");
            dIndex = 1;
            readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
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

                    dataGridViewAccom.DataSource = ds;
                    dataGridViewAccom.DataMember = "Accommodation";
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            sqlConnection.Close();
        }
        public void readData(string readstring)
        {
            try
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(readstring, sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        txtAID.Text = dReader.GetValue(1).ToString();
                        txtAType.Text = dReader.GetValue(2).ToString();
                        txtAOccupants.Text = dReader.GetValue(3).ToString();
                        txtAPrice.Text = dReader.GetValue(4).ToString();
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
            loadTemp();
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchID.Text.Length > 0)
            {
                txtSearchOccupants.Clear();
                txtsearchPrice.Clear();
                txtSearchType.Clear();
                Display($"Select * from Accommodation where Accommodation_ID Like '%{txtSearchID.Text}%'");
            }
            else
                Display("Select * from Accommodation");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dIndex++;
            readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '"+dIndex+"'");//'" + dIndex+"'");//'"+dIndex+"'");
            dataGridViewAccom.ClearSelection();
            dataGridViewAccom.Rows[dIndex].Selected = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(dIndex>1)
                dIndex--;
            readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
            dataGridViewAccom.ClearSelection();
            dataGridViewAccom.Rows[dIndex].Selected = true;
        }

        private void dataGridViewAccom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dIndex = e.RowIndex +1;
            readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
        }

        private void pnlGroupBoxSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchType.Text.Length >0)
            {
                txtSearchID.Clear();
                if(txtSearchOccupants.Text.Length == 0 && txtsearchPrice.Text.Length == 0)
                Display($"Select * from Accommodation where Accommodation_TypeID Like '%{txtSearchType.Text}%'");
                else if(txtSearchOccupants.Text.Length > 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{txtSearchType.Text}%' AND Number_Of_Occupants Like '%{txtSearchOccupants.Text}%'");
                else if (txtSearchOccupants.Text.Length == 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{txtSearchType.Text}%' AND Accommodation_Price Like '%{txtsearchPrice.Text}%'");
                else if (txtSearchOccupants.Text.Length > 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{txtSearchType.Text}%'AND Number_Of_Occupants Like '%{txtSearchOccupants.Text}%' AND Accommodation_Price Like '%{txtsearchPrice.Text}%'");
            }
            else
                Display("Select * from Accommodation");
        }

        private void txtSearchOccupants_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchOccupants.Text.Length > 0)
            {
                txtSearchID.Clear();
                if (txtSearchType.Text.Length == 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select * from Accommodation where Number_Of_Occupants Like '%{txtSearchOccupants.Text}%'");
                else if (txtSearchType.Text.Length > 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select * from Accommodation where Number_Of_Occupants Like '%{txtSearchOccupants.Text}%' AND Accommodation_TypeID Like '%{txtSearchType.Text}%'");
                else if (txtSearchType.Text.Length == 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Number_Of_Occupants Like '%{txtSearchOccupants.Text}%' AND Accommodation_Price Like '%{txtsearchPrice.Text}%'");
                else if (txtSearchType.Text.Length > 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Number_Of_Occupants Like '%{txtSearchOccupants.Text}%'AND Accommodation_TypeID Like '%{txtSearchType.Text}%' AND Accommodation_Price Like '%{txtsearchPrice.Text}%'");
            }
            else
                Display("Select * from Accommodation");
        }

        private void txtsearchPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchPrice.Text.Length > 0)
            {
                txtSearchID.Clear();
                if (txtSearchType.Text.Length == 0 && txtSearchOccupants.Text.Length == 0)
                    Display($"Select * from Accommodation where Accommodation_Price Like '%{txtsearchPrice.Text}%'");
                else if (txtSearchType.Text.Length > 0 && txtSearchOccupants.Text.Length == 0)
                    Display($"Select * from Accommodation where Accommodation_Price Like '%{txtsearchPrice.Text}%' AND Accommodation_TypeID Like '%{txtSearchType.Text}%'");
                else if (txtSearchType.Text.Length == 0 && txtSearchOccupants.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_Price Like '%{txtsearchPrice.Text}%' AND Number_Of_Occupants Like '%{txtSearchOccupants.Text}%'");
                else if (txtSearchType.Text.Length > 0 && txtSearchOccupants.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_Price Like '%{txtsearchPrice.Text}%'AND Accommodation_TypeID Like '%{txtSearchType.Text}%' AND Number_Of_Occupants Like '%{txtSearchOccupants.Text}%'");
            }
            else
                Display("Select * from Accommodation");
        }
    }
}