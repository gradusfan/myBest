using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Collections;
using System.IO.Ports;
using HOperatorSet_EX;

namespace VisionTool.ImageToolDAL
{
    [Serializable]
    public  class ImageTool
    {
        [NonSerialized]
         List<ImageTool> tempImageTool;
        [NonSerialized]
        public  long timer;
        [NonSerialized]
        HTuple halconWindow;
        [NonSerialized]
        HWindowControl windowControl;
        public HTuple HalconWindow
        {
            get
            {
                return halconWindow;
            }
            set
            {
                halconWindow = value;
            }
        }
   
        public HWindowControl WindowControl
        {
            get
            {
                return windowControl;
            }
            set
            {
                windowControl = value;
            }
        }
        public enum Roi
        {
            圆 = 0,
            矩形 = 1,
            方向矩形 = 2,
            多边形 = 3
        }
        public enum Set_draw
        {
            margin = 0,
            fill = 1
        }
        public enum ColorFul
        {
            black,
            blue,
            yellow,
            red,
            green,
            cyan,
            magenta,
            coral,
            pink,
            white,
            gray,
            orange,
         }
        public enum Tool
        {
            采集图像 = 0,
            斑点分析 = 1,
            找圆测量 = 2,
            找线测量 = 3,
            形状模板匹配 = 4,
            NCC匹配 = 65,
            差异比较检测 = 5,
            卡尺测量 = 6,
            字符识别检测 = 7,
            条形码识别 = 8,
            二维码识别 = 9,
            点到线测量 = 10,
            点到点测量 = 11,
            两线间距测量 = 12,
            两线夹角测量 = 13,
            找顶点测量 = 14,
            图像预处理 = 15,
            标定图像 = 16,
            位置定位 = 17,
            性线收缩图像 = 18,
            均值滤波图像 = 19,
            中值滤波图像 = 20,
            平滑图像 = 21,
            区域合并 = 22,
            区域交集 = 23,
            区域差集 = 24,
            区域对称差 = 25,
            区域创建 = 26,
            彩色转HSV图像 = 27,
            串口设置=28,
            补正图像 = 29,
            划痕提取检测 = 30,
            脏污提取检测 = 31,
            图像校正 = 32,
            增强图像=33,
            九点标定=34,
            存储图像=35,
            瑕疵提取检测 = 36,
            颜色抽取检测 = 37,
            焊点检测=38,
            两线交点测量 = 39,
            找方向矩形测量 = 40,
            水平夹角测量 = 41,
            工具块=42,
            取反图像 = 43,
            结构区域膨胀 = 44,
            圆区域膨胀 = 45,
            矩形区域膨胀 = 46,
            圆区域腐蚀 = 47,
            矩形区域腐蚀 = 48,
            圆区域开运算=49,
            矩形区域开运算 = 50,
            圆区域闭运算 = 51,
            矩形区域闭运算 = 52,
            灰度值膨胀 =53,
            灰度值腐蚀 =54,
            灰度开运算=55,
            灰度闭运算 = 55,
            极坐标变换图像 = 56,
            旋转图像=57,
            视觉脚本=58,
            Yolo训练 = 80,
            区域形态处理 =59,
            灰度形态处理图像 = 60,
            顶帽处理图像 = 61,
            底帽处理图像 = 62,
            找边测量 = 63,
            投影图像 = 64,
            表面缺口检测=68,
            网格线检测=69
        }
        public enum CoordSystem
        {
            window,
            image
        }
        public virtual string toolName()
        { return "";
        }
        public virtual long toolTimer()
        {
            return 0;
        }
        public virtual bool toolResult()
        {
            return false;
        }
        public virtual void recon()
        { }
        public virtual void ini()
        {
        }
        public virtual void draw_roi()
        { }
        public virtual void run()
        { }
        public virtual void dispresult()
        { }
        public virtual long set_after()
        { return 0; }
          public void draw_roi(HTuple hv_WindowHandle,  Dictionary<string, HObject> htImg,string ImageName, HTuple hv_drawshape, HTuple Circle, HTuple Rectangle1, HTuple Rectangle2,out HTuple hv_circle,out HTuple hv_rectangle1, out HTuple hv_rectangle2)
          {
                try
                { 
                     HSystem.SetSystem("flush_graphic", "true");
                     HOperatorSet.SetDraw(WindowControl.HalconWindow, Set_draw.margin.ToString());
                     // Local control variables 
                     HTuple hv_circleRow1 = new HTuple(), hv_circleColumn1 = new HTuple();
                     HTuple hv_circleRadius1 = new HTuple(), hv_rec1Row1 = new HTuple();
                     HTuple hv_rec1Column1 = new HTuple(), hv_rec1Row2 = new HTuple();
                     HTuple hv_rec1Column2 = new HTuple(), hv_rec2Row1 = new HTuple();
                     HTuple hv_rec2Column1 = new HTuple(), hv_rec2Phi1 = new HTuple();
                     HTuple hv_rec2Length1 = new HTuple(), hv_rec2Length2 = new HTuple();
                     // Initialize local and output iconic variables 
                     hv_circle = new HTuple();
                     hv_rectangle1 = new HTuple();
                     hv_rectangle2 = new HTuple();
                     if (hv_drawshape == Roi.圆.ToString())
                     {
                         //修改圆
                         //if (Circle.Length > 1)
                          //  HOperatorSet.DrawCircleMod(WindowControl.HalconWindow, Circle[0], Circle[1], Circle[2], out hv_circleRow1, out hv_circleColumn1, out hv_circleRadius1);
                         //else //画圆
                            HOperatorSet.DrawCircle(WindowControl.HalconWindow, out hv_circleRow1, out hv_circleColumn1, out hv_circleRadius1);
                         if (hv_circle == null)
                             hv_circle = new HTuple();
                         hv_circle[0] = hv_circleRow1;
                         if (hv_circle == null)
                             hv_circle = new HTuple();
                         hv_circle[1] = hv_circleColumn1;
                         if (hv_circle == null)
                             hv_circle = new HTuple();
                         hv_circle[2] = hv_circleRadius1;
                         HOperatorSet.ClearWindow(WindowControl.HalconWindow);
                         HOperatorSet.DispObj((HObject)htImg[ImageName], WindowControl.HalconWindow);
                         HOperatorSet.DispCircle(WindowControl.HalconWindow, hv_circle[0], hv_circle[1], hv_circle[2]);
                         HSystem.SetSystem("flush_graphic", "false");
                     }
                     if (hv_drawshape == Roi.矩形.ToString())
                     {
                         //画矩形
                        // if (Rectangle1.Length>1)
                        // HOperatorSet.DrawRectangle1Mod(WindowControl.HalconWindow,Rectangle1[0],Rectangle1[1],Rectangle1[2],Rectangle1[3], out hv_rec1Row1, out hv_rec1Column1,
                        //     out hv_rec1Row2, out hv_rec1Column2);
                       //  else
                          HOperatorSet.DrawRectangle1(WindowControl.HalconWindow, out hv_rec1Row1, out hv_rec1Column1,
                         out hv_rec1Row2, out hv_rec1Column2);

                         if (hv_rectangle1 == null)
                             hv_rectangle1 = new HTuple();
                         hv_rectangle1[0] = hv_rec1Row1;
                         if (hv_rectangle1 == null)
                             hv_rectangle1 = new HTuple();
                         hv_rectangle1[1] = hv_rec1Column1;
                         if (hv_rectangle1 == null)
                             hv_rectangle1 = new HTuple();
                         hv_rectangle1[2] = hv_rec1Row2;
                         if (hv_rectangle1 == null)
                             hv_rectangle1 = new HTuple();
                         hv_rectangle1[3] = hv_rec1Column2;
                         HOperatorSet.ClearWindow(WindowControl.HalconWindow);
                         HOperatorSet.DispObj((HObject)htImg[ImageName], WindowControl.HalconWindow);
                         HOperatorSet.DispRectangle1(WindowControl.HalconWindow, hv_rectangle1[0], hv_rectangle1[1], hv_rectangle1[2], hv_rectangle1[3]);
                         HSystem.SetSystem("flush_graphic", "false");
                     }
                     if (hv_drawshape == Roi.方向矩形.ToString())
                     {
                        //修改方向矩形
                         //if (Rectangle2>1)
                         //HOperatorSet.DrawRectangle2Mod(WindowControl.HalconWindow, Rectangle2[0], Rectangle2[1], Rectangle2[2], Rectangle2[3], Rectangle2[4], out hv_rec2Row1, out hv_rec2Column1,
                         //  out hv_rec2Phi1, out hv_rec2Length1, out hv_rec2Length2);
                         ////方向矩形
                         //else
                         HOperatorSet.DrawRectangle2(WindowControl.HalconWindow,  out hv_rec2Row1, out hv_rec2Column1,
                             out hv_rec2Phi1, out hv_rec2Length1, out hv_rec2Length2);
             
                         if (hv_rectangle2 == null)
                             hv_rectangle2 = new HTuple();
                         hv_rectangle2[0] = hv_rec2Row1;
                         if (hv_rectangle2 == null)
                             hv_rectangle2 = new HTuple();
                         hv_rectangle2[1] = hv_rec2Column1;
                         if (hv_rectangle2 == null)
                             hv_rectangle2 = new HTuple();
                         hv_rectangle2[2] = hv_rec2Phi1;
                         if (hv_rectangle2 == null)
                             hv_rectangle2 = new HTuple();
                         hv_rectangle2[3] = hv_rec2Length1;
                         if (hv_rectangle2 == null)
                             hv_rectangle2 = new HTuple();
                         hv_rectangle2[4] = hv_rec2Length2;
                         HOperatorSet.ClearWindow(WindowControl.HalconWindow);

                         HOperatorSet.DispObj((HObject)htImg[ImageName], WindowControl.HalconWindow);
                         HOperatorSet.DispRectangle2(WindowControl.HalconWindow, hv_rectangle2[0], hv_rectangle2[1], hv_rectangle2[2], hv_rectangle2[3], hv_rectangle2[4]);
                         HSystem.SetSystem("flush_graphic", "false");
                     }
                }
                catch (HalconException HDevExpDefaultException)
                {

                    throw HDevExpDefaultException;
                }
          }
     
         public void gen_roi(out HObject ho_ROI_0, string drawshape, HTuple hv_circle,
          HTuple hv_rectangle1, HTuple hv_rectangle2)
         {
             HOperatorSet.SetDraw(WindowControl.HalconWindow, Set_draw.margin.ToString());
             // Initialize local and output iconic variables 
             HOperatorSet.GenEmptyObj(out ho_ROI_0);
             if (drawshape.Equals(Roi.圆.ToString()))
             {
                 ho_ROI_0.Dispose();
                 HOperatorSet.GenCircle(out ho_ROI_0, hv_circle.TupleSelect(0), hv_circle.TupleSelect(
                     1), hv_circle.TupleSelect(2));
                 //HOperatorSet.DispObj(ho_ROI_0, hv_WinHandle);
             }
             if (drawshape.Equals(Roi.矩形.ToString()))
             {
                 ho_ROI_0.Dispose();
                 HOperatorSet.GenRectangle1(out ho_ROI_0, hv_rectangle1.TupleSelect(0), hv_rectangle1.TupleSelect(
                     1), hv_rectangle1.TupleSelect(2), hv_rectangle1.TupleSelect(3));
                 //HOperatorSet.DispObj(ho_ROI_0, hv_WinHandle);
             }
             if (drawshape.Equals(Roi.方向矩形.ToString()))
             {
                 ho_ROI_0.Dispose();
                 HOperatorSet.GenRectangle2(out ho_ROI_0, hv_rectangle2.TupleSelect(0), hv_rectangle2.TupleSelect(
                     1), hv_rectangle2.TupleSelect(2), hv_rectangle2.TupleSelect(3), hv_rectangle2.TupleSelect(4));
                 //HOperatorSet.DispObj(ho_ROI_0, hv_WinHandle);
             }
             //HSystem.SetSystem("flush_graphic", "true");
             //HOperatorSet.DispObj(ho_ROI_0, WindowControl.HalconWindow);
             //HSystem.SetSystem("flush_graphic", "false");
         }
        public void dev_display_measure_arrow(out HObject ho_Arrow, HTuple hWin,
                  bool dir,  HTuple hv_Row1, HTuple hv_Column1, HTuple hv_Phi, HTuple hv_Length1, HTuple hv_Length2)
        {
            // Stack for temporary objects 
            HObject[] OTemp = new HObject[20];
            // Local iconic variables 
            HObject ho_Rectangle;
            // Local control variables 
            HTuple hv_RowEx = null, hv_ColEx = null, hv_beginRow = null;
            HTuple hv_beginCol = null, hv_EndRow = null, hv_EndCol = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Arrow);
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            try
            {
                ho_Rectangle.Dispose();
                HOperatorSet.GenRectangle2ContourXld(out ho_Rectangle, hv_Row1, hv_Column1,hv_Phi, hv_Length1, hv_Length2);
                if (dir)
                {
                    hv_beginRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1 + 20));
                    hv_beginCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1 + 20));
                    hv_EndRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1));
                    hv_EndCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1));
                }
                else
                {
                    //hv_RowEx = hv_Row1 - ((hv_Phi.TupleSin()) * hv_Length1);
                    //hv_ColEx = hv_Column1 + ((hv_Phi.TupleCos()) * hv_Length1);

                    //hv_beginRow = hv_RowEx + (hv_Phi.TupleSin());
                    //hv_beginCol = hv_ColEx - (hv_Phi.TupleCos());
                    //hv_EndRow = hv_RowEx - ((hv_Phi.TupleSin()) * 20);
                    //hv_EndCol = hv_ColEx + ((hv_Phi.TupleCos()) * 20);


                    hv_beginRow = hv_Row1 - ((hv_Phi.TupleSin()) * (hv_Length1));
                    hv_beginCol = hv_Column1 + ((hv_Phi.TupleCos()) * (hv_Length1));
                    hv_EndRow = hv_Row1 - ((hv_Phi.TupleSin()) * (hv_Length1 + 20));
                    hv_EndCol = hv_Column1 + ((hv_Phi.TupleCos()) * (hv_Length1 + 20));
                }
                ho_Arrow.Dispose();
                HOperatorSet_Ex.gen_arrow_contour_xld(out ho_Arrow, hv_beginRow, hv_beginCol, hv_EndRow, hv_EndCol,
                    10, 10);
            
                HOperatorSet.DispObj(ho_Rectangle, hWin);
                {
                    HObject ExpTmpOutVar_0;
                    HOperatorSet.ConcatObj(ho_Arrow, ho_Rectangle, out ExpTmpOutVar_0);
                    ho_Arrow.Dispose();
                    ho_Arrow = ExpTmpOutVar_0;
                }
                ho_Rectangle.Dispose();
                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_Rectangle.Dispose();

                throw HDevExpDefaultException;
            }
        }
        public void dev_display_measure_arrow(HTuple hWin,bool dir, HTuple hv_Row1,
             HTuple hv_Column1, HTuple hv_Phi, HTuple hv_Length1, HTuple hv_Length2)
        {
            // Local iconic variables 

            HObject ho_Rectangle, ho_Arrow;

            // Local control variables 

            HTuple hv_RowEx = null, hv_ColEx = null, hv_beginRow = null;
            HTuple hv_beginCol = null, hv_EndRow = null, hv_EndCol = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            HOperatorSet.GenEmptyObj(out ho_Arrow);
            try
            {
                ho_Rectangle.Dispose();
                HOperatorSet.GenRectangle2ContourXld(out ho_Rectangle, hv_Row1, hv_Column1,
                hv_Phi, hv_Length1, hv_Length2);
                if (dir)
                {
                    hv_beginRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1 + 20));
                    hv_beginCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1 + 20));
                    hv_EndRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1));
                    hv_EndCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1));
                }
                else
                {
                    //hv_RowEx = hv_Row1 - ((hv_Phi.TupleSin()) * hv_Length1);
                    //hv_ColEx = hv_Column1 + ((hv_Phi.TupleCos()) * hv_Length1);

                    //hv_beginRow = hv_RowEx + (hv_Phi.TupleSin());
                    //hv_beginCol = hv_ColEx - (hv_Phi.TupleCos());
                    //hv_EndRow = hv_RowEx - ((hv_Phi.TupleSin()) * 20);
                    //hv_EndCol = hv_ColEx + ((hv_Phi.TupleCos()) * 20);


                    hv_beginRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1));
                    hv_beginCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1));
                    hv_EndRow = hv_Row1 + ((hv_Phi.TupleSin()) * (hv_Length1 + 20));
                    hv_EndCol = hv_Column1 - ((hv_Phi.TupleCos()) * (hv_Length1 + 20));
                }

                ho_Arrow.Dispose();
               HOperatorSet_Ex.gen_arrow_contour_xld(out ho_Arrow, hv_beginRow, hv_beginCol, hv_EndRow, hv_EndCol,
                    10, 10);
                HOperatorSet.DispObj(ho_Arrow, hWin);
                HOperatorSet.DispObj(ho_Rectangle, hWin);
                ho_Rectangle.Dispose();
                ho_Arrow.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_Rectangle.Dispose();
                ho_Arrow.Dispose();

                throw HDevExpDefaultException;
            }
        }
        public HObject dev_display_measure_object(HTuple hWin, HTuple hv_Row,
          HTuple hv_Col, HTuple hv_Phi, HTuple hv_Length1, HTuple hv_Length2)
         {
             // Stack for temporary objects 
             HObject[] OTemp = new HObject[20];
             // Local iconic variables 
             HObject ho_Contour, ho_ObjectsConcat;
             // Local control variables 
             HTuple hv_RowStart = null, hv_RowEnd = null;
             HTuple hv_ColStart = null, hv_ColEnd = null, hv_drow = null;
             HTuple hv_dcol = null;
             // Initialize local and output iconic variables 
             HOperatorSet.GenEmptyObj(out ho_ObjectsConcat);
             HOperatorSet.GenEmptyObj(out ho_Contour);
             hv_RowStart = hv_Row + ((hv_Phi.TupleSin()) * hv_Length1);
             hv_RowEnd = hv_Row - ((hv_Phi.TupleSin()) * hv_Length1);
             hv_ColStart = hv_Col - ((hv_Phi.TupleCos()) * hv_Length1);
             hv_ColEnd = hv_Col + ((hv_Phi.TupleCos()) * hv_Length1);
             hv_drow = (((((new HTuple(90)).TupleRad()) - hv_Phi)).TupleSin()) * hv_Length2;
             hv_dcol = (((((new HTuple(90)).TupleRad()) - hv_Phi)).TupleCos()) * hv_Length2;
             ho_Contour.Dispose();
             HOperatorSet.GenContourPolygonXld(out ho_Contour, ((((((((hv_RowStart - hv_drow)).TupleConcat(
                 hv_RowEnd - hv_drow))).TupleConcat(hv_RowEnd + hv_drow))).TupleConcat(hv_RowStart + hv_drow))).TupleConcat(
                 hv_RowStart - hv_drow), ((((((((hv_ColStart - hv_dcol)).TupleConcat(hv_ColEnd - hv_dcol))).TupleConcat(
                 hv_ColEnd + hv_dcol))).TupleConcat(hv_ColStart + hv_dcol))).TupleConcat(hv_ColStart - hv_dcol));
             HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
             HOperatorSet.SetColor(WindowControl.HalconWindow, "blue");
             HOperatorSet.DispObj(ho_Contour, WindowControl.HalconWindow);
             ho_ObjectsConcat.Dispose();
             dev_display_profile_line(out ho_ObjectsConcat, hv_Row, hv_Col, hv_Phi, hv_Length1,
                 hv_Length2);
             {
                 HObject ExpTmpOutVar_0;
                 HOperatorSet.ConcatObj(ho_ObjectsConcat, ho_Contour, out ExpTmpOutVar_0);
                 ho_ObjectsConcat.Dispose();
                 ho_ObjectsConcat = ExpTmpOutVar_0;
             }
             ho_Contour.Dispose();
             HOperatorSet.DispObj(ho_ObjectsConcat, hWin);
             return ho_ObjectsConcat;
         }
         public void dev_display_profile_line(out HObject ho_ObjectsArrow, HTuple hv_Row,
            HTuple hv_Col, HTuple hv_Phi, HTuple hv_Length1, HTuple hv_Length2)
         {

             // Local iconic variables 

             HObject ho_CProfile, ho_CArrow, ho_CMidPoint;

             // Local control variables 

             HTuple hv_ArrowAngle = null, hv_ArrowLength = null;
             HTuple hv_PSize = null, hv_RowStart = null, hv_RowEnd = null;
             HTuple hv_ColStart = null, hv_ColEnd = null;
             // Initialize local and output iconic variables 
             HOperatorSet.GenEmptyObj(out ho_ObjectsArrow);
             HOperatorSet.GenEmptyObj(out ho_CProfile);
             HOperatorSet.GenEmptyObj(out ho_CArrow);
             HOperatorSet.GenEmptyObj(out ho_CMidPoint);
             hv_ArrowAngle = ((new HTuple(45)).TupleRad()) / 2;
             hv_ArrowLength = hv_Length1 * 0.2;
             hv_PSize = hv_Length2 * 0.2;
             hv_RowStart = hv_Row + ((hv_Phi.TupleSin()) * hv_Length1);
             hv_RowEnd = hv_Row - ((hv_Phi.TupleSin()) * hv_Length1);
             hv_ColStart = hv_Col - ((hv_Phi.TupleCos()) * hv_Length1);
             hv_ColEnd = hv_Col + ((hv_Phi.TupleCos()) * hv_Length1);

             ho_CProfile.Dispose();
             HOperatorSet.GenContourPolygonXld(out ho_CProfile, hv_RowStart.TupleConcat(hv_RowEnd),
                 hv_ColStart.TupleConcat(hv_ColEnd));
             ho_CArrow.Dispose();
             HOperatorSet.GenContourPolygonXld(out ho_CArrow, ((((hv_RowEnd - ((((hv_ArrowAngle - hv_Phi)).TupleSin()
                 ) * hv_ArrowLength))).TupleConcat(hv_RowEnd))).TupleConcat(hv_RowEnd + ((((hv_ArrowAngle + hv_Phi)).TupleSin()
                 ) * hv_ArrowLength)), ((((hv_ColEnd - ((((hv_ArrowAngle - hv_Phi)).TupleCos()) * hv_ArrowLength))).TupleConcat(
                 hv_ColEnd))).TupleConcat(hv_ColEnd - ((((hv_ArrowAngle + hv_Phi)).TupleCos()) * hv_ArrowLength)));

             ho_CMidPoint.Dispose();
             HOperatorSet.GenContourPolygonXld(out ho_CMidPoint, ((hv_Row - ((((((new HTuple(90)).TupleRad()
                 ) + hv_Phi)).TupleSin()) * hv_PSize))).TupleConcat(hv_Row - ((((hv_Phi - ((new HTuple(90)).TupleRad()
                 ))).TupleSin()) * hv_PSize)), ((hv_Col + ((((((new HTuple(90)).TupleRad()) + hv_Phi)).TupleCos()
                 ) * hv_PSize))).TupleConcat(hv_Col + ((((hv_Phi - ((new HTuple(90)).TupleRad()))).TupleCos()
                 ) * hv_PSize)));
             HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 2);
             HOperatorSet.SetColor(WindowControl.HalconWindow, "white");
             HOperatorSet.DispObj(ho_CProfile, WindowControl.HalconWindow);
             HOperatorSet.DispObj(ho_CArrow, WindowControl.HalconWindow);
             HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 1);
             HOperatorSet.SetColor(WindowControl.HalconWindow, "blue");
             HOperatorSet.DispObj(ho_CProfile, WindowControl.HalconWindow);
             HOperatorSet.DispObj(ho_CArrow, WindowControl.HalconWindow);
             ho_ObjectsArrow.Dispose();
             HOperatorSet.ConcatObj(ho_CArrow, ho_CProfile, out ho_ObjectsArrow);
             ho_CArrow.Dispose();
             ho_CProfile.Dispose();
             ho_CMidPoint.Dispose();
             return;
         }
         public HObject display_line(HTuple hv_RowEdge, HTuple hv_ColumnEdge, HTuple hv_len2, HTuple hv_ph1)
         {
             HTuple begin_row = hv_RowEdge - (hv_len2 * (new HTuple(hv_ph1).TupleCos()));
             HTuple begin_col = hv_ColumnEdge - (hv_len2 * (new HTuple((hv_ph1)).TupleSin()));
             HTuple end_row = hv_RowEdge + (hv_len2 * (new HTuple(hv_ph1).TupleCos()));
             HTuple end_col = hv_ColumnEdge + (hv_len2 * (new HTuple((hv_ph1)).TupleSin()));
             HObject xldLine1, xldLine2;
             HOperatorSet.GenEmptyObj(out xldLine1);
             HOperatorSet.GenEmptyObj(out xldLine2);
             xldLine1.Dispose();
             for (int i = 0; i < begin_row.Length; i++)
             {
                 HOperatorSet.GenContourPolygonXld(out xldLine1, ((begin_row.TupleSelect(i)).TupleConcat(end_row.TupleSelect(i))),
                                                    ((begin_col.TupleSelect(i))).TupleConcat(end_col.TupleSelect(i)));
                 HOperatorSet.ConcatObj(xldLine1, xldLine2, out xldLine2);
             }
             HOperatorSet.SetLineWidth(WindowControl.HalconWindow, 2);
             HOperatorSet.DispObj(xldLine2, WindowControl.HalconWindow);
             return xldLine2;
         }
    }
}
