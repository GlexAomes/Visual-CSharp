#region Transaction
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway_POS
{
    public partial class Form3 : Form
    {
        double Owingchange;
        double change;
        public Form3()

        
        {
            InitializeComponent();
        }
        public static string returnchange;
        public static string returntendered;
        public static string returnhst;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtOwing.Text = Form2.total.ToString("C");
            txtTax.Text = Form2.tax.ToString("C");
            txtChange.Text = "-" + Form2.total.ToString("C");
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            returnchange = txtChange.Text;
            returntendered = nudTendered.Text;
            returnhst = txtTax.Text;
            if (txtChange.Text.Contains("-$"))
            {
                MessageBox.Show("The customer still owes money!", "Invalid Change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            this.Close();
        }

        private void nudTendered_ValueChanged(object sender, EventArgs e)
        {
            double tendered = (double)(nudTendered.Value);
            double change = tendered - Form2.total;
            double Owingchange = Form2.total - tendered;
            if (tendered < Form2.total)
            {
                txtOwing.Text = Owingchange.ToString("C");
                txtChange.Text = "-" + Owingchange.ToString("C");
            }
            else
            {
                txtOwing.Text = Form2.total.ToString("C");
                txtChange.Text = change.ToString("C");
            }
        }
    }
}
#endregion