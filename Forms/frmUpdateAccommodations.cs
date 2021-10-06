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
        public string strDisplay2 = "Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID";

        public string strDisplay = "Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;";
        public frmUpdateAccommodations()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control co in this.Controls)
            {

                // if (co.GetType() == typeof(Panel))
                // {
                //    co.Parent = this;
                //    co.BackColor = Color.Transparent;
                // }
                if (co.GetType() == typeof(Label))
                {
                    Label lbl = (Label)co;
                    lbl.Font = GlobalSettings.font;
                    lbl.Font = new Font("Microsoft Sans Serif", 12);
                    lbl.Parent = this;
                    lbl.ForeColor = GlobalSettings.SecondaryColor;
                    lbl.BackColor = Color.Transparent;

                }
                /*if (co.GetType() == typeof(Button))
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
                }*/
            }
            

            aplytheme(pnlConnetionControls);
            aplytheme(pnlGroupBoxDetails);
            aplytheme(pnlGroupBoxSearch);
            aplytheme(pnlDatagrid);
            //aplytheme2(pnlLabelHeading);
            //aplytheme(pnl_device);
            //aplytheme(pnl_main);

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
                        dtgg.BackgroundColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.BackColor = GlobalSettings.PrimaryColor;
                        dtgg.DefaultCellStyle.Font = new Font("Arial", float.Parse("10"), FontStyle.Regular);
                        //dtgg.DefaultCellStyle.SelectionBackColor = GlobalSettings.PrimaryColor;


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
            tempType = comboBoxAType.Text;
            tempOccupants = txtAOccupants.Text;
            tempPrice = txtAPrice.Text;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAID.Text = tempID;
            comboBoxAType.SelectedItem = tempType;
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
            loadComboBox();
            Display(strDisplay);
            //Display("Select Accommodation_ID as [ID], Accommodation_TypeID as [Type], Number_Of_Occupants as [Occupants], Accommodation_Price as [Price], Active as [Active] from Accommodation");
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
        public string getTypeID(int id)
        {
            string retType = "";
            try
            {

                if(sqlConnection.State == ConnectionState.Closed)sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Select AccommodationType from Accommodationtype where Accommodation_TypeID='" + id + "'", sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        retType = dReader.GetValue(0).ToString();

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

            return retType;
        }
        public int getAccomType(string type)
        {
            int typeInt = 0;
            try
            {

                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Select Accommodation_TypeID from Accommodationtype where AccommodationType='" + type + "'", sqlConnection))
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
        public void readData(string readstring)
        {
            try
            {
                Boolean active = false;
                int typeID = 0;
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(readstring, sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        txtAID.Text = dReader.GetValue(1).ToString();
                        typeID = (int)dReader.GetValue(2);
                        
                        //txtAType.Text = dReader.GetValue(2).ToString();
                        txtAOccupants.Text = dReader.GetValue(3).ToString();
                        txtAPrice.Text = Convert.ToDecimal(String.Format("{0:0}", Convert.ToDecimal(dReader.GetValue(4).ToString()))).ToString();
                        active = (Boolean)dReader.GetValue(5);
                        if (active == true) checkBoxActive.Checked = true;
                        else checkBoxActive.Checked = false;
                    }

                    dReader.Close();
                    sqlCommand.Dispose();
                }

                sqlConnection.Close();
                //comboBoxAType.SelectedItem = getTypeID(typeID);
                comboBoxAType.SelectedItem = getTypeID(typeID);
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message.ToString());
            }
            loadTemp();
        }
        public void readData2(string readstring)
        {
            try
            {
                Boolean active = false;
                int typeID = 0;
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(readstring, sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        txtAID.Text = dReader.GetValue(0).ToString();
                        typeID = (int)dReader.GetValue(1);

                        //txtAType.Text = dReader.GetValue(2).ToString();
                        txtAOccupants.Text = dReader.GetValue(2).ToString();
                        txtAPrice.Text = Convert.ToDecimal(String.Format("{0:0}", Convert.ToDecimal(dReader.GetValue(3).ToString()))).ToString();
                        active = (Boolean)dReader.GetValue(4);
                        if (active == true) checkBoxActive.Checked = true;
                        else checkBoxActive.Checked = false;
                    }

                    dReader.Close();
                    sqlCommand.Dispose();
                }

                sqlConnection.Close();
                //txtAType.Text = getTypeID(typeID);
                comboBoxAType.SelectedItem = getTypeID(typeID);
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
                string search = txtSearchID.Text;
                txtSearchOccupants.Clear();
                txtsearchPrice.Clear();
                comboBoxSearchType.SelectedItem = "";
                Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodation.Accommodation_ID Like '%{search}%';");
                //Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID;");

            }
            else
                Display(strDisplay);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dIndex++;
            if (dataGridViewAccom.RowCount > dIndex)
            {
                
                readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");//'" + dIndex+"'");//'"+dIndex+"'");
                dataGridViewAccom.ClearSelection();
                dataGridViewAccom.Rows[dIndex-1].Selected = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(dIndex>1)
                dIndex--;
            readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
            dataGridViewAccom.ClearSelection();
            if(dIndex<1)
            dataGridViewAccom.Rows[dIndex].Selected = true;
            else { dataGridViewAccom.Rows[dIndex - 1].Selected = true; }
        }

        private void dataGridViewAccom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewAccom.CurrentCell.RowIndex;
            int columnindex = dataGridViewAccom.CurrentCell.ColumnIndex;

            string dindex2 = dataGridViewAccom.Rows[rowindex].Cells[0].Value.ToString();
            dIndex = e.RowIndex +1;
            int conv = Convert.ToInt32(dindex2);
            //dIndex = dataGridViewAccom.Rows;
            //dIndex = e.RowIndex;
            //int accommID = dataGridViewAccom.Rows.
            //readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
            readData2("Select * from Accommodation where Accommodation_ID = '"+conv+"'");
        }

        private void pnlGroupBoxSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (err == false)
            {
                string s = txtAID.Text;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update Accommodation ID: '" + s + "'?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int upID = Convert.ToInt32(txtAID.Text);
                        //int upType = Convert.ToInt32(txtAType.Text);
                        int upType = getAccomType(comboBoxAType.Text);
                        int upOcc = Convert.ToInt32(txtAOccupants.Text);
                        double upPrice = Convert.ToDouble(txtAPrice.Text);
                        Boolean active = false;
                        if (checkBoxActive.Checked) active = true;

                        sqlConnection = new SqlConnection(connString);
                        sqlConnection.Open();
                        sqlCmd = new SqlCommand($"Update Accommodation Set Accommodation_TypeID = '" + upType + "', Number_Of_Occupants = '" + upOcc + "', Accommodation_Price = '" + upPrice + "', Active ='"+active+"' where Accommodation_ID = '" + upID + "'", sqlConnection);

                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();

                        Display(strDisplay);
                        dIndex = 1;
                        readData("WITH myTableWithRows AS (SELECT(ROW_NUMBER() OVER(ORDER BY Accommodation.Accommodation_ID)) as row, *FROM Accommodation)SELECT* FROM myTableWithRows WHERE row = '" + dIndex + "'");
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
        public Boolean err = false;
        private void txtAID_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrWhiteSpace(txtAID.Text))
            {
                e.Cancel = true;
                txtAID.Focus();
                errorProviderID.SetError(txtAID, "ID can not be blank!");
                err = true;
            }
            else if(!int.TryParse(txtAID.Text, out parsedValue))
            {
                e.Cancel = true;
                txtAID.Focus();
                errorProviderID.SetError(txtAID, "Can not contain letters!");
                err = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderID.SetError(txtAID, "");
                err = false;
            }
        }

        /*private void txtAType_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrWhiteSpace(txtAType.Text))
            {
                e.Cancel = true;
                txtAType.Focus();
                errorProviderType.SetError(txtAType, "Type can not be blank!");
                err = true;
            }
            else if (!int.TryParse(txtAType.Text, out parsedValue))
            {
                e.Cancel = true;
                txtAType.Focus();
                errorProviderType.SetError(txtAType, "Can not contain letters!");
                err = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderType.SetError(txtAType, "");
                err = false;
            }
        }*/

        private void txtAOccupants_Validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrWhiteSpace(txtAOccupants.Text))
            {
                e.Cancel = true;
                //txtAType.Focus();
                comboBoxAType.Focus();
                errorProviderOccupants.SetError(txtAOccupants, "Occupants can not be blank!");
                err = true;
            }
            else if (!int.TryParse(txtAOccupants.Text, out parsedValue))
            {
                e.Cancel = true;
                //txtAType.Focus();
                comboBoxAType.Focus();
                errorProviderOccupants.SetError(txtAOccupants, "Can not contain letters!");
                err = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderOccupants.SetError(txtAOccupants, "");
                err = false;
            }
        }

        private void txtAPrice_Validating(object sender, CancelEventArgs e)
        {
            /*int parsedValue;
            if (string.IsNullOrWhiteSpace(txtAPrice.Text))
            {
                e.Cancel = true;
                txtAType.Focus();
                errorProviderPrice.SetError(txtAPrice, "Type can not be blank!");
                err = true;
            }
            else if (!int.TryParse(txtAPrice.Text, out parsedValue))
            {
                e.Cancel = true;
                txtAType.Focus();
                errorProviderPrice.SetError(txtAPrice, "Can not contain letters!");
                err = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderPrice.SetError(txtAPrice, "");
                err = false;
            }*/
        }

        private void dataGridViewAccom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadComboBox()
        {

            try
            {
                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("Select AccommodationType from Accommodationtype", sqlConnection))
                {

                    SqlDataReader dReader = sqlCommand.ExecuteReader();

                    while (dReader.Read())
                    {
                        comboBoxAType.Items.Add(dReader.GetValue(0).ToString());
                        comboBoxSearchType.Items.Add(dReader.GetValue(0).ToString());
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
        }
        private void comboBoxAType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int serOcc = 0;
            double serPrice = 0;
            int serType = 0;
            string searchType = "";
            Boolean active = true;
            if (comboBoxSearchType.Text.Length > 0)
            {
                //int serID = Convert.ToInt32(txtSearchID.Text);
                searchType = comboBoxSearchType.SelectedItem.ToString();
                //if (txtSearchType.Text.Length > 0) serType = Convert.ToInt32(txtSearchType.Text);
                if (txtSearchOccupants.Text.Length > 0) serOcc = Convert.ToInt32(txtSearchOccupants.Text);
                if (txtsearchPrice.Text.Length > 0) serPrice = Convert.ToDouble(txtsearchPrice.Text);
                if (checkBoxActive.Checked) active = true; else active = false;
                txtSearchID.Clear();
                if (txtSearchOccupants.Text.Length == 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodationtype.AccommodationType Like '%{searchType}%' ; ");

                //Display($"Select * from Accommodation where Number_Of_Occupants Like '%{serOcc}%'");
                else if (comboBoxSearchType.Text.Length > 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' AND Accommodationtype.AccommodationType Like '%{searchType}%' ;");
                else if (comboBoxSearchType.Text.Length == 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' AND Accommodation_Price Like '%{serPrice}%' ;");
                else if (comboBoxSearchType.Text.Length > 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%'AND Accommodationtype.AccommodationType Like '%{searchType}%' AND Accommodation_Price Like '%{serPrice}%' ;");
            }
            else
                Display(strDisplay);
        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            /*int serOcc = 0;
            double serPrice = 0;
            int serType = 0;
            if(txtSearchType.Text.Length >0)
            {
                //int serID = Convert.ToInt32(txtSearchID.Text);
                if(txtSearchType.Text.Length>0) serType = Convert.ToInt32(txtSearchType.Text);
                if(txtSearchOccupants.Text.Length >0) serOcc = Convert.ToInt32(txtSearchOccupants.Text);
                if (txtsearchPrice.Text.Length > 0) serPrice = Convert.ToDouble(txtsearchPrice.Text);
                txtSearchID.Clear();
                if(txtSearchOccupants.Text.Length == 0 && txtsearchPrice.Text.Length == 0)
                Display($"Select * from Accommodation where Accommodation_TypeID Like '%{serType}%'");
                else if(txtSearchOccupants.Text.Length > 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{serType}%' AND Number_Of_Occupants Like '%{serOcc}%'");
                else if (txtSearchOccupants.Text.Length == 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{serType}%' AND Accommodation_Price Like '%{serPrice}%'");
                else if (txtSearchOccupants.Text.Length > 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select * from Accommodation where Accommodation_TypeID Like '%{serType}%'AND Number_Of_Occupants Like '%{serOcc}%' AND Accommodation_Price Like '%{serPrice}%'");
            }
            else
                Display("Select * from Accommodation");*/
        }

        private void txtSearchOccupants_TextChanged(object sender, EventArgs e)
        {
            int serOcc = 0;
            double serPrice = 0;
            int serType = 0;
            Boolean active = true;
            string searchType = "";
            if (txtSearchOccupants.Text.Length > 0)
            {
                searchType = comboBoxSearchType.SelectedItem.ToString();
                //int serID = Convert.ToInt32(txtSearchID.Text);
                //if (comboBoxSearchType.Text.Length > 0) serType = Convert.ToInt32(txtSearchType.Text);
                if (txtSearchOccupants.Text.Length > 0) serOcc = Convert.ToInt32(txtSearchOccupants.Text);
                if (txtsearchPrice.Text.Length > 0) serPrice = Convert.ToDouble(txtsearchPrice.Text);
                if (checkBoxActive.Checked) active = true; else active = false;
                txtSearchID.Clear();
                if (comboBoxSearchType.Text.Length == 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' ; ");

                //Display($"Select * from Accommodation where Number_Of_Occupants Like '%{serOcc}%'");
                else if (comboBoxSearchType.Text.Length > 0 && txtsearchPrice.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' AND Accommodationtype.AccommodationType Like '%{searchType}%';");
                else if (comboBoxSearchType.Text.Length == 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' AND Accommodation_Price Like '%{serPrice}%' ;");
                else if (comboBoxSearchType.Text.Length > 0 && txtsearchPrice.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Number_Of_Occupants Like '%{serOcc}%' AND Accommodation_Price Like '%{serPrice}%' AND Accommodationtype.AccommodationType Like '%{searchType}%' ;");
            }
            else
                Display(strDisplay);
        }

        private void txtsearchPrice_TextChanged(object sender, EventArgs e)
        {
            int serOcc = 0;
            double serPrice = 0;
            int serType = 0;
            string searchType = "";
            if (txtsearchPrice.Text.Length > 0)
            {
                searchType = comboBoxSearchType.SelectedItem.ToString();
                //int serID = Convert.ToInt32(txtSearchID.Text);
                //if (txtSearchType.Text.Length > 0) serType = Convert.ToInt32(txtSearchType.Text);
                if (txtSearchOccupants.Text.Length > 0) serOcc = Convert.ToInt32(txtSearchOccupants.Text);
                if (txtsearchPrice.Text.Length > 0) serPrice = Convert.ToDouble(txtsearchPrice.Text);
                txtSearchID.Clear();
                if (comboBoxSearchType.Text.Length == 0 && txtSearchOccupants.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodation_Price Like '%{serPrice}%';");
                else if (comboBoxSearchType.Text.Length > 0 && txtSearchOccupants.Text.Length == 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodation_Price Like '%{serPrice}%' AND Accommodationtype.AccommodationType Like '%{searchType}%';");
                else if (comboBoxSearchType.Text.Length == 0 && txtSearchOccupants.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodation_Price Like '%{serPrice}%' AND Number_Of_Occupants Like '%{serOcc}%';");
                else if (comboBoxSearchType.Text.Length > 0 && txtSearchOccupants.Text.Length > 0)
                    Display($"Select Accommodation.Accommodation_ID as [ID], Accommodationtype.AccommodationType as [Type], Accommodation.Number_Of_Occupants as [Occupants], Accommodation.Accommodation_Price as [Price], Accommodation.Active as [Active] from Accommodation INNER JOIN Accommodationtype on Accommodation.Accommodation_TypeID = Accommodationtype.Accommodation_TypeID where Accommodation_Price Like '%{serPrice}%' AND Number_Of_Occupants Like '%{serOcc}%' AND Accommodationtype.AccommodationType Like '%{searchType}%';");
            }
            else
                Display(strDisplay);
        }
    }
}