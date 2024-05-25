namespace XFF_Vision.frm_Tool
{
    partial class frm_Morphology
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudHeiht = new System.Windows.Forms.NumericUpDown();
            this.lblHig = new System.Windows.Forms.Label();
            this.nudWith = new System.Windows.Forms.NumericUpDown();
            this.lblWith = new System.Windows.Forms.Label();
            this.cebxIsSelectedRegions = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMorphology = new System.Windows.Forms.ComboBox();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeiht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWith)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 473);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "工具名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudHeiht);
            this.groupBox2.Controls.Add(this.lblHig);
            this.groupBox2.Controls.Add(this.nudWith);
            this.groupBox2.Controls.Add(this.lblWith);
            this.groupBox2.Controls.Add(this.cebxIsSelectedRegions);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxSetdraw);
            this.groupBox2.Controls.Add(this.cbxRegion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxMorphology);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 340);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ROI区域设置";
            // 
            // nudHeiht
            // 
            this.nudHeiht.DecimalPlaces = 1;
            this.nudHeiht.Location = new System.Drawing.Point(260, 119);
            this.nudHeiht.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudHeiht.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeiht.Name = "nudHeiht";
            this.nudHeiht.Size = new System.Drawing.Size(71, 21);
            this.nudHeiht.TabIndex = 61;
            this.nudHeiht.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeiht.ValueChanged += new System.EventHandler(this.nudHeiht_ValueChanged);
            // 
            // lblHig
            // 
            this.lblHig.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lblHig.AutoSize = true;
            this.lblHig.Location = new System.Drawing.Point(225, 128);
            this.lblHig.Name = "lblHig";
            this.lblHig.Size = new System.Drawing.Size(29, 12);
            this.lblHig.TabIndex = 60;
            this.lblHig.Text = "高：";
            // 
            // nudWith
            // 
            this.nudWith.DecimalPlaces = 1;
            this.nudWith.Location = new System.Drawing.Point(110, 119);
            this.nudWith.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudWith.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWith.Name = "nudWith";
            this.nudWith.Size = new System.Drawing.Size(71, 21);
            this.nudWith.TabIndex = 59;
            this.nudWith.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWith.ValueChanged += new System.EventHandler(this.nudWith_ValueChanged);
            // 
            // lblWith
            // 
            this.lblWith.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lblWith.AutoSize = true;
            this.lblWith.Location = new System.Drawing.Point(75, 128);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(29, 12);
            this.lblWith.TabIndex = 58;
            this.lblWith.Text = "宽：";
            // 
            // cebxIsSelectedRegions
            // 
            this.cebxIsSelectedRegions.AutoSize = true;
            this.cebxIsSelectedRegions.BackColor = System.Drawing.Color.Silver;
            this.cebxIsSelectedRegions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsSelectedRegions.Location = new System.Drawing.Point(261, 263);
            this.cebxIsSelectedRegions.Name = "cebxIsSelectedRegions";
            this.cebxIsSelectedRegions.Size = new System.Drawing.Size(70, 16);
            this.cebxIsSelectedRegions.TabIndex = 8;
            this.cebxIsSelectedRegions.Text = "显示区域";
            this.cebxIsSelectedRegions.UseVisualStyleBackColor = false;
            this.cebxIsSelectedRegions.CheckedChanged += new System.EventHandler(this.cebxIsSelectedRegions_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "显示：";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(77, 262);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(166, 20);
            this.cbxSetdraw.TabIndex = 6;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // cbxRegion
            // 
            this.cbxRegion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(77, 31);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(254, 22);
            this.cbxRegion.TabIndex = 2;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "输入区域：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "形态特征：";
            // 
            // cbxMorphology
            // 
            this.cbxMorphology.FormattingEnabled = true;
            this.cbxMorphology.Items.AddRange(new object[] {
            "矩形区域开运算",
            "矩形区域闭运算",
            "矩形区域腐蚀",
            "矩形区域膨胀",
            "圆区域开运算",
            "圆区域闭运算",
            "圆区域腐蚀",
            "圆区域膨胀"});
            this.cbxMorphology.Location = new System.Drawing.Point(77, 74);
            this.cbxMorphology.Name = "cbxMorphology";
            this.cbxMorphology.Size = new System.Drawing.Size(254, 20);
            this.cbxMorphology.TabIndex = 3;
            this.cbxMorphology.SelectedIndexChanged += new System.EventHandler(this.cbxMorphlogy_SelectedIndexChanged);
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(73, 6);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(264, 26);
            this.tbxToolName.TabIndex = 62;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbxImage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 52);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(67, 18);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(264, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入图像：";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(174, 503);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 69;
            this.lblResult.Text = "FAIL";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(75, 506);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 68;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(300, 491);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 67;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(1, 491);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 65;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(219, 491);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 66;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(377, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(609, 508);
            this.halconView1.TabIndex = 71;
            this.halconView1.HMouseWheelEvent += new ViewControl.HalconView.HMouseDelegate(this.halconView1_HMouseWheelEvent);
            // 
            // frm_Morphology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 526);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_sure);
            this.Name = "frm_Morphology";
            this.Text = "区域形态学处理";
            this.Load += new System.EventHandler(this.frm_Morphology_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeiht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWith)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMorphology;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_sure;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.CheckBox cebxIsSelectedRegions;
        private System.Windows.Forms.NumericUpDown nudHeiht;
        private System.Windows.Forms.Label lblHig;
        private System.Windows.Forms.NumericUpDown nudWith;
        private System.Windows.Forms.Label lblWith;
    }
}