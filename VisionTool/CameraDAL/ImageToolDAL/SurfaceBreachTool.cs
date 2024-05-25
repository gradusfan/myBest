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
    /*****20221007 阿涛添加工具****/
    [Serializable]
    public class SurfaceBreachTool : ImageTool
    {
        [NonSerialized]
        HTuple searchModeRoi = new HTuple();
        [NonSerialized]
        Dictionary<string, HObject> ho_Image = new Dictionary<string, HObject>();
        [NonSerialized]
        HObject outImage;
        [NonSerialized]
        HObject RegionErosion;

        public int low_Threshold { get; set; }
        public int high_Threshold { get; set; }
        public int rect_width { get; set; }
        public int rect_height { get; set; }
        public int enhance_width { get; set; }
        public int enhance_height { get; set; }
        public int enhance_num { get; set; }
        public int etch_width { get; set; }
        public int etch_height { get; set; }
        public double rect_sX { get; set; }
        public double rect_sY { get; set; }
        public double rect_eX { get; set; }
        public double rect_eY { get; set; }
        public string Methods { get; set; }

        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names { get; set; }
        public bool ResultLogic { get; set; }
        public bool IsFlaw { get; set; }
        /// <summary>
        /// 轮廓显示
        /// </summary>
        public string Setdraw { get; set; }
        /// <summary>
        /// 输入图像
        /// </summary>
        public Dictionary<string, HObject> Image
        {
            get { return ho_Image; }
            set { ho_Image = value; }
        }
        /// <summary>
        /// 图片
        /// </summary>
        public HObject OutImage
        {
            get { return outImage; }
            set { outImage = value; }
        }
        public HTuple SearchModeRoi
        {
            get { return searchModeRoi; }
            set { searchModeRoi = value; }
        }
        public bool IsSearchRegion { get; set; }
        public override string toolName()
        { return Names; }
        public override long toolTimer()
        {
            return timer;
        }
        public override void recon()
        { }
        public override void ini()
        {
            Names = Tool.表面缺口检测.ToString();
            rect_height = 10;
            rect_width = 10;
            enhance_width = 7;
            enhance_height = 7;
            enhance_num = 1;
            low_Threshold = 0;
            high_Threshold = 20;
            etch_height = 5;
            etch_width = 5;
            ImageName = "采集图像0";
            Setdraw = Set_draw.fill.ToString();
            IsFlaw = true; //瑕疵

            Methods = "convex";
            rect_sX = 100;
            rect_sY = 100;
            rect_eX = 300;
            rect_eY = 300;
        }
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
                if (outImage != null)
                    outImage.Dispose();

                SurfaceDetection((HObject)ho_Image[ImageName], out RegionErosion);
                HTuple area, row, col;
                HOperatorSet.AreaCenter(RegionErosion, out area, out row, out col);
                if (area.D > 0)
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
                    if (RegionErosion != null)
                        RegionErosion.Dispose();

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
                {
                    HOperatorSet.DispObj(RegionErosion, WindowControl.HalconWindow);
                }

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
            if (rect_sX != -1) //是否存在搜索区域
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

        private void SurfaceDetection(HObject ho_Image, out HObject ho_RegionErosion)
        {
            HObject ho_SeachROI, imageOpening, imageEmphasize, ho_Region, connectedRegions, selectedRegions;
            HObject regionUn, ho_RegionFillUp, regionErosion, ho_RegionClosing, ho_RegionDifference;

            if (IsSearchRegion)//限定区域搜索模板
            {
                HOperatorSet.GenRectangle1(out ho_SeachROI, rect_sX, rect_sY, rect_eX, rect_eY);
                HOperatorSet.ReduceDomain(ho_Image, ho_SeachROI, out ho_SeachROI);
                ho_Image = ho_SeachROI;
            }

            HOperatorSet.GrayOpeningRect(ho_Image, out imageOpening, rect_height, rect_width);

            HOperatorSet.Emphasize(imageOpening, out imageEmphasize, enhance_width, enhance_height, enhance_num);

            //二值化
            HOperatorSet.Threshold(imageEmphasize, out ho_Region, low_Threshold, high_Threshold);
            //连通区域
            HOperatorSet.Connection(ho_Region, out connectedRegions);
            //筛选面积最大区域
            HOperatorSet.SelectShape(connectedRegions, out selectedRegions, "area", "and", 10000, 9999999999);

            HOperatorSet.Union1(selectedRegions, out regionUn);
            //填充区域
            HOperatorSet.FillUp(regionUn, out ho_RegionFillUp);

            HOperatorSet.ErosionRectangle1(ho_RegionFillUp, out regionErosion, 3, 3);
            //补缺区域
            HOperatorSet.ShapeTrans(regionErosion, out ho_RegionClosing, (HTuple)Methods);
            //差分
            HOperatorSet.Difference(ho_RegionClosing, ho_RegionFillUp, out ho_RegionDifference);

            HOperatorSet.ErosionRectangle1(ho_RegionDifference, out ho_RegionErosion, etch_width, etch_height);
            imageOpening.Dispose();
            imageEmphasize.Dispose();
            ho_Region.Dispose();
            connectedRegions.Dispose();
            selectedRegions.Dispose();
            regionUn.Dispose();
            ho_RegionFillUp.Dispose();
            regionErosion.Dispose();
            ho_RegionClosing.Dispose();
            ho_RegionDifference.Dispose();
        }
    }
}
