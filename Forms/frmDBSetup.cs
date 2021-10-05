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
        public Boolean localServer; //local True and server false
        public frmDBSetup()
        {
            InitializeComponent();
        }

        private void btnlocal_Click(object sender, EventArgs e)
        {
            localServer = true;
            this.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            localServer = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
