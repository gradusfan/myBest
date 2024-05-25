namespace XFF_Vision.frm_Tool
{
    partial class frm_DistancePointPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DistancePointPoint));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.cbxPointName1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPointName2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.nudHmeasure = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxMeasure = new System.Windows.Forms.CheckBox();
            this.nudLmeasure = new System.Windows.Forms.NumericUpDown();
            this.halconView1 = new ViewControl.HalconView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.nudHmeasure1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cebxMeasure1 = new System.Windows.Forms.CheckBox();
            this.nudLmeasure1 = new System.Windows.Forms.NumericUpDown();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.nudHmeasure2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cebxMeasure2 = new System.Windows.Forms.CheckBox();
            this.nudLmeasure2 = new System.Windows.Forms.NumericUpDown();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.设置 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.设置.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(89, 529);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 47;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(274, 514);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 46;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(193, 514);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 45;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(8, 514);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 44;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // cbxPointName1
            // 
            this.cbxPointName1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxPointName1.FormattingEnabled = true;
            this.cbxPointName1.Location = new System.Drawing.Point(75, 114);
            this.cbxPointName1.Name = "cbxPointName1";
            this.cbxPointName1.Size = new System.Drawing.Size(245, 22);
            this.cbxPointName1.TabIndex = 43;
            this.cbxPointName1.SelectedIndexChanged += new System.EventHandler(this.cbxPointName1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "点1选择：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(101, 11);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(205, 26);
            this.tbxToolName.TabIndex = 41;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "点到点工具名：";
            // 
            // cbxPointName2
            // 
            this.cbxPointName2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxPointName2.FormattingEnabled = true;
            this.cbxPointName2.Location = new System.Drawing.Point(75, 146);
            this.cbxPointName2.Name = "cbxPointName2";
            this.cbxPointName2.Size = new System.Drawing.Size(245, 22);
            this.cbxPointName2.TabIndex = 49;
            this.cbxPointName2.SelectedIndexChanged += new System.EventHandler(this.cbxPointName2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "点2选择：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "结果：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 239);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(11, 12);
            this.lblResult.TabIndex = 51;
            this.lblResult.Text = "0";
            // 
            // nudHmeasure
            // 
            this.nudHmeasure.DecimalPlaces = 2;
            this.nudHmeasure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHmeasure.Location = new System.Drawing.Point(204, 233);
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
            this.nudHmeasure.Size = new System.Drawing.Size(65, 21);
            this.nudHmeasure.TabIndex = 73;
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
            this.label27.Location = new System.Drawing.Point(228, 218);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 72;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(136, 218);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 71;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 239);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 70;
            this.label29.Text = "间距1：";
            // 
            // cebxMeasure
            // 
            this.cebxMeasure.AutoSize = true;
            this.cebxMeasure.Location = new System.Drawing.Point(275, 238);
            this.cebxMeasure.Name = "cebxMeasure";
            this.cebxMeasure.Size = new System.Drawing.Size(48, 16);
            this.cebxMeasure.TabIndex = 69;
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
            this.nudLmeasure.Location = new System.Drawing.Point(101, 233);
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
            this.nudLmeasure.Size = new System.Drawing.Size(65, 21);
            this.nudLmeasure.TabIndex = 68;
            this.nudLmeasure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure.ValueChanged += new System.EventHandler(this.nudLmeasure_ValueChanged);
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(355, 11);
            this.halconView1.Name = "halconView1";
            this.halconView1.ShowStatus1 = false;
            this.halconView1.ShowStatus2 = false;
            this.halconView1.Size = new System.Drawing.Size(648, 532);
            this.halconView1.TabIndex = 74;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 52);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(68, 20);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(229, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "输入图像：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 83;
            this.label9.Text = "比例：";
            // 
            // nudScale
            // 
            this.nudScale.DecimalPlaces = 5;
            this.nudScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScale.Location = new System.Drawing.Point(75, 181);
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
            // nudHmeasure1
            // 
            this.nudHmeasure1.DecimalPlaces = 2;
            this.nudHmeasure1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHmeasure1.Location = new System.Drawing.Point(204, 261);
            this.nudHmeasure1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHmeasure1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHmeasure1.Name = "nudHmeasure1";
            this.nudHmeasure1.Size = new System.Drawing.Size(65, 21);
            this.nudHmeasure1.TabIndex = 88;
            this.nudHmeasure1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHmeasure1.ValueChanged += new System.EventHandler(this.nudHmeasure1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 87;
            this.label6.Text = "间距2：";
            // 
            // cebxMeasure1
            // 
            this.cebxMeasure1.AutoSize = true;
            this.cebxMeasure1.Location = new System.Drawing.Point(275, 266);
            this.cebxMeasure1.Name = "cebxMeasure1";
            this.cebxMeasure1.Size = new System.Drawing.Size(48, 16);
            this.cebxMeasure1.TabIndex = 86;
            this.cebxMeasure1.Text = "使用";
            this.cebxMeasure1.UseVisualStyleBackColor = true;
            this.cebxMeasure1.CheckedChanged += new System.EventHandler(this.cebxMeasure1_CheckedChanged);
            // 
            // nudLmeasure1
            // 
            this.nudLmeasure1.DecimalPlaces = 1;
            this.nudLmeasure1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLmeasure1.Location = new System.Drawing.Point(101, 260);
            this.nudLmeasure1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLmeasure1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure1.Name = "nudLmeasure1";
            this.nudLmeasure1.Size = new System.Drawing.Size(65, 21);
            this.nudLmeasure1.TabIndex = 85;
            this.nudLmeasure1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure1.ValueChanged += new System.EventHandler(this.nudLmeasure1_ValueChanged);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(60, 270);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(11, 12);
            this.lblResult1.TabIndex = 84;
            this.lblResult1.Text = "0";
            // 
            // nudHmeasure2
            // 
            this.nudHmeasure2.DecimalPlaces = 2;
            this.nudHmeasure2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHmeasure2.Location = new System.Drawing.Point(204, 288);
            this.nudHmeasure2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHmeasure2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHmeasure2.Name = "nudHmeasure2";
            this.nudHmeasure2.Size = new System.Drawing.Size(65, 21);
            this.nudHmeasure2.TabIndex = 93;
            this.nudHmeasure2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHmeasure2.ValueChanged += new System.EventHandler(this.nudHmeasure2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 92;
            this.label8.Text = "间距3：";
            // 
            // cebxMeasure2
            // 
            this.cebxMeasure2.AutoSize = true;
            this.cebxMeasure2.Location = new System.Drawing.Point(275, 293);
            this.cebxMeasure2.Name = "cebxMeasure2";
            this.cebxMeasure2.Size = new System.Drawing.Size(48, 16);
            this.cebxMeasure2.TabIndex = 91;
            this.cebxMeasure2.Text = "使用";
            this.cebxMeasure2.UseVisualStyleBackColor = true;
            this.cebxMeasure2.CheckedChanged += new System.EventHandler(this.cebxMeasure2_CheckedChanged);
            // 
            // nudLmeasure2
            // 
            this.nudLmeasure2.DecimalPlaces = 1;
            this.nudLmeasure2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLmeasure2.Location = new System.Drawing.Point(101, 288);
            this.nudLmeasure2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLmeasure2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure2.Name = "nudLmeasure2";
            this.nudLmeasure2.Size = new System.Drawing.Size(65, 21);
            this.nudLmeasure2.TabIndex = 90;
            this.nudLmeasure2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure2.ValueChanged += new System.EventHandler(this.nudLmeasure2_ValueChanged);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(60, 297);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(11, 12);
            this.lblResult2.TabIndex = 89;
            this.lblResult2.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.设置);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 496);
            this.tabControl1.TabIndex = 94;
            // 
            // 设置
            // 
            this.设置.BackColor = System.Drawing.Color.DodgerBlue;
            this.设置.Controls.Add(this.checkBox1);
            this.设置.Controls.Add(this.tbxToolName);
            this.设置.Controls.Add(this.nudHmeasure2);
            this.设置.Controls.Add(this.label4);
            this.设置.Controls.Add(this.label8);
            this.设置.Controls.Add(this.groupBox1);
            this.设置.Controls.Add(this.cebxMeasure2);
            this.设置.Controls.Add(this.label1);
            this.设置.Controls.Add(this.nudLmeasure2);
            this.设置.Controls.Add(this.cbxPointName1);
            this.设置.Controls.Add(this.lblResult2);
            this.设置.Controls.Add(this.label2);
            this.设置.Controls.Add(this.nudHmeasure1);
            this.设置.Controls.Add(this.cbxPointName2);
            this.设置.Controls.Add(this.label6);
            this.设置.Controls.Add(this.label9);
            this.设置.Controls.Add(this.cebxMeasure1);
            this.设置.Controls.Add(this.nudScale);
            this.设置.Controls.Add(this.nudLmeasure1);
            this.设置.Controls.Add(this.label3);
            this.设置.Controls.Add(this.lblResult1);
            this.设置.Controls.Add(this.lblResult);
            this.设置.Controls.Add(this.nudLmeasure);
            this.设置.Controls.Add(this.nudHmeasure);
            this.设置.Controls.Add(this.cebxMeasure);
            this.设置.Controls.Add(this.label27);
            this.设置.Controls.Add(this.label29);
            this.设置.Controls.Add(this.label28);
            this.设置.Location = new System.Drawing.Point(4, 22);
            this.设置.Name = "设置";
            this.设置.Padding = new System.Windows.Forms.Padding(3);
            this.设置.Size = new System.Drawing.Size(333, 470);
            this.设置.TabIndex = 0;
            this.设置.Text = "设置";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 331);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 94;
            this.checkBox1.Text = "显示图形结果";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frm_DistancePointPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DistancePointPoint";
            this.Text = "点到点测量";
            this.Load += new System.EventHandler(this.frm_DistancePointPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.设置.ResumeLayout(false);
            this.设置.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ComboBox cbxPointName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPointName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown nudHmeasure;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxMeasure;
        private System.Windows.Forms.NumericUpDown nudLmeasure;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.NumericUpDown nudHmeasure1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cebxMeasure1;
        private System.Windows.Forms.NumericUpDown nudLmeasure1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.NumericUpDown nudHmeasure2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cebxMeasure2;
        private System.Windows.Forms.NumericUpDown nudLmeasure2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 设置;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}