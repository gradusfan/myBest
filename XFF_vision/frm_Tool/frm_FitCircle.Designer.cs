﻿namespace XFF_Vision.frm_Tool
{
    partial class frm_FitCircle
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
            HalconDotNet.HWindow hWindow1 = new HalconDotNet.HWindow();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FitCircle));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRuleWidth = new System.Windows.Forms.Label();
            this.lblRuleHigh = new System.Windows.Forms.Label();
            this.lblRulenums = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.nudSigma = new System.Windows.Forms.NumericUpDown();
            this.takBarRuleWidth = new System.Windows.Forms.TrackBar();
            this.takBarRuleHigh = new System.Windows.Forms.TrackBar();
            this.takBarRulenums = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbntSelectAll = new System.Windows.Forms.RadioButton();
            this.rbntSelectLast = new System.Windows.Forms.RadioButton();
            this.rbntSelectFirst = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbntAll = new System.Windows.Forms.RadioButton();
            this.rbntNegative = new System.Windows.Forms.RadioButton();
            this.rbntPostive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cebxFitCircle = new System.Windows.Forms.CheckBox();
            this.cebxFitPoint = new System.Windows.Forms.CheckBox();
            this.cebxRule = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.nudHmeasure = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxMeasure = new System.Windows.Forms.CheckBox();
            this.nudLmeasure = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.halconView1 = new ViewControl.HalconView();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRulenums)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.lblRuleWidth);
            this.tabPage1.Controls.Add(this.lblRuleHigh);
            this.tabPage1.Controls.Add(this.lblRulenums);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudThreshold);
            this.tabPage1.Controls.Add(this.nudSigma);
            this.tabPage1.Controls.Add(this.takBarRuleWidth);
            this.tabPage1.Controls.Add(this.takBarRuleHigh);
            this.tabPage1.Controls.Add(this.takBarRulenums);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // lblRuleWidth
            // 
            this.lblRuleWidth.AutoSize = true;
            this.lblRuleWidth.Location = new System.Drawing.Point(336, 439);
            this.lblRuleWidth.Name = "lblRuleWidth";
            this.lblRuleWidth.Size = new System.Drawing.Size(11, 12);
            this.lblRuleWidth.TabIndex = 63;
            this.lblRuleWidth.Text = "0";
            // 
            // lblRuleHigh
            // 
            this.lblRuleHigh.AutoSize = true;
            this.lblRuleHigh.Location = new System.Drawing.Point(336, 377);
            this.lblRuleHigh.Name = "lblRuleHigh";
            this.lblRuleHigh.Size = new System.Drawing.Size(11, 12);
            this.lblRuleHigh.TabIndex = 62;
            this.lblRuleHigh.Text = "0";
            // 
            // lblRulenums
            // 
            this.lblRulenums.AutoSize = true;
            this.lblRulenums.Location = new System.Drawing.Point(336, 314);
            this.lblRulenums.Name = "lblRulenums";
            this.lblRulenums.Size = new System.Drawing.Size(11, 12);
            this.lblRulenums.TabIndex = 61;
            this.lblRulenums.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(3, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 53);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置定位设置";
            // 
            // cebxFixture
            // 
            this.cebxFixture.AutoSize = true;
            this.cebxFixture.Location = new System.Drawing.Point(302, 22);
            this.cebxFixture.Name = "cebxFixture";
            this.cebxFixture.Size = new System.Drawing.Size(48, 16);
            this.cebxFixture.TabIndex = 51;
            this.cebxFixture.Text = "使用";
            this.cebxFixture.UseVisualStyleBackColor = true;
            this.cebxFixture.CheckedChanged += new System.EventHandler(this.cebxFixture_CheckedChanged);
            // 
            // cbxFixture
            // 
            this.cbxFixture.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxFixture.FormattingEnabled = true;
            this.cbxFixture.Location = new System.Drawing.Point(97, 16);
            this.cbxFixture.Name = "cbxFixture";
            this.cbxFixture.Size = new System.Drawing.Size(199, 22);
            this.cbxFixture.TabIndex = 0;
            this.cbxFixture.SelectedIndexChanged += new System.EventHandler(this.cbxFixture_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "输入定位位置：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(101, 16);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(229, 26);
            this.tbxToolName.TabIndex = 59;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbxImage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(4, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 52);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(97, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(229, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入图像：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "找圆工具名：";
            // 
            // nudThreshold
            // 
            this.nudThreshold.Location = new System.Drawing.Point(81, 245);
            this.nudThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(74, 21);
            this.nudThreshold.TabIndex = 56;
            this.nudThreshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudThreshold.ValueChanged += new System.EventHandler(this.nudThreshold_ValueChanged);
            // 
            // nudSigma
            // 
            this.nudSigma.DecimalPlaces = 1;
            this.nudSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSigma.Location = new System.Drawing.Point(81, 192);
            this.nudSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSigma.Name = "nudSigma";
            this.nudSigma.Size = new System.Drawing.Size(74, 21);
            this.nudSigma.TabIndex = 55;
            this.nudSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSigma.ValueChanged += new System.EventHandler(this.nudSigma_ValueChanged);
            // 
            // takBarRuleWidth
            // 
            this.takBarRuleWidth.BackColor = System.Drawing.Color.DimGray;
            this.takBarRuleWidth.Location = new System.Drawing.Point(79, 423);
            this.takBarRuleWidth.Maximum = 100;
            this.takBarRuleWidth.Minimum = 5;
            this.takBarRuleWidth.Name = "takBarRuleWidth";
            this.takBarRuleWidth.Size = new System.Drawing.Size(251, 45);
            this.takBarRuleWidth.TabIndex = 42;
            this.takBarRuleWidth.Value = 20;
            this.takBarRuleWidth.Scroll += new System.EventHandler(this.takBarRuleWidth_Scroll);
            // 
            // takBarRuleHigh
            // 
            this.takBarRuleHigh.BackColor = System.Drawing.Color.DimGray;
            this.takBarRuleHigh.Location = new System.Drawing.Point(79, 361);
            this.takBarRuleHigh.Maximum = 200;
            this.takBarRuleHigh.Minimum = 5;
            this.takBarRuleHigh.Name = "takBarRuleHigh";
            this.takBarRuleHigh.Size = new System.Drawing.Size(251, 45);
            this.takBarRuleHigh.TabIndex = 41;
            this.takBarRuleHigh.Value = 50;
            this.takBarRuleHigh.Scroll += new System.EventHandler(this.takBarRuleHigh_Scroll);
            // 
            // takBarRulenums
            // 
            this.takBarRulenums.BackColor = System.Drawing.Color.DimGray;
            this.takBarRulenums.Location = new System.Drawing.Point(79, 298);
            this.takBarRulenums.Maximum = 200;
            this.takBarRulenums.Minimum = 6;
            this.takBarRulenums.Name = "takBarRulenums";
            this.takBarRulenums.Size = new System.Drawing.Size(251, 45);
            this.takBarRulenums.TabIndex = 40;
            this.takBarRulenums.Value = 20;
            this.takBarRulenums.Scroll += new System.EventHandler(this.takBarRulenums_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "卡尺宽度：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "卡尺高度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "卡尺数量：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbntSelectAll);
            this.groupBox2.Controls.Add(this.rbntSelectLast);
            this.groupBox2.Controls.Add(this.rbntSelectFirst);
            this.groupBox2.Location = new System.Drawing.Point(285, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 87);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "边设定";
            // 
            // rbntSelectAll
            // 
            this.rbntSelectAll.AutoSize = true;
            this.rbntSelectAll.Checked = true;
            this.rbntSelectAll.Location = new System.Drawing.Point(12, 64);
            this.rbntSelectAll.Name = "rbntSelectAll";
            this.rbntSelectAll.Size = new System.Drawing.Size(47, 16);
            this.rbntSelectAll.TabIndex = 23;
            this.rbntSelectAll.TabStop = true;
            this.rbntSelectAll.Text = "所有";
            this.rbntSelectAll.UseVisualStyleBackColor = true;
            this.rbntSelectAll.CheckedChanged += new System.EventHandler(this.rbntSelectAll_CheckedChanged);
            // 
            // rbntSelectLast
            // 
            this.rbntSelectLast.AutoSize = true;
            this.rbntSelectLast.Location = new System.Drawing.Point(12, 42);
            this.rbntSelectLast.Name = "rbntSelectLast";
            this.rbntSelectLast.Size = new System.Drawing.Size(65, 16);
            this.rbntSelectLast.TabIndex = 22;
            this.rbntSelectLast.Text = "最后1条";
            this.rbntSelectLast.UseVisualStyleBackColor = true;
            this.rbntSelectLast.CheckedChanged += new System.EventHandler(this.rbntSelectLast_CheckedChanged);
            // 
            // rbntSelectFirst
            // 
            this.rbntSelectFirst.AutoSize = true;
            this.rbntSelectFirst.Location = new System.Drawing.Point(12, 20);
            this.rbntSelectFirst.Name = "rbntSelectFirst";
            this.rbntSelectFirst.Size = new System.Drawing.Size(53, 16);
            this.rbntSelectFirst.TabIndex = 21;
            this.rbntSelectFirst.Text = "第1条";
            this.rbntSelectFirst.UseVisualStyleBackColor = true;
            this.rbntSelectFirst.CheckedChanged += new System.EventHandler(this.rbntSelectFirst_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbntAll);
            this.groupBox1.Controls.Add(this.rbntNegative);
            this.groupBox1.Controls.Add(this.rbntPostive);
            this.groupBox1.Location = new System.Drawing.Point(174, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 87);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "极性设定";
            // 
            // rbntAll
            // 
            this.rbntAll.AutoSize = true;
            this.rbntAll.Checked = true;
            this.rbntAll.Location = new System.Drawing.Point(10, 64);
            this.rbntAll.Name = "rbntAll";
            this.rbntAll.Size = new System.Drawing.Size(47, 16);
            this.rbntAll.TabIndex = 23;
            this.rbntAll.TabStop = true;
            this.rbntAll.Text = "所有";
            this.rbntAll.UseVisualStyleBackColor = true;
            this.rbntAll.CheckedChanged += new System.EventHandler(this.rbntAll_CheckedChanged);
            // 
            // rbntNegative
            // 
            this.rbntNegative.AutoSize = true;
            this.rbntNegative.Location = new System.Drawing.Point(10, 42);
            this.rbntNegative.Name = "rbntNegative";
            this.rbntNegative.Size = new System.Drawing.Size(59, 16);
            this.rbntNegative.TabIndex = 22;
            this.rbntNegative.Text = "白到黑";
            this.rbntNegative.UseVisualStyleBackColor = true;
            this.rbntNegative.CheckedChanged += new System.EventHandler(this.rbntNegative_CheckedChanged);
            // 
            // rbntPostive
            // 
            this.rbntPostive.AutoSize = true;
            this.rbntPostive.Location = new System.Drawing.Point(10, 20);
            this.rbntPostive.Name = "rbntPostive";
            this.rbntPostive.Size = new System.Drawing.Size(59, 16);
            this.rbntPostive.TabIndex = 21;
            this.rbntPostive.Text = "黑到白";
            this.rbntPostive.UseVisualStyleBackColor = true;
            this.rbntPostive.CheckedChanged += new System.EventHandler(this.rbntPostive_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "平滑值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "阈值：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.btnDrawRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(224, 77);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(75, 23);
            this.btnDrawRoi.TabIndex = 18;
            this.btnDrawRoi.Text = "画roi";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btnDrawRoi_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.cebxFitCircle);
            this.tabPage3.Controls.Add(this.cebxFitPoint);
            this.tabPage3.Controls.Add(this.cebxRule);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // cebxFitCircle
            // 
            this.cebxFitCircle.AutoSize = true;
            this.cebxFitCircle.Location = new System.Drawing.Point(49, 112);
            this.cebxFitCircle.Name = "cebxFitCircle";
            this.cebxFitCircle.Size = new System.Drawing.Size(84, 16);
            this.cebxFitCircle.TabIndex = 40;
            this.cebxFitCircle.Text = "拟合圆图形";
            this.cebxFitCircle.UseVisualStyleBackColor = true;
            this.cebxFitCircle.CheckedChanged += new System.EventHandler(this.cebxFitCircle_CheckedChanged);
            // 
            // cebxFitPoint
            // 
            this.cebxFitPoint.AutoSize = true;
            this.cebxFitPoint.Location = new System.Drawing.Point(49, 69);
            this.cebxFitPoint.Name = "cebxFitPoint";
            this.cebxFitPoint.Size = new System.Drawing.Size(84, 16);
            this.cebxFitPoint.TabIndex = 39;
            this.cebxFitPoint.Text = "拟合点图形";
            this.cebxFitPoint.UseVisualStyleBackColor = true;
            this.cebxFitPoint.CheckedChanged += new System.EventHandler(this.cebxFitPoint_CheckedChanged);
            // 
            // cebxRule
            // 
            this.cebxRule.AutoSize = true;
            this.cebxRule.Location = new System.Drawing.Point(49, 28);
            this.cebxRule.Name = "cebxRule";
            this.cebxRule.Size = new System.Drawing.Size(72, 16);
            this.cebxRule.TabIndex = 38;
            this.cebxRule.Text = "卡尺图形";
            this.cebxRule.UseVisualStyleBackColor = true;
            this.cebxRule.CheckedChanged += new System.EventHandler(this.cebxRule_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.nudScale);
            this.tabPage4.Controls.Add(this.nudHmeasure);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.cebxMeasure);
            this.tabPage4.Controls.Add(this.nudLmeasure);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(376, 581);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 83;
            this.label6.Text = "比例：";
            // 
            // nudScale
            // 
            this.nudScale.DecimalPlaces = 5;
            this.nudScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScale.Location = new System.Drawing.Point(84, 481);
            this.nudScale.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScale.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nudScale.Name = "nudScale";
            this.nudScale.Size = new System.Drawing.Size(76, 21);
            this.nudScale.TabIndex = 82;
            this.nudScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScale.ValueChanged += new System.EventHandler(this.nudScale_ValueChanged);
            // 
            // nudHmeasure
            // 
            this.nudHmeasure.DecimalPlaces = 2;
            this.nudHmeasure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHmeasure.Location = new System.Drawing.Point(178, 537);
            this.nudHmeasure.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHmeasure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHmeasure.Name = "nudHmeasure";
            this.nudHmeasure.Size = new System.Drawing.Size(76, 21);
            this.nudHmeasure.TabIndex = 67;
            this.nudHmeasure.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHmeasure.ValueChanged += new System.EventHandler(this.nudHmeasure_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(176, 522);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(84, 522);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(37, 543);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 64;
            this.label29.Text = "直径：";
            // 
            // cebxMeasure
            // 
            this.cebxMeasure.AutoSize = true;
            this.cebxMeasure.Location = new System.Drawing.Point(260, 542);
            this.cebxMeasure.Name = "cebxMeasure";
            this.cebxMeasure.Size = new System.Drawing.Size(48, 16);
            this.cebxMeasure.TabIndex = 63;
            this.cebxMeasure.Text = "使用";
            this.cebxMeasure.UseVisualStyleBackColor = true;
            this.cebxMeasure.CheckedChanged += new System.EventHandler(this.cebxMeasure_CheckedChanged);
            // 
            // nudLmeasure
            // 
            this.nudLmeasure.DecimalPlaces = 1;
            this.nudLmeasure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLmeasure.Location = new System.Drawing.Point(84, 537);
            this.nudLmeasure.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLmeasure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure.Name = "nudLmeasure";
            this.nudLmeasure.Size = new System.Drawing.Size(76, 21);
            this.nudLmeasure.TabIndex = 62;
            this.nudLmeasure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure.ValueChanged += new System.EventHandler(this.nudLmeasure_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(370, 440);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(95, 635);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(319, 622);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(238, 622);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 14;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(14, 622);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 13;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(400, 9);
            this.halconView1.Name = "halconView1";
            this.halconView1.ShowStatus1 = false;
            this.halconView1.ShowStatus2 = false;
            this.halconView1.Size = new System.Drawing.Size(674, 640);
            this.halconView1.TabIndex = 17;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(195, 637);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "FAIL";
            // 
            // frm_FitCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 662);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_FitCircle";
            this.Text = "找圆";
            this.Load += new System.EventHandler(this.frm_FitCircle_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRulenums)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.TrackBar takBarRuleWidth;
        private System.Windows.Forms.TrackBar takBarRuleHigh;
        private System.Windows.Forms.TrackBar takBarRulenums;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbntSelectAll;
        private System.Windows.Forms.RadioButton rbntSelectLast;
        private System.Windows.Forms.RadioButton rbntSelectFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbntAll;
        private System.Windows.Forms.RadioButton rbntNegative;
        private System.Windows.Forms.RadioButton rbntPostive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.NumericUpDown nudSigma;
        private System.Windows.Forms.CheckBox cebxFitCircle;
        private System.Windows.Forms.CheckBox cebxFitPoint;
        private System.Windows.Forms.CheckBox cebxRule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudHmeasure;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxMeasure;
        private System.Windows.Forms.NumericUpDown nudLmeasure;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.Label lblRuleWidth;
        private System.Windows.Forms.Label lblRuleHigh;
        private System.Windows.Forms.Label lblRulenums;
    }
}