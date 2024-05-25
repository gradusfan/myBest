using HalconDotNet;
using HOperatorSet_EX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionTool.ImageToolDAL
{
    /*******20221008 阿涛新增工具********/
    [Serializable]
    public class GridLineTool : ImageTool
    {
        //二值化
        HTuple lowThreshold = null, highthreshold = null;
        //初步筛选
        HTuple minArea1 = null, maxArea1 = null, minWidth1 = null, maxWidth1 = null;
        //二次筛选
        HTuple minArea2 = null, maxArea2 = null, minWidth2 = null, maxWidth2 = null;
        //最终筛选
        HTuple minArea3 = null, maxArea3 = null, minWidth3 = null, maxWidth3 = null, minHeight3 = null, maxHeight3 = null;

        //过滤异常面积
        HTuple strangeMinArea = null, strangeMaxArea = null;

        [NonSerialized]
        HObject ResultRegion;

        [NonSerialized]
        Dictionary<string, HObject> ho_Image = new Dictionary<string, HObject>();

        /// <summary>
        /// 输出结果
        /// </summary>
        public bool ResultLogic { get; set; }
        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names { get; set; }
        /// <summary>
        /// 轮廓显示
        /// </summary>
        public string Setdraw { get; set; }
        public bool IsFlaw { get; set; }

        #region 属性
        public double rect_sX { get; set; }
        public double rect_sY { get; set; }
        public double rect_eX { get; set; }
        public double rect_eY { get; set; }

        HTuple searchModeRoi = new HTuple();
        public HTuple SearchModeRoi
        {
            get { return searchModeRoi; }
            set { searchModeRoi = value; }
        }
        public bool IsSearchRegion { get; set; }
        /// <summary>
        /// 输入图像
        /// </summary>
        public Dictionary<string, HObject> Image
        {
            get { return ho_Image; }
            set { ho_Image = value; }
        }
        /// <summary>
        /// 二值化低阈值
        /// </summary>
        public HTuple LowThreshold { get => lowThreshold; set => lowThreshold = value; }
        /// <summary>
        /// 二值化高阈值
        /// </summary>
        public HTuple Highthreshold { get => highthreshold; set => highthreshold = value; }
        /// <summary>
        /// 初步筛选面积-最小
        /// </summary>
        public HTuple MinArea1 { get => minArea1; set => minArea1 = value; }
        /// <summary>
        /// 初步筛选面积-最大
        /// </summary>
        public HTuple MaxArea1 { get => maxArea1; set => maxArea1 = value; }
        /// <summary>
        /// 初步筛选宽度-最小
        /// </summary>
        public HTuple MinWidth1 { get => minWidth1; set => minWidth1 = value; }
        /// <summary>
        /// 初步筛选宽度-最大
        /// </summary>
        public HTuple MaxWidth1 { get => maxWidth1; set => maxWidth1 = value; }
        /// <summary>
        /// 二次筛选面积-最小
        /// </summary>
        public HTuple MinArea2 { get => minArea2; set => minArea2 = value; }
        /// <summary>
        /// 二次筛选面积-最大
        /// </summary>
        public HTuple MaxArea2 { get => maxArea2; set => maxArea2 = value; }
        /// <summary>
        /// 二次筛选宽度-最小
        /// </summary>
        public HTuple MinWidth2 { get => minWidth2; set => minWidth2 = value; }
        /// <summary>
        /// 二次筛选宽度-最大
        /// </summary>
        public HTuple MaxWidth2 { get => maxWidth2; set => maxWidth2 = value; }
        /// <summary>
        /// 最终筛选面积-最小
        /// </summary>
        public HTuple MinArea3 { get => minArea3; set => minArea3 = value; }
        /// <summary>
        /// 最终筛选面积-最大
        /// </summary>
        public HTuple MaxArea3 { get => maxArea3; set => maxArea3 = value; }
        /// <summary>
        /// 最终筛选宽度-最小
        /// </summary>
        public HTuple MinWidth3 { get => minWidth3; set => minWidth3 = value; }
        /// <summary>
        /// 最终筛选宽度-最大
        /// </summary>
        public HTuple MaxWidth3 { get => maxWidth3; set => maxWidth3 = value; }
        /// <summary>
        /// 最终筛选高度-最小
        /// </summary>
        public HTuple MinHeight3 { get => minHeight3; set => minHeight3 = value; }
        /// <summary>
        /// 最终筛选高度-最大
        /// </summary>
        public HTuple MaxHeight3 { get => maxHeight3; set => maxHeight3 = value; }
        /// <summary>
        /// 异常面积过滤-最小
        /// </summary>
        public HTuple StrangeMinArea { get => strangeMinArea; set => strangeMinArea = value; }
        /// <summary>
        /// 异常面积过滤-最大
        /// </summary>
        public HTuple StrangeMaxArea { get => strangeMaxArea; set => strangeMaxArea = value; }

        #endregion

        public override string toolName()
        {
            return Names;
        }
        public override long toolTimer()
        {
            return timer;
        }
        public override void recon()
        { }
        public override void ini()
        {
            Names = Tool.网格线检测.ToString();
            ImageName = "采集图像0";
            IsFlaw = true; //瑕疵
            Setdraw = Set_draw.fill.ToString();

            lowThreshold = 0;
            highthreshold = 128;

            minArea1 = 5000;
            maxArea1 = 8000;
            minWidth1 = 160;
            maxWidth1 = 300;

            MinArea2 = 10000;
            MaxArea2 = 15000;
            MinWidth2 = 200;
            maxWidth2 = 300;

            MinArea3 = 0;
            MaxArea3 = 100;
            minWidth3 = 2000;
            MaxWidth3 = 10000;
            MinHeight3 = 900;
            maxHeight3 = 1000;

            strangeMinArea = 1000;
            strangeMaxArea = 99999;

            rect_sX = 100;
            rect_sY = 100;
            rect_eX = 300;
            rect_eY = 300;
        }

        /// <summary>
        /// 运行一次
        /// </summary>
        public override void run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            toolRun();
            dispresult();
            watch.Stop();
            timer = watch.ElapsedMilliseconds;
        }

        private void toolRun()
        {
            try
            {
                HSystem.SetSystem("flush_graphic", "true");

                GridlineDetection((HObject)ho_Image[ImageName], out ResultRegion);
                HTuple area, row, col;
                HOperatorSet.AreaCenter(ResultRegion, out area, out row, out col);
                if (area.Length>0&&area.D > 0)
                    ResultLogic = false;
                else
                    ResultLogic = true;

                HSystem.SetSystem("flush_graphic", "false");
            }
            catch (HalconException ex)
            {
                try
                {
                    HSystem.SetSystem("flush_graphic", "true");
                    HTuple hv_Exception;
                    ex.ToHTuple(out hv_Exception);
                    HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "{" + hv_Exception + "}", CoordSystem.window.ToString(), 10, 10, "red", "false");
                    if (ResultRegion != null)
                        ResultRegion.Dispose();

                    ResultLogic = false;//结果异常
                    HSystem.SetSystem("flush_graphic", "false");
                }
                catch { };
            }
        }

        public override void dispresult()
        {
            try
            {
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet.SetDraw(WindowControl.HalconWindow, Setdraw);
                HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 2);
                HOperatorSet.SetColor(WindowControl.HalconWindow, ColorFul.red.ToString());
                if (IsFlaw)
                    HOperatorSet.DispObj(ResultRegion, WindowControl.HalconWindow);

                HSystem.SetSystem("flush_graphic", "false");
            }
            catch (HalconException ex)
            {
                try
                {
                    HSystem.SetSystem("flush_graphic", "true");
                    HTuple hv_Exception;
                    ex.ToHTuple(out hv_Exception);
                    HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "{" + hv_Exception + "}", CoordSystem.window.ToString(), 10, 10, "red", "false");
                    ResultLogic = false;//结果异常
                    HSystem.SetSystem("flush_graphic", "false");
                }
                catch { };
            }
        }
        public override long set_after()
        {

            try
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                HOperatorSet.ClearWindow(WindowControl.HalconWindow);
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet.DispObj((HObject)ho_Image[ImageName], WindowControl.HalconWindow);
                HSystem.SetSystem("flush_graphic", "false");
                run();
                dispresult();
                watch.Stop();
                timer = watch.ElapsedMilliseconds;
                return watch.ElapsedMilliseconds;
            }
            catch
            {
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "运行异常", "image", 10, 10, "red", "false");
                ResultLogic = false;//结果异常
                HSystem.SetSystem("flush_graphic", "false");
                timer = 0;
                return 0;
            }
        }
        public override bool toolResult()
        {
            return ResultLogic;
        }

        public void drawSearchRoi()//
        {
            HTuple hv_rec1Column1 = new HTuple(), hv_rec1Row1 = new HTuple();
            HTuple hv_rec1Column2 = new HTuple(), hv_rec1Row2 = new HTuple();
            HSystem.SetSystem("flush_graphic", "true");
            HOperatorSet.SetColor(WindowControl.HalconWindow, "green");
            HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
            HOperatorSet.DispObj((HObject)Image[ImageName], WindowControl.HalconWindow);
            HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "创建裁剪区域,右键确定！", "image", 10, 10, "green", "false");
            if (rect_sX !=- 1) //是否存在搜索区域
                HOperatorSet.DrawRectangle1Mod(WindowControl.HalconWindow, rect_sX, rect_sY, rect_eX, rect_eY, out hv_rec1Row1, out hv_rec1Column1, out hv_rec1Row2, out hv_rec1Column2);
            else     //
                HOperatorSet.DrawRectangle1(WindowControl.HalconWindow, out hv_rec1Row1, out hv_rec1Column1, out hv_rec1Row2, out hv_rec1Column2);

            rect_sX = hv_rec1Row1;
            rect_sY = hv_rec1Column1;
            rect_eX = hv_rec1Row2;
            rect_eY = hv_rec1Column2;
            HOperatorSet.DispRectangle1(WindowControl.HalconWindow, rect_sX, rect_sY, rect_eX, rect_eY);
            HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "裁剪区域", "image", rect_sX + 10, rect_sY + 10, "green", "false");
            HSystem.SetSystem("flush_graphic", "false"); 
            set_after();
        }

        private void GridlineDetection(HObject hv_image, out HObject ResultRegion)
        {
            HObject ho_Region, ConnectedRegions, ho_GoodSmallParts, ho_GoodLongParts, ho_Clutter, ho_Difference, ho_BrokenParts, ho_BrokenPartsTrans,ho_SeachROI;

            if (IsSearchRegion)//限定区域搜索模板
            {
                HOperatorSet.GenRectangle1(out ho_SeachROI, rect_sX, rect_sY, rect_eX, rect_eY);
                HOperatorSet.ReduceDomain(hv_image, ho_SeachROI, out ho_SeachROI);
                hv_image = ho_SeachROI;
            }
            
            HOperatorSet.Threshold(hv_image, out ho_Region, lowThreshold, highthreshold);
            HOperatorSet.Connection(ho_Region, out ConnectedRegions);
            HOperatorSet.SelectShape(ConnectedRegions, out ho_GoodSmallParts, (new HTuple("area")).TupleConcat("width"), "and", (new HTuple(minArea1)).TupleConcat(minWidth1), (new HTuple(maxArea1)).TupleConcat(maxWidth1));
            HOperatorSet.SelectShape(ConnectedRegions, out ho_GoodLongParts, (new HTuple("area")).TupleConcat("width"), "and", (new HTuple(minArea2)).TupleConcat(minWidth2), (new HTuple(maxArea2)).TupleConcat(maxWidth2));
            HOperatorSet.SelectShape(ConnectedRegions, out ho_Clutter, ((new HTuple("width")).TupleConcat("height")).TupleConcat("area"), "or", ((new HTuple(minWidth3)).TupleConcat(minHeight3)).TupleConcat(minArea3), ((new HTuple(maxWidth3)).TupleConcat(maxHeight3)).TupleConcat(maxArea3));
            HOperatorSet.Difference(ConnectedRegions, ho_GoodSmallParts, out ho_Difference);
            {
                HObject ExpTmpOutVar_0;
                HOperatorSet.Difference(ho_Difference, ho_GoodLongParts, out ExpTmpOutVar_0);
                ho_Difference.Dispose();
                ho_Difference = ExpTmpOutVar_0;
            }
            HOperatorSet.Difference(ho_Difference, ho_Clutter, out ho_BrokenParts);
            {
                HObject ExpTmpOutVar_0;
                HOperatorSet.SelectShape(ho_BrokenParts, out ExpTmpOutVar_0, "area", "and", 1000, 99999);
                ho_BrokenParts.Dispose();
                ho_BrokenParts = ExpTmpOutVar_0;
            }
            HOperatorSet.ShapeTrans(ho_BrokenParts, out ho_BrokenPartsTrans, "rectangle1");
            HOperatorSet.ErosionRectangle1(ho_BrokenParts, out ResultRegion, 1, 25);
            HOperatorSet.DispObj(ResultRegion, WindowControl.HalconWindow);


            ho_Region.Dispose();
            ConnectedRegions.Dispose();
            ho_GoodSmallParts.Dispose();
            ho_GoodLongParts.Dispose();
            ho_Clutter.Dispose();
            ho_Difference.Dispose();
            ho_BrokenParts.Dispose();
            ho_BrokenPartsTrans.Dispose();
        }
    }
}
