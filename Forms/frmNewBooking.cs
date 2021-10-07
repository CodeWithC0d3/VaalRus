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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace vaalrusGUIPrototype.Forms
{
    public partial class frmNewBooking : Form
    {
        string constr = Properties.Settings.Default.conString;
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql = "";

        /*private ErrorProvider userErrorProvider;
        private ErrorProvider customerErrorProvider;
        private ErrorProvider fromDateErrorProvider;
        private ErrorProvider toDateErrorProvider;
        private ErrorProvider typeErrorProvider;
        private ErrorProvider accListErrorProvider;*/
        public frmNewBooking()
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

            aplytheme(pnlMain);
            aplytheme(pnlFilter);
            aplytheme(pnlGrid);
            aplytheme(pnlBookDetail);
            aplytheme(pnlButtons);
            aplytheme(pnlCusInformation);
            aplytheme(pnlPayment);

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
        private void frmNewBooking_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void createErProviders()
        {
            /*userErrorProvider = new ErrorProvider();

            userErrorProvider.SetIconAlignment(txtUser, ErrorIconAlignment.MiddleRight);
            userErrorProvider.SetIconPadding(txtUser, 2);
            userErrorProvider.BlinkRate = 1000;
            userErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            customerErrorProvider = new ErrorProvider();
            customerErrorProvider.SetIconAlignment(cmbCustomer, ErrorIconAlignment.MiddleRight);
            customerErrorProvider.SetIconPadding(cmbCustomer, 2);
            customerErrorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            fromDateErrorProvider = new ErrorProvider();
            fromDateErrorProvider.SetIconAlignment(dpFrom, ErrorIconAlignment.MiddleRight);
            fromDateErrorProvider.SetIconPadding(dpFrom, 2);
            fromDateErrorProvider.BlinkRate = 1000;
            fromDateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            toDateErrorProvider = new ErrorProvider();
            toDateErrorProvider.SetIconAlignment(dpTo, ErrorIconAlignment.MiddleRight);
            toDateErrorProvider.SetIconPadding(dpTo, 2);
            toDateErrorProvider.BlinkRate = 1000;
            toDateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            typeErrorProvider = new ErrorProvider();
            typeErrorProvider.SetIconAlignment(cmbFilter, ErrorIconAlignment.MiddleRight);
            typeErrorProvider.SetIconPadding(cmbFilter, 2);
            typeErrorProvider.BlinkRate = 1000;
            typeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            accListErrorProvider = new ErrorProvider();
            accListErrorProvider.SetIconAlignment(lstAccommodation, ErrorIconAlignment.MiddleRight);
            accListErrorProvider.SetIconPadding(lstAccommodation, 2);
            accListErrorProvider.BlinkRate = 1000;
            accListErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;*/

        }

        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
