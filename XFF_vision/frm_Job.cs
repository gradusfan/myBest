using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;
using WeifenLuo.WinFormsUI.Docking;
using XFF_vision.frm_Tool;
using XFF_Vision.BLL;
using XFF_Vision.frm_Tool;

namespace XFF_Vision
{
    public partial class frm_Job : DockContent
    {
        #region 声名工具

        BlobTool blobTool;
        AcqFifoTool acqFifoTool;
        PMAlignTool pmalignTool;
        FixtureTool fixtureTool;
        FitCircleTool fitCircleTool;
        FitLineTool fitLineTool;
        FindEdgeTool findEdgeTool;
        FindRectangle2Tool findRectangle2Tool;
        DistancePointPointTool distancePpTool;
        DistancePointLineTool distancePlTool;
        DistanceLineLineTool distanceLlTool;
        DistanceAnglePointPointTool distanceAPpTool;
        DistanceAngleLineLineTool distanceALlTool;
        IntersectionLinesTool intersectionLinesTool;
        OCRMaxTool ocrMaxTool;
        CaliperTool caliperTool;
        _2DSymbolTool _2dSymbolTool;
        BarcodeTool barcodeTool;
        FindCornerTool findCornerTool;
        ScaleImageTool scaleImageTool;
        SmoothImageTool smoothImageTool;
        MeanImageTool meanImageTool;
        MedianImageTool medianImageTool;
        EmphasizeImageTool emphasizeImage;
        InvertImageTool invertImageTool;
        ProjectiveTransImageTool projectiveTransImageTool;
        TransPolarTool transPolarTool;
        RotateImageTool rotateImageTool;
        ImageConvertTool imageConvertTool;
        PatInspectTool patInspectTool;
        SerialPortTool serialPortTool;
        AffineTransImageTool affineTransImageTool;
        DetectScratchesTool detectScratchesTool;
        SurfaceStainsTool surfaceStainsTool;
        SurfaceFlawTool surfaceFlawTool;
        _9PointCalibTool _9pointCalibTool;
        SaveImageTool saveImageTool;
        ColorExtractorTool colorExtractorTool;
        InspectionBallBondingTool inspectionBallBonding;
        HalconScriptTool halconScriptTool;
        MorphologyTool morphologyTool;
        GrayTophatTool grayTophatTool;

        RoiCreateTool roiCreate;
        SurfaceBreachTool surfaceBreachTool;
        GridLineTool gridLineTool;


        RoiOpUnionTool roiOpUnionTool;
        CalibrationTool calibrationTool;
        //RoiOpIntersectionTool roiOpIntersectionTool;
        //RoiOpDifferenceTool roiOpDifferenceTool;
        //RoiOpXorTool roiOpXorTool; 

        private Color RowBackColorAlt = Color.FromArgb(185, 210, 234);//交替色
        private Color RowBackColorSel = Color.FromArgb(106, 197, 242);//选中项目颜色
        public HTuple acqHandle1;
        public HTuple AcqHandle
        {
            get { return acqHandle1; }
            set { acqHandle1 = value; }
        }

        #endregion
        public List<ImageTool> tool = new List<ImageTool>();
        FlowExecuteDAL flowExecute1 = new FlowExecuteDAL();
        public bool isFlowExecute = false;
        long timer;
        public string toolPath;
        OpenFileDialog ReadSet = new OpenFileDialog();
        SaveFileDialog SaveSet = new SaveFileDialog();
        string noodePath = "";
        // HTuple acqHandle1;
        HWindowControl windowControl;
        /// <summary>
        /// 对象实例
        /// </summary>
        private static frm_Job _instance;
        public static frm_Job Instance
        {
            get
            {

                if (_instance == null || _instance.IsDisposed)
                    _instance = new frm_Job();
                return _instance;
            }
        }
        public frm_Job()
        {
            InitializeComponent();
            windowControl = frm_ImageWindow.Instance.halconView1.HWindowControl;
            frm_Tools.SelcetToolEvent += Frm_Tools_SelcetToolEvent;
            frm_Example.SelcetToolEvent += Frm_Example_SelcetToolEvent;
        }
        private void Frm_Tools_SelcetToolEvent(string type)
        {
            addTool(type);
        }

        private void Frm_Example_SelcetToolEvent(string path)
        {
            if (ReadFile(path))
                recon(tool);
        }
        private void frm_Job_Load(object sender, EventArgs e)
        {

        }

        public void setVal(ImageTool it)
        {
            try
            {
                int index = listView1.SelectedItems[0].Index;//选中一行集合索引
                if (it is AcqFifoTool)
                {
                    tool[index] = it;
                    tool[index].WindowControl = windowControl;
                    AcqFifoTool acq = it as AcqFifoTool;
                    if (acq.WindowControl != null && !acq.IsUseImg)
                        ProgramBLL.OpenCamera(tool, ref acqHandle1);//打开相机
                }
                else
                {
                    tool[index] = it;
                    tool[index].WindowControl = windowControl;
                }
                recon(tool);  //跟新工具名
            }
            catch (Exception)
            {


            }


        }
        /// <summary>
        /// 读取配置文件重建
        /// </summary>
        /// <param name="tool"></param>
        public void recon(List<ImageTool> tool)
        {
            this.tool = tool;
            try
            {
                int item = 1;
                listView1.Items.Clear();
                listView1.BeginUpdate();
                foreach (ImageTool it in tool)
                {
                    string[] name = it.toolName().Split(new char[] { '_' });
                    if (it.WindowControl == null)
                        it.WindowControl = windowControl;
                    it.recon();
                    ListViewItem lvItem = listView1.Items.Add(item.ToString());
                    lvItem.SubItems.Add(name[0]);
                    string str = (name.Length < 2) ? name[0] : name[1];
                    lvItem.SubItems.Add(str);
                    lvItem.SubItems.Add(it.toolResult().ToString());
                    lvItem.SubItems.Add(it.toolTimer().ToString() + "ms");//耗时
                    item++;
                }
                listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                listView1.EndUpdate();
                // MessageBox.Show("数据读取失败!", "数据读取失败", MessageBoxButtons.OK, MessageBoxIcon.Warning); listView1.EndUpdate();
            }
        }
        /// <summary>
        /// 更新工具数据
        /// </summary>
        /// <param name="tool"></param>
        public void toolUpdate(List<ImageTool> tool)
        {//将ListView的每一项的UseItemStyleForSubItems属性设置为false
            try
            {
                int item = 1;
                listView1.Items.Clear();
                foreach (ImageTool it in tool)
                {
                    listView1.BeginUpdate();
                    string[] name = it.toolName().Split(new char[] { '_' });
                    if (it.WindowControl == null)
                        it.WindowControl = windowControl;
                    ListViewItem lvItem = listView1.Items.Add(item.ToString());
                    lvItem.UseItemStyleForSubItems = false;//第一行,第一列颜色改变
                    lvItem.SubItems.Add(name[0]);
                    string str = (name.Length < 2) ? name[0] : name[1];
                    lvItem.SubItems.Add(str);
                    lvItem.SubItems.Add(it.toolResult().ToString());
                    lvItem.SubItems.Add(it.toolTimer().ToString() + "ms");//耗时
                    if (!it.toolResult())
                        lvItem.BackColor = Color.Red;
                    else
                        lvItem.BackColor = Color.LightGreen;

                    item++;
                    listView1.EndUpdate();
                }
            }
            catch
            {
                // MessageBox.Show("更新工具数据失败!", "更新工具数据失败", MessageBoxButtons.OK, MessageBoxIcon.Warning); listView1.EndUpdate();
            }

        }
        /// <summary>
        /// 运行
        /// </summary>
        public void run()
        {
            Invoke((EventHandler)(delegate
            {
                isFlowExecute = true;
                ProgramBLL.Run(frm_ImageWindow.Instance.halconView1, ref acqHandle1, tool, flowExecute1, out timer).ToString();
                frm_ImageWindow.Instance.halconView1.ToolLable2.Text = "PASS";
                frm_ImageWindow.Instance.halconView1.ToolLable2.ForeColor = Color.Lime;
                frm_Result.Instance.lblResult.Text = "OK";
                frm_Result.Instance.lblResult.BackColor = Color.Lime;
                //frm_Result.Instance.lblResult.ForeColor = Color.Lime;               
                frm_ImageWindow.Instance.halconView1.ToolLable3.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
                int conut = 0;
                foreach (bool item in flowExecute1.AllResultLogic) //遍历工具结果
                {
                    if (!item)  // 等于false
                    {
                        frm_ImageWindow.Instance.halconView1.ToolLable2.Text = "FAIL";
                        frm_ImageWindow.Instance.halconView1.ToolLable2.ForeColor = Color.Red;
                        frm_Result.Instance.lblResult.Text = "NG";
                        frm_Result.Instance.lblResult.BackColor = Color.Red;
                        frm_Output.Instance.OutputMsg("NG", Color.Red);
                    }
                    else
                    {
                        conut++;
                        if (conut == flowExecute1.AllResultLogic.Count)
                        {
                            //OK代码加io卡
                            frm_Output.Instance.OutputMsg("OK", Color.Green);
                        }
                    }
                }
                frm_ImageWindow.Instance.halconView1.disp_win_cross();
                toolUpdate(tool);
                isFlowExecute = false;
            }));
        }

