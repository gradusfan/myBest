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
    public partial class frm_Mesbox : Form
    {

        static frm_Mesbox _instance;
        public frm_Mesbox()
        {
            InitializeComponent();
        }

        public static frm_Mesbox SingleShow(string caption, string txt)
        {
                if (_instance == null)
                    _instance = new frm_Mesbox();
                _instance.Message(caption, txt);
                return _instance;
    
        }
        public  void Message(string caption,string txt)
        {
            this.Text = caption;
            lblMes.Text = txt;

        }
        private void frm_Mesbox_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.CenterToParent();
            this.Text = "信息";
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            this.Hide();
            _instance = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            _instance = null;
        }
    }
}
