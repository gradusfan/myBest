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
    public partial class Form_main : MetroForm
    {


        private Form_set form2 = new Form_set();
        private Form3 form3 = new Form3();
        public Form_main()
        {
            InitializeComponent();
        }
        //主页
     
   

        private void button5_Click(object sender, EventArgs e)
        {
            openForm(new Form3());
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

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }

        private void btn_rest_Click(object sender, EventArgs e)
        {

        }

        private void btn_camera_Click(object sender, EventArgs e)
        {

        }

       


        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_set_Click(object sender, EventArgs e)
        {

        }


        private void btn_quite_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出软件吗?", "WARNING", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Exit();
            else
                return;
        }
    }
}