        /// <summary>
        /// 添加工具到流程中
        /// </summary>
        /// <param name="type"></param>
        public void addTool(string type)
        {
            string s = "1";
            int index = -1;
            //int index = listView1.SelectedItems[0].Index;//选中一行集合索引;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                index = lvItem.Index;
            }
            if (index > 0)
                s = (index + 1).ToString(); //选中一行集合索引;
            else
                s = (tool.Count + 1).ToString();
            if (type == ImageTool.Tool.采集图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                ImageTool imageTool = new AcqFifoTool();

                if (index > 0)
                    EditBLL.Insert(listView1, tool, imageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, imageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.找方向矩形测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                findRectangle2Tool = new FindRectangle2Tool();
                findRectangle2Tool.Image = flowExecute1.CollectiveImage;
                findRectangle2Tool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                findRectangle2Tool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, findRectangle2Tool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, findRectangle2Tool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);

            }
            if (type == ImageTool.Tool.找线测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                fitLineTool = new FitLineTool();
                fitLineTool.Image = flowExecute1.CollectiveImage;
                fitLineTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                fitLineTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, fitLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, fitLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.找边测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                findEdgeTool = new FindEdgeTool();
                findEdgeTool.Image = flowExecute1.CollectiveImage;
                findEdgeTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                findEdgeTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, findEdgeTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, findEdgeTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.找圆测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                fitCircleTool = new FitCircleTool();
                fitCircleTool.Image = flowExecute1.CollectiveImage;
                fitCircleTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                fitCircleTool.DictPhi = flowExecute1.DicFixPhi;

                if (index > 0)
                    EditBLL.Insert(listView1, tool, fitCircleTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, fitCircleTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.水平夹角测量.ToString())
            {
                string[] str = new string[] { s, ImageTool.Tool.找方向矩形测量.ToString(), "", "NG", "0ms" };
                distanceAPpTool = new DistanceAnglePointPointTool();
                distanceAPpTool.Image = flowExecute1.CollectiveImage;
                distanceAPpTool.HtRowLine1 = flowExecute1.DicRow1Line;   //线
                distanceAPpTool.HtColLine1 = flowExecute1.DicCol1Line;   //线
                distanceAPpTool.HtRowLine2 = flowExecute1.DicRow2Line;   //线
                distanceAPpTool.HtColLine2 = flowExecute1.DicCol2Line;   //线
                if (index > 0)
                    EditBLL.Insert(listView1, tool, distanceAPpTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, distanceAPpTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.两线夹角测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                distanceALlTool = new DistanceAngleLineLineTool();
                distanceALlTool.Image = flowExecute1.CollectiveImage;
                distanceALlTool.HtRowLine1 = flowExecute1.DicRow1Line;   //线
                distanceALlTool.HtColLine1 = flowExecute1.DicCol1Line;   //线
                distanceALlTool.HtRowLine2 = flowExecute1.DicRow2Line;   //线
                distanceALlTool.HtColLine2 = flowExecute1.DicCol2Line;   //线
                if (index > 0)
                    EditBLL.Insert(listView1, tool, distanceALlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, distanceALlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.两线间距测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                distanceLlTool = new DistanceLineLineTool();
                distanceLlTool.Image = flowExecute1.CollectiveImage;
                distanceLlTool.HtLine1 = flowExecute1.DicLines;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, distanceLlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, distanceLlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.点到点测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                distancePpTool = new DistancePointPointTool();
                distancePpTool.Image = flowExecute1.CollectiveImage;
                distancePpTool.HtRowPoint = flowExecute1.DicRowPoint;   //   点位
                distancePpTool.HtColPoint = flowExecute1.DicColPoint;   //   点位
                if (index > 0)
                    EditBLL.Insert(listView1, tool, distancePpTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, distancePpTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.点到线测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                distancePlTool = new DistancePointLineTool();
                distancePlTool.Image = flowExecute1.CollectiveImage;
                distancePlTool.HtRowPoint = flowExecute1.DicRowPoint;   //   点位
                distancePlTool.HtColPoint = flowExecute1.DicColPoint;   //   点位

                distancePlTool.HtRowLine1 = flowExecute1.DicRow1Line;   //线
                distancePlTool.HtColLine1 = flowExecute1.DicCol1Line;   //线
                distancePlTool.HtRowLine2 = flowExecute1.DicRow2Line;   //线
                distancePlTool.HtColLine2 = flowExecute1.DicCol2Line;   //线
                if (index > 0)
                    EditBLL.Insert(listView1, tool, distancePlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, distancePlTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.两线交点测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                intersectionLinesTool = new IntersectionLinesTool();
                intersectionLinesTool.Image = flowExecute1.CollectiveImage;
                intersectionLinesTool.HtRowLine1 = flowExecute1.DicRow1Line;   //线
                intersectionLinesTool.HtColLine1 = flowExecute1.DicCol1Line;   //线
                intersectionLinesTool.HtRowLine2 = flowExecute1.DicRow2Line;   //线
                intersectionLinesTool.HtColLine2 = flowExecute1.DicCol2Line;   //线
                if (index > 0)
                    EditBLL.Insert(listView1, tool, intersectionLinesTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, intersectionLinesTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.形状模板匹配.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                pmalignTool = new PMAlignTool();
                pmalignTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, pmalignTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, pmalignTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.卡尺测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                caliperTool = new CaliperTool();
                caliperTool.Image = flowExecute1.CollectiveImage;
                caliperTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                caliperTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, caliperTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, caliperTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.二维码识别.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                _2dSymbolTool = new _2DSymbolTool();
                _2dSymbolTool.Image = flowExecute1.CollectiveImage;
                _2dSymbolTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                _2dSymbolTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, _2dSymbolTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, _2dSymbolTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.条形码识别.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                barcodeTool = new BarcodeTool();
                barcodeTool.Image = flowExecute1.CollectiveImage;
                barcodeTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                barcodeTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, barcodeTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, barcodeTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.斑点分析.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                blobTool = new BlobTool();
                blobTool.Image = flowExecute1.CollectiveImage;
                blobTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                blobTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, blobTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, blobTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.字符识别检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                ocrMaxTool = new OCRMaxTool();
                ocrMaxTool.Image = flowExecute1.CollectiveImage;
                ocrMaxTool.Region = flowExecute1.CollectiveRegion;
                ocrMaxTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                ocrMaxTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, ocrMaxTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, ocrMaxTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.位置定位.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                fixtureTool = new FixtureTool();
                fixtureTool.HtRow = flowExecute1.DicMRow;
                fixtureTool.HtCol = flowExecute1.DicMCol;
                fixtureTool.HtPhi = flowExecute1.DicMPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, fixtureTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, fixtureTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.找顶点测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                findCornerTool = new FindCornerTool();
                findCornerTool.Image = flowExecute1.CollectiveImage;
                findCornerTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                findCornerTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, findCornerTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, findCornerTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.性线收缩图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                scaleImageTool = new ScaleImageTool();
                scaleImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, scaleImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, scaleImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.平滑图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                smoothImageTool = new SmoothImageTool();
                smoothImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, smoothImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, smoothImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.均值滤波图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                meanImageTool = new MeanImageTool();
                meanImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, meanImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, meanImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.中值滤波图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                medianImageTool = new MedianImageTool();
                medianImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, medianImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, medianImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.增强图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                emphasizeImage = new EmphasizeImageTool();
                emphasizeImage.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, emphasizeImage, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, emphasizeImage, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.取反图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                invertImageTool = new InvertImageTool();
                invertImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, invertImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, invertImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.投影图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                projectiveTransImageTool = new ProjectiveTransImageTool();
                projectiveTransImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, projectiveTransImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, projectiveTransImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.极坐标变换图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                transPolarTool = new TransPolarTool();
                transPolarTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, transPolarTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, transPolarTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.彩色转HSV图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                imageConvertTool = new ImageConvertTool();
                imageConvertTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, imageConvertTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, imageConvertTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.差异比较检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                patInspectTool = new PatInspectTool();
                patInspectTool.Image = flowExecute1.CollectiveImage;
                patInspectTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                patInspectTool.DicHomMat2D1 = flowExecute1.DicFixHomMat2D1;
                patInspectTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, patInspectTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, patInspectTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.划痕提取检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                detectScratchesTool = new DetectScratchesTool();
                detectScratchesTool.Image = flowExecute1.CollectiveImage;
                detectScratchesTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                EditBLL.Add(listView1, tool, detectScratchesTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.脏污提取检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                surfaceStainsTool = new SurfaceStainsTool();
                surfaceStainsTool.Image = flowExecute1.CollectiveImage;
                surfaceStainsTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, surfaceStainsTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, surfaceStainsTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.瑕疵提取检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                surfaceFlawTool = new SurfaceFlawTool();
                surfaceFlawTool.Image = flowExecute1.CollectiveImage;
                surfaceFlawTool.HtHomMat2D = flowExecute1.DicFixHomMat2D;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, surfaceFlawTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, surfaceFlawTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.焊点检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                inspectionBallBonding = new InspectionBallBondingTool();
                inspectionBallBonding.Image = flowExecute1.CollectiveImage;
                inspectionBallBonding.HtHomMat2D = flowExecute1.DicFixHomMat2D;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, inspectionBallBonding, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, inspectionBallBonding, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.九点标定.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                _9pointCalibTool = new _9PointCalibTool();
                _9pointCalibTool.Image = flowExecute1.CollectiveImage;
                _9pointCalibTool.HtRow = flowExecute1.DicMRow;
                _9pointCalibTool.HtCol = flowExecute1.DicMCol;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, _9pointCalibTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, _9pointCalibTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.区域形态处理.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                morphologyTool = new MorphologyTool();
                morphologyTool.Image = flowExecute1.CollectiveImage;
                morphologyTool.Region = flowExecute1.CollectiveRegion;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, morphologyTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, morphologyTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.补正图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                affineTransImageTool = new AffineTransImageTool();
                affineTransImageTool.Image = flowExecute1.CollectiveImage;
                affineTransImageTool.HtHomMat2D = flowExecute1.DicFixHomMat2D;
                affineTransImageTool.HtHomMat2D1 = flowExecute1.DicFixHomMat2D1;
                affineTransImageTool.HtPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, affineTransImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, affineTransImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.旋转图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                rotateImageTool = new RotateImageTool();
                rotateImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, rotateImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, rotateImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.存储图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                saveImageTool = new SaveImageTool();
                saveImageTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, saveImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, saveImageTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.颜色抽取检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                colorExtractorTool = new ColorExtractorTool();
                colorExtractorTool.Image = flowExecute1.CollectiveImage;
                colorExtractorTool.DicHomMat2D = flowExecute1.DicFixHomMat2D;
                colorExtractorTool.DicPhi = flowExecute1.DicFixPhi;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, colorExtractorTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, colorExtractorTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.视觉脚本.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                halconScriptTool = new HalconScriptTool();
                halconScriptTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, halconScriptTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, halconScriptTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.顶帽处理图像.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                grayTophatTool = new GrayTophatTool();
                grayTophatTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, grayTophatTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, grayTophatTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.串口设置.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                serialPortTool = new SerialPortTool();
                // serialPortTool.SerialPort1 = serialPort1;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, serialPortTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, serialPortTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.区域创建.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                roiCreate = new RoiCreateTool();
                roiCreate.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, roiCreate, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, roiCreate, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.区域合并.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                roiOpUnionTool = new RoiOpUnionTool();
                roiOpUnionTool.Image = flowExecute1.CollectiveImage;
                roiOpUnionTool.Region = flowExecute1.CollectiveRegion;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, roiOpUnionTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, roiOpUnionTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.两线交点测量.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                intersectionLinesTool = new IntersectionLinesTool();
                intersectionLinesTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, intersectionLinesTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, intersectionLinesTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.表面缺口检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                surfaceBreachTool = new SurfaceBreachTool();
                surfaceBreachTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, surfaceBreachTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, surfaceBreachTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }
            if (type == ImageTool.Tool.网格线检测.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                gridLineTool = new GridLineTool();
                gridLineTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, gridLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, gridLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }

            if (type == ImageTool.Tool.Yolo训练.ToString())
            {
                string[] str = new string[] { s, type, "", "NG", "0ms" };
                gridLineTool = new GridLineTool();
                gridLineTool.Image = flowExecute1.CollectiveImage;
                if (index > 0)
                    EditBLL.Insert(listView1, tool, gridLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
                else
                    EditBLL.Add(listView1, tool, gridLineTool, str, frm_ImageWindow.Instance.halconView1.HWindowControl);
            }




        }

        public void ReadFile()
        {
            if (tool == null)
                tool = new List<ImageTool>();
            ReadSet.Filter = "系统数据(*.vin)|*.vin";
            ReadSet.FileName = Application.StartupPath + @"\配置文件\";
            if (ReadSet.ShowDialog() == DialogResult.OK)
            {
                toolPath = ReadSet.FileName;
                switch (ReadSet.FilterIndex)
                {
                    case 1:
                        if (acqHandle1 != null)
                        {
                            HOperatorSet.CloseFramegrabber(acqHandle1);
                            acqHandle1 = null;
                        }
                        try
                        {
                            tool.Clear();
                            tool = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具

                        }
                        catch (System.Exception ex)
                        {

                            MessageBox.Show("数据加载失败！" + ex.Message, "数据加载失败！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tool = new List<ImageTool>();
                        }
                        break;

                }
            }
        }
        public bool ReadFile(string path)
        {
            try
            {
                int sx = path.LastIndexOf("\\");
                noodePath = path.Substring(sx + 1, path.Length - (sx + 1));
                //toolPath = path;
                tool.Clear();
                tool = SerializeBLL.Read(path) as List<ImageTool>;//反序列化所有工具
                frm_Mesbox.SingleShow("数据加载成功！", "数据加载成功！").Show();
                return true;
                //   MessageBox.Show("数据加载成成功！" , "数据加载成成功！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Exception ex)
            {
                frm_Mesbox.SingleShow("数据加载失败！", "数据加载失败！").Show();
                tool = new List<ImageTool>();
                //MessageBox.Show("数据加载失败！" + ex.Message, "数据加载失败！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
        }
        public void SaveFile()
        {
            try
            {
                bool b = SerializeBLL.Write(tool, toolPath + @"\" + noodePath);
                DialogResult result = (b != false) ? MessageBox.Show("数据保存成功！", "数据保存成功！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) : MessageBox.Show("数据保存失败!", "数据保存失败!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("数据保存失败!" + ex.Message, "数据保存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SaveAs_file()
        {
            SaveSet.Filter = "系统数据(*.vin)|*.vin";
            if (SaveSet.ShowDialog() == DialogResult.OK)
            {
                toolPath = SaveSet.FileName;
                switch (SaveSet.FilterIndex)
                {
                    case 1:
                        try
                        {
                            bool b = SerializeBLL.Write(tool, toolPath);
                            DialogResult result = (b != false) ? MessageBox.Show("数据另存成功！", "数据另存成功！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) : MessageBox.Show("数据保存失败!", "数据保存失败!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("数据另存失败!" + ex.Message, "数据另存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBLL.UpEdit(listView1, tool);

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditBLL.DownEdit(listView1, tool);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditBLL.RemoveAt(listView1, tool);
        }
        private void 清除工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBLL.Clear(listView1, tool);
        }
        private void frm_Job_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count == 0) return;
            int index = listView.SelectedItems[0].Index;//选中一行集合索引

            if (tool[index] as BlobTool is BlobTool)
            {
                BlobTool blobTool = tool[index] as BlobTool;
                frm_Blob.SingleShow(blobTool, setVal).Show();
            }
            if (tool[index] as PMAlignTool is PMAlignTool)
            {
                PMAlignTool pmalignTool = tool[index] as PMAlignTool;
                frm_PMAlign.SingleShow(pmalignTool, setVal).Show();
            }
            if (tool[index] as AcqFifoTool is AcqFifoTool)
            {
                if (acqHandle1 != null)
                {
                    try
                    {
                        HOperatorSet.CloseFramegrabber(acqHandle1);
                        acqHandle1 = null;

                    }
                    catch
                    {
                    }
                    AcqFifoTool acqFifoTool = tool[index] as AcqFifoTool;
                    frm_AcqFifo.SingleShow(acqFifoTool, setVal).Show();
                    //frm_AcqFifo.eventCancel += Frm_AcqFifo_eventCancel;
                }
                else
                {
                    AcqFifoTool acqFifoTool = tool[index] as AcqFifoTool;
                    frm_AcqFifo.SingleShow(acqFifoTool, setVal).Show();
                }
            }
            if (tool[index] as FixtureTool is FixtureTool)
            {
                FixtureTool fixtureTool = tool[index] as FixtureTool;
                frm_Fixture.SingleShow(fixtureTool, setVal).Show();
            }
            if (tool[index] as FitCircleTool is FitCircleTool)
            {
                FitCircleTool fitCircle = tool[index] as FitCircleTool;
                frm_FitCircle.SingleShow(fitCircle, setVal).Show();
            }
            if (tool[index] as FitLineTool is FitLineTool)
            {
                FitLineTool fitLine = tool[index] as FitLineTool;
                frm_FitLine.SingleShow(fitLine, setVal).Show();
            }
            if (tool[index] as FindEdgeTool is FindEdgeTool)
            {
                FindEdgeTool findEdgeTool = tool[index] as FindEdgeTool;
                frm_FindEdge.SingleShow(findEdgeTool, setVal).Show();
            }
            if (tool[index] as FindRectangle2Tool is FindRectangle2Tool)
            {
                FindRectangle2Tool findRectangle2 = tool[index] as FindRectangle2Tool;
                frm_FindRectangle2.SingleShow(findRectangle2, setVal).Show();
            }
            if (tool[index] as DistancePointPointTool is DistancePointPointTool)
            {
                DistancePointPointTool distancePpTool = tool[index] as DistancePointPointTool;
                frm_DistancePointPoint.SingleShow(distancePpTool, setVal).Show();
            }
            if (tool[index] as DistancePointLineTool is DistancePointLineTool)
            {
                DistancePointLineTool distancePlTool = tool[index] as DistancePointLineTool;
                frm_DistancePointLine.SingleShow(distancePlTool, setVal).Show();

            }
            if (tool[index] as DistanceLineLineTool is DistanceLineLineTool)
            {
                DistanceLineLineTool distanceLlTool = tool[index] as DistanceLineLineTool;
                frm_DistanceLineLine.SingleShow(distanceLlTool, setVal).Show();
            }
            if (tool[index] as DistanceAnglePointPointTool is DistanceAnglePointPointTool)
            {
                DistanceAnglePointPointTool distanceAPpTool = tool[index] as DistanceAnglePointPointTool;
                frm_AnglePointPoint.SingleShow(distanceAPpTool, setVal).Show();
            }
            if (tool[index] as DistanceAngleLineLineTool is DistanceAngleLineLineTool)
            {
                DistanceAngleLineLineTool distanceALlTool = tool[index] as DistanceAngleLineLineTool;
                frm_AngleLineLine.SingleShow(distanceALlTool, setVal).Show();
            }
            if (tool[index] as IntersectionLinesTool is IntersectionLinesTool)
            {
                IntersectionLinesTool intersectionLinesTool = tool[index] as IntersectionLinesTool;
                frm_IntersectionLines.SingleShow(intersectionLinesTool, setVal).Show();
            }
            if (tool[index] as OCRMaxTool is OCRMaxTool)
            {
                OCRMaxTool ocrMaxTool = tool[index] as OCRMaxTool;
                frm_OCRMax.SingleShow(ocrMaxTool, setVal).Show();
            }
            if (tool[index] as CaliperTool is CaliperTool)
            {
                CaliperTool caliperTool = tool[index] as CaliperTool;
                frm_Caliper.SingleShow(caliperTool, setVal).Show();
            }
            if (tool[index] as _2DSymbolTool is _2DSymbolTool)
            {
                _2DSymbolTool _2dSymbolTool = tool[index] as _2DSymbolTool;
                frm_2DSymbol.SingleShow(_2dSymbolTool, setVal).Show();
            }
            if (tool[index] as FindCornerTool is FindCornerTool)
            {
                FindCornerTool findCornerTool = tool[index] as FindCornerTool;
                frm_FindCorner.SingleShow(findCornerTool, setVal).Show();
            }
            if (tool[index] as ScaleImageTool is ScaleImageTool)
            {
                ScaleImageTool scaleImageTool = tool[index] as ScaleImageTool;
                frm_ScaleImage.SingleShow(scaleImageTool, setVal).Show();
            }

            if (tool[index] as SmoothImageTool is SmoothImageTool)
            {
                SmoothImageTool smoothImageTool = tool[index] as SmoothImageTool;
                frm_Smooth.SingleShow(smoothImageTool, setVal).Show();
            }
            if (tool[index] as MeanImageTool is MeanImageTool)
            {
                MeanImageTool meanImageTool = tool[index] as MeanImageTool;
                frm_MeanImage.SingleShow(meanImageTool, setVal).Show();
            }
            if (tool[index] as MedianImageTool is MedianImageTool)
            {
                MedianImageTool medianImageTool = tool[index] as MedianImageTool;
                frm_MedianImage.SingleShow(medianImageTool, setVal).Show();
            }
            if (tool[index] as InvertImageTool is InvertImageTool)
            {
                InvertImageTool ivertImageTool = tool[index] as InvertImageTool;
                frm_InvertImage.SingleShow(ivertImageTool, setVal).Show();
            }
            if (tool[index] as TransPolarTool is TransPolarTool)
            {
                ProjectiveTransImageTool projectiveTransImageTool = tool[index] as ProjectiveTransImageTool;
                frm_ProjectiveTransImage.SingleShow(projectiveTransImageTool, setVal).Show();
            }
            if (tool[index] as TransPolarTool is TransPolarTool)
            {
                TransPolarTool transPolarTool = tool[index] as TransPolarTool;
                frm_TransPolar.SingleShow(transPolarTool, setVal).Show();
            }
            if (tool[index] as ImageConvertTool is ImageConvertTool)
            {
                ImageConvertTool imageConvertTool = tool[index] as ImageConvertTool;
                frm_ImageConvert.SingleShow(imageConvertTool, setVal).Show();
            }
            if (tool[index] as SerialPortTool is SerialPortTool)
            {
                SerialPortTool serialPortTool = tool[index] as SerialPortTool;
                frm_Tool.frm_Serial.SingleShow(serialPortTool, this.setVal).Show();
            }
            if (tool[index] as RoiCreateTool is RoiCreateTool)
            {
                RoiCreateTool roiCreateTool = tool[index] as RoiCreateTool;
                frm_RoiCreate.SingleShow(roiCreateTool, setVal).Show();
            }
            if (tool[index] as RoiOpUnionTool is RoiOpUnionTool)
            {
                RoiOpUnionTool roiOpUnionTool = tool[index] as RoiOpUnionTool;
                frm_RoiOpUnion.SingleShow(roiOpUnionTool, setVal).Show();
            }
            if (tool[index] as PatInspectTool is PatInspectTool)
            {
                PatInspectTool patInspectTool = tool[index] as PatInspectTool;
                frm_PatInspect.SingleShow(patInspectTool, setVal).Show();
            }
            if (tool[index] as AffineTransImageTool is AffineTransImageTool)
            {
                AffineTransImageTool affineTransImageTool = tool[index] as AffineTransImageTool;
                frm_AffineTransImage.SingleShow(affineTransImageTool, setVal).Show();
            }
            if (tool[index] as DetectScratchesTool is DetectScratchesTool)
            {
                DetectScratchesTool detectScratchesTool = tool[index] as DetectScratchesTool;
                frm_DetectScratches.SingleShow(detectScratchesTool, setVal).Show();
            }
            if (tool[index] as SurfaceStainsTool is SurfaceStainsTool)
            {
                SurfaceStainsTool surfaceStainsTool = tool[index] as SurfaceStainsTool;
                frm_SurfaceStains.SingleShow(surfaceStainsTool, setVal).Show();
            }
            if (tool[index] as SurfaceFlawTool is SurfaceFlawTool)
            {
                SurfaceFlawTool surfaceFlawTool = tool[index] as SurfaceFlawTool;
                frm_SurfaceFlaw.SingleShow(surfaceFlawTool, setVal).Show();
            }
            if (tool[index] as EmphasizeImageTool is EmphasizeImageTool)
            {
                EmphasizeImageTool emphasizeImageTool = tool[index] as EmphasizeImageTool;
                frm_Emphasize.SingleShow(emphasizeImageTool, setVal).Show();
            }
            if (tool[index] as RotateImageTool is RotateImageTool)
            {
                RotateImageTool rotateImageTool = tool[index] as RotateImageTool;
                frm_RotateImage.SingleShow(rotateImageTool, setVal).Show();
            }
            if (tool[index] as BarcodeTool is BarcodeTool)
            {
                BarcodeTool barcodeTool = tool[index] as BarcodeTool;
                frm_Barcode.SingleShow(barcodeTool, setVal).Show();
            }
            if (tool[index] as _9PointCalibTool is _9PointCalibTool)
            {
                _9PointCalibTool _9pointCalibTool = tool[index] as _9PointCalibTool;
                frm_9PointCalib.SingleShow(_9pointCalibTool, setVal).Show();
            }
            if (tool[index] as SaveImageTool is SaveImageTool)
            {
                SaveImageTool saveImageTool = tool[index] as SaveImageTool;
                frm_SaveImage.SingleShow(saveImageTool, setVal).Show();
            }
            if (tool[index] as ColorExtractorTool is ColorExtractorTool)
            {
                ColorExtractorTool colorExtractorTool = tool[index] as ColorExtractorTool;
                frm_ColorExtrator.SingleShow(colorExtractorTool, setVal).Show();
            }
            if (tool[index] as InspectionBallBondingTool is InspectionBallBondingTool)
            {

                InspectionBallBondingTool inspectionBallBonding = tool[index] as InspectionBallBondingTool;
                frm_InspectionBallBonding.SingleShow(inspectionBallBonding, setVal).Show();
            }
            if (tool[index] as HalconScriptTool is HalconScriptTool)
            {
                HalconScriptTool halconScriptTool = tool[index] as HalconScriptTool;
                frm_HalconScript.SingleShow(halconScriptTool, setVal).Show();
            }
            if (tool[index] as MorphologyTool is MorphologyTool)
            {
                MorphologyTool morphologyTool = tool[index] as MorphologyTool;
                frm_Morphology.SingleShow(morphologyTool, setVal).Show();
            }
            if (tool[index] as GrayTophatTool is GrayTophatTool)
            {
                GrayTophatTool grayTophatTool = tool[index] as GrayTophatTool;
                frm_GrayTophat.SingleShow(grayTophatTool, setVal).Show();
            }
            if (tool[index] as SurfaceBreachTool is SurfaceBreachTool)
            {
                SurfaceBreachTool surfaceBreachTool = tool[index] as SurfaceBreachTool;
                frm_SurfaceBreach.SingleShow(surfaceBreachTool, setVal).Show();
            }
            if (tool[index] as GridLineTool is GridLineTool)
            {
                GridLineTool gridLineTool = tool[index] as GridLineTool;
                frm_GridLine.SingleShow(gridLineTool, setVal).Show();
            }
        }
    }
}

