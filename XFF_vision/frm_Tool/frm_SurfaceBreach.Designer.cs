
namespace XFF_Vision.frm_Tool
{
    partial class frm_SurfaceBreach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SurfaceBreach));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudLowThreshold = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudHighThreshold = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchRoi = new System.Windows.Forms.Button();
            this.ceboxSeath = new System.Windows.Forms.CheckBox();
            this.nudMaskWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMaskHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudEnhanceHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudEnhanceNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudEnhanceWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudrectHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudrectWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cebxIsSurfaceFlaw = new System.Windows.Forms.CheckBox();
            this.halconView1 = new ViewControl.HalconView();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxMethods = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrectHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudrectWidth)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(-109, 530);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 65;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(-194, 509);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 62;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 71;
            this.label1.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(268, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 70;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(187, 512);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 69;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 68;
            this.button1.Text = "运行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 494);
            this.tabControl1.TabIndex = 67;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.cbxMethods);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btnSearchRoi);
            this.tabPage1.Controls.Add(this.ceboxSeath);
            this.tabPage1.Controls.Add(this.nudMaskWidth);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.nudMaskHeight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.nudLowThreshold);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudHighThreshold);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 80);
            this.groupBox4.TabIndex = 96;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "二值化";
            // 
            // nudLowThreshold
            // 
            this.nudLowThreshold.Location = new System.Drawing.Point(74, 20);
            this.nudLowThreshold.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudLowThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowThreshold.Name = "nudLowThreshold";
            this.nudLowThreshold.Size = new System.Drawing.Size(238, 21);
            this.nudLowThreshold.TabIndex = 82;
            this.nudLowThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "阈值-低：";
            // 
            // nudHighThreshold
            // 
            this.nudHighThreshold.Location = new System.Drawing.Point(74, 47);
            this.nudHighThreshold.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudHighThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHighThreshold.Name = "nudHighThreshold";
            this.nudHighThreshold.Size = new System.Drawing.Size(238, 21);
            this.nudHighThreshold.TabIndex = 82;
            this.nudHighThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 79;
            this.label11.Text = "阈值-高：";
            // 
            // btnSearchRoi
            // 
            this.btnSearchRoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoi.Location = new System.Drawing.Point(11, 393);
            this.btnSearchRoi.Name = "btnSearchRoi";
            this.btnSearchRoi.Size = new System.Drawing.Size(120, 25);
            this.btnSearchRoi.TabIndex = 94;
            this.btnSearchRoi.Text = "创建裁剪区域";
            this.btnSearchRoi.UseVisualStyleBackColor = true;
            this.btnSearchRoi.Click += new System.EventHandler(this.btnSearchRoi_Click);
            // 
            // ceboxSeath
            // 
            this.ceboxSeath.AutoSize = true;
            this.ceboxSeath.Location = new System.Drawing.Point(11, 434);
            this.ceboxSeath.Name = "ceboxSeath";
            this.ceboxSeath.Size = new System.Drawing.Size(96, 16);
            this.ceboxSeath.TabIndex = 95;
            this.ceboxSeath.Text = "使用裁剪区域";
            this.ceboxSeath.UseVisualStyleBackColor = true;
            this.ceboxSeath.CheckedChanged += new System.EventHandler(this.ceboxSeath_CheckedChanged);
            // 
            // nudMaskWidth
            // 
            this.nudMaskWidth.Location = new System.Drawing.Point(77, 327);
            this.nudMaskWidth.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudMaskWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaskWidth.Name = "nudMaskWidth";
            this.nudMaskWidth.Size = new System.Drawing.Size(238, 21);
            this.nudMaskWidth.TabIndex = 82;
            this.nudMaskWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "腐蚀宽度：";
            // 
            // nudMaskHeight
            // 
            this.nudMaskHeight.Location = new System.Drawing.Point(77, 300);
            this.nudMaskHeight.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudMaskHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaskHeight.Name = "nudMaskHeight";
            this.nudMaskHeight.Size = new System.Drawing.Size(238, 21);
            this.nudMaskHeight.TabIndex = 82;
            this.nudMaskHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 79;
            this.label2.Text = "腐蚀高度：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(77, 11);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(238, 26);
            this.tbxToolName.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(3, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 45);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(74, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(238, 22);
            this.cbxImage.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 1;
            this.label30.Text = "输入图像：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 68;
            this.label31.Text = "工具名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 468);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "参数";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.nudEnhanceHeight);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudEnhanceNum);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nudEnhanceWidth);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(5, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 103);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像增强";
            // 
            // nudEnhanceHeight
            // 
            this.nudEnhanceHeight.Location = new System.Drawing.Point(74, 20);
            this.nudEnhanceHeight.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudEnhanceHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnhanceHeight.Name = "nudEnhanceHeight";
            this.nudEnhanceHeight.Size = new System.Drawing.Size(238, 21);
            this.nudEnhanceHeight.TabIndex = 82;
            this.nudEnhanceHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 79;
            this.label7.Text = "掩膜高度：";
            // 
            // nudEnhanceNum
            // 
            this.nudEnhanceNum.Location = new System.Drawing.Point(74, 74);
            this.nudEnhanceNum.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudEnhanceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnhanceNum.Name = "nudEnhanceNum";
            this.nudEnhanceNum.Size = new System.Drawing.Size(238, 21);
            this.nudEnhanceNum.TabIndex = 82;
            this.nudEnhanceNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "增强系数：";
            // 
            // nudEnhanceWidth
            // 
            this.nudEnhanceWidth.Location = new System.Drawing.Point(74, 47);
            this.nudEnhanceWidth.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudEnhanceWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnhanceWidth.Name = "nudEnhanceWidth";
            this.nudEnhanceWidth.Size = new System.Drawing.Size(238, 21);
            this.nudEnhanceWidth.TabIndex = 82;
            this.nudEnhanceWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 79;
            this.label8.Text = "掩膜宽度：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nudrectHeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudrectWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 80);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "掩膜矩形";
            // 
            // nudrectHeight
            // 
            this.nudrectHeight.Location = new System.Drawing.Point(74, 20);
            this.nudrectHeight.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudrectHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudrectHeight.Name = "nudrectHeight";
            this.nudrectHeight.Size = new System.Drawing.Size(238, 21);
            this.nudrectHeight.TabIndex = 82;
            this.nudrectHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 79;
            this.label5.Text = "矩形高度：";
            // 
            // nudrectWidth
            // 
            this.nudrectWidth.Location = new System.Drawing.Point(74, 47);
            this.nudrectWidth.Maximum = new decimal(new int[] {
            501,
            0,
            0,
            0});
            this.nudrectWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudrectWidth.Name = "nudrectWidth";
            this.nudrectWidth.Size = new System.Drawing.Size(238, 21);
            this.nudrectWidth.TabIndex = 82;
            this.nudrectWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "矩形宽度：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.cbxSetdraw);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cebxIsSurfaceFlaw);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(336, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(59, 22);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 75;
            this.cbxSetdraw.Text = "fill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 74;
            this.label3.Text = "显示：";
            // 
            // cebxIsSurfaceFlaw
            // 
            this.cebxIsSurfaceFlaw.AutoSize = true;
            this.cebxIsSurfaceFlaw.BackColor = System.Drawing.Color.Silver;
            this.cebxIsSurfaceFlaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsSurfaceFlaw.Location = new System.Drawing.Point(59, 58);
            this.cebxIsSurfaceFlaw.Name = "cebxIsSurfaceFlaw";
            this.cebxIsSurfaceFlaw.Size = new System.Drawing.Size(94, 16);
            this.cebxIsSurfaceFlaw.TabIndex = 72;
            this.cebxIsSurfaceFlaw.Text = "显示瑕疵区域";
            this.cebxIsSurfaceFlaw.UseVisualStyleBackColor = false;
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(349, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.ShowStatus1 = false;
            this.halconView1.ShowStatus2 = false;
            this.halconView1.Size = new System.Drawing.Size(654, 529);
            this.halconView1.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 79;
            this.label12.Text = "填充方式：";
            // 
            // cbxMethods
            // 
            this.cbxMethods.FormattingEnabled = true;
            this.cbxMethods.Items.AddRange(new object[] {
            "convex",
            "ellipse",
            "outer_circle",
            "inner_circle",
            "rectangle1",
            "rectangle2",
            "inner_rectangle1",
            "inner_rectangle2"});
            this.cbxMethods.Location = new System.Drawing.Point(77, 200);
            this.cbxMethods.Name = "cbxMethods";
            this.cbxMethods.Size = new System.Drawing.Size(238, 20);
            this.cbxMethods.TabIndex = 97;
            this.cbxMethods.Text = "convex";
            // 
            // frm_SurfaceBreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_run);
            this.MaximizeBox = false;
            this.Name = "frm_SurfaceBreach";
            this.Text = "缺口检测";
            this.Load += new System.EventHandler(this.frm_SurfaceBreach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnhanceWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrectHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudrectWidth)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudMaskHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cebxIsSurfaceFlaw;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.NumericUpDown nudMaskWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchRoi;
        private System.Windows.Forms.CheckBox ceboxSeath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudLowThreshold;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudHighThreshold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudEnhanceHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudEnhanceNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudEnhanceWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudrectHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudrectWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxMethods;
    }
}