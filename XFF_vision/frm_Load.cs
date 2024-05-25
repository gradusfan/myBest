using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFF_Vision
{
    public partial class frm_Load : Form
    {
        public frm_Main fmain;
        public string Lblinfo { get; set; }
        public frm_Load()
        {
            InitializeComponent();
        }
        private void frm_load_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            label1.Text = Lblinfo;
        }
         private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //系统初始化
            try
            {
            //    timer1.Enabled = false;
               
            //    this.fmain.LoadProduct();
              
                
            //    this.fmain.initProduct();
              
             
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();

            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message + "");
            }
        }
    }
}
