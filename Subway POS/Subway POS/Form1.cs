#region Login for Subway POS
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

namespace Subway_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            if (First == true)
            {
                Thread T = new Thread(new ThreadStart(SplashStart));
                T.Start();
                Thread.Sleep(4000);
                T.Abort();
            }
            
            System.Windows.Forms.Application.EnableVisualStyles();
            txtPass.PasswordChar = '\u0007'; //Char ID for ASCII-Bell
        }

        public static bool First = true;

        public void SplashStart()
        {
            Application.Run(new Form4());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Login and checker
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Subway" && txtPass.Text == "eatfresh")
            {
                this.Hide();
                Form2 Frm2 = new Form2();
                Frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtUser.Text == "Subway" && txtPass.Text == "eatfresh")
                {
                    this.Hide();
                    Form2 Frm2 = new Form2();
                    Frm2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please check your username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }  
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtUser.Text == "Subway" && txtPass.Text == "eatfresh")
                {
                    this.Hide();
                    Form2 Frm2 = new Form2();
                    Frm2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please check your username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        #endregion

    }
}
#endregion