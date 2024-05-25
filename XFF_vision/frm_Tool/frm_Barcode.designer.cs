﻿namespace XFF_Vision.frm_Tool
{
    partial class frm_Barcode
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
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTimerOut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cebxFixture = new System.Windows.Forms.CheckBox();
            this.cbxFixture = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRoi = new System.Windows.Forms.ComboBox();
            this.btnDrawRoi = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nudHigNum = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxNums = new System.Windows.Forms.CheckBox();
            this.nudLowNum = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.cebxIsRegion = new System.Windows.Forms.CheckBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerOut)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Location = new System.Drawing.Point(390, 22);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(614, 524);
            this.halconView1.TabIndex = 0;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 513);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.cbxType);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nudTimerOut);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // cbxType
            // 
            this.cbxType.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "auto",
            "2/5 Industrial",
            "EAN-8",
            "GS1-128",
            "2/5 Interleaved",
            "EAN-8 Add-On 2",
            "GS1 DataBar Omnidir",
            "Codabar",
            "EAN-8 Add-On 5",
            "GS1 DataBar Truncated",
            "Code 39",
            "EAN-13",
            "GS1 DataBar Stacked",
            "Code 32 (converted from Code 39)",
            "EAN-13 Add-On 2",
            "GS1 DataBar Stacked Omnidir",
            "Code 93",
            "EAN-13 Add-On 5",
            "GS1 DataBar Limited",
            "Code 128",
            "UPC-A",
            "GS1 DataBar Expanded",
            "MSI",
            "UPC-A Add-On 2",
            "GS1 DataBar",
            "Expanded Stacked",
            "PharmaCode",
            "UPC-A Add-On 5\t",
            "UPC-E\t",
            "UPC-E Add-On 2\t",
            "UPC-E Add-On 5"});
            this.cbxType.Location = new System.Drawing.Point(101, 222);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(230, 20);
            this.cbxType.TabIndex = 64;
            this.cbxType.Text = "auto";
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "类型：";
            // 
            // nudTimerOut
            // 
            this.nudTimerOut.Location = new System.Drawing.Point(102, 186);
            this.nudTimerOut.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudTimerOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerOut.Name = "nudTimerOut";
            this.nudTimerOut.Size = new System.Drawing.Size(74, 21);
            this.nudTimerOut.TabIndex = 62;
            this.nudTimerOut.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTimerOut.ValueChanged += new System.EventHandler(this.nudTimerOut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 61;
            this.label2.Text = "识别时间：";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cebxFixture);
            this.groupBox4.Controls.Add(this.cbxFixture);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(3, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 56);
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
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "二维码工具名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.cebxIsRegion);
            this.tabPage2.Controls.Add(this.cbxRegion);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxRoi);
            this.tabPage2.Controls.Add(this.btnDrawRoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "区域";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "ROI：";
            // 
            // cbxRoi
            // 
            this.cbxRoi.FormattingEnabled = true;
            this.cbxRoi.Location = new System.Drawing.Point(69, 80);
            this.cbxRoi.Name = "cbxRoi";
            this.cbxRoi.Size = new System.Drawing.Size(168, 20);
            this.cbxRoi.TabIndex = 19;
            this.cbxRoi.SelectedIndexChanged += new System.EventHandler(this.cbxRoi_SelectedIndexChanged);
            // 
            // btnDrawRoi
            // 
            this.btnDrawRoi.Location = new System.Drawing.Point(254, 77);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(376, 487);
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
            this.tabPage4.Size = new System.Drawing.Size(376, 487);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "结果";
            // 
            // nudHigNum
            // 
            this.nudHigNum.Location = new System.Drawing.Point(186, 451);
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
            this.nudHigNum.TabIndex = 67;
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
            this.label27.Location = new System.Drawing.Point(184, 436);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(92, 436);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 457);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 64;
            this.label29.Text = "位数";
            // 
            // cebxNums
            // 
            this.cebxNums.AutoSize = true;
            this.cebxNums.Location = new System.Drawing.Point(268, 456);
            this.cebxNums.Name = "cebxNums";
            this.cebxNums.Size = new System.Drawing.Size(48, 16);
            this.cebxNums.TabIndex = 63;
            this.cebxNums.Text = "使用";
            this.cebxNums.UseVisualStyleBackColor = true;
            this.cebxNums.CheckedChanged += new System.EventHandler(this.cebxNums_CheckedChanged);
            // 
            // nudLowNum
            // 
            this.nudLowNum.Location = new System.Drawing.Point(92, 451);
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
            this.nudLowNum.TabIndex = 62;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(370, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(183, 532);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 30;
            this.lblResult.Text = "FAIL";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(83, 532);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 29;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(307, 519);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(226, 519);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 27;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(2, 519);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 26;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // cebxIsRegion
            // 
            this.cebxIsRegion.AutoSize = true;
            this.cebxIsRegion.Location = new System.Drawing.Point(271, 35);
            this.cebxIsRegion.Name = "cebxIsRegion";
            this.cebxIsRegion.Size = new System.Drawing.Size(48, 16);
            this.cebxIsRegion.TabIndex = 54;
            this.cebxIsRegion.Text = "使用";
            this.cebxIsRegion.UseVisualStyleBackColor = true;
            // 
            // cbxRegion
            // 
            this.cbxRegion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(69, 29);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(196, 22);
            this.cbxRegion.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 53;
            this.label14.Text = "输入区域：";
            // 
            // frm_Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 552);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.Name = "frm_Barcode";
            this.Text = "条形码识别";
            this.Load += new System.EventHandler(this.frm_2DSymbol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerOut)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cebxFixture;
        private System.Windows.Forms.ComboBox cbxFixture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDrawRoi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown nudHigNum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cebxNums;
        private System.Windows.Forms.NumericUpDown nudLowNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.NumericUpDown nudTimerOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxRoi;
        private System.Windows.Forms.CheckBox cebxIsRegion;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label14;
    }
}