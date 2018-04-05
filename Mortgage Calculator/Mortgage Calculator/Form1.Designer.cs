namespace Mortgage_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.BtnCloseTb1 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.nudDownPayment = new System.Windows.Forms.NumericUpDown();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudInsurance = new System.Windows.Forms.NumericUpDown();
            this.nudPropertyTax = new System.Windows.Forms.NumericUpDown();
            this.btnCloseHelp = new System.Windows.Forms.Button();
            this.btnHelpOptionals = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtPaymentwithInterest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.lblMortgageCalc = new System.Windows.Forms.Label();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.nudPrincipal = new System.Windows.Forms.NumericUpDown();
            this.nudTerm = new System.Windows.Forms.NumericUpDown();
            this.lstFreq = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblPropertyTax = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.nudInterest = new System.Windows.Forms.NumericUpDown();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnLifestyleControls = new System.Windows.Forms.Button();
            this.trbInterest = new System.Windows.Forms.TrackBar();
            this.trbTerm = new System.Windows.Forms.TrackBar();
            this.tabPersonalize = new System.Windows.Forms.TabPage();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.lstVoice = new System.Windows.Forms.ListBox();
            this.lblPersonalizationDesc = new System.Windows.Forms.Label();
            this.lblPersonalization = new System.Windows.Forms.Label();
            this.BtnReturntoCalc = new System.Windows.Forms.Button();
            this.BtnTextColor = new System.Windows.Forms.Button();
            this.BtnButtonColor = new System.Windows.Forms.Button();
            this.BtnBackColor = new System.Windows.Forms.Button();
            this.tabHelpOptionals = new System.Windows.Forms.TabPage();
            this.lblInsuranceTitle = new System.Windows.Forms.Label();
            this.lblPropertyTaxTitle = new System.Windows.Forms.Label();
            this.lblDownpaymenttitle = new System.Windows.Forms.Label();
            this.lblPropertytaxexplained = new System.Windows.Forms.Label();
            this.lblHelpOptionals = new System.Windows.Forms.Label();
            this.lblInsuranceexplained = new System.Windows.Forms.Label();
            this.btnReturnfromHelpOptionals = new System.Windows.Forms.Button();
            this.lblDownpaymentexplained = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbcMain.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPropertyTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTerm)).BeginInit();
            this.tabPersonalize.SuspendLayout();
            this.tabHelpOptionals.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabWelcome);
            this.tbcMain.Controls.Add(this.tabCalculator);
            this.tbcMain.Controls.Add(this.tabPersonalize);
            this.tbcMain.Controls.Add(this.tabHelpOptionals);
            this.tbcMain.Location = new System.Drawing.Point(2, -61);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1108, 853);
            this.tbcMain.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabWelcome.Controls.Add(this.pictureBox1);
            this.tabWelcome.Controls.Add(this.lblCopyright);
            this.tabWelcome.Controls.Add(this.BtnCloseTb1);
            this.tabWelcome.Controls.Add(this.lblWelcome);
            this.tabWelcome.Controls.Add(this.BtnStart);
            this.tabWelcome.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabWelcome.Location = new System.Drawing.Point(4, 34);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(1100, 751);
            this.tabWelcome.TabIndex = 1;
            this.tabWelcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mortgage_Calculator.Properties.Resources.CalcMoney;
            this.pictureBox1.Location = new System.Drawing.Point(319, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(820, 32);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(274, 26);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Application by Alex Gomes";
            // 
            // BtnCloseTb1
            // 
            this.BtnCloseTb1.BackColor = System.Drawing.Color.Gold;
            this.BtnCloseTb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCloseTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnCloseTb1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnCloseTb1.Location = new System.Drawing.Point(896, 599);
            this.BtnCloseTb1.Name = "BtnCloseTb1";
            this.BtnCloseTb1.Size = new System.Drawing.Size(198, 184);
            this.BtnCloseTb1.TabIndex = 2;
            this.BtnCloseTb1.TabStop = false;
            this.BtnCloseTb1.Text = "Quit";
            this.BtnCloseTb1.UseVisualStyleBackColor = false;
            this.BtnCloseTb1.Click += new System.EventHandler(this.BtnCloseTb1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblWelcome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblWelcome.Location = new System.Drawing.Point(90, 132);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(932, 63);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to your Mortgage Calculator";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Gold;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnStart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.Location = new System.Drawing.Point(6, 599);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(884, 184);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "Launch Calculator";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tabCalculator
            // 
            this.tabCalculator.BackColor = System.Drawing.Color.Ivory;
            this.tabCalculator.Controls.Add(this.btnAbout);
            this.tabCalculator.Controls.Add(this.nudDownPayment);
            this.tabCalculator.Controls.Add(this.lblPercent);
            this.tabCalculator.Controls.Add(this.lblYears);
            this.tabCalculator.Controls.Add(this.label1);
            this.tabCalculator.Controls.Add(this.nudInsurance);
            this.tabCalculator.Controls.Add(this.nudPropertyTax);
            this.tabCalculator.Controls.Add(this.btnCloseHelp);
            this.tabCalculator.Controls.Add(this.btnHelpOptionals);
            this.tabCalculator.Controls.Add(this.lblHelp);
            this.tabCalculator.Controls.Add(this.txtPaymentwithInterest);
            this.tabCalculator.Controls.Add(this.label3);
            this.tabCalculator.Controls.Add(this.btnHelp);
            this.tabCalculator.Controls.Add(this.lblFreq);
            this.tabCalculator.Controls.Add(this.lblOptional);
            this.tabCalculator.Controls.Add(this.lblMortgageCalc);
            this.tabCalculator.Controls.Add(this.lblRequirements);
            this.tabCalculator.Controls.Add(this.nudPrincipal);
            this.tabCalculator.Controls.Add(this.nudTerm);
            this.tabCalculator.Controls.Add(this.lstFreq);
            this.tabCalculator.Controls.Add(this.btnCalculate);
            this.tabCalculator.Controls.Add(this.lblInsurance);
            this.tabCalculator.Controls.Add(this.label2);
            this.tabCalculator.Controls.Add(this.lblTerm);
            this.tabCalculator.Controls.Add(this.lblInterest);
            this.tabCalculator.Controls.Add(this.lblDownPayment);
            this.tabCalculator.Controls.Add(this.lblPropertyTax);
            this.tabCalculator.Controls.Add(this.lblPrincipal);
            this.tabCalculator.Controls.Add(this.txtPayment);
            this.tabCalculator.Controls.Add(this.nudInterest);
            this.tabCalculator.Controls.Add(this.BtnQuit);
            this.tabCalculator.Controls.Add(this.BtnLifestyleControls);
            this.tabCalculator.Controls.Add(this.trbInterest);
            this.tabCalculator.Controls.Add(this.trbTerm);
            this.tabCalculator.Location = new System.Drawing.Point(4, 34);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(1100, 815);
            this.tabCalculator.TabIndex = 2;
            this.tabCalculator.Text = "Calculator";
            this.tabCalculator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabCalculator_MouseMove);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAbout.Location = new System.Drawing.Point(400, 714);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(164, 72);
            this.btnAbout.TabIndex = 39;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // nudDownPayment
            // 
            this.nudDownPayment.DecimalPlaces = 2;
            this.nudDownPayment.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDownPayment.Location = new System.Drawing.Point(759, 153);
            this.nudDownPayment.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDownPayment.Name = "nudDownPayment";
            this.nudDownPayment.Size = new System.Drawing.Size(281, 31);
            this.nudDownPayment.TabIndex = 38;
            this.nudDownPayment.ThousandsSeparator = true;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPercent.Location = new System.Drawing.Point(431, 258);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(32, 26);
            this.lblPercent.TabIndex = 36;
            this.lblPercent.Text = "%";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYears.Location = new System.Drawing.Point(431, 384);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(60, 26);
            this.lblYears.TabIndex = 37;
            this.lblYears.Text = "Yr(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Debugging:";
            this.label1.Visible = false;
            // 
            // nudInsurance
            // 
            this.nudInsurance.DecimalPlaces = 2;
            this.nudInsurance.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudInsurance.Location = new System.Drawing.Point(759, 268);
            this.nudInsurance.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudInsurance.Name = "nudInsurance";
            this.nudInsurance.Size = new System.Drawing.Size(281, 31);
            this.nudInsurance.TabIndex = 34;
            this.nudInsurance.ThousandsSeparator = true;
            // 
            // nudPropertyTax
            // 
            this.nudPropertyTax.DecimalPlaces = 2;
            this.nudPropertyTax.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPropertyTax.Location = new System.Drawing.Point(759, 211);
            this.nudPropertyTax.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPropertyTax.Name = "nudPropertyTax";
            this.nudPropertyTax.Size = new System.Drawing.Size(281, 31);
            this.nudPropertyTax.TabIndex = 33;
            this.nudPropertyTax.ThousandsSeparator = true;
            // 
            // btnCloseHelp
            // 
            this.btnCloseHelp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCloseHelp.Location = new System.Drawing.Point(828, 593);
            this.btnCloseHelp.Name = "btnCloseHelp";
            this.btnCloseHelp.Size = new System.Drawing.Size(143, 63);
            this.btnCloseHelp.TabIndex = 31;
            this.btnCloseHelp.TabStop = false;
            this.btnCloseHelp.Text = "Close Help";
            this.btnCloseHelp.UseVisualStyleBackColor = false;
            this.btnCloseHelp.Visible = false;
            this.btnCloseHelp.Click += new System.EventHandler(this.btnCloseHelp_Click);
            // 
            // btnHelpOptionals
            // 
            this.btnHelpOptionals.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHelpOptionals.Location = new System.Drawing.Point(558, 593);
            this.btnHelpOptionals.Name = "btnHelpOptionals";
            this.btnHelpOptionals.Size = new System.Drawing.Size(239, 63);
            this.btnHelpOptionals.TabIndex = 30;
            this.btnHelpOptionals.TabStop = false;
            this.btnHelpOptionals.Text = "What are optionals?";
            this.btnHelpOptionals.UseVisualStyleBackColor = false;
            this.btnHelpOptionals.Visible = false;
            this.btnHelpOptionals.Click += new System.EventHandler(this.btnHelpOptionals_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(553, 363);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(478, 208);
            this.lblHelp.TabIndex = 29;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            this.lblHelp.Visible = false;
            // 
            // txtPaymentwithInterest
            // 
            this.txtPaymentwithInterest.Enabled = false;
            this.txtPaymentwithInterest.Location = new System.Drawing.Point(210, 705);
            this.txtPaymentwithInterest.Name = "txtPaymentwithInterest";
            this.txtPaymentwithInterest.Size = new System.Drawing.Size(183, 31);
            this.txtPaymentwithInterest.TabIndex = 28;
            this.txtPaymentwithInterest.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total with interest";
            this.label3.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHelp.Location = new System.Drawing.Point(570, 714);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(164, 72);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(92, 454);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(114, 52);
            this.lblFreq.TabIndex = 25;
            this.lblFreq.Text = "Payment\r\nFrequency";
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.BackColor = System.Drawing.Color.Transparent;
            this.lblOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.Location = new System.Drawing.Point(717, 103);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(172, 26);
            this.lblOptional.TabIndex = 23;
            this.lblOptional.Text = "Optional Fields";
            // 
            // lblMortgageCalc
            // 
            this.lblMortgageCalc.AutoSize = true;
            this.lblMortgageCalc.BackColor = System.Drawing.Color.Transparent;
            this.lblMortgageCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMortgageCalc.ForeColor = System.Drawing.Color.Black;
            this.lblMortgageCalc.Location = new System.Drawing.Point(267, 18);
            this.lblMortgageCalc.Name = "lblMortgageCalc";
            this.lblMortgageCalc.Size = new System.Drawing.Size(514, 63);
            this.lblMortgageCalc.TabIndex = 22;
            this.lblMortgageCalc.Text = "Mortgage Calculator";
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.BackColor = System.Drawing.Color.Transparent;
            this.lblRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirements.Location = new System.Drawing.Point(214, 103);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(179, 26);
            this.lblRequirements.TabIndex = 21;
            this.lblRequirements.Text = "Required Fields";
            // 
            // nudPrincipal
            // 
            this.nudPrincipal.DecimalPlaces = 2;
            this.nudPrincipal.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrincipal.Location = new System.Drawing.Point(219, 158);
            this.nudPrincipal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrincipal.Name = "nudPrincipal";
            this.nudPrincipal.Size = new System.Drawing.Size(281, 31);
            this.nudPrincipal.TabIndex = 20;
            this.nudPrincipal.ThousandsSeparator = true;
            this.nudPrincipal.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrincipal.Leave += new System.EventHandler(this.nudPrincipal_Leave);
            // 
            // nudTerm
            // 
            this.nudTerm.Location = new System.Drawing.Point(305, 379);
            this.nudTerm.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTerm.Name = "nudTerm";
            this.nudTerm.Size = new System.Drawing.Size(120, 31);
            this.nudTerm.TabIndex = 6;
            this.nudTerm.ValueChanged += new System.EventHandler(this.nudTerm_ValueChanged);
            // 
            // lstFreq
            // 
            this.lstFreq.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstFreq.FormattingEnabled = true;
            this.lstFreq.ItemHeight = 25;
            this.lstFreq.Items.AddRange(new object[] {
            "\t Monthly",
            "\t Weekly",
            "               Bi-Weekly"});
            this.lstFreq.Location = new System.Drawing.Point(219, 442);
            this.lstFreq.Name = "lstFreq";
            this.lstFreq.Size = new System.Drawing.Size(281, 79);
            this.lstFreq.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalculate.Location = new System.Drawing.Point(219, 543);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(281, 76);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(646, 270);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(107, 26);
            this.lblInsurance.TabIndex = 15;
            this.lblInsurance.Text = "Insurance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Payment";
            this.label2.Visible = false;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(72, 363);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(134, 26);
            this.lblTerm.TabIndex = 12;
            this.lblTerm.Text = "Amortization";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(122, 253);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(84, 26);
            this.lblInterest.TabIndex = 11;
            this.lblInterest.Text = "Interest";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(574, 155);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(179, 26);
            this.lblDownPayment.TabIndex = 10;
            this.lblDownPayment.Text = "Down Payment $";
            // 
            // lblPropertyTax
            // 
            this.lblPropertyTax.AutoSize = true;
            this.lblPropertyTax.Location = new System.Drawing.Point(618, 213);
            this.lblPropertyTax.Name = "lblPropertyTax";
            this.lblPropertyTax.Size = new System.Drawing.Size(135, 26);
            this.lblPropertyTax.TabIndex = 9;
            this.lblPropertyTax.Text = "Property Tax";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.Location = new System.Drawing.Point(99, 160);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(114, 26);
            this.lblPrincipal.TabIndex = 8;
            this.lblPrincipal.Text = "Principal $";
            // 
            // txtPayment
            // 
            this.txtPayment.Enabled = false;
            this.txtPayment.Location = new System.Drawing.Point(219, 663);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(281, 31);
            this.txtPayment.TabIndex = 7;
            this.txtPayment.Visible = false;
            // 
            // nudInterest
            // 
            this.nudInterest.DecimalPlaces = 2;
            this.nudInterest.Location = new System.Drawing.Point(305, 253);
            this.nudInterest.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudInterest.Name = "nudInterest";
            this.nudInterest.Size = new System.Drawing.Size(120, 31);
            this.nudInterest.TabIndex = 5;
            this.nudInterest.ValueChanged += new System.EventHandler(this.nudInterest_ValueChanged);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnQuit.Location = new System.Drawing.Point(924, 714);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(166, 72);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.TabStop = false;
            this.BtnQuit.Text = "Quit Calculator";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnLifestyleControls
            // 
            this.BtnLifestyleControls.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnLifestyleControls.Location = new System.Drawing.Point(740, 714);
            this.BtnLifestyleControls.Name = "BtnLifestyleControls";
            this.BtnLifestyleControls.Size = new System.Drawing.Size(178, 72);
            this.BtnLifestyleControls.TabIndex = 0;
            this.BtnLifestyleControls.TabStop = false;
            this.BtnLifestyleControls.Text = "Personalization Controls";
            this.BtnLifestyleControls.UseVisualStyleBackColor = false;
            this.BtnLifestyleControls.Click += new System.EventHandler(this.BtnLifestyleControls_Click);
            // 
            // trbInterest
            // 
            this.trbInterest.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.trbInterest.Location = new System.Drawing.Point(219, 204);
            this.trbInterest.Maximum = 25;
            this.trbInterest.Name = "trbInterest";
            this.trbInterest.Size = new System.Drawing.Size(281, 90);
            this.trbInterest.TabIndex = 19;
            this.trbInterest.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbInterest.ValueChanged += new System.EventHandler(this.trbInterest_ValueChanged);
            // 
            // trbTerm
            // 
            this.trbTerm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.trbTerm.Location = new System.Drawing.Point(219, 330);
            this.trbTerm.Maximum = 30;
            this.trbTerm.Name = "trbTerm";
            this.trbTerm.Size = new System.Drawing.Size(281, 90);
            this.trbTerm.TabIndex = 18;
            this.trbTerm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTerm.ValueChanged += new System.EventHandler(this.trbTerm_ValueChanged);
            // 
            // tabPersonalize
            // 
            this.tabPersonalize.BackColor = System.Drawing.Color.Ivory;
            this.tabPersonalize.Controls.Add(this.lblSpeaker);
            this.tabPersonalize.Controls.Add(this.cbVoice);
            this.tabPersonalize.Controls.Add(this.lblVoice);
            this.tabPersonalize.Controls.Add(this.lstVoice);
            this.tabPersonalize.Controls.Add(this.lblPersonalizationDesc);
            this.tabPersonalize.Controls.Add(this.lblPersonalization);
            this.tabPersonalize.Controls.Add(this.BtnReturntoCalc);
            this.tabPersonalize.Controls.Add(this.BtnTextColor);
            this.tabPersonalize.Controls.Add(this.BtnButtonColor);
            this.tabPersonalize.Controls.Add(this.BtnBackColor);
            this.tabPersonalize.Location = new System.Drawing.Point(4, 34);
            this.tabPersonalize.Name = "tabPersonalize";
            this.tabPersonalize.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalize.Size = new System.Drawing.Size(1100, 815);
            this.tabPersonalize.TabIndex = 3;
            this.tabPersonalize.Text = "Personalization";
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Location = new System.Drawing.Point(735, 465);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(93, 26);
            this.lblSpeaker.TabIndex = 34;
            this.lblSpeaker.Text = "Speaker";
            // 
            // cbVoice
            // 
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(640, 494);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(288, 33);
            this.cbVoice.TabIndex = 33;
            this.cbVoice.SelectedIndexChanged += new System.EventHandler(this.cbVoice_SelectedIndexChanged);
            this.cbVoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbVoice_KeyPress);
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(716, 333);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(148, 26);
            this.lblVoice.TabIndex = 32;
            this.lblVoice.Text = "Voice Options";
            // 
            // lstVoice
            // 
            this.lstVoice.FormattingEnabled = true;
            this.lstVoice.ItemHeight = 25;
            this.lstVoice.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.lstVoice.Location = new System.Drawing.Point(721, 373);
            this.lstVoice.Name = "lstVoice";
            this.lstVoice.Size = new System.Drawing.Size(120, 54);
            this.lstVoice.TabIndex = 31;
            this.lstVoice.SelectedIndexChanged += new System.EventHandler(this.lstVoice_SelectedIndexChanged);
            // 
            // lblPersonalizationDesc
            // 
            this.lblPersonalizationDesc.AutoSize = true;
            this.lblPersonalizationDesc.Location = new System.Drawing.Point(247, 115);
            this.lblPersonalizationDesc.Name = "lblPersonalizationDesc";
            this.lblPersonalizationDesc.Size = new System.Drawing.Size(617, 26);
            this.lblPersonalizationDesc.TabIndex = 30;
            this.lblPersonalizationDesc.Text = "This is your calculator, make it look the way you want it to look!";
            // 
            // lblPersonalization
            // 
            this.lblPersonalization.AutoSize = true;
            this.lblPersonalization.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPersonalization.ForeColor = System.Drawing.Color.Black;
            this.lblPersonalization.Location = new System.Drawing.Point(352, 23);
            this.lblPersonalization.Name = "lblPersonalization";
            this.lblPersonalization.Size = new System.Drawing.Size(399, 63);
            this.lblPersonalization.TabIndex = 23;
            this.lblPersonalization.Text = "Personalization";
            // 
            // BtnReturntoCalc
            // 
            this.BtnReturntoCalc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnReturntoCalc.Location = new System.Drawing.Point(206, 585);
            this.BtnReturntoCalc.Name = "BtnReturntoCalc";
            this.BtnReturntoCalc.Size = new System.Drawing.Size(288, 102);
            this.BtnReturntoCalc.TabIndex = 3;
            this.BtnReturntoCalc.Text = "Return to Calculator";
            this.BtnReturntoCalc.UseVisualStyleBackColor = false;
            this.BtnReturntoCalc.Click += new System.EventHandler(this.BtnReturntoCalc_Click);
            // 
            // BtnTextColor
            // 
            this.BtnTextColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnTextColor.Location = new System.Drawing.Point(206, 411);
            this.BtnTextColor.Name = "BtnTextColor";
            this.BtnTextColor.Size = new System.Drawing.Size(288, 102);
            this.BtnTextColor.TabIndex = 2;
            this.BtnTextColor.Text = "Change Text Color";
            this.BtnTextColor.UseVisualStyleBackColor = false;
            this.BtnTextColor.Click += new System.EventHandler(this.BtnTextColor_Click);
            // 
            // BtnButtonColor
            // 
            this.BtnButtonColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnButtonColor.Location = new System.Drawing.Point(206, 303);
            this.BtnButtonColor.Name = "BtnButtonColor";
            this.BtnButtonColor.Size = new System.Drawing.Size(288, 102);
            this.BtnButtonColor.TabIndex = 1;
            this.BtnButtonColor.Text = "Change Button Colors";
            this.BtnButtonColor.UseVisualStyleBackColor = false;
            this.BtnButtonColor.Click += new System.EventHandler(this.BtnButtonColor_Click);
            // 
            // BtnBackColor
            // 
            this.BtnBackColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnBackColor.Location = new System.Drawing.Point(206, 195);
            this.BtnBackColor.Name = "BtnBackColor";
            this.BtnBackColor.Size = new System.Drawing.Size(288, 102);
            this.BtnBackColor.TabIndex = 0;
            this.BtnBackColor.Text = "Change BackColor";
            this.BtnBackColor.UseVisualStyleBackColor = false;
            this.BtnBackColor.Click += new System.EventHandler(this.BtnBackColor_Click);
            // 
            // tabHelpOptionals
            // 
            this.tabHelpOptionals.BackColor = System.Drawing.Color.Ivory;
            this.tabHelpOptionals.Controls.Add(this.lblInsuranceTitle);
            this.tabHelpOptionals.Controls.Add(this.lblPropertyTaxTitle);
            this.tabHelpOptionals.Controls.Add(this.lblDownpaymenttitle);
            this.tabHelpOptionals.Controls.Add(this.lblPropertytaxexplained);
            this.tabHelpOptionals.Controls.Add(this.lblHelpOptionals);
            this.tabHelpOptionals.Controls.Add(this.lblInsuranceexplained);
            this.tabHelpOptionals.Controls.Add(this.btnReturnfromHelpOptionals);
            this.tabHelpOptionals.Controls.Add(this.lblDownpaymentexplained);
            this.tabHelpOptionals.Location = new System.Drawing.Point(4, 34);
            this.tabHelpOptionals.Name = "tabHelpOptionals";
            this.tabHelpOptionals.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelpOptionals.Size = new System.Drawing.Size(1100, 815);
            this.tabHelpOptionals.TabIndex = 4;
            this.tabHelpOptionals.Text = "HelpOptionals";
            // 
            // lblInsuranceTitle
            // 
            this.lblInsuranceTitle.AutoSize = true;
            this.lblInsuranceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceTitle.Location = new System.Drawing.Point(29, 437);
            this.lblInsuranceTitle.Name = "lblInsuranceTitle";
            this.lblInsuranceTitle.Size = new System.Drawing.Size(322, 26);
            this.lblInsuranceTitle.TabIndex = 37;
            this.lblInsuranceTitle.Text = "What is mortgage insurance?";
            // 
            // lblPropertyTaxTitle
            // 
            this.lblPropertyTaxTitle.AutoSize = true;
            this.lblPropertyTaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyTaxTitle.Location = new System.Drawing.Point(29, 257);
            this.lblPropertyTaxTitle.Name = "lblPropertyTaxTitle";
            this.lblPropertyTaxTitle.Size = new System.Drawing.Size(238, 26);
            this.lblPropertyTaxTitle.TabIndex = 36;
            this.lblPropertyTaxTitle.Text = "What is property tax?";
            // 
            // lblDownpaymenttitle
            // 
            this.lblDownpaymenttitle.AutoSize = true;
            this.lblDownpaymenttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownpaymenttitle.Location = new System.Drawing.Point(29, 100);
            this.lblDownpaymenttitle.Name = "lblDownpaymenttitle";
            this.lblDownpaymenttitle.Size = new System.Drawing.Size(266, 26);
            this.lblDownpaymenttitle.TabIndex = 35;
            this.lblDownpaymenttitle.Text = "What is down payment?";
            // 
            // lblPropertytaxexplained
            // 
            this.lblPropertytaxexplained.AutoSize = true;
            this.lblPropertytaxexplained.Location = new System.Drawing.Point(29, 257);
            this.lblPropertytaxexplained.Name = "lblPropertytaxexplained";
            this.lblPropertytaxexplained.Size = new System.Drawing.Size(977, 130);
            this.lblPropertytaxexplained.TabIndex = 34;
            this.lblPropertytaxexplained.Text = resources.GetString("lblPropertytaxexplained.Text");
            // 
            // lblHelpOptionals
            // 
            this.lblHelpOptionals.AutoSize = true;
            this.lblHelpOptionals.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpOptionals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHelpOptionals.ForeColor = System.Drawing.Color.Black;
            this.lblHelpOptionals.Location = new System.Drawing.Point(351, 16);
            this.lblHelpOptionals.Name = "lblHelpOptionals";
            this.lblHelpOptionals.Size = new System.Drawing.Size(383, 63);
            this.lblHelpOptionals.TabIndex = 33;
            this.lblHelpOptionals.Text = "Optionals Help";
            // 
            // lblInsuranceexplained
            // 
            this.lblInsuranceexplained.AutoSize = true;
            this.lblInsuranceexplained.Location = new System.Drawing.Point(29, 437);
            this.lblInsuranceexplained.Name = "lblInsuranceexplained";
            this.lblInsuranceexplained.Size = new System.Drawing.Size(1026, 104);
            this.lblInsuranceexplained.TabIndex = 32;
            this.lblInsuranceexplained.Text = "\r\n\r\nMortgage insurance is a insurance policy that is usually required if your dow" +
    "n payment is between 5-20%.\r\nThe policy covers any losses between the loaner (yo" +
    "u) and the borrower (your bank/agent).";
            // 
            // btnReturnfromHelpOptionals
            // 
            this.btnReturnfromHelpOptionals.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReturnfromHelpOptionals.Location = new System.Drawing.Point(372, 609);
            this.btnReturnfromHelpOptionals.Name = "btnReturnfromHelpOptionals";
            this.btnReturnfromHelpOptionals.Size = new System.Drawing.Size(288, 102);
            this.btnReturnfromHelpOptionals.TabIndex = 31;
            this.btnReturnfromHelpOptionals.Text = "Return to Calculator";
            this.btnReturnfromHelpOptionals.UseVisualStyleBackColor = false;
            this.btnReturnfromHelpOptionals.Click += new System.EventHandler(this.btnReturnfromHelpOptionals_Click);
            // 
            // lblDownpaymentexplained
            // 
            this.lblDownpaymentexplained.AutoSize = true;
            this.lblDownpaymentexplained.Location = new System.Drawing.Point(29, 100);
            this.lblDownpaymentexplained.Name = "lblDownpaymentexplained";
            this.lblDownpaymentexplained.Size = new System.Drawing.Size(833, 104);
            this.lblDownpaymentexplained.TabIndex = 30;
            this.lblDownpaymentexplained.Text = "\r\n\r\nDown payment is an one-time payment made prior to your mortgage payment perio" +
    "d.\r\nDown payment is usually required to be at least 5-20% of your principal.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 793);
            this.Controls.Add(this.tbcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMain.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPropertyTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTerm)).EndInit();
            this.tabPersonalize.ResumeLayout(false);
            this.tabPersonalize.PerformLayout();
            this.tabHelpOptionals.ResumeLayout(false);
            this.tabHelpOptionals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TabPage tabCalculator;
        private System.Windows.Forms.Button BtnCloseTb1;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnLifestyleControls;
        private System.Windows.Forms.TabPage tabPersonalize;
        private System.Windows.Forms.Button BtnReturntoCalc;
        private System.Windows.Forms.Button BtnTextColor;
        private System.Windows.Forms.Button BtnButtonColor;
        private System.Windows.Forms.Button BtnBackColor;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblPropertyTax;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.NumericUpDown nudTerm;
        private System.Windows.Forms.NumericUpDown nudInterest;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstFreq;
        private System.Windows.Forms.TrackBar trbTerm;
        private System.Windows.Forms.TrackBar trbInterest;
        private System.Windows.Forms.NumericUpDown nudPrincipal;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Label lblMortgageCalc;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaymentwithInterest;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnCloseHelp;
        private System.Windows.Forms.Button btnHelpOptionals;
        private System.Windows.Forms.Label lblPersonalization;
        private System.Windows.Forms.TabPage tabHelpOptionals;
        private System.Windows.Forms.Label lblPropertytaxexplained;
        private System.Windows.Forms.Label lblHelpOptionals;
        private System.Windows.Forms.Label lblInsuranceexplained;
        private System.Windows.Forms.Button btnReturnfromHelpOptionals;
        private System.Windows.Forms.Label lblDownpaymentexplained;
        private System.Windows.Forms.NumericUpDown nudPropertyTax;
        private System.Windows.Forms.NumericUpDown nudInsurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblPersonalizationDesc;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.ListBox lstVoice;
        private System.Windows.Forms.ComboBox cbVoice;
        private System.Windows.Forms.Label lblSpeaker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudDownPayment;
        private System.Windows.Forms.Label lblDownpaymenttitle;
        private System.Windows.Forms.Label lblPropertyTaxTitle;
        private System.Windows.Forms.Label lblInsuranceTitle;
        private System.Windows.Forms.Button btnAbout;
    }
}

