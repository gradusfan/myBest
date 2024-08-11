
namespace FanSwProject
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_hand = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_quite = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groudbox1 = new System.Windows.Forms.GroupBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_rest = new System.Windows.Forms.Button();
            this.btn_camera = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelMain.SuspendLayout();
            this.groudbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Location = new System.Drawing.Point(7, 128);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(155, 65);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "    运行";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stop.Location = new System.Drawing.Point(7, 211);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(155, 65);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "    停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_hand
            // 
            this.btn_hand.Image = ((System.Drawing.Image)(resources.GetObject("btn_hand.Image")));
            this.btn_hand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hand.Location = new System.Drawing.Point(1, 474);
            this.btn_hand.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hand.Name = "btn_hand";
            this.btn_hand.Size = new System.Drawing.Size(155, 65);
            this.btn_hand.TabIndex = 5;
            this.btn_hand.Text = "     手动";
            this.btn_hand.UseVisualStyleBackColor = true;
            this.btn_hand.Click += new System.EventHandler(this.btn_hand_Click);
            // 
            // btn_set
            // 
            this.btn_set.Image = ((System.Drawing.Image)(resources.GetObject("btn_set.Image")));
            this.btn_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.Location = new System.Drawing.Point(7, 656);
            this.btn_set.Margin = new System.Windows.Forms.Padding(4);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(155, 65);
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "   设置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(7, 751);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 65);
            this.button6.TabIndex = 3;
            this.button6.Text = "    日志";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_quite
            // 
            this.btn_quite.Image = ((System.Drawing.Image)(resources.GetObject("btn_quite.Image")));
            this.btn_quite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quite.Location = new System.Drawing.Point(7, 851);
            this.btn_quite.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quite.Name = "btn_quite";
            this.btn_quite.Size = new System.Drawing.Size(155, 65);
            this.btn_quite.TabIndex = 6;
            this.btn_quite.Text = "   关闭";
            this.btn_quite.UseVisualStyleBackColor = true;
            this.btn_quite.Click += new System.EventHandler(this.btn_quite_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.listView1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMain.Size = new System.Drawing.Size(1837, 1041);
            this.panelMain.TabIndex = 7;
            // 
            // groudbox1
            // 
            this.groudbox1.Controls.Add(this.btn_hand);
            this.groudbox1.Controls.Add(this.btn_home);
            this.groudbox1.Controls.Add(this.btn_quite);
            this.groudbox1.Controls.Add(this.button2);
            this.groudbox1.Controls.Add(this.btn_start);
            this.groudbox1.Controls.Add(this.button6);
            this.groudbox1.Controls.Add(this.btn_rest);
            this.groudbox1.Controls.Add(this.btn_stop);
            this.groudbox1.Controls.Add(this.btn_set);
            this.groudbox1.Controls.Add(this.btn_camera);
            this.groudbox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groudbox1.Location = new System.Drawing.Point(1663, 60);
            this.groudbox1.Name = "groudbox1";
            this.groudbox1.Size = new System.Drawing.Size(174, 1041);
            this.groudbox1.TabIndex = 9;
            this.groudbox1.TabStop = false;
            this.groudbox1.Text = "菜单";
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(7, 44);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(149, 65);
            this.btn_home.TabIndex = 10;
            this.btn_home.Text = "    主页";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 65);
            this.button2.TabIndex = 8;
            this.button2.Text = "    备用";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_rest
            // 
            this.btn_rest.Image = ((System.Drawing.Image)(resources.GetObject("btn_rest.Image")));
            this.btn_rest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rest.Location = new System.Drawing.Point(7, 297);
            this.btn_rest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(155, 65);
            this.btn_rest.TabIndex = 9;
            this.btn_rest.Text = "    复位";
            this.btn_rest.UseVisualStyleBackColor = true;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // btn_camera
            // 
            this.btn_camera.Image = ((System.Drawing.Image)(resources.GetObject("btn_camera.Image")));
            this.btn_camera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_camera.Location = new System.Drawing.Point(7, 386);
            this.btn_camera.Margin = new System.Windows.Forms.Padding(4);
            this.btn_camera.Name = "btn_camera";
            this.btn_camera.Size = new System.Drawing.Size(155, 65);
            this.btn_camera.TabIndex = 7;
            this.btn_camera.Text = "    视觉";
            this.btn_camera.UseVisualStyleBackColor = true;
            this.btn_camera.Click += new System.EventHandler(this.btn_camera_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 813);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1837, 228);
            this.listView1.TabIndex = 0;
            this.listView1.Tag = "";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1837, 1101);
            this.Controls.Add(this.groudbox1);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_main";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.panelMain.ResumeLayout(false);
            this.groudbox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_hand;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_quite;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groudbox1;
        private System.Windows.Forms.Button btn_rest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_camera;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ListView listView1;
    }
}