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
    /*****20221007 阿涛添加工具****/
    public partial class frm_SurfaceBreach : Form
    {
        static frm_SurfaceBreach frm;
        SurfaceBreachTool surfaceBreachTool = new SurfaceBreachTool();
        public delegate void HandledSetVal(SurfaceBreachTool surfaceFlawTool);
        HandledSetVal handleSetval;

        public frm_SurfaceBreach()
        {
            InitializeComponent();
        }
        public frm_SurfaceBreach(SurfaceBreachTool surfaceBreachTool, HandledSetVal handleSetval)
        {
            InitializeComponent();
            this.handleSetval = handleSetval;
            DisplayVal(surfaceBreachTool);
            this.surfaceBreachTool.Image = surfaceBreachTool.Image;
            this.surfaceBreachTool.rect_sX = surfaceBreachTool.rect_sX;
            this.surfaceBreachTool.rect_sY = surfaceBreachTool.rect_sY;
            this.surfaceBreachTool.rect_eX = surfaceBreachTool.rect_eX;
            this.surfaceBreachTool.rect_eY = surfaceBreachTool.rect_eY;
            this.SetVal(ref this.surfaceBreachTool);
        }
        /// <summary>
        /// 单实例
        /// </summary>
        /// <param name="fb"></param>
        public static frm_SurfaceBreach SingleShow(SurfaceBreachTool surfaceBreachTool, HandledSetVal handleSetval)
        {
            if (frm == null)//
            {
                frm = new frm_SurfaceBreach(surfaceBreachTool, handleSetval);
            }
            return frm;
        }

        void DisplayVal(SurfaceBreachTool surfaceBreachTool)
        {
            try
            {
                Cancel();//注销事件
                int nameIndex = surfaceBreachTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = surfaceBreachTool.Names.Substring(nameIndex + 1, surfaceBreachTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;
                }
                else
                {
                    this.Text = surfaceBreachTool.Names;
                    tbxToolName.Text = surfaceBreachTool.Names;
                }
                cbxImage.Text = surfaceBreachTool.ImageName;
                cbxMethods.Text = surfaceBreachTool.Methods;
                nudMaskHeight.Value = surfaceBreachTool.etch_height;
                nudMaskWidth.Value = surfaceBreachTool.etch_width;
                nudEnhanceHeight.Value = surfaceBreachTool.enhance_height;
                nudEnhanceWidth.Value = surfaceBreachTool.enhance_width;
                nudEnhanceNum.Value = surfaceBreachTool.enhance_num;
                nudLowThreshold.Value = surfaceBreachTool.low_Threshold;
                nudHighThreshold.Value = surfaceBreachTool.high_Threshold;
                nudrectHeight.Value = surfaceBreachTool.rect_height;
                nudrectWidth.Value = surfaceBreachTool.rect_width;

                ceboxSeath.Checked = surfaceBreachTool.IsSearchRegion;
                cebxIsSurfaceFlaw.Checked = surfaceBreachTool.IsFlaw;
                cbxSetdraw.Text = surfaceBreachTool.Setdraw;
                cbxImage.Items.Clear();
                if (surfaceBreachTool.Image != null)
                {
                    foreach (var item in surfaceBreachTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)surfaceBreachTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
            }
            catch (Exception ex)
            {
                cbxImage.Items.Clear();
                if (surfaceBreachTool.Image != null)
                {
                    foreach (var item in surfaceBreachTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)surfaceBreachTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
            }
            Register();//注册事件
        }

        void SetVal(ref SurfaceBreachTool surfaceBreachTool)
        {
            surfaceBreachTool.ImageName = cbxImage.Text;
            surfaceBreachTool.Names = ImageTool.Tool.表面缺口检测.ToString() + "_" + tbxToolName.Text;

            surfaceBreachTool.etch_height = Convert.ToInt32(nudMaskHeight.Value);
            surfaceBreachTool.etch_width = Convert.ToInt32(nudMaskWidth.Value);
            surfaceBreachTool.enhance_height = Convert.ToInt32(nudEnhanceHeight.Value);
            surfaceBreachTool.enhance_width = Convert.ToInt32(nudEnhanceWidth.Value);
            surfaceBreachTool.enhance_num = Convert.ToInt32(nudEnhanceNum.Value);
            surfaceBreachTool.low_Threshold = Convert.ToInt32(nudLowThreshold.Value);
            surfaceBreachTool.high_Threshold = Convert.ToInt32(nudHighThreshold.Value);
            surfaceBreachTool.rect_height = Convert.ToInt32(nudrectHeight.Value);
            surfaceBreachTool.rect_width = Convert.ToInt32(nudrectWidth.Value);
            surfaceBreachTool.Methods = cbxMethods.Text;

            surfaceBreachTool.IsFlaw = cebxIsSurfaceFlaw.Checked;
            surfaceBreachTool.Setdraw = cbxSetdraw.Text;
            surfaceBreachTool.IsSearchRegion = ceboxSeath.Checked;
        }



        void Cancel()
        {
            nudMaskHeight.ValueChanged -= nudMaskHeight_ValueChanged;
            nudMaskHeight.ValueChanged -= nudMaskWidth_ValueChanged; ;
            nudEnhanceHeight.ValueChanged -= nudEnhanceHeight_ValueChanged;
            nudEnhanceWidth.ValueChanged -= NudEnhanceWidth_ValueChanged;
            nudEnhanceNum.ValueChanged -= NudEnhanceNum_ValueChanged;
            nudLowThreshold.ValueChanged -= NudLowThreshold_ValueChanged;
            nudHighThreshold.ValueChanged -= NudHighThreshold_ValueChanged;
            nudrectHeight.ValueChanged -= NudrectHeight_ValueChanged;
            nudrectWidth.ValueChanged -= NudrectWidth_ValueChanged;

            cbxMethods.SelectedIndexChanged -= CbxMethods_SelectedIndexChanged;
            cebxIsSurfaceFlaw.CheckedChanged -= cebxIsSurfaceFlaw_CheckedChanged;
            cbxSetdraw.TextChanged -= cbxSetdraw_SelectedIndexChanged;
        }
        void Register()
        {
            nudMaskHeight.ValueChanged += nudMaskHeight_ValueChanged;
            nudMaskHeight.ValueChanged += nudMaskWidth_ValueChanged; ;
            nudEnhanceHeight.ValueChanged += nudEnhanceHeight_ValueChanged;
            nudEnhanceWidth.ValueChanged += NudEnhanceWidth_ValueChanged;
            nudEnhanceNum.ValueChanged += NudEnhanceNum_ValueChanged;
            nudLowThreshold.ValueChanged += NudLowThreshold_ValueChanged;
            nudHighThreshold.ValueChanged += NudHighThreshold_ValueChanged;
            nudrectHeight.ValueChanged += NudrectHeight_ValueChanged;
            nudrectWidth.ValueChanged += NudrectWidth_ValueChanged;

            cbxMethods.SelectedIndexChanged += CbxMethods_SelectedIndexChanged;
            cebxIsSurfaceFlaw.CheckedChanged += cebxIsSurfaceFlaw_CheckedChanged;
            cbxSetdraw.TextChanged += cbxSetdraw_SelectedIndexChanged;

        }

        private void CbxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.Methods = cbxMethods.Text;
            surfaceBreachTool.set_after();
        }

        private void NudrectWidth_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.rect_width =Convert.ToInt32( nudrectWidth.Value);
            surfaceBreachTool.set_after();
        }

        private void NudrectHeight_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.rect_height = Convert.ToInt32(nudrectHeight.Value);
            surfaceBreachTool.set_after();
        }

        private void NudHighThreshold_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.high_Threshold = Convert.ToInt32(nudHighThreshold.Value);
            surfaceBreachTool.set_after();
        }

        private void NudLowThreshold_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.low_Threshold = Convert.ToInt32(nudLowThreshold.Value);
            surfaceBreachTool.set_after();
        }

        private void NudEnhanceNum_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.enhance_num = Convert.ToInt32(nudEnhanceNum.Value);
            surfaceBreachTool.set_after();
        }

        private void NudEnhanceWidth_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.enhance_width = Convert.ToInt32(nudEnhanceWidth.Value);
            surfaceBreachTool.set_after();
        }

        private void nudEnhanceHeight_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.enhance_height = Convert.ToInt32(nudEnhanceHeight.Value);
            surfaceBreachTool.set_after();
        }

        private void cbxSetdraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.Setdraw = cbxSetdraw.Text;
            surfaceBreachTool.set_after();
        }

        private void cebxIsSurfaceFlaw_CheckedChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.IsFlaw = cebxIsSurfaceFlaw.Checked;
            surfaceBreachTool.set_after();
        }

        private void nudMaskWidth_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.etch_width = (int)nudMaskWidth.Value;
            surfaceBreachTool.set_after();
        }

        private void nudMaskHeight_ValueChanged(object sender, EventArgs e)
        {
            surfaceBreachTool.etch_height = (int)nudMaskHeight.Value;
            surfaceBreachTool.set_after();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long timer = surfaceBreachTool.set_after();
            halconView1.ToolLable2.Text = "FAIL";
            halconView1.ToolLable2.ForeColor = Color.Red;
            if (this.surfaceBreachTool.ResultLogic)
            {
                halconView1.ToolLable2.Text = "PASS";
                halconView1.ToolLable2.ForeColor = Color.Lime;
            }
            lblTimer.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
            halconView1.ToolLable3.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetVal(ref this.surfaceBreachTool);
                this.Hide();
                frm = null;
                handleSetval(this.surfaceBreachTool);
            }
            catch
            {
                this.Hide();
                frm = null;
                handleSetval(this.surfaceBreachTool);
            }
        }

        private void frm_SurfaceBreach_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormClosing += frm_SurfaceBreach_FormClosing;
            halconView1.HMouseWheelEvent += halconView1_HMouseWheelEvent;
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "blue");
            this.surfaceBreachTool.WindowControl = halconView1.HWindowControl;
            this.CenterToScreen();
        }

        private void halconView1_HMouseWheelEvent(object sender)
        {
            surfaceBreachTool.dispresult();
        }

        private void frm_SurfaceBreach_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = null;
        }

        private void btnSearchRoi_Click(object sender, EventArgs e)
        {
            if (ceboxSeath.Checked)
            {
                halconView1.ContextMenuStripHide();
                halconView1.Focus();
                this.surfaceBreachTool.drawSearchRoi();
            }
            else
            {
                MessageBox.Show("请先勾选使用区域!");
            }
        }

        private void ceboxSeath_CheckedChanged(object sender, EventArgs e)
        {
            this.surfaceBreachTool.IsSearchRegion = ceboxSeath.Checked;
        }
    }
}
