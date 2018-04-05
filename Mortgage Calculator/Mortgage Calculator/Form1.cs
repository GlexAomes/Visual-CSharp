//Commenced Friday, February 5, 2016 | Due Friday, February 12, 2016
#region Mortgage Calculator
        #region Variables, Selected Setup and Load
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;

namespace Mortgage_Calculator
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        bool speech = true;
        public Form1()
        {
            Thread T = new Thread(new ThreadStart(SplashStart));
            T.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            T.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstFreq.SelectedIndex =0;
            lstVoice.SelectedIndex = 0;
            ss = new SpeechSynthesizer();
            ss.Rate = 2;
            foreach (InstalledVoice voice in ss.GetInstalledVoices())
            {
                cbVoice.Items.Add(voice.VoiceInfo.Name);
            }
            cbVoice.Items.RemoveAt(1);
            cbVoice.SelectedIndex = 0;
            ss.SpeakAsyncCancelAll();
        }
    #endregion
        #region Speech User Manager
        private void tabCalculator_MouseMove(object sender, MouseEventArgs e)
        {
            ss.SpeakAsyncCancelAll();
        }
        private void lstVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVoice.SelectedIndex == 1)
            {
                speech = false;
                cbVoice.Enabled = false;
            }
            else if (lstVoice.SelectedIndex ==0)
            {
                speech = true;
                cbVoice.Enabled = true;
            }
        }
        private void cbVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
                ss.SelectVoice(cbVoice.Text);
                if (cbVoice.SelectedIndex == 0)
                {
                    ss.SpeakAsync("Hello, I'm David, your voice speaker.");
                }
                else
                {
                    ss.SpeakAsync("Hello, I'm Zira, your voice speaker.");
                }
        }
        #endregion
        #region Welcome Tab
        private void BtnStart_Click(object sender, EventArgs e)
        {
            tbcMain.SelectTab(tabCalculator);
        }
        private void BtnCloseTb1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Calculator
        #region Voice
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (nudPrincipal.Value == 0 && nudInterest.Value == 0 && nudTerm.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Are you trying to be a rebel!? Please enter a valid number for your Principal, Interest and Amortization.");  //LMAO TAKE AWAY "ARE YOU TRYING TO BE A REBEL!?"
                }
                MessageBox.Show("Please enter a valid number for your Principal, Interest, and Amortization.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudInterest.Value == 0 && nudTerm.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Interest and Amortization.");
                }
                MessageBox.Show("Please enter a valid number for your Interest and Amortization.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudPrincipal.Value == 0 && nudInterest.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Principal and Interest.");
                }
                MessageBox.Show("Please enter a valid number for your Principal and Interest.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudPrincipal.Value == 0 && nudTerm.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Principal and Amortization.");
                }
                MessageBox.Show("Please enter a valid number for your Principal and Amortization.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudInterest.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Interest.");
                }
                MessageBox.Show("Please enter a valid number for your Interest.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudTerm.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Amortization.");
                }
                MessageBox.Show("Please enter a valid number for your Amortization.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudPrincipal.Value == 0)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a valid number for your Principal.");
                }
                MessageBox.Show("Please enter a valid number for your Principal.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudPrincipal.Value < nudDownPayment.Value || nudPrincipal.Value == nudDownPayment.Value)
            {
                if (speech == true)
                {
                    ss.SpeakAsync("Please enter a principal greater than your down payment.");
                }
                MessageBox.Show("Please enter a principal greater than your down payment.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        #endregion
        #region Equations
            if (lstFreq.SelectedIndex == 0)
            {
                double loanAmount = (double)(nudPrincipal.Value);
                double taxesPerYear = (double)(nudPropertyTax.Value);
                double downPayment = (double)(nudDownPayment.Value);
                double interestRate = (double)nudInterest.Value / 100;
                double termOfLoan = (double)(nudTerm.Value * 12);
                double propertyTax = (double)(nudPropertyTax.Value);
                double insurance = (double)(nudInsurance.Value);

                double payment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termOfLoan) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termOfLoan) - 1));

                // optional add on; a monthly property tax and insurance

                payment = payment + (propertyTax + insurance) / 12;
                txtPayment.Text = payment.ToString("C");
                double total = (payment * termOfLoan);
                txtPaymentwithInterest.Text = total.ToString("C");

                if (nudInterest.Value > 0 && nudTerm.Value > 0 && nudPrincipal.Value > 0 && nudPrincipal.Value > nudDownPayment.Value) //copy to week and bi
                {
                    if (speech == true)
                    {
                        ss.SpeakAsync("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your monthly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and any optionals is " + (txtPaymentwithInterest.Text + ".")))));
                    }
                     MessageBox.Show("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your monthly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and any optionals is " + (txtPaymentwithInterest.Text + ".")))), "Mortgage Statement");
                }
            }
            
            else if (lstFreq.SelectedIndex == 1) //Replaced 12 with 52
            {
                double loanAmount = (double)(nudPrincipal.Value);
                double taxesPerYear = (double)(nudPropertyTax.Value);
                double downPayment = (double)(nudDownPayment.Value);
                double interestRate = (double)nudInterest.Value / 100;
                double termOfLoan = (double)(nudTerm.Value * 52);
                double propertyTax = (double)(nudPropertyTax.Value);
                double insurance = (double)(nudInsurance.Value);

                double payment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 52), termOfLoan) * interestRate) / (52 * (Math.Pow((1 + interestRate / 52), termOfLoan) - 1));

                // optional add on a weekly property tax and insurance

                payment = payment + (propertyTax + insurance) / 52;
                double total = (payment * termOfLoan);
                txtPaymentwithInterest.Text = total.ToString("C");
                double wpayment = payment; //2;

                txtPayment.Text = wpayment.ToString("C");

                if (nudInterest.Value > 0 && nudTerm.Value > 0 && nudPrincipal.Value > 0 && nudPrincipal.Value > nudDownPayment.Value)
                {
                    if (speech == true)
                    {
                        ss.SpeakAsync("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your weekly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and any optionals is " + (txtPaymentwithInterest.Text + ".")))));
                    }
                        MessageBox.Show("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your weekly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and optionals is " + (txtPaymentwithInterest.Text + ".")))), "Mortgage Statement");
                }
            }
            else if (lstFreq.SelectedIndex == 2) //Replaced 12 with 26 
            {
                double loanAmount = (double)(nudPrincipal.Value);
                double taxesPerYear = (double)(nudPropertyTax.Value);
                double downPayment = (double)(nudDownPayment.Value);
                double interestRate = (double)nudInterest.Value / 100;
                double termOfLoan = (double)(nudTerm.Value * 26);
                double propertyTax = (double)(nudPropertyTax.Value);
                double insurance = (double)(nudInsurance.Value);

                double payment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 26), termOfLoan) * interestRate) / (26 * (Math.Pow((1 + interestRate / 26), termOfLoan) - 1));

                // optional add on a biweekly property tax and insurance

                payment = payment + (propertyTax + insurance) / 26;
                double total = (payment * termOfLoan);
                txtPaymentwithInterest.Text = total.ToString("C");
                double bpayment = payment; // 4;


                txtPayment.Text = bpayment.ToString("C");


                if (nudInterest.Value > 0 && nudTerm.Value > 0 && nudPrincipal.Value > 0 && nudPrincipal.Value > nudDownPayment.Value)
                {
                    if (speech == true)
                    {
                        ss.SpeakAsync("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your bi-weekly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and any optionals is " + (txtPaymentwithInterest.Text + ".")))));
                    }
                   MessageBox.Show("For a " + (nudPrincipal.Value.ToString("C") + " mortgage at a " + (nudInterest.Value.ToString("N") + "% interest rate, for " + (nudTerm.Value.ToString() + " years, your bi-weekly payment will be " + (txtPayment.Text + ".") + Environment.NewLine + Environment.NewLine + "Your total payment after interest and optionals is " + (txtPaymentwithInterest.Text + ".")))), "Mortgage Statement");
                }

            }
        }
            #endregion
        #endregion
        #region Numeric UpDown Collation with Trackbar
        private void trbTerm_ValueChanged(object sender, EventArgs e) //Term Collaberator
        {
            nudTerm.Value = trbTerm.Value;
        }
        private void trbInterest_ValueChanged(object sender, EventArgs e)
        {
            nudInterest.Value = trbInterest.Value;
        }
        private void nudTerm_ValueChanged(object sender, EventArgs e)
        {
            trbTerm.Value = Convert.ToInt32(nudTerm.Value);
        }
        private void nudInterest_ValueChanged(object sender, EventArgs e)
        {
            trbInterest.Value = Convert.ToInt32(nudInterest.Value);
        }
