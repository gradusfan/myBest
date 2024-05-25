namespace XFF_Vision.frm_Tool
{
    partial class frm_SaveImage
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
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ceboxDumpWin = new System.Windows.Forms.CheckBox();
            this.cboxFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.tbxPath0 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ceboxDeleteDir = new System.Windows.Forms.CheckBox();
            this.tboxSaveDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.checkNG = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(119, 3);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(230, 26);
            this.tbxToolName.TabIndex = 62;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbxImage);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 52);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(97, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(244, 22);
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
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "图片保存工具名：";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.checkNG);
            this.groupBox10.Controls.Add(this.ceboxDumpWin);
            this.groupBox10.Controls.Add(this.cboxFormat);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.btnPath);
            this.groupBox10.Controls.Add(this.tbxPath0);
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Location = new System.Drawing.Point(2, 96);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(356, 131);
            this.groupBox10.TabIndex = 63;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "保存位置";
            // 
            // ceboxDumpWin
            // 
            this.ceboxDumpWin.AutoSize = true;
            this.ceboxDumpWin.Location = new System.Drawing.Point(6, 110);
            this.ceboxDumpWin.Name = "ceboxDumpWin";
            this.ceboxDumpWin.Size = new System.Drawing.Size(108, 16);
            this.ceboxDumpWin.TabIndex = 5;
            this.ceboxDumpWin.Text = "保存文字带图形";
            this.ceboxDumpWin.UseVisualStyleBackColor = true;
            this.ceboxDumpWin.CheckedChanged += new System.EventHandler(this.ceboxDumpWin_CheckedChanged);
            // 
            // cboxFormat
            // 
            this.cboxFormat.FormattingEnabled = true;
            this.cboxFormat.Items.AddRange(new object[] {
            "bmp",
            "jpg",
            "png"});
            this.cboxFormat.Location = new System.Drawing.Point(66, 67);
            this.cboxFormat.Name = "cboxFormat";
            this.cboxFormat.Size = new System.Drawing.Size(93, 20);
            this.cboxFormat.TabIndex = 4;
            this.cboxFormat.Text = "jpg";
            this.cboxFormat.SelectedIndexChanged += new System.EventHandler(this.cboxFormat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片格式：";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(285, 64);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(62, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "......";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbxPath0
            // 
            this.tbxPath0.Location = new System.Drawing.Point(6, 37);
            this.tbxPath0.Name = "tbxPath0";
            this.tbxPath0.ReadOnly = true;
            this.tbxPath0.Size = new System.Drawing.Size(344, 21);
            this.tbxPath0.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "文件夹名：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(277, 315);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(183, 315);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 65;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(10, 315);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 64;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ceboxDeleteDir);
            this.groupBox1.Controls.Add(this.tboxSaveDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 76);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "清理文件";
            // 
            // ceboxDeleteDir
            // 
            this.ceboxDeleteDir.AutoSize = true;
            this.ceboxDeleteDir.Location = new System.Drawing.Point(227, 37);
            this.ceboxDeleteDir.Name = "ceboxDeleteDir";
            this.ceboxDeleteDir.Size = new System.Drawing.Size(120, 16);
            this.ceboxDeleteDir.TabIndex = 6;
            this.ceboxDeleteDir.Text = "自动清理过期文件";
            this.ceboxDeleteDir.UseVisualStyleBackColor = true;
            this.ceboxDeleteDir.CheckedChanged += new System.EventHandler(this.ceboxDeleteDir_CheckedChanged);
            // 
            // tboxSaveDay
            // 
            this.tboxSaveDay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxSaveDay.Location = new System.Drawing.Point(66, 33);
            this.tboxSaveDay.Name = "tboxSaveDay";
            this.tboxSaveDay.Size = new System.Drawing.Size(93, 21);
            this.tboxSaveDay.TabIndex = 68;
            this.tboxSaveDay.Text = "1";
            this.tboxSaveDay.TextChanged += new System.EventHandler(this.tboxSaveDay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "保存天数：";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(91, 330);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 68;
            this.lblTimer.Text = "耗时：";
            // 
            // checkNG
            // 
            this.checkNG.AutoSize = true;
            this.checkNG.Location = new System.Drawing.Point(132, 108);
            this.checkNG.Name = "checkNG";
            this.checkNG.Size = new System.Drawing.Size(84, 16);
            this.checkNG.TabIndex = 6;
            this.checkNG.Text = "保存NG图片";
            this.checkNG.UseVisualStyleBackColor = true;
            this.checkNG.CheckedChanged += new System.EventHandler(this.checkNG_CheckedChanged);
            // 
            // frm_SaveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(361, 356);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.tbxToolName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Name = "frm_SaveImage";
            this.Text = "保存图像";
            this.Load += new System.EventHandler(this.frm_SaveImage_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox tbxPath0;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboxFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ceboxDumpWin;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ceboxDeleteDir;
        private System.Windows.Forms.TextBox tboxSaveDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.CheckBox checkNG;
    }
}