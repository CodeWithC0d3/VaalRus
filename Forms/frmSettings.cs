using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.IO;



namespace vaalrusGUIPrototype
{
    public partial class frmSettings : Form
    {
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

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
            txtConString.Text = Properties.Settings.Default.conString;
            
        }

        private void btnConString_Click(object sender, EventArgs e)
        {
            buildDatabse();
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

        private void btnTestData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(txtConString.Text);
            con.Open();
            Server server = new Server(new ServerConnection(con));            
            string str = File.ReadAllText(@"_SQL\InitialData.txt");          
            server.ConnectionContext.ExecuteNonQuery(str);
            str = File.ReadAllText(@"_SQL\Views.txt");
            server.ConnectionContext.ExecuteNonQuery(str);

            con.Close();
        }
    }
}
