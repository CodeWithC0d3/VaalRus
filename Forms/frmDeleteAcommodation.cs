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
    public partial class frmDeleteAccommodation : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        Boolean firstrun = true;
        int accid;

        public frmDeleteAccommodation()
        {
            InitializeComponent();

            populateDataGrid();
        }

        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {

                // if (co.GetType() == typeof(Panel))
                // {
                //    co.Parent = this;
                //   co.BackColor = Color.FromArgb(58, 93, 117);
                //}
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

            aplytheme(pnlDelete);
            aplytheme(pnlFilter);
            //aplytheme(panel3);
            aplytheme(pnlGrid);
            //aplytheme(panel5);
            //aplytheme(panel6);

            //aplytheme(pnl_accSet);
            //timer1.Start();
        }
        private void aplytheme(Control pn)
        {
            if (pn.GetType() == typeof(Panel))
            {
                pn.BackColor = Color.FromArgb(58, 93, 117);
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
                        dtgg.AllowUserToAddRows = false;
                        dtgg.AllowUserToDeleteRows = false;
                        dtgg.AllowUserToOrderColumns = false;
                        dtgg.AllowUserToResizeRows = false;
                        dtgg.AllowUserToResizeColumns = true;
                        dtgg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        dtgg.RowHeadersVisible = false;
                        dtgg.ColumnHeadersHeight = 4;
                        dtgg.EnableHeadersVisualStyles = false;


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
                        gpc.ForeColor = Color.White;
                        gpc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(ListBox))
                    {
                        ListBox lsc = (ListBox)co;
                        lsc.ForeColor = GlobalSettings.SecondaryColor;
                        lsc.Font = GlobalSettings.font;

                    }
                    if (co.GetType() == typeof(CheckBox))
                    {
                        CheckBox ch = (CheckBox)co;
                        ch.ForeColor = Color.White;
                        ch.Font = GlobalSettings.font;

                    }
                }

            }
        }
        private void sizeGrid()
        {
            for (int i = 0; i < dgView.Columns.Count; i++)
            {
                dgView.Columns[i].MinimumWidth = 100;
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
        private void populateDataGrid()
        {
            //populate the data grid
            if (conDB())
            {

                string queryText = $"SELECT Accommodation.Accommodation_ID, Accommodationtype.AccommodationType, Accommodation.Number_Of_Occupants FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID";

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                command = new SqlCommand(queryText, con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Accommodation_ID");
                dgView.DataSource = ds;
                dgView.DataMember = "Accommodation_ID";

                con.Close();
            }
            //sizeGrid();
        }
        private void fillcmbtype()
        {
            string queryText = "select AccommodationType from Accommodationtype";

            adapter = new SqlDataAdapter();
            ds = new DataSet();
            command = new SqlCommand(queryText, con);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Accommodation_ID");
            cmbType.DisplayMember = "AccommodationType";
            cmbType.ValueMember = "AccommodationType";
            cmbType.DataSource = ds.Tables[0];
            cmbType.SelectedIndex = -1;
        }

        private void frmDeleteAccommodation_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            fillcmbtype();
            populateDataGrid();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstrun && cmbType.SelectedItem != null)
            {
                if (conDB())
                {
                    string type = cmbType.SelectedValue.ToString();
                    string queryText = $"SELECT Accommodation.Accommodation_ID, Accommodationtype.AccommodationType, Accommodation.Number_Of_Occupants FROM Accommodation INNER JOIN Accommodationtype ON Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID WHERE (Accommodationtype.AccommodationType = @accid)";

                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    command = new SqlCommand(queryText, con);
                    command.Parameters.AddWithValue("@accid", type);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Accommodation_ID");
                    dgView.DataSource = ds;
                    dgView.DataMember = "Accommodation_ID";

                    con.Close();
                }
            }
            else
                firstrun = false;
            
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            accid = int.Parse(dgView.CurrentRow.Cells[0].Value.ToString());
            txtAccNr.Text = accid.ToString();
            txtType.Text = dgView.CurrentRow.Cells[1].Value.ToString();
            txtNrOcc.Text = dgView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDeleteAccomm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the accommodation from Vaalrus database", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Accommodation WHERE Accommodation_ID = @accid";
                if (conDB())
                {
                    command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@accid", accid);
                    command.ExecuteNonQuery();
                    populateDataGrid();
                }
            }
            
        }
    }
}