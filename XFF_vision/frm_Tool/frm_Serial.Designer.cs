namespace XFF_Vision.frm_Tool
{
    partial class frm_Serial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCom1 = new System.Windows.Forms.Button();
            this.ptbComState1 = new System.Windows.Forms.PictureBox();
            this.cbxPortName1 = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate1 = new System.Windows.Forms.ComboBox();
            this.cbxParity1 = new System.Windows.Forms.ComboBox();
            this.cbxDataBits1 = new System.Windows.Forms.ComboBox();
            this.cbxStopBits1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxToolName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComState1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCom1);
            this.groupBox1.Controls.Add(this.ptbComState1);
            this.groupBox1.Controls.Add(this.cbxPortName1);
            this.groupBox1.Controls.Add(this.cbxBaudRate1);
            this.groupBox1.Controls.Add(this.cbxParity1);
            this.groupBox1.Controls.Add(this.cbxDataBits1);
            this.groupBox1.Controls.Add(this.cbxStopBits1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 219);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(0, 184);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 29);
            this.btnSend.TabIndex = 63;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(81, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 21);
            this.textBox1.TabIndex = 62;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCom1
            // 
            this.btnCom1.Location = new System.Drawing.Point(0, 149);
            this.btnCom1.Name = "btnCom1";
            this.btnCom1.Size = new System.Drawing.Size(77, 29);
            this.btnCom1.TabIndex = 59;
            this.btnCom1.Text = "打开";
            this.btnCom1.UseVisualStyleBackColor = true;
            this.btnCom1.Click += new System.EventHandler(this.btnCom1_Click);
            // 
            // ptbComState1
            // 
            this.ptbComState1.ErrorImage = null;
          
            this.ptbComState1.Location = new System.Drawing.Point(129, 148);
            this.ptbComState1.Name = "ptbComState1";
            this.ptbComState1.Size = new System.Drawing.Size(33, 30);
            this.ptbComState1.TabIndex = 56;
            this.ptbComState1.TabStop = false;
            // 
            // cbxPortName1
            // 
            this.cbxPortName1.FormattingEnabled = true;
            this.cbxPortName1.Items.AddRange(new object[] {
            "",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbxPortName1.Location = new System.Drawing.Point(65, 18);
            this.cbxPortName1.Name = "cbxPortName1";
            this.cbxPortName1.Size = new System.Drawing.Size(97, 20);
            this.cbxPortName1.TabIndex = 0;
            this.cbxPortName1.SelectedIndexChanged += new System.EventHandler(this.cbxPortName1_SelectedIndexChanged);
            // 
            // cbxBaudRate1
            // 
            this.cbxBaudRate1.FormattingEnabled = true;
            this.cbxBaudRate1.Items.AddRange(new object[] {
            "",
            "9600",
            "19200",
            "38400",
            "115200",
            ""});
            this.cbxBaudRate1.Location = new System.Drawing.Point(65, 44);
            this.cbxBaudRate1.Name = "cbxBaudRate1";
            this.cbxBaudRate1.Size = new System.Drawing.Size(97, 20);
            this.cbxBaudRate1.TabIndex = 1;
            this.cbxBaudRate1.SelectedIndexChanged += new System.EventHandler(this.cbxBaudRate1_SelectedIndexChanged);
            // 
            // cbxParity1
            // 
            this.cbxParity1.FormattingEnabled = true;
            this.cbxParity1.Items.AddRange(new object[] {
            "",
            "None",
            "Odd",
            "Even"});
            this.cbxParity1.Location = new System.Drawing.Point(65, 70);
            this.cbxParity1.Name = "cbxParity1";
            this.cbxParity1.Size = new System.Drawing.Size(97, 20);
            this.cbxParity1.TabIndex = 2;
            this.cbxParity1.SelectedIndexChanged += new System.EventHandler(this.cbxParity1_SelectedIndexChanged);
            // 
            // cbxDataBits1
            // 
            this.cbxDataBits1.FormattingEnabled = true;
            this.cbxDataBits1.Items.AddRange(new object[] {
            "",
            "7",
            "8"});
            this.cbxDataBits1.Location = new System.Drawing.Point(65, 96);
            this.cbxDataBits1.Name = "cbxDataBits1";
            this.cbxDataBits1.Size = new System.Drawing.Size(97, 20);
            this.cbxDataBits1.TabIndex = 3;
            this.cbxDataBits1.SelectedIndexChanged += new System.EventHandler(this.cbxDataBits1_SelectedIndexChanged);
            // 
            // cbxStopBits1
            // 
            this.cbxStopBits1.FormattingEnabled = true;
            this.cbxStopBits1.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.cbxStopBits1.Location = new System.Drawing.Point(65, 122);
            this.cbxStopBits1.Name = "cbxStopBits1";
            this.cbxStopBits1.Size = new System.Drawing.Size(97, 20);
            this.cbxStopBits1.TabIndex = 4;
            this.cbxStopBits1.SelectedIndexChanged += new System.EventHandler(this.cbxStopBits1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "串口：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "停止位：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "数据位：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "校应位：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "波特率：";
            // 
            // tbxToolName
            // 
            this.tbxToolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxToolName.Location = new System.Drawing.Point(95, 11);
            this.tbxToolName.Name = "tbxToolName";
            this.tbxToolName.Size = new System.Drawing.Size(245, 26);
            this.tbxToolName.TabIndex = 63;
            this.tbxToolName.TextChanged += new System.EventHandler(this.tbxToolName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "串口工具名：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(432, 282);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 65;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(351, 282);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 29);
            this.btn_sure.TabIndex = 64;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // frm_Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(520, 321);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.tbxToolName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Serial";
            this.Text = "frm_Serial";
            this.Load += new System.EventHandler(this.frm_Serial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComState1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCom1;
        private System.Windows.Forms.PictureBox ptbComState1;
        private System.Windows.Forms.ComboBox cbxPortName1;
        private System.Windows.Forms.ComboBox cbxBaudRate1;
        private System.Windows.Forms.ComboBox cbxParity1;
        private System.Windows.Forms.ComboBox cbxDataBits1;
        private System.Windows.Forms.ComboBox cbxStopBits1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxToolName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sure;
    }
}