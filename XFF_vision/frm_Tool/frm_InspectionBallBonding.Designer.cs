﻿namespace XFF_Vision.frm_Tool
{
    partial class frm_InspectionBallBonding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InspectionBallBonding));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudOpeningCircle = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.hSrlBarAreaMax = new System.Windows.Forms.HScrollBar();
            this.hSrlBarAreaMin = new System.Windows.Forms.HScrollBar();
            this.lbl_higt = new System.Windows.Forms.Label();
            this.lbl_areaMax = new System.Windows.Forms.Label();
            this.lbl_low = new System.Windows.Forms.Label();
            this.lbl_areaMin = new System.Windows.Forms.Label();
            this.takBarHigThreshold = new System.Windows.Forms.TrackBar();
            this.takBarLowThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRoiPath = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.btnClearRoi = new System.Windows.Forms.Button();
            this.btnAddRoi = new System.Windows.Forms.Button();
            this.btnSaveRoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.cebxIsCross = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudHigAera = new System.Windows.Forms.NumericUpDown();
            this.nudHigNum = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.cebxNums = new System.Windows.Forms.CheckBox();
            this.nudLowNum = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxDiameter = new System.Windows.Forms.CheckBox();
            this.nudLowAera = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.halconView1 = new ViewControl.HalconView();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpeningCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarHigThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarLowThreshold)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(384, 607);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cebxFixture);
            this.groupBox3.Controls.Add(this.cbxFixture);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "位置定位设置";
            // 
            // cebxFixture
            // 
            this.cebxFixture.AutoSize = true;
            this.cebxFixture.Location = new System.Drawing.Point(315, 20);
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
            this.cbxFixture.Size = new System.Drawing.Size(209, 22);
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
            this.tbxToolName.Location = new System.Drawing.Point(100, 8);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(229, 26);
            this.tbxToolName.TabIndex = 3;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbx_toolName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nudOpeningCircle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.hSrlBarAreaMax);
            this.groupBox2.Controls.Add(this.hSrlBarAreaMin);
            this.groupBox2.Controls.Add(this.lbl_higt);
            this.groupBox2.Controls.Add(this.lbl_areaMax);
            this.groupBox2.Controls.Add(this.lbl_low);
            this.groupBox2.Controls.Add(this.lbl_areaMin);
            this.groupBox2.Controls.Add(this.takBarHigThreshold);
            this.groupBox2.Controls.Add(this.takBarLowThreshold);
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分割设置";
            // 
            // nudOpeningCircle
            // 
            this.nudOpeningCircle.DecimalPlaces = 1;
            this.nudOpeningCircle.Location = new System.Drawing.Point(97, 332);
            this.nudOpeningCircle.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudOpeningCircle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudOpeningCircle.Name = "nudOpeningCircle";
            this.nudOpeningCircle.Size = new System.Drawing.Size(265, 21);
            this.nudOpeningCircle.TabIndex = 92;
            this.nudOpeningCircle.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudOpeningCircle.ValueChanged += new System.EventHandler(this.nudOpeningCircle_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 91;
            this.label7.Text = "圆开运算：";
            // 
            // hSrlBarAreaMax
            // 
            this.hSrlBarAreaMax.Location = new System.Drawing.Point(7, 270);
            this.hSrlBarAreaMax.Maximum = 999999;
            this.hSrlBarAreaMax.Name = "hSrlBarAreaMax";
            this.hSrlBarAreaMax.Size = new System.Drawing.Size(355, 33);
            this.hSrlBarAreaMax.TabIndex = 10;
            this.hSrlBarAreaMax.Value = 499999;
            this.hSrlBarAreaMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSrlBar_areaMax_Scroll);
            // 
            // hSrlBarAreaMin
            // 
            this.hSrlBarAreaMin.Location = new System.Drawing.Point(8, 192);
            this.hSrlBarAreaMin.Maximum = 999999;
            this.hSrlBarAreaMin.Name = "hSrlBarAreaMin";
            this.hSrlBarAreaMin.Size = new System.Drawing.Size(354, 33);
            this.hSrlBarAreaMin.TabIndex = 8;
            this.hSrlBarAreaMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSrlBar_areaMin_Scroll);
            // 
            // lbl_higt
            // 
            this.lbl_higt.AutoSize = true;
            this.lbl_higt.Location = new System.Drawing.Point(6, 94);
            this.lbl_higt.Name = "lbl_higt";
            this.lbl_higt.Size = new System.Drawing.Size(41, 12);
            this.lbl_higt.TabIndex = 3;
            this.lbl_higt.Text = "高阀值";
            // 
            // lbl_areaMax
            // 
            this.lbl_areaMax.AutoSize = true;
            this.lbl_areaMax.Location = new System.Drawing.Point(5, 247);
            this.lbl_areaMax.Name = "lbl_areaMax";
            this.lbl_areaMax.Size = new System.Drawing.Size(101, 12);
            this.lbl_areaMax.TabIndex = 8;
            this.lbl_areaMax.Text = "最大面积填补限定";
            // 
            // lbl_low
            // 
            this.lbl_low.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lbl_low.AutoSize = true;
            this.lbl_low.Location = new System.Drawing.Point(5, 22);
            this.lbl_low.Name = "lbl_low";
            this.lbl_low.Size = new System.Drawing.Size(41, 12);
            this.lbl_low.TabIndex = 2;
            this.lbl_low.Text = "低阀值";
            // 
            // lbl_areaMin
            // 
            this.lbl_areaMin.AutoSize = true;
            this.lbl_areaMin.Location = new System.Drawing.Point(7, 169);
            this.lbl_areaMin.Name = "lbl_areaMin";
            this.lbl_areaMin.Size = new System.Drawing.Size(101, 12);
            this.lbl_areaMin.TabIndex = 7;
            this.lbl_areaMin.Text = "最小面积填补限定";
            // 
            // takBarHigThreshold
            // 
            this.takBarHigThreshold.BackColor = System.Drawing.SystemColors.WindowText;
            this.takBarHigThreshold.Location = new System.Drawing.Point(8, 109);
            this.takBarHigThreshold.Maximum = 255;
            this.takBarHigThreshold.Name = "takBarHigThreshold";
            this.takBarHigThreshold.Size = new System.Drawing.Size(355, 45);
            this.takBarHigThreshold.TabIndex = 1;
            this.takBarHigThreshold.Value = 130;
            this.takBarHigThreshold.Scroll += new System.EventHandler(this.takBar_higt_Scroll);
            // 
            // takBarLowThreshold
            // 
            this.takBarLowThreshold.BackColor = System.Drawing.SystemColors.WindowText;
            this.takBarLowThreshold.Location = new System.Drawing.Point(8, 37);
            this.takBarLowThreshold.Maximum = 255;
            this.takBarLowThreshold.Name = "takBarLowThreshold";
            this.takBarLowThreshold.Size = new System.Drawing.Size(355, 45);
            this.takBarLowThreshold.TabIndex = 0;
            this.takBarLowThreshold.Scroll += new System.EventHandler(this.takBar_low_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(97, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(229, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbx_image_SelectedIndexChanged);
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
            this.label4.Location = new System.Drawing.Point(1, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "焊点检测工具名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.lblRoiPath);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbxRegion);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // lblRoiPath
            // 
            this.lblRoiPath.AutoSize = true;
            this.lblRoiPath.Location = new System.Drawing.Point(6, 194);
            this.lblRoiPath.Name = "lblRoiPath";
            this.lblRoiPath.Size = new System.Drawing.Size(35, 12);
            this.lblRoiPath.TabIndex = 10;
            this.lblRoiPath.Text = "C ;//";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDrawRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnClearRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnAddRoi);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveRoi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(68, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 69);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(3, 3);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(83, 27);
            this.btnDrawRoi.TabIndex = 2;
            this.btnDrawRoi.Text = "创建ROI区域";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btn_drawRoi_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "区域交互：";
            // 
            // cbxRegion
            // 
            this.cbxRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(68, 15);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(213, 27);
            this.cbxRegion.TabIndex = 4;
            this.cbxRegion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxRegion_DrawItem);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(6, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 340);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROI类型：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(68, 59);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(213, 27);
            this.cbxRoi.TabIndex = 0;
            this.cbxRoi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxRoi_DrawItem);
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbx_roi_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cbxSetdraw);
            this.tabPage3.Controls.Add(this.cebxIsCross);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "显示：";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(69, 94);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 3;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // cebxIsCross
            // 
            this.cebxIsCross.AutoSize = true;
            this.cebxIsCross.BackColor = System.Drawing.Color.Silver;
            this.cebxIsCross.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsCross.Location = new System.Drawing.Point(69, 60);
            this.cebxIsCross.Name = "cebxIsCross";
            this.cebxIsCross.Size = new System.Drawing.Size(70, 16);
            this.cebxIsCross.TabIndex = 1;
            this.cebxIsCross.Text = "显示斑点";
            this.cebxIsCross.UseVisualStyleBackColor = false;
            this.cebxIsCross.CheckedChanged += new System.EventHandler(this.cebxIsCross_CheckedChanged);
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
            this.tabPage4.Controls.Add(this.cebxDiameter);
            this.tabPage4.Controls.Add(this.nudLowAera);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(376, 581);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // nudHigAera
            // 
            this.nudHigAera.DecimalPlaces = 3;
            this.nudHigAera.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHigAera.Location = new System.Drawing.Point(182, 519);
            this.nudHigAera.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHigAera.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudHigAera.Name = "nudHigAera";
            this.nudHigAera.Size = new System.Drawing.Size(76, 21);
            this.nudHigAera.TabIndex = 61;
            this.nudHigAera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigAera.ValueChanged += new System.EventHandler(this.nudHigAera_ValueChanged);
            // 
            // nudHigNum
            // 
            this.nudHigNum.Location = new System.Drawing.Point(182, 546);
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
            this.nudHigNum.TabIndex = 57;
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
            this.label26.Location = new System.Drawing.Point(41, 552);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 50;
            this.label26.Text = "数量：";
            // 
            // cebxNums
            // 
            this.cebxNums.AutoSize = true;
            this.cebxNums.Location = new System.Drawing.Point(264, 551);
            this.cebxNums.Name = "cebxNums";
            this.cebxNums.Size = new System.Drawing.Size(48, 16);
            this.cebxNums.TabIndex = 49;
            this.cebxNums.Text = "使用";
            this.cebxNums.UseVisualStyleBackColor = true;
            this.cebxNums.CheckedChanged += new System.EventHandler(this.cebxNums_CheckedChanged);
            // 
            // nudLowNum
            // 
            this.nudLowNum.Location = new System.Drawing.Point(88, 546);
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
            this.nudLowNum.TabIndex = 48;
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
            this.label27.Location = new System.Drawing.Point(180, 504);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 47;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(88, 504);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 46;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(41, 525);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 45;
            this.label29.Text = "直径：";
            // 
            // cebxDiameter
            // 
            this.cebxDiameter.AutoSize = true;
            this.cebxDiameter.Location = new System.Drawing.Point(264, 524);
            this.cebxDiameter.Name = "cebxDiameter";
            this.cebxDiameter.Size = new System.Drawing.Size(48, 16);
            this.cebxDiameter.TabIndex = 44;
            this.cebxDiameter.Text = "使用";
            this.cebxDiameter.UseVisualStyleBackColor = true;
            this.cebxDiameter.CheckedChanged += new System.EventHandler(this.cebxDiameter_CheckedChanged);
            // 
            // nudLowAera
            // 
            this.nudLowAera.DecimalPlaces = 3;
            this.nudLowAera.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLowAera.Location = new System.Drawing.Point(88, 519);
            this.nudLowAera.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLowAera.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLowAera.Name = "nudLowAera";
            this.nudLowAera.Size = new System.Drawing.Size(76, 21);
            this.nudLowAera.TabIndex = 43;
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
            this.dataGridView1.Size = new System.Drawing.Size(370, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(12, 623);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 5;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(236, 623);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 6;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(317, 623);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(93, 636);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "耗时：";
            // 
            // halconView1
            // 
            this.halconView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(402, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(672, 640);
            this.halconView1.TabIndex = 13;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(191, 636);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "FAIL";
            // 
            // frm_InspectionBallBonding
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
            this.Name = "frm_InspectionBallBonding";
            this.Text = "焊点检测";
            this.Load += new System.EventHandler(this.frm_InspectionBallBonding_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpeningCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarHigThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarLowThreshold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_areaMax;
        private System.Windows.Forms.Label lbl_areaMin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cebxIsCross;
        private System.Windows.Forms.HScrollBar hSrlBarAreaMax;
        private System.Windows.Forms.HScrollBar hSrlBarAreaMin;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown nudHigNum;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cebxNums;
        private System.Windows.Forms.NumericUpDown nudLowNum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxDiameter;
        private System.Windows.Forms.NumericUpDown nudLowAera;
        private System.Windows.Forms.NumericUpDown nudHigAera;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearRoi;
        private System.Windows.Forms.Button btnAddRoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSaveRoi;
        private System.Windows.Forms.Label lblRoiPath;
        private System.Windows.Forms.Label lbl_higt;
        private System.Windows.Forms.Label lbl_low;
        private System.Windows.Forms.TrackBar takBarHigThreshold;
        private System.Windows.Forms.TrackBar takBarLowThreshold;
        private System.Windows.Forms.NumericUpDown nudOpeningCircle;
        private System.Windows.Forms.Label label7;
    }
}