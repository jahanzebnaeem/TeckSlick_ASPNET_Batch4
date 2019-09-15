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
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teckslick_Batch4DataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.teckslick_Batch4DataSet.Country);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form countryForm = new frmCountry();
            //countryForm.MdiParent = new frmMain();
            countryForm.Show();
        }
    }
}
