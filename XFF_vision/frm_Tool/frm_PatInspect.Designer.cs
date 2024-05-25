﻿namespace XFF_Vision.frm_Tool
{
    partial class frm_PatInspect
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
            HalconDotNet.HWindow hWindow2 = new HalconDotNet.HWindow();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblForegroundGValMode = new System.Windows.Forms.Label();
            this.lblBackgroundGValMode = new System.Windows.Forms.Label();
            this.cebxIllumination = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.输出设置 = new System.Windows.Forms.GroupBox();
            this.nudSelectedRegionMin = new System.Windows.Forms.NumericUpDown();
            this.nudSelectedRegionMax = new System.Windows.Forms.NumericUpDown();
            this.cbxCompareMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudVarThreshold = new System.Windows.Forms.NumericUpDown();
            this.nudDilation = new System.Windows.Forms.NumericUpDown();
            this.nudAbsThreshold = new System.Windows.Forms.NumericUpDown();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cebxEdgeMod = new System.Windows.Forms.CheckBox();
            this.btnCreateMode = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.lblModePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.btnClearRoi = new System.Windows.Forms.Button();
            this.btnAddRoi = new System.Windows.Forms.Button();
            this.btnSaveRoi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRoiPath = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.cebxIsRectangle = new System.Windows.Forms.CheckBox();
            this.cebxIsCross = new System.Windows.Forms.CheckBox();
            this.cebxIsSelectedRegions = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudHigAera = new System.Windows.Forms.NumericUpDown();
            this.nudHigNum = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.cebxNums = new System.Windows.Forms.CheckBox();
            this.nudLowNum = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxArea = new System.Windows.Forms.CheckBox();
            this.nudLowAera = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.输出设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedRegionMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedRegionMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDilation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigAera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowAera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.lblForegroundGValMode);
            this.tabPage1.Controls.Add(this.lblBackgroundGValMode);
            this.tabPage1.Controls.Add(this.cebxIllumination);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.输出设置);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // lblForegroundGValMode
            // 
            this.lblForegroundGValMode.AutoSize = true;
            this.lblForegroundGValMode.Location = new System.Drawing.Point(243, 423);
            this.lblForegroundGValMode.Name = "lblForegroundGValMode";
            this.lblForegroundGValMode.Size = new System.Drawing.Size(71, 12);
            this.lblForegroundGValMode.TabIndex = 62;
            this.lblForegroundGValMode.Text = "ForeVal:1.0";
            // 
            // lblBackgroundGValMode
            // 
            this.lblBackgroundGValMode.AutoSize = true;
            this.lblBackgroundGValMode.Location = new System.Drawing.Point(243, 401);
            this.lblBackgroundGValMode.Name = "lblBackgroundGValMode";
            this.lblBackgroundGValMode.Size = new System.Drawing.Size(71, 12);
            this.lblBackgroundGValMode.TabIndex = 61;
            this.lblBackgroundGValMode.Text = "BackVal:1.0";
            // 
            // cebxIllumination
            // 
            this.cebxIllumination.AutoSize = true;
            this.cebxIllumination.Location = new System.Drawing.Point(245, 371);
            this.cebxIllumination.Name = "cebxIllumination";
            this.cebxIllumination.Size = new System.Drawing.Size(96, 16);
            this.cebxIllumination.TabIndex = 59;
            this.cebxIllumination.Text = "光照线性补偿";
            this.cebxIllumination.UseVisualStyleBackColor = true;
            this.cebxIllumination.CheckedChanged += new System.EventHandler(this.cebxIllumination_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 47);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置定位设置";
            // 
            // cebxFixture
            // 
            this.cebxFixture.AutoSize = true;
            this.cebxFixture.Location = new System.Drawing.Point(298, 22);
            this.cebxFixture.Name = "cebxFixture";
            this.cebxFixture.Size = new System.Drawing.Size(48, 16);
            this.cebxFixture.TabIndex = 50;
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
            this.cbxFixture.Size = new System.Drawing.Size(178, 22);
            this.cbxFixture.TabIndex = 0;
            this.cbxFixture.SelectedIndexChanged += new System.EventHandler(this.cbxFixture_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "输入定位位置：";
            // 
            // 输出设置
            // 
            this.输出设置.Controls.Add(this.nudSelectedRegionMin);
            this.输出设置.Controls.Add(this.nudSelectedRegionMax);
            this.输出设置.Controls.Add(this.cbxCompareMode);
            this.输出设置.Controls.Add(this.label5);
            this.输出设置.Controls.Add(this.label4);
            this.输出设置.Controls.Add(this.label3);
            this.输出设置.Controls.Add(this.label2);
            this.输出设置.Location = new System.Drawing.Point(6, 252);
            this.输出设置.Name = "输出设置";
            this.输出设置.Size = new System.Drawing.Size(352, 113);
            this.输出设置.TabIndex = 57;
            this.输出设置.TabStop = false;
            this.输出设置.Text = "搜索差异模型参数";
            // 
            // nudSelectedRegionMin
            // 
            this.nudSelectedRegionMin.Location = new System.Drawing.Point(67, 51);
            this.nudSelectedRegionMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSelectedRegionMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectedRegionMin.Name = "nudSelectedRegionMin";
            this.nudSelectedRegionMin.Size = new System.Drawing.Size(87, 21);
            this.nudSelectedRegionMin.TabIndex = 60;
            this.nudSelectedRegionMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectedRegionMin.ValueChanged += new System.EventHandler(this.nudSelectedRegionMin_ValueChanged);
            // 
            // nudSelectedRegionMax
            // 
            this.nudSelectedRegionMax.Location = new System.Drawing.Point(239, 51);
            this.nudSelectedRegionMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSelectedRegionMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectedRegionMax.Name = "nudSelectedRegionMax";
            this.nudSelectedRegionMax.Size = new System.Drawing.Size(87, 21);
            this.nudSelectedRegionMax.TabIndex = 59;
            this.nudSelectedRegionMax.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSelectedRegionMax.ValueChanged += new System.EventHandler(this.nudSelectedRegionMax_ValueChanged);
            // 
            // cbxCompareMode
            // 
            this.cbxCompareMode.FormattingEnabled = true;
            this.cbxCompareMode.Items.AddRange(new object[] {
            "absolute",
            "light",
            "dark",
            "light_dark"});
            this.cbxCompareMode.Location = new System.Drawing.Point(67, 84);
            this.cbxCompareMode.Name = "cbxCompareMode";
            this.cbxCompareMode.Size = new System.Drawing.Size(259, 20);
            this.cbxCompareMode.TabIndex = 50;
            this.cbxCompareMode.Text = "absolute";
            this.cbxCompareMode.SelectedIndexChanged += new System.EventHandler(this.cbxCompareMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 49;
            this.label5.Text = "差异模式:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "最大";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "最小";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "面积筛选:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudVarThreshold);
            this.groupBox2.Controls.Add(this.nudDilation);
            this.groupBox2.Controls.Add(this.nudAbsThreshold);
            this.groupBox2.Controls.Add(this.nudScale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 89);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "创建差异模型参数";
            // 
            // nudVarThreshold
            // 
            this.nudVarThreshold.DecimalPlaces = 1;
            this.nudVarThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudVarThreshold.Location = new System.Drawing.Point(239, 48);
            this.nudVarThreshold.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudVarThreshold.Name = "nudVarThreshold";
            this.nudVarThreshold.Size = new System.Drawing.Size(87, 21);
            this.nudVarThreshold.TabIndex = 58;
            this.nudVarThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVarThreshold.ValueChanged += new System.EventHandler(this.nudVarThreshold_ValueChanged);
            // 
            // nudDilation
            // 
            this.nudDilation.Location = new System.Drawing.Point(239, 19);
            this.nudDilation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDilation.Name = "nudDilation";
            this.nudDilation.Size = new System.Drawing.Size(87, 21);
            this.nudDilation.TabIndex = 58;
            this.nudDilation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDilation.ValueChanged += new System.EventHandler(this.nudDilation_ValueChanged);
            // 
            // nudAbsThreshold
            // 
            this.nudAbsThreshold.DecimalPlaces = 1;
            this.nudAbsThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAbsThreshold.Location = new System.Drawing.Point(67, 48);
            this.nudAbsThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAbsThreshold.Name = "nudAbsThreshold";
            this.nudAbsThreshold.Size = new System.Drawing.Size(87, 21);
            this.nudAbsThreshold.TabIndex = 58;
            this.nudAbsThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAbsThreshold.ValueChanged += new System.EventHandler(this.nudAbsThreshold_ValueChanged);
            // 
            // nudScale
            // 
            this.nudScale.Location = new System.Drawing.Point(67, 19);
            this.nudScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScale.Name = "nudScale";
            this.nudScale.Size = new System.Drawing.Size(87, 21);
            this.nudScale.TabIndex = 57;
            this.nudScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScale.ValueChanged += new System.EventHandler(this.nudScale_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 50;
            this.label8.Text = "绝对阀值:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 53;
            this.label9.Text = "阀值:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "轮廓缩放:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 47;
            this.label7.Text = "轮廓膨胀:";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(103, 10);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(249, 26);
            this.tbxToolName.TabIndex = 12;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(97, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(249, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 1;
            this.label30.Text = "输入图像：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(30, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 11;
            this.label31.Text = "工具名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.lblModePath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbxRegion);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.lblRoiPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cebxEdgeMod);
            this.groupBox3.Controls.Add(this.btnCreateMode);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.btnAddMode);
            this.groupBox3.Controls.Add(this.btnSaveModel);
            this.groupBox3.Location = new System.Drawing.Point(6, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 142);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "差异模板";
            // 
            // cebxEdgeMod
            // 
            this.cebxEdgeMod.AutoSize = true;
            this.cebxEdgeMod.Location = new System.Drawing.Point(262, 107);
            this.cebxEdgeMod.Name = "cebxEdgeMod";
            this.cebxEdgeMod.Size = new System.Drawing.Size(84, 16);
            this.cebxEdgeMod.TabIndex = 126;
            this.cebxEdgeMod.Text = "亚像素边缘";
            this.cebxEdgeMod.UseVisualStyleBackColor = true;
            this.cebxEdgeMod.CheckedChanged += new System.EventHandler(this.cebxEdgeMod_CheckedChanged);
            // 
            // btnCreateMode
            // 
            this.btnCreateMode.Location = new System.Drawing.Point(262, 20);
            this.btnCreateMode.Name = "btnCreateMode";
            this.btnCreateMode.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMode.TabIndex = 125;
            this.btnCreateMode.Text = "创建模板";
            this.btnCreateMode.UseVisualStyleBackColor = true;
            this.btnCreateMode.Click += new System.EventHandler(this.btnCreateMode_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(4, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(255, 112);
            this.listBox2.TabIndex = 124;
            // 
            // btnAddMode
            // 
            this.btnAddMode.Location = new System.Drawing.Point(262, 49);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(75, 23);
            this.btnAddMode.TabIndex = 113;
            this.btnAddMode.Text = "加载模板";
            this.btnAddMode.UseVisualStyleBackColor = true;
            this.btnAddMode.Click += new System.EventHandler(this.btnAddMode_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(262, 78);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveModel.TabIndex = 115;
            this.btnSaveModel.Text = "保存模板";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // lblModePath
            // 
            this.lblModePath.AutoSize = true;
            this.lblModePath.Location = new System.Drawing.Point(8, 440);
            this.lblModePath.Name = "lblModePath";
            this.lblModePath.Size = new System.Drawing.Size(29, 12);
            this.lblModePath.TabIndex = 123;
            this.lblModePath.Text = "C://";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 120;
            this.label1.Text = "区域交互：";
            // 
            // cbxRegion
            // 
            this.cbxRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(76, 3);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(213, 27);
            this.cbxRegion.TabIndex = 119;
            this.cbxRegion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxRegion_DrawItem);
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(17, 61);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(59, 12);
            this.label38.TabIndex = 118;
            this.label38.Text = "ROI类型：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(77, 46);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(213, 27);
            this.cbxRoi.TabIndex = 116;
            this.cbxRoi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxRoi_DrawItem);
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbxRoi_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDrawRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnClearRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnAddRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveRoi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(76, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 69);
            this.flowLayoutPanel1.TabIndex = 121;
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(3, 3);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(83, 27);
            this.btnDrawRoi.TabIndex = 2;
            this.btnDrawRoi.Text = "创建ROI区域";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btnDrawRoi_Click);
            // 
            // btnClearRoi
            // 
            this.btnClearRoi.Location = new System.Drawing.Point(92, 3);
            this.btnClearRoi.Name = "btnClearRoi";
            this.btnClearRoi.Size = new System.Drawing.Size(83, 27);
            this.btnClearRoi.TabIndex = 6;
            this.btnClearRoi.Text = "清除ROI区域";
            this.btnClearRoi.UseVisualStyleBackColor = true;
            this.btnClearRoi.Click += new System.EventHandler(this.btnClearRoi_Click);
            // 
            // btnAddRoi
            // 
            this.btnAddRoi.Location = new System.Drawing.Point(3, 36);
            this.btnAddRoi.Name = "btnAddRoi";
            this.btnAddRoi.Size = new System.Drawing.Size(83, 27);
            this.btnAddRoi.TabIndex = 7;
            this.btnAddRoi.Text = "加载ROI区域";
            this.btnAddRoi.UseVisualStyleBackColor = true;
            this.btnAddRoi.Click += new System.EventHandler(this.btnAddRoi_Click);
            // 
            // btnSaveRoi
            // 
            this.btnSaveRoi.Location = new System.Drawing.Point(92, 36);
            this.btnSaveRoi.Name = "btnSaveRoi";
            this.btnSaveRoi.Size = new System.Drawing.Size(83, 27);
            this.btnSaveRoi.TabIndex = 8;
            this.btnSaveRoi.Text = "保存ROI区域";
            this.btnSaveRoi.UseVisualStyleBackColor = true;
            this.btnSaveRoi.Click += new System.EventHandler(this.btnSaveRoi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 100);
            this.listBox1.TabIndex = 114;
            // 
            // lblRoiPath
            // 
            this.lblRoiPath.AutoSize = true;
            this.lblRoiPath.Location = new System.Drawing.Point(11, 257);
            this.lblRoiPath.Name = "lblRoiPath";
            this.lblRoiPath.Size = new System.Drawing.Size(29, 12);
            this.lblRoiPath.TabIndex = 122;
            this.lblRoiPath.Text = "C://";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cbxSetdraw);
            this.tabPage3.Controls.Add(this.cebxIsRectangle);
            this.tabPage3.Controls.Add(this.cebxIsCross);
            this.tabPage3.Controls.Add(this.cebxIsSelectedRegions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(364, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "显示：";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(80, 128);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 8;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // cebxIsRectangle
            // 
            this.cebxIsRectangle.AutoSize = true;
            this.cebxIsRectangle.BackColor = System.Drawing.Color.Silver;
            this.cebxIsRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsRectangle.Location = new System.Drawing.Point(80, 88);
            this.cebxIsRectangle.Name = "cebxIsRectangle";
            this.cebxIsRectangle.Size = new System.Drawing.Size(94, 16);
            this.cebxIsRectangle.TabIndex = 7;
            this.cebxIsRectangle.Text = "显示最小矩形";
            this.cebxIsRectangle.UseVisualStyleBackColor = false;
            this.cebxIsRectangle.CheckedChanged += new System.EventHandler(this.cebxIsRectangle_CheckedChanged);
            // 
            // cebxIsCross
            // 
            this.cebxIsCross.AutoSize = true;
            this.cebxIsCross.BackColor = System.Drawing.Color.Silver;
            this.cebxIsCross.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsCross.Location = new System.Drawing.Point(80, 55);
            this.cebxIsCross.Name = "cebxIsCross";
            this.cebxIsCross.Size = new System.Drawing.Size(70, 16);
            this.cebxIsCross.TabIndex = 6;
            this.cebxIsCross.Text = "显示斑点";
            this.cebxIsCross.UseVisualStyleBackColor = false;
            this.cebxIsCross.CheckedChanged += new System.EventHandler(this.cebxIsCross_CheckedChanged_1);
            // 
            // cebxIsSelectedRegions
            // 
            this.cebxIsSelectedRegions.AutoSize = true;
            this.cebxIsSelectedRegions.BackColor = System.Drawing.Color.Silver;
            this.cebxIsSelectedRegions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsSelectedRegions.Location = new System.Drawing.Point(80, 21);
            this.cebxIsSelectedRegions.Name = "cebxIsSelectedRegions";
            this.cebxIsSelectedRegions.Size = new System.Drawing.Size(94, 16);
            this.cebxIsSelectedRegions.TabIndex = 5;
            this.cebxIsSelectedRegions.Text = "显示面积区域";
            this.cebxIsSelectedRegions.UseVisualStyleBackColor = false;
            this.cebxIsSelectedRegions.CheckedChanged += new System.EventHandler(this.cebxIsSelectedRegions_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage4.Controls.Add(this.nudHigAera);
            this.tabPage4.Controls.Add(this.nudHigNum);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.cebxNums);
            this.tabPage4.Controls.Add(this.nudLowNum);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.cebxArea);
            this.tabPage4.Controls.Add(this.nudLowAera);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(364, 455);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // nudHigAera
            // 
            this.nudHigAera.Location = new System.Drawing.Point(172, 398);
            this.nudHigAera.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHigAera.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigAera.Name = "nudHigAera";
            this.nudHigAera.Size = new System.Drawing.Size(76, 21);
            this.nudHigAera.TabIndex = 71;
            this.nudHigAera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigAera.ValueChanged += new System.EventHandler(this.nudHigAera_ValueChanged);
            // 
            // nudHigNum
            // 
            this.nudHigNum.Location = new System.Drawing.Point(172, 425);
            this.nudHigNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHigNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigNum.Name = "nudHigNum";
            this.nudHigNum.Size = new System.Drawing.Size(76, 21);
            this.nudHigNum.TabIndex = 70;
            this.nudHigNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudHigNum.ValueChanged += new System.EventHandler(this.nudHigNum_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 431);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 69;
            this.label26.Text = "数量：";
            // 
            // cebxNums
            // 
            this.cebxNums.AutoSize = true;
            this.cebxNums.Location = new System.Drawing.Point(254, 430);
            this.cebxNums.Name = "cebxNums";
            this.cebxNums.Size = new System.Drawing.Size(48, 16);
            this.cebxNums.TabIndex = 68;
            this.cebxNums.Text = "使用";
            this.cebxNums.UseVisualStyleBackColor = true;
            this.cebxNums.CheckedChanged += new System.EventHandler(this.cebxNums_CheckedChanged);
            // 
            // nudLowNum
            // 
            this.nudLowNum.Location = new System.Drawing.Point(78, 425);
            this.nudLowNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLowNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowNum.Name = "nudLowNum";
            this.nudLowNum.Size = new System.Drawing.Size(76, 21);
            this.nudLowNum.TabIndex = 67;
            this.nudLowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowNum.ValueChanged += new System.EventHandler(this.nudLowNum_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(170, 383);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(78, 383);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(31, 404);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 64;
            this.label29.Text = "面积：";
            // 
            // cebxArea
            // 
            this.cebxArea.AutoSize = true;
            this.cebxArea.Location = new System.Drawing.Point(254, 403);
            this.cebxArea.Name = "cebxArea";
            this.cebxArea.Size = new System.Drawing.Size(48, 16);
            this.cebxArea.TabIndex = 63;
            this.cebxArea.Text = "使用";
            this.cebxArea.UseVisualStyleBackColor = true;
            this.cebxArea.CheckedChanged += new System.EventHandler(this.cebxArea_CheckedChanged);
            // 
            // nudLowAera
            // 
            this.nudLowAera.Location = new System.Drawing.Point(78, 398);
            this.nudLowAera.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLowAera.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowAera.Name = "nudLowAera";
            this.nudLowAera.Size = new System.Drawing.Size(76, 21);
            this.nudLowAera.TabIndex = 62;
            this.nudLowAera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowAera.ValueChanged += new System.EventHandler(this.nudLowAera_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(358, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(305, 511);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(222, 511);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 38;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(12, 511);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 37;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(93, 526);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 40;
            this.lblTimer.Text = "耗时：";
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Location = new System.Drawing.Point(386, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(604, 528);
            this.halconView1.TabIndex = 1;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // frm_PatInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 543);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_PatInspect";
            this.Text = "差异模板";
            this.Load += new System.EventHandler(this.frm_PatInspect_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.输出设置.ResumeLayout(false);
            this.输出设置.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedRegionMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectedRegionMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDilation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigAera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowAera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox 输出设置;
        private System.Windows.Forms.NumericUpDown nudSelectedRegionMax;
        private System.Windows.Forms.ComboBox cbxCompareMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudVarThreshold;
        private System.Windows.Forms.NumericUpDown nudDilation;
        private System.Windows.Forms.NumericUpDown nudAbsThreshold;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.NumericUpDown nudSelectedRegionMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.Button btnClearRoi;
        private System.Windows.Forms.Button btnAddRoi;
        private System.Windows.Forms.Button btnSaveRoi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRoiPath;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Button btnSaveModel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblModePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.CheckBox cebxIsRectangle;
        private System.Windows.Forms.CheckBox cebxIsCross;
        private System.Windows.Forms.CheckBox cebxIsSelectedRegions;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudHigAera;
        private System.Windows.Forms.NumericUpDown nudHigNum;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cebxNums;
        private System.Windows.Forms.NumericUpDown nudLowNum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxArea;
        private System.Windows.Forms.NumericUpDown nudLowAera;
        private System.Windows.Forms.Button btnCreateMode;
        private System.Windows.Forms.CheckBox cebxIllumination;
        private System.Windows.Forms.Label lblForegroundGValMode;
        private System.Windows.Forms.Label lblBackgroundGValMode;
        private System.Windows.Forms.CheckBox cebxEdgeMod;
    }
}