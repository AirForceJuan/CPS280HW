using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppHW0
    /// </summary>
    /// Form App that Calculates the Payoff of a loan
    /// </summary>
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void lnAmount_TextChanged(object sender, EventArgs e)
        {
            int val;
            if ((!Int32.TryParse(lnAmount.Text, out val)))
            {
                label4.Visible = true;
            }
            if ((Int32.TryParse(lnAmount.Text, out val)))
            {
                label4.Visible = false;
            }

           
        }

        private void trmYears_TextChanged(object sender, EventArgs e)
        {
            int val;
            if ((!Int32.TryParse(trmYears.Text, out val)))
            {
                label5.Visible = true;
            }
            if ((Int32.TryParse(trmYears.Text, out val)))
            {
                label5.Visible = false;
            }
            string num = val.ToString();
            if (num.Length >= 4)
            {
                label5.Visible = true;
            }
        }

        private void iRate_TextChanged(object sender, EventArgs e)
        {
            double val;
            if ((!double.TryParse(iRate.Text, out val)))
            {
                label6.Visible = true;
            }
            if ((double.TryParse(iRate.Text, out val)))
            {
                label6.Visible = false;
            }

            string num = val.ToString();
            if (num.Length >= 5)
            {
                label6.Visible = true;
            }
        }

    }
}
