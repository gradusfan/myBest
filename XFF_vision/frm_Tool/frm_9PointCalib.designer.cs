namespace XFF_vision.frm_Tool
{
    partial  class frm_9PointCalib

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_9PointCalib));
            this.halconView1 = new ViewControl.HalconView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImageX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImageY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorldX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorldY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddImageCoord = new System.Windows.Forms.Button();
            this.btnCalib = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCalib1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxWorldrY = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxWorldrX = new System.Windows.Forms.TextBox();
            this.btnGetImageCoord3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxWorldY3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxWorldX3 = new System.Windows.Forms.TextBox();
            this.btnGetImageCoord2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxWorldY2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxWorldX2 = new System.Windows.Forms.TextBox();
            this.btnGetImageCoord1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxWorldY1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxWorldX1 = new System.Windows.Forms.TextBox();
            this.cbxModelName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.lblCalib = new System.Windows.Forms.Label();
            this.btndrawRoi = new System.Windows.Forms.Button();
            this.btnPLC = new System.Windows.Forms.Button();
            this.btnGetImageCoord = new System.Windows.Forms.Button();
            this.tbxWorldY = new System.Windows.Forms.TextBox();
            this.tbxImageY = new System.Windows.Forms.TextBox();
            this.tbxWorldX = new System.Windows.Forms.TextBox();
            this.tbxImageX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxImage = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSetdraw = new System.Windows.Forms.ComboBox();
            this.cebxIsRectangle = new System.Windows.Forms.CheckBox();
            this.cebxIsSelectedRegions = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.cbxAngle = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // halconView1
            // 
            this.halconView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.HalconWindow = hWindow2;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(388, 17);
            this.halconView1.Name = "halconView1";
            this.halconView1.ShowStatus1 = false;
            this.halconView1.ShowStatus2 = false;
            this.halconView1.Size = new System.Drawing.Size(593, 514);
            this.halconView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.cbxModelName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.tbxToolName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设定";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(5, 245);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(351, 205);
            this.tabControl2.TabIndex = 37;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.btnAddImageCoord);
            this.tabPage3.Controls.Add(this.btnCalib);
            this.tabPage3.Controls.Add(this.btnDeleteAll);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(343, 179);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "九点坐标";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItems,
            this.chImageX,
            this.chImageY,
            this.chWorldX,
            this.chWorldY});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 142);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chItems
            // 
            this.chItems.Text = "  序号";
            this.chItems.Width = 70;
            // 
            // chImageX
            // 
            this.chImageX.Text = "ImageX";
            this.chImageX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chImageX.Width = 70;
            // 
            // chImageY
            // 
            this.chImageY.Text = "ImageY";
            this.chImageY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chImageY.Width = 70;
            // 
            // chWorldX
            // 
            this.chWorldX.Text = "WorldX";
            this.chWorldX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWorldX.Width = 70;
            // 
            // chWorldY
            // 
            this.chWorldY.Text = "WorldY";
            this.chWorldY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWorldY.Width = 70;
            // 
            // btnAddImageCoord
            // 
            this.btnAddImageCoord.Location = new System.Drawing.Point(7, 146);
            this.btnAddImageCoord.Name = "btnAddImageCoord";
            this.btnAddImageCoord.Size = new System.Drawing.Size(75, 23);
            this.btnAddImageCoord.TabIndex = 12;
            this.btnAddImageCoord.Text = "添加坐标";
            this.btnAddImageCoord.UseVisualStyleBackColor = true;
            this.btnAddImageCoord.Click += new System.EventHandler(this.btnAddImageCoord_Click);
            // 
            // btnCalib
            // 
            this.btnCalib.Location = new System.Drawing.Point(94, 146);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(75, 23);
            this.btnCalib.TabIndex = 14;
            this.btnCalib.Text = "标定";
            this.btnCalib.UseVisualStyleBackColor = true;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(178, 146);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 13;
            this.btnDeleteAll.Text = "全部删除";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage4.Controls.Add(this.cbxAngle);
            this.tabPage4.Controls.Add(this.btnCalib1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.tbxWorldrY);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.tbxWorldrX);
            this.tabPage4.Controls.Add(this.btnGetImageCoord3);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.tbxWorldY3);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.tbxWorldX3);
            this.tabPage4.Controls.Add(this.btnGetImageCoord2);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.tbxWorldY2);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.tbxWorldX2);
            this.tabPage4.Controls.Add(this.btnGetImageCoord1);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbxWorldY1);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.tbxWorldX1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(343, 179);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "工具中心坐标";
            // 
            // btnCalib1
            // 
            this.btnCalib1.Location = new System.Drawing.Point(232, 137);
            this.btnCalib1.Name = "btnCalib1";
            this.btnCalib1.Size = new System.Drawing.Size(75, 23);
            this.btnCalib1.TabIndex = 35;
            this.btnCalib1.Text = "计算坐标";
            this.btnCalib1.UseVisualStyleBackColor = true;
            this.btnCalib1.Click += new System.EventHandler(this.btnCalib1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "ry:";
            // 
            // tbxWorldrY
            // 
            this.tbxWorldrY.Location = new System.Drawing.Point(144, 137);
            this.tbxWorldrY.Name = "tbxWorldrY";
            this.tbxWorldrY.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldrY.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 33;
            this.label16.Text = "rx:";
            // 
            // tbxWorldrX
            // 
            this.tbxWorldrX.Location = new System.Drawing.Point(34, 136);
            this.tbxWorldrX.Name = "tbxWorldrX";
            this.tbxWorldrX.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldrX.TabIndex = 31;
            // 
            // btnGetImageCoord3
            // 
            this.btnGetImageCoord3.Location = new System.Drawing.Point(232, 105);
            this.btnGetImageCoord3.Name = "btnGetImageCoord3";
            this.btnGetImageCoord3.Size = new System.Drawing.Size(75, 23);
            this.btnGetImageCoord3.TabIndex = 26;
            this.btnGetImageCoord3.Text = "获取坐标";
            this.btnGetImageCoord3.UseVisualStyleBackColor = true;
            this.btnGetImageCoord3.Click += new System.EventHandler(this.btnGetImageCoord3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "y3:";
            // 
            // tbxWorldY3
            // 
            this.tbxWorldY3.Location = new System.Drawing.Point(144, 107);
            this.tbxWorldY3.Name = "tbxWorldY3";
            this.tbxWorldY3.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldY3.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "x3:";
            // 
            // tbxWorldX3
            // 
            this.tbxWorldX3.Location = new System.Drawing.Point(35, 106);
            this.tbxWorldX3.Name = "tbxWorldX3";
            this.tbxWorldX3.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldX3.TabIndex = 27;
            // 
            // btnGetImageCoord2
            // 
            this.btnGetImageCoord2.Location = new System.Drawing.Point(232, 76);
            this.btnGetImageCoord2.Name = "btnGetImageCoord2";
            this.btnGetImageCoord2.Size = new System.Drawing.Size(75, 23);
            this.btnGetImageCoord2.TabIndex = 21;
            this.btnGetImageCoord2.Text = "获取坐标";
            this.btnGetImageCoord2.UseVisualStyleBackColor = true;
            this.btnGetImageCoord2.Click += new System.EventHandler(this.btnGetImageCoord2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "y2:";
            // 
            // tbxWorldY2
            // 
            this.tbxWorldY2.Location = new System.Drawing.Point(144, 78);
            this.tbxWorldY2.Name = "tbxWorldY2";
            this.tbxWorldY2.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldY2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "x2:";
            // 
            // tbxWorldX2
            // 
            this.tbxWorldX2.Location = new System.Drawing.Point(35, 77);
            this.tbxWorldX2.Name = "tbxWorldX2";
            this.tbxWorldX2.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldX2.TabIndex = 22;
            // 
            // btnGetImageCoord1
            // 
            this.btnGetImageCoord1.Location = new System.Drawing.Point(232, 9);
            this.btnGetImageCoord1.Name = "btnGetImageCoord1";
            this.btnGetImageCoord1.Size = new System.Drawing.Size(75, 23);
            this.btnGetImageCoord1.TabIndex = 17;
            this.btnGetImageCoord1.Text = "获取坐标";
            this.btnGetImageCoord1.UseVisualStyleBackColor = true;
            this.btnGetImageCoord1.Click += new System.EventHandler(this.btnGetImageCoord1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "y1:";
            // 
            // tbxWorldY1
            // 
            this.tbxWorldY1.Location = new System.Drawing.Point(144, 11);
            this.tbxWorldY1.Name = "tbxWorldY1";
            this.tbxWorldY1.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldY1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "x1:";
            // 
            // tbxWorldX1
            // 
            this.tbxWorldX1.Location = new System.Drawing.Point(35, 10);
            this.tbxWorldX1.Name = "tbxWorldX1";
            this.tbxWorldX1.Size = new System.Drawing.Size(70, 21);
            this.tbxWorldX1.TabIndex = 17;
            // 
            // cbxModelName
            // 
            this.cbxModelName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxModelName.FormattingEnabled = true;
            this.cbxModelName.Location = new System.Drawing.Point(89, 93);
            this.cbxModelName.Name = "cbxModelName";
            this.cbxModelName.Size = new System.Drawing.Size(263, 22);
            this.cbxModelName.TabIndex = 31;
            this.cbxModelName.SelectedIndexChanged += new System.EventHandler(this.cbxModelName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "模板定位选择：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.port);
            this.groupBox3.Controls.Add(this.ip);
            this.groupBox3.Controls.Add(this.lblCalib);
            this.groupBox3.Controls.Add(this.btndrawRoi);
            this.groupBox3.Controls.Add(this.btnPLC);
            this.groupBox3.Controls.Add(this.btnGetImageCoord);
            this.groupBox3.Controls.Add(this.tbxWorldY);
            this.groupBox3.Controls.Add(this.tbxImageY);
            this.groupBox3.Controls.Add(this.tbxWorldX);
            this.groupBox3.Controls.Add(this.tbxImageX);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 121);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "标定操作";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "A区";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "获取plc坐标";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "机器ip";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(289, 66);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(63, 21);
            this.port.TabIndex = 14;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(201, 67);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(81, 21);
            this.ip.TabIndex = 13;
            // 
            // lblCalib
            // 
            this.lblCalib.AutoSize = true;
            this.lblCalib.Location = new System.Drawing.Point(300, 100);
            this.lblCalib.Name = "lblCalib";
            this.lblCalib.Size = new System.Drawing.Size(41, 12);
            this.lblCalib.TabIndex = 12;
            this.lblCalib.Text = "未标定";
            // 
            // btndrawRoi
            // 
            this.btndrawRoi.Location = new System.Drawing.Point(228, 12);
            this.btndrawRoi.Name = "btndrawRoi";
            this.btndrawRoi.Size = new System.Drawing.Size(75, 23);
            this.btndrawRoi.TabIndex = 11;
            this.btndrawRoi.Text = "创建点区域";
            this.btndrawRoi.UseVisualStyleBackColor = true;
            this.btndrawRoi.Click += new System.EventHandler(this.btndrawRoi_Click);
            // 
            // btnPLC
            // 
            this.btnPLC.Location = new System.Drawing.Point(39, 145);
            this.btnPLC.Name = "btnPLC";
            this.btnPLC.Size = new System.Drawing.Size(86, 23);
            this.btnPLC.TabIndex = 10;
            this.btnPLC.Text = "获取机械坐标";
            this.btnPLC.UseVisualStyleBackColor = true;
            this.btnPLC.Click += new System.EventHandler(this.btnPLC_Click);
            // 
            // btnGetImageCoord
            // 
            this.btnGetImageCoord.Location = new System.Drawing.Point(55, 95);
            this.btnGetImageCoord.Name = "btnGetImageCoord";
            this.btnGetImageCoord.Size = new System.Drawing.Size(75, 23);
            this.btnGetImageCoord.TabIndex = 9;
            this.btnGetImageCoord.Text = "获取坐标";
            this.btnGetImageCoord.UseVisualStyleBackColor = true;
            this.btnGetImageCoord.Click += new System.EventHandler(this.btnGetImageCoord_Click);
            // 
            // tbxWorldY
            // 
            this.tbxWorldY.Location = new System.Drawing.Point(135, 68);
            this.tbxWorldY.Name = "tbxWorldY";
            this.tbxWorldY.Size = new System.Drawing.Size(60, 21);
            this.tbxWorldY.TabIndex = 8;
            this.tbxWorldY.TextChanged += new System.EventHandler(this.tbxWorldY_TextChanged);
            // 
            // tbxImageY
            // 
            this.tbxImageY.Location = new System.Drawing.Point(135, 41);
            this.tbxImageY.Name = "tbxImageY";
            this.tbxImageY.Size = new System.Drawing.Size(60, 21);
            this.tbxImageY.TabIndex = 7;
            // 
            // tbxWorldX
            // 
            this.tbxWorldX.Location = new System.Drawing.Point(55, 68);
            this.tbxWorldX.Name = "tbxWorldX";
            this.tbxWorldX.Size = new System.Drawing.Size(60, 21);
            this.tbxWorldX.TabIndex = 6;
            this.tbxWorldX.TextChanged += new System.EventHandler(this.tbxWorldX_TextChanged);
            // 
            // tbxImageX
            // 
            this.tbxImageX.Location = new System.Drawing.Point(55, 41);
            this.tbxImageX.Name = "tbxImageX";
            this.tbxImageX.Size = new System.Drawing.Size(60, 21);
            this.tbxImageX.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y坐标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "X坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图像";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(89, 11);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(269, 26);
            this.tbxToolName.TabIndex = 17;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxImage);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 45);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // cbxImage
            // 
            this.cbxImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxImage.FormattingEnabled = true;
            this.cbxImage.Location = new System.Drawing.Point(83, 16);
            this.cbxImage.Name = "cbxImage";
            this.cbxImage.Size = new System.Drawing.Size(263, 22);
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
            this.label31.Location = new System.Drawing.Point(30, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 16;
            this.label31.Text = "工具名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbxSetdraw);
            this.tabPage2.Controls.Add(this.cebxIsRectangle);
            this.tabPage2.Controls.Add(this.cebxIsSelectedRegions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(362, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图形";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "显示：";
            // 
            // cbxSetdraw
            // 
            this.cbxSetdraw.FormattingEnabled = true;
            this.cbxSetdraw.Items.AddRange(new object[] {
            "fill",
            "margin"});
            this.cbxSetdraw.Location = new System.Drawing.Point(95, 124);
            this.cbxSetdraw.Name = "cbxSetdraw";
            this.cbxSetdraw.Size = new System.Drawing.Size(121, 20);
            this.cbxSetdraw.TabIndex = 7;
            this.cbxSetdraw.Text = "fill";
            this.cbxSetdraw.SelectedIndexChanged += new System.EventHandler(this.cbxSetdraw_SelectedIndexChanged);
            // 
            // cebxIsRectangle
            // 
            this.cebxIsRectangle.AutoSize = true;
            this.cebxIsRectangle.BackColor = System.Drawing.Color.Silver;
            this.cebxIsRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsRectangle.Location = new System.Drawing.Point(95, 51);
            this.cebxIsRectangle.Name = "cebxIsRectangle";
            this.cebxIsRectangle.Size = new System.Drawing.Size(70, 16);
            this.cebxIsRectangle.TabIndex = 6;
            this.cebxIsRectangle.Text = "显示矩形";
            this.cebxIsRectangle.UseVisualStyleBackColor = false;
            this.cebxIsRectangle.CheckedChanged += new System.EventHandler(this.cebxIsRectangle_CheckedChanged);
            // 
            // cebxIsSelectedRegions
            // 
            this.cebxIsSelectedRegions.AutoSize = true;
            this.cebxIsSelectedRegions.BackColor = System.Drawing.Color.Silver;
            this.cebxIsSelectedRegions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cebxIsSelectedRegions.Location = new System.Drawing.Point(95, 17);
            this.cebxIsSelectedRegions.Name = "cebxIsSelectedRegions";
            this.cebxIsSelectedRegions.Size = new System.Drawing.Size(94, 16);
            this.cebxIsSelectedRegions.TabIndex = 5;
            this.cebxIsSelectedRegions.Text = "显示面积区域";
            this.cebxIsSelectedRegions.UseVisualStyleBackColor = false;
            this.cebxIsSelectedRegions.CheckedChanged += new System.EventHandler(this.cebxIsSelectedRegions_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(303, 502);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(226, 502);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 35;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(16, 502);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 34;
            this.btn_run.Text = "运行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // cbxAngle
            // 
            this.cbxAngle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAngle.FormattingEnabled = true;
            this.cbxAngle.Location = new System.Drawing.Point(33, 38);
            this.cbxAngle.Name = "cbxAngle";
            this.cbxAngle.Size = new System.Drawing.Size(181, 22);
            this.cbxAngle.TabIndex = 36;
            this.cbxAngle.SelectedIndexChanged += new System.EventHandler(this.cbxAngle_SelectedIndexChanged);
            // 
            // frm_9PointCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(987, 543);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.halconView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_9PointCalib";
            this.Text = "9点标定";
            this.Load += new System.EventHandler(this.frm_9PointCalib_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ViewControl.HalconView halconView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalib;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAddImageCoord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chItems;
        private System.Windows.Forms.ColumnHeader chImageX;
        private System.Windows.Forms.ColumnHeader chImageY;
        private System.Windows.Forms.ColumnHeader chWorldX;
        private System.Windows.Forms.ColumnHeader chWorldY;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btndrawRoi;
        private System.Windows.Forms.Button btnPLC;
        private System.Windows.Forms.Button btnGetImageCoord;
        private System.Windows.Forms.TextBox tbxWorldY;
        private System.Windows.Forms.TextBox tbxImageY;
        private System.Windows.Forms.TextBox tbxWorldX;
        private System.Windows.Forms.TextBox tbxImageX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxModelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSetdraw;
        private System.Windows.Forms.CheckBox cebxIsRectangle;
        private System.Windows.Forms.CheckBox cebxIsSelectedRegions;
        private System.Windows.Forms.Label lblCalib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCalib1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxWorldrY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxWorldrX;
        private System.Windows.Forms.Button btnGetImageCoord3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxWorldY3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxWorldX3;
        private System.Windows.Forms.Button btnGetImageCoord2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxWorldY2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxWorldX2;
        private System.Windows.Forms.Button btnGetImageCoord1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxWorldY1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxWorldX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxAngle;
    }
}