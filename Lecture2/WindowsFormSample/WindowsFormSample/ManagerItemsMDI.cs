using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSample
{
    public partial class ManagerItemsMDI : Form
    {
        public ManagerItemsMDI()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Itration 2
            if (txtName.Text.Contains("@"))
            {
                lblResult.Text = "This is a valid email";
            }
            else
            {
                lblResult.Text = "Your email is invalid";
            }
            // Itration 1
            //if (txtName.Text.ToLower() == "jahanzeb")
            //{
            //    lblResult.Text = "Welcome " + txtName.Text + " to the ASP.NET Batch 4";
            //}
            //else
            //{
            //    lblResult.Text = "You are not Jahanzeb Naeem, please login";
            //}
        }
    }
}
