namespace VRADFix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFaceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxBsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHDR = new System.Windows.Forms.RadioButton();
            this.radioButtonLDR = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonBrowseBsp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.luxelsCanvas = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelRGB = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.spinnerR = new System.Windows.Forms.NumericUpDown();
            this.spinnerE = new System.Windows.Forms.NumericUpDown();
            this.spinnerG = new System.Windows.Forms.NumericUpDown();
            this.spinnerB = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.manualExposure = new System.Windows.Forms.NumericUpDown();
            this.radioButton_expManual = new System.Windows.Forms.RadioButton();
            this.radioButton_expAuto = new System.Windows.Forms.RadioButton();
            this.checkBoxAdjustColors = new System.Windows.Forms.CheckBox();
            this.checkBoxOverexp = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerB)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualExposure)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "BSP files (*.bsp)|*bsp";
            // 
            // textBoxFaceID
            // 
            this.textBoxFaceID.Enabled = false;
            this.textBoxFaceID.Location = new System.Drawing.Point(0, 36);
            this.textBoxFaceID.Name = "textBoxFaceID";
            this.textBoxFaceID.Size = new System.Drawing.Size(78, 20);
            this.textBoxFaceID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FaceId:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.helpProvider1.SetHelpKeyword(this.buttonLoad, "hey");
            this.buttonLoad.Location = new System.Drawing.Point(84, 34);
            this.buttonLoad.Name = "buttonLoad";
            this.helpProvider1.SetShowHelp(this.buttonLoad, true);
            this.buttonLoad.Size = new System.Drawing.Size(103, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load lightmap!";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxBsp
            // 
            this.textBoxBsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBsp.Location = new System.Drawing.Point(0, 10);
            this.textBoxBsp.Name = "textBoxBsp";
            this.textBoxBsp.ReadOnly = true;
            this.textBoxBsp.Size = new System.Drawing.Size(562, 20);
            this.textBoxBsp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bsp:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(71, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 24);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Write changes to BSP";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUnload
            // 
            this.buttonUnload.Enabled = false;
            this.buttonUnload.Location = new System.Drawing.Point(193, 34);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(59, 23);
            this.buttonUnload.TabIndex = 8;
            this.buttonUnload.Text = "Unload";
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(834, 60);
            this.panel1.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBoxBsp);
            this.panel8.Controls.Add(this.textBoxFaceID);
            this.panel8.Controls.Add(this.buttonLoad);
            this.panel8.Controls.Add(this.buttonUnload);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(53, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 10, 4, 10);
            this.panel8.Size = new System.Drawing.Size(566, 60);
            this.panel8.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(10, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(43, 60);
            this.panel7.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(619, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel5.Size = new System.Drawing.Size(215, 60);
            this.panel5.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.groupBox2);
            this.panel12.Location = new System.Drawing.Point(88, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(124, 90);
            this.panel12.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHDR);
            this.groupBox2.Controls.Add(this.radioButtonLDR);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 40);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light mode";
            // 
            // radioButtonHDR
            // 
            this.radioButtonHDR.AutoSize = true;
            this.radioButtonHDR.Location = new System.Drawing.Point(60, 17);
            this.radioButtonHDR.Name = "radioButtonHDR";
            this.radioButtonHDR.Size = new System.Drawing.Size(49, 17);
            this.radioButtonHDR.TabIndex = 1;
            this.radioButtonHDR.Text = "HDR";
            this.radioButtonHDR.UseVisualStyleBackColor = true;
            this.radioButtonHDR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLDR
            // 
            this.radioButtonLDR.AutoSize = true;
            this.radioButtonLDR.Checked = true;
            this.radioButtonLDR.Location = new System.Drawing.Point(7, 17);
            this.radioButtonLDR.Name = "radioButtonLDR";
            this.radioButtonLDR.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLDR.TabIndex = 0;
            this.radioButtonLDR.TabStop = true;
            this.radioButtonLDR.Text = "LDR";
            this.radioButtonLDR.UseVisualStyleBackColor = true;
            this.radioButtonLDR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonBrowseBsp);
            this.panel11.Location = new System.Drawing.Point(0, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(88, 57);
            this.panel11.TabIndex = 2;
            // 
            // buttonBrowseBsp
            // 
            this.buttonBrowseBsp.Location = new System.Drawing.Point(2, 5);
            this.buttonBrowseBsp.Name = "buttonBrowseBsp";
            this.buttonBrowseBsp.Size = new System.Drawing.Size(86, 24);
            this.buttonBrowseBsp.TabIndex = 1;
            this.buttonBrowseBsp.Text = "Browse";
            this.buttonBrowseBsp.UseVisualStyleBackColor = true;
            this.buttonBrowseBsp.Click += new System.EventHandler(this.buttonBrowseBsp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel2.Size = new System.Drawing.Size(834, 466);
            this.panel2.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.AutoScroll = true;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.luxelsCanvas);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(814, 423);
            this.panel9.TabIndex = 0;
            // 
            // luxelsCanvas
            // 
            this.luxelsCanvas.Location = new System.Drawing.Point(3, 3);
            this.luxelsCanvas.Name = "luxelsCanvas";
            this.luxelsCanvas.Size = new System.Drawing.Size(100, 100);
            this.luxelsCanvas.TabIndex = 0;
            this.luxelsCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.luxelsCanvas_Paint);
            this.luxelsCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luxelsCanvas_MouseClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(814, 33);
            this.panel6.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelRGB);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(258, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(356, 33);
            this.panel10.TabIndex = 8;
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(3, 10);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(196, 13);
            this.labelRGB.TabIndex = 6;
            this.labelRGB.Text = "Corresponding RGB value: 255 255 255";
            this.labelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonUpdate);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(614, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 33);
            this.panel14.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.spinnerR);
            this.panel13.Controls.Add(this.spinnerE);
            this.panel13.Controls.Add(this.spinnerG);
            this.panel13.Controls.Add(this.spinnerB);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(258, 33);
            this.panel13.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RGBE:";
            // 
            // spinnerR
            // 
            this.spinnerR.Enabled = false;
            this.spinnerR.Location = new System.Drawing.Point(43, 8);
            this.spinnerR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinnerR.Name = "spinnerR";
            this.spinnerR.Size = new System.Drawing.Size(47, 20);
            this.spinnerR.TabIndex = 1;
            this.spinnerR.ValueChanged += new System.EventHandler(this.spinner_ValueChanged);
            // 
            // spinnerE
            // 
            this.spinnerE.Enabled = false;
            this.spinnerE.Location = new System.Drawing.Point(202, 8);
            this.spinnerE.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.spinnerE.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.spinnerE.Name = "spinnerE";
            this.spinnerE.Size = new System.Drawing.Size(47, 20);
            this.spinnerE.TabIndex = 5;
            this.spinnerE.ValueChanged += new System.EventHandler(this.spinner_ValueChanged);
            // 
            // spinnerG
            // 
            this.spinnerG.Enabled = false;
            this.spinnerG.Location = new System.Drawing.Point(96, 8);
            this.spinnerG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinnerG.Name = "spinnerG";
            this.spinnerG.Size = new System.Drawing.Size(47, 20);
            this.spinnerG.TabIndex = 3;
            this.spinnerG.ValueChanged += new System.EventHandler(this.spinner_ValueChanged);
            // 
            // spinnerB
            // 
            this.spinnerB.Enabled = false;
            this.spinnerB.Location = new System.Drawing.Point(149, 8);
            this.spinnerB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinnerB.Name = "spinnerB";
            this.spinnerB.Size = new System.Drawing.Size(47, 20);
            this.spinnerB.TabIndex = 4;
            this.spinnerB.ValueChanged += new System.EventHandler(this.spinner_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.checkBoxAdjustColors);
            this.panel3.Controls.Add(this.checkBoxOverexp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 526);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 3, 10, 8);
            this.panel3.Size = new System.Drawing.Size(834, 35);
            this.panel3.TabIndex = 15;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.manualExposure);
            this.panel15.Controls.Add(this.radioButton_expManual);
            this.panel15.Controls.Add(this.radioButton_expAuto);
            this.panel15.Location = new System.Drawing.Point(575, 1);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(189, 31);
            this.panel15.TabIndex = 8;
            // 
            // manualExposure
            // 
            this.manualExposure.DecimalPlaces = 1;
            this.manualExposure.Enabled = false;
            this.manualExposure.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.manualExposure.Location = new System.Drawing.Point(134, 6);
            this.manualExposure.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.manualExposure.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            -2147483648});
            this.manualExposure.Name = "manualExposure";
            this.manualExposure.Size = new System.Drawing.Size(46, 20);
            this.manualExposure.TabIndex = 2;
            this.manualExposure.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButton_expManual
            // 
            this.radioButton_expManual.AutoSize = true;
            this.radioButton_expManual.Location = new System.Drawing.Point(56, 6);
            this.radioButton_expManual.Name = "radioButton_expManual";
            this.radioButton_expManual.Size = new System.Drawing.Size(77, 17);
            this.radioButton_expManual.TabIndex = 1;
            this.radioButton_expManual.Text = "Brightness:";
            this.radioButton_expManual.UseVisualStyleBackColor = true;
            this.radioButton_expManual.CheckedChanged += new System.EventHandler(this.radioButton_exp_CheckedChanged);
            // 
            // radioButton_expAuto
            // 
            this.radioButton_expAuto.AutoSize = true;
            this.radioButton_expAuto.Checked = true;
            this.radioButton_expAuto.Location = new System.Drawing.Point(4, 6);
            this.radioButton_expAuto.Name = "radioButton_expAuto";
            this.radioButton_expAuto.Size = new System.Drawing.Size(47, 17);
            this.radioButton_expAuto.TabIndex = 0;
            this.radioButton_expAuto.TabStop = true;
            this.radioButton_expAuto.Text = "Auto";
            this.radioButton_expAuto.UseVisualStyleBackColor = true;
            this.radioButton_expAuto.CheckedChanged += new System.EventHandler(this.radioButton_exp_CheckedChanged);
            // 
            // checkBoxAdjustColors
            // 
            this.checkBoxAdjustColors.AutoSize = true;
            this.checkBoxAdjustColors.Checked = true;
            this.checkBoxAdjustColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdjustColors.Location = new System.Drawing.Point(291, 8);
            this.checkBoxAdjustColors.Name = "checkBoxAdjustColors";
            this.checkBoxAdjustColors.Size = new System.Drawing.Size(285, 17);
            this.checkBoxAdjustColors.TabIndex = 7;
            this.checkBoxAdjustColors.Text = "Adjust preview brightness (doesn\'t affect actual values)";
            this.checkBoxAdjustColors.UseVisualStyleBackColor = true;
            this.checkBoxAdjustColors.CheckedChanged += new System.EventHandler(this.checkBoxAdjustColors_CheckedChanged);
            // 
            // checkBoxOverexp
            // 
            this.checkBoxOverexp.AutoSize = true;
            this.checkBoxOverexp.Location = new System.Drawing.Point(63, 8);
            this.checkBoxOverexp.Name = "checkBoxOverexp";
            this.checkBoxOverexp.Size = new System.Drawing.Size(220, 17);
            this.checkBoxOverexp.TabIndex = 6;
            this.checkBoxOverexp.Text = "Flash when a color channel exceeds 255";
            this.checkBoxOverexp.UseVisualStyleBackColor = true;
            this.checkBoxOverexp.CheckedChanged += new System.EventHandler(this.checkBoxOverexp_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 561);
            this.panel4.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preview:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Main";
            this.Text = "Source Engine BSP Lightmap Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualExposure)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFaceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxBsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonUnload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.NumericUpDown spinnerE;
        private System.Windows.Forms.NumericUpDown spinnerB;
        private System.Windows.Forms.NumericUpDown spinnerG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinnerR;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox checkBoxAdjustColors;
        private System.Windows.Forms.CheckBox checkBoxOverexp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonHDR;
        private System.Windows.Forms.RadioButton radioButtonLDR;
        private System.Windows.Forms.Button buttonBrowseBsp;
        private System.Windows.Forms.Panel luxelsCanvas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.NumericUpDown manualExposure;
        private System.Windows.Forms.RadioButton radioButton_expManual;
        private System.Windows.Forms.RadioButton radioButton_expAuto;
        private System.Windows.Forms.Label label2;
    }
}

