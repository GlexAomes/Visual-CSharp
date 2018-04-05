namespace Bootleg_Paint
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cldPicker = new System.Windows.Forms.ColorDialog();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.cboDrawType = new System.Windows.Forms.ComboBox();
            this.pnlChosenColor = new System.Windows.Forms.Panel();
            this.lblChosenColor = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblpx = new System.Windows.Forms.Label();
            this.rdoEraseAll = new System.Windows.Forms.RadioButton();
            this.rdoEraseBrush = new System.Windows.Forms.RadioButton();
            this.lblFill = new System.Windows.Forms.Label();
            this.pnlSpecialErase = new System.Windows.Forms.Panel();
            this.cldBucket = new System.Windows.Forms.ColorDialog();
            this.btnBucketColor = new System.Windows.Forms.Button();
            this.btnClearBucket = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.svdDoodle = new System.Windows.Forms.SaveFileDialog();
            this.grpErasers = new System.Windows.Forms.GroupBox();
            this.grpVertexType = new System.Windows.Forms.GroupBox();
            this.rdoUpDown = new System.Windows.Forms.RadioButton();
            this.rdoLeftRight = new System.Windows.Forms.RadioButton();
            this.grpTriangleType = new System.Windows.Forms.GroupBox();
            this.rdoEquilIso = new System.Windows.Forms.RadioButton();
            this.rdoRightAngle = new System.Windows.Forms.RadioButton();
            this.nudSides = new System.Windows.Forms.NumericUpDown();
            this.lblSides = new System.Windows.Forms.Label();
            this.lblPolygon = new System.Windows.Forms.Label();
            this.grpPolygon = new System.Windows.Forms.GroupBox();
            this.lblClickCount = new System.Windows.Forms.Label();
            this.lblClicksLeft = new System.Windows.Forms.Label();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdDoodle = new System.Windows.Forms.OpenFileDialog();
            this.btnAdvancedColor = new System.Windows.Forms.Button();
            this.pnlTools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.grpErasers.SuspendLayout();
            this.grpVertexType.SuspendLayout();
            this.grpTriangleType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).BeginInit();
            this.grpPolygon.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlMain.Location = new System.Drawing.Point(28, 150);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1201, 797);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseClick);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1076, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Location = new System.Drawing.Point(220, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(155, 53);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Choose Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(12, 57);
            this.nudSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(137, 31);
            this.nudSize.TabIndex = 3;
            this.nudSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // cboDrawType
            // 
            this.cboDrawType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDrawType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDrawType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrawType.FormattingEnabled = true;
            this.cboDrawType.Items.AddRange(new object[] {
            "Brush",
            "Bucket",
            "Eraser",
            "Highlighter",
            "Line",
            "Rectangle",
            "Circle",
            "Triangle",
            "Polygons"});
            this.cboDrawType.Location = new System.Drawing.Point(11, 12);
            this.cboDrawType.Name = "cboDrawType";
            this.cboDrawType.Size = new System.Drawing.Size(179, 33);
            this.cboDrawType.TabIndex = 4;
            this.cboDrawType.SelectedIndexChanged += new System.EventHandler(this.cboDrawType_SelectedIndexChanged);
            // 
            // pnlChosenColor
            // 
            this.pnlChosenColor.BackColor = System.Drawing.Color.Black;
            this.pnlChosenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChosenColor.Location = new System.Drawing.Point(417, 15);
            this.pnlChosenColor.Name = "pnlChosenColor";
            this.pnlChosenColor.Size = new System.Drawing.Size(54, 47);
            this.pnlChosenColor.TabIndex = 5;
            // 
            // lblChosenColor
            // 
            this.lblChosenColor.AutoSize = true;
            this.lblChosenColor.Location = new System.Drawing.Point(412, 70);
            this.lblChosenColor.Name = "lblChosenColor";
            this.lblChosenColor.Size = new System.Drawing.Size(64, 26);
            this.lblChosenColor.TabIndex = 6;
            this.lblChosenColor.Text = "Color";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(11, 109);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(97, 26);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "X: 0, Y:0";
            // 
            // lblpx
            // 
            this.lblpx.AutoSize = true;
            this.lblpx.Location = new System.Drawing.Point(155, 62);
            this.lblpx.Name = "lblpx";
            this.lblpx.Size = new System.Drawing.Size(35, 26);
            this.lblpx.TabIndex = 11;
            this.lblpx.Text = "px";
            // 
            // rdoEraseAll
            // 
            this.rdoEraseAll.AutoSize = true;
            this.rdoEraseAll.Checked = true;
            this.rdoEraseAll.Location = new System.Drawing.Point(6, 30);
            this.rdoEraseAll.Name = "rdoEraseAll";
            this.rdoEraseAll.Size = new System.Drawing.Size(125, 30);
            this.rdoEraseAll.TabIndex = 12;
            this.rdoEraseAll.TabStop = true;
            this.rdoEraseAll.Text = "Erase All";
            this.rdoEraseAll.UseVisualStyleBackColor = true;
            this.rdoEraseAll.CheckedChanged += new System.EventHandler(this.rdoEraseAll_CheckedChanged);
            // 
            // rdoEraseBrush
            // 
            this.rdoEraseBrush.AutoSize = true;
            this.rdoEraseBrush.Location = new System.Drawing.Point(6, 59);
            this.rdoEraseBrush.Name = "rdoEraseBrush";
            this.rdoEraseBrush.Size = new System.Drawing.Size(157, 30);
            this.rdoEraseBrush.TabIndex = 13;
            this.rdoEraseBrush.Text = "Erase Brush";
            this.rdoEraseBrush.UseVisualStyleBackColor = true;
            this.rdoEraseBrush.CheckedChanged += new System.EventHandler(this.rdoEraseBrush_CheckedChanged);
            // 
            // lblFill
            // 
            this.lblFill.AutoSize = true;
            this.lblFill.Location = new System.Drawing.Point(68, 62);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(40, 26);
            this.lblFill.TabIndex = 14;
            this.lblFill.Text = "Fill";
            this.lblFill.Visible = false;
            // 
            // pnlSpecialErase
            // 
            this.pnlSpecialErase.BackColor = System.Drawing.Color.Black;
            this.pnlSpecialErase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSpecialErase.Location = new System.Drawing.Point(418, 15);
            this.pnlSpecialErase.Name = "pnlSpecialErase";
            this.pnlSpecialErase.Size = new System.Drawing.Size(53, 47);
            this.pnlSpecialErase.TabIndex = 9;
            // 
            // cldBucket
            // 
            this.cldBucket.Color = System.Drawing.Color.White;
            // 
            // btnBucketColor
            // 
            this.btnBucketColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBucketColor.Location = new System.Drawing.Point(220, 12);
            this.btnBucketColor.Name = "btnBucketColor";
            this.btnBucketColor.Size = new System.Drawing.Size(155, 53);
            this.btnBucketColor.TabIndex = 15;
            this.btnBucketColor.Text = "Choose Color";
            this.btnBucketColor.UseVisualStyleBackColor = true;
            this.btnBucketColor.Click += new System.EventHandler(this.btnBucketColor_Click);
            // 
            // btnClearBucket
            // 
            this.btnClearBucket.Location = new System.Drawing.Point(1076, 73);
            this.btnClearBucket.Name = "btnClearBucket";
            this.btnClearBucket.Size = new System.Drawing.Size(152, 50);
            this.btnClearBucket.TabIndex = 16;
            this.btnClearBucket.Text = "Bucket Clear";
            this.btnClearBucket.UseVisualStyleBackColor = true;
            this.btnClearBucket.Click += new System.EventHandler(this.btnClearBucket_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(960, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Export";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // svdDoodle
            // 
            this.svdDoodle.FileName = "My Doodle";
            this.svdDoodle.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg";
            this.svdDoodle.ShowHelp = true;
            this.svdDoodle.Title = "Export a Doodle";
            this.svdDoodle.FileOk += new System.ComponentModel.CancelEventHandler(this.svdDoodle_FileOk);
            this.svdDoodle.HelpRequest += new System.EventHandler(this.svdDoodle_HelpRequest);
            // 
            // grpErasers
            // 
            this.grpErasers.Controls.Add(this.rdoEraseAll);
            this.grpErasers.Controls.Add(this.rdoEraseBrush);
            this.grpErasers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpErasers.Location = new System.Drawing.Point(220, 12);
            this.grpErasers.Name = "grpErasers";
            this.grpErasers.Size = new System.Drawing.Size(178, 102);
            this.grpErasers.TabIndex = 18;
            this.grpErasers.TabStop = false;
            this.grpErasers.Text = "Eraser Type";
            this.grpErasers.Visible = false;
            // 
            // grpVertexType
            // 
            this.grpVertexType.Controls.Add(this.rdoUpDown);
            this.grpVertexType.Controls.Add(this.rdoLeftRight);
            this.grpVertexType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpVertexType.Location = new System.Drawing.Point(776, 21);
            this.grpVertexType.Name = "grpVertexType";
            this.grpVertexType.Size = new System.Drawing.Size(166, 94);
            this.grpVertexType.TabIndex = 19;
            this.grpVertexType.TabStop = false;
            this.grpVertexType.Text = "Vertex Style";
            this.grpVertexType.Visible = false;
            // 
            // rdoUpDown
            // 
            this.rdoUpDown.AutoSize = true;
            this.rdoUpDown.Checked = true;
            this.rdoUpDown.Location = new System.Drawing.Point(6, 30);
            this.rdoUpDown.Name = "rdoUpDown";
            this.rdoUpDown.Size = new System.Drawing.Size(110, 30);
            this.rdoUpDown.TabIndex = 12;
            this.rdoUpDown.TabStop = true;
            this.rdoUpDown.Text = "Verticle";
            this.rdoUpDown.UseVisualStyleBackColor = true;
            // 
            // rdoLeftRight
            // 
            this.rdoLeftRight.AutoSize = true;
            this.rdoLeftRight.Location = new System.Drawing.Point(6, 59);
            this.rdoLeftRight.Name = "rdoLeftRight";
            this.rdoLeftRight.Size = new System.Drawing.Size(135, 30);
            this.rdoLeftRight.TabIndex = 13;
            this.rdoLeftRight.Text = "Horizontal";
            this.rdoLeftRight.UseVisualStyleBackColor = true;
            // 
            // grpTriangleType
            // 
            this.grpTriangleType.Controls.Add(this.rdoEquilIso);
            this.grpTriangleType.Controls.Add(this.rdoRightAngle);
            this.grpTriangleType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpTriangleType.Location = new System.Drawing.Point(507, 27);
            this.grpTriangleType.Name = "grpTriangleType";
            this.grpTriangleType.Size = new System.Drawing.Size(263, 96);
            this.grpTriangleType.TabIndex = 20;
            this.grpTriangleType.TabStop = false;
            this.grpTriangleType.Text = "Triangle Type";
            this.grpTriangleType.Visible = false;
            // 
            // rdoEquilIso
            // 
            this.rdoEquilIso.AutoSize = true;
            this.rdoEquilIso.Checked = true;
            this.rdoEquilIso.Location = new System.Drawing.Point(6, 30);
            this.rdoEquilIso.Name = "rdoEquilIso";
            this.rdoEquilIso.Size = new System.Drawing.Size(249, 30);
            this.rdoEquilIso.TabIndex = 12;
            this.rdoEquilIso.TabStop = true;
            this.rdoEquilIso.Text = "Equilateral / Isosceles";
            this.rdoEquilIso.UseVisualStyleBackColor = true;
            this.rdoEquilIso.CheckedChanged += new System.EventHandler(this.rdoEquilIso_CheckedChanged);
            // 
            // rdoRightAngle
            // 
            this.rdoRightAngle.AutoSize = true;
            this.rdoRightAngle.Location = new System.Drawing.Point(6, 59);
            this.rdoRightAngle.Name = "rdoRightAngle";
            this.rdoRightAngle.Size = new System.Drawing.Size(150, 30);
            this.rdoRightAngle.TabIndex = 13;
            this.rdoRightAngle.Text = "Right Angle";
            this.rdoRightAngle.UseVisualStyleBackColor = true;
            this.rdoRightAngle.CheckedChanged += new System.EventHandler(this.rdoRightAngle_CheckedChanged);
            // 
            // nudSides
            // 
            this.nudSides.Location = new System.Drawing.Point(13, 32);
            this.nudSides.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSides.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSides.Name = "nudSides";
            this.nudSides.Size = new System.Drawing.Size(137, 31);
            this.nudSides.TabIndex = 21;
            this.nudSides.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSides.ValueChanged += new System.EventHandler(this.nudSides_ValueChanged);
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(156, 34);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(67, 26);
            this.lblSides.TabIndex = 22;
            this.lblSides.Text = "Sides";
            // 
            // lblPolygon
            // 
            this.lblPolygon.AutoSize = true;
            this.lblPolygon.Location = new System.Drawing.Point(8, 74);
            this.lblPolygon.Name = "lblPolygon";
            this.lblPolygon.Size = new System.Drawing.Size(72, 26);
            this.lblPolygon.TabIndex = 23;
            this.lblPolygon.Text = "Trigon";
            // 
            // grpPolygon
            // 
            this.grpPolygon.Controls.Add(this.lblClickCount);
            this.grpPolygon.Controls.Add(this.lblClicksLeft);
            this.grpPolygon.Controls.Add(this.nudSides);
            this.grpPolygon.Controls.Add(this.lblPolygon);
            this.grpPolygon.Controls.Add(this.lblSides);
            this.grpPolygon.Location = new System.Drawing.Point(508, 23);
            this.grpPolygon.Name = "grpPolygon";
            this.grpPolygon.Size = new System.Drawing.Size(428, 112);
            this.grpPolygon.TabIndex = 24;
            this.grpPolygon.TabStop = false;
            this.grpPolygon.Text = "Polygon Settings";
            this.grpPolygon.Visible = false;
            // 
            // lblClickCount
            // 
            this.lblClickCount.AutoSize = true;
            this.lblClickCount.Location = new System.Drawing.Point(324, 57);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(24, 26);
            this.lblClickCount.TabIndex = 25;
            this.lblClickCount.Text = "3";
            // 
            // lblClicksLeft
            // 
            this.lblClicksLeft.AutoSize = true;
            this.lblClicksLeft.Location = new System.Drawing.Point(290, 25);
            this.lblClicksLeft.Name = "lblClicksLeft";
            this.lblClicksLeft.Size = new System.Drawing.Size(119, 26);
            this.lblClicksLeft.TabIndex = 24;
            this.lblClicksLeft.Text = "Clicks Left:";
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(410, 105);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(66, 30);
            this.chkFill.TabIndex = 25;
            this.chkFill.Text = "Fill";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(960, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 50);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ofdDoodle
            // 
            this.ofdDoodle.FileName = "My Doodle";
            this.ofdDoodle.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg";
            this.ofdDoodle.ShowHelp = true;
            this.ofdDoodle.Title = "Import a Doodle";
            this.ofdDoodle.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdDoodle_FileOk);
            this.ofdDoodle.HelpRequest += new System.EventHandler(this.ofdDoodle_HelpRequest);
            // 
            // btnAdvancedColor
            // 
            this.btnAdvancedColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdvancedColor.Location = new System.Drawing.Point(220, 70);
            this.btnAdvancedColor.Name = "btnAdvancedColor";
            this.btnAdvancedColor.Size = new System.Drawing.Size(155, 65);
            this.btnAdvancedColor.TabIndex = 27;
            this.btnAdvancedColor.Text = "Advanced Colors";
            this.btnAdvancedColor.UseVisualStyleBackColor = true;
            this.btnAdvancedColor.Click += new System.EventHandler(this.btnAdvancedColor_Click);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnAdvancedColor);
            this.pnlTools.Controls.Add(this.btnImport);
            this.pnlTools.Controls.Add(this.chkFill);
            this.pnlTools.Controls.Add(this.grpPolygon);
            this.pnlTools.Controls.Add(this.grpTriangleType);
            this.pnlTools.Controls.Add(this.grpVertexType);
            this.pnlTools.Controls.Add(this.grpErasers);
            this.pnlTools.Controls.Add(this.btnSave);
            this.pnlTools.Controls.Add(this.btnColor);
            this.pnlTools.Controls.Add(this.btnBucketColor);
            this.pnlTools.Controls.Add(this.btnClearBucket);
            this.pnlTools.Controls.Add(this.pnlSpecialErase);
            this.pnlTools.Controls.Add(this.lblFill);
            this.pnlTools.Controls.Add(this.lblpx);
            this.pnlTools.Controls.Add(this.lblPosition);
            this.pnlTools.Controls.Add(this.lblChosenColor);
            this.pnlTools.Controls.Add(this.pnlChosenColor);
            this.pnlTools.Controls.Add(this.cboDrawType);
            this.pnlTools.Controls.Add(this.nudSize);
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(1256, 144);
            this.pnlTools.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 974);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1285, 797);
            this.Name = "Form1";
            this.Text = "Doodle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.grpErasers.ResumeLayout(false);
            this.grpErasers.PerformLayout();
            this.grpVertexType.ResumeLayout(false);
            this.grpVertexType.PerformLayout();
            this.grpTriangleType.ResumeLayout(false);
            this.grpTriangleType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).EndInit();
            this.grpPolygon.ResumeLayout(false);
            this.grpPolygon.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cldPicker;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.ComboBox cboDrawType;
        private System.Windows.Forms.Panel pnlChosenColor;
        private System.Windows.Forms.Label lblChosenColor;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblpx;
        private System.Windows.Forms.RadioButton rdoEraseAll;
        private System.Windows.Forms.RadioButton rdoEraseBrush;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.Panel pnlSpecialErase;
        private System.Windows.Forms.ColorDialog cldBucket;
        private System.Windows.Forms.Button btnBucketColor;
        private System.Windows.Forms.Button btnClearBucket;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog svdDoodle;
        private System.Windows.Forms.GroupBox grpErasers;
        private System.Windows.Forms.GroupBox grpVertexType;
        private System.Windows.Forms.RadioButton rdoUpDown;
        private System.Windows.Forms.RadioButton rdoLeftRight;
        private System.Windows.Forms.GroupBox grpTriangleType;
        private System.Windows.Forms.RadioButton rdoEquilIso;
        private System.Windows.Forms.RadioButton rdoRightAngle;
        private System.Windows.Forms.NumericUpDown nudSides;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Label lblPolygon;
        private System.Windows.Forms.GroupBox grpPolygon;
        private System.Windows.Forms.Label lblClicksLeft;
        private System.Windows.Forms.Label lblClickCount;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdDoodle;
        private System.Windows.Forms.Button btnAdvancedColor;
        private System.Windows.Forms.Panel pnlTools;
    }
}

