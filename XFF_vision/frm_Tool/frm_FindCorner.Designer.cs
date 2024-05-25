namespace XFF_Vision.frm_Tool
{
    partial class frm_FindCorner
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
            this.cebxCross = new System.Windows.Forms.CheckBox();
            this.cebxRule = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.nudHmeasure = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxMeasure = new System.Windows.Forms.CheckBox();
            this.nudLmeasure = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).BeginInit();
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.tabPage3.Controls.Add(this.cebxCross);
            this.tabPage3.Controls.Add(this.cebxRule);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图形";
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
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.numericUpDown2);
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
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(186, 509);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 21);
            this.numericUpDown1.TabIndex = 71;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "Y：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(268, 514);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "使用";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(92, 509);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 21);
            this.numericUpDown2.TabIndex = 68;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHmeasure
            // 
            this.nudHmeasure.DecimalPlaces = 2;
            this.nudHmeasure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHmeasure.Location = new System.Drawing.Point(186, 482);
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
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(184, 467);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(92, 467);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 488);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 12);
            this.label29.TabIndex = 64;
            this.label29.Text = "X：";
            // 
            // cebxMeasure
            // 
            this.cebxMeasure.AutoSize = true;
            this.cebxMeasure.Location = new System.Drawing.Point(268, 487);
            this.cebxMeasure.Name = "cebxMeasure";
            this.cebxMeasure.Size = new System.Drawing.Size(48, 16);
            this.cebxMeasure.TabIndex = 63;
            this.cebxMeasure.Text = "使用";
            this.cebxMeasure.UseVisualStyleBackColor = true;
            // 
            // nudLmeasure
            // 
            this.nudLmeasure.DecimalPlaces = 1;
            this.nudLmeasure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLmeasure.Location = new System.Drawing.Point(92, 482);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(370, 444);
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
            // frm_FindCorner
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
            this.Name = "frm_FindCorner";
            this.Text = "找顶点";
            this.Load += new System.EventHandler(this.frm_FindCorner_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown nudHmeasure;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxMeasure;
        private System.Windows.Forms.NumericUpDown nudLmeasure;
    }
}