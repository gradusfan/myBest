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
    public partial class frm_GridLine : Form
    {
        static frm_GridLine frm;
        GridLineTool gridLineTool = new GridLineTool();
        public delegate void HandledSetVal(GridLineTool gridLinTool);
        HandledSetVal handleSetval;
        public frm_GridLine()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单实例
        /// </summary>
        /// <param name="fb"></param>
        public static frm_GridLine SingleShow(GridLineTool gridLineTool, HandledSetVal handleSetval)
        {
            if (frm == null)//
            {
                frm = new frm_GridLine(gridLineTool, handleSetval);
            }
            return frm;
        }

        private void frm_GridLine_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormClosing += frm_GridLine_FormClosing;
            halconView1.HMouseWheelEvent += halconView1_HMouseWheelEvent;
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "blue");
            this.gridLineTool.WindowControl = halconView1.HWindowControl;
            this.CenterToScreen();
        }
        public frm_GridLine(GridLineTool gridLineTool, HandledSetVal handleSetval)
        {
            InitializeComponent();
            this.handleSetval = handleSetval;
            DisplayVal(gridLineTool);
            this.gridLineTool.Image = gridLineTool.Image;
            this.gridLineTool.rect_sX = gridLineTool.rect_sX;
            this.gridLineTool.rect_sY = gridLineTool.rect_sY;
            this.gridLineTool.rect_eX = gridLineTool.rect_eX;
            this.gridLineTool.rect_eY = gridLineTool.rect_eY;
            this.SetVal(ref this.gridLineTool);
        }

        void DisplayVal(GridLineTool gridLineTool)
        {
            try
            {
                Cancel();//注销事件
                int nameIndex = gridLineTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = gridLineTool.Names.Substring(nameIndex + 1, gridLineTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;
                }
                else
                {
                    this.Text = gridLineTool.Names;
                    tbxToolName.Text = gridLineTool.Names;
                }
                cbxImage.Text = gridLineTool.ImageName;

                nudLowthreshold.Value = gridLineTool.LowThreshold.I;
                nudHighthreshold.Value = gridLineTool.Highthreshold.I;

                nudMinArea1.Value = gridLineTool.MinArea1.I;
                nudMaxArea1.Value = gridLineTool.MaxArea1.I;
                nudMinWidth1.Value = gridLineTool.MinWidth1.I;
                nudMaxWidth1.Value = gridLineTool.MaxWidth1.I;

                nudMinArea2.Value = gridLineTool.MinArea2.I;
                nudMaxArea2.Value = gridLineTool.MaxArea2.I;
                nudMinWidth2.Value = gridLineTool.MinWidth2.I;
                nudMaxWidth2.Value = gridLineTool.MaxWidth2.I;

                nudMinArea3.Value = gridLineTool.MinArea3.I;
                nudMaxArea3.Value = gridLineTool.MaxArea3.I;
                nudMinWidth3.Value = gridLineTool.MinWidth3.I;
                nudMaxWidth3.Value = gridLineTool.MaxWidth3.I;
                nudMaxHeight3.Value = gridLineTool.MaxHeight3.I;
                nudMinHeight3.Value = gridLineTool.MinHeight3.I;

                nudMinArea.Value = gridLineTool.StrangeMinArea.I;
                nudMaxArea.Value = gridLineTool.StrangeMaxArea.I;

                cebxIsSurfaceFlaw.Checked = gridLineTool.IsFlaw;
                cbxSetdraw.Text = gridLineTool.Setdraw;
                ceboxSeath.Checked = gridLineTool.IsSearchRegion;

                cbxImage.Items.Clear();
                if (gridLineTool.Image != null)
                {
                    foreach (var item in gridLineTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)gridLineTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
            }
            catch (Exception ex)
            {
                cbxImage.Items.Clear();
                if (gridLineTool.Image != null)
                {
                    foreach (var item in gridLineTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)gridLineTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
            }
            Register();//注册事件
        }

        void SetVal(ref GridLineTool gridLineTool)
        {
            gridLineTool.ImageName = cbxImage.Text;
            gridLineTool.Names = ImageTool.Tool.网格线检测.ToString() + "_" + tbxToolName.Text;

            gridLineTool.LowThreshold = Convert.ToInt32(nudLowthreshold.Value);
            gridLineTool.Highthreshold = Convert.ToInt32(nudHighthreshold.Value);

            gridLineTool.MinArea1 = Convert.ToInt32(nudMinArea1.Value);
            gridLineTool.MaxArea1 = Convert.ToInt32(nudMaxArea1.Value);
            gridLineTool.MinWidth1 = Convert.ToInt32(nudMinWidth1.Value);
            gridLineTool.MaxWidth1 = Convert.ToInt32(nudMaxWidth1.Value);

            gridLineTool.MinArea2 = Convert.ToInt32(nudMinArea2.Value);
            gridLineTool.MaxArea2 = Convert.ToInt32(nudMaxArea2.Value);
            gridLineTool.MinWidth2 = Convert.ToInt32(nudMinWidth2.Value);
            gridLineTool.MaxWidth2 = Convert.ToInt32(nudMaxWidth2.Value);

            gridLineTool.MinArea3 = Convert.ToInt32(nudMinArea3.Value);
            gridLineTool.MaxArea3 = Convert.ToInt32(nudMaxArea3.Value);
            gridLineTool.MinWidth3 = Convert.ToInt32(nudMinWidth3.Value);
            gridLineTool.MaxWidth3 = Convert.ToInt32(nudMaxWidth3.Value);
            gridLineTool.MaxHeight3 = Convert.ToInt32(nudMaxHeight3.Value);
            gridLineTool.MinHeight3 = Convert.ToInt32(nudMinHeight3.Value);

            gridLineTool.StrangeMinArea = Convert.ToInt32(nudMinArea.Value);
            gridLineTool.StrangeMaxArea = Convert.ToInt32(nudMaxArea.Value);

            gridLineTool.IsFlaw = cebxIsSurfaceFlaw.Checked;
            gridLineTool.Setdraw = cbxSetdraw.Text;
            gridLineTool.IsSearchRegion = ceboxSeath.Checked;
        }

        void Cancel()
        {
            nudLowthreshold.ValueChanged -= new EventHandler(nudLowthreshold_ValueChanged);
            nudHighthreshold.ValueChanged -= new EventHandler(nudHighthreshold_ValueChanged);

            nudMinArea1.ValueChanged -= new EventHandler(nudMinArea1_ValueChanged);
            nudMaxArea1.ValueChanged -= new EventHandler(nudMaxArea1_ValueChanged);
            nudMinWidth1.ValueChanged -= new EventHandler(nudMinWidth1_ValueChanged);
            nudMaxWidth1.ValueChanged -= new EventHandler(nudMaxWidth1_ValueChanged);

            nudMinArea2.ValueChanged -= new EventHandler(nudMinArea2_ValueChanged);
            nudMaxArea2.ValueChanged -= new EventHandler(nudMaxArea2_ValueChanged);
            nudMinWidth2.ValueChanged -= new EventHandler(nudMinWidth2_ValueChanged);
            nudMaxWidth2.ValueChanged -= new EventHandler(nudMaxWidth2_ValueChanged);

            nudMinArea3.ValueChanged -= new EventHandler(nudMinArea3_ValueChanged);
            nudMaxArea3.ValueChanged -= new EventHandler(nudMaxArea3_ValueChanged);
            nudMinWidth3.ValueChanged -= new EventHandler(nudMinWidth3_ValueChanged);
            nudMaxWidth3.ValueChanged -= new EventHandler(nudMaxWidth3_ValueChanged);
            nudMaxHeight3.ValueChanged -= new EventHandler(nudMaxHeight3_ValueChanged);
            nudMinHeight3.ValueChanged -= new EventHandler(nudMinHeight3_ValueChanged);

            nudMinArea.ValueChanged -= new EventHandler(nudMinArea_ValueChanged);
            nudMaxArea.ValueChanged -= new EventHandler(nudMaxArea_ValueChanged);

            cebxIsSurfaceFlaw.CheckedChanged -= new EventHandler(cebxIsSurfaceFlaw_CheckedChanged);
            cbxSetdraw.TextChanged -= new EventHandler(cbxSetdraw_SelectedIndexChanged);
        }
        void Register()
        {
            nudLowthreshold.ValueChanged += new EventHandler(nudLowthreshold_ValueChanged);
            nudHighthreshold.ValueChanged += new EventHandler(nudHighthreshold_ValueChanged);

            nudMinArea1.ValueChanged += new EventHandler(nudMinArea1_ValueChanged);
            nudMaxArea1.ValueChanged += new EventHandler(nudMaxArea1_ValueChanged);
            nudMinWidth1.ValueChanged += new EventHandler(nudMinWidth1_ValueChanged);
            nudMaxWidth1.ValueChanged += new EventHandler(nudMaxWidth1_ValueChanged);

            nudMinArea2.ValueChanged += new EventHandler(nudMinArea2_ValueChanged);
            nudMaxArea2.ValueChanged += new EventHandler(nudMaxArea2_ValueChanged);
            nudMinWidth2.ValueChanged += new EventHandler(nudMinWidth2_ValueChanged);
            nudMaxWidth2.ValueChanged += new EventHandler(nudMaxWidth2_ValueChanged);

            nudMinArea3.ValueChanged += new EventHandler(nudMinArea3_ValueChanged);
            nudMaxArea3.ValueChanged += new EventHandler(nudMaxArea3_ValueChanged);
            nudMinWidth3.ValueChanged += new EventHandler(nudMinWidth3_ValueChanged);
            nudMaxWidth3.ValueChanged += new EventHandler(nudMaxWidth3_ValueChanged);
            nudMaxHeight3.ValueChanged += new EventHandler(nudMaxHeight3_ValueChanged);
            nudMinHeight3.ValueChanged += new EventHandler(nudMinHeight3_ValueChanged);

            nudMinArea.ValueChanged += new EventHandler(nudMinArea_ValueChanged);
            nudMaxArea.ValueChanged += new EventHandler(nudMaxArea_ValueChanged);

            cebxIsSurfaceFlaw.CheckedChanged += new EventHandler(cebxIsSurfaceFlaw_CheckedChanged);
            cbxSetdraw.TextChanged += new EventHandler(cbxSetdraw_SelectedIndexChanged);

        }

        private void nudMaxArea_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.StrangeMaxArea = Convert.ToInt32(nudMaxArea.Value);
            gridLineTool.set_after();
        }

        private void nudMinArea_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.StrangeMinArea = Convert.ToInt32(nudMinArea.Value);
            gridLineTool.set_after();
        }

        private void nudMinHeight3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinHeight3 = Convert.ToInt32(nudMinHeight3.Value);
            gridLineTool.set_after();
        }

        private void nudMaxHeight3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxHeight3 = Convert.ToInt32(nudMaxHeight3.Value);
            gridLineTool.set_after();
        }

        private void nudMaxWidth3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxWidth3 = Convert.ToInt32(nudMaxWidth3.Value);
            gridLineTool.set_after();
        }

        private void nudMinWidth3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinWidth3 = Convert.ToInt32(nudMinWidth3.Value);
            gridLineTool.set_after();
        }

        private void nudMinArea3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinArea3 = Convert.ToInt32(nudMinArea3.Value);
            gridLineTool.set_after();
        }

        private void nudMaxArea3_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxArea3 = Convert.ToInt32(nudMaxArea3.Value);
            gridLineTool.set_after();
        }

        private void nudMinWidth2_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinWidth2 = Convert.ToInt32(nudMinWidth2.Value);
            gridLineTool.set_after();
        }

        private void nudMaxWidth2_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxWidth2 = Convert.ToInt32(nudMaxWidth2.Value);
            gridLineTool.set_after();
        }

        private void nudMaxArea2_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxArea2 = Convert.ToInt32(nudMaxArea2.Value);
            gridLineTool.set_after();
        }

        private void nudMinArea2_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinArea2 = Convert.ToInt32(nudMinArea2.Value);
            gridLineTool.set_after();
        }

        private void nudMaxWidth1_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxWidth1 = Convert.ToInt32(nudMaxWidth1.Value);
            gridLineTool.set_after();
        }

        private void nudMinWidth1_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinWidth1 = Convert.ToInt32(nudMinWidth1.Value);
            gridLineTool.set_after();
        }

        private void nudMaxArea1_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MaxArea1 = Convert.ToInt32(nudMaxArea1.Value);
            gridLineTool.set_after();
        }

        private void nudMinArea1_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.MinArea1 = Convert.ToInt32(nudMinArea1.Value);
            gridLineTool.set_after();
        }

        private void nudHighthreshold_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.Highthreshold = Convert.ToInt32(nudHighthreshold.Value);
            gridLineTool.set_after();
        }

        private void nudLowthreshold_ValueChanged(object sender, EventArgs e)
        {
            gridLineTool.LowThreshold = Convert.ToInt32(nudLowthreshold.Value);
            gridLineTool.set_after();
        }


        private void cbxSetdraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridLineTool.Setdraw = cbxSetdraw.Text;
            gridLineTool.set_after();
        }

        private void cebxIsSurfaceFlaw_CheckedChanged(object sender, EventArgs e)
        {
            gridLineTool.IsFlaw = cebxIsSurfaceFlaw.Checked;
            gridLineTool.set_after();
        }

        private void frm_GridLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = null;
        }

        private void halconView1_HMouseWheelEvent(object sender)
        {
            gridLineTool.dispresult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long timer = gridLineTool.set_after();
            halconView1.ToolLable2.Text = "FAIL";
            halconView1.ToolLable2.ForeColor = Color.Red;
            if (this.gridLineTool.ResultLogic)
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
                this.SetVal(ref this.gridLineTool);
                this.Hide();
                frm = null;
                handleSetval(this.gridLineTool);
            }
            catch
            {
                this.Hide();
                frm = null;
                handleSetval(this.gridLineTool);
            }
        }

        private void btnSearchRoi_Click(object sender, EventArgs e)
        {
            if (ceboxSeath.Checked)
            {
                halconView1.ContextMenuStripHide();
                halconView1.Focus();
                gridLineTool.drawSearchRoi();
            }
            else
            {
                MessageBox.Show("请先勾选使用区域!");
            }
        }

        private void ceboxSeath_CheckedChanged(object sender, EventArgs e)
        {
            gridLineTool.IsSearchRegion = ceboxSeath.Checked;
        }
    }
}
