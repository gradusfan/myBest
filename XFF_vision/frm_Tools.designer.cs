namespace XFF_Vision
{
    partial class frm_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tools));
            this.tvwTools = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.展开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折叠所有节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwTools
            // 
            this.tvwTools.AllowDrop = true;
            this.tvwTools.ContextMenuStrip = this.contextMenuStrip1;
            this.tvwTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwTools.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvwTools.Indent = 24;
            this.tvwTools.ItemHeight = 25;
            this.tvwTools.LineColor = System.Drawing.Color.Green;
            this.tvwTools.Location = new System.Drawing.Point(0, 0);
            this.tvwTools.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tvwTools.Name = "tvwTools";
            this.tvwTools.Size = new System.Drawing.Size(176, 594);
            this.tvwTools.TabIndex = 24;
            this.tvwTools.DoubleClick += new System.EventHandler(this.tvw_jobs_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.展开ToolStripMenuItem,
            this.折叠所有节点ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 展开ToolStripMenuItem
            // 
            this.展开ToolStripMenuItem.Name = "展开ToolStripMenuItem";
            this.展开ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.展开ToolStripMenuItem.Text = "展开所有节点";
            this.展开ToolStripMenuItem.Click += new System.EventHandler(this.展开ToolStripMenuItem_Click);
            // 
            // 折叠所有节点ToolStripMenuItem
            // 
            this.折叠所有节点ToolStripMenuItem.Name = "折叠所有节点ToolStripMenuItem";
            this.折叠所有节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.折叠所有节点ToolStripMenuItem.Text = "折叠所有节点";
            this.折叠所有节点ToolStripMenuItem.Click += new System.EventHandler(this.折叠所有节点ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Open2_32x32.png");
            this.imageList1.Images.SetKeyName(1, "Tool.ico");
            this.imageList1.Images.SetKeyName(2, "toolbar_image_相机模块.png");
            this.imageList1.Images.SetKeyName(3, "toolbar_image_图片保存_normal.png");
            this.imageList1.Images.SetKeyName(4, "ic_图像处理组合模块.png");
            this.imageList1.Images.SetKeyName(5, "toolbar_locate_特征匹配.png");
            this.imageList1.Images.SetKeyName(6, "toolbar_cali_仿射变换.png");
            this.imageList1.Images.SetKeyName(7, "toolbar_cali_N点标定.png");
            this.imageList1.Images.SetKeyName(8, "toolbar_cali_unitconvert.png");
            this.imageList1.Images.SetKeyName(9, "toolbar_cali_透视畸变校正.png");
            this.imageList1.Images.SetKeyName(10, "toolbar_color_颜色抽取.png");
            this.imageList1.Images.SetKeyName(11, "toolbar_color_颜色空间转换.png");
            this.imageList1.Images.SetKeyName(12, "toolbar_imageprocess_图像滤波.png");
            this.imageList1.Images.SetKeyName(13, "toolbar_imageprocess_图像增强.png");
            this.imageList1.Images.SetKeyName(14, "toolbar_locate_交点定位.png");
            this.imageList1.Images.SetKeyName(15, "toolbar_locate_矩形定位.png");
            this.imageList1.Images.SetKeyName(16, "toolbar_locate_卡尺.png");
            this.imageList1.Images.SetKeyName(17, "toolbar_locate_位置修正.png");
            this.imageList1.Images.SetKeyName(18, "toolbar_locate_圆查找.png");
            this.imageList1.Images.SetKeyName(19, "toolbar_locate_直线查找.png");
            this.imageList1.Images.SetKeyName(20, "toolbar_mea_p2l.png");
            this.imageList1.Images.SetKeyName(21, "toolbar_mea_p2p.png");
            this.imageList1.Images.SetKeyName(22, "toolbar_mea_线线测量.png");
            this.imageList1.Images.SetKeyName(23, "toolbar_reg_二维码识别.png");
            this.imageList1.Images.SetKeyName(24, "toolbar_reg_条码识别.png");
            this.imageList1.Images.SetKeyName(25, "toolbar_reg_字符识别.png");
            this.imageList1.Images.SetKeyName(26, "toolbar_imageprocess_图像修正.png");
            this.imageList1.Images.SetKeyName(27, "toolbar_imageprocess_形态学.png");
            this.imageList1.Images.SetKeyName(28, "toolbar_imageprocess_图像归一化.png");
            this.imageList1.Images.SetKeyName(29, "toolbar_locate_vertex.png");
            this.imageList1.Images.SetKeyName(30, "toolbar_locate_Blob.png");
            this.imageList1.Images.SetKeyName(31, "toolbar_imageprocess_二值化.png");
            this.imageList1.Images.SetKeyName(32, "toolbar_imageprocess_圆环展开.png");
            // 
            // frm_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 594);
            this.Controls.Add(this.tvwTools);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Tools";
            this.Text = "工具箱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Tools_FormClosing);
            this.Load += new System.EventHandler(this.frm_Tools_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwTools;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 展开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折叠所有节点ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}