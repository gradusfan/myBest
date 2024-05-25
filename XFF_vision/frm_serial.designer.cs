namespace XFF_Vision
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
            this.comPort2 = new SerialPortCon.ComPort();
            this.comPort1 = new SerialPortCon.ComPort();
            this.dmButtonCloseLight1 = new DMSkin.Controls.DMButtonCloseLight();
            this.SuspendLayout();
            // 
            // comPort2
            // 
            this.comPort2.Location = new System.Drawing.Point(275, 34);
            this.comPort2.Msg = "";
            this.comPort2.Name = "comPort2";
            this.comPort2.Size = new System.Drawing.Size(257, 206);
            this.comPort2.State = false;
            this.comPort2.TabIndex = 1;
            // 
            // comPort1
            // 
            this.comPort1.Location = new System.Drawing.Point(12, 34);
            this.comPort1.Msg = "";
            this.comPort1.Name = "comPort1";
            this.comPort1.Size = new System.Drawing.Size(257, 206);
            this.comPort1.State = false;
            this.comPort1.TabIndex = 0;
            this.comPort1.Load += new System.EventHandler(this.comPort1_Load);
            // 
            // dmButtonCloseLight1
            // 
            this.dmButtonCloseLight1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonCloseLight1.Location = new System.Drawing.Point(516, 1);
            this.dmButtonCloseLight1.MaximumSize = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLight1.MinimumSize = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLight1.Name = "dmButtonCloseLight1";
            this.dmButtonCloseLight1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLight1.TabIndex = 2;
            this.dmButtonCloseLight1.Click += new System.EventHandler(this.dmButtonCloseLight1_Click);
            // 
            // frm_Serial
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(547, 240);
            this.Controls.Add(this.comPort2);
            this.Controls.Add(this.comPort1);
            this.Controls.Add(this.dmButtonCloseLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_serial_FormClosing);
            this.Load += new System.EventHandler(this.frm_serial_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private SerialPortCon.ComPort comPort1;
        private SerialPortCon.ComPort comPort2;
        private DMSkin.Controls.DMButtonCloseLight dmButtonCloseLight1;
    }
}