using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootleg_Paint
{
    public partial class Form2 : Form
    {
        public static bool ok;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nudAlpha.Value = Form1.a;
            nudRed.Value = Form1.r;
            nudGreen.Value = Form1.g;
            nudBlue.Value = Form1.b;
        }

        private void nudAlpha_ValueChanged(object sender, EventArgs e)
        {
            Form1.a = Convert.ToInt32(nudAlpha.Value);
            pnlPreview.BackColor = Color.FromArgb(Form1.a, Form1.r, Form1.g, Form1.b);
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            Form1.r = Convert.ToInt32(nudRed.Value);
            pnlPreview.BackColor = Color.FromArgb(Form1.a, Form1.r, Form1.g, Form1.b);
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            Form1.b = Convert.ToInt32(nudBlue.Value);
            pnlPreview.BackColor = Color.FromArgb(Form1.a, Form1.r, Form1.g, Form1.b);
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            Form1.g = Convert.ToInt32(nudGreen.Value);
            pnlPreview.BackColor = Color.FromArgb(Form1.a, Form1.r, Form1.g, Form1.b);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }
    }
}
