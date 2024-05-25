namespace XFF_Vision.frm_Tool
{
    partial class frm_FindRectangle2
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
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRuleWidth = new System.Windows.Forms.Label();
            this.takBarRuleWidth = new System.Windows.Forms.TrackBar();
            this.lblRuleHigh = new System.Windows.Forms.Label();
            this.takBarRuleHigh = new System.Windows.Forms.TrackBar();
            this.lblRulenums = new System.Windows.Forms.Label();
            this.takBarRulenums = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cebxFitRectangle2 = new System.Windows.Forms.CheckBox();
            this.cebxCross = new System.Windows.Forms.CheckBox();
            this.cebxRule = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.nudHigLen2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cebxLen2 = new System.Windows.Forms.CheckBox();
            this.nudLowLen2 = new System.Windows.Forms.NumericUpDown();
            this.nudHigLen1 = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxLen1 = new System.Windows.Forms.CheckBox();
            this.nudLowLen1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRulenums)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigLen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigLen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(388, 29);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(684, 625);
            this.halconView1.TabIndex = 0;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 607);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.lblRuleWidth);
            this.tabPage1.Controls.Add(this.takBarRuleWidth);
            this.tabPage1.Controls.Add(this.lblRuleHigh);
            this.tabPage1.Controls.Add(this.takBarRuleHigh);
            this.tabPage1.Controls.Add(this.lblRulenums);
            this.tabPage1.Controls.Add(this.takBarRulenums);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudThreshold);
            this.tabPage1.Controls.Add(this.nudSigma);
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
            this.lblRuleWidth.Location = new System.Drawing.Point(337, 426);
            this.lblRuleWidth.Name = "lblRuleWidth";
            this.lblRuleWidth.Size = new System.Drawing.Size(11, 12);
            this.lblRuleWidth.TabIndex = 66;
            this.lblRuleWidth.Text = "0";
            // 
            // takBarRuleWidth
            // 
            this.takBarRuleWidth.BackColor = System.Drawing.Color.DimGray;
            this.takBarRuleWidth.Location = new System.Drawing.Point(80, 411);
            this.takBarRuleWidth.Maximum = 100;
            this.takBarRuleWidth.Minimum = 5;
            this.takBarRuleWidth.Name = "takBarRuleWidth";
            this.takBarRuleWidth.Size = new System.Drawing.Size(251, 45);
            this.takBarRuleWidth.TabIndex = 66;
            this.takBarRuleWidth.Value = 20;
            this.takBarRuleWidth.Scroll += new System.EventHandler(this.takBarRuleWidth_Scroll);
            // 
            // lblRuleHigh
            // 
            this.lblRuleHigh.AutoSize = true;
            this.lblRuleHigh.Location = new System.Drawing.Point(337, 364);
            this.lblRuleHigh.Name = "lblRuleHigh";
            this.lblRuleHigh.Size = new System.Drawing.Size(11, 12);
            this.lblRuleHigh.TabIndex = 65;
            this.lblRuleHigh.Text = "0";
            // 
            // takBarRuleHigh
            // 
            this.takBarRuleHigh.BackColor = System.Drawing.Color.DimGray;
            this.takBarRuleHigh.Location = new System.Drawing.Point(80, 349);
            this.takBarRuleHigh.Maximum = 200;
            this.takBarRuleHigh.Minimum = 5;
            this.takBarRuleHigh.Name = "takBarRuleHigh";
            this.takBarRuleHigh.Size = new System.Drawing.Size(251, 45);
            this.takBarRuleHigh.TabIndex = 65;
            this.takBarRuleHigh.Value = 50;
            this.takBarRuleHigh.Scroll += new System.EventHandler(this.takBarRuleHigh_Scroll);
            // 
            // lblRulenums
            // 
            this.lblRulenums.AutoSize = true;
            this.lblRulenums.Location = new System.Drawing.Point(337, 301);
            this.lblRulenums.Name = "lblRulenums";
            this.lblRulenums.Size = new System.Drawing.Size(11, 12);
            this.lblRulenums.TabIndex = 64;
            this.lblRulenums.Text = "0";
            // 
            // takBarRulenums
            // 
            this.takBarRulenums.BackColor = System.Drawing.Color.DimGray;
            this.takBarRulenums.Location = new System.Drawing.Point(80, 286);
            this.takBarRulenums.Maximum = 200;
            this.takBarRulenums.Minimum = 10;
            this.takBarRulenums.Name = "takBarRulenums";
            this.takBarRulenums.Size = new System.Drawing.Size(251, 45);
            this.takBarRulenums.TabIndex = 64;
            this.takBarRulenums.Value = 20;
            this.takBarRulenums.Scroll += new System.EventHandler(this.takBarRulenums_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 63;
            this.label9.Text = "卡尺宽度：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 62;
            this.label10.Text = "卡尺高度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 61;
            this.label11.Text = "卡尺数量：";
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
            this.label4.Text = "卡尺工具名：";
            // 
            // nudThreshold
            // 
            this.nudThreshold.Location = new System.Drawing.Point(81, 237);
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
            this.nudSigma.Location = new System.Drawing.Point(81, 182);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbntSelectAll);
            this.groupBox2.Controls.Add(this.rbntSelectLast);
            this.groupBox2.Controls.Add(this.rbntSelectFirst);
            this.groupBox2.Location = new System.Drawing.Point(280, 171);
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
            this.groupBox1.Location = new System.Drawing.Point(174, 171);
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
            this.label2.Location = new System.Drawing.Point(22, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "平滑值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "阈值：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Controls.Add(this.btnDrawRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "ROI：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(50, 77);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(168, 20);
            this.cbxRoi.TabIndex = 19;
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbxRoi_SelectedIndexChanged);
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(244, 75);
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
            this.tabPage3.Controls.Add(this.cebxFitRectangle2);
            this.tabPage3.Controls.Add(this.cebxCross);
            this.tabPage3.Controls.Add(this.cebxRule);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
            // 
            // cebxFitRectangle2
            // 
            this.cebxFitRectangle2.AutoSize = true;
            this.cebxFitRectangle2.Location = new System.Drawing.Point(49, 112);
            this.cebxFitRectangle2.Name = "cebxFitRectangle2";
            this.cebxFitRectangle2.Size = new System.Drawing.Size(96, 16);
            this.cebxFitRectangle2.TabIndex = 41;
            this.cebxFitRectangle2.Text = "拟合矩形图形";
            this.cebxFitRectangle2.UseVisualStyleBackColor = true;
            this.cebxFitRectangle2.CheckedChanged += new System.EventHandler(this.cebxFitRectangle2_CheckedChanged);
            // 
            // cebxCross
            // 
            this.cebxCross.AutoSize = true;
            this.cebxCross.Location = new System.Drawing.Point(49, 69);
            this.cebxCross.Name = "cebxCross";
            this.cebxCross.Size = new System.Drawing.Size(108, 16);
            this.cebxCross.TabIndex = 39;
            this.cebxCross.Text = "卡尺标记点图形";
            this.cebxCross.UseVisualStyleBackColor = true;
            this.cebxCross.CheckedChanged += new System.EventHandler(this.cebxCross_CheckedChanged);
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
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.nudScale);
            this.tabPage4.Controls.Add(this.nudHigLen2);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.cebxLen2);
            this.tabPage4.Controls.Add(this.nudLowLen2);
            this.tabPage4.Controls.Add(this.nudHigLen1);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.cebxLen1);
            this.tabPage4.Controls.Add(this.nudLowLen1);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(376, 581);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 85;
            this.label7.Text = "比例：";
            // 
            // nudScale
            // 
            this.nudScale.DecimalPlaces = 5;
            this.nudScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScale.Location = new System.Drawing.Point(90, 456);
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
            this.nudScale.TabIndex = 84;
            this.nudScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScale.ValueChanged += new System.EventHandler(this.nudScale_ValueChanged);
            // 
            // nudHigLen2
            // 
            this.nudHigLen2.DecimalPlaces = 2;
            this.nudHigLen2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHigLen2.Location = new System.Drawing.Point(184, 540);
            this.nudHigLen2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHigLen2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigLen2.Name = "nudHigLen2";
            this.nudHigLen2.Size = new System.Drawing.Size(76, 21);
            this.nudHigLen2.TabIndex = 71;
            this.nudHigLen2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHigLen2.ValueChanged += new System.EventHandler(this.nudHigLen2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "宽度：";
            // 
            // cebxLen2
            // 
            this.cebxLen2.AutoSize = true;
            this.cebxLen2.Location = new System.Drawing.Point(266, 545);
            this.cebxLen2.Name = "cebxLen2";
            this.cebxLen2.Size = new System.Drawing.Size(48, 16);
            this.cebxLen2.TabIndex = 69;
            this.cebxLen2.Text = "使用";
            this.cebxLen2.UseVisualStyleBackColor = true;
            this.cebxLen2.CheckedChanged += new System.EventHandler(this.cebxLen2_CheckedChanged);
            // 
            // nudLowLen2
            // 
            this.nudLowLen2.DecimalPlaces = 2;
            this.nudLowLen2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLowLen2.Location = new System.Drawing.Point(90, 540);
            this.nudLowLen2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLowLen2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowLen2.Name = "nudLowLen2";
            this.nudLowLen2.Size = new System.Drawing.Size(76, 21);
            this.nudLowLen2.TabIndex = 68;
            this.nudLowLen2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowLen2.ValueChanged += new System.EventHandler(this.nudLowLen2_ValueChanged);
            // 
            // nudHigLen1
            // 
            this.nudHigLen1.DecimalPlaces = 2;
            this.nudHigLen1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHigLen1.Location = new System.Drawing.Point(184, 513);
            this.nudHigLen1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHigLen1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigLen1.Name = "nudHigLen1";
            this.nudHigLen1.Size = new System.Drawing.Size(76, 21);
            this.nudHigLen1.TabIndex = 67;
            this.nudHigLen1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHigLen1.ValueChanged += new System.EventHandler(this.nudHigLen1_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(182, 498);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(90, 498);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(43, 519);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 64;
            this.label29.Text = "长度：";
            // 
            // cebxLen1
            // 
            this.cebxLen1.AutoSize = true;
            this.cebxLen1.Location = new System.Drawing.Point(266, 518);
            this.cebxLen1.Name = "cebxLen1";
            this.cebxLen1.Size = new System.Drawing.Size(48, 16);
            this.cebxLen1.TabIndex = 63;
            this.cebxLen1.Text = "使用";
            this.cebxLen1.UseVisualStyleBackColor = true;
            this.cebxLen1.CheckedChanged += new System.EventHandler(this.cebxLen1_CheckedChanged);
            // 
            // nudLowLen1
            // 
            this.nudLowLen1.DecimalPlaces = 2;
            this.nudLowLen1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLowLen1.Location = new System.Drawing.Point(90, 513);
            this.nudLowLen1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLowLen1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowLen1.Name = "nudLowLen1";
            this.nudLowLen1.Size = new System.Drawing.Size(76, 21);
            this.nudLowLen1.TabIndex = 62;
            this.nudLowLen1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowLen1.ValueChanged += new System.EventHandler(this.nudLowLen1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(370, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(184, 638);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 29;
            this.lblResult.Text = "FAIL";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(86, 638);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(310, 625);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(229, 625);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 26;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(5, 625);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 25;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // frm_FindRectangle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 662);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Name = "frm_FindRectangle2";
            this.Text = "找矩形";
            this.Load += new System.EventHandler(this.frm_FindCorner_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRuleHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarRulenums)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigLen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigLen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.NumericUpDown nudSigma;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cebxCross;
        private System.Windows.Forms.CheckBox cebxRule;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.NumericUpDown nudHigLen2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cebxLen2;
        private System.Windows.Forms.NumericUpDown nudLowLen2;
        private System.Windows.Forms.NumericUpDown nudHigLen1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxLen1;
        private System.Windows.Forms.NumericUpDown nudLowLen1;
        private System.Windows.Forms.CheckBox cebxFitRectangle2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.TrackBar takBarRuleWidth;
        private System.Windows.Forms.TrackBar takBarRuleHigh;
        private System.Windows.Forms.TrackBar takBarRulenums;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRuleWidth;
        private System.Windows.Forms.Label lblRuleHigh;
        private System.Windows.Forms.Label lblRulenums;
    }
}