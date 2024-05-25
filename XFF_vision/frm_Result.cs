using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace XFF_Vision
{
    public partial class frm_Result : DockContent
    {
        public frm_Result()
        {
            InitializeComponent();
            this.Text = "综合结果";
        }
        private static frm_Result _instance;
        public static frm_Result Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frm_Result();
                }
                return _instance;
            }
        }
        private void frm_Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

       
    }
}
