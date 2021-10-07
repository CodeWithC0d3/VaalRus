using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vaalrusGUIPrototype.Forms;
using Microsoft.Data.ConnectionUI;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.IO;



namespace vaalrusGUIPrototype
{
    public partial class frmSettings : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql = "";
        public frmSettings()
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
                        pnl.Parent = picBackground;
                        pnl.BackColor = Color.Transparent;
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
            }
        }
        private Boolean conDB()
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                con.Close();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        private void CopyDB()
        {

        }
        private void checkDBfile()
        {
            string path = Application.StartupPath;
            string cstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $"{path}" + @"\_SQL\database\Vaalrus.mdf;Integrated Security=True;Connect Timeout=0; ";
            
            SqlConnection conn = new SqlConnection();          
            {
                try
                {
                    conn = new SqlConnection(cstr);
                    command = new SqlCommand("", conn);
                    command.CommandText = @"drop DATABASE Vaalrus;";

                    conn.Open();
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Dispose();
                    conn.Close();
                }
                catch (Exception)
                {
                    command.Dispose();
                    conn.Dispose();
                    conn.Close();
                    // throw;
                   
                }

            }
        }
        public bool IsFileLocked(string filename)
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                            File.Open(filename, FileMode.OpenOrCreate,
                            FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                Locked = true;
            }
            return Locked;
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
            txtConString.Text = Properties.Settings.Default.conString;
            if (Properties.Settings.Default.conString == "")
                CreateDBStuff();
            
        }
        private void CreateDBStuff()
        {
           
            //Boolean exist = false;
            string path = Application.StartupPath;
            string cstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $"{path}" + @"\data\Vaalrus.mdf;Integrated Security=True;Connect Timeout=0; ";
            //if (Properties.Settings.Default.conString == "")
            //{
                frmDBSetup frmdb = new frmDBSetup();
                frmdb.StartPosition = FormStartPosition.CenterParent;
                frmdb.ShowDialog();


                if (frmdb.localServer == 0)
                {
                    Properties.Settings.Default.conString = cstr;
                    Properties.Settings.Default.Save();
                    constr = Properties.Settings.Default.conString;
                    createLocalTable();
                }
                else if (frmdb.localServer == 1)
                {
                Properties.Settings.Default.conString = "";
                    buildDatabse();
                }
                else
                    MessageBox.Show("No db setup selected");
                

           // }
                txtConString.Text = Properties.Settings.Default.conString;

        }
        private void btnConString_Click(object sender, EventArgs e)
        {
            //buildDatabse();
            CreateDBStuff();
        }

        private void btnCreateDatabAse_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.conString = "";
            Properties.Settings.Default.Save();
            txtConString.Text = "";
        
        }
        private void buildDatabse()
        {
            if (Properties.Settings.Default.conString == "")
            {
                MessageBox.Show("You will now select your DATABASE Source and Server");
                DataConnectionDialog dc = new DataConnectionDialog();
                DataSource.AddStandardDataSources(dc);
                dc.Title = "DataBase Connection String";
                if (DataConnectionDialog.Show(dc) == DialogResult.OK)
                {
                    Properties.Settings.Default.conString = dc.DisplayConnectionString;
                }
                Properties.Settings.Default.Save();
                txtConString.Text = Properties.Settings.Default.conString;
                if (!Properties.Settings.Default.conString.Contains("Vaalrus"))
                {
                    MessageBox.Show("DataBase Vaalrus Will now be Created");
                    SqlConnection con = new SqlConnection(txtConString.Text);
                    con.Open();
                    Server server = new Server(new ServerConnection(con));
                    string str = "CREATE DATABASE Vaalrus;";
                    server.ConnectionContext.ExecuteNonQuery(str);
                    str = File.ReadAllText(@"_SQL\Script.txt");
                    server.ConnectionContext.ExecuteNonQuery(str);
                    con.Close();

                    string oldconstring = txtConString.Text;
                    string first = oldconstring.Substring(0, oldconstring.IndexOf(";"));
                    string second = ";Initial Catalog=Vaalrus";
                    string third = oldconstring.Substring(oldconstring.IndexOf(";"));
                    string necon = first + second + third;
                    Properties.Settings.Default.conString = necon;
                    Properties.Settings.Default.Save();
                    txtConString.Text = Properties.Settings.Default.conString;
                    MessageBox.Show("Vaalrus database is now created");
                }
            }
            else if(!Properties.Settings.Default.conString.Contains("Vaalrus"))
            {
                MessageBox.Show("Please Select a databse");
                DataConnectionDialog dc = new DataConnectionDialog();
                DataSource.AddStandardDataSources(dc);
                dc.Title = "DataBase Connection String";
                if (DataConnectionDialog.Show(dc) == DialogResult.OK)
                {
                    Properties.Settings.Default.conString = dc.DisplayConnectionString;
                }
                Properties.Settings.Default.Save();
                txtConString.Text = Properties.Settings.Default.conString;
            }
        }
        private void createLocalTable()
        {
            string str = File.ReadAllText(@"_SQL\ScriptLocal.txt");
          
            sql = str;
            MessageBox.Show("DataBase Vaalrus Will now be Created");
            con = new SqlConnection(constr);
            command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            txtConString.Text = Properties.Settings.Default.conString;
            MessageBox.Show("Local Vaalrus database is now created");         



        }
        private void loadTestData()
        {
            if (conDB())
            {
                SqlConnection.ClearPool(con);
                con = new SqlConnection(constr);
                con.Open();
                Server server = new Server(new ServerConnection(con));
                string str = File.ReadAllText(@"_SQL\InitialData.txt");
                server.ConnectionContext.ExecuteNonQuery(str);
                str = File.ReadAllText(@"_SQL\ViewsLocal.txt");
                server.ConnectionContext.ExecuteNonQuery(str);
                str = File.ReadAllText(@"_SQL\viewReportBookings.txt");
                server.ConnectionContext.ExecuteNonQuery(str);

                con.Close();
            }
            
        }
        private void btnTestData_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(txtConString.Text);
            con.Open();
            Server server = new Server(new ServerConnection(con));            
            string str = File.ReadAllText(@"_SQL\InitialData.txt");          
            server.ConnectionContext.ExecuteNonQuery(str);
            str = File.ReadAllText(@"_SQL\Views.txt");
            server.ConnectionContext.ExecuteNonQuery(str);

            con.Close();*/
            loadTestData();
        }
    }
}
