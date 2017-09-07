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
            label4.Visible = false; // sets "must me a number" labal to false
            label5.Visible = false; // sets "must be a year" labal to false
            label6.Visible = false; // sets "must be a %" labal to false

            
        }

        private void LnAmount_TextChanged(object sender, EventArgs e) //input validation for loan amount
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

        private void TrmYears_TextChanged(object sender, EventArgs e) //input validation for Loan term 
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

        private void IRate_TextChanged(object sender, EventArgs e) //input validation for Interest Rate
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
            if (label4.Visible == false && label5.Visible == false && label6.Visible == false) //makes sure input is in correct type and format
            {
                double lAmount = Convert.ToDouble(loanAmount.Text); //changes type of loan amount to double
                double iRate = Convert.ToDouble(intRate.Text) / 100; // changes Interest rate to double
                double loanMonths = Convert.ToDouble(loanYears.Text) * 12; // gets interest rate by month and converts it to a double
                double payMonth = (lAmount) * (Math.Pow((1 + iRate / 12), loanMonths) * iRate) / (12 * (Math.Pow((1 + iRate / 12), loanMonths) - 1)); //monththly payment formula that returns the payment based on the users input for years

                double monthPaid = Math.Round(payMonth, 2); //puts monthly payment into number.XX



                for (int t =1;t<=loanMonths;t++) //calculator for loan repayment
                {
                    
                    double intpaid = Math.Round(lAmount * (iRate / 12), 2); //gets interest paid per month on loan
                    
                    double princpaid = Math.Round(monthPaid - intpaid, 2); // gets principal paid per month on loan

                    double balance = Math.Round((lAmount - princpaid), 2); // gets remaing balance on the loan after the principal paid each month is is subtracted.

                    Solution.AppendText(string.Format("Month: {0,-10}", t)) ; // adds Month to richtextbox
                    Solution.AppendText(string.Format("Balance: {0,-20}", balance)); //adds Balace to richtextbox
                    Solution.AppendText(string.Format("Interest Paid: {0,-20}", intpaid)); // adds Interst paid to richtextbox 
                    Solution.AppendText(string.Format("Principal: {0,-15}" + "\r\n", princpaid)); // adds Principal paid to richtextbox
                    

                    lAmount = balance; //recomputes new loan Amount
                }
               
                
                
            }

        }
    }
}
