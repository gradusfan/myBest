namespace XFF_Vision
{
    partial class frm_Example
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Example));
            this.tvwExample = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvwExample
            // 
            this.tvwExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwExample.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvwExample.Location = new System.Drawing.Point(0, 0);
            this.tvwExample.Name = "tvwExample";
            this.tvwExample.Size = new System.Drawing.Size(211, 487);
            this.tvwExample.TabIndex = 0;
            this.tvwExample.DoubleClick += new System.EventHandler(this.tvwExample_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Open2_32x32.png");
            this.imageList1.Images.SetKeyName(1, "File.png");
            // 
            // frm_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 487);
            this.Controls.Add(this.tvwExample);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frm_Example";
            this.Text = "例程";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Example_FormClosing);
            this.Load += new System.EventHandler(this.frm_Example_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwExample;
        private System.Windows.Forms.ImageList imageList1;
    }
}