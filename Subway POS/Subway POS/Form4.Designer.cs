namespace Subway_POS
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.pboSplash = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.tmrTooMuchFreeTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pboSplash
            // 
            this.pboSplash.Image = global::Subway_POS.Properties.Resources.SubwayLarge_with_slogan;
            this.pboSplash.Location = new System.Drawing.Point(82, 12);
            this.pboSplash.Name = "pboSplash";
            this.pboSplash.Size = new System.Drawing.Size(530, 261);
            this.pboSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboSplash.TabIndex = 0;
            this.pboSplash.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(229, 362);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(0, 26);
            this.lblLoading.TabIndex = 1;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 20;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // prgSplash
            // 
            this.prgSplash.ForeColor = System.Drawing.Color.DarkGreen;
            this.prgSplash.Location = new System.Drawing.Point(12, 312);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(709, 36);
            this.prgSplash.Step = 35;
            this.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgSplash.TabIndex = 2;
            // 
            // tmrTooMuchFreeTime
            // 
            this.tmrTooMuchFreeTime.Enabled = true;
            this.tmrTooMuchFreeTime.Tick += new System.EventHandler(this.tmrTooMuchFreeTime_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(733, 418);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pboSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pboSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboSplash;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer tmrTooMuchFreeTime;
    }
}