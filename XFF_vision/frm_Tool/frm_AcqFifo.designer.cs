namespace XFF_vision.frm_Tool
{
    partial class frm_AcqFifo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AcqFifo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.cebxGrab = new System.Windows.Forms.CheckBox();
            this.nudExposureTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxImgPath = new System.Windows.Forms.TextBox();
            this.btnSelectdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetCamera = new System.Windows.Forms.Button();
            this.cebxUseImg = new System.Windows.Forms.CheckBox();
            this.cbxDevice = new System.Windows.Forms.ComboBox();
            this.cebkUseLoopImg = new System.Windows.Forms.CheckBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.cbxInterface = new System.Windows.Forms.ComboBox();
            this.btnSnapImage = new System.Windows.Forms.Button();
            this.btnGrapImage = new System.Windows.Forms.Button();
            this.lbxDevInfo = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegisterImg = new System.Windows.Forms.Button();
            this.lbx_Image = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposureTime)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbxDevInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(105, 8);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(261, 26);
            this.tbxToolName.TabIndex = 26;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbx_toolName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "相机工具名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenImage);
            this.groupBox1.Controls.Add(this.cebxGrab);
            this.groupBox1.Controls.Add(this.nudExposureTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxImgPath);
            this.groupBox1.Controls.Add(this.btnSelectdir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetCamera);
            this.groupBox1.Controls.Add(this.cebxUseImg);
            this.groupBox1.Controls.Add(this.cbxDevice);
            this.groupBox1.Controls.Add(this.cebkUseLoopImg);
            this.groupBox1.Controls.Add(this.btnOpenCamera);
            this.groupBox1.Controls.Add(this.cbxInterface);
            this.groupBox1.Controls.Add(this.btnSnapImage);
            this.groupBox1.Controls.Add(this.btnGrapImage);
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 331);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相机设置";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenImage.Location = new System.Drawing.Point(189, 185);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(174, 32);
            this.btnOpenImage.TabIndex = 32;
            this.btnOpenImage.Text = "打开图片";
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // cebxGrab
            // 
            this.cebxGrab.AutoSize = true;
            this.cebxGrab.Location = new System.Drawing.Point(268, 156);
            this.cebxGrab.Name = "cebxGrab";
            this.cebxGrab.Size = new System.Drawing.Size(72, 16);
            this.cebxGrab.TabIndex = 31;
            this.cebxGrab.Text = "同步采集";
            this.cebxGrab.UseVisualStyleBackColor = true;
            this.cebxGrab.CheckedChanged += new System.EventHandler(this.ceboxGrab_CheckedChanged);
            // 
            // nudExposureTime
            // 
            this.nudExposureTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudExposureTime.Location = new System.Drawing.Point(79, 297);
            this.nudExposureTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudExposureTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudExposureTime.Name = "nudExposureTime";
            this.nudExposureTime.Size = new System.Drawing.Size(96, 21);
            this.nudExposureTime.TabIndex = 30;
            this.nudExposureTime.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudExposureTime.ValueChanged += new System.EventHandler(this.nudExposureTime_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "曝光：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "相机端口：";
            // 
            // tbxImgPath
            // 
            this.tbxImgPath.Location = new System.Drawing.Point(6, 223);
            this.tbxImgPath.Name = "tbxImgPath";
            this.tbxImgPath.Size = new System.Drawing.Size(358, 21);
            this.tbxImgPath.TabIndex = 20;
            // 
            // btnSelectdir
            // 
            this.btnSelectdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSelectdir.Location = new System.Drawing.Point(6, 185);
            this.btnSelectdir.Name = "btnSelectdir";
            this.btnSelectdir.Size = new System.Drawing.Size(174, 32);
            this.btnSelectdir.TabIndex = 17;
            this.btnSelectdir.Text = "浏览文件夹";
            this.btnSelectdir.UseVisualStyleBackColor = false;
            this.btnSelectdir.Click += new System.EventHandler(this.btn_selectdir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "相机设备：";
            // 
            // btnGetCamera
            // 
            this.btnGetCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGetCamera.Location = new System.Drawing.Point(289, 95);
            this.btnGetCamera.Name = "btnGetCamera";
            this.btnGetCamera.Size = new System.Drawing.Size(75, 32);
            this.btnGetCamera.TabIndex = 22;
            this.btnGetCamera.Text = "获取相机";
            this.btnGetCamera.UseVisualStyleBackColor = false;
            this.btnGetCamera.Click += new System.EventHandler(this.btn_getCamera_Click);
            // 
            // cebxUseImg
            // 
            this.cebxUseImg.AutoSize = true;
            this.cebxUseImg.Location = new System.Drawing.Point(6, 156);
            this.cebxUseImg.Name = "cebxUseImg";
            this.cebxUseImg.Size = new System.Drawing.Size(96, 16);
            this.cebxUseImg.TabIndex = 19;
            this.cebxUseImg.Text = "使用本地图片";
            this.cebxUseImg.UseVisualStyleBackColor = true;
            this.cebxUseImg.CheckedChanged += new System.EventHandler(this.cek_boxUseImg_CheckedChanged);
            // 
            // cbxDevice
            // 
            this.cbxDevice.BackColor = System.Drawing.SystemColors.Info;
            this.cbxDevice.FormattingEnabled = true;
            this.cbxDevice.Location = new System.Drawing.Point(79, 107);
            this.cbxDevice.Name = "cbxDevice";
            this.cbxDevice.Size = new System.Drawing.Size(204, 20);
            this.cbxDevice.TabIndex = 18;
            this.cbxDevice.SelectedIndexChanged += new System.EventHandler(this.cbx_device_SelectedIndexChanged);
            // 
            // cebkUseLoopImg
            // 
            this.cebkUseLoopImg.AutoSize = true;
            this.cebkUseLoopImg.Location = new System.Drawing.Point(137, 156);
            this.cebkUseLoopImg.Name = "cebkUseLoopImg";
            this.cebkUseLoopImg.Size = new System.Drawing.Size(96, 16);
            this.cebkUseLoopImg.TabIndex = 21;
            this.cebkUseLoopImg.Text = "运行循环图片";
            this.cebkUseLoopImg.UseVisualStyleBackColor = true;
            this.cebkUseLoopImg.CheckedChanged += new System.EventHandler(this.cek_useLoopImg_CheckedChanged);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenCamera.Location = new System.Drawing.Point(6, 20);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(75, 32);
            this.btnOpenCamera.TabIndex = 12;
            this.btnOpenCamera.Text = "打开相机";
            this.btnOpenCamera.UseVisualStyleBackColor = false;
            this.btnOpenCamera.Click += new System.EventHandler(this.btn_OpenCamera_Click);
            // 
            // cbxInterface
            // 
            this.cbxInterface.BackColor = System.Drawing.SystemColors.Info;
            this.cbxInterface.FormattingEnabled = true;
            this.cbxInterface.Items.AddRange(new object[] {
            "MVision",
            "GigEVision",
            "DahengCAM",
            "DirectShow",
            "pylon",
            "TWAIN",
            "1394IIDC",
            "ABS",
            "Andor",
            "Argos3D-P1xx",
            "BitFlow",
            "Crevis",
            "DirectFile",
            "Ensenso-NxLib",
            "File",
            "GenICamTL",
            "Ginga++",
            "GingaDG",
            "LinX",
            "LPS36",
            "LuCam",
            "MatrixVisionAcquire",
            "MILLite",
            "MultiCam",
            "Opteon",
            "PixeLINK",
            "SaperaLT",
            "Sentech",
            "ShapeDrive",
            "SICK-3DCamera",
            "SICK-ScanningRuler",
            "SiliconSoftware",
            "SwissRanger",
            "uEye",
            "USB3Vision",
            "VRmUsbCam"});
            this.cbxInterface.Location = new System.Drawing.Point(79, 65);
            this.cbxInterface.Name = "cbxInterface";
            this.cbxInterface.Size = new System.Drawing.Size(204, 20);
            this.cbxInterface.TabIndex = 15;
            this.cbxInterface.SelectedIndexChanged += new System.EventHandler(this.cbx_interface_SelectedIndexChanged);
            // 
            // btnSnapImage
            // 
            this.btnSnapImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSnapImage.Location = new System.Drawing.Point(208, 20);
            this.btnSnapImage.Name = "btnSnapImage";
            this.btnSnapImage.Size = new System.Drawing.Size(75, 32);
            this.btnSnapImage.TabIndex = 13;
            this.btnSnapImage.Text = "采集一次";
            this.btnSnapImage.UseVisualStyleBackColor = false;
            this.btnSnapImage.Click += new System.EventHandler(this.btn_SnapImage_Click);
            // 
            // btnGrapImage
            // 
            this.btnGrapImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGrapImage.Location = new System.Drawing.Point(108, 20);
            this.btnGrapImage.Name = "btnGrapImage";
            this.btnGrapImage.Size = new System.Drawing.Size(75, 32);
            this.btnGrapImage.TabIndex = 14;
            this.btnGrapImage.Text = "连续采集";
            this.btnGrapImage.UseVisualStyleBackColor = false;
            this.btnGrapImage.Click += new System.EventHandler(this.btn_GrapImage_Click);
            // 
            // lbxDevInfo
            // 
            this.lbxDevInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDevInfo.FormattingEnabled = true;
            this.lbxDevInfo.ItemHeight = 12;
            this.lbxDevInfo.Location = new System.Drawing.Point(3, 377);
            this.lbxDevInfo.Name = "lbxDevInfo";
            this.lbxDevInfo.Size = new System.Drawing.Size(373, 196);
            this.lbxDevInfo.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.btnRegisterImg);
            this.tabPage2.Controls.Add(this.lbx_Image);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "本地图片";
            // 
            // btnRegisterImg
            // 
            this.btnRegisterImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegisterImg.Location = new System.Drawing.Point(6, 523);
            this.btnRegisterImg.Name = "btnRegisterImg";
            this.btnRegisterImg.Size = new System.Drawing.Size(93, 32);
            this.btnRegisterImg.TabIndex = 23;
            this.btnRegisterImg.Text = "注册当前图像";
            this.btnRegisterImg.UseVisualStyleBackColor = false;
            this.btnRegisterImg.Click += new System.EventHandler(this.btnRegisterImg_Click);
            // 
            // lbx_Image
            // 
            this.lbx_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbx_Image.BackColor = System.Drawing.Color.White;
            this.lbx_Image.FormattingEnabled = true;
            this.lbx_Image.ItemHeight = 12;
            this.lbx_Image.Location = new System.Drawing.Point(6, 9);
            this.lbx_Image.Name = "lbx_Image";
            this.lbx_Image.Size = new System.Drawing.Size(368, 508);
            this.lbx_Image.TabIndex = 0;
            this.lbx_Image.SelectedIndexChanged += new System.EventHandler(this.lbx_Image_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(324, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSure.Location = new System.Drawing.Point(239, 627);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 29);
            this.btnSure.TabIndex = 9;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.Location = new System.Drawing.Point(12, 627);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 29);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(95, 639);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 14);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "耗时：";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(194, 639);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 14);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "FAIL";
            // 
            // halconView1
            // 
            this.halconView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(405, 12);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(657, 641);
            this.halconView1.TabIndex = 12;
            // 
            // frm_AcqFifo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 662);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.halconView1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AcqFifo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采集图像";
            this.Load += new System.EventHandler(this.frm_AcqFifo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposureTime)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbx_Image;
        private System.Windows.Forms.ComboBox cbxDevice;
        private System.Windows.Forms.Button btnSelectdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxInterface;
        private System.Windows.Forms.Button btnGrapImage;
        private System.Windows.Forms.Button btnSnapImage;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.CheckBox cebkUseLoopImg;
        private System.Windows.Forms.TextBox tbxImgPath;
        private System.Windows.Forms.CheckBox cebxUseImg;
        private System.Windows.Forms.Button btnGetCamera;
        private System.Windows.Forms.ListBox lbxDevInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimer;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudExposureTime;
        private System.Windows.Forms.CheckBox cebxGrab;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnRegisterImg;
    }
}