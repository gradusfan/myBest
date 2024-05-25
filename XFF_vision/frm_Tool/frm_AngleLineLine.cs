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

namespace XFF_Vision.frm_Tool
{
    public partial class frm_AngleLineLine : Form
    {    
        static frm_AngleLineLine frm;
        DistanceAngleLineLineTool distanceALlTool = new DistanceAngleLineLineTool();
        public delegate void HandledSetVal(DistanceAngleLineLineTool distanceALlTool);
        HandledSetVal handleSetval;
        /// <summary>
        /// 单实例
        /// </summary>
        /// <param name="fb"></param>
        public static frm_AngleLineLine SingleShow(DistanceAngleLineLineTool distanceALlTool, HandledSetVal handleSetval)
        {
            if (frm == null)//
            {
                frm = new frm_AngleLineLine(distanceALlTool, handleSetval);
            }
            return frm;
        }

        public frm_AngleLineLine(DistanceAngleLineLineTool distanceALlTool, HandledSetVal handleSetval)
        {
            InitializeComponent();
            this.handleSetval = handleSetval;
            DisplayVal(distanceALlTool);
            this.distanceALlTool.Image = distanceALlTool.Image;
            this.distanceALlTool.HtRowLine1 = distanceALlTool.HtRowLine1;
            this.distanceALlTool.HtRowLine2 = distanceALlTool.HtRowLine2;
            this.distanceALlTool.HtColLine1 = distanceALlTool.HtColLine1;
            this.distanceALlTool.HtColLine2 = distanceALlTool.HtColLine2;
            this.SetVal(ref this.distanceALlTool);
         }

        void DisplayVal(DistanceAngleLineLineTool distanceALlTool)
        {
            try
            {
                Cancel();//注销事件
                int nameIndex = distanceALlTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = distanceALlTool.Names.Substring(nameIndex + 1, distanceALlTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;
                }
                else
                {
                    this.Text = distanceALlTool.Names;
                    tbxToolName.Text = distanceALlTool.Names;
                }
                cbxImage.Text = distanceALlTool.ImageName;//
                cbxLineName1.Text = distanceALlTool.LineName1;
                cbxLineName2.Text = distanceALlTool.LineName2;
                nudHangle.Value = Convert.ToDecimal(distanceALlTool.Hmeasure.D);
                nudLangle.Value = Convert.ToDecimal(distanceALlTool.Lmeasure.D);
                cebxAngle.Checked = distanceALlTool.IsMeasure;
                cbxImage.Items.Clear();
                if (distanceALlTool.Image != null)
                {
                    foreach (var item in distanceALlTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)distanceALlTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
                cbxLineName1.Items.Clear();
                if (distanceALlTool.HtRowLine1 != null)
                {
                    foreach (var item in distanceALlTool.HtRowLine1.Keys)
                    {
                        cbxLineName1.Items.Add(item);//加载点
                        cbxLineName2.Items.Add(item);//加载点
                    }
                }
                Register();//注册事件
            }
            catch
            {
                cbxImage.Items.Clear();
                if (distanceALlTool.Image != null)
                {
                    foreach (var item in distanceALlTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                cbxLineName1.Items.Clear();
                if (distanceALlTool.HtRowLine1 != null)
                {
                    foreach (var item in distanceALlTool.HtRowLine1.Keys)
                    {
                        cbxLineName1.Items.Add(item);//加载点
                        cbxLineName2.Items.Add(item);//加载点
                    }
                } Register();
            }
        }
        void SetVal(ref DistanceAngleLineLineTool distanceALlTool)
        {
            try
            {
                distanceALlTool.Names = ImageTool.Tool.两线夹角测量.ToString() + "_" + tbxToolName.Text;
                distanceALlTool.ImageName = cbxImage.Text;
                distanceALlTool.LineName1 = cbxLineName1.Text;
                distanceALlTool.LineName2 = cbxLineName2.Text;
                distanceALlTool.Lmeasure = (double)nudLangle.Value;
                distanceALlTool.Hmeasure = (double)nudHangle.Value;
                distanceALlTool.IsMeasure = cebxAngle.Checked;
            }
            catch { }
        }
        void Cancel()
        {
            cbxLineName1.SelectedIndexChanged -= new EventHandler(cbxLineName1_SelectedIndexChanged);
            cbxLineName2.SelectedIndexChanged -= new EventHandler(cbxLineName2_SelectedIndexChanged);
           nudLangle.ValueChanged -= new EventHandler(nudLangle_ValueChanged);
            nudHangle.ValueChanged -= new EventHandler(nudHangle_ValueChanged);
            cebxAngle.CheckedChanged -= new EventHandler(cebxAngle_CheckedChanged);
        }
        void Register()
        {
            cbxLineName1.SelectedIndexChanged += new EventHandler(cbxLineName1_SelectedIndexChanged);
            cbxLineName2.SelectedIndexChanged += new EventHandler(cbxLineName2_SelectedIndexChanged);
            nudLangle.ValueChanged += new EventHandler(nudLangle_ValueChanged);
            nudHangle.ValueChanged += new EventHandler(nudHangle_ValueChanged);
            cebxAngle.CheckedChanged += new EventHandler(cebxAngle_CheckedChanged);
        }

        public frm_AngleLineLine()
        {
            InitializeComponent();
        }

        private void frm_DistancePointPoint_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormClosing += frm_AngleLineLine_FormClosing;
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "blue");
            this.CenterToScreen();
            this.distanceALlTool.WindowControl = halconView1.HWindowControl;

        }

        void frm_AngleLineLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = null;
        }

        private void tbxToolName_TextChanged(object sender, EventArgs e)
        {
            distanceALlTool.Names = ImageTool.Tool.两线夹角测量.ToString() + "_" + tbxToolName.Text;
        }
        private void cbxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            distanceALlTool.ImageName = cbxImage.Text;
            halconView1.DispImage((HObject)this.distanceALlTool.Image[cbxImage.Text], true);
            halconView1.FitImage();
       

        }

        private void cbxLineName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            distanceALlTool.LineName1 = cbxLineName1.Text;
            distanceALlTool.set_after();
          
        }

        private void cbxLineName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            distanceALlTool.LineName2 = cbxLineName2.Text;
            distanceALlTool.set_after();
   
        }

        private void nudLangle_ValueChanged(object sender, EventArgs e)
        {
            distanceALlTool.Lmeasure = (double)nudLangle.Value;
            distanceALlTool.set_after();
    
        }

        private void nudHangle_ValueChanged(object sender, EventArgs e)
        {
            distanceALlTool.Hmeasure = (double)nudHangle.Value;
            distanceALlTool.set_after();
          
        }

        private void cebxAngle_CheckedChanged(object sender, EventArgs e)
        {
            distanceALlTool.IsMeasure = cebxAngle.Checked;
            distanceALlTool.set_after();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            try { 
            long timer = distanceALlTool.set_after();
            lblResult.Text = "FAIL";
            lblResult.BackColor = Color.Red;
            halconView1.ToolLable2.Text = "FAIL";
            halconView1.ToolLable2.ForeColor = Color.Red;
            if (this.distanceALlTool.ResultLogic)
            {
                lblResult.Text = "PASS";
                lblResult.BackColor = Color.LimeGreen;
                halconView1.ToolLable2.Text = "PASS";
                halconView1.ToolLable2.ForeColor = Color.Lime;
            }
            lblTimer.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
            halconView1.ToolLable3.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
            lblResult.Text = distanceALlTool.Angle.D.ToString();
            }
            catch
            {
                MessageBox.Show("结果输出异常,查看设定参数！");
            }

        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetVal(ref this.distanceALlTool);
                this.Hide();
                frm = null;
                handleSetval(this.distanceALlTool);
            }
            catch
            {
                this.Hide();
                frm = null;
                handleSetval(this.distanceALlTool);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = null;
        }

        private void halconView1_HMouseWheelEvent(object sender)
        {
            distanceALlTool.dispresult();
        }
    }
}
