namespace XFF_Vision.frm_Tool
{
    partial class frm_Calibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Calibration));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCamTyp = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cebxlongFocus = new System.Windows.Forms.CheckBox();
            this.nudFocus = new System.Windows.Forms.NumericUpDown();
            this.nudChipPixHight = new System.Windows.Forms.NumericUpDown();
            this.nudChipPixWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.btnDescribeFile = new System.Windows.Forms.Button();
            this.tbxDescribeFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMaxDiamReset = new System.Windows.Forms.Button();
            this.nudMaxDiam = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.btnMinContLReset = new System.Windows.Forms.Button();
            this.nudMinContL = new System.Windows.Forms.NumericUpDown();
            this.label50 = new System.Windows.Forms.Label();
            this.btnSmootingReset = new System.Windows.Forms.Button();
            this.nudSmooth = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.btnMinThreshReset = new System.Windows.Forms.Button();
            this.nudMinThresh = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.btnThreshDecrReset = new System.Windows.Forms.Button();
            this.nudThreshDecr = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.btnInitThreshReset = new System.Windows.Forms.Button();
            this.nudInitThresh = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.btnMinDiamReset = new System.Windows.Forms.Button();
            this.nudMinDiam = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.btnMarkThreshReset = new System.Windows.Forms.Button();
            this.nudMarkThresh = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.btnFilterSizeReset = new System.Windows.Forms.Button();
            this.nudFilterSize = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label78 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.cebxCoordSys = new System.Windows.Forms.CheckBox();
            this.cebxMarkCenter = new System.Windows.Forms.CheckBox();
            this.cebxPlateRegion = new System.Windows.Forms.CheckBox();
            this.cboxDraw = new System.Windows.Forms.ComboBox();
            this.cboxCoordSys = new System.Windows.Forms.ComboBox();
            this.cboxMarkCenters = new System.Windows.Forms.ComboBox();
            this.cboxPlateRegion = new System.Windows.Forms.ComboBox();
            this.btnOriginImg = new System.Windows.Forms.Button();
            this.lvCalibImg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.halconView1 = new ViewControl.HalconView();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLast1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btnCamPoseExport = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tbxCameraPoseZ_R = new System.Windows.Forms.TextBox();
            this.tbxCameraPoseZ = new System.Windows.Forms.TextBox();
            this.tbxCameraPoseY_R = new System.Windows.Forms.TextBox();
            this.tbxCameraPoseY = new System.Windows.Forms.TextBox();
            this.tbxCameraPoseX_R = new System.Windows.Forms.TextBox();
            this.tbxCameraPoseX = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PanelKappa = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.tbxKappa = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.PanelAreaScanPolynom = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxP1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxK3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbxP2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbxK2 = new System.Windows.Forms.TextBox();
            this.tbxK1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCamParamExport = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.um = new System.Windows.Forms.Label();
            this.tbxImageHeight = new System.Windows.Forms.TextBox();
            this.tbxImageWidth = new System.Windows.Forms.TextBox();
            this.tbxCy = new System.Windows.Forms.TextBox();
            this.tbxCx = new System.Windows.Forms.TextBox();
            this.tbxFocus = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxChipPixHight = new System.Windows.Forms.TextBox();
            this.tbxChipPixWidth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxCalibrationError = new System.Windows.Forms.TextBox();
            this.tbxCalibrationStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipPixHight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipPixWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshDecr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PanelKappa.SuspendLayout();
            this.PanelAreaScanPolynom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(11, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 646);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "安装";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(363, 554);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCamTyp);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.cebxlongFocus);
            this.groupBox2.Controls.Add(this.nudFocus);
            this.groupBox2.Controls.Add(this.nudChipPixHight);
            this.groupBox2.Controls.Add(this.nudChipPixWidth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(24, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(770, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "摄像机参数";
            // 
            // cbxCamTyp
            // 
            this.cbxCamTyp.Items.AddRange(new object[] {
            "Area Scan(Division)",
            "Area Scan(Polynomial)",
            "Line Scan"});
            this.cbxCamTyp.Location = new System.Drawing.Point(239, 47);
            this.cbxCamTyp.Name = "cbxCamTyp";
            this.cbxCamTyp.Size = new System.Drawing.Size(252, 21);
            this.cbxCamTyp.TabIndex = 13;
            this.cbxCamTyp.Text = "Area Scan(Division)";
            this.cbxCamTyp.SelectedIndexChanged += new System.EventHandler(this.cbxCamTyp_SelectedIndexChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(521, 186);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(20, 13);
            this.label49.TabIndex = 12;
            this.label49.Text = "㎜";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(517, 145);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(27, 13);
            this.label48.TabIndex = 11;
            this.label48.Text = "μm";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(517, 100);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(27, 13);
            this.label47.TabIndex = 10;
            this.label47.Text = "μm";
            // 
            // cebxlongFocus
            // 
            this.cebxlongFocus.AutoSize = true;
            this.cebxlongFocus.ForeColor = System.Drawing.Color.Black;
            this.cebxlongFocus.Location = new System.Drawing.Point(563, 182);
            this.cebxlongFocus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cebxlongFocus.Name = "cebxlongFocus";
            this.cebxlongFocus.Size = new System.Drawing.Size(52, 17);
            this.cebxlongFocus.TabIndex = 8;
            this.cebxlongFocus.Text = "远心";
            this.cebxlongFocus.UseVisualStyleBackColor = true;
            this.cebxlongFocus.CheckedChanged += new System.EventHandler(this.cebxlongFocus_CheckedChanged);
            // 
            // nudFocus
            // 
            this.nudFocus.DecimalPlaces = 3;
            this.nudFocus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudFocus.Location = new System.Drawing.Point(239, 177);
            this.nudFocus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudFocus.Name = "nudFocus";
            this.nudFocus.Size = new System.Drawing.Size(252, 22);
            this.nudFocus.TabIndex = 7;
            this.nudFocus.ValueChanged += new System.EventHandler(this.nudFocus_ValueChanged);
            // 
            // nudChipPixHight
            // 
            this.nudChipPixHight.DecimalPlaces = 3;
            this.nudChipPixHight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudChipPixHight.Location = new System.Drawing.Point(239, 136);
            this.nudChipPixHight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudChipPixHight.Name = "nudChipPixHight";
            this.nudChipPixHight.Size = new System.Drawing.Size(252, 22);
            this.nudChipPixHight.TabIndex = 6;
            this.nudChipPixHight.Value = new decimal(new int[] {
            50735,
            0,
            0,
            196608});
            this.nudChipPixHight.ValueChanged += new System.EventHandler(this.nudChipPixHight_ValueChanged);
            // 
            // nudChipPixWidth
            // 
            this.nudChipPixWidth.DecimalPlaces = 3;
            this.nudChipPixWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudChipPixWidth.Location = new System.Drawing.Point(239, 91);
            this.nudChipPixWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudChipPixWidth.Name = "nudChipPixWidth";
            this.nudChipPixWidth.Size = new System.Drawing.Size(252, 22);
            this.nudChipPixWidth.TabIndex = 5;
            this.nudChipPixWidth.Value = new decimal(new int[] {
            50735,
            0,
            0,
            196608});
            this.nudChipPixWidth.ValueChanged += new System.EventHandler(this.nudChipPixWidth_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(59, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "焦距：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(59, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "单个像元的高（Sy）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "单个像元的宽（Sx）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "摄像机模型：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudThickness);
            this.groupBox1.Controls.Add(this.btnDescribeFile);
            this.groupBox1.Controls.Add(this.tbxDescribeFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(770, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标定板";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "㎜";
            // 
            // nudThickness
            // 
            this.nudThickness.DecimalPlaces = 2;
            this.nudThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudThickness.Location = new System.Drawing.Point(167, 107);
            this.nudThickness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudThickness.Name = "nudThickness";
            this.nudThickness.Size = new System.Drawing.Size(324, 22);
            this.nudThickness.TabIndex = 4;
            // 
            // btnDescribeFile
            // 
            this.btnDescribeFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDescribeFile.Location = new System.Drawing.Point(520, 32);
            this.btnDescribeFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDescribeFile.Name = "btnDescribeFile";
            this.btnDescribeFile.Size = new System.Drawing.Size(95, 37);
            this.btnDescribeFile.TabIndex = 3;
            this.btnDescribeFile.UseVisualStyleBackColor = true;
            this.btnDescribeFile.Click += new System.EventHandler(this.btnDescribeFile_Click);
            // 
            // tbxDescribeFile
            // 
            this.tbxDescribeFile.Location = new System.Drawing.Point(167, 47);
            this.tbxDescribeFile.Name = "tbxDescribeFile";
            this.tbxDescribeFile.ReadOnly = true;
            this.tbxDescribeFile.Size = new System.Drawing.Size(324, 22);
            this.tbxDescribeFile.TabIndex = 2;
            this.tbxDescribeFile.Text = ".descr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "厚度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "描述文件：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.btnOriginImg);
            this.tabPage2.Controls.Add(this.lvCalibImg);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btnOpenImage);
            this.tabPage2.Controls.Add(this.btnCalibration);
            this.tabPage2.Controls.Add(this.btnLast);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "标定";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnMaxDiamReset);
            this.groupBox7.Controls.Add(this.nudMaxDiam);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.btnMinContLReset);
            this.groupBox7.Controls.Add(this.nudMinContL);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.btnSmootingReset);
            this.groupBox7.Controls.Add(this.nudSmooth);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.btnMinThreshReset);
            this.groupBox7.Controls.Add(this.nudMinThresh);
            this.groupBox7.Controls.Add(this.label52);
            this.groupBox7.Controls.Add(this.btnThreshDecrReset);
            this.groupBox7.Controls.Add(this.nudThreshDecr);
            this.groupBox7.Controls.Add(this.label53);
            this.groupBox7.Controls.Add(this.btnInitThreshReset);
            this.groupBox7.Controls.Add(this.nudInitThresh);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Controls.Add(this.btnMinDiamReset);
            this.groupBox7.Controls.Add(this.nudMinDiam);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Controls.Add(this.btnMarkThreshReset);
            this.groupBox7.Controls.Add(this.nudMarkThresh);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.btnFilterSizeReset);
            this.groupBox7.Controls.Add(this.nudFilterSize);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Location = new System.Drawing.Point(537, 260);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(492, 353);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "校准板提取参数";
            // 
            // btnMaxDiamReset
            // 
            this.btnMaxDiamReset.ForeColor = System.Drawing.Color.Black;
            this.btnMaxDiamReset.Location = new System.Drawing.Point(422, 302);
            this.btnMaxDiamReset.Name = "btnMaxDiamReset";
            this.btnMaxDiamReset.Size = new System.Drawing.Size(58, 26);
            this.btnMaxDiamReset.TabIndex = 35;
            this.btnMaxDiamReset.Text = "Reset";
            this.btnMaxDiamReset.Click += new System.EventHandler(this.btnMaxDiamReset_Click);
            // 
            // nudMaxDiam
            // 
            this.nudMaxDiam.Location = new System.Drawing.Point(134, 302);
            this.nudMaxDiam.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMaxDiam.Name = "nudMaxDiam";
            this.nudMaxDiam.Size = new System.Drawing.Size(282, 22);
            this.nudMaxDiam.TabIndex = 33;
            this.nudMaxDiam.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxDiam.ValueChanged += new System.EventHandler(this.nudMaxDiam_ValueChanged);
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(3, 302);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(112, 26);
            this.label46.TabIndex = 32;
            this.label46.Text = "MaxMarkDiam   最大标记直径";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinContLReset
            // 
            this.btnMinContLReset.ForeColor = System.Drawing.Color.Black;
            this.btnMinContLReset.Location = new System.Drawing.Point(422, 268);
            this.btnMinContLReset.Name = "btnMinContLReset";
            this.btnMinContLReset.Size = new System.Drawing.Size(58, 26);
            this.btnMinContLReset.TabIndex = 31;
            this.btnMinContLReset.Text = "Reset";
            this.btnMinContLReset.Click += new System.EventHandler(this.btnMinContLReset_Click);
            // 
            // nudMinContL
            // 
            this.nudMinContL.Location = new System.Drawing.Point(134, 268);
            this.nudMinContL.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMinContL.Name = "nudMinContL";
            this.nudMinContL.Size = new System.Drawing.Size(282, 22);
            this.nudMinContL.TabIndex = 29;
            this.nudMinContL.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinContL.ValueChanged += new System.EventHandler(this.nudMinContL_ValueChanged);
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(3, 268);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(112, 26);
            this.label50.TabIndex = 28;
            this.label50.Text = "MinContLength 最小轮廓";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSmootingReset
            // 
            this.btnSmootingReset.ForeColor = System.Drawing.Color.Black;
            this.btnSmootingReset.Location = new System.Drawing.Point(422, 233);
            this.btnSmootingReset.Name = "btnSmootingReset";
            this.btnSmootingReset.Size = new System.Drawing.Size(58, 26);
            this.btnSmootingReset.TabIndex = 27;
            this.btnSmootingReset.Text = "Reset";
            this.btnSmootingReset.Click += new System.EventHandler(this.btnSmootingReset_Click);
            // 
            // nudSmooth
            // 
            this.nudSmooth.DecimalPlaces = 1;
            this.nudSmooth.Location = new System.Drawing.Point(134, 233);
            this.nudSmooth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSmooth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSmooth.Name = "nudSmooth";
            this.nudSmooth.Size = new System.Drawing.Size(282, 22);
            this.nudSmooth.TabIndex = 25;
            this.nudSmooth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSmooth.ValueChanged += new System.EventHandler(this.nudSmooth_ValueChanged);
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(3, 233);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(112, 26);
            this.label51.TabIndex = 24;
            this.label51.Text = "Smoothing 平滑";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinThreshReset
            // 
            this.btnMinThreshReset.ForeColor = System.Drawing.Color.Black;
            this.btnMinThreshReset.Location = new System.Drawing.Point(422, 199);
            this.btnMinThreshReset.Name = "btnMinThreshReset";
            this.btnMinThreshReset.Size = new System.Drawing.Size(58, 26);
            this.btnMinThreshReset.TabIndex = 23;
            this.btnMinThreshReset.Text = "Reset";
            this.btnMinThreshReset.Click += new System.EventHandler(this.btnMinThreshReset_Click);
            // 
            // nudMinThresh
            // 
            this.nudMinThresh.Location = new System.Drawing.Point(134, 199);
            this.nudMinThresh.Name = "nudMinThresh";
            this.nudMinThresh.Size = new System.Drawing.Size(282, 22);
            this.nudMinThresh.TabIndex = 21;
            this.nudMinThresh.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinThresh.ValueChanged += new System.EventHandler(this.nudMinThresh_ValueChanged);
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(3, 199);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 26);
            this.label52.TabIndex = 20;
            this.label52.Text = "MinThresh 最小阈值";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThreshDecrReset
            // 
            this.btnThreshDecrReset.ForeColor = System.Drawing.Color.Black;
            this.btnThreshDecrReset.Location = new System.Drawing.Point(422, 164);
            this.btnThreshDecrReset.Name = "btnThreshDecrReset";
            this.btnThreshDecrReset.Size = new System.Drawing.Size(58, 26);
            this.btnThreshDecrReset.TabIndex = 19;
            this.btnThreshDecrReset.Text = "Reset";
            this.btnThreshDecrReset.Click += new System.EventHandler(this.btnThreshDecrReset_Click);
            // 
            // nudThreshDecr
            // 
            this.nudThreshDecr.Location = new System.Drawing.Point(134, 164);
            this.nudThreshDecr.Name = "nudThreshDecr";
            this.nudThreshDecr.Size = new System.Drawing.Size(282, 22);
            this.nudThreshDecr.TabIndex = 17;
            this.nudThreshDecr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudThreshDecr.ValueChanged += new System.EventHandler(this.nudThreshDecr_ValueChanged);
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(3, 164);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(93, 26);
            this.label53.TabIndex = 16;
            this.label53.Text = "ThreshDecr 递减";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInitThreshReset
            // 
            this.btnInitThreshReset.ForeColor = System.Drawing.Color.Black;
            this.btnInitThreshReset.Location = new System.Drawing.Point(422, 130);
            this.btnInitThreshReset.Name = "btnInitThreshReset";
            this.btnInitThreshReset.Size = new System.Drawing.Size(58, 26);
            this.btnInitThreshReset.TabIndex = 15;
            this.btnInitThreshReset.Text = "Reset";
            this.btnInitThreshReset.Click += new System.EventHandler(this.btnInitThreshReset_Click);
            // 
            // nudInitThresh
            // 
            this.nudInitThresh.Location = new System.Drawing.Point(134, 130);
            this.nudInitThresh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInitThresh.Name = "nudInitThresh";
            this.nudInitThresh.Size = new System.Drawing.Size(282, 22);
            this.nudInitThresh.TabIndex = 13;
            this.nudInitThresh.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudInitThresh.ValueChanged += new System.EventHandler(this.nudInitThresh_ValueChanged);
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(3, 130);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 26);
            this.label54.TabIndex = 12;
            this.label54.Text = "开始阀值InitThresh";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinDiamReset
            // 
            this.btnMinDiamReset.ForeColor = System.Drawing.Color.Black;
            this.btnMinDiamReset.Location = new System.Drawing.Point(422, 95);
            this.btnMinDiamReset.Name = "btnMinDiamReset";
            this.btnMinDiamReset.Size = new System.Drawing.Size(58, 26);
            this.btnMinDiamReset.TabIndex = 11;
            this.btnMinDiamReset.Text = "Reset";
            this.btnMinDiamReset.Click += new System.EventHandler(this.btnMinDiamReset_Click);
            // 
            // nudMinDiam
            // 
            this.nudMinDiam.Location = new System.Drawing.Point(134, 95);
            this.nudMinDiam.Name = "nudMinDiam";
            this.nudMinDiam.Size = new System.Drawing.Size(282, 22);
            this.nudMinDiam.TabIndex = 9;
            this.nudMinDiam.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinDiam.ValueChanged += new System.EventHandler(this.nudMinDiam_ValueChanged);
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(3, 95);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(125, 26);
            this.label55.TabIndex = 8;
            this.label55.Text = "标志点的最小直径MinMarkDiam";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMarkThreshReset
            // 
            this.btnMarkThreshReset.ForeColor = System.Drawing.Color.Black;
            this.btnMarkThreshReset.Location = new System.Drawing.Point(422, 61);
            this.btnMarkThreshReset.Name = "btnMarkThreshReset";
            this.btnMarkThreshReset.Size = new System.Drawing.Size(58, 26);
            this.btnMarkThreshReset.TabIndex = 7;
            this.btnMarkThreshReset.Text = "Reset";
            this.btnMarkThreshReset.Click += new System.EventHandler(this.btnMarkThreshReset_Click);
            // 
            // nudMarkThresh
            // 
            this.nudMarkThresh.Location = new System.Drawing.Point(134, 61);
            this.nudMarkThresh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMarkThresh.Name = "nudMarkThresh";
            this.nudMarkThresh.Size = new System.Drawing.Size(282, 22);
            this.nudMarkThresh.TabIndex = 5;
            this.nudMarkThresh.Value = new decimal(new int[] {
            112,
            0,
            0,
            0});
            this.nudMarkThresh.ValueChanged += new System.EventHandler(this.nudMarkThresh_ValueChanged);
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(5, 61);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(123, 26);
            this.label56.TabIndex = 4;
            this.label56.Text = "标志点的阀值MarkThresh";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFilterSizeReset
            // 
            this.btnFilterSizeReset.ForeColor = System.Drawing.Color.Black;
            this.btnFilterSizeReset.Location = new System.Drawing.Point(422, 26);
            this.btnFilterSizeReset.Name = "btnFilterSizeReset";
            this.btnFilterSizeReset.Size = new System.Drawing.Size(58, 26);
            this.btnFilterSizeReset.TabIndex = 3;
            this.btnFilterSizeReset.Text = "Reset";
            this.btnFilterSizeReset.Click += new System.EventHandler(this.btnFilterSizeReset_Click);
            // 
            // nudFilterSize
            // 
            this.nudFilterSize.Location = new System.Drawing.Point(134, 26);
            this.nudFilterSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudFilterSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFilterSize.Name = "nudFilterSize";
            this.nudFilterSize.Size = new System.Drawing.Size(282, 22);
            this.nudFilterSize.TabIndex = 1;
            this.nudFilterSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudFilterSize.ValueChanged += new System.EventHandler(this.nudFilterSize_ValueChanged);
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(8, 26);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(120, 26);
            this.label57.TabIndex = 0;
            this.label57.Text = "高斯滤波尺寸FilterSize";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudLineWidth);
            this.groupBox6.Controls.Add(this.label78);
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.cebxCoordSys);
            this.groupBox6.Controls.Add(this.cebxMarkCenter);
            this.groupBox6.Controls.Add(this.cebxPlateRegion);
            this.groupBox6.Controls.Add(this.cboxDraw);
            this.groupBox6.Controls.Add(this.cboxCoordSys);
            this.groupBox6.Controls.Add(this.cboxMarkCenters);
            this.groupBox6.Controls.Add(this.cboxPlateRegion);
            this.groupBox6.Location = new System.Drawing.Point(4, 402);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(524, 172);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "显示参数";
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.Location = new System.Drawing.Point(197, 132);
            this.nudLineWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(153, 22);
            this.nudLineWidth.TabIndex = 36;
            this.nudLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.ValueChanged += new System.EventHandler(this.nudLineWidth_ValueChanged);
            // 
            // label78
            // 
            this.label78.Location = new System.Drawing.Point(48, 132);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(77, 26);
            this.label78.TabIndex = 35;
            this.label78.Text = " LineWidth";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label68
            // 
            this.label68.Location = new System.Drawing.Point(48, 101);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(77, 26);
            this.label68.TabIndex = 33;
            this.label68.Text = " Draw";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cebxCoordSys
            // 
            this.cebxCoordSys.Checked = true;
            this.cebxCoordSys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cebxCoordSys.Location = new System.Drawing.Point(24, 78);
            this.cebxCoordSys.Name = "cebxCoordSys";
            this.cebxCoordSys.Size = new System.Drawing.Size(167, 25);
            this.cebxCoordSys.TabIndex = 32;
            this.cebxCoordSys.Text = "  Coordinate System";
            this.cebxCoordSys.CheckedChanged += new System.EventHandler(this.cebxCoordSys_CheckedChanged);
            // 
            // cebxMarkCenter
            // 
            this.cebxMarkCenter.Checked = true;
            this.cebxMarkCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cebxMarkCenter.Location = new System.Drawing.Point(24, 52);
            this.cebxMarkCenter.Name = "cebxMarkCenter";
            this.cebxMarkCenter.Size = new System.Drawing.Size(154, 26);
            this.cebxMarkCenter.TabIndex = 31;
            this.cebxMarkCenter.Text = "  Mark Centers";
            this.cebxMarkCenter.CheckedChanged += new System.EventHandler(this.cebxMarkCenter_CheckedChanged);
            // 
            // cebxPlateRegion
            // 
            this.cebxPlateRegion.Checked = true;
            this.cebxPlateRegion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cebxPlateRegion.Location = new System.Drawing.Point(24, 26);
            this.cebxPlateRegion.Name = "cebxPlateRegion";
            this.cebxPlateRegion.Size = new System.Drawing.Size(154, 26);
            this.cebxPlateRegion.TabIndex = 30;
            this.cebxPlateRegion.Text = "  Plate Region";
            this.cebxPlateRegion.CheckedChanged += new System.EventHandler(this.cebxPlateRegion_CheckedChanged);
            // 
            // cboxDraw
            // 
            this.cboxDraw.Items.AddRange(new object[] {
            "margin",
            "fill"});
            this.cboxDraw.Location = new System.Drawing.Point(197, 105);
            this.cboxDraw.Name = "cboxDraw";
            this.cboxDraw.Size = new System.Drawing.Size(153, 21);
            this.cboxDraw.TabIndex = 29;
            this.cboxDraw.Text = "margin";
            this.cboxDraw.SelectedIndexChanged += new System.EventHandler(this.cboxDraw_SelectedIndexChanged);
            // 
            // cboxCoordSys
            // 
            this.cboxCoordSys.Items.AddRange(new object[] {
            "green",
            "red",
            "blue",
            "black",
            "white",
            "yellow",
            "magenta",
            "cyan",
            "gray"});
            this.cboxCoordSys.Location = new System.Drawing.Point(197, 78);
            this.cboxCoordSys.Name = "cboxCoordSys";
            this.cboxCoordSys.Size = new System.Drawing.Size(153, 21);
            this.cboxCoordSys.TabIndex = 28;
            this.cboxCoordSys.Text = "yellow";
            this.cboxCoordSys.SelectedIndexChanged += new System.EventHandler(this.cboxCoordSys_SelectedIndexChanged);
            // 
            // cboxMarkCenters
            // 
            this.cboxMarkCenters.Items.AddRange(new object[] {
            "green",
            "red",
            "blue",
            "black",
            "white",
            "yellow",
            "magenta",
            "cyan",
            "gray"});
            this.cboxMarkCenters.Location = new System.Drawing.Point(197, 52);
            this.cboxMarkCenters.Name = "cboxMarkCenters";
            this.cboxMarkCenters.Size = new System.Drawing.Size(153, 21);
            this.cboxMarkCenters.TabIndex = 27;
            this.cboxMarkCenters.Text = "cyan";
            this.cboxMarkCenters.SelectedIndexChanged += new System.EventHandler(this.cboxMarkCenters_SelectedIndexChanged);
            // 
            // cboxPlateRegion
            // 
            this.cboxPlateRegion.Items.AddRange(new object[] {
            "green",
            "red",
            "blue",
            "black",
            "white",
            "yellow",
            "magenta",
            "cyan",
            "gray"});
            this.cboxPlateRegion.Location = new System.Drawing.Point(197, 26);
            this.cboxPlateRegion.Name = "cboxPlateRegion";
            this.cboxPlateRegion.Size = new System.Drawing.Size(153, 21);
            this.cboxPlateRegion.TabIndex = 26;
            this.cboxPlateRegion.Text = "green";
            this.cboxPlateRegion.SelectedIndexChanged += new System.EventHandler(this.cboxPlateRegion_SelectedIndexChanged);
            // 
            // btnOriginImg
            // 
            this.btnOriginImg.Location = new System.Drawing.Point(636, 6);
            this.btnOriginImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOriginImg.Name = "btnOriginImg";
            this.btnOriginImg.Size = new System.Drawing.Size(98, 44);
            this.btnOriginImg.TabIndex = 9;
            this.btnOriginImg.Text = "设定参考姿态";
            this.btnOriginImg.UseVisualStyleBackColor = true;
            this.btnOriginImg.Click += new System.EventHandler(this.btnOriginImg_Click);
            // 
            // lvCalibImg
            // 
            this.lvCalibImg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCalibImg.GridLines = true;
            this.lvCalibImg.HideSelection = false;
            this.lvCalibImg.Location = new System.Drawing.Point(537, 56);
            this.lvCalibImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvCalibImg.MultiSelect = false;
            this.lvCalibImg.Name = "lvCalibImg";
            this.lvCalibImg.Size = new System.Drawing.Size(495, 198);
            this.lvCalibImg.TabIndex = 0;
            this.lvCalibImg.UseCompatibleStateImageBehavior = false;
            this.lvCalibImg.View = System.Windows.Forms.View.Details;
            this.lvCalibImg.SelectedIndexChanged += new System.EventHandler(this.lvCalibImg_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "参考位置";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "图像";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 360;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(4, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(528, 390);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.halconView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Size = new System.Drawing.Size(520, 363);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "图像显示";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(4, 3);
            this.halconView1.Name = "halconView1";
            this.halconView1.Size = new System.Drawing.Size(512, 357);
            this.halconView1.TabIndex = 0;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOpenImage.Location = new System.Drawing.Point(540, 6);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(98, 44);
            this.btnOpenImage.TabIndex = 3;
            this.btnOpenImage.Text = "加载图像";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(729, 6);
            this.btnCalibration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(98, 44);
            this.btnCalibration.TabIndex = 2;
            this.btnCalibration.Text = "标定";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(337, 580);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(76, 23);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "上一步";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.btnLast1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1045, 619);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "结果";
            // 
            // btnLast1
            // 
            this.btnLast1.Location = new System.Drawing.Point(370, 573);
            this.btnLast1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLast1.Name = "btnLast1";
            this.btnLast1.Size = new System.Drawing.Size(76, 23);
            this.btnLast1.TabIndex = 4;
            this.btnLast1.Text = "上一步";
            this.btnLast1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.btnCamPoseExport);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.tbxCameraPoseZ_R);
            this.groupBox5.Controls.Add(this.tbxCameraPoseZ);
            this.groupBox5.Controls.Add(this.tbxCameraPoseY_R);
            this.groupBox5.Controls.Add(this.tbxCameraPoseY);
            this.groupBox5.Controls.Add(this.tbxCameraPoseX_R);
            this.groupBox5.Controls.Add(this.tbxCameraPoseX);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(28, 428);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(784, 139);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "摄像机位姿";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(711, 83);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(20, 13);
            this.label45.TabIndex = 34;
            this.label45.Text = "度";
            // 
            // btnCamPoseExport
            // 
            this.btnCamPoseExport.Location = new System.Drawing.Point(700, 110);
            this.btnCamPoseExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCamPoseExport.Name = "btnCamPoseExport";
            this.btnCamPoseExport.Size = new System.Drawing.Size(76, 23);
            this.btnCamPoseExport.TabIndex = 0;
            this.btnCamPoseExport.Text = "导出文件";
            this.btnCamPoseExport.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(711, 55);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(20, 13);
            this.label44.TabIndex = 33;
            this.label44.Text = "度";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(711, 27);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(20, 13);
            this.label43.TabIndex = 32;
            this.label43.Text = "度";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(339, 83);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(20, 13);
            this.label42.TabIndex = 31;
            this.label42.Text = "㎜";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(339, 55);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(20, 13);
            this.label41.TabIndex = 30;
            this.label41.Text = "㎜";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(339, 27);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(20, 13);
            this.label40.TabIndex = 29;
            this.label40.Text = "㎜";
            // 
            // tbxCameraPoseZ_R
            // 
            this.tbxCameraPoseZ_R.Location = new System.Drawing.Point(567, 74);
            this.tbxCameraPoseZ_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseZ_R.Name = "tbxCameraPoseZ_R";
            this.tbxCameraPoseZ_R.ReadOnly = true;
            this.tbxCameraPoseZ_R.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseZ_R.TabIndex = 28;
            // 
            // tbxCameraPoseZ
            // 
            this.tbxCameraPoseZ.Location = new System.Drawing.Point(208, 74);
            this.tbxCameraPoseZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseZ.Name = "tbxCameraPoseZ";
            this.tbxCameraPoseZ.ReadOnly = true;
            this.tbxCameraPoseZ.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseZ.TabIndex = 27;
            // 
            // tbxCameraPoseY_R
            // 
            this.tbxCameraPoseY_R.Location = new System.Drawing.Point(567, 46);
            this.tbxCameraPoseY_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseY_R.Name = "tbxCameraPoseY_R";
            this.tbxCameraPoseY_R.ReadOnly = true;
            this.tbxCameraPoseY_R.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseY_R.TabIndex = 26;
            // 
            // tbxCameraPoseY
            // 
            this.tbxCameraPoseY.Location = new System.Drawing.Point(208, 46);
            this.tbxCameraPoseY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseY.Name = "tbxCameraPoseY";
            this.tbxCameraPoseY.ReadOnly = true;
            this.tbxCameraPoseY.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseY.TabIndex = 25;
            // 
            // tbxCameraPoseX_R
            // 
            this.tbxCameraPoseX_R.Location = new System.Drawing.Point(567, 18);
            this.tbxCameraPoseX_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseX_R.Name = "tbxCameraPoseX_R";
            this.tbxCameraPoseX_R.ReadOnly = true;
            this.tbxCameraPoseX_R.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseX_R.TabIndex = 24;
            // 
            // tbxCameraPoseX
            // 
            this.tbxCameraPoseX.Location = new System.Drawing.Point(208, 18);
            this.tbxCameraPoseX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCameraPoseX.Name = "tbxCameraPoseX";
            this.tbxCameraPoseX.ReadOnly = true;
            this.tbxCameraPoseX.Size = new System.Drawing.Size(120, 22);
            this.tbxCameraPoseX.TabIndex = 23;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(425, 83);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(66, 13);
            this.label39.TabIndex = 5;
            this.label39.Text = "Z轴旋转：";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(425, 55);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 13);
            this.label38.TabIndex = 4;
            this.label38.Text = "Y轴旋转：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(425, 27);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 3;
            this.label37.Text = "X轴旋转：";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 83);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 13);
            this.label36.TabIndex = 2;
            this.label36.Text = "Z：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(77, 55);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Y：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(77, 27);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "X：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PanelKappa);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.PanelAreaScanPolynom);
            this.groupBox4.Controls.Add(this.btnCamParamExport);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.um);
            this.groupBox4.Controls.Add(this.tbxImageHeight);
            this.groupBox4.Controls.Add(this.tbxImageWidth);
            this.groupBox4.Controls.Add(this.tbxCy);
            this.groupBox4.Controls.Add(this.tbxCx);
            this.groupBox4.Controls.Add(this.tbxFocus);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tbxChipPixHight);
            this.groupBox4.Controls.Add(this.tbxChipPixWidth);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(28, 117);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(784, 305);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "摄像机参数";
            // 
            // PanelKappa
            // 
            this.PanelKappa.Controls.Add(this.label27);
            this.PanelKappa.Controls.Add(this.tbxKappa);
            this.PanelKappa.Controls.Add(this.label59);
            this.PanelKappa.Location = new System.Drawing.Point(7, 125);
            this.PanelKappa.Name = "PanelKappa";
            this.PanelKappa.Size = new System.Drawing.Size(329, 39);
            this.PanelKappa.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(268, 17);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 13);
            this.label27.TabIndex = 42;
            this.label27.Text = "㎜";
            // 
            // tbxKappa
            // 
            this.tbxKappa.Location = new System.Drawing.Point(147, 8);
            this.tbxKappa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxKappa.Name = "tbxKappa";
            this.tbxKappa.ReadOnly = true;
            this.tbxKappa.Size = new System.Drawing.Size(120, 22);
            this.tbxKappa.TabIndex = 41;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(16, 11);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(55, 13);
            this.label59.TabIndex = 40;
            this.label59.Text = "Kappa：";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(275, 212);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 38;
            this.label58.Text = "像素";
            // 
            // PanelAreaScanPolynom
            // 
            this.PanelAreaScanPolynom.Controls.Add(this.label18);
            this.PanelAreaScanPolynom.Controls.Add(this.label20);
            this.PanelAreaScanPolynom.Controls.Add(this.tbxP1);
            this.PanelAreaScanPolynom.Controls.Add(this.label32);
            this.PanelAreaScanPolynom.Controls.Add(this.label14);
            this.PanelAreaScanPolynom.Controls.Add(this.tbxK3);
            this.PanelAreaScanPolynom.Controls.Add(this.label31);
            this.PanelAreaScanPolynom.Controls.Add(this.tbxP2);
            this.PanelAreaScanPolynom.Controls.Add(this.label19);
            this.PanelAreaScanPolynom.Controls.Add(this.label30);
            this.PanelAreaScanPolynom.Controls.Add(this.label25);
            this.PanelAreaScanPolynom.Controls.Add(this.label26);
            this.PanelAreaScanPolynom.Controls.Add(this.tbxK2);
            this.PanelAreaScanPolynom.Controls.Add(this.tbxK1);
            this.PanelAreaScanPolynom.Controls.Add(this.label13);
            this.PanelAreaScanPolynom.Location = new System.Drawing.Point(342, 21);
            this.PanelAreaScanPolynom.Name = "PanelAreaScanPolynom";
            this.PanelAreaScanPolynom.Size = new System.Drawing.Size(435, 237);
            this.PanelAreaScanPolynom.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 22);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "径向2阶（K1）：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 156);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "切向4阶（P2）：";
            // 
            // tbxP1
            // 
            this.tbxP1.Location = new System.Drawing.Point(149, 112);
            this.tbxP1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxP1.Name = "tbxP1";
            this.tbxP1.ReadOnly = true;
            this.tbxP1.Size = new System.Drawing.Size(120, 22);
            this.tbxP1.TabIndex = 18;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(278, 156);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 33;
            this.label32.Text = "1/m4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "切向2阶（P1）：";
            // 
            // tbxK3
            // 
            this.tbxK3.Location = new System.Drawing.Point(149, 77);
            this.tbxK3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxK3.Name = "tbxK3";
            this.tbxK3.ReadOnly = true;
            this.tbxK3.Size = new System.Drawing.Size(120, 22);
            this.tbxK3.TabIndex = 17;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(278, 86);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 13);
            this.label31.TabIndex = 32;
            this.label31.Text = "1/m6";
            // 
            // tbxP2
            // 
            this.tbxP2.Location = new System.Drawing.Point(149, 147);
            this.tbxP2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxP2.Name = "tbxP2";
            this.tbxP2.ReadOnly = true;
            this.tbxP2.Size = new System.Drawing.Size(120, 22);
            this.tbxP2.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 86);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "径向6阶（K3）：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(277, 22);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 13);
            this.label30.TabIndex = 31;
            this.label30.Text = "1/m2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(277, 52);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "1/m4";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(279, 121);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "1/m2";
            // 
            // tbxK2
            // 
            this.tbxK2.Location = new System.Drawing.Point(149, 44);
            this.tbxK2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxK2.Name = "tbxK2";
            this.tbxK2.ReadOnly = true;
            this.tbxK2.Size = new System.Drawing.Size(120, 22);
            this.tbxK2.TabIndex = 16;
            // 
            // tbxK1
            // 
            this.tbxK1.Location = new System.Drawing.Point(149, 13);
            this.tbxK1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxK1.Name = "tbxK1";
            this.tbxK1.ReadOnly = true;
            this.tbxK1.Size = new System.Drawing.Size(120, 22);
            this.tbxK1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "径向4阶（K2）：";
            // 
            // btnCamParamExport
            // 
            this.btnCamParamExport.Location = new System.Drawing.Point(700, 276);
            this.btnCamParamExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCamParamExport.Name = "btnCamParamExport";
            this.btnCamParamExport.Size = new System.Drawing.Size(76, 23);
            this.btnCamParamExport.TabIndex = 36;
            this.btnCamParamExport.Text = "导出文件";
            this.btnCamParamExport.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(275, 280);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(33, 13);
            this.label34.TabIndex = 35;
            this.label34.Text = "像素";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(275, 177);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 13);
            this.label33.TabIndex = 34;
            this.label33.Text = "像素";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(275, 74);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 13);
            this.label29.TabIndex = 30;
            this.label29.Text = "μm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(275, 247);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "像素";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(275, 107);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "㎜";
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(275, 43);
            this.um.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(27, 13);
            this.um.TabIndex = 24;
            this.um.Text = "μm";
            // 
            // tbxImageHeight
            // 
            this.tbxImageHeight.Location = new System.Drawing.Point(154, 271);
            this.tbxImageHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxImageHeight.Name = "tbxImageHeight";
            this.tbxImageHeight.ReadOnly = true;
            this.tbxImageHeight.Size = new System.Drawing.Size(120, 22);
            this.tbxImageHeight.TabIndex = 23;
            // 
            // tbxImageWidth
            // 
            this.tbxImageWidth.Location = new System.Drawing.Point(154, 238);
            this.tbxImageWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxImageWidth.Name = "tbxImageWidth";
            this.tbxImageWidth.ReadOnly = true;
            this.tbxImageWidth.Size = new System.Drawing.Size(120, 22);
            this.tbxImageWidth.TabIndex = 22;
            // 
            // tbxCy
            // 
            this.tbxCy.Location = new System.Drawing.Point(154, 203);
            this.tbxCy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCy.Name = "tbxCy";
            this.tbxCy.ReadOnly = true;
            this.tbxCy.Size = new System.Drawing.Size(120, 22);
            this.tbxCy.TabIndex = 21;
            // 
            // tbxCx
            // 
            this.tbxCx.Location = new System.Drawing.Point(154, 168);
            this.tbxCx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCx.Name = "tbxCx";
            this.tbxCx.ReadOnly = true;
            this.tbxCx.Size = new System.Drawing.Size(120, 22);
            this.tbxCx.TabIndex = 20;
            // 
            // tbxFocus
            // 
            this.tbxFocus.Location = new System.Drawing.Point(154, 98);
            this.tbxFocus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFocus.Name = "tbxFocus";
            this.tbxFocus.ReadOnly = true;
            this.tbxFocus.Size = new System.Drawing.Size(120, 22);
            this.tbxFocus.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 280);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "图像高：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 215);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "中心点y坐标（Cy）：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "单个像元的高(Sy):";
            // 
            // tbxChipPixHight
            // 
            this.tbxChipPixHight.Location = new System.Drawing.Point(154, 65);
            this.tbxChipPixHight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxChipPixHight.Name = "tbxChipPixHight";
            this.tbxChipPixHight.ReadOnly = true;
            this.tbxChipPixHight.Size = new System.Drawing.Size(120, 22);
            this.tbxChipPixHight.TabIndex = 7;
            // 
            // tbxChipPixWidth
            // 
            this.tbxChipPixWidth.Location = new System.Drawing.Point(154, 34);
            this.tbxChipPixWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxChipPixWidth.Name = "tbxChipPixWidth";
            this.tbxChipPixWidth.ReadOnly = true;
            this.tbxChipPixWidth.Size = new System.Drawing.Size(120, 22);
            this.tbxChipPixWidth.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 247);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "图像宽：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 177);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "中心点x坐标（Cx）：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "焦距：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "单个像元的宽(Sx)：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbxCalibrationError);
            this.groupBox3.Controls.Add(this.tbxCalibrationStatus);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(28, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(784, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "标定状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "㎜";
            // 
            // tbxCalibrationError
            // 
            this.tbxCalibrationError.BackColor = System.Drawing.Color.DarkGray;
            this.tbxCalibrationError.Location = new System.Drawing.Point(208, 55);
            this.tbxCalibrationError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCalibrationError.Name = "tbxCalibrationError";
            this.tbxCalibrationError.Size = new System.Drawing.Size(349, 22);
            this.tbxCalibrationError.TabIndex = 3;
            // 
            // tbxCalibrationStatus
            // 
            this.tbxCalibrationStatus.BackColor = System.Drawing.Color.DarkGray;
            this.tbxCalibrationStatus.Location = new System.Drawing.Point(208, 18);
            this.tbxCalibrationStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCalibrationStatus.Name = "tbxCalibrationStatus";
            this.tbxCalibrationStatus.Size = new System.Drawing.Size(349, 22);
            this.tbxCalibrationStatus.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "平均误差：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "标定状态：";
            // 
            // frm_Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Calibration";
            this.Text = "frm_Calibration";
            this.Load += new System.EventHandler(this.frm_Calibration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipPixHight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipPixWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshDecr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PanelKappa.ResumeLayout(false);
            this.PanelKappa.PerformLayout();
            this.PanelAreaScanPolynom.ResumeLayout(false);
            this.PanelAreaScanPolynom.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox cebxlongFocus;
        private System.Windows.Forms.NumericUpDown nudFocus;
        private System.Windows.Forms.NumericUpDown nudChipPixHight;
        private System.Windows.Forms.NumericUpDown nudChipPixWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudThickness;
        private System.Windows.Forms.Button btnDescribeFile;
        private System.Windows.Forms.TextBox tbxDescribeFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOriginImg;
        private System.Windows.Forms.ListView lvCalibImg;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCamParamExport;
        private System.Windows.Forms.Button btnCamPoseExport;
        private System.Windows.Forms.Button btnLast1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tbxCameraPoseZ_R;
        private System.Windows.Forms.TextBox tbxCameraPoseZ;
        private System.Windows.Forms.TextBox tbxCameraPoseY_R;
        private System.Windows.Forms.TextBox tbxCameraPoseY;
        private System.Windows.Forms.TextBox tbxCameraPoseX_R;
        private System.Windows.Forms.TextBox tbxCameraPoseX;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label um;
        private System.Windows.Forms.TextBox tbxImageHeight;
        private System.Windows.Forms.TextBox tbxImageWidth;
        private System.Windows.Forms.TextBox tbxCy;
        private System.Windows.Forms.TextBox tbxCx;
        private System.Windows.Forms.TextBox tbxP2;
        private System.Windows.Forms.TextBox tbxP1;
        private System.Windows.Forms.TextBox tbxK3;
        private System.Windows.Forms.TextBox tbxK2;
        private System.Windows.Forms.TextBox tbxK1;
        private System.Windows.Forms.TextBox tbxFocus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxChipPixHight;
        private System.Windows.Forms.TextBox tbxChipPixWidth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxCalibrationError;
        private System.Windows.Forms.TextBox tbxCalibrationStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCamTyp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.CheckBox cebxCoordSys;
        private System.Windows.Forms.CheckBox cebxMarkCenter;
        private System.Windows.Forms.CheckBox cebxPlateRegion;
        private System.Windows.Forms.ComboBox cboxDraw;
        private System.Windows.Forms.ComboBox cboxCoordSys;
        private System.Windows.Forms.ComboBox cboxMarkCenters;
        private System.Windows.Forms.ComboBox cboxPlateRegion;
        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnMaxDiamReset;
        private System.Windows.Forms.NumericUpDown nudMaxDiam;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnMinContLReset;
        private System.Windows.Forms.NumericUpDown nudMinContL;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btnSmootingReset;
        private System.Windows.Forms.NumericUpDown nudSmooth;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button btnMinThreshReset;
        private System.Windows.Forms.NumericUpDown nudMinThresh;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button btnThreshDecrReset;
        private System.Windows.Forms.NumericUpDown nudThreshDecr;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnInitThreshReset;
        private System.Windows.Forms.NumericUpDown nudInitThresh;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btnMinDiamReset;
        private System.Windows.Forms.NumericUpDown nudMinDiam;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnMarkThreshReset;
        private System.Windows.Forms.NumericUpDown nudMarkThresh;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnFilterSizeReset;
        private System.Windows.Forms.NumericUpDown nudFilterSize;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel PanelAreaScanPolynom;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Panel PanelKappa;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbxKappa;
        private System.Windows.Forms.Label label59;
    }
}