namespace FanSwProject
{
    partial class Form_crameProcess
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
            this.tabControl_crama = new System.Windows.Forms.TabControl();
            this.相机调试 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnOpen = new System.Windows.Forms.Button();
            this.bnEnum = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnSavePng = new System.Windows.Forms.Button();
            this.bnSaveTiff = new System.Windows.Forms.Button();
            this.bnSaveJpg = new System.Windows.Forms.Button();
            this.bnSaveBmp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnStopRecord = new System.Windows.Forms.Button();
            this.bnStartRecord = new System.Windows.Forms.Button();
            this.bnTriggerExec = new System.Windows.Forms.Button();
            this.cbSoftTrigger = new System.Windows.Forms.CheckBox();
            this.bnStopGrab = new System.Windows.Forms.Button();
            this.bnStartGrab = new System.Windows.Forms.Button();
            this.bnTriggerMode = new System.Windows.Forms.RadioButton();
            this.bnContinuesMode = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbPixelFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bnSetParam = new System.Windows.Forms.Button();
            this.bnGetParam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbExposure = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_crama.SuspendLayout();
            this.相机调试.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_crama
            // 
            this.tabControl_crama.Controls.Add(this.相机调试);
            this.tabControl_crama.Controls.Add(this.tabPage2);
            this.tabControl_crama.Location = new System.Drawing.Point(2, 12);
            this.tabControl_crama.Name = "tabControl_crama";
            this.tabControl_crama.SelectedIndex = 0;
            this.tabControl_crama.Size = new System.Drawing.Size(2233, 1244);
            this.tabControl_crama.TabIndex = 0;
            // 
            // 相机调试
            // 
            this.相机调试.Controls.Add(this.pictureBox1);
            this.相机调试.Controls.Add(this.groupBox4);
            this.相机调试.Controls.Add(this.groupBox3);
            this.相机调试.Controls.Add(this.groupBox2);
            this.相机调试.Controls.Add(this.groupBox1);
            this.相机调试.Controls.Add(this.cbDeviceList);
            this.相机调试.Location = new System.Drawing.Point(4, 28);
            this.相机调试.Name = "相机调试";
            this.相机调试.Padding = new System.Windows.Forms.Padding(3);
            this.相机调试.Size = new System.Drawing.Size(2225, 1212);
            this.相机调试.TabIndex = 0;
            this.相机调试.Text = "相机调试";
            this.相机调试.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2225, 1212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "相机程序加载";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(4, 25);
            this.cbDeviceList.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(1708, 26);
            this.cbDeviceList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnClose);
            this.groupBox1.Controls.Add(this.bnOpen);
            this.groupBox1.Controls.Add(this.bnEnum);
            this.groupBox1.Location = new System.Drawing.Point(1743, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(475, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            // 
            // bnClose
            // 
            this.bnClose.Enabled = false;
            this.bnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnClose.Location = new System.Drawing.Point(258, 156);
            this.bnClose.Margin = new System.Windows.Forms.Padding(4);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(132, 34);
            this.bnClose.TabIndex = 2;
            this.bnClose.Text = "Close Device";
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // bnOpen
            // 
            this.bnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnOpen.Location = new System.Drawing.Point(27, 156);
            this.bnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(124, 34);
            this.bnOpen.TabIndex = 1;
            this.bnOpen.Text = "Open Device";
            this.bnOpen.UseVisualStyleBackColor = true;
            // 
            // bnEnum
            // 
            this.bnEnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnEnum.Location = new System.Drawing.Point(27, 61);
            this.bnEnum.Margin = new System.Windows.Forms.Padding(4);
            this.bnEnum.Name = "bnEnum";
            this.bnEnum.Size = new System.Drawing.Size(363, 34);
            this.bnEnum.TabIndex = 0;
            this.bnEnum.Text = "Search Device";
            this.bnEnum.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bnSavePng);
            this.groupBox3.Controls.Add(this.bnSaveTiff);
            this.groupBox3.Controls.Add(this.bnSaveJpg);
            this.groupBox3.Controls.Add(this.bnSaveBmp);
            this.groupBox3.Location = new System.Drawing.Point(1743, 651);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(475, 259);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture Storage";
            // 
            // bnSavePng
            // 
            this.bnSavePng.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSavePng.Location = new System.Drawing.Point(249, 172);
            this.bnSavePng.Margin = new System.Windows.Forms.Padding(4);
            this.bnSavePng.Name = "bnSavePng";
            this.bnSavePng.Size = new System.Drawing.Size(142, 52);
            this.bnSavePng.TabIndex = 2;
            this.bnSavePng.Text = "Save as PNG";
            this.bnSavePng.UseVisualStyleBackColor = true;
            // 
            // bnSaveTiff
            // 
            this.bnSaveTiff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveTiff.Location = new System.Drawing.Point(30, 172);
            this.bnSaveTiff.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveTiff.Name = "bnSaveTiff";
            this.bnSaveTiff.Size = new System.Drawing.Size(138, 52);
            this.bnSaveTiff.TabIndex = 1;
            this.bnSaveTiff.Text = "Save as TIFF";
            this.bnSaveTiff.UseVisualStyleBackColor = true;
            // 
            // bnSaveJpg
            // 
            this.bnSaveJpg.Enabled = false;
            this.bnSaveJpg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveJpg.Location = new System.Drawing.Point(243, 56);
            this.bnSaveJpg.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveJpg.Name = "bnSaveJpg";
            this.bnSaveJpg.Size = new System.Drawing.Size(142, 59);
            this.bnSaveJpg.TabIndex = 0;
            this.bnSaveJpg.Text = "Save as JPG";
            this.bnSaveJpg.UseVisualStyleBackColor = true;
            // 
            // bnSaveBmp
            // 
            this.bnSaveBmp.Enabled = false;
            this.bnSaveBmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveBmp.Location = new System.Drawing.Point(30, 56);
            this.bnSaveBmp.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveBmp.Name = "bnSaveBmp";
            this.bnSaveBmp.Size = new System.Drawing.Size(138, 59);
            this.bnSaveBmp.TabIndex = 0;
            this.bnSaveBmp.Text = "Save as BMP";
            this.bnSaveBmp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnStopRecord);
            this.groupBox2.Controls.Add(this.bnStartRecord);
            this.groupBox2.Controls.Add(this.bnTriggerExec);
            this.groupBox2.Controls.Add(this.cbSoftTrigger);
            this.groupBox2.Controls.Add(this.bnStopGrab);
            this.groupBox2.Controls.Add(this.bnStartGrab);
            this.groupBox2.Controls.Add(this.bnTriggerMode);
            this.groupBox2.Controls.Add(this.bnContinuesMode);
            this.groupBox2.Location = new System.Drawing.Point(1743, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(475, 334);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Acquisition";
            // 
            // bnStopRecord
            // 
            this.bnStopRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStopRecord.Location = new System.Drawing.Point(279, 225);
            this.bnStopRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bnStopRecord.Name = "bnStopRecord";
            this.bnStopRecord.Size = new System.Drawing.Size(112, 34);
            this.bnStopRecord.TabIndex = 7;
            this.bnStopRecord.UseVisualStyleBackColor = true;
            // 
            // bnStartRecord
            // 
            this.bnStartRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStartRecord.Location = new System.Drawing.Point(30, 225);
            this.bnStartRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bnStartRecord.Name = "bnStartRecord";
            this.bnStartRecord.Size = new System.Drawing.Size(112, 34);
            this.bnStartRecord.TabIndex = 6;
            this.bnStartRecord.UseVisualStyleBackColor = true;
            // 
            // bnTriggerExec
            // 
            this.bnTriggerExec.Enabled = false;
            this.bnTriggerExec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnTriggerExec.Location = new System.Drawing.Point(225, 148);
            this.bnTriggerExec.Margin = new System.Windows.Forms.Padding(4);
            this.bnTriggerExec.Name = "bnTriggerExec";
            this.bnTriggerExec.Size = new System.Drawing.Size(130, 34);
            this.bnTriggerExec.TabIndex = 5;
            this.bnTriggerExec.Text = "Trigger Once";
            this.bnTriggerExec.UseVisualStyleBackColor = true;
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.AutoSize = true;
            this.cbSoftTrigger.Enabled = false;
            this.cbSoftTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSoftTrigger.Location = new System.Drawing.Point(9, 154);
            this.cbSoftTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Size = new System.Drawing.Size(205, 22);
            this.cbSoftTrigger.TabIndex = 4;
            this.cbSoftTrigger.Text = "Trigger by Software";
            this.cbSoftTrigger.UseVisualStyleBackColor = true;
            // 
            // bnStopGrab
            // 
            this.bnStopGrab.Enabled = false;
            this.bnStopGrab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStopGrab.Location = new System.Drawing.Point(268, 93);
            this.bnStopGrab.Margin = new System.Windows.Forms.Padding(4);
            this.bnStopGrab.Name = "bnStopGrab";
            this.bnStopGrab.Size = new System.Drawing.Size(142, 34);
            this.bnStopGrab.TabIndex = 3;
            this.bnStopGrab.Text = "Stop";
            this.bnStopGrab.UseVisualStyleBackColor = true;
            // 
            // bnStartGrab
            // 
            this.bnStartGrab.Enabled = false;
            this.bnStartGrab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStartGrab.Location = new System.Drawing.Point(30, 93);
            this.bnStartGrab.Margin = new System.Windows.Forms.Padding(4);
            this.bnStartGrab.Name = "bnStartGrab";
            this.bnStartGrab.Size = new System.Drawing.Size(124, 34);
            this.bnStartGrab.TabIndex = 2;
            this.bnStartGrab.Text = "Start";
            this.bnStartGrab.UseVisualStyleBackColor = true;
            // 
            // bnTriggerMode
            // 
            this.bnTriggerMode.AutoSize = true;
            this.bnTriggerMode.Enabled = false;
            this.bnTriggerMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnTriggerMode.Location = new System.Drawing.Point(269, 39);
            this.bnTriggerMode.Margin = new System.Windows.Forms.Padding(4);
            this.bnTriggerMode.Name = "bnTriggerMode";
            this.bnTriggerMode.Size = new System.Drawing.Size(141, 22);
            this.bnTriggerMode.TabIndex = 1;
            this.bnTriggerMode.TabStop = true;
            this.bnTriggerMode.Text = "Trigger Mode";
            this.bnTriggerMode.UseMnemonic = false;
            this.bnTriggerMode.UseVisualStyleBackColor = true;
            // 
            // bnContinuesMode
            // 
            this.bnContinuesMode.AutoSize = true;
            this.bnContinuesMode.Enabled = false;
            this.bnContinuesMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnContinuesMode.Location = new System.Drawing.Point(30, 39);
            this.bnContinuesMode.Margin = new System.Windows.Forms.Padding(4);
            this.bnContinuesMode.Name = "bnContinuesMode";
            this.bnContinuesMode.Size = new System.Drawing.Size(123, 22);
            this.bnContinuesMode.TabIndex = 0;
            this.bnContinuesMode.TabStop = true;
            this.bnContinuesMode.Text = "Continuous";
            this.bnContinuesMode.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPixelFormat);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.bnSetParam);
            this.groupBox4.Controls.Add(this.bnGetParam);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbFrameRate);
            this.groupBox4.Controls.Add(this.tbGain);
            this.groupBox4.Controls.Add(this.tbExposure);
            this.groupBox4.Location = new System.Drawing.Point(1743, 933);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(475, 344);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // tbPixelFormat
            // 
            this.tbPixelFormat.Location = new System.Drawing.Point(206, 148);
            this.tbPixelFormat.Margin = new System.Windows.Forms.Padding(4);
            this.tbPixelFormat.Name = "tbPixelFormat";
            this.tbPixelFormat.Size = new System.Drawing.Size(247, 28);
            this.tbPixelFormat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pixel Format";
            // 
            // bnSetParam
            // 
            this.bnSetParam.Enabled = false;
            this.bnSetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSetParam.Location = new System.Drawing.Point(241, 206);
            this.bnSetParam.Margin = new System.Windows.Forms.Padding(4);
            this.bnSetParam.Name = "bnSetParam";
            this.bnSetParam.Size = new System.Drawing.Size(231, 50);
            this.bnSetParam.TabIndex = 7;
            this.bnSetParam.Text = "Set Parameter";
            this.bnSetParam.UseVisualStyleBackColor = true;
            // 
            // bnGetParam
            // 
            this.bnGetParam.Enabled = false;
            this.bnGetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnGetParam.Location = new System.Drawing.Point(27, 206);
            this.bnGetParam.Margin = new System.Windows.Forms.Padding(4);
            this.bnGetParam.Name = "bnGetParam";
            this.bnGetParam.Size = new System.Drawing.Size(186, 50);
            this.bnGetParam.TabIndex = 6;
            this.bnGetParam.Text = "Get Parameter";
            this.bnGetParam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frame Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exposure Time";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Enabled = false;
            this.tbFrameRate.Location = new System.Drawing.Point(206, 142);
            this.tbFrameRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(148, 28);
            this.tbFrameRate.TabIndex = 2;
            // 
            // tbGain
            // 
            this.tbGain.Enabled = false;
            this.tbGain.Location = new System.Drawing.Point(206, 88);
            this.tbGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(247, 28);
            this.tbGain.TabIndex = 1;
            // 
            // tbExposure
            // 
            this.tbExposure.Enabled = false;
            this.tbExposure.Location = new System.Drawing.Point(206, 38);
            this.tbExposure.Margin = new System.Windows.Forms.Padding(4);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(247, 28);
            this.tbExposure.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(4, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1708, 1166);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_crameProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2233, 1244);
            this.Controls.Add(this.tabControl_crama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_crameProcess";
            this.Text = "Form_crameProcess";
            this.tabControl_crama.ResumeLayout(false);
            this.相机调试.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_crama;
        private System.Windows.Forms.TabPage 相机调试;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.Button bnOpen;
        private System.Windows.Forms.Button bnEnum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnSavePng;
        private System.Windows.Forms.Button bnSaveTiff;
        private System.Windows.Forms.Button bnSaveJpg;
        private System.Windows.Forms.Button bnSaveBmp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnStopRecord;
        private System.Windows.Forms.Button bnStartRecord;
        private System.Windows.Forms.Button bnTriggerExec;
        private System.Windows.Forms.CheckBox cbSoftTrigger;
        private System.Windows.Forms.Button bnStopGrab;
        private System.Windows.Forms.Button bnStartGrab;
        private System.Windows.Forms.RadioButton bnTriggerMode;
        private System.Windows.Forms.RadioButton bnContinuesMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbPixelFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnSetParam;
        private System.Windows.Forms.Button bnGetParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbExposure;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}