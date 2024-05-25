namespace XFF_Vision.frm_Tool
{
    partial class frm_SurfaceFlaw
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
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudMaxShapeFlaw = new System.Windows.Forms.NumericUpDown();
            this.nudMinShapeFlaw = new System.Windows.Forms.NumericUpDown();
            this.lbl_areaMax = new System.Windows.Forms.Label();
            this.lbl_areaMin = new System.Windows.Forms.Label();
            this.cbxLightDrak = new System.Windows.Forms.ComboBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.nudMaskHeight = new System.Windows.Forms.NumericUpDown();
            this.nudMaskWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.ceboxIsRoi = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cebxIsRectangle = new System.Windows.Forms.CheckBox();
            this.cebxIsSurfaceFlaw = new System.Windows.Forms.CheckBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxShapeFlaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinShapeFlaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Location = new System.Drawing.Point(348, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(654, 529);
            this.halconView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 494);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.nudMaxShapeFlaw);
            this.tabPage1.Controls.Add(this.nudMinShapeFlaw);
            this.tabPage1.Controls.Add(this.lbl_areaMax);
            this.tabPage1.Controls.Add(this.lbl_areaMin);
            this.tabPage1.Controls.Add(this.cbxLightDrak);
            this.tabPage1.Controls.Add(this.nudOffset);
            this.tabPage1.Controls.Add(this.nudMaskHeight);
            this.tabPage1.Controls.Add(this.nudMaskWidth);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // nudMaxShapeFlaw
            // 
            this.nudMaxShapeFlaw.Location = new System.Drawing.Point(101, 314);
            this.nudMaxShapeFlaw.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMaxShapeFlaw.Name = "nudMaxShapeFlaw";
            this.nudMaxShapeFlaw.Size = new System.Drawing.Size(201, 21);
            this.nudMaxShapeFlaw.TabIndex = 90;
            this.nudMaxShapeFlaw.ValueChanged += new System.EventHandler(this.nudMaxShapeFlaw_ValueChanged);
            // 
            // nudMinShapeFlaw
            // 
            this.nudMinShapeFlaw.Location = new System.Drawing.Point(102, 280);
            this.nudMinShapeFlaw.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMinShapeFlaw.Name = "nudMinShapeFlaw";
            this.nudMinShapeFlaw.Size = new System.Drawing.Size(200, 21);
            this.nudMinShapeFlaw.TabIndex = 89;
            this.nudMinShapeFlaw.ValueChanged += new System.EventHandler(this.nudMinShapeFlaw_ValueChanged);
            // 
            // lbl_areaMax
            // 
            this.lbl_areaMax.AutoSize = true;
            this.lbl_areaMax.Location = new System.Drawing.Point(7, 323);
            this.lbl_areaMax.Name = "lbl_areaMax";
            this.lbl_areaMax.Size = new System.Drawing.Size(89, 12);
            this.lbl_areaMax.TabIndex = 88;
            this.lbl_areaMax.Text = "最大面积限定：";
            // 
            // lbl_areaMin
            // 
            this.lbl_areaMin.AutoSize = true;
            this.lbl_areaMin.Location = new System.Drawing.Point(6, 289);
            this.lbl_areaMin.Name = "lbl_areaMin";
            this.lbl_areaMin.Size = new System.Drawing.Size(89, 12);
            this.lbl_areaMin.TabIndex = 87;
            this.lbl_areaMin.Text = "最小面积限定：";
            // 
            // cbxLightDrak
            // 
            this.cbxLightDrak.FormattingEnabled = true;
            this.cbxLightDrak.Items.AddRange(new object[] {
            "light",
            "dark",
            "equal",
            "not_equal"});
            this.cbxLightDrak.Location = new System.Drawing.Point(102, 246);
            this.cbxLightDrak.Name = "cbxLightDrak";
            this.cbxLightDrak.Size = new System.Drawing.Size(199, 20);
            this.cbxLightDrak.TabIndex = 85;
            this.cbxLightDrak.Text = "light";
            this.cbxLightDrak.SelectedIndexChanged += new System.EventHandler(this.cbxLightDrak_SelectedIndexChanged);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(101, 205);
            this.nudOffset.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            254,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(201, 21);
            this.nudOffset.TabIndex = 84;
            this.nudOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudOffset_ValueChanged);
            // 
            // nudMaskHeight
            // 
            this.nudMaskHeight.Location = new System.Drawing.Point(101, 178);
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
            this.nudMaskHeight.Size = new System.Drawing.Size(201, 21);
            this.nudMaskHeight.TabIndex = 83;
            this.nudMaskHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaskHeight.ValueChanged += new System.EventHandler(this.nudMaskHeight_ValueChanged);
            // 
            // nudMaskWidth
            // 
            this.nudMaskWidth.Location = new System.Drawing.Point(101, 150);
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
            this.nudMaskWidth.Size = new System.Drawing.Size(201, 21);
            this.nudMaskWidth.TabIndex = 82;
            this.nudMaskWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaskWidth.ValueChanged += new System.EventHandler(this.nudMaskWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 81;
            this.label8.Text = "偏移值：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "掩膜高度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 79;
            this.label1.Text = "掩膜宽度：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 86;
            this.label13.Text = "提取区域：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(77, 4);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(238, 26);
            this.tbxToolName.TabIndex = 69;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
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
            this.label31.Location = new System.Drawing.Point(18, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 68;
            this.label31.Text = "工具名：";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 47);
            this.groupBox4.TabIndex = 70;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.btnDrawRoi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Controls.Add(this.ceboxIsRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(221, 19);
            this.btnDrawRoi.Name = "btnDrawRoi";
            this.btnDrawRoi.Size = new System.Drawing.Size(93, 23);
            this.btnDrawRoi.TabIndex = 70;
            this.btnDrawRoi.Text = "创建ROI区域";
            this.btnDrawRoi.UseVisualStyleBackColor = true;
            this.btnDrawRoi.Click += new System.EventHandler(this.btnDrawRoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "ROI：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(47, 22);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(168, 20);
            this.cbxRoi.TabIndex = 68;
            // 
            // ceboxIsRoi
            // 
            this.ceboxIsRoi.AutoSize = true;
            this.ceboxIsRoi.Location = new System.Drawing.Point(221, 65);
            this.ceboxIsRoi.Name = "ceboxIsRoi";
            this.ceboxIsRoi.Size = new System.Drawing.Size(96, 16);
            this.ceboxIsRoi.TabIndex = 67;
            this.ceboxIsRoi.Text = "使用限定区域";
            this.ceboxIsRoi.UseVisualStyleBackColor = true;
            this.ceboxIsRoi.CheckedChanged += new System.EventHandler(this.ceboxIsRoi_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.cbxSetdraw);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cebxIsRectangle);
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
            this.cbxSetdraw.Location = new System.Drawing.Point(58, 98);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 75;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 74;
            this.label2.Text = "显示：";
            // 
            // cebxIsRectangle
            // 
            this.cebxIsRectangle.AutoSize = true;
            this.cebxIsRectangle.BackColor = System.Drawing.Color.Silver;
            this.cebxIsRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsRectangle.Location = new System.Drawing.Point(58, 57);
            this.cebxIsRectangle.Name = "cebxIsRectangle";
            this.cebxIsRectangle.Size = new System.Drawing.Size(94, 16);
            this.cebxIsRectangle.TabIndex = 73;
            this.cebxIsRectangle.Text = "显示最小矩形";
            this.cebxIsRectangle.UseVisualStyleBackColor = false;
            this.cebxIsRectangle.CheckedChanged += new System.EventHandler(this.cebxIsRectangle_CheckedChanged);
            // 
            // cebxIsSurfaceFlaw
            // 
            this.cebxIsSurfaceFlaw.AutoSize = true;
            this.cebxIsSurfaceFlaw.BackColor = System.Drawing.Color.Silver;
            this.cebxIsSurfaceFlaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsSurfaceFlaw.Location = new System.Drawing.Point(58, 15);
            this.cebxIsSurfaceFlaw.Name = "cebxIsSurfaceFlaw";
            this.cebxIsSurfaceFlaw.Size = new System.Drawing.Size(94, 16);
            this.cebxIsSurfaceFlaw.TabIndex = 72;
            this.cebxIsSurfaceFlaw.Text = "显示瑕疵区域";
            this.cebxIsSurfaceFlaw.UseVisualStyleBackColor = false;
            this.cebxIsSurfaceFlaw.CheckedChanged += new System.EventHandler(this.cebxIsSurfaceFlaw_CheckedChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(87, 527);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 59;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(267, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(186, 512);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 57;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(2, 512);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 56;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // frm_SurfaceFlaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Name = "frm_SurfaceFlaw";
            this.Text = "瑕疵提取";
            this.Load += new System.EventHandler(this.frm_SurfaceFlaw_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxShapeFlaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinShapeFlaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaskWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxLightDrak;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.NumericUpDown nudMaskHeight;
        private System.Windows.Forms.NumericUpDown nudMaskWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.CheckBox ceboxIsRoi;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cebxIsRectangle;
        private System.Windows.Forms.CheckBox cebxIsSurfaceFlaw;
        private System.Windows.Forms.NumericUpDown nudMaxShapeFlaw;
        private System.Windows.Forms.NumericUpDown nudMinShapeFlaw;
        private System.Windows.Forms.Label lbl_areaMax;
        private System.Windows.Forms.Label lbl_areaMin;
    }
}