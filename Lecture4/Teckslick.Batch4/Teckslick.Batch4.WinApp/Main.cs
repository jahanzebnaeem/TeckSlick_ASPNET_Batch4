using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teckslick.Batch4.WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form countriesForm = new frmCountries();
            countriesForm.MdiParent = this;
            countriesForm.Show();
        }
    }
}
