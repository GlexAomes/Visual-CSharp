//Commenced Wednesday, February 17, 2016 | Due Wednesday, February 24, 2016
#region POS
#region References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
#endregion

#region Variables and Settings -> Complete
namespace Subway_POS
{
    public partial class Form2 : Form
    {
        bool paid = false;

        bool BreadExists = false;
        bool MeatExists = false;
        bool CheeseExists = false;
        bool VegetableExists = false;
        bool SauceExists = false;

        double before;
        string Small;
        double SizePrice;

        double BreadPrice;
        double MeatPrice;

        string BreadCode;
        string MeatCode;

        string BreadName;
        string MeatName;

        public Form2()
        {
            InitializeComponent();
        }

        public static double total;
        public static double tax;
        public static string money;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width += 64;
            this.Height += 70;
        }

#endregion

#region Checkbox Limiter -> Complete
        private void chkBoxBread_CheckedChanged(object sender, EventArgs e) //Fkin' Bread (not literally...)
        {
            var checkboxes = this.grpBreadType.Controls.OfType<CheckBox>().ToList();
            int numberChecked = checkboxes.Where(x => x.Checked).ToList().Count;
            foreach (var chk in checkboxes)
            {
                chk.Enabled = numberChecked < 1 || chk.Checked;
                if (chk.Checked == true)
                {
                    BreadCode = chk.Name;
                }
            }
        }

        private void chkBoxMeat_CheckChanged(object sender, EventArgs e) //Meat ( ͡° ͜ʖ ͡°)
        {
            var checkboxes = this.grpMeat.Controls.OfType<CheckBox>().ToList();
            int numberChecked = checkboxes.Where(x => x.Checked).ToList().Count;
            foreach (var chk in checkboxes)
            {
                chk.Enabled = numberChecked < 1 || chk.Checked;
                if (chk.Checked == true)
                {
                    MeatCode = chk.Name;
                }
            }
        }

        private void chkBoxCheese_CheckChanged(object sender, EventArgs e) //U cheesed bruh?
        {
            var checkboxes = this.grpCheeseType.Controls.OfType<CheckBox>().ToList();
            int numberChecked = checkboxes.Where(x => x.Checked).ToList().Count;
            foreach (var chk in checkboxes)
            {
                chk.Enabled = numberChecked < 1 || chk.Checked;
            }
        }

        private void chkBoxVegetables_CheckChanged(object sender, EventArgs e) //Vegeta.. bless
        {
            var checkboxes = this.grpVegetables.Controls.OfType<CheckBox>().ToList();
            int numberChecked = checkboxes.Where(x => x.Checked).ToList().Count;
            foreach (var chk in checkboxes)
            {
                chk.Enabled = numberChecked < 4 || chk.Checked;
            }
        }

        private void chkBoxSauces_CheckedChanged(object sender, EventArgs e)
        {
            var checkboxes = this.grpSauces.Controls.OfType<CheckBox>().ToList();
            int numberChecked = checkboxes.Where(x => x.Checked).ToList().Count;
            foreach (var chk in checkboxes)
            {
                chk.Enabled = numberChecked < 2 || chk.Checked;
            }
        }
#endregion

#region Sammich Builder Reset -> Complete
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnBuild.Visible = true;
            btnReset.Visible = false;
            grpBreadType.Enabled = true;
            grpMeat.Enabled = true;
            grpCheeseType.Enabled = true;
            grpVegetables.Enabled = true;
            grpSauces.Enabled = true;
            grpSandwichType.Enabled = true;

            var BreadReset = this.grpBreadType.Controls.OfType<CheckBox>();
            var MeatReset = this.grpMeat.Controls.OfType<CheckBox>();
            var CheeseReset = this.grpCheeseType.Controls.OfType<CheckBox>();
            var VegetableReset = this.grpVegetables.Controls.OfType<CheckBox>();
            var SauceReset = this.grpSauces.Controls.OfType<CheckBox>();

