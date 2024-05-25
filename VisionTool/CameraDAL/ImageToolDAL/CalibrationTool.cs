using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using HOperatorSet_EX;

namespace VisionTool.ImageToolDAL
{
    public class CalibrationTool : ImageTool
    {
        HObject ho_Caltab = null, ho_Cross = null, ho_Circle = null;
        HTuple hv_RCoord= new HTuple (),  hv_CCoord= new HTuple (), hv_StartPose=new HTuple();
        HTuple hv_StartCamPar = new HTuple();
        /// <summary>
        /// 开相机参数
        /// </summary>
        public HTuple StartCamPar
        {
            get { return hv_StartCamPar; }
            set { hv_StartCamPar = value; }
        }
        HTuple hv_CamParam = new HTuple();
        /// <summary>
        ///标定后的相机内参
        /// </summary>
        public HTuple CamParam
        {
            get { return hv_CamParam; }
            set { hv_CamParam = value; }
        }

        HTuple hv_CamPose = new HTuple();
        /// <summary>
        /// 标定姿态
        /// </summary>
        public HTuple CalibPose
        {
            get { return hv_CamPose; }
            set { hv_CamPose = value; }
        }

        HTuple hv_Error;
        /// <summary>
        ///标定平均误差
        /// </summary>
        public HTuple CalibrationError
        {
            get { return hv_Error; }
            set { hv_Error = value; }
        }

        HTuple hv_CalibDataID;
        /// <summary>
        /// 标定句柄
        /// </summary>
        public HTuple CalibDataID
        {
            get { return hv_CalibDataID; }
            set { hv_CalibDataID = value; }
        }
        HTuple hv_CaltabName;
        /// <summary>
        /// 标定板描述
        /// </summary>
        public HTuple CaltabName
        {
            get { return hv_CaltabName; }
            set { hv_CaltabName = value; }
        }
      

        string describeFile;
        /// <summary>
        /// 标定文件
        /// </summary>
        public string DescribeFile
        {
            get { return describeFile; }
            set { describeFile = value; }
        }
        string thickness;
        /// <summary>
        /// 标定板厚度
        /// </summary>
        public string Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }
        string camType;
        /// <summary>
        /// 相机类型
        /// </summary>
        public string CamType
        {
            get { return camType; }
            set { camType = value; }
        }
        string chipPixWidth;
        /// <summary>
        /// 单个像元的宽（Sx）
        /// </summary>
        public string ChipPixWidth
        {
            get { return chipPixWidth; }
            set { chipPixWidth = value; }
        }
        string chipPixHight;
        /// <summary>
        /// 单个像元的高（Sy）
        /// </summary>
        public string ChipPixHight
        {
            get { return chipPixHight; }
            set { chipPixHight = value; }

        }
        string focalLength;
        /// <summary>
        /// 焦距
        /// </summary>
        public string FocalLength
        {
            get { return focalLength; }
            set { focalLength = value; }
        }
        bool isTelecentri;
        /// <summary>
        /// 远心
        /// </summary>
        public bool IsTelecentri
        {
            get { return isTelecentri; }
            set { isTelecentri = value; }
        }
        string plateRegioColor = "green";
        /// <summary>
        /// 标定板区域颜色
        /// </summary>
        public string PlateRegionColor
        {
            get { return plateRegioColor; }
            set { plateRegioColor = value; }
        }
        string coordSysColor = "yellow";
        /// <summary>
        /// 3d坐标颜色
        /// </summary>
        public string CoordSysColor
        {
            get { return coordSysColor; }
            set { coordSysColor = value; }
        }
        string markCenterColor = "blue";
        /// <summary>
        /// 圆斑点区域颜色
        /// </summary>
        public string MarkCenterColor
        {
            get { return markCenterColor; }
            set { markCenterColor = value; }
        }
        bool isPlateRegion = true;
        /// <summary>
        /// 标定板区域
        /// </summary>
        public bool IsPlateRegion
        {
            get { return isPlateRegion; }
            set { isPlateRegion = value; }
        }
        bool isCoordSys = true;
        /// <summary>
        /// 3d坐标
        /// </summary>
        public bool IsCoordSys
        {
            get { return isCoordSys; }
            set { isCoordSys = value; }
        }
        bool isMarkCenter = true;
        /// <summary>
        /// 圆斑点区域
        /// </summary>
        public bool IsMarkCenter
        {
            get { return isMarkCenter; }
            set { isMarkCenter = value; }
        }
        string draw = Set_draw.margin.ToString();
        /// <summary>
        /// 区域轮廓/填充
        /// </summary>
        public string Draw
        {
            get { return draw; }
            set { draw = value; }
        }
        int lineWidth;
        /// <summary>
        /// 线宽
        /// </summary>
        public int LineWidth
        {
            get { return lineWidth; }
            set { lineWidth = value; }
        }
        int filterSize = 3;
        /// <summary>
        /// 高斯滤波尺寸
        /// </summary>
        public int FilterSize
        {
            get { return filterSize; }
            set { filterSize = value; }
        }
        int markThresh = 112;
        /// <summary>
        /// 标志点阀值
        /// </summary>
        public int MarkThresh
        {
            get { return markThresh; }
            set { markThresh = value; }
        }
        int minMarkDiam = 5;
        /// <summary>
        /// 标志点半径最小阀值
        /// </summary>
        public int MinMarkDiam
        {
            get { return minMarkDiam; }
            set { minMarkDiam = value; }
        }
        int initThresh = 128;
        /// <summary>
        /// 初始阀值
        /// </summary>
        public int InitThresh
        {
            get { return initThresh; }
            set { initThresh = value; }
        }
        int threshDecr = 10;
        /// <summary>
        /// 阀值递减
        /// </summary>
        public int ThreshDecr
        {
            get { return threshDecr; }
            set { threshDecr = value; }
        }
        int minThresh = 18;
        /// <summary>
        /// 最小阀值
        /// </summary>
        public int MinThresh
        {
            get { return minThresh; }
            set { minThresh = value; }
        }
        double smoothing = 0.9; 
        /// <summary>
        /// 平滑
        /// </summary>
        public double Smoothing
        {
            get { return smoothing; }
            set { smoothing = value; }
        }
        int minContL = 15;
        /// <summary>
        /// 最小长度
        /// </summary>
        public int MinContL
        {
            get { return minContL; }
            set { minContL = value; }
        }
        int maxMarkDiam = 100;
        /// <summary>
        /// 最大标志点半径
        /// </summary>
        public int MaxMarkDiam
        {
            get { return maxMarkDiam; }
            set { maxMarkDiam = value; }
        }
        string plateStatus;
        /// <summary>
        /// 图片状态
        /// </summary>
        public string mPlateStatus
        {
            get { return plateStatus; }
            set { plateStatus = value; }
        }
        string calibrationStatus;
        /// <summary>
        /// 标定状态
        /// </summary>
        public string CalibrationStatus
        {
            get { return calibrationStatus; }
            set { calibrationStatus = value; }
        }
        /// <summary>
        /// 参考位置
        /// </summary>
        public int mReferenceIndex
        { get;set;}




        #region 参数
        string imageName;
        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName
        {
            get { return imageName; }
            set { imageName = value; }
        }
        string name;
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names
        {
            get { return name; }
            set { name = value; }
        }
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
        #endregion
        public override string toolName()
        {
            return name;
        }
        public override long toolTimer()
        {
            return 0;
        }
        public override void recon()
        { }
        public override void ini()
        {
            Names = Tool.标定图像.ToString();
            ImageName = "采集图像0";
        }
        public override void draw_roi()
        { }
        public override void run()
        { }
        public override void dispresult()
        { }
        public override long set_after()
        { return 0; }

        /// <summary>
        /// 标定
        /// </summary>
        /// <param name="index">参考位置</param>
        public void calibData(int index)
        {
            calibData(hv_CalibDataID, index, out hv_Error, out hv_CamParam, out hv_CamPose);
        }
         void calibData(HTuple hv_CalibDataID, HTuple hv_index, out HTuple hv_Error,
                    out HTuple hv_CamParam, out HTuple hv_PoseCalib)
        {
            // Initialize local and output iconic variables 
            //标定误差
            HOperatorSet.CalibrateCameras(hv_CalibDataID, out hv_Error);
            //标定后的相机参数
            HOperatorSet.GetCalibData(hv_CalibDataID, "camera", 0, "params", out hv_CamParam);
            //设定参考位置0-1 第一张图片
            HOperatorSet.GetCalibData(hv_CalibDataID, "calib_obj_pose", (new HTuple(0)).TupleConcat(
                hv_index), "pose", out hv_PoseCalib);
           
        }

        /// <summary>
        /// 返回标定板状态
        /// </summary>
        /// <param name="ho_Image"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public string updateCaltab(HObject ho_Image,int index)
        {
            try
            {
                updateCaltab(ho_Image, out ho_Caltab, out ho_Cross, out ho_Circle,
                    hv_CalibDataID,hv_CaltabName, filterSize,
                    markThresh, minMarkDiam,
                    hv_StartCamPar,
                    initThresh,
                    threshDecr, minThresh, smoothing, minContL, maxMarkDiam, draw, index,
                    PlateRegionColor,
                    MarkCenterColor,
                    CoordSysColor,
                    WindowControl.HalconWindow,
                    out hv_RCoord, out hv_CCoord, out hv_StartPose);
                return "OK";
            }
            catch
            {
                return "ERR";
            }
        }
        void updateCaltab(HObject ho_Img, out HObject ho_Caltab, out HObject ho_Cross,
            out HObject ho_Circle, HTuple hv_CalibDataID, HTuple hv_CaltabName, HTuple hv_SizeGauss,
            HTuple hv_MarkThresh, HTuple hv_MinMarkDiam, HTuple hv_StartCamPar, HTuple hv_InitThresh,
            HTuple hv_ThreshDecr, HTuple hv_MinThresh, HTuple hv_Smoothing, HTuple hv_MinContLength,
            HTuple hv_MaxMarkDiam, HTuple hv_Draw, HTuple hv_index, HTuple hv_PlateRegion, HTuple hv_MarkCenter,
            HTuple hv_CoordSys, HTuple hv_WindowHandle, out HTuple hv_RCoord, out HTuple hv_CCoord,
            out HTuple hv_StartPose)
        {
         
                // Initialize local and output iconic variables 
                HOperatorSet.GenEmptyObj(out ho_Caltab);
                HOperatorSet.GenEmptyObj(out ho_Cross);
                HOperatorSet.GenEmptyObj(out ho_Circle);

                HOperatorSet.SetDraw(WindowControl.HalconWindow, "margin");
                HOperatorSet.SetColor(WindowControl.HalconWindow, hv_PlateRegion);
                //获取标定板边框
                ho_Caltab.Dispose();
                HOperatorSet.FindCaltab(ho_Img, out ho_Caltab, hv_CaltabName, hv_SizeGauss,
                    hv_MarkThresh, hv_MinMarkDiam);
                HOperatorSet.DispObj(ho_Caltab, WindowControl.HalconWindow);
                HOperatorSet.FindMarksAndPose(ho_Img, ho_Caltab, hv_CaltabName, hv_StartCamPar,
                    hv_InitThresh, hv_ThreshDecr, hv_MinThresh, hv_Smoothing, hv_MinContLength,
                    hv_MaxMarkDiam, out hv_RCoord, out hv_CCoord, out hv_StartPose);
                HOperatorSet.SetDraw(WindowControl.HalconWindow, hv_Draw);
                HOperatorSet.SetColor(WindowControl.HalconWindow, hv_MarkCenter);
                //获取标定板圆点
                ho_Cross.Dispose();
                HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RCoord, hv_CCoord, 6, 0.785398);
                ho_Circle.Dispose();
                HOperatorSet.GenCircle(out ho_Circle, hv_RCoord, hv_CCoord, HTuple.TupleGenConst(
                    new HTuple(hv_RCoord.TupleLength()), 3));
                HOperatorSet.DispObj(ho_Circle, WindowControl.HalconWindow);
                HOperatorSet.SetCalibDataObservPoints(hv_CalibDataID, 0, 0, hv_index, hv_RCoord,
                    hv_CCoord, "all", hv_StartPose);
                HOperatorSet.SetColor(WindowControl.HalconWindow, hv_CoordSys);
                HOperatorSet_Ex.disp_3d_coord_system(WindowControl.HalconWindow, hv_StartCamPar, hv_StartPose, 0.02);
             
  
        }

    }     
}
