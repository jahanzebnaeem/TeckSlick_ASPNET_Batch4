using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teckslick.Batch4.Application;

namespace Teckslick.Batch4.WinUI
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
            // Add logic to hook up with control
            List<Teckslick.Batch4.Common.Country> countries = new CountryHandler().GetCountries();
            grdCountries.DataSource = countries;
        }
    }
}
