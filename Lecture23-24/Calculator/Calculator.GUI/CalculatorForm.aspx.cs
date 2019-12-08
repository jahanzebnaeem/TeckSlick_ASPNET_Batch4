using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator.Library;

namespace Calculator.GUI
{
    public partial class CalculatorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int operand1 = Convert.ToInt32(txtOperand1.Text);
            int operand2 = Convert.ToInt32(txtOperand2.Text);
            var result = CalculatorAdd.AddValue(operand1, operand2);
            lblResult.Text = result.ToString();
        }
    }
}