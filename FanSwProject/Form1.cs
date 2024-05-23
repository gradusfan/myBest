using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FanSwProject
{
    public partial class Form1 : MetroForm
    {


        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }
        //主页
     
   

        private void button5_Click(object sender, EventArgs e)
        {
            openForm(new Form3());
        }

        private void butt0n7_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("确定要退出软件吗?", "WARNING", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Exit();
            else
                return;

        }

        private void  openForm(Form frm)
        {
            frm.TopLevel = false;
            frm.TopMost = false;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }
        //手动按钮
        private void btn_hand_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(1392, 740);
        //    this.Name = "Form1";
        //    this.ResumeLayout(false);

        //}
    }
}
