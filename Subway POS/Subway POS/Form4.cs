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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            prgSplash.Increment(1);
            lblLoading.Text = "Loading Point of Sale - " + prgSplash.Value.ToString() + "%";
            if (prgSplash.Value == 100)
            {
                tmrSplash.Stop();
            }
        }

        private void tmrTooMuchFreeTime_Tick(object sender, EventArgs e)
        {
            var colors = new[] { Color.Red, Color.Orange, Color.Gold, Color.Green, Color.Cyan, Color.Blue, Color.Purple };
            var index = DateTime.Now.Millisecond % colors.Length;
            prgSplash.ForeColor = colors[index];
            if (prgSplash.Value == 100)
            {
                tmrTooMuchFreeTime.Stop();
            }
        }
    }
}