            foreach (var chk in BreadReset)
            {
                chk.Checked = false;
                BreadExists = false;
            }
            foreach (var chk in MeatReset)
            {
                chk.Checked = false;
                MeatExists = false;
            }
            foreach (var chk in CheeseReset)
            {
                chk.Checked = false;
                CheeseExists = false;
            }
            foreach (var chk in VegetableReset)
            {
                chk.Checked = false;
                VegetableExists = false;
            }
            foreach (var chk in SauceReset)
            {
                chk.Checked = false;
                SauceExists = false;
            }
        } 
#endregion

#region Sammich Builder -> Complete [Core 1]
        //Sandwich prices are only determined by bread and size
        private void btnBuild_Click(object sender, EventArgs e)
        {
            #region Validator
            var BreadReset = this.grpBreadType.Controls.OfType<CheckBox>();
            var MeatReset = this.grpMeat.Controls.OfType<CheckBox>();
            var CheeseReset = this.grpCheeseType.Controls.OfType<CheckBox>();
            var VegetableReset = this.grpVegetables.Controls.OfType<CheckBox>();
            var SauceReset = this.grpSauces.Controls.OfType<CheckBox>();

            foreach (var chk in BreadReset)
            {
                if (chk.Checked == true)
                {
                    BreadExists = true;
                }
            }
            foreach (var chk in MeatReset)
            {
                if (chk.Checked == true)
                {
                    MeatExists = true;
                }
            }
            foreach (var chk in CheeseReset)
            {
                if (chk.Checked == true)
                {
                    CheeseExists = true;
                }
            }
            foreach (var chk in VegetableReset)
            {
                if (chk.Checked == true)
                {
                    VegetableExists = true;
                }
            }
            foreach (var chk in SauceReset)
            {
                if (chk.Checked == true)
                {
                    SauceExists = true;
                }
            }
            #endregion
            #region Set Values

            if (rdoHalfFoot.Checked == true)
            {
                Small = "6' ";
                SizePrice = 6.00;
            }
            else if (rdoFootLong.Checked == true)
            {
                Small = "12' ";
                SizePrice = 8.00;
            }

            if (BreadCode == "chkGrainWheat") //Breads
            {
                BreadName = "Wheat";
                BreadPrice = 0.45;
            }
            else if (BreadCode == "chkGrainHoneyOat")
            {
                BreadName = "Honey Oat";
                BreadPrice = 0.69;
            }
            else if (BreadCode == "chkCheeseBread")
            {
                BreadName = "Cheese Bread";
                BreadPrice = 0.79;
            }
            else if (BreadCode == "chkFlatBread")
            {
                BreadName = "Flatbread";
                BreadPrice = 0.39;
            }
            else if (BreadCode == "chkItalian")
            {
                BreadName = "Italian";
                BreadPrice = 0.55;
            }
            else if (BreadCode == "chkItalianHerbCheese")
            {
                BreadName = "Italian Herb & Cheese";
                BreadPrice = 0.65;
            }
            else if (BreadCode == "chkHeartyItalian")
            {
                BreadName = "Hearty Italian";
                BreadPrice = 0.50;
            }
            else if (BreadCode == "chkParmesanOregano")
            {
                BreadName = "Parmesan Oregano";
                BreadPrice = 0.89;
            }
            else if (BreadCode == "chkRoastedGarlic")
            {
                BreadName = "Roasted Garlic";
                BreadPrice = 0.79;
            }
            //MEATS
            if (MeatCode == "chkChickenBreast")
            {
                MeatName = "Chicken Breast";
                MeatPrice = 1.19;
            }
            else if (MeatCode == "chkHam")
            {
                MeatName = "Ham";
                MeatPrice = 0.99;
            }
            else if (MeatCode == "chkGenoaSalami")
            {
                MeatName = "Genoa Salami";
                MeatPrice = 0.99;
            }
            else if (MeatCode == "chkMeatballs")
            {
                MeatName = "Meatballs";
                MeatPrice = 1.09;
            }
            else if (MeatCode == "chkRoastBeef")
            {
                MeatName = "Roast Beef";
                MeatPrice = 1.29;
            }            
            else if (MeatCode == "chkSteakandCheese")
            {
                MeatName = "Steak & Cheese";
                MeatPrice = 1.49;
            }
            else if (MeatCode == "chkTuna")
            {
                MeatName = "Tuna";
                MeatPrice = 1.39;
            }
            else if (MeatCode == "chkTurkeyBreast")
            {
                MeatName = "Turkey Breast";
                MeatPrice = 1.19;
            }
            else if (MeatCode == "chkMeatNone")
            {
                MeatName = "Veggie";
                MeatPrice = 0.99;
            }

            #endregion
            #region Compile and send to Receipt
            if (BreadExists == true && MeatExists == true && CheeseExists == true && VegetableExists == true && SauceExists) // add sauce lmao
            {
            btnBuild.Visible = false;
            btnReset.Visible = true;
            grpSandwichType.Enabled = false;
            grpBreadType.Enabled = false;
            grpMeat.Enabled = false;
            grpCheeseType.Enabled = false;
            grpVegetables.Enabled = false;
            grpSauces.Enabled = false;
            double breadandsizeprice = BreadPrice + SizePrice;

                double totalwBefore;
                before = Convert.ToDouble(txtTotal.Text);
                totalwBefore = before + BreadPrice + MeatPrice + SizePrice; //add others?
                lstTransaction.Items.Add(Small + MeatName + " Sandwich ");
                //lstTransaction.Items.Add(MeatName); //Meat
                lstPrice.Items.Add((breadandsizeprice + MeatPrice).ToString("N"));
                //lstPrice.Items.Add(MeatPrice); //Meat Price
                txtTotal.Text = totalwBefore.ToString("N");
                MessageBox.Show("Sandwich added to receipt.", "Well Made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The sandwich is incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (lstTransaction.Items.Count > -1) //Manually set btnPay to enabled if there aren't any other items
            {
                btnPay.Enabled = true;
            }
            #endregion
        }
#endregion

#region Transaction Tab Button Logic -> Clean up after
        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            double Totalbefore = Convert.ToDouble(txtTotal.Text);
            double PricetoAdd = Convert.ToDouble(lstPrice.SelectedItem.ToString());
            double dupupdate = Totalbefore + PricetoAdd;
            lstTransaction.Items.Add(lstTransaction.SelectedItem);//
            lstPrice.Items.Add(lstPrice.SelectedItem);//
            txtTotal.Text = dupupdate.ToString("N");
        }
        private void btnVoid_Click(object sender, EventArgs e)
        {
            double Totalbefore = Convert.ToDouble(txtTotal.Text);
            double PricetoRemove = Convert.ToDouble(lstPrice.SelectedItem.ToString());
            double voidupdate = Totalbefore - PricetoRemove;
                lstTransaction.Items.RemoveAt(lstTransaction.SelectedIndex);
                lstPrice.Items.RemoveAt(lstPrice.SelectedIndex);
                txtTotal.Text = voidupdate.ToString("N");
                
        }
        private void lstTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTransaction.SelectedIndex > -1)
            {
            lstPrice.SelectedIndex = lstTransaction.SelectedIndex;
        }
            if (lstTransaction.SelectedItems.Count > 0)
            {
                btnDuplicate.Enabled = true;
                btnVoid.Enabled = true;
            }
            else
            {
                btnDuplicate.Enabled = false;
                btnVoid.Enabled = false;
            }
                if (lstTransaction.Items.Count <= 0)
                {
                    btnPay.Enabled = false;
                }

        }

        private void lstPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTransaction.SelectedIndex = lstPrice.SelectedIndex;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTransaction.Items.Clear();
            lstPrice.Items.Clear();
            btnDuplicate.Enabled = false;
            btnVoid.Enabled = false;
            btnPay.Enabled = false;
            txtTotal.Text = "0.00";
            txtTax.Text = "0.00";
            tbcMenus.Enabled = true;
            btnPrint.Enabled = false;
            paid = false;
            btnClear.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            total = Convert.ToDouble(txtTax.Text);
            tax = Convert.ToDouble(txtTax.Text) - (Convert.ToDouble(txtTotal.Text));
            Form3 Frm3 = new Form3();
            Frm3.ShowDialog();
            btnPrint.Enabled = true;
            btnPay.Enabled = false;
            tbcMenus.Enabled = false;
            paid = true;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTax.Text = (Convert.ToDouble(txtTotal.Text) * 1.13).ToString("N");
            if (Convert.ToDouble(txtTotal.Text) > 0)
            {
                btnPay.Enabled = true;
                btnClear.Enabled = true;
            }
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 1 && paid == true)
            {
                MessageBox.Show("Customer Receipt is still open!" + Environment.NewLine + "Please clear the receipt.", "Active Receipt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbcMain.SelectedIndex = 2;
            }
            else if (tbcMain.SelectedIndex == 0 && paid == true)
            {
                MessageBox.Show("Customer Receipt is still open!" + Environment.NewLine + "Please clear the receipt.", "Active Receipt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbcMain.SelectedIndex = 2;
            }
        }

#endregion

#region Featured Sandwiches [Core 2] -> Complete
        private void btnChickenandBaconRanchMelt_Click(object sender, EventArgs e)
        {
            string sub = "Chicken & Bacon Ranch Sub ";
            double price = 7.20;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Chicken and Bacon Ranch Melt to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }


        }
        private void btnChickenPizziolaMelt_Click(object sender, EventArgs e)
        {
            string sub = "Chicken Pizziola Sub ";
            double price = 7.49;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Chicken Pizziola Melt to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void SweetOnionChickenTeriyaki_Click(object sender, EventArgs e)
        {
            string sub = "SO Chicken Teriyaki Sub ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Sweet Onion Chicken Teriyaki to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSteakandCheese_Click(object sender, EventArgs e)
        {
            string sub = "Steak & Cheese Sub ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Steak and Cheese to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnVeggieDelite_Click(object sender, EventArgs e)
        {
            string sub = "Veggie Delite Sub ";
            double price = 5.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Veggie Delite to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnTurkeyBreastandHam_Click(object sender, EventArgs e)
        {
            string sub = "Turkey Breast & Ham Sub ";
            double price = 7.20;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Turkey Breast and Ham to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnTuna_Click(object sender, EventArgs e)
        {
            string sub = "Tuna Sub ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Tuna to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnMeatballMarinara_Click(object sender, EventArgs e)
        {
            string sub = "Meatball Marinara Sub ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Meatball Marinara to receipt?", "Featured Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        #endregion 

#region Cold Drinks [Core 3] -> Complete
        private void btnPepsi_Click(object sender, EventArgs e)
        {
            string sub = "Pepsi - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Pepsi to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnCoke_Click(object sender, EventArgs e)
        {
            string sub = "Coca Cola Classic - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Coca Cola Classic to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSprite_Click(object sender, EventArgs e)
        {
            string sub = "Sprite - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Sprite to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnNestea_Click(object sender, EventArgs e)
        {
            string sub = "Nestea Lemon - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Nestea to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnWater_Click(object sender, EventArgs e)
        {
            string sub = "Bottled Water - 500mL ";
            double price = 1.20;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Bottled Water to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnMtnDew_Click(object sender, EventArgs e)
        {
            string sub = "Mountain Dew - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Mountain Dew to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnFanta_Click(object sender, EventArgs e)
        {
            string sub = "Fanta Orange - 355mL ";
            double price = 0.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Fanta Orange to receipt?", "Cold Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        #endregion 

#region Hot Drinks [Core 4] -> Complete
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            string sub = " Coffee ";
            double price = Convert.ToDouble(lblCoffeePrice.Text);
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add " + lblSize.Text + " " + lblCoffeeStyle.Text + " Coffee to receipt?", "Hot Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(lblSize.Text + sub + lblCoffeeStyle.Text))
                    {
                        if (s == lblSize.Text + sub + lblCoffeeStyle.Text)
                        {
                            lstTransaction.Items[i] = lblSize.Text + sub + lblCoffeeStyle.Text + " x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = lblSize.Text + sub + lblCoffeeStyle.Text + " x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(lblSize.Text + sub + lblCoffeeStyle.Text);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        } 
        #endregion
#region Coffee Trackbar Selection -> Complete
        private void trbCoffee_Scroll(object sender, EventArgs e)
        {
            if (trbCoffee.Value == 0)
            {
                lblCoffeePrice.Text = "1.49";
                lblSize.Text = "Small";
            }
            else if (trbCoffee.Value == 1)
            {
                lblCoffeePrice.Text = "1.99";
                lblSize.Text = "Medium";
            }
            else if (trbCoffee.Value > 1)
            {
                lblCoffeePrice.Text = "2.49";
                lblSize.Text = "Large";
            }
        }
        private void trbCoffeeType_Scroll(object sender, EventArgs e)
        {
            if (trbCoffeeType.Value == 0)
            {
                lblCoffeeStyle.Text = "Regular";
            }
            else if (trbCoffeeType.Value == 1)
            {
                lblCoffeeStyle.Text = "Decaf";
            }
        }
        #endregion

#region Breakfast [Core 5] -> Complete
        private void btnBaconEggandCheese_Click(object sender, EventArgs e)
        {
            string sub = "Bacon, Egg & Cheese Breakfast ";
            double price = 3.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Bacon, Egg & Cheese to receipt?", "Breakfast", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnBlackForestHamEggsandCheese_Click(object sender, EventArgs e)
        {
            string sub = "Ham, Egg & Cheese Breakfast ";
            double price = 3.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Black Forest Ham, Egg & Cheese to receipt?", "Breakfast", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnEggsandCheese_Click(object sender, EventArgs e)
        {
            string sub = "Egg & Cheese Breakfast ";
            double price = 3.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Egg & Cheese to receipt?", "Breakfast", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSteakEggWhiteandCheese_Click(object sender, EventArgs e)
        {
            string sub = "Steak, Egg & Cheese Breakfast ";
            double price = 3.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Steak, Egg White & Cheese to receipt?", "Breakfast", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        #endregion

#region Sides [Core 6 -> Complete]
        private void btnAppleSlice_Click(object sender, EventArgs e)
        {
            string sub = "Subway Apple Slices ";
            double price = 1.50;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Apple Slices to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnLaysOB_Click(object sender, EventArgs e)
        {
            string sub = "Lays - Oven Baked Chips ";
            double price = 1.10;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Oven Baked Lays to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnLaysClassic_Click(object sender, EventArgs e)
        {
            string sub = "Lays - Classic ";
            double price = 1.10;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Classic Lays to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnDoritosNachoCheese_Click(object sender, EventArgs e)
        {
            string sub = "Doritos - Nacho Cheese ";
            double price = 1.10;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Nacho Cheese Doritos to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnDoritosCoolRanch_Click(object sender, EventArgs e)
        {
            string sub = "Doritos - Cool Ranch ";
            double price = 1.10;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Cool Ranch Doritos to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSunChipsHarvestCheddar_Click(object sender, EventArgs e)
        {
            string sub = "Sun Chips - Harvest Cheddar ";
            double price = 1.10;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Harvest Cheddar Sun Chips to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnCookies_Click(object sender, EventArgs e)
        {
            string sub = " - Fresh Baked ";
            double price = Convert.ToDouble(lblCookiesPrice.Text);
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add " + lblCookiesQuantity.Text + " to receipt?", "Sides", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(lblCookiesQuantity.Text + sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(lblCookiesQuantity.Text + sub))
                    {
                        if (s == lblCookiesQuantity.Text + sub)
                        {
                            lstTransaction.Items[i] = lblCookiesQuantity.Text + sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = lblCookiesQuantity.Text + sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(lblCookiesQuantity.Text + sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        #endregion
#region Cookies Trackbar Selection -> Complete
        private void trbCookies_Scroll(object sender, EventArgs e)
        {
            if (trbCookies.Value == 0)
            {
                lblCookiesPrice.Text = "0.65";
                lblCookiesQuantity.Text = "One Cookie";
            }
            else if (trbCookies.Value == 1)
            {
                lblCookiesPrice.Text = "1.70";
                lblCookiesQuantity.Text = "Three Cookies";
            }
            else if (trbCookies.Value > 1)
            {
                lblCookiesPrice.Text = "5.99";
                lblCookiesQuantity.Text = "Dozen Cookies";
            }
        }
        #endregion

#region Salads [Core 7] -> Complete
        private void btnChickenandBaconRanchMeltSalad_Click(object sender, EventArgs e)
        {
            string sub = "Chicken and Bacon Ranch Salad ";
            double price = 7.20;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Chicken and Bacon Ranch Melt to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnChickenPizziolaMeltSalad_Click(object sender, EventArgs e)
        {
            string sub = "Chicken Pizziola Salad ";
            double price = 7.49;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Chicken Pizziola Melt to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSweetOnionChickenTeriyakiSalad_Click(object sender, EventArgs e)
        {
            string sub = "SO Chicken Teriyaki Salad ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Sweet Onion Chicken Teriyaki to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnSteakandCheeseSalad_Click(object sender, EventArgs e)
        {
            string sub = "Steak & Cheese Salad ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Steak and Cheese to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnVeggieDeliteSalad_Click(object sender, EventArgs e)
        {
            string sub = "Veggie Delite Salad ";
            double price = 5.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Veggie Delite to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnTurkeyBreastandHamSalad_Click(object sender, EventArgs e)
        {
            string sub = "Turkey Breast & Ham Salad ";
            double price = 7.20;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Turkey Breast and Ham to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnTunaSalad_Click(object sender, EventArgs e)
        {
            string sub = "Tuna Salad ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Tuna to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        private void btnMeatballMarinaraSalad_Click(object sender, EventArgs e)
        {
            string sub = "Meatball Marinara Salad ";
            double price = 6.99;
            double total = Convert.ToDouble(txtTotal.Text);
            double totalwPrice = price + total;

            DialogResult confirm = (MessageBox.Show("Add Meatball Marinara to receipt?", "Salads", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (confirm == DialogResult.Yes)
            {
                string sprice = price.ToString("N");
                double totalwprice = price + total;
                var pattern = Regex.Escape(sub);
                bool isExist = false;
                for (int i = 0; i < lstTransaction.Items.Count; i++)
                {
                    var s = lstTransaction.Items[i].ToString();
                    if (s.StartsWith(sub))
                    {
                        if (s == sub)
                        {
                            lstTransaction.Items[i] = sub + "x2";
                            txtTotal.Text = totalwprice.ToString("N");
                            isExist = true;
                            break;
                        }
                        else
                        {
                            Match m = Regex.Match(s, "^" + pattern + @"x(\d+)$");
                            if (m.Success)
                            {
                                lstTransaction.Items[i] = sub + "x" + (Int32.Parse(m.Groups[1].Value) + 1);
                                txtTotal.Text = totalwprice.ToString("N");
                                isExist = true;
                                break;
                            }
                        }
                    }
                }
                if (!isExist)
                {
                    lstTransaction.Items.Add(sub);
                    lstPrice.Items.Add(sprice);
                    txtTotal.Text = totalwprice.ToString("N");
                }
            }
        }
        #endregion

#region Print -> Complete
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); 

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            } 
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float cash = float.Parse(Form3.returntendered);
            string change;

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); 

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("    SUBWAY - Eat Fresh!", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight;
            graphic.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            string totalprice = "$" + txtTax.Text;

            
            foreach (string prices in lstPrice.Items)
            {
                money = prices;

            }
            
            foreach (string item in lstTransaction.Items)
            {
                string products = item;
                
                    graphic.DrawString(products + " @ " + money, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 7;
            }
            double count = lstTransaction.Items.Count;

            change = Form3.returnchange;

            offset = offset + 22;
            graphic.DrawString("Unique Items: " + count, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 22;
            graphic.DrawString("HST ".PadRight(33) + String.Format("{0:c}", Form3.returnhst), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 17;
            graphic.DrawString("SUBTOTAL ".PadRight(33) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 22;
            graphic.DrawString("CASH ".PadRight(33) + String.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 17;
            graphic.DrawString("CHANGE ".PadRight(33) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 32;
            graphic.DrawString("      Thank-you for your purchase", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 17;
            graphic.DrawString("        Please eat again soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
#endregion

#region Closing and Data Transfer -> Complete
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?" + Environment.NewLine + "Any active receipt data will not be saved.", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Form1.First = false;
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog(); 
            }
        }
        #endregion

    }
}
#endregion
//Complete Saturday, Feburary 27, 2016 | Debugged and Tested Same Date
//Marked Tuesday, March 1, 2016 | 100% (+1 Overall)