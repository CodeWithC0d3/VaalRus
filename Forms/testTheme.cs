using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vaalrusGUIPrototype
{
    public partial class testTheme : Form
    {
       
        public testTheme()
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
                    pnl.Parent = pictureBoxViewAllBookingsBackground;
                    pnl.BackColor = Color.Transparent;
                }
            }
                /*
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
                        btn.FlatStyle = FlatStyle.Flat;
                        //btn.Parent = pictureBox1;//If using a picture box as background please set parent
                        btn.BackColor = GlobalSettings.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.Font = GlobalSettings.font;
                        //btn.FlatAppearance.BorderColor = GlobalSettings.SecondaryColor;
                        btn.FlatAppearance.BorderColor = Color.White;
                        btn.FlatAppearance.BorderSize = 2;
                    }
                }
                foreach (Control lbls in this.Controls)
                {
                    if (lbls.GetType() == typeof(Label))
                    {
                        Label lbl = (Label)lbls;
                        lbl.Font = GlobalSettings.font;
                        //lbl.Parent = pictureBox1;//If using a picture box as background please set parent
                        lbl.ForeColor = GlobalSettings.SecondaryColor;
                        lbl.Parent = pictureBoxViewAllBookingsBackground;
                        lbl.BackColor = Color.Transparent;

                    }
                }                          
                foreach (Control dtg in this.Controls)
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

                foreach (Control chk in this.Controls)
                {
                    if (chk.GetType() == typeof(CheckBox))
                    {
                        CheckBox chkk = (CheckBox)chk;
                        chkk.ForeColor = GlobalSettings.SecondaryColor;

                    }*/
            }
            aplytheme(panel1);
            //aplytheme(pnl_device);
            //aplytheme(pnl_main);

        }        
        //Apply theme is used for panels.
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
                        //lbl.Parent = pictureBox1;
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
            }
        }
       

        

        private void viewAllBookings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                //Button btn = (Button)sender;
                //btn.Size = new Size(btn.Size.Width - 20, btn.Size.Height - 20);
                //btn.BackColor = ThemeColor.PrimaryColor;
                //btn.ForeColor = Color.White;
                //btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.Size = new Size(btn.Size.Width - 20, btn.Size.Height - 20);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
