namespace Bootleg_Paint
{
    partial class Form2
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
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAlpha
            // 
            this.nudAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.12566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlpha.Location = new System.Drawing.Point(36, 73);
            this.nudAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(147, 80);
            this.nudAlpha.TabIndex = 0;
            this.nudAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAlpha.ValueChanged += new System.EventHandler(this.nudAlpha_ValueChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(78, 32);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(68, 26);
            this.lblAlpha.TabIndex = 4;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(262, 32);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(52, 26);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Red";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(439, 32);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(56, 26);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(617, 32);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(72, 26);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "Green";
            // 
            // nudRed
            // 
            this.nudRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.12566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRed.Location = new System.Drawing.Point(222, 73);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(147, 80);
            this.nudRed.TabIndex = 8;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // nudBlue
            // 
            this.nudBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.12566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBlue.Location = new System.Drawing.Point(404, 73);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(147, 80);
            this.nudBlue.TabIndex = 9;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudBlue_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.12566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGreen.Location = new System.Drawing.Point(595, 73);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(147, 80);
            this.nudGreen.TabIndex = 10;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudGreen_ValueChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(83, 273);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(264, 62);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "&Ok";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(264, 62);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.Black;
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPreview.Location = new System.Drawing.Point(272, 194);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(222, 50);
            this.pnlPreview.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 347);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.nudAlpha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Colors";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlPreview;
    }
}