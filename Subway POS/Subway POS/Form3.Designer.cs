namespace Subway_POS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtOwing = new System.Windows.Forms.TextBox();
            this.lblOwing = new System.Windows.Forms.Label();
            this.lblTendered = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.nudTendered = new System.Windows.Forms.NumericUpDown();
            this.lblDolladolla = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTendered)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOwing
            // 
            this.txtOwing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.83246F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwing.ForeColor = System.Drawing.Color.Black;
            this.txtOwing.Location = new System.Drawing.Point(82, 89);
            this.txtOwing.Name = "txtOwing";
            this.txtOwing.ReadOnly = true;
            this.txtOwing.Size = new System.Drawing.Size(283, 55);
            this.txtOwing.TabIndex = 0;
            this.txtOwing.TabStop = false;
            // 
            // lblOwing
            // 
            this.lblOwing.AutoSize = true;
            this.lblOwing.BackColor = System.Drawing.Color.Transparent;
            this.lblOwing.ForeColor = System.Drawing.Color.Black;
            this.lblOwing.Location = new System.Drawing.Point(148, 60);
            this.lblOwing.Name = "lblOwing";
            this.lblOwing.Size = new System.Drawing.Size(145, 26);
            this.lblOwing.TabIndex = 2;
            this.lblOwing.Text = "Money Owing";
            // 
            // lblTendered
            // 
            this.lblTendered.AutoSize = true;
            this.lblTendered.BackColor = System.Drawing.Color.Transparent;
            this.lblTendered.ForeColor = System.Drawing.Color.Black;
            this.lblTendered.Location = new System.Drawing.Point(136, 194);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.Size = new System.Drawing.Size(174, 26);
            this.lblTendered.TabIndex = 3;
            this.lblTendered.Text = "Money Tendered";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(178, 329);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(88, 26);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.83246F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.Location = new System.Drawing.Point(82, 358);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(283, 55);
            this.txtChange.TabIndex = 0;
            this.txtChange.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(141, 525);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(169, 64);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return to POS";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // nudTendered
            // 
            this.nudTendered.DecimalPlaces = 2;
            this.nudTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.83246F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTendered.ForeColor = System.Drawing.Color.Black;
            this.nudTendered.Location = new System.Drawing.Point(122, 242);
            this.nudTendered.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTendered.Name = "nudTendered";
            this.nudTendered.Size = new System.Drawing.Size(199, 55);
            this.nudTendered.TabIndex = 0;
            this.nudTendered.ValueChanged += new System.EventHandler(this.nudTendered_ValueChanged);
            // 
            // lblDolladolla
            // 
            this.lblDolladolla.AutoSize = true;
            this.lblDolladolla.BackColor = System.Drawing.Color.Transparent;
            this.lblDolladolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.83246F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolladolla.ForeColor = System.Drawing.Color.Black;
            this.lblDolladolla.Location = new System.Drawing.Point(70, 244);
            this.lblDolladolla.Name = "lblDolladolla";
            this.lblDolladolla.Size = new System.Drawing.Size(43, 48);
            this.lblDolladolla.TabIndex = 8;
            this.lblDolladolla.Text = "$";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.83246F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.ForeColor = System.Drawing.Color.Black;
            this.txtTax.Location = new System.Drawing.Point(82, 464);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(283, 55);
            this.txtTax.TabIndex = 1;
            this.txtTax.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(192, 435);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(55, 26);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "HST";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::Subway_POS.Properties.Resources.Subway_Background;
            this.ClientSize = new System.Drawing.Size(452, 601);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblDolladolla);
            this.Controls.Add(this.nudTendered);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblTendered);
            this.Controls.Add(this.lblOwing);
            this.Controls.Add(this.txtOwing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction in Progress";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTendered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOwing;
        private System.Windows.Forms.Label lblOwing;
        private System.Windows.Forms.Label lblTendered;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown nudTendered;
        private System.Windows.Forms.Label lblDolladolla;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
    }
}