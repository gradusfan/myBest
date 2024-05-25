namespace XFF_Vision.frm_Tool
{
    partial class frm_MeanImage
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_hig = new System.Windows.Forms.Label();
            this.takBarMaskHeight = new System.Windows.Forms.TrackBar();
            this.lbl_low = new System.Windows.Forms.Label();
            this.takBarMaskWidth = new System.Windows.Forms.TrackBar();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takBarMaskHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarMaskWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(87, 602);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 34;
            this.lblTimer.Text = "耗时：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(297, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 33;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(216, 512);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 32;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(6, 512);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 31;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 481);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.lbl_hig);
            this.tabPage1.Controls.Add(this.takBarMaskHeight);
            this.tabPage1.Controls.Add(this.lbl_low);
            this.tabPage1.Controls.Add(this.takBarMaskWidth);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // lbl_hig
            // 
            this.lbl_hig.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lbl_hig.AutoSize = true;
            this.lbl_hig.Location = new System.Drawing.Point(4, 183);
            this.lbl_hig.Name = "lbl_hig";
            this.lbl_hig.Size = new System.Drawing.Size(77, 12);
            this.lbl_hig.TabIndex = 15;
            this.lbl_hig.Text = "遮掩的高度：";
            // 
            // takBarMaskHeight
            // 
            this.takBarMaskHeight.BackColor = System.Drawing.SystemColors.WindowText;
            this.takBarMaskHeight.Location = new System.Drawing.Point(7, 198);
            this.takBarMaskHeight.Maximum = 500;
            this.takBarMaskHeight.Minimum = 1;
            this.takBarMaskHeight.Name = "takBarMaskHeight";
            this.takBarMaskHeight.Size = new System.Drawing.Size(346, 45);
            this.takBarMaskHeight.TabIndex = 14;
            this.takBarMaskHeight.Value = 1;
            this.takBarMaskHeight.Scroll += new System.EventHandler(this.takBarMaskHeight_Scroll);
            // 
            // lbl_low
            // 
            this.lbl_low.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lbl_low.AutoSize = true;
            this.lbl_low.Location = new System.Drawing.Point(4, 106);
            this.lbl_low.Name = "lbl_low";
            this.lbl_low.Size = new System.Drawing.Size(77, 12);
            this.lbl_low.TabIndex = 12;
            this.lbl_low.Text = "遮掩的宽度：";
            // 
            // takBarMaskWidth
            // 
            this.takBarMaskWidth.BackColor = System.Drawing.SystemColors.WindowText;
            this.takBarMaskWidth.Location = new System.Drawing.Point(7, 121);
            this.takBarMaskWidth.Maximum = 500;
            this.takBarMaskWidth.Minimum = 1;
            this.takBarMaskWidth.Name = "takBarMaskWidth";
            this.takBarMaskWidth.Size = new System.Drawing.Size(346, 45);
            this.takBarMaskWidth.TabIndex = 10;
            this.takBarMaskWidth.Value = 1;
            this.takBarMaskWidth.Scroll += new System.EventHandler(this.takBarMaskWidth_Scroll);
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(103, 13);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(255, 26);
            this.tbxToolName.TabIndex = 9;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(97, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(249, 22);
            this.cbxImage.TabIndex = 0;
            this.cbxImage.SelectedIndexChanged += new System.EventHandler(this.cbxImage_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 1;
            this.label30.Text = "输入图像：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(30, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 8;
            this.label31.Text = "工具名：";
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Location = new System.Drawing.Point(380, 34);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(611, 507);
            this.halconView1.TabIndex = 35;
            // 
            // frm_MeanImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 543);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_MeanImage";
            this.Text = "均值滤波图像";
            this.Load += new System.EventHandler(this.frm_MeanImage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takBarMaskHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takBarMaskWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_low;
        private System.Windows.Forms.TrackBar takBarMaskWidth;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.Label lbl_hig;
        private System.Windows.Forms.TrackBar takBarMaskHeight;

    }
}