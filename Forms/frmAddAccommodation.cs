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
        public string strDisplay = "Select Accommodation.Accommodation_ID as [ID],Accommodation.Common_Name as [Name], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
        public Boolean err = false;
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
                            //pnl.BackColor = Color.Transparent;
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
            //aplytheme(pnlDelete);
            //aplytheme(pnlDeleteDetails);
            aplytheme(pnlDGrid);

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
        //public int typeInt;
        public int getAccomType(string type)
        {
            int typeInt = 0;
            try
            {
                
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Select Accommodation_TypeID from Accommodationtype where AccommodationType='"+type+"'", sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        typeInt = Convert.ToInt32(dReader.GetValue(0));
                        
                    }

                    dReader.Close();
                    sqlCommand.Dispose();
                }

                sqlConnection.Close();
                return typeInt;
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
                return typeInt;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (err != true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to insert new accommodation?", "Add Accommodation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int tempNewID = 0;
                        //string tnt = cbAccomType.Text;
                        string tempNewType = cbAccomType.Text;//cbAccomType.SelectedValue.ToString();
                        sqlConnection = new SqlConnection(connString);
                        sqlConnection.Open();
                        using (SqlCommand sqlCmd = new SqlCommand("Select Accommodation_TypeID from Accommodationtype where AccommodationType = '" + tempNewType + "'", sqlConnection))
                        {
                            SqlDataReader dReader = sqlCmd.ExecuteReader();

                            while (dReader.Read())
                            {
                                tempNewID = (int)dReader.GetValue(0);
                            }
                        }
                        sqlConnection.Close();
                        if (tempNewID == 0)
                        {
                            //int type = getAccomType(cbAccomType.Text);
                            //if(cbAccomType.SelectedIndex==0)
                            sqlConnection = new SqlConnection(connString);
                            sqlConnection.Open();
                            sqlCmd = new SqlCommand($"Insert Into Accommodationtype (AccommodationType) Values (@type)", sqlConnection);
                            //sqlCmd.Parameters.AddWithValue("@typeID", cbAccomType.SelectedIndex + 1);
                            sqlCmd.Parameters.AddWithValue("@type", tempNewType);
                            //sqlCmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtAccomPrice.Text));
                            sqlCmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        //txtAID.Text = dReader.GetValue(1).ToString();

                        //if(cbAccomType.SelectedValue !=)
                        int type = getAccomType(cbAccomType.Text);
                        //if(cbAccomType.SelectedIndex==0)
                        sqlConnection = new SqlConnection(connString);
                        sqlConnection.Open();
                        sqlCmd = new SqlCommand($"Insert Into Accommodation (Common_Name,Accommodation_TypeID,Number_Of_Occupants,Accommodation_Price,Active) Values (@name,@type,@noo,@price,@act)", sqlConnection);
                        //sqlCmd.Parameters.AddWithValue("@id", cbAccomType.SelectedIndex + 1);
                        sqlCmd.Parameters.AddWithValue("@name", txtAccName.Text);
                        sqlCmd.Parameters.AddWithValue("@type", cbAccomType.SelectedIndex + 1);
                        sqlCmd.Parameters.AddWithValue("@noo", numOfOccupants.Value);
                        sqlCmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtAccomPrice.Text));
                        sqlCmd.Parameters.AddWithValue("@act", true);
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();

                        Display(strDisplay);
                        dataGridAccommodations.Rows[dataGridAccommodations.Rows.Count - 1].Cells[1].Selected = true;
                        dataGridAccommodations.ClearSelection();
                        int nRowIndex = dataGridAccommodations.Rows.Count - 1;

                        dataGridAccommodations.Rows[nRowIndex].Selected = true;
                        dataGridAccommodations.Rows[nRowIndex].Cells[0].Selected = true;
                        dataGridAccommodations.FirstDisplayedScrollingRowIndex = dataGridAccommodations.RowCount - 1;
                        MessageBox.Show("New Accommodation succesfully added to database");
                        //dIndex = 1;
                        //readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
                    }
                    catch (SqlException sqlx)
                    {
                        //Could not update
                        MessageBox.Show(sqlx.ToString());
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void frmAddAccommodation_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Connected to db");
                setType();
                Display(strDisplay);
                //cbAccomType.Items.Add("");
                //readData("Select TOP 1 * from Accommodation");
                dIndex = 1;
                sqlConnection.Close();
            }
            catch (SqlException sqlx)
            {
                MessageBox.Show("Connection unsuccesful");
            }
            
        }

        private void dataGridAccommodations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridAccommodations.CurrentCell.RowIndex;
            int columnindex = dataGridAccommodations.CurrentCell.ColumnIndex;

            string dindex2 = dataGridAccommodations.Rows[rowindex].Cells[columnindex].Value.ToString();
            //txtDelID.Text = dindex2;
        }
        /*public void clearDel()
        {
            txtDelID.Clear();
            txtDelType.Clear();
            txtDelNumO.Clear();
            txtDelPrice.Clear();

        }*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* string s = txtDelID.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete accommodation ID: '"+s+"'?", "Delete Accommodation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int delID = Convert.ToInt32(txtDelID.Text);
                    int type = getAccomType(cbAccomType.Text);
                    //if(cbAccomType.SelectedIndex==0)
                    sqlConnection = new SqlConnection(connString);
                    sqlConnection.Open();
                    sqlCmd = new SqlCommand($"Delete from Accommodation where Accommodation_ID = '"+delID+"'", sqlConnection);
                    
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();

                    Display("Select * from Accommodation");
                    clearDel();
                    
                }
                catch (SqlException sqlx)
                {
                    //Could not update
                    MessageBox.Show(sqlx.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }*/
        }

        private void numOfOccupants_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtAccomPrice_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void cbAccomType_Validating(object sender, CancelEventArgs e)
        {
           /* //int parsedValue;
            if (string.IsNullOrWhiteSpace(cbAccomType.Text))
            {
                e.Cancel = true;
                cbAccomType.Focus();
                err = true;
                errorProviderPrice.SetError(cbAccomType, "Type can not be blank!");
                
            }
            //else if (!int.TryParse(cbAccomType.Text, out parsedValue))
            //{
            //    e.Cancel = true;
            //    cbAccomType.Focus();
            //    errorProviderPrice.SetError(cbAccomType, "Can not contain letters!");
            //    err = true;
            //}
            else
            {
                e.Cancel = false;
                err = false;
                errorProviderPrice.SetError(cbAccomType, "");
                
            }*/
        }

        private void cbAccomType_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAccomType.Text))
            {
                //e.Cancel = true;
                cbAccomType.Focus();
                err = true;
                errorProviderPrice.SetError(cbAccomType, "Type can not be blank!");

            }
            //else if (!int.TryParse(cbAccomType.Text, out parsedValue))
            //{
            //    e.Cancel = true;
            //    cbAccomType.Focus();
            //    errorProviderPrice.SetError(cbAccomType, "Can not contain letters!");
            //    err = true;
            //}
            else
            {
               //e.Cancel = false;
                err = false;
                errorProviderPrice.SetError(cbAccomType, "");

            }
        }

        private void numOfOccupants_Validated(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrWhiteSpace(numOfOccupants.Text))
            {
                //e.Cancel = true;
                //txtAType.Focus();
                numOfOccupants.Focus();
                err = true;
                errorProviderOccupants.SetError(numOfOccupants, "Occupants can not be blank!");

            }
            else if (int.TryParse(numOfOccupants.Text, out parsedValue))
            {
                if (parsedValue == 0)
                {
                    //e.Cancel = true;
                    numOfOccupants.Focus();
                    err = true;
                    errorProviderOccupants.SetError(numOfOccupants, "Occupants can not be 0");
                }

            }
            else if (!int.TryParse(numOfOccupants.Text, out parsedValue))
            {
                //e.Cancel = true;
                //txtAType.Focus();
                numOfOccupants.Focus();
                err = true;
                errorProviderOccupants.SetError(numOfOccupants, "Can not contain letters!");

            }
            else
            {
                //e.Cancel = false;
                err = false;
                errorProviderOccupants.SetError(numOfOccupants, "");

            }
        }

        private void txtAccomPrice_Validated(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrWhiteSpace(txtAccomPrice.Text))
            {
                //e.Cancel = true;
                txtAccomPrice.Focus();
                err = true;
                errorProviderPrice.SetError(txtAccomPrice, "Price can not be blank!");

            }
            else if (!int.TryParse(txtAccomPrice.Text, out parsedValue))
            {
                //e.Cancel = true;
                txtAccomPrice.Focus();
                err = true;
                errorProviderPrice.SetError(txtAccomPrice, "Can not contain letters!");

            }
            else
            {
                //.Cancel = false;
                err = false;
                errorProviderPrice.SetError(txtAccomPrice, "");

            }
        }
    }
}
