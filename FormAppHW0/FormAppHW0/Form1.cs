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

        private void LnAmount_TextChanged(object sender, EventArgs e)
        {
            int loanVal;
            if ((!Int32.TryParse(lnAmount.Text, out loanVal)))
            {
                label4.Visible = true;
            }
            if ((Int32.TryParse(lnAmount.Text, out loanVal)))
            {
                label4.Visible = false;
            }
           
        }

        private void TrmYears_TextChanged(object sender, EventArgs e)
        {
            int termVal;
            if ((!Int32.TryParse(trmYears.Text, out termVal)))
            {
                label5.Visible = true;
            }
            if ((Int32.TryParse(trmYears.Text, out termVal)))
            {
                label5.Visible = false;
            }
            string num = termVal.ToString();
            if (num.Length >= 4)
            {
                label5.Visible = true;
            }
        }

        private void IRate_TextChanged(object sender, EventArgs e)
        {
            double rateVal;
            if ((!double.TryParse(iRate.Text, out rateVal)))
            {
                label6.Visible = true;
            }
            if ((double.TryParse(iRate.Text, out rateVal)))
            {
                label6.Visible = false;
            }

            string num = rateVal.ToString();
            if (num.Length >= 5)
            {
                label6.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Visible == false && label5.Visible == false && label6.Visible == false)
            {
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
