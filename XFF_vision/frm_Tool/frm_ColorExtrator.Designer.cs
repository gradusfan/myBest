namespace XFF_Vision.frm_Tool
{
    partial class frm_ColorExtrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ColorExtrator));
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cebxIsColorType = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxColorType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxAreaMax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxAreaMin = new System.Windows.Forms.TextBox();
            this.nudHueRangesMin = new System.Windows.Forms.NumericUpDown();
            this.nudHueRangesMax = new System.Windows.Forms.NumericUpDown();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ceboxIsRoi = new System.Windows.Forms.CheckBox();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudHigNum = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxNums = new System.Windows.Forms.CheckBox();
            this.nudLowNum = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueRangesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueRangesMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(390, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(614, 537);
            this.halconView1.TabIndex = 1;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cebxIsColorType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxColorType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbxAreaMax);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxAreaMin);
            this.groupBox2.Controls.Add(this.nudHueRangesMin);
            this.groupBox2.Controls.Add(this.nudHueRangesMax);
            this.groupBox2.Location = new System.Drawing.Point(7, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 176);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分割设置";
            // 
            // cebxIsColorType
            // 
            this.cebxIsColorType.AutoSize = true;
            this.cebxIsColorType.Location = new System.Drawing.Point(189, 84);
            this.cebxIsColorType.Name = "cebxIsColorType";
            this.cebxIsColorType.Size = new System.Drawing.Size(48, 16);
            this.cebxIsColorType.TabIndex = 52;
            this.cebxIsColorType.Text = "使用";
            this.cebxIsColorType.UseVisualStyleBackColor = true;
            this.cebxIsColorType.CheckedChanged += new System.EventHandler(this.cebxIsColorType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 113;
            this.label2.Text = "颜色抽取：";
            // 
            // cbxColorType
            // 
            this.cbxColorType.FormattingEnabled = true;
            this.cbxColorType.Items.AddRange(new object[] {
            "Orange",
            "Red",
            "Blue",
            "Yellow",
            "Green"});
            this.cbxColorType.Location = new System.Drawing.Point(96, 80);
            this.cbxColorType.Name = "cbxColorType";
            this.cbxColorType.Size = new System.Drawing.Size(75, 20);
            this.cbxColorType.TabIndex = 112;
            this.cbxColorType.SelectedIndexChanged += new System.EventHandler(this.cbxColorType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 105;
            this.label6.Text = "下限值：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 106;
            this.label12.Text = "上限值：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 107;
            this.label14.Text = "最小面积：";
            // 
            // tbxAreaMax
            // 
            this.tbxAreaMax.Location = new System.Drawing.Point(258, 53);
            this.tbxAreaMax.Name = "tbxAreaMax";
            this.tbxAreaMax.Size = new System.Drawing.Size(73, 21);
            this.tbxAreaMax.TabIndex = 111;
            this.tbxAreaMax.Text = "999999";
            this.tbxAreaMax.TextChanged += new System.EventHandler(this.tbxAreaMax_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 108;
            this.label13.Text = "最大面积：";
            // 
            // tbxAreaMin
            // 
            this.tbxAreaMin.Location = new System.Drawing.Point(96, 53);
            this.tbxAreaMin.Name = "tbxAreaMin";
            this.tbxAreaMin.Size = new System.Drawing.Size(68, 21);
            this.tbxAreaMin.TabIndex = 110;
            this.tbxAreaMin.Text = "1000";
            this.tbxAreaMin.TextChanged += new System.EventHandler(this.tbxAreaMin_TextChanged);
            // 
            // nudHueRangesMin
            // 
            this.nudHueRangesMin.Location = new System.Drawing.Point(96, 24);
            this.nudHueRangesMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHueRangesMin.Name = "nudHueRangesMin";
            this.nudHueRangesMin.Size = new System.Drawing.Size(67, 21);
            this.nudHueRangesMin.TabIndex = 104;
            this.nudHueRangesMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHueRangesMin.ValueChanged += new System.EventHandler(this.nudHueRangesMin_ValueChanged);
            // 
            // nudHueRangesMax
            // 
            this.nudHueRangesMax.Location = new System.Drawing.Point(258, 24);
            this.nudHueRangesMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHueRangesMax.Name = "nudHueRangesMax";
            this.nudHueRangesMax.Size = new System.Drawing.Size(74, 21);
            this.nudHueRangesMax.TabIndex = 109;
            this.nudHueRangesMax.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudHueRangesMax.ValueChanged += new System.EventHandler(this.nudHueRangesMax_ValueChanged);
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(104, 9);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(229, 26);
            this.tbxToolName.TabIndex = 63;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbxImage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 52);
            this.groupBox3.TabIndex = 61;
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
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "颜色抽取工具名：";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 56);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置定位设置";
            // 
            // cebxFixture
            // 
            this.cebxFixture.AutoSize = true;
            this.cebxFixture.Location = new System.Drawing.Point(310, 20);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.ceboxIsRoi);
            this.tabPage2.Controls.Add(this.btnDrawRoi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // ceboxIsRoi
            // 
            this.ceboxIsRoi.AutoSize = true;
            this.ceboxIsRoi.Location = new System.Drawing.Point(66, 82);
            this.ceboxIsRoi.Name = "ceboxIsRoi";
            this.ceboxIsRoi.Size = new System.Drawing.Size(96, 16);
            this.ceboxIsRoi.TabIndex = 70;
            this.ceboxIsRoi.Text = "使用限定区域";
            this.ceboxIsRoi.UseVisualStyleBackColor = true;
            this.ceboxIsRoi.CheckedChanged += new System.EventHandler(this.ceboxIsRoi_CheckedChanged);
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(240, 40);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(93, 23);
            this.btnDrawRoi.TabIndex = 69;
            this.btnDrawRoi.Text = "创建ROI区域";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btnDrawRoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "ROI：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(66, 43);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(168, 20);
            this.cbxRoi.TabIndex = 67;
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbxRoi_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage4.Controls.Add(this.nudHigNum);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.cebxNums);
            this.tabPage4.Controls.Add(this.nudLowNum);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(376, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // nudHigNum
            // 
            this.nudHigNum.Location = new System.Drawing.Point(186, 457);
            this.nudHigNum.Maximum = new decimal(new int[] {
            999999,
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
            this.nudHigNum.TabIndex = 74;
            this.nudHigNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHigNum.ValueChanged += new System.EventHandler(this.nudHigNum_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(184, 442);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 73;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(92, 442);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 72;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 463);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 71;
            this.label29.Text = "数量";
            // 
            // cebxNums
            // 
            this.cebxNums.AutoSize = true;
            this.cebxNums.Location = new System.Drawing.Point(268, 462);
            this.cebxNums.Name = "cebxNums";
            this.cebxNums.Size = new System.Drawing.Size(48, 16);
            this.cebxNums.TabIndex = 70;
            this.cebxNums.Text = "使用";
            this.cebxNums.UseVisualStyleBackColor = true;
            this.cebxNums.CheckedChanged += new System.EventHandler(this.cebxNums_CheckedChanged);
            // 
            // nudLowNum
            // 
            this.nudLowNum.Location = new System.Drawing.Point(92, 457);
            this.nudLowNum.Maximum = new decimal(new int[] {
            999999,
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
            this.nudLowNum.TabIndex = 69;
            this.nudLowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowNum.ValueChanged += new System.EventHandler(this.nudLowNum_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(370, 420);
            this.dataGridView1.TabIndex = 68;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(85, 533);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(309, 520);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(228, 520);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 31;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(4, 520);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 30;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // frm_ColorExtrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 552);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Name = "frm_ColorExtrator";
            this.Text = "颜色提取";
            this.Load += new System.EventHandler(this.frm_ColorExtrator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueRangesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueRangesMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxAreaMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxAreaMin;
        private System.Windows.Forms.NumericUpDown nudHueRangesMin;
        private System.Windows.Forms.NumericUpDown nudHueRangesMax;
        private System.Windows.Forms.CheckBox cebxIsColorType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxColorType;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.NumericUpDown nudHigNum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxNums;
        private System.Windows.Forms.NumericUpDown nudLowNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ceboxIsRoi;
    }
}