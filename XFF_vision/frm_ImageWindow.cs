using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;
using WeifenLuo.WinFormsUI.Docking;

namespace XFF_Vision
{
    public partial class frm_ImageWindow : DockContent
    {
        private static frm_ImageWindow _instance;
        public static frm_ImageWindow Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frm_ImageWindow();
                }
                return _instance;
            }
        }

        public frm_ImageWindow()
        {
            InitializeComponent();
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "gray");
            this.Text = "图像窗口[" + halconView1.HWindowControl.HalconID + "]";
        }

        private void frm_ImageWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void halconView1_HMouseWheelEvent(object sender)
        {
            foreach (ImageTool tool in frm_Job.Instance.tool)
            {
                tool.dispresult();
            }
        }

        private void frm_ImageWindow_Resize(object sender, EventArgs e)
        {
            try
            {
                halconView1.FitImage();
                foreach (ImageTool tool in frm_Job.Instance.tool)
                {
                    tool.dispresult();
                }
            }
            catch (Exception ce)
            {

            }

        }


    }
}
