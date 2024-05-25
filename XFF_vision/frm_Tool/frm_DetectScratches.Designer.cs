namespace XFF_Vision.frm_Tool
{
    partial class frm_DetectScratches
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxScratchProperty = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaxScratchLength = new System.Windows.Forms.NumericUpDown();
            this.nudMinScratchLength = new System.Windows.Forms.NumericUpDown();
            this.nudSigma = new System.Windows.Forms.NumericUpDown();
            this.nudScratchContrast = new System.Windows.Forms.NumericUpDown();
            this.nudScratchWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ceboxIsRoi = new System.Windows.Forms.CheckBox();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.cebxIsRectangle = new System.Windows.Forms.CheckBox();
            this.cebxIsScratchesXLD = new System.Windows.Forms.CheckBox();
            this.halconView1 = new ViewControl.HalconView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxScratchLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinScratchLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScratchContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScratchWidth)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxScratchProperty);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudMaxScratchLength);
            this.groupBox2.Controls.Add(this.nudMinScratchLength);
            this.groupBox2.Controls.Add(this.nudSigma);
            this.groupBox2.Controls.Add(this.nudScratchContrast);
            this.groupBox2.Controls.Add(this.nudScratchWidth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 283);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // cbxScratchProperty
            // 
            this.cbxScratchProperty.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxScratchProperty.FormattingEnabled = true;
            this.cbxScratchProperty.Items.AddRange(new object[] {
            "light",
            "dark"});
            this.cbxScratchProperty.Location = new System.Drawing.Point(89, 150);
            this.cbxScratchProperty.Name = "cbxScratchProperty";
            this.cbxScratchProperty.Size = new System.Drawing.Size(227, 22);
            this.cbxScratchProperty.TabIndex = 51;
            this.cbxScratchProperty.SelectedIndexChanged += new System.EventHandler(this.cbxScratchProperty_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "划痕属性：";
            // 
            // nudMaxScratchLength
            // 
            this.nudMaxScratchLength.Location = new System.Drawing.Point(89, 123);
            this.nudMaxScratchLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMaxScratchLength.Name = "nudMaxScratchLength";
            this.nudMaxScratchLength.Size = new System.Drawing.Size(227, 21);
            this.nudMaxScratchLength.TabIndex = 9;
            this.nudMaxScratchLength.ValueChanged += new System.EventHandler(this.nudMaxScratchLength_ValueChanged);
            // 
            // nudMinScratchLength
            // 
            this.nudMinScratchLength.Location = new System.Drawing.Point(89, 96);
            this.nudMinScratchLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMinScratchLength.Name = "nudMinScratchLength";
            this.nudMinScratchLength.Size = new System.Drawing.Size(227, 21);
            this.nudMinScratchLength.TabIndex = 8;
            this.nudMinScratchLength.ValueChanged += new System.EventHandler(this.nudMinScratchLength_ValueChanged);
            // 
            // nudSigma
            // 
            this.nudSigma.DecimalPlaces = 1;
            this.nudSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSigma.Location = new System.Drawing.Point(89, 69);
            this.nudSigma.Name = "nudSigma";
            this.nudSigma.Size = new System.Drawing.Size(227, 21);
            this.nudSigma.TabIndex = 7;
            this.nudSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudSigma.ValueChanged += new System.EventHandler(this.nudSigma_ValueChanged);
            // 
            // nudScratchContrast
            // 
            this.nudScratchContrast.DecimalPlaces = 1;
            this.nudScratchContrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScratchContrast.Location = new System.Drawing.Point(89, 42);
            this.nudScratchContrast.Name = "nudScratchContrast";
            this.nudScratchContrast.Size = new System.Drawing.Size(227, 21);
            this.nudScratchContrast.TabIndex = 6;
            this.nudScratchContrast.ValueChanged += new System.EventHandler(this.nudScratchContrast_ValueChanged);
            // 
            // nudScratchWidth
            // 
            this.nudScratchWidth.DecimalPlaces = 1;
            this.nudScratchWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScratchWidth.Location = new System.Drawing.Point(89, 15);
            this.nudScratchWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScratchWidth.Name = "nudScratchWidth";
            this.nudScratchWidth.Size = new System.Drawing.Size(227, 21);
            this.nudScratchWidth.TabIndex = 5;
            this.nudScratchWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScratchWidth.ValueChanged += new System.EventHandler(this.nudScratchWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "划痕最大长度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "划痕最小长度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "平滑：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "划痕对比度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "划痕宽度：";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(3, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 47);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置定位设置";
            // 
            // cebxFixture
            // 
            this.cebxFixture.AutoSize = true;
            this.cebxFixture.Location = new System.Drawing.Point(274, 20);
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
            this.cbxFixture.Location = new System.Drawing.Point(83, 16);
            this.cbxFixture.Name = "cbxFixture";
            this.cbxFixture.Size = new System.Drawing.Size(185, 22);
            this.cbxFixture.TabIndex = 0;
            this.cbxFixture.SelectedIndexChanged += new System.EventHandler(this.cbxFixture_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "输入定位位置：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(80, 13);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(238, 26);
            this.tbxToolName.TabIndex = 61;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 45);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(77, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(239, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
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
            this.label31.Location = new System.Drawing.Point(21, 27);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 60;
            this.label31.Text = "工具名：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.ceboxIsRoi);
            this.tabPage3.Controls.Add(this.btnDrawRoi);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbxRoi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(336, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "区域";
            // 
            // ceboxIsRoi
            // 
            this.ceboxIsRoi.AutoSize = true;
            this.ceboxIsRoi.Location = new System.Drawing.Point(218, 75);
            this.ceboxIsRoi.Name = "ceboxIsRoi";
            this.ceboxIsRoi.Size = new System.Drawing.Size(96, 16);
            this.ceboxIsRoi.TabIndex = 62;
            this.ceboxIsRoi.Text = "使用限定区域";
            this.ceboxIsRoi.UseVisualStyleBackColor = true;
            this.ceboxIsRoi.CheckedChanged += new System.EventHandler(this.ceboxIsRoi_CheckedChanged);
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(221, 27);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(93, 23);
            this.btnDrawRoi.TabIndex = 14;
            this.btnDrawRoi.Text = "创建ROI区域";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btnDrawRoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "ROI：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(47, 30);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(168, 20);
            this.cbxRoi.TabIndex = 12;
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbxRoi_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbxSetdraw);
            this.tabPage2.Controls.Add(this.cebxIsRectangle);
            this.tabPage2.Controls.Add(this.cebxIsScratchesXLD);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图形";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 66;
            this.label8.Text = "显示：";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(53, 102);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 65;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // cebxIsRectangle
            // 
            this.cebxIsRectangle.AutoSize = true;
            this.cebxIsRectangle.BackColor = System.Drawing.Color.Silver;
            this.cebxIsRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsRectangle.Location = new System.Drawing.Point(53, 61);
            this.cebxIsRectangle.Name = "cebxIsRectangle";
            this.cebxIsRectangle.Size = new System.Drawing.Size(94, 16);
            this.cebxIsRectangle.TabIndex = 4;
            this.cebxIsRectangle.Text = "显示最小矩形";
            this.cebxIsRectangle.UseVisualStyleBackColor = false;
            this.cebxIsRectangle.CheckedChanged += new System.EventHandler(this.cebxIsRectangle_CheckedChanged);
            // 
            // cebxIsScratchesXLD
            // 
            this.cebxIsScratchesXLD.AutoSize = true;
            this.cebxIsScratchesXLD.BackColor = System.Drawing.Color.Silver;
            this.cebxIsScratchesXLD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsScratchesXLD.Location = new System.Drawing.Point(53, 19);
            this.cebxIsScratchesXLD.Name = "cebxIsScratchesXLD";
            this.cebxIsScratchesXLD.Size = new System.Drawing.Size(94, 16);
            this.cebxIsScratchesXLD.TabIndex = 3;
            this.cebxIsScratchesXLD.Text = "显示划痕区域";
            this.cebxIsScratchesXLD.UseVisualStyleBackColor = false;
            this.cebxIsScratchesXLD.CheckedChanged += new System.EventHandler(this.cebxIsScratchesXLD_CheckedChanged);
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(348, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(641, 519);
            this.halconView1.TabIndex = 1;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(87, 517);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 51;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(267, 502);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(186, 502);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 49;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(2, 502);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 48;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // frm_DetectScratches
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
            this.Name = "frm_DetectScratches";
            this.Text = "划痕提取";
            this.Load += new System.EventHandler(this.frm_DetectScratches_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxScratchLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinScratchLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScratchContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScratchWidth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxScratchLength;
        private System.Windows.Forms.NumericUpDown nudMinScratchLength;
        private System.Windows.Forms.NumericUpDown nudSigma;
        private System.Windows.Forms.NumericUpDown nudScratchContrast;
        private System.Windows.Forms.NumericUpDown nudScratchWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxScratchProperty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.CheckBox cebxIsRectangle;
        private System.Windows.Forms.CheckBox cebxIsScratchesXLD;
        private System.Windows.Forms.CheckBox ceboxIsRoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSetdraw;
    }
}