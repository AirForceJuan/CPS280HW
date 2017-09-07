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
            int val;
            if ((!Int32.TryParse(loanAmount.Text, out val)))
            {
                label4.Visible = true;
            }
            if ((Int32.TryParse(loanAmount.Text, out val)))
            {
                label4.Visible = false;
            }
           
        }

        private void TrmYears_TextChanged(object sender, EventArgs e)
        {
            int val;
            if ((!Int32.TryParse(loanYears.Text, out val)))
            {
                label5.Visible = true;
            }
            if ((Int32.TryParse(loanYears.Text, out val)))
            {
                label5.Visible = false;
            }
            string num = val.ToString();
            if (num.Length >= 4)
            {
                label5.Visible = true;
            }
        }

        private void IRate_TextChanged(object sender, EventArgs e)
        {
            double val;
            if ((!double.TryParse(intRate.Text, out val)))
            {
                label6.Visible = true;
            }
            if ((double.TryParse(intRate.Text, out val)))
            {
                label6.Visible = false;
            }

            string num = val.ToString();
            if (num.Length >= 7)
            {
                label6.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (label4.Visible == false && label5.Visible == false && label6.Visible == false)
            {
                double lAmount = Convert.ToDouble(loanAmount.Text);
                double iRate = Convert.ToDouble(intRate.Text) / 100;
                double loanMonths = Convert.ToDouble(loanYears.Text) * 12;
                double payMonth = (lAmount) * (Math.Pow((1 + iRate / 12), loanMonths) * iRate) / (12 * (Math.Pow((1 + iRate / 12), loanMonths) - 1));

                double monthPaid = Math.Round(payMonth, 1);



                for (int t =1;t<=loanMonths;t++)
                {
                    
                    double intpaid = Math.Round(lAmount * (iRate / 12), 3);
                    double balance = Math.Round((lAmount - monthPaid),3);
                    double princpaid = Math.Round(monthPaid - intpaid, 3);

                    Solution.AppendText(string.Format("Month: {0}", t));
                    Solution.AppendText(string.Format("Balance: {0}", balance));
                    Solution.AppendText(string.Format("Interest Paid: {0}", intpaid));
                    Solution.AppendText(string.Format("Principal: {0}\t\n", princpaid));
                    

                    lAmount = balance;
                }
               
                
                
            }

        }
    }
}
