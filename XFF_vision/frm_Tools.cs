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
using HalconDotNet;
using WeifenLuo.WinFormsUI.Docking;

namespace XFF_Vision
{
    public partial class frm_Tools : DockContent
    {
        List<ImageTool> tool = new List<ImageTool>();
        public delegate void SelcetDelegate(string type);
        public static event SelcetDelegate SelcetToolEvent;
        private static frm_Tools _instance;
        public static frm_Tools Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frm_Tools();
                return _instance;
            }

        }

        public frm_Tools()
        {
            InitializeComponent();
        }

        private void frm_Tools_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.CenterToParent();
            this.tvwTools.ImageList = this.imageList1;
            try
            {
                #region 图像处理
                TreeNode imageAcaquisitionNode = tvwTools.Nodes.Add("", "图像处理", 0, 0);
                {
                    imageAcaquisitionNode.Nodes.Add("", ImageTool.Tool.采集图像.ToString(), 2, 2);
                    imageAcaquisitionNode.Nodes.Add("", ImageTool.Tool.存储图像.ToString(), 3, 3);
                    TreeNode preconceptionNode = imageAcaquisitionNode.Nodes.Add("", "预处理图像", 0, 0);
                    {
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.增强图像.ToString(), 12, 12);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.平滑图像.ToString(), 13, 13);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.性线收缩图像.ToString(), 31, 31);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.均值滤波图像.ToString(), 13, 13);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.中值滤波图像.ToString(), 13, 13);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.顶帽处理图像.ToString(), 13, 13);
                        //preconceptionNode.Nodes.Add("", ImageTool.Tool.投影图像.ToString(), 9, 9);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.旋转图像.ToString(), 26, 26);
                        //preconceptionNode.Nodes.Add("", ImageTool.Tool.极坐标变换图像.ToString(), 32, 32);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.取反图像.ToString(), 13, 13);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.补正图像.ToString(), 26, 26);
                        preconceptionNode.Nodes.Add("", ImageTool.Tool.彩色转HSV图像.ToString(), 11, 11);

                    }
                }
                #endregion
                #region 图像定位
                TreeNode imageFixPosition = tvwTools.Nodes.Add("", "匹配定位", 0, 0);
                {
                    imageFixPosition.Nodes.Add("", ImageTool.Tool.形状模板匹配.ToString(), 5, 5);
                    
                    imageFixPosition.Nodes.Add("", ImageTool.Tool.位置定位.ToString(), 6, 6);

                    imageFixPosition.Nodes.Add("", ImageTool.Tool.NCC匹配.ToString(), 7, 7);
                }
                #endregion
                #region 图像标定
                TreeNode imageCalibration = tvwTools.Nodes.Add("", "图像坐标变换标定", 0, 0);
                {
                    imageCalibration.Nodes.Add("", ImageTool.Tool.九点标定.ToString(), 7, 7);
                }
                #endregion
                #region 阈值分割统计
                TreeNode imageThreshold = tvwTools.Nodes.Add("", "斑点检测", 0, 0);
                {
                    imageThreshold.Nodes.Add("", ImageTool.Tool.斑点分析.ToString(), 30, 30);
                }
                #endregion
                #region 测量
                TreeNode imageMesuer = tvwTools.Nodes.Add("", "测量", 0, 0);
                {
                    imageMesuer.Nodes.Add("", ImageTool.Tool.卡尺测量.ToString(), 16, 16);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.找线测量.ToString(), 19, 19);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.找边测量.ToString(), 19, 19);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.找圆测量.ToString(), 18, 18);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.找方向矩形测量.ToString(), 15, 15);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.找顶点测量.ToString(), 29, 29);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.点到点测量.ToString(), 21, 21);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.点到线测量.ToString(), 20, 20);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.水平夹角测量.ToString(), 14, 14);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.两线交点测量.ToString(), 14, 14);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.两线间距测量.ToString(), 22, 22);
                    imageMesuer.Nodes.Add("", ImageTool.Tool.两线夹角测量.ToString(), 14, 14);

                }
                #endregion
                #region 图像检测
                // TreeNode imageTest = tvwTools.Nodes.Add("", "图像识别检测", 0, 0);
                //{

                //    imageTest.Nodes.Add("", ImageTool.Tool.二维码识别.ToString(), 23,23);
                //    imageTest.Nodes.Add("", ImageTool.Tool.条形码识别.ToString(), 24, 24);
                //    imageTest.Nodes.Add("", ImageTool.Tool.字符识别检测.ToString(), 25, 25);
                //    imageTest.Nodes.Add("", ImageTool.Tool.颜色抽取检测.ToString(), 10, 10);

                //}

                TreeNode imageSurfaceTest = tvwTools.Nodes.Add("", "图像外观检测", 0, 0);
                {
                    //  imageSurfaceTest.Nodes.Add("", ImageTool.Tool.划痕提取检测.ToString(), 1, 1);
                    // imageSurfaceTest.Nodes.Add("", ImageTool.Tool.瑕疵提取检测.ToString(), 1, 1);
                    imageSurfaceTest.Nodes.Add("", ImageTool.Tool.脏污提取检测.ToString(), 1, 1);
                    imageSurfaceTest.Nodes.Add("", ImageTool.Tool.差异比较检测.ToString(), 1, 1);
                    imageSurfaceTest.Nodes.Add("", ImageTool.Tool.表面缺口检测.ToString(), 1, 1);
                    imageSurfaceTest.Nodes.Add("", ImageTool.Tool.网格线检测.ToString(), 1, 1);
                    //    imageSurfaceTest.Nodes.Add("", ImageTool.Tool.焊点检测.ToString(), 1, 1);

                }
                #endregion
                #region 图像区域形态处理
                TreeNode imageMorphology = tvwTools.Nodes.Add("", "图像形态处理", 0, 0);
                {
                    imageMorphology.Nodes.Add("", ImageTool.Tool.区域形态处理.ToString(), 28, 28);
                }
                #endregion
                #region 图像脚本
                TreeNode imageScript = tvwTools.Nodes.Add("", "图像视觉脚本", 0, 0);
                {
                    imageScript.Nodes.Add("", ImageTool.Tool.视觉脚本.ToString(), 1, 1);
                    //imageScript.Nodes.Add("", ImageTool.Tool.Yolo训练.ToString(), 2, 2);
                }
                #endregion
                #region 增加的流程
                TreeNode deepLearn = tvwTools.Nodes.Add("", "基于原版增加", 0, 0);
                {
                    //deepLearn.Nodes.Add("", ImageTool.Tool.视觉脚本.ToString(), 1, 1);
                    deepLearn.Nodes.Add("", ImageTool.Tool.Yolo训练.ToString(), 1, 1);
                }
                #endregion

            }
            catch
            {
            }
        }



        private void tvw_jobs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string type = tvwTools.SelectedNode.Text;
                SelcetToolEvent(type);
            }
            catch (Exception ex)
            {
            }
        }
        private void frm_Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }
        private void 展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvwTools.ExpandAll();
            tvwTools.SelectedNode = tvwTools.Nodes[0].Nodes[0];
            tvwTools.AutoScrollOffset = new System.Drawing.Point(0, 0);
        }

        private void 折叠所有节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvwTools.CollapseAll();
        }
    }
}
