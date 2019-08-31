﻿using System;
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
    public partial class MainApplication : Form
    {
        public MainApplication()
        {
            InitializeComponent();
        }

        private void ManageItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mngItems = new ManagerItemsMDI();
            mngItems.MdiParent = this;
            mngItems.Show();
        }
    }
}
