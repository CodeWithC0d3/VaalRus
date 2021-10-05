using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaalrusGUIPrototype.Forms
{
    
    public partial class frmDBSetup : Form
    {
        public int localServer; //local True and server false
        public frmDBSetup()
        {
            InitializeComponent();
        }

        private void btnlocal_Click(object sender, EventArgs e)
        {
            localServer = 0;
            this.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            localServer = 1;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            localServer = 2;
            this.Close();
        }

        private void frmDBSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
