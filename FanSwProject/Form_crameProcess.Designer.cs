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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnClose = new System.Windows.Forms.Button();
            this.bnOpen = new System.Windows.Forms.Button();
            this.bnEnum = new System.Windows.Forms.Button();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_crama.SuspendLayout();
            this.相机调试.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox4.Location = new System.Drawing.Point(1720, 794);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(475, 411);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "参数调整";
            // 
            // tbPixelFormat
            // 
            this.tbPixelFormat.Location = new System.Drawing.Point(207, 285);
            this.tbPixelFormat.Margin = new System.Windows.Forms.Padding(4);
            this.tbPixelFormat.Name = "tbPixelFormat";
            this.tbPixelFormat.Size = new System.Drawing.Size(247, 30);
            this.tbPixelFormat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "像素格式";
            // 
            // bnSetParam
            // 
            this.bnSetParam.Enabled = false;
            this.bnSetParam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSetParam.Location = new System.Drawing.Point(236, 367);
            this.bnSetParam.Margin = new System.Windows.Forms.Padding(4);
            this.bnSetParam.Name = "bnSetParam";
            this.bnSetParam.Size = new System.Drawing.Size(231, 50);
            this.bnSetParam.TabIndex = 7;
            this.bnSetParam.Text = "设置参数";
            this.bnSetParam.UseVisualStyleBackColor = true;
            // 
            // bnGetParam
            // 
            this.bnGetParam.Enabled = false;
            this.bnGetParam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnGetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnGetParam.Location = new System.Drawing.Point(27, 367);
            this.bnGetParam.Margin = new System.Windows.Forms.Padding(4);
            this.bnGetParam.Name = "bnGetParam";
            this.bnGetParam.Size = new System.Drawing.Size(186, 50);
            this.bnGetParam.TabIndex = 6;
            this.bnGetParam.Text = "获取参数";
            this.bnGetParam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(30, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frame Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "增益调整";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "曝光时间";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Enabled = false;
            this.tbFrameRate.Location = new System.Drawing.Point(207, 216);
            this.tbFrameRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(247, 30);
            this.tbFrameRate.TabIndex = 2;
            // 
            // tbGain
            // 
            this.tbGain.Enabled = false;
            this.tbGain.Location = new System.Drawing.Point(206, 142);
            this.tbGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(247, 30);
            this.tbGain.TabIndex = 1;
            // 
            // tbExposure
            // 
            this.tbExposure.Enabled = false;
            this.tbExposure.Location = new System.Drawing.Point(206, 70);
            this.tbExposure.Margin = new System.Windows.Forms.Padding(4);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(247, 30);
            this.tbExposure.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.bnSavePng);
            this.groupBox3.Controls.Add(this.bnSaveTiff);
            this.groupBox3.Controls.Add(this.bnSaveJpg);
            this.groupBox3.Controls.Add(this.bnSaveBmp);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.Location = new System.Drawing.Point(1720, 527);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(475, 259);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图片存储";
            // 
            // bnSavePng
            // 
            this.bnSavePng.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSavePng.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSavePng.Location = new System.Drawing.Point(294, 181);
            this.bnSavePng.Margin = new System.Windows.Forms.Padding(4);
            this.bnSavePng.Name = "bnSavePng";
            this.bnSavePng.Size = new System.Drawing.Size(140, 60);
            this.bnSavePng.TabIndex = 2;
            this.bnSavePng.Text = "保存PNG";
            this.bnSavePng.UseVisualStyleBackColor = true;
            this.bnSavePng.Click += new System.EventHandler(this.bnSavePng_Click_1);
            // 
            // bnSaveTiff
            // 
            this.bnSaveTiff.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveTiff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveTiff.Location = new System.Drawing.Point(27, 181);
            this.bnSaveTiff.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveTiff.Name = "bnSaveTiff";
            this.bnSaveTiff.Size = new System.Drawing.Size(140, 60);
            this.bnSaveTiff.TabIndex = 1;
            this.bnSaveTiff.Text = "保存 TIFF";
            this.bnSaveTiff.UseVisualStyleBackColor = true;
            this.bnSaveTiff.Click += new System.EventHandler(this.bnSaveTiff_Click_1);
            // 
            // bnSaveJpg
            // 
            this.bnSaveJpg.Enabled = false;
            this.bnSaveJpg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveJpg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveJpg.Location = new System.Drawing.Point(294, 113);
            this.bnSaveJpg.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveJpg.Name = "bnSaveJpg";
            this.bnSaveJpg.Size = new System.Drawing.Size(140, 60);
            this.bnSaveJpg.TabIndex = 0;
            this.bnSaveJpg.Text = "保存 JPG";
            this.bnSaveJpg.UseVisualStyleBackColor = true;
            this.bnSaveJpg.Click += new System.EventHandler(this.bnSaveJpg_Click_1);
            // 
            // bnSaveBmp
            // 
            this.bnSaveBmp.Enabled = false;
            this.bnSaveBmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnSaveBmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnSaveBmp.Location = new System.Drawing.Point(27, 113);
            this.bnSaveBmp.Margin = new System.Windows.Forms.Padding(4);
            this.bnSaveBmp.Name = "bnSaveBmp";
            this.bnSaveBmp.Size = new System.Drawing.Size(140, 60);
            this.bnSaveBmp.TabIndex = 0;
            this.bnSaveBmp.Text = "保存BMP";
            this.bnSaveBmp.UseVisualStyleBackColor = true;
            this.bnSaveBmp.Click += new System.EventHandler(this.bnSaveBmp_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.bnStopRecord);
            this.groupBox2.Controls.Add(this.bnStartRecord);
            this.groupBox2.Controls.Add(this.bnTriggerExec);
            this.groupBox2.Controls.Add(this.cbSoftTrigger);
            this.groupBox2.Controls.Add(this.bnStopGrab);
            this.groupBox2.Controls.Add(this.bnStartGrab);
            this.groupBox2.Controls.Add(this.bnTriggerMode);
            this.groupBox2.Controls.Add(this.bnContinuesMode);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(1720, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(475, 275);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片采集";
            // 
            // bnStopRecord
            // 
            this.bnStopRecord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStopRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStopRecord.Location = new System.Drawing.Point(294, 201);
            this.bnStopRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bnStopRecord.Name = "bnStopRecord";
            this.bnStopRecord.Size = new System.Drawing.Size(120, 50);
            this.bnStopRecord.TabIndex = 7;
            this.bnStopRecord.Text = "停止录像";
            this.bnStopRecord.UseVisualStyleBackColor = true;
            this.bnStopRecord.Click += new System.EventHandler(this.bnStopRecord_Click_1);
            // 
            // bnStartRecord
            // 
            this.bnStartRecord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStartRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStartRecord.Location = new System.Drawing.Point(30, 201);
            this.bnStartRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bnStartRecord.Name = "bnStartRecord";
            this.bnStartRecord.Size = new System.Drawing.Size(120, 50);
            this.bnStartRecord.TabIndex = 6;
            this.bnStartRecord.Text = "开始录像";
            this.bnStartRecord.UseVisualStyleBackColor = true;
            this.bnStartRecord.Click += new System.EventHandler(this.bnStartRecord_Click_1);
            // 
            // bnTriggerExec
            // 
            this.bnTriggerExec.Enabled = false;
            this.bnTriggerExec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnTriggerExec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnTriggerExec.Location = new System.Drawing.Point(294, 143);
            this.bnTriggerExec.Margin = new System.Windows.Forms.Padding(4);
            this.bnTriggerExec.Name = "bnTriggerExec";
            this.bnTriggerExec.Size = new System.Drawing.Size(120, 50);
            this.bnTriggerExec.TabIndex = 5;
            this.bnTriggerExec.Text = "触发一次";
            this.bnTriggerExec.UseVisualStyleBackColor = true;
            this.bnTriggerExec.Click += new System.EventHandler(this.bnTriggerExec_Click_1);
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.AutoSize = true;
            this.cbSoftTrigger.Enabled = false;
            this.cbSoftTrigger.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSoftTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSoftTrigger.Location = new System.Drawing.Point(27, 154);
            this.cbSoftTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Size = new System.Drawing.Size(132, 28);
            this.cbSoftTrigger.TabIndex = 4;
            this.cbSoftTrigger.Text = "软件触发";
            this.cbSoftTrigger.UseVisualStyleBackColor = true;
            this.cbSoftTrigger.CheckedChanged += new System.EventHandler(this.cbSoftTrigger_CheckedChanged_1);
            // 
            // bnStopGrab
            // 
            this.bnStopGrab.Enabled = false;
            this.bnStopGrab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStopGrab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStopGrab.Location = new System.Drawing.Point(294, 78);
            this.bnStopGrab.Margin = new System.Windows.Forms.Padding(4);
            this.bnStopGrab.Name = "bnStopGrab";
            this.bnStopGrab.Size = new System.Drawing.Size(120, 50);
            this.bnStopGrab.TabIndex = 3;
            this.bnStopGrab.Text = "停止";
            this.bnStopGrab.UseVisualStyleBackColor = true;
            this.bnStopGrab.Click += new System.EventHandler(this.bnStopGrab_Click_1);
            // 
            // bnStartGrab
            // 
            this.bnStartGrab.Enabled = false;
            this.bnStartGrab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnStartGrab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnStartGrab.Location = new System.Drawing.Point(30, 78);
            this.bnStartGrab.Margin = new System.Windows.Forms.Padding(4);
            this.bnStartGrab.Name = "bnStartGrab";
            this.bnStartGrab.Size = new System.Drawing.Size(120, 50);
            this.bnStartGrab.TabIndex = 2;
            this.bnStartGrab.Text = "开始";
            this.bnStartGrab.UseVisualStyleBackColor = true;
            this.bnStartGrab.Click += new System.EventHandler(this.bnStartGrab_Click);
            // 
            // bnTriggerMode
            // 
            this.bnTriggerMode.AutoSize = true;
            this.bnTriggerMode.Enabled = false;
            this.bnTriggerMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnTriggerMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnTriggerMode.Location = new System.Drawing.Point(269, 39);
            this.bnTriggerMode.Margin = new System.Windows.Forms.Padding(4);
            this.bnTriggerMode.Name = "bnTriggerMode";
            this.bnTriggerMode.Size = new System.Drawing.Size(131, 28);
            this.bnTriggerMode.TabIndex = 1;
            this.bnTriggerMode.TabStop = true;
            this.bnTriggerMode.Text = "触发模式";
            this.bnTriggerMode.UseMnemonic = false;
            this.bnTriggerMode.UseVisualStyleBackColor = true;
            // 
            // bnContinuesMode
            // 
            this.bnContinuesMode.AutoSize = true;
            this.bnContinuesMode.Enabled = false;
            this.bnContinuesMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnContinuesMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnContinuesMode.Location = new System.Drawing.Point(30, 39);
            this.bnContinuesMode.Margin = new System.Windows.Forms.Padding(4);
            this.bnContinuesMode.Name = "bnContinuesMode";
            this.bnContinuesMode.Size = new System.Drawing.Size(131, 28);
            this.bnContinuesMode.TabIndex = 0;
            this.bnContinuesMode.TabStop = true;
            this.bnContinuesMode.Text = "连续采集";
            this.bnContinuesMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bnClose);
            this.groupBox1.Controls.Add(this.bnOpen);
            this.groupBox1.Controls.Add(this.bnEnum);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(1720, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(475, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化";
            // 
            // bnClose
            // 
            this.bnClose.Enabled = false;
            this.bnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnClose.Location = new System.Drawing.Point(294, 132);
            this.bnClose.Margin = new System.Windows.Forms.Padding(4);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(120, 50);
            this.bnClose.TabIndex = 2;
            this.bnClose.Text = "关闭相机";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // bnOpen
            // 
            this.bnOpen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnOpen.Location = new System.Drawing.Point(72, 132);
            this.bnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(120, 50);
            this.bnOpen.TabIndex = 1;
            this.bnOpen.Text = "打开相机";
            this.bnOpen.UseVisualStyleBackColor = true;
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnEnum
            // 
            this.bnEnum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnEnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bnEnum.Location = new System.Drawing.Point(72, 44);
            this.bnEnum.Margin = new System.Windows.Forms.Padding(4);
            this.bnEnum.Name = "bnEnum";
            this.bnEnum.Size = new System.Drawing.Size(342, 50);
            this.bnEnum.TabIndex = 0;
            this.bnEnum.Text = "查找设备";
            this.bnEnum.UseVisualStyleBackColor = true;
            this.bnEnum.Click += new System.EventHandler(this.bnEnum_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 30);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "图片路径";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "指定路径";
            this.button1.UseVisualStyleBackColor = true;
          
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}