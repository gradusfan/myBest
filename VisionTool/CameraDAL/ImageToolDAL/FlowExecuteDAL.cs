using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using XFF_Vision;

namespace VisionTool.ImageToolDAL
{
    public class FlowExecuteDAL
    {
        public string ImageName { get; set; }
        public string Imagetoo { get; set; }
        public FlowExecuteDAL()
        {   //Tast
        }
        //Imagetool it; //声明变量
        List<bool> allResultLogic = new List<bool>();
        public List<bool> AllResultLogic
        {
            get { return allResultLogic; }
            set { allResultLogic = value; }
        }
        //结果跟工具名返回
        Dictionary<string, bool> allResultLogic1 = new Dictionary<string, bool>();
        public Dictionary<string, bool> AllResultLogic1
        {
            get { return allResultLogic1; }
            set { allResultLogic1 = value; }
        }
        Dictionary<string, string> allResultLogic2 = new Dictionary<string, string>();
        public Dictionary<string, string> AllResultLogic2
        {
            get { return allResultLogic2; }
            set { allResultLogic2 = value; }
        }
        #region 公共字段 
        #region 点
        Dictionary<string, HTuple> dicRowPoint = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicRowPoint
        {
            get { return dicRowPoint; }
            set { dicRowPoint = value; }
        }

        Dictionary<string, HTuple> dicColPoint = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicColPoint
        {
            get { return dicColPoint; }
            set { dicColPoint = value; }
        }
        #endregion
        #region 找线
        Dictionary<string, HTuple> dicRow1Line = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicRow1Line
        {
            get { return dicRow1Line; }
            set { dicRow1Line = value; }
        }
        Dictionary<string, HTuple> dicRow2Line = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicRow2Line
        {
            get { return dicRow2Line; }
            set { dicRow2Line = value; }
        }
        Dictionary<string, HTuple> dicCol1Line = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicCol1Line
        {
            get { return dicCol1Line; }
            set { dicCol1Line = value; }
        }

        Dictionary<string, HTuple> dicCol2Line = new Dictionary<string, HTuple>();
        public Dictionary<string, HTuple> DicCol2Line
        {
            get { return dicCol2Line; }
            set { dicCol2Line = value; }
        }

        Dictionary<string, HObject> dicLines = new Dictionary<string, HObject>();
        public Dictionary<string, HObject> DicLines
        {
            get { return dicLines; }
            set { dicLines = value; }
        }
        #endregion
        #region 图像 
        Dictionary<string, HObject> collectiveImage = new Dictionary<string, HObject>();
        public Dictionary<string, HObject> CollectiveImage
        {
            get { return collectiveImage; }
            set { collectiveImage = value; }
        }
        // 区域 
        Dictionary<string, HObject> collectiveRegion = new Dictionary<string, HObject>();
        public Dictionary<string, HObject> CollectiveXld
        {
            get { return collectiveXld; }
            set { collectiveXld = value; }
        }
        //XLD
        Dictionary<string, HObject> collectiveXld = new Dictionary<string, HObject>();
        public Dictionary<string, HObject> CollectiveRegion
        {
            get { return collectiveRegion; }
            set { collectiveRegion = value; }
        }


        #endregion
        #region 仿射距

        Dictionary<string, List<HTuple>> dicFixHomMat2D = new Dictionary<string, List<HTuple>>();
        public Dictionary<string, List<HTuple>> DicFixHomMat2D
        {
            get { return dicFixHomMat2D; }
            set { dicFixHomMat2D = value; }
        }
        Dictionary<string, List<HTuple>> dicFixHomMat2D1 = new Dictionary<string, List<HTuple>>();
        public Dictionary<string, List<HTuple>> DicFixHomMat2D1
        {
            get { return dicFixHomMat2D1; }
            set { dicFixHomMat2D1 = value; }
        }
        public Dictionary<string, List<HTuple>> dicFixPhi = new Dictionary<string, List<HTuple>>();
        public Dictionary<string, List<HTuple>> DicFixPhi
        {
            get { return dicFixPhi; }
            set { dicFixPhi = value; }
        }

        #endregion
        #endregion
        #region 采集图像字段声明
        int numImage = 0;
        Dictionary<string, HObject> acqFifoImage = new Dictionary<string, HObject>();
        public Dictionary<string, HObject> AcqFifoImage
        {
            get { return acqFifoImage; }
            set { acqFifoImage = value; }
        }
        void ImageClear()
        {
            numImage = 0;
            collectiveImage.Clear();
            collectiveRegion.Clear();
            acqFifoImage.Clear();
        }
        #endregion
        #region 斑点工具字段声明
        int numBlob = 0;
        void BlobClear()
        {
            numBlob = 0;
        }
        #endregion
        #region 模板匹配工具字段声明
        int numModel = 0;

        Dictionary<string, HTuple> dicMRow = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicMRow
        {
            get { return dicMRow; }
            set { dicMRow = value; }
        }
        Dictionary<string, HTuple> dicMCol = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicMCol
        {
            get { return dicMCol; }
            set { dicMCol = value; }
        }
        Dictionary<string, HTuple> dicMPhi = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicMPhi
        {
            get { return dicMPhi; }
            set { dicMPhi = value; }
        }

        void PMAlignClear()
        {
            numModel = 0;
            dicMRow.Clear();
            dicMCol.Clear();
            dicMPhi.Clear();
        }
        #endregion
        #region 位置定位工具字段声明
        int numPose = 0;
        List<HTuple> HomMat2D = new List<HTuple>();
        List<HTuple> HomMat2D1 = new List<HTuple>();
        List<HTuple> Phi = new List<HTuple>();

        void FixtureClear()
        {
            HomMat2D.Clear();
            HomMat2D1.Clear();
            Phi.Clear();
            dicFixHomMat2D.Clear();//原图坐标跟随当前图坐标（仿射转换）
            dicFixHomMat2D1.Clear(); //当前图坐标跟随原图坐标（仿射转换）
            dicFixPhi.Clear();
            numPose = 0;
        }
        #endregion
        #region 找矩形工具字段声明
        int numfindReg2 = 0;
        Dictionary<string, HTuple> dicfindReg2Row = new Dictionary<string, HTuple>();
        Dictionary<string, HTuple> dicfindReg2Col = new Dictionary<string, HTuple>();
        void FindReg2Clear()
        {
            numfindReg2 = 0;
            dicfindReg2Row.Clear();
            dicfindReg2Col.Clear();
        }
        #endregion
        #region 找圆工具字段声明
        int numfitc = 0;
        Dictionary<string, HTuple> dicfitcRow = new Dictionary<string, HTuple>();
        Dictionary<string, HTuple> dicfitcCol = new Dictionary<string, HTuple>();
        void FitCircleClear()
        {
            numfitc = 0;
            dicfitcCol.Clear();
            dicfitcRow.Clear();
        }
        #endregion
        #region 找线工具字段声明
        int numfitl = 0;
        Dictionary<string, HTuple> dicfitlRow1 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfitlRow1
        {
            get { return dicfitlRow1; }
            set { dicfitlRow1 = value; }
        }
        Dictionary<string, HTuple> dicfitlCol1 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfitlCol1
        {
            get { return dicfitlCol1; }
            set { dicfitlCol1 = value; }
        }
        Dictionary<string, HTuple> dicfitlRow2 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfitlRow2
        {
            get { return dicfitlRow2; }
            set { dicfitlRow2 = value; }
        }
        Dictionary<string, HTuple> dicfitlCol2 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfitlCol2
        {
            get { return dicfitlCol2; }
            set { dicfitlCol2 = value; }
        }

        Dictionary<string, HObject> dicline = new Dictionary<string, HObject>();

        public Dictionary<string, HObject> Htline
        {
            get { return dicline; }
            set { dicline = value; }
        }


        Dictionary<string, HTuple> diclinerow = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> diclineRow
        {
            get { return diclinerow; }
            set { diclinerow = value; }
        }
        Dictionary<string, HTuple> diclinecol = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> diclineCol
        {
            get { return diclinecol; }
            set { diclinecol = value; }
        }

        Dictionary<string, HTuple> dicfitlAngle = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfitlAngle
        {
            get { return dicfitlAngle; }
            set { dicfitlAngle = value; }
        }

        void FitLineClear()
        {
            numfitl = 0;
            dicfitlCol1.Clear();
            dicfitlRow1.Clear();
            dicfitlCol2.Clear();
            dicfitlRow2.Clear();
            dicline.Clear();
            diclinecol.Clear();
            diclinerow.Clear();
            dicfitlAngle.Clear();
        }
        #endregion
        #region 找边工具字段声明
        int numfindedge = 0;
        Dictionary<string, HTuple> dicfindedgeRow1 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfindedgeRow1
        {
            get { return dicfitlRow1; }
            set { dicfitlRow1 = value; }
        }
        Dictionary<string, HTuple> dicfindedgeCol1 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfindedgeCol1
        {
            get { return dicfitlCol1; }
            set { dicfitlCol1 = value; }
        }
        Dictionary<string, HTuple> dicfindedgeRow2 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfindedgeRow2
        {
            get { return dicfitlRow2; }
            set { dicfitlRow2 = value; }
        }
        Dictionary<string, HTuple> dicfindedgeCol2 = new Dictionary<string, HTuple>();

        public Dictionary<string, HTuple> DicfindedgeCol2
        {
            get { return dicfitlCol2; }
            set { dicfitlCol2 = value; }
        }
        Dictionary<string, HObject> dicfindedge = new Dictionary<string, HObject>();

        public Dictionary<string, HObject> Dicfindedge
        {
            get { return dicfindedge; }
            set { dicfindedge = value; }
        }



        void FindedgeClear()
        {
            numfindedge = 0;
            dicfindedgeCol1.Clear();
            dicfindedgeRow1.Clear();
            dicfindedgeCol2.Clear();
            dicfindedgeRow2.Clear();
            dicfindedge.Clear();
        }
        #endregion
        #region 点到线工具字段声明
        int numpl = 0;
        void PointToLineClear()
        {
            numpl = 0;
        }
        #endregion
        #region 点到点工具字段声明
        int numpp = 0;
        void PointToPointClear()
        {
            numpp = 0;
        }
        #endregion
        #region 两线间距工具字段声明
        int numll = 0;
        void LineToLineClear()
        {
            numll = 0;
        }
        #endregion
        #region 两线夹角角度工具字段声明
        int numal = 0;
        void AngleLineToLineClear()
        {
            numal = 0;
        }
        #endregion
        #region 水平夹角角度工具字段声明
        int numapp = 0;
        void AnglePointToPointClear()
        {
            numapp = 0;
        }
        #endregion
        #region 字符识别工具字段声明
        int numocr = 0;
        void OcrClear()
        {
            numocr = 0;
        }


        #endregion
        #region 卡尺工具字段声明

        #endregion
        #region 一维码工具字段声明

        #endregion
        #region 二维码工具字段声明

        #endregion
        #region 找顶点工具字段声明
        int numCorner = 0;
        Dictionary<string, HTuple> dicCornerRow = new Dictionary<string, HTuple>();
        Dictionary<string, HTuple> dicCornerCol = new Dictionary<string, HTuple>();
        void CornerClear()
        {
            numCorner = 0;
            dicCornerCol.Clear();
            dicCornerRow.Clear();
        }
        #endregion
        #region 找交点工具字段声明
        int numIntersection = 0;
        Dictionary<string, HTuple> dicIntersectionRow = new Dictionary<string, HTuple>();
        Dictionary<string, HTuple> dicIntersectionCol = new Dictionary<string, HTuple>();

        void IntersectionClear()
        {
            numIntersection = 0;
            dicIntersectionCol.Clear();
            dicIntersectionRow.Clear();
        }
        #endregion
        #region 差异模板工具字段声明

        #endregion
        #region 图片转化工具字段声明
        int numTransImage = 0;
        void TransImageClear()
        {
            numTransImage = 0;
        }
        #endregion
        #region 区域形态学工具字段声明
        int numMorphology = 0;
        void MorphologyClear()
        {
            numMorphology = 0;
        }
        #endregion
        #region 创建区域工具字段声明
        int numRoiCreate = 0;
        void RoiCreateClear()
        {
            numRoiCreate = 0;
        }
        #endregion
        #region 合并区域工具字段声明
        int numRoiOpUnion = 0;
        void RoiOpUnionClear()
        {
            numRoiOpUnion = 0;
        }
        #endregion
        #region   性线预处理图片工具字段声明
        int numScaleImage = 0;
        void ScaleImageClear()
        {
            numScaleImage = 0;
        }
        #endregion
        #region   图片补正工具字段声明
        int numAffineTransImage = 0;
        void numAffineTransImageClear()
        {
            numAffineTransImage = 0;
        }

        #endregion
        #region   平滑图片工具字段声明

        int numSmoothImage = 0;
        void SmoothImageClear()
        {
            numSmoothImage = 0;
        }

        #endregion
        #region 均值滤波工具字段声明
        int numMeanImage = 0;
        void MeanImageClear()
        {
            numMeanImage = 0;
        }
        #endregion
        #region 中值滤波工具字段声明
        int numMedianImage = 0;
        void MedianImageClear()
        {
            numMedianImage = 0;
        }
        #endregion
        #region 顶帽工具字段声明
        int numGrayTophatImage = 0;
        void GrayTophatImageClear()
        {
            numGrayTophatImage = 0;
        }
        #endregion
        #region 增强图片工具字段声明

        int numEmphasizeImage = 0;
        void EmphasizeImageClear()
        {
            numEmphasizeImage = 0;
        }

        #endregion
        #region 图片取反工具字段声明
        int numInvertImage = 0;
        void InvertImageClear()
        {
            numInvertImage = 0;
        }
        #endregion
        #region 图片工具字段声明
        int numProjectiveTransImage = 0;
        void ProjectiveTransImageClear()
        {
            numProjectiveTransImage = 0;
        }
        #endregion
        #region 图片旋转工具字段声明
        int numRotateImage = 0;
        void RotateImageClear()
        {
            numRotateImage = 0;
        }
        #endregion
        #region 极坐标转化工具字段声明
        int numTransPolarImage = 0;
        void TransPolarClear()
        {
            numTransPolarImage = 0;
        }
        #endregion
        #region 清除字段数据
        public void Clear()
        {

            allResultLogic.Clear();
            allResultLogic1.Clear();
            allResultLogic2.Clear();
            ImageClear();
            BlobClear();
            PMAlignClear();
            FixtureClear();
            FindReg2Clear();
            FitCircleClear();
            FitLineClear();
            FindedgeClear();
            PointToLineClear();
            PointToPointClear();
            LineToLineClear();
            AnglePointToPointClear();
            AngleLineToLineClear();
            OcrClear();
            CornerClear();
            IntersectionClear();
            ScaleImageClear();
            SmoothImageClear();
            MeanImageClear();
            EmphasizeImageClear();
            InvertImageClear();
            ProjectiveTransImageClear();
            TransPolarClear();
            MedianImageClear();
            TransImageClear();
            RoiCreateClear();
            RoiOpUnionClear();
            MorphologyClear();
            numAffineTransImageClear();
            RotateImageClear();
        }
        #endregion
        #region 工具声明

        AcqFifoTool acqfifoTool;
        HalconScriptTool halconScriptTool;
        BlobTool blobTool;
        PMAlignTool pmalignTool;
        FixtureTool fixtureTool;
        FindRectangle2Tool findRectangle2Tool;
        FitCircleTool fitcirleTool;
        FitLineTool fitlineTool;
        FindEdgeTool findEdgeTool;
        DistancePointPointTool distancePpTool;
        DistancePointLineTool distancePlTool;
        DistanceLineLineTool distanceLlTool;
        DistanceAngleLineLineTool distanceALlTool;
        DistanceAnglePointPointTool distanceAPpTool;
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
        EmphasizeImageTool emphasizeImageTool;
        InvertImageTool invertImageTool;
        ProjectiveTransImageTool projectiveTransImageTool;
        TransPolarTool transPolarTool;
        ImageConvertTool transImageTool;
        RotateImageTool rotateImageTool;
        SerialPortTool serialPortTool;
        PatInspectTool patInspectTool;
        AffineTransImageTool affineTransImageTool;
        DetectScratchesTool detectScratchesTool;
        SurfaceStainsTool surfaceStainsTool;


        SurfaceBreachTool surfaceBreachTool;
        GridLineTool gridLineTool;

        SurfaceFlawTool surfaceFlawTool;
        _9PointCalibTool _9pointCalibTool;
        SaveImageTool saveImageTool;
        ColorExtractorTool colorExtractorTool;
        InspectionBallBondingTool inspectionBallBondingTool;
        MorphologyTool morphologyTool;
        GrayTophatTool grayTophatTool;
        RoiCreateTool roiCreateTool;
        RoiOpUnionTool roiOpUnionTool;
        RoiOpIntersectionTool roiOpIntersection;
        RoiOpDifferenceTool roiOpDifference;
        RoiOpXorTool roiOpXorTool;

        #endregion
        #region 执行流程工具
        public void flowExecute(ImageTool it)//执行流程
        {
            #region 采集图像
            if (it is AcqFifoTool)//采集图相
            {
                acqfifoTool = it as AcqFifoTool;
                acqfifoTool.run();
                string name = "采集图像";
                int nameIndex = acqfifoTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = acqfifoTool.Names.Substring(nameIndex + 1, acqfifoTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numImage.ToString(), acqfifoTool.OutImage);
                allResultLogic.Add(acqfifoTool.ResultLogic);
                allResultLogic1.Add(acqfifoTool.Names, acqfifoTool.ResultLogic);
                numImage++; //图片编号

            }
            #endregion
            #region 斑点分析
            if (it is BlobTool)//斑点分析
            {  //输入
                blobTool = it as BlobTool;
                blobTool.Image = collectiveImage;
                blobTool.DicHomMat2D = dicFixHomMat2D;
                blobTool.DicPhi = dicFixPhi;
                string name = ImageTool.Tool.斑点分析.ToString() + "0";
                blobTool.run();
                //  blob.dispresult();
                //输出
                int nameIndex = blobTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    name = blobTool.Names.Substring(nameIndex + 1, blobTool.Names.Length - (nameIndex + 1));
                    if (name == "无")
                    {
                        name = "斑点分析";
                    }
                }
                dicMRow.Add(name + numBlob.ToString(), blobTool.ResultRow);
                dicMCol.Add(name + numBlob.ToString(), blobTool.ResultCol);
                dicMPhi.Add(name + numBlob.ToString(), 0);

                collectiveRegion.Add(name + numBlob.ToString(), blobTool.OutRegion);
                numBlob++;
                allResultLogic.Add(blobTool.ResultLogic);
                allResultLogic1.Add(blobTool.Names, blobTool.ResultLogic);
                if (!blobTool.ResultLogic)
                {
                    string str = string.Format("检测内容:{0}  检测结果:{1}  检测上限:{2}  检测下限:{3}", blobTool.Names, blobTool.ResultArea, blobTool.HigAera, blobTool.LowAera);
                    allResultLogic2.Add(blobTool.Names, str);
                }
            }
            #endregion
            #region 脚本
            if (it is HalconScriptTool)//脚本
            {  //输入
                halconScriptTool = it as HalconScriptTool;
                halconScriptTool.Image = collectiveImage;
                halconScriptTool.run();
                // halconScriptTool.dispresult();
                //输出
                allResultLogic.Add(halconScriptTool.ResultLogic);
            }
            #endregion
            #region 模板匹配
            if (it is PMAlignTool)
            {   //输入
                string t = Imagetoo;
                if (t == null)
                    t = "0";
                pmalignTool = it as PMAlignTool;
                pmalignTool.Image = collectiveImage;
                pmalignTool.run1(t);
                // pmalign.dispresult();
                //输出
                string name = "模板匹配";
                int nameIndex = pmalignTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = pmalignTool.Names.Substring(nameIndex + 1, pmalignTool.Names.Length - (nameIndex + 1));
                dicMRow.Add(name + numModel.ToString(), pmalignTool.ResultRow);
                dicMCol.Add(name + numModel.ToString(), pmalignTool.ResultColumn);
                dicMPhi.Add(name + numModel.ToString(), pmalignTool.ResultAngle);
                allResultLogic.Add(pmalignTool.ResultLogic);
                allResultLogic1.Add(pmalignTool.Names, pmalignTool.ResultLogic);
                //输出缺口
                numModel++;
                if (pmalignTool.ResultLogic)
                {
                    string str = string.Format("检测内容:{0} 检测结果:{1} X{2} Y{3} U{4}", pmalignTool.Names, pmalignTool.ResultScore, pmalignTool.ResultRow.D.ToString("f3"), pmalignTool.ResultColumn.D.ToString("f3"), pmalignTool.ResultAngle.D.ToString("f3"));
                    allResultLogic2.Add(pmalignTool.Names, str);
                }
            }
            #endregion
            #region 位置定位
            if (it is FixtureTool)
            { //输入
                fixtureTool = it as FixtureTool;
                fixtureTool.HtRow = dicMRow;
                fixtureTool.HtCol = dicMCol;
                fixtureTool.HtPhi = UnionDictionary(dicMPhi, dicfitlAngle);
                fixtureTool.run();
                fixtureTool.dispresult();
                //输出
                string name = "位置定位";
                if (fixtureTool.HomMat2D != null)
                {

                    int nameIndex = fixtureTool.Names.LastIndexOf("_");
                    if (nameIndex != -1)
                        name = fixtureTool.Names.Substring(nameIndex + 1, fixtureTool.Names.Length - (nameIndex + 1));
                    HomMat2D = fixtureTool.HomMat2D;
                    HomMat2D1 = fixtureTool.HomMat2D1;
                    dicFixHomMat2D.Add(name + numPose.ToString(), HomMat2D);
                    dicFixHomMat2D1.Add(name + numPose.ToString(), HomMat2D1);
                }
                if (fixtureTool.Phi != null)
                {
                    Phi = fixtureTool.Phi;
                    dicFixPhi.Add(name + numPose.ToString(), Phi);
                }
                numPose++;
            }
            #endregion
            #region 找矩形
            if (it is FindRectangle2Tool)
            {//输入
                findRectangle2Tool = it as FindRectangle2Tool;
                findRectangle2Tool.Image = collectiveImage;
                findRectangle2Tool.DicHomMat2D = dicFixHomMat2D;
                findRectangle2Tool.DicPhi = DicFixPhi;
                findRectangle2Tool.run();
                //   findRectangle2.dispresult();
                //输出
                string name = "找矩形";
                int nameIndex = findRectangle2Tool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = findRectangle2Tool.Names.Substring(nameIndex + 1, findRectangle2Tool.Names.Length - (nameIndex + 1));
                allResultLogic.Add(findRectangle2Tool.ResultLogic);
                dicfindReg2Row.Add(name + numfindReg2.ToString(), findRectangle2Tool.ResultRow);
                dicfindReg2Col.Add(name + numfindReg2.ToString(), findRectangle2Tool.ResultColumn);
                numfindReg2++;
            }
            #endregion
            #region  找圆
            if (it is FitCircleTool)
            {//输入
                fitcirleTool = it as FitCircleTool;
                fitcirleTool.Image = collectiveImage;
                fitcirleTool.DicHomMat2D = dicFixHomMat2D;
                fitcirleTool.DictPhi = DicFixPhi;
                fitcirleTool.run();
                //  fitcirle.dispresult();
                //输出
                string name = "找圆";
                int nameIndex = fitcirleTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = fitcirleTool.Names.Substring(nameIndex + 1, fitcirleTool.Names.Length - (nameIndex + 1));
                allResultLogic.Add(fitcirleTool.ResultLogic);
                dicfitcRow.Add(name + numfitc.ToString(), fitcirleTool.ResultRowCenter);
                dicfitcCol.Add(name + numfitc.ToString(), fitcirleTool.ResultColCenter);
                //九点定位找点
                dicMRow.Add(name + numModel.ToString(), fitcirleTool.ResultRowCenter);
                dicMCol.Add(name + numModel.ToString(), fitcirleTool.ResultColCenter);
                numfitc++;
            }
            #endregion
            #region 找线
            if (it is FitLineTool)
            {   //输入
                fitlineTool = it as FitLineTool;
                fitlineTool.Image = collectiveImage;
                fitlineTool.DicHomMat2D = dicFixHomMat2D;
                fitlineTool.DicPhi = dicFixPhi;
                fitlineTool.run();
                //  fitline.dispresult();
                //输出
                string name = "找线";
                int nameIndex = fitlineTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = fitlineTool.Names.Substring(nameIndex + 1, fitlineTool.Names.Length - (nameIndex + 1));
                dicfitlRow1.Add(name + numfitl.ToString(), fitlineTool.ResultRow1);
                dicfitlCol1.Add(name + numfitl.ToString(), fitlineTool.ResultCol1);
                dicfitlRow2.Add(name + numfitl.ToString(), fitlineTool.ResultRow2);
                dicfitlCol2.Add(name + numfitl.ToString(), fitlineTool.ResultCol2);
                dicfitlAngle.Add(name + numfitl.ToString(), fitlineTool.ResultAngle);
                dicline.Add(name + numfitl.ToString(), fitlineTool.ResultLine);
                diclinerow.Add(name + numfitl.ToString(), fitlineTool.hv_Line_ResultRow);
                diclineCol.Add(name + numfitl.ToString(), fitlineTool.hv_Line_ResultCol);
                allResultLogic.Add(fitlineTool.ResultLogic);
                numfitl++;
                if (fitlineTool.ResultLogic)
                {
                    string str = string.Format("检测内容:{0} S_X{1} S_Y{2} E_X{3} E_Y{4} U{5}", fitlineTool.Names, fitlineTool.ResultRow1.D.ToString("f3"), fitlineTool.ResultCol1.D.ToString("f3"), fitlineTool.ResultRow2.D.ToString("f3"), fitlineTool.ResultCol2.D.ToString("f3"), fitlineTool.ResultAngle.D.ToString("f3"));
                    allResultLogic2.Add(fitlineTool.Names, str);
                }
            }
            #endregion
            #region 找边
            if (it is FindEdgeTool)
            {   //输入
                findEdgeTool = it as FindEdgeTool;
                findEdgeTool.Image = collectiveImage;
                findEdgeTool.DicHomMat2D = dicFixHomMat2D;
                findEdgeTool.DicPhi = dicFixPhi;
                findEdgeTool.run();
                //  fitline.dispresult();
                //输出
                string name = "找边";
                int nameIndex = findEdgeTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = findEdgeTool.Names.Substring(nameIndex + 1, findEdgeTool.Names.Length - (nameIndex + 1));

                dicfindedgeRow1.Add(name + numfindedge.ToString(), findEdgeTool.ResultRow1);
                dicfindedgeCol1.Add(name + numfindedge.ToString(), findEdgeTool.ResultCol1);
                dicfindedgeRow2.Add(name + numfindedge.ToString(), findEdgeTool.ResultRow2);
                dicfindedgeCol2.Add(name + numfindedge.ToString(), findEdgeTool.ResultCol2);
                dicfindedge.Add(name + numfindedge.ToString(), findEdgeTool.ResultLine);
                allResultLogic.Add(findEdgeTool.ResultLogic);
                allResultLogic1.Add(findEdgeTool.Names, findEdgeTool.ResultLogic);
                numfindedge++;

                if (findEdgeTool.ResultLogic)
                {
                    string str = string.Format("检测内容:{0}  起始点X:{1}  起始点Y:{2}  结束点X:{3}  结束点Y:{4}", findEdgeTool.Names, findEdgeTool.ResultCol1, findEdgeTool.ResultRow1, findEdgeTool.ResultCol2, findEdgeTool.ResultRow2);
                    allResultLogic2.Add(findEdgeTool.Names, str);
                }
            }
            #endregion
            #region 点到点
            if (it is DistancePointPointTool)
            {    //输入

                dicRowPoint = UnionDictionary(dicfitcRow, dicCornerRow, dicIntersectionRow, dicfindReg2Row);
                dicColPoint = UnionDictionary(dicfitcCol, dicCornerCol, dicIntersectionCol, dicfindReg2Col);
                distancePpTool = it as DistancePointPointTool;
                distancePpTool.Image = collectiveImage;
                distancePpTool.HtRowPoint = dicRowPoint;   //   点位
                distancePpTool.HtColPoint = dicColPoint;   //   点位
                distancePpTool.run();

                string name = "点到点";
                int nameIndex = distancePpTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = distancePpTool.Names.Substring(nameIndex + 1, distancePpTool.Names.Length - (nameIndex + 1));
                dicfitlRow1.Add(name + numpl.ToString(), distancePpTool.ResultRow1);
                dicfitlCol1.Add(name + numpl.ToString(), distancePpTool.ResultCol1);
                dicfitlRow2.Add(name + numpl.ToString(), distancePpTool.ResultRow2);
                dicfitlCol2.Add(name + numpl.ToString(), distancePpTool.ResultCol2);
                numpl++;

                //  distancePp.dispresult();
                allResultLogic.Add(distancePpTool.ResultLogic);
            }
            #endregion
            #region 点到线
            if (it is DistancePointLineTool)
            {   //输入
                dicRowPoint = UnionDictionary(dicfitcRow, dicCornerRow, dicIntersectionRow, dicfindReg2Row);
                dicColPoint = UnionDictionary(dicfitcCol, dicCornerCol, dicIntersectionCol, dicfindReg2Col);


                dicRow1Line = UnionDictionary(dicfitlRow1, dicfindedgeRow1);
                dicRow2Line = UnionDictionary(dicfitlRow2, dicfindedgeRow2);
                dicCol1Line = UnionDictionary(dicfitlCol1, dicfindedgeCol1);
                dicCol2Line = UnionDictionary(dicfitlCol2, dicfindedgeCol2);

                distancePlTool = it as DistancePointLineTool;

                distancePlTool.Image = collectiveImage;

                distancePlTool.HtRowPoint = dicRowPoint;   //   点位
                distancePlTool.HtColPoint = dicColPoint;   //   点位

                distancePlTool.HtRowLine1 = dicRow1Line;   //线
                distancePlTool.HtColLine1 = dicCol1Line;   //线
                distancePlTool.HtRowLine2 = dicRow2Line;   //线
                distancePlTool.HtColLine2 = dicCol2Line;   //线

                distancePlTool.run();
                //     distancePl.dispresult();
                allResultLogic.Add(distancePlTool.ResultLogic);
            }
            #endregion
            #region 两线间距
            if (it is DistanceLineLineTool)
            {   //输入
                dicLines = UnionDictionary(dicline, dicfindedge);
                distanceLlTool = it as DistanceLineLineTool;
                distanceLlTool.HRow1 = dicfitlRow1;
                distanceLlTool.HCol1 = dicfitlCol1;
                distanceLlTool.HRow2 = dicfitlRow2;
                distanceLlTool.HCol2 = dicfitlCol2;
                distanceLlTool.Image = collectiveImage;
                distanceLlTool.HtLine1 = dicLines;
                distanceLlTool.hv_LineCol1 = diclinecol;
                distanceLlTool.hv_LineRow1 = diclinerow;
                distanceLlTool.run();
                //  distanceLl.dispresult();
                string str = string.Format("检测内容:{0}  检测结果:{1}", distanceLlTool.Names, distanceLlTool.Distance);
                allResultLogic2.Add(distanceLlTool.Names, str);
                allResultLogic.Add(distanceLlTool.ResultLogic);
            }
            #endregion
            #region 水平夹角角度
            if (it is DistanceAnglePointPointTool)
            {    //输入
                distanceAPpTool = it as DistanceAnglePointPointTool;
                distanceAPpTool.Image = collectiveImage;


                dicRow1Line = UnionDictionary(dicfitlRow1, dicfindedgeRow1);
                dicRow2Line = UnionDictionary(dicfitlRow2, dicfindedgeRow2);
                dicCol1Line = UnionDictionary(dicfitlCol1, dicfindedgeCol1);
                dicCol2Line = UnionDictionary(dicfitlCol2, dicfindedgeCol2);

                distanceAPpTool.HtRowLine1 = dicRow1Line;     //线
                distanceAPpTool.HtColLine1 = dicCol1Line;
                distanceAPpTool.HtRowLine2 = dicRow2Line;
                distanceAPpTool.HtColLine2 = dicCol2Line;
                distanceAPpTool.run();
                // distanceAPp.dispresult();
                allResultLogic.Add(distanceAPpTool.ResultLogic);
            }
            #endregion
            #region 两线夹角角度
            if (it is DistanceAngleLineLineTool)
            {    //输入
                distanceALlTool = it as DistanceAngleLineLineTool;
                distanceALlTool.Image = collectiveImage;

                dicRow1Line = UnionDictionary(dicfitlRow1, dicfindedgeRow1);
                dicRow2Line = UnionDictionary(dicfitlRow2, dicfindedgeRow2);
                dicCol1Line = UnionDictionary(dicfitlCol1, dicfindedgeCol1);
                dicCol2Line = UnionDictionary(dicfitlCol2, dicfindedgeCol2);

                distanceALlTool.HtRowLine1 = dicRow1Line;     //线
                distanceALlTool.HtColLine1 = dicCol1Line;
                distanceALlTool.HtRowLine2 = dicRow2Line;
                distanceALlTool.HtColLine2 = dicCol2Line;
                distanceALlTool.run();
                //   distanceALl.dispresult();
                allResultLogic.Add(distanceALlTool.ResultLogic);
            }
            #endregion
            #region OCR字符识别
            if (it is OCRMaxTool)
            {
                ocrMaxTool = it as OCRMaxTool;
                ocrMaxTool.Image = collectiveImage;
                ocrMaxTool.Region = collectiveRegion;
                ocrMaxTool.DicHomMat2D = dicFixHomMat2D;
                ocrMaxTool.DicPhi = DicFixPhi;
                ocrMaxTool.run();
                //ocrMax.dispresult();
                allResultLogic.Add(ocrMaxTool.ResultLogic);
            }
            #endregion
            #region 卡尺测量
            if (it is CaliperTool)
            {
                caliperTool = it as CaliperTool;
                caliperTool.Image = collectiveImage;
                caliperTool.DicHomMat2D = dicFixHomMat2D;
                caliperTool.DicPhi = dicFixPhi;
                caliperTool.run();
                //     caliper.dispresult();
                allResultLogic.Add(caliperTool.ResultLogic);
                allResultLogic1.Add(caliperTool.Names, caliperTool.ResultLogic);
                string str = string.Format("检测内容:{0}  检测结果:{1}  检测上限:{2}  检测下限:{3}", caliperTool.Names, caliperTool.Distance, caliperTool.Hmeasure, caliperTool.Lmeasure);
                allResultLogic2.Add(caliperTool.Names, str);
            }
            #endregion
            #region 一维码
            if (it is BarcodeTool)
            {
                barcodeTool = it as BarcodeTool;
                barcodeTool.Image = collectiveImage;
                barcodeTool.DicHomMat2D = dicFixHomMat2D;
                barcodeTool.DicPhi = dicFixPhi;
                barcodeTool.run();
                //     barcodeTool.dispresult();
                allResultLogic.Add(barcodeTool.ResultLogic);
            }
            #endregion
            #region 二维码
            if (it is _2DSymbolTool)
            {
                _2dSymbolTool = it as _2DSymbolTool;
                _2dSymbolTool.Image = collectiveImage;
                _2dSymbolTool.DicHomMat2D = dicFixHomMat2D;
                _2dSymbolTool.DicPhi = dicFixPhi;
                _2dSymbolTool.run();
                //     _2dSymbol.dispresult();
                allResultLogic.Add(_2dSymbolTool.ResultLogic);

            }
            #endregion
            #region 找顶点
            if (it is FindCornerTool)
            {//输入
                findCornerTool = it as FindCornerTool;
                findCornerTool.Image = collectiveImage;
                findCornerTool.DicHomMat2D = dicFixHomMat2D;
                findCornerTool.DicPhi = dicFixPhi;
                findCornerTool.run();
                //  findCorner.dispresult();
                //输出
                string name = "找顶点";
                int nameIndex = findCornerTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = findCornerTool.Names.Substring(nameIndex + 1, findCornerTool.Names.Length - (nameIndex + 1));
                dicCornerRow.Add(name + numCorner.ToString(), findCornerTool.ResultRow);
                dicCornerCol.Add(name + numCorner.ToString(), findCornerTool.ResultColumn);
                //九点定位找点
                dicMRow.Add(name + numModel.ToString(), findCornerTool.ResultRow);
                dicMCol.Add(name + numModel.ToString(), findCornerTool.ResultColumn);
                allResultLogic.Add(findCornerTool.ResultLogic);
                numCorner++;
            }
            #endregion
            #region 两线交点
            if (it is IntersectionLinesTool)
            {//输入

                intersectionLinesTool = it as IntersectionLinesTool;
                intersectionLinesTool.Image = collectiveImage;

                dicRow1Line = UnionDictionary(dicfitlRow1, dicfindedgeRow1);
                dicRow2Line = UnionDictionary(dicfitlRow2, dicfindedgeRow2);
                dicCol1Line = UnionDictionary(dicfitlCol1, dicfindedgeCol1);
                dicCol2Line = UnionDictionary(dicfitlCol2, dicfindedgeCol2);


                intersectionLinesTool.HtRowLine1 = dicRow1Line;     //线
                intersectionLinesTool.HtColLine1 = dicCol1Line;
                intersectionLinesTool.HtRowLine2 = dicRow2Line;
                intersectionLinesTool.HtColLine2 = dicCol2Line;

                intersectionLinesTool.run();
                //     intersectionLines.dispresult();
                //输出
                dicIntersectionRow.Add("交点" + numIntersection.ToString(), intersectionLinesTool.Row);
                dicIntersectionCol.Add("交点" + numIntersection.ToString(), intersectionLinesTool.Col);
                //九点定位找点
                dicMRow.Add("交点" + numIntersection.ToString(), intersectionLinesTool.Row);
                dicMCol.Add("交点" + numIntersection.ToString(), intersectionLinesTool.Col);
                allResultLogic.Add(intersectionLinesTool.ResultLogic);
                allResultLogic1.Add(intersectionLinesTool.Names, intersectionLinesTool.ResultLogic);
                //输出缺口
                numIntersection++;
                if (intersectionLinesTool.ResultLogic)
                {
                    string str = string.Format("检测内容:{0} X{1} Y{2}", intersectionLinesTool.Names, intersectionLinesTool.Col.D.ToString("f3"), intersectionLinesTool.Row.D.ToString("f3"));
                    allResultLogic2.Add(intersectionLinesTool.Names, str);
                }
            }
            #endregion
            #region 图片转化
            if (it is ImageConvertTool)
            {
                transImageTool = it as ImageConvertTool;
                transImageTool.Image = collectiveImage;
                string name = ImageTool.Tool.彩色转HSV图像.ToString() + "0";
                transImageTool.run();
                //  transImage.dispresult();
                int nameIndex = transImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = transImageTool.Names.Substring(nameIndex + 1, transImageTool.Names.Length - (nameIndex + 1));
                if (transImageTool.OutImageGray != null)
                    collectiveImage.Add(name + "灰度" + numTransImage, transImageTool.OutImageGray);
                if (transImageTool.OutImageChanne1 != null)
                    collectiveImage.Add(name + "R通道" + numTransImage, transImageTool.OutImageChanne1);
                if (transImageTool.OutImageChanne2 != null)
                    collectiveImage.Add(name + "G通道" + numTransImage, transImageTool.OutImageChanne2);
                if (transImageTool.OutImageChanne3 != null)
                    collectiveImage.Add(name + "B通道" + numTransImage, transImageTool.OutImageChanne3);
                if (transImageTool.OutImageHue != null)
                    collectiveImage.Add(name + "H分量图" + numTransImage, transImageTool.OutImageHue);
                if (transImageTool.OutImageSaturation != null)
                    collectiveImage.Add(name + "S分量图" + numTransImage, transImageTool.OutImageSaturation);//饱和度
                if (transImageTool.OutImageIntensity != null)
                    collectiveImage.Add(name + "V分量图" + numTransImage, transImageTool.OutImageIntensity);
                numTransImage++;
            }
            #endregion
            #region 差异模板
            if (it is PatInspectTool)
            {
                patInspectTool = it as PatInspectTool;
                patInspectTool.Image = collectiveImage;
                patInspectTool.DicHomMat2D = dicFixHomMat2D;
                patInspectTool.DicHomMat2D1 = dicFixHomMat2D1;
                patInspectTool.DicPhi = dicFixPhi; ;
                patInspectTool.run();
                //      patInspect.dispresult();
                allResultLogic.Add(patInspectTool.ResultLogic);
            }
            #endregion
            #region 划痕提取
            if (it is DetectScratchesTool)
            {
                detectScratchesTool = it as DetectScratchesTool;
                detectScratchesTool.Image = collectiveImage;
                detectScratchesTool.DicHomMat2D = dicFixHomMat2D;
                detectScratchesTool.run();
                //     detectScratches.dispresult();
                allResultLogic.Add(detectScratchesTool.ResultLogic);
            }
            #endregion
            #region 脏污提取
            if (it is SurfaceStainsTool)
            {
                surfaceStainsTool = it as SurfaceStainsTool;
                surfaceStainsTool.Image = collectiveImage;
                surfaceStainsTool.DicHomMat2D = dicFixHomMat2D;
                surfaceStainsTool.run();
                //     surfaceStains.dispresult();
                allResultLogic.Add(surfaceStainsTool.ResultLogic);
            }
            #endregion


            #region 表面缺口提取
            if (it is SurfaceBreachTool)
            {
                surfaceBreachTool = it as SurfaceBreachTool;
                surfaceBreachTool.Image = collectiveImage;
                surfaceBreachTool.run();
                //     surfaceStains.dispresult();
                allResultLogic.Add(surfaceBreachTool.ResultLogic);
                allResultLogic1.Add(surfaceBreachTool.Names, surfaceBreachTool.ResultLogic);
            }
            #endregion
            #region 网格线检测
            if (it is GridLineTool)
            {
                gridLineTool = it as GridLineTool;
                gridLineTool.Image = collectiveImage;
                gridLineTool.run();
                //     surfaceStains.dispresult();
                allResultLogic.Add(gridLineTool.ResultLogic);
                allResultLogic1.Add(gridLineTool.Names, gridLineTool.ResultLogic);
            }
            #endregion


            #region 瑕疵提取
            if (it is SurfaceFlawTool)
            {
                surfaceFlawTool = it as SurfaceFlawTool;
                surfaceFlawTool.Image = collectiveImage;
                surfaceFlawTool.HtHomMat2D = dicFixHomMat2D;
                surfaceFlawTool.run();
                //       surfaceFlaw.dispresult();
                allResultLogic.Add(surfaceFlawTool.ResultLogic);
            }
            #endregion
            #region 焊点检测
            if (it is InspectionBallBondingTool)
            {
                inspectionBallBondingTool = it as InspectionBallBondingTool;
                inspectionBallBondingTool.Image = collectiveImage;
                inspectionBallBondingTool.HtHomMat2D = dicFixHomMat2D;
                inspectionBallBondingTool.run();
                //     inspectionBallBonding.dispresult();
                allResultLogic.Add(inspectionBallBondingTool.ResultLogic);
            }
            #endregion
            #region 九点标定
            if (it is _9PointCalibTool)
            {
                _9pointCalibTool = it as _9PointCalibTool;
                _9pointCalibTool.HtRow = dicMRow;
                _9pointCalibTool.HtCol = dicMCol;
                _9pointCalibTool.HtAngle = UnionDictionary(dicMPhi, dicfitlAngle);
                _9pointCalibTool.Image = collectiveImage;
                _9pointCalibTool.run();
                //_9pointCalib.dispresult();
                allResultLogic.Add(_9pointCalibTool.ResultLogic);
                allResultLogic1.Add(_9pointCalibTool.Names, _9pointCalibTool.ResultLogic);
                //机器人定位结果
                string str = string.Format("检测内容:{0} X{1} Y{2} U{3}", _9pointCalibTool.Names, _9pointCalibTool.Hv_Axis_X, _9pointCalibTool.Hv_Axis_Y, _9pointCalibTool.Hv_Axis_U);
                allResultLogic2.Add(_9pointCalibTool.Names, str);
                if (_9pointCalibTool.ResultLogic)
                {

                }
            }
            #endregion
            #region 颜色抽取
            if (it is ColorExtractorTool)
            {
                colorExtractorTool = it as ColorExtractorTool;
                colorExtractorTool.Image = collectiveImage;
                colorExtractorTool.DicHomMat2D = dicFixHomMat2D;
                colorExtractorTool.DicPhi = dicFixPhi;
                colorExtractorTool.run();
                //       colorExtractor.dispresult();
                allResultLogic.Add(colorExtractorTool.ResultLogic);

            }
            #endregion
            #region 串口
            if (it is SerialPortTool)
            {
                serialPortTool = it as SerialPortTool;
                serialPortTool.run();
            }
            #endregion
            #region 区域
            if (it is MorphologyTool)
            {
                morphologyTool = it as MorphologyTool;
                morphologyTool.Image = collectiveImage;
                morphologyTool.Region = collectiveRegion;
                string name = ImageTool.Tool.区域形态处理.ToString() + "0";
                morphologyTool.run();

                int nameIndex = morphologyTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = morphologyTool.Names.Substring(nameIndex + 1, morphologyTool.Names.Length - (nameIndex + 1));
                collectiveRegion.Add(name + numMorphology.ToString(), morphologyTool.OutRegion);
                numMorphology++;
            }

            #endregion
            #region 创建区域
            if (it is RoiCreateTool)
            {
                roiCreateTool = it as RoiCreateTool;
                roiCreateTool.Image = collectiveImage;
                roiCreateTool.Region = collectiveRegion;
                string name = ImageTool.Tool.区域创建.ToString() + "0";
                roiCreateTool.run();
                roiCreateTool.dispresult();
                int nameIndex = roiCreateTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = roiCreateTool.Names.Substring(nameIndex + 1, roiCreateTool.Names.Length - (nameIndex + 1));
                collectiveRegion.Add(name + numRoiCreate, roiCreateTool.OutRegion);
                numRoiCreate++;
            }
            #endregion
            #region 合并区域
            if (it is RoiOpUnionTool)
            {
                roiOpUnionTool = it as RoiOpUnionTool;
                roiOpUnionTool.Image = collectiveImage;
                roiOpUnionTool.Region = collectiveRegion;
                string name = ImageTool.Tool.区域合并.ToString() + "0";
                roiOpUnionTool.run();
                roiOpUnionTool.dispresult();
                int nameIndex = roiOpUnionTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = roiOpUnionTool.Names.Substring(nameIndex + 1, roiOpUnionTool.Names.Length - (nameIndex + 1));
                collectiveRegion.Add(name + numRoiOpUnion.ToString(), roiOpUnionTool.OutRegion);
                numRoiOpUnion++;
            }

            #endregion
            #region 性线收缩图片
            if (it is ScaleImageTool)//
            {
                scaleImageTool = it as ScaleImageTool;
                scaleImageTool.Image = collectiveImage;
                string name = ScaleImageTool.Tool.性线收缩图像.ToString() + "0";
                scaleImageTool.run();
                int nameIndex = scaleImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = scaleImageTool.Names.Substring(nameIndex + 1, scaleImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numScaleImage.ToString(), scaleImageTool.OutImage);
                allResultLogic.Add(scaleImageTool.ResultLogic);
                numScaleImage++; //图片编号
            }
            #endregion
            #region 图片补正
            if (it is AffineTransImageTool)//
            {
                affineTransImageTool = it as AffineTransImageTool;
                affineTransImageTool.Image = collectiveImage;
                affineTransImageTool.HtHomMat2D = dicFixHomMat2D;
                affineTransImageTool.HtHomMat2D1 = dicFixHomMat2D1;
                affineTransImageTool.HtPhi = dicFixPhi;
                string name = AffineTransImageTool.Tool.补正图像.ToString();
                affineTransImageTool.run();
                //    affineTransImage.dispresult();
                int nameIndex = affineTransImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = affineTransImageTool.Names.Substring(nameIndex + 1, affineTransImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numAffineTransImage.ToString(), affineTransImageTool.OutImage);
                allResultLogic.Add(affineTransImageTool.ResultLogic);
                numAffineTransImage++; //图片编号
            }
            #endregion
            #region 平滑图片
            if (it is SmoothImageTool)//
            {
                smoothImageTool = it as SmoothImageTool;
                smoothImageTool.Image = collectiveImage;
                string name = SmoothImageTool.Tool.平滑图像.ToString();
                smoothImageTool.run();
                int nameIndex = smoothImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = smoothImageTool.Names.Substring(nameIndex + 1, smoothImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numSmoothImage.ToString(), smoothImageTool.OutImage);
                allResultLogic.Add(smoothImageTool.ResultLogic);
                numSmoothImage++; //图片编号
            }
            #endregion
            #region 均值滤波图片
            if (it is MeanImageTool)//
            {
                meanImageTool = it as MeanImageTool;
                meanImageTool.Image = collectiveImage;
                string name = MeanImageTool.Tool.均值滤波图像.ToString();
                meanImageTool.run();
                int nameIndex = meanImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = meanImageTool.Names.Substring(nameIndex + 1, meanImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numMeanImage.ToString(), meanImageTool.OutImage);
                allResultLogic.Add(meanImageTool.ResultLogic);
                numMeanImage++; //图片编号
            }
            #endregion
            #region 中值滤波图片
            if (it is MedianImageTool)//
            {
                medianImageTool = it as MedianImageTool;
                medianImageTool.Image = collectiveImage;
                string name = MedianImageTool.Tool.中值滤波图像.ToString();
                medianImageTool.run();
                int nameIndex = medianImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = medianImageTool.Names.Substring(nameIndex + 1, medianImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numMedianImage.ToString(), medianImageTool.OutImage);
                allResultLogic.Add(medianImageTool.ResultLogic);
                numMedianImage++; //图片编号
            }
            #endregion
            #region 顶帽图片
            if (it is GrayTophatTool)//
            {
                grayTophatTool = it as GrayTophatTool;
                grayTophatTool.Image = collectiveImage;
                string name = ImageTool.Tool.顶帽处理图像.ToString();
                grayTophatTool.run();
                int nameIndex = grayTophatTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = grayTophatTool.Names.Substring(nameIndex + 1, grayTophatTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numGrayTophatImage.ToString(), grayTophatTool.OutImage);
                allResultLogic.Add(grayTophatTool.ResultLogic);
                numGrayTophatImage++; //图片编号
            }
            #endregion
            #region 增强图像图片
            if (it is EmphasizeImageTool)//
            {
                emphasizeImageTool = it as EmphasizeImageTool;
                emphasizeImageTool.Image = collectiveImage;
                string name = EmphasizeImageTool.Tool.增强图像.ToString();
                emphasizeImageTool.run();
                int nameIndex = emphasizeImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = emphasizeImageTool.Names.Substring(nameIndex + 1, emphasizeImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numEmphasizeImage.ToString(), emphasizeImageTool.OutImage);
                allResultLogic.Add(emphasizeImageTool.ResultLogic);
                numEmphasizeImage++; //图片编号
            }
            #endregion
            #region 图像取反
            if (it is InvertImageTool)// 
            {

                invertImageTool = it as InvertImageTool;
                invertImageTool.Image = collectiveImage;
                string name = ImageTool.Tool.取反图像.ToString();
                invertImageTool.run();
                int nameIndex = invertImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = invertImageTool.Names.Substring(nameIndex + 1, invertImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numInvertImage.ToString(), invertImageTool.OutImage);
                allResultLogic.Add(invertImageTool.ResultLogic);
                numInvertImage++; //图片编号

            }
            #endregion
            #region 投影图像
            if (it is ProjectiveTransImageTool)// 
            {
                projectiveTransImageTool = it as ProjectiveTransImageTool;
                projectiveTransImageTool.Image = collectiveImage;
                string name = ImageTool.Tool.投影图像.ToString();
                projectiveTransImageTool.run();
                int nameIndex = projectiveTransImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = projectiveTransImageTool.Names.Substring(nameIndex + 1, projectiveTransImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numProjectiveTransImage.ToString(), projectiveTransImageTool.OutImage);
                allResultLogic.Add(projectiveTransImageTool.ResultLogic);
                numProjectiveTransImage++; //图片编号
            }
            #endregion
            #region 图像旋转
            if (it is RotateImageTool)// 
            {

                rotateImageTool = it as RotateImageTool;
                rotateImageTool.Image = collectiveImage;
                string name = ImageTool.Tool.旋转图像.ToString();
                rotateImageTool.run();
                //rotateImage.dispresult();
                int nameIndex = rotateImageTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = rotateImageTool.Names.Substring(nameIndex + 1, rotateImageTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numRotateImage.ToString(), rotateImageTool.OutImage);
                allResultLogic.Add(rotateImageTool.ResultLogic);
                numRotateImage++; //图片编号

            }
            #endregion
            #region 图像极坐标转化
            if (it is TransPolarTool)// 
            {

                transPolarTool = it as TransPolarTool;
                transPolarTool.Image = collectiveImage;
                string name = ImageTool.Tool.极坐标变换图像.ToString();
                transPolarTool.run();
                int nameIndex = transPolarTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                    name = transPolarTool.Names.Substring(nameIndex + 1, transPolarTool.Names.Length - (nameIndex + 1));
                collectiveImage.Add(name + numTransPolarImage.ToString(), transPolarTool.OutImage);
                allResultLogic.Add(transPolarTool.ResultLogic);
                numTransPolarImage++; //图片编号

            }
            #endregion
            #region 图像保存图片
            if (it is SaveImageTool)
            {
                string t = ImageName;
                saveImageTool = it as SaveImageTool;
                saveImageTool.Image = collectiveImage;
                bool resultLogic = false;
                foreach (bool item in allResultLogic) //遍历工具结果
                {
                    if (item)  // 等于true
                        resultLogic = true;
                    else
                    {
                        resultLogic = false;
                        break;
                    }
                }
                if (!resultLogic)
                {
                    saveImageTool.toolRun("NG");
                }
                else
                {
                    saveImageTool.toolRun("");
                }
                // saveImageTool.run();
                //saveImageTool.toolRun(t);
            }
            #endregion
            #region 数据并集
            if (dicLines.Count < 1)//大于两条边
            {
                dicLines = UnionDictionary(dicline, dicfindedge);
            }
            if (dicRowPoint.Count < 1)//大于一个点
            {
                dicRowPoint = UnionDictionary(dicfitcRow, dicCornerRow, dicIntersectionRow, dicfindReg2Row);
                dicColPoint = UnionDictionary(dicfitcCol, dicCornerCol, dicIntersectionCol, dicfindReg2Col);
            }
            if (dicRow1Line.Count < 1)//大于两条边
            {
                dicRow1Line = UnionDictionary(dicfitlRow1, dicfindedgeRow1);
                dicRow2Line = UnionDictionary(dicfitlRow2, dicfindedgeRow2);
                dicCol1Line = UnionDictionary(dicfitlCol1, dicfindedgeCol1);
                dicCol2Line = UnionDictionary(dicfitlCol2, dicfindedgeCol2);
            }
            #endregion
        }
        #endregion

        /// <summary>
        /// 合并字典(HTuple)
        /// </summary>
        /// <param name="di"></param>
        /// <returns></returns>
        Dictionary<string, HTuple> UnionDictionary(params Dictionary<string, HTuple>[] di)
        {
            Dictionary<string, HTuple> dic = new Dictionary<string, HTuple>();
            for (int j = 0; j < di.Length; j++)
            {
                foreach (KeyValuePair<string, HTuple> itme in di[j])
                {
                    dic.Add(itme.Key, itme.Value);
                }
            }
            return dic;
        }
        /// <summary>
        /// 合并字典(HObject)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        Dictionary<string, HObject> UnionDictionary(params Dictionary<string, HObject>[] di)
        {
            Dictionary<string, HObject> dic = new Dictionary<string, HObject>();
            for (int j = 0; j < di.Length; j++)
            {
                foreach (KeyValuePair<string, HObject> itme in di[j])
                {
                    dic.Add(itme.Key, itme.Value);
                }
            }
            return dic;
        }
    }
}
