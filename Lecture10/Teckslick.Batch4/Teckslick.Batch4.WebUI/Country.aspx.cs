using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Teckslick.Batch4.Common;
using Teckslick.Batch4.Application;

namespace Teckslick.Batch4.WebUI
{
    public partial class Country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Add logic to hook up with control
                List<Teckslick.Batch4.Common.Country> countries = new CountryHandler().GetCountries();
                grdCountries.DataSource = countries;
                grdCountries.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}