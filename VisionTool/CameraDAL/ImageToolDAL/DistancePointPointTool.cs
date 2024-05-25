using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Diagnostics;
using HOperatorSet_EX;

namespace VisionTool.ImageToolDAL
{
    [Serializable]
    public class DistancePointPointTool : ImageTool
    {
        [NonSerialized]
        HTuple hv_rowA1;
        [NonSerialized]
        HTuple hv_colA1;
        [NonSerialized]
        HTuple hv_rowB1;
        [NonSerialized]
        HTuple hv_colB1;
        [NonSerialized]
        HObject arrow;
        [NonSerialized]
        HObject arrow1;
        [NonSerialized]
        HObject arrow2;
        #region 结果输出
        [NonSerialized]
        private HTuple distance;
        [NonSerialized]
        private HTuple distance1;
        [NonSerialized]
        private HTuple distance2;
        public HTuple Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public HTuple Distance1
        {
            get { return distance1; }
            set { distance1 = value; }
        }
        public HTuple Distance2
        {
            get { return distance2; }
            set { distance2 = value; }
        }
        [NonSerialized]
        bool resultLogic1 = false, resultLogic2 = false, resultLogic = false;
        public bool ResultLogic { get; set; }

        [NonSerialized]
        HTuple hv_rsultRow1, hv_rsultCol1, hv_rsultRow2, hv_rsultCol2;
        public HTuple ResultRow1
        {
            get { return hv_rsultRow1; }
            set { hv_rsultRow1 = value; }
        }
        public HTuple ResultCol1
        {
            get { return hv_rsultCol1; }
            set { hv_rsultCol1 = value; }
        }
        public HTuple ResultRow2
        {
            get { return hv_rsultRow2; }
            set { hv_rsultRow2 = value; }
        }
        public HTuple ResultCol2
        {
            get { return hv_rsultCol2; }
            set { hv_rsultCol2 = value; }
        }
        #endregion
        #region 输出结果判定
        public bool IsMeasure { get; set; }
        public bool IsMeasure1 { get; set; }
        public bool IsMeasure2 { get; set; }
        public HTuple Hmeasure
        { get; set; }
        public HTuple Lmeasure
        { get; set; }
        public HTuple Hmeasure1
        { get; set; }
        public HTuple Lmeasure1
        { get; set; }
        public HTuple Hmeasure2
        { get; set; }
        public HTuple Lmeasure2
        { get; set; }
        #endregion,
        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names
        { get; set; }
        public string PointName1
        { get; set; }
        public string PointName2
        { get; set; }

        [NonSerialized]
        Dictionary<string, HObject> ho_Image = new Dictionary<string, HObject>();
        /// <summary>
        /// 输入图像
        /// </summary>
        public Dictionary<string, HObject> Image
        {
            get { return ho_Image; }
            set { ho_Image = value; }
        }
        [NonSerialized]
        Dictionary<string, HTuple> htRowPoint = new Dictionary<string, HTuple>();
        /// <summary>
        /// row点坐标
        /// </summary>
        public Dictionary<string, HTuple> HtRowPoint
        {
            get { return htRowPoint; }
            set { htRowPoint = value; }
        }
        [NonSerialized]
        Dictionary<string, HTuple> htColPoint = new Dictionary<string, HTuple>();
        /// <summary>
        /// col点坐标
        /// </summary>
        public Dictionary<string, HTuple> HtColPoint
        {
            get { return htColPoint; }
            set { htColPoint = value; }
        }
        /// <summary>
        /// 比例
        /// </summary>
        public HTuple Scale { get; set; }

        public bool IsResultShow { get; set; }

        public override string toolName()
        {
            return Names;
        }
        public override long toolTimer()
        {
            return timer;
        }
        public override void ini()
        {
            Names = Tool.点到点测量.ToString();
            ImageName = "采集图像0";
            IsMeasure = true;
            Hmeasure = 200;
            Lmeasure = 1;
            IsMeasure1 = true;
            Hmeasure1 = 200;
            Lmeasure1 = 1;
            IsMeasure2 = true;
            Hmeasure2 = 200;
            Lmeasure2 = 1;
            Scale = 1.000;
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
                ResultLogic = true;//结果
                resultLogic = true;//结果
                resultLogic1 = true;//结果
                resultLogic2 = true;//结果

                Select(PointName1, PointName2);

                if (IsMeasure)
                {
                    if (distance > Lmeasure && distance < Hmeasure)//工差范围
                    {
                        resultLogic = true;//结果
                    }
                    else
                    {
                        resultLogic = false;//结果异常
                    }
                }

                if (IsMeasure1)
                {
                    if (distance1 > Lmeasure1 && distance1 < Hmeasure1)//工差范围
                    {
                        resultLogic1 = true;//结果
                    }
                    else
                    {
                        resultLogic1 = false;//结果异常
                    }
                }
                if (IsMeasure2)
                {
                    if (distance2 > Lmeasure2 && distance2 < Hmeasure2)//工差范围
                    {
                        resultLogic2 = true;//结果
                    }
                    else
                    {
                        resultLogic2 = false;//结果异常
                    }
                }
                if (resultLogic == false || resultLogic1 == false || resultLogic2 == false)
                    ResultLogic = false;

            }
            catch
            {
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "运行异常", "image", 10, 10, "red", "false");
                ResultLogic = false;//结果异常
                HSystem.SetSystem("flush_graphic", "false");
            }

        }
        public override void dispresult()
        {
            try
            {
                HTuple hv_Angle = null, hv_cenrow = null, hv_cencol = null;
                HTuple hv_Angle1 = null, hv_cenrow1 = null, hv_cencol1 = null;
                HTuple hv_Angle2 = null, hv_cenrow2 = null, hv_cencol2 = null;
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet.SetColor(WindowControl.HalconWindow, "green");
                HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                HOperatorSet_Ex.set_display_font(WindowControl.HalconWindow, 12, "sans", "false", "false");//mono', 'sans', 'serif
                get_cenline_point(hv_rowA1, hv_colA1, hv_rowB1, hv_colB1, out hv_Angle, out hv_cenrow, out hv_cencol);
                get_cenline_point(hv_rowA1, hv_colA1, hv_rowA1, hv_colB1, out hv_Angle1, out hv_cenrow1, out hv_cencol1);
                get_cenline_point(hv_rowA1, hv_rowB1, hv_rowA1, hv_colB1, out hv_Angle2, out hv_cenrow2, out hv_cencol2);

                if (resultLogic)
                {
                    if(IsResultShow)
                    HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance.TupleString("0.03f"), "image", hv_cenrow, hv_cencol, "white", "forest green");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "green");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow != null)
                        arrow.Dispose();
                    HOperatorSet_Ex.gen_arrow_contour_xld(out arrow, hv_rowA1, hv_colA1, hv_rowB1, hv_colB1, 10, 10);
                    HOperatorSet.DispObj((HObject)arrow, WindowControl.HalconWindow);
                }
                else
                {
                    if (IsResultShow)
                        HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance.TupleString("0.03f"), "image", hv_cenrow, hv_cencol, "white", "red");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "red");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow != null)
                        arrow.Dispose();
                    HOperatorSet_Ex.gen_arrow_contour_xld(out arrow, hv_rowA1, hv_colA1, hv_rowB1, hv_colB1, 10, 10);
                    HOperatorSet.DispObj((HObject)arrow, WindowControl.HalconWindow);
                }
                if (resultLogic1)
                {
                    if (IsMeasure1)
                        HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance1.TupleString("0.03f"), "image", hv_cenrow1, hv_cencol1, "white", "forest green");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "green");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow1 != null)
                        arrow1.Dispose();
                    if (IsMeasure1)
                    {
                        HOperatorSet_Ex.gen_arrow_contour_xld(out arrow1, hv_rowA1, hv_colA1, hv_rowA1, hv_colB1, 10, 10);
                        HOperatorSet.DispObj((HObject)arrow1, WindowControl.HalconWindow);
                    }

                }
                else
                {
                    if (IsMeasure1)
                        HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance1.TupleString("0.03f"), "image", hv_cenrow1, hv_cencol1, "white", "red");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "red");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow1 != null)
                        arrow1.Dispose();
                    if (IsMeasure1)
                    {
                        HOperatorSet_Ex.gen_arrow_contour_xld(out arrow1, hv_rowA1, hv_colA1, hv_rowA1, hv_colB1, 10, 10);
                        HOperatorSet.DispObj((HObject)arrow1, WindowControl.HalconWindow);
                    }
                }
                if (resultLogic2)
                {
                    if (IsMeasure2)
                        HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance2.TupleString("0.03f"), "image", hv_cenrow2, hv_cencol2, "white", "forest green");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "green");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow2 != null)
                        arrow2.Dispose();
                    if (IsMeasure2)
                    {
                        HOperatorSet_Ex.gen_arrow_contour_xld(out arrow2, hv_rowB1, hv_colB1, hv_rowA1, hv_colB1, 10, 10);
                        HOperatorSet.DispObj((HObject)arrow2, WindowControl.HalconWindow);
                    }
                }
                else
                {
                    if (IsMeasure2)
                        HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, "点到点间距:" + distance2.TupleString("0.03f"), "image", hv_cenrow2, hv_cencol2, "white", "red");
                    HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
                    HOperatorSet.SetColor(WindowControl.HalconWindow, "red");
                    HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                    if (arrow2 != null)
                        arrow2.Dispose();
                    if (IsMeasure2)
                    {
                        HOperatorSet_Ex.gen_arrow_contour_xld(out arrow2, hv_rowB1, hv_colB1, hv_rowA1, hv_colB1, 10, 10);
                        HOperatorSet.DispObj((HObject)arrow2, WindowControl.HalconWindow);
                    }
                }
                HSystem.SetSystem("flush_graphic", "false");
            }
            catch
            {
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "运行异常", "image", 10, 10, "red", "false");
                ResultLogic = false;//结果异常
                HSystem.SetSystem("flush_graphic", "false");
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
        void Select(string point1, string point2)
        {
            hv_rowA1 = (HTuple)htRowPoint[point1];
            hv_colA1 = (HTuple)htColPoint[point1];
            hv_rowB1 = (HTuple)htRowPoint[point2];
            hv_colB1 = (HTuple)htColPoint[point2];

            hv_rsultRow1 = hv_rowA1;
            hv_rsultCol1 = hv_colA1;
            hv_rsultRow2 = hv_rowB1;
            hv_rsultCol2 = hv_colB1;

            HOperatorSet.DistancePp(hv_rowA1, hv_colA1, hv_rowB1, hv_colB1, out distance);
            distance *= Scale;
            if (IsMeasure1)
            {
                HOperatorSet.DistancePp(hv_rowA1, hv_colA1, hv_rowA1, hv_colB1, out distance1);
                distance1 *= Scale;
            }
            if (IsMeasure2)
            {
                HOperatorSet.DistancePp(hv_rowB1, hv_colB1, hv_rowA1, hv_colB1, out distance2);
                distance2 *= Scale;
            }

        }

        void get_cenline_point(HTuple hv_Row1, HTuple hv_Column1, HTuple hv_Row2,
    HTuple hv_Column2, out HTuple hv_Angle, out HTuple hv_cenrow, out HTuple hv_cencol)
        {
            // Local iconic variables 
            // Local control variables 
            HTuple hv_Distance = null;
            // Initialize local and output iconic variables 
            HOperatorSet.AngleLx(hv_Row1, hv_Column1, hv_Row2, hv_Column2, out hv_Angle);
            HOperatorSet.DistancePp(hv_Row1, hv_Column1, hv_Row2, hv_Column2, out hv_Distance);
            hv_cenrow = (((hv_Angle.TupleSin()) * hv_Distance) / 2) - hv_Row1;
            HOperatorSet.TupleAbs(hv_cenrow, out hv_cenrow);
            hv_cencol = (((hv_Angle.TupleCos()) * hv_Distance) / 2) + hv_Column1;
            hv_Distance *= Scale;
            return;
        }

    }
}