#endregion
        #region Calculator Tab Option Control & Help
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLifestyleControls_Click(object sender, EventArgs e)
        {
            tbcMain.SelectTab(tabPersonalize);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = true;
            btnHelp.Visible = false;
            btnCloseHelp.Visible = true;
            btnHelpOptionals.Visible = true;
        }
        private void btnCloseHelp_Click(object sender, EventArgs e)
        {
            lblHelp.Visible = false;
            btnHelp.Visible = true;
            btnCloseHelp.Visible = false;
            btnHelpOptionals.Visible = false;
        }
        private void btnHelpOptionals_Click(object sender, EventArgs e)
        {
            tbcMain.SelectTab(tabHelpOptionals);
        }
        #endregion
        #region Optionals Help Tab
        private void btnReturnfromHelpOptionals_Click(object sender, EventArgs e)
        {
            tbcMain.SelectTab(tabCalculator);
        }
        #endregion
        #region Personalization Tab 
        private void BtnReturntoCalc_Click(object sender, EventArgs e)
        {
            tbcMain.SelectTab(tabCalculator);
        }
        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)          //Delete the "//" if need be; keep for records sake
            {
                this.BackColor = colorDialog1.Color;        //Main
                tabCalculator.BackColor = colorDialog1.Color;       //First tab begins
                tabPersonalize.BackColor = colorDialog1.Color;
                tabHelpOptionals.BackColor = colorDialog1.Color;
              //  nudPrincipal.BackColor = colorDialog1.Color;
              //  nudInterest.BackColor = colorDialog1.Color;
             //   nudTerm.BackColor = colorDialog1.Color;
              //  nudDownPayment.BackColor = colorDialog1.Color;
             //   nudPropertyTax.BackColor = colorDialog1.Color;
            //    nudInsurance.BackColor = colorDialog1.Color;
             //   lstFreq.BackColor = colorDialog1.Color;         //First tab ends
            //    lstVoice.BackColor = colorDialog1.Color;        //Second tab begins
            //    cbVoice.BackColor = colorDialog1.Color;         //Second tab ends
            }
        }
        private void BtnButtonColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {   
                nudPrincipal.BackColor = colorDialog1.Color; //First tab begins
                nudInterest.BackColor = colorDialog1.Color;
                nudTerm.BackColor = colorDialog1.Color;
                nudDownPayment.BackColor = colorDialog1.Color;
                nudPropertyTax.BackColor = colorDialog1.Color;
                nudInsurance.BackColor = colorDialog1.Color;
                trbInterest.BackColor = colorDialog1.Color;
                trbTerm.BackColor = colorDialog1.Color;
                lstFreq.BackColor = colorDialog1.Color;
                btnCalculate.BackColor = colorDialog1.Color;
                btnHelp.BackColor = colorDialog1.Color;
                BtnLifestyleControls.BackColor = colorDialog1.Color;
                BtnQuit.BackColor = colorDialog1.Color;
                btnCloseHelp.BackColor = colorDialog1.Color;
                lblPercent.BackColor = colorDialog1.Color;
                lblYears.BackColor = colorDialog1.Color;
                btnHelpOptionals.BackColor = colorDialog1.Color; //First tab ends
                BtnBackColor.BackColor = colorDialog1.Color; //Second tab begins
                BtnButtonColor.BackColor = colorDialog1.Color;
                BtnTextColor.BackColor = colorDialog1.Color;
                BtnReturntoCalc.BackColor = colorDialog1.Color;
                lstVoice.BackColor = colorDialog1.Color;
                cbVoice.BackColor = colorDialog1.Color; //Second tab ends
                btnReturnfromHelpOptionals.BackColor = colorDialog1.Color; //third tab begins and ends
            }
        }
        private void BtnTextColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblMortgageCalc.ForeColor = colorDialog1.Color; //First tab begings
                lblRequirements.ForeColor = colorDialog1.Color;
                lblOptional.ForeColor = colorDialog1.Color;
                lblPrincipal.ForeColor = colorDialog1.Color;
                lblInterest.ForeColor = colorDialog1.Color;
                lblTerm.ForeColor = colorDialog1.Color;
                lblFreq.ForeColor = colorDialog1.Color;
                lblDownPayment.ForeColor = colorDialog1.Color;
                lblPropertyTax.ForeColor = colorDialog1.Color;
                lblInsurance.ForeColor = colorDialog1.Color;
                lblHelp.ForeColor = colorDialog1.Color;
                lblPercent.ForeColor = colorDialog1.Color;
                lblYears.ForeColor = colorDialog1.Color;
                nudPrincipal.ForeColor = colorDialog1.Color;
                nudInterest.ForeColor = colorDialog1.Color;
                nudTerm.ForeColor = colorDialog1.Color;
                nudDownPayment.ForeColor = colorDialog1.Color;
                nudPropertyTax.ForeColor = colorDialog1.Color;
                nudInsurance.ForeColor = colorDialog1.Color;
                lstFreq.ForeColor = colorDialog1.Color;
                btnCalculate.ForeColor = colorDialog1.Color;
                btnHelp.ForeColor = colorDialog1.Color;
                btnCloseHelp.ForeColor = colorDialog1.Color;
                BtnQuit.ForeColor = colorDialog1.Color;
                BtnLifestyleControls.ForeColor = colorDialog1.Color;
                btnHelpOptionals.ForeColor = colorDialog1.Color; //First tab ends
                BtnBackColor.ForeColor = colorDialog1.Color; //Second tab begins
                BtnButtonColor.ForeColor = colorDialog1.Color;
                BtnTextColor.ForeColor = colorDialog1.Color;
                BtnReturntoCalc.ForeColor = colorDialog1.Color;
                lblPersonalization.ForeColor = colorDialog1.Color;
                lblPersonalizationDesc.ForeColor = colorDialog1.Color;
                lblVoice.ForeColor = colorDialog1.Color;
                lblSpeaker.ForeColor = colorDialog1.Color;
                lstVoice.ForeColor = colorDialog1.Color;
                cbVoice.ForeColor = colorDialog1.Color; //Second tab ends
                lblHelpOptionals.ForeColor = colorDialog1.Color; //Third tab begins
                lblDownpaymentexplained.ForeColor = colorDialog1.Color;
                lblPropertytaxexplained.ForeColor = colorDialog1.Color;
                lblInsuranceexplained.ForeColor = colorDialog1.Color;
                btnReturnfromHelpOptionals.ForeColor = colorDialog1.Color;
                lblDownpaymenttitle.ForeColor = colorDialog1.Color;
                lblPropertyTaxTitle.ForeColor = colorDialog1.Color;
                lblInsuranceTitle.ForeColor = colorDialog1.Color; //Third tab ends
            }

        }
        #endregion
        #region Fixes and extras

        private void nudPrincipal_Leave(object sender, EventArgs e)
        {
            if (nudPrincipal.Text == "")
            {
                nudPrincipal.Value = 0;
                if (speech == true)
                {
                ss.SpeakAsync("Please enter a valid number for your Principal");
                }
                MessageBox.Show("Please enter a valid number for your Principal.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbVoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();    
        }
        #endregion
        #region Closing Confirmation
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Are you sure you want to quit your Mortgage Calculator?" + Environment.NewLine + "Your personalization and data will not be saved.", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
            e.Cancel = true;
            }
        }
        #endregion
    }
}
#endregion
//Completed Tuesday, February 9, 2016 | Debugged and Tested Wednesday, February 10, 2016

//Marked Tuesday, February 16. 2016 - 100% (+1% Overall) [WORTH 5%]