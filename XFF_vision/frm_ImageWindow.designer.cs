namespace XFF_Vision
{
    partial class frm_ImageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImageWindow));
            this.halconView1 = new ViewControl.HalconView();
            this.SuspendLayout();
            // 
            // halconView1
            // 
            this.halconView1.BackColor = System.Drawing.Color.Blue;
            this.halconView1.CausesValidation = false;
            this.halconView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halconView1.HalconWindow = hWindow1;
            this.halconView1.Image = ((System.Collections.Generic.Dictionary<string, HalconDotNet.HObject>)(resources.GetObject("halconView1.Image")));
            this.halconView1.Location = new System.Drawing.Point(0, 0);
            this.halconView1.Name = "halconView1";
            this.halconView1.ShowStatus1 = true;
            this.halconView1.ShowStatus2 = true;
            this.halconView1.Size = new System.Drawing.Size(795, 609);
            this.halconView1.TabIndex = 0;
            // 
            // frm_ImageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 609);
            this.Controls.Add(this.halconView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frm_ImageWindow";
            this.Text = "图像窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ImageWindow_FormClosing);
            this.Resize += new System.EventHandler(this.frm_ImageWindow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        internal ViewControl.HalconView halconView1;
    }
}