namespace XFF_Vision.frm_Tool
{
    partial class frm_DistanceLineLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DistanceLineLine));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.cbxLineName1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLineName2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.nudHmeasure = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cebxMeasure = new System.Windows.Forms.CheckBox();
            this.nudLmeasure = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.halconView1 = new ViewControl.HalconView();
            this.label9 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(83, 529);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 47;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(277, 514);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 46;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(197, 514);
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
            // cbxLineName1
            // 
            this.cbxLineName1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxLineName1.FormattingEnabled = true;
            this.cbxLineName1.Location = new System.Drawing.Point(72, 150);
            this.cbxLineName1.Name = "cbxLineName1";
            this.cbxLineName1.Size = new System.Drawing.Size(258, 22);
            this.cbxLineName1.TabIndex = 43;
            this.cbxLineName1.SelectedIndexChanged += new System.EventHandler(this.cbxLineName1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "线1选择：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(92, 17);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(245, 26);
            this.tbxToolName.TabIndex = 41;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "线到线工具名：";
            // 
            // cbxLineName2
            // 
            this.cbxLineName2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxLineName2.FormattingEnabled = true;
            this.cbxLineName2.Location = new System.Drawing.Point(72, 182);
            this.cbxLineName2.Name = "cbxLineName2";
            this.cbxLineName2.Size = new System.Drawing.Size(258, 22);
            this.cbxLineName2.TabIndex = 49;
            this.cbxLineName2.SelectedIndexChanged += new System.EventHandler(this.cbxLineName2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "线2选择：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "结果：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(70, 70);
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
            this.nudHmeasure.Location = new System.Drawing.Point(164, 166);
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
            this.label27.Location = new System.Drawing.Point(162, 151);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 72;
            this.label27.Text = "上限：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(70, 151);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 71;
            this.label28.Text = "下限：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 172);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 70;
            this.label29.Text = "间距：";
            // 
            // cebxMeasure
            // 
            this.cebxMeasure.AutoSize = true;
            this.cebxMeasure.Location = new System.Drawing.Point(246, 171);
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
            this.nudLmeasure.Location = new System.Drawing.Point(70, 166);
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
            this.nudLmeasure.TabIndex = 68;
            this.nudLmeasure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLmeasure.ValueChanged += new System.EventHandler(this.nudLmeasure_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 52);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(88, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(238, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "输入图像：";
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(359, 11);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(646, 532);
            this.halconView1.TabIndex = 74;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 81;
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
            this.nudScale.Location = new System.Drawing.Point(70, 109);
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
            this.nudScale.TabIndex = 80;
            this.nudScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScale.ValueChanged += new System.EventHandler(this.nudScale_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 496);
            this.tabControl1.TabIndex = 82;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cbxLineName1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxLineName2);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.nudScale);
            this.tabPage2.Controls.Add(this.nudLmeasure);
            this.tabPage2.Controls.Add(this.cebxMeasure);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.nudHmeasure);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "结果";
            // 
            // frm_DistanceLineLine
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
            this.Name = "frm_DistanceLineLine";
            this.Text = "线到线测量";
            this.Load += new System.EventHandler(this.frm_DistanceLineLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLmeasure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ComboBox cbxLineName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLineName2;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}