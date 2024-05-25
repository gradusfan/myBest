using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using VisionTool.ImageToolDAL;


namespace XFF_Vision.frm_Tool
{
    public partial class frm_Calibration : Form
    {

        OpenFileDialog openFileDialogDescr = new OpenFileDialog();
        OpenFileDialog openFileDialogImg = new OpenFileDialog();
        FolderBrowserDialog folderBrowserDialogImg = new FolderBrowserDialog();
        CalibrationTool calibrationTool = new CalibrationTool();

        HObject ho_image;

        int currIdx;

        double mWidth;  // imageWidth 
        double mHeight; // imageHeight 

        string AreaScanDivision = "Area Scan(Division)";
        string AreaScanPolynomial = "Area Scan(Polynomial)";
        string LineScan = "Line Scan";

        double mThickness;    //标定板厚度
        double mCellWidth;    //Sx 
        double mCellHeight;   //Sy 
        double mFocalLength;  //远心
        double mKappa;        //畸变
        double mK1;           //径向2阶
        double mK2;           //径向4阶
        double mK3;           //径向6阶
        double mP1;           //切向2阶
        double mP2;           //切向4阶
    
        double mMotionVx;
        double mMotionVy;
        double mMotionVz;
        bool isTelecentric;  //远心

        public frm_Calibration()
        {
            InitializeComponent();

            mThickness = 1.00;       // millimeter
            mCellWidth = 8.300;         // micrometer
            mCellHeight = 8.300;        // micrometer
            mFocalLength = 8.000;          // millimeter
            isTelecentric = false;
            mKappa = 0.0;
            mK1 = 0.0;
            mK2 = 0.0;
            mK3 = 0.0;
            mP1 = 0.0;
            mP2 = 0.0;
            mMotionVx = 0.0;
            mMotionVy = 500.0;
            mMotionVz = 0.0;
        }
        private void frm_Calibration_Load(object sender, EventArgs e)
        {
            tabPage1.Parent = tabControl1;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
        }
        //标定板描述
        private void btnDescribeFile_Click(object sender, EventArgs e)
        {
            string file;
            string[] val;
            openFileDialogDescr.Filter = "标定文件（*.descr）|*.descr";
            if (openFileDialogDescr.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialogDescr.FileNames[0];
                if (file.EndsWith(".descr"))
                {
                    val = file.Split(new char[] { '\\' });
                    file = val[val.Length - 1];
                    tbxDescribeFile.Text = file;
                }
                else
                {
                    MessageBox.Show("文件格式是错误的，它不是描述文件!",
                                    "校准助手",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
        //相机类型
        private void cbxCamTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCameraParams(cbxCamTyp.Text);
            calibrationTool.CamType = cbxCamTyp.Text;
        }
        //像元芯片尺寸W
        private void nudChipPixWidth_ValueChanged(object sender, EventArgs e)
        {
          
        }
        //像元芯片尺寸H
        private void nudChipPixHight_ValueChanged(object sender, EventArgs e)
        {

        }
        //焦距
        private void nudFocus_ValueChanged(object sender, EventArgs e)
        {

        }
        //远心镜头
        private void cebxlongFocus_CheckedChanged(object sender, EventArgs e)
        {

        }
        //下一步
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabPage1.Parent = null;
            tabPage2.Parent = tabControl1;
            tabPage3.Parent = null;
        }
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            HObject ho_image;
            HOperatorSet.GenEmptyObj(out ho_image);
            string[] files;
            int count = 0;
            ListViewItem item;
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "图片(*.bmp)|*.bmp|图片(*.jpg)|*.jpg|图片(*.png)|*.png";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialogImg.FileNames;
                count = files.Length;
                for (int i = 0; i < count; i++)
                {
                    ho_image.Dispose();
                    HOperatorSet.ReadImage(out ho_image, files[i]);
                    item = new ListViewItem("");
                    item.SubItems.Add(files[i]);
                    item.SubItems.Add(calibrationTool.updateCaltab(ho_image, i));
                    lvCalibImg.Items.AddRange(new ListViewItem[] { item });
                }
            }
        }
        private void btnCalibration_Click(object sender, EventArgs e)
        {
            // areaScanPolyParameter
            // Focus 0, Kappa 1,Kappa 2,Kappa 3,P1 4,P1 5,Cx 6,Cy 7,ImageWidth 8,ImageHeight 9
            // areaScanParameter
            // Focus 0, Kappa 1,Cx 2,Cy 3,ImageWidth 4,ImageHeight 5
            try
            {
                calibrationTool.calibData(1);
                //标定结果显示
                tbxChipPixWidth.Text = Convert.ToString(calibrationTool.CamParam[6].F * 10000000); tbxChipPixWidth.Text = Convert.ToString(calibrationTool.CamParam[7].F * 10000000);
                tbxFocus.Text = Convert.ToString(calibrationTool.CamParam[0].F * 1000);
                tbxK1.Text = Convert.ToString(calibrationTool.CamParam[1].F);
                tbxK2.Text = Convert.ToString(calibrationTool.CamParam[2].F);
                tbxK3.Text = Convert.ToString(calibrationTool.CamParam[3].F);
                tbxP1.Text = Convert.ToString(calibrationTool.CamParam[4].F);
                tbxP2.Text = Convert.ToString(calibrationTool.CamParam[5].F);
                tbxCx.Text = Convert.ToString(calibrationTool.CamParam[7].F);
                tbxCy.Text = Convert.ToString(calibrationTool.CamParam[8].F);
                tbxImageWidth.Text = Convert.ToString(calibrationTool.CamParam[10].F);
                tbxImageHeight.Text = Convert.ToString(calibrationTool.CamParam[11].F);

                double err = calibrationTool.CalibrationError;
                tbxCalibrationStatus.Text= "标定成功";
                tbxCalibrationError.Text = Convert.ToString(Math.Round(err, 6));

                tbxCameraPoseX.Text = Convert.ToString(calibrationTool.CalibPose[0].F * 1000);
                tbxCameraPoseY.Text = Convert.ToString(calibrationTool.CalibPose[1].F * 1000);
                tbxCameraPoseZ.Text = Convert.ToString(calibrationTool.CalibPose[2].F * 1000);
                tbxCameraPoseX_R.Text = Convert.ToString(calibrationTool.CalibPose[3].F * 1000);
                tbxCameraPoseY_R.Text = Convert.ToString(calibrationTool.CalibPose[4].F * 1000);
                tbxCameraPoseZ_R.Text = Convert.ToString(calibrationTool.CalibPose[5].F * 1000);

                tabPage1.Parent = null;
                tabPage2.Parent = null;
                tabPage3.Parent = tabControl1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOriginImg_Click(object sender, EventArgs e)
        {
          
            int val = calibrationTool.mReferenceIndex;
            if (val > -1)
                lvCalibImg.Items[val].SubItems[0].Text = "";

            //calibrationTool.mReferenceIndex
            //mAssistant.setReferenceIdx(currIdx);
            lvCalibImg.Items[currIdx].SubItems[0].Text = "   *";
          
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {

        }

        private void cebxPlateRegion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cebxMarkCenter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cebxCoordSys_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboxPlateRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMarkCenters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxCoordSys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxDraw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudLineWidth_ValueChanged(object sender, EventArgs e)
        {

        }
        #region FilterSize
        private void nudFilterSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilterSizeTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnFilterSizeReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region MarkThresh
        private void nudMarkThresh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MarkThreshTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnMarkThreshReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region MinDiam
        private void nudMinDiam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinDiamTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnMinDiamReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region InitThresh
        private void nudInitThresh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitThreshTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnInitThreshReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region ThreshDecr
        private void nudThreshDecr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ThreshDecrTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnThreshDecrReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region MinThresh
        private void nudMinThresh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinThreshTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnMinThreshReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Smooth
        private void nudSmooth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SmoothTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnSmootingReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region MinContL
        private void nudMinContL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinContLTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnMinContLReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region MaxDiam
        private void nudMaxDiam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MaxDiamTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void btnMaxDiamReset_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /// <summary>
        /// 获取初始参数
        /// </summary>
        /// <param name="mCameraType"></param>
        /// <returns></returns>
        public HTuple getCameraParams(string mCameraType)
        {
            HTuple campar;
            int paramsListSize = 8;//面阵普通标定
            int offset = 0;
            bool areaScanPoly = false;
            if (mCameraType == AreaScanPolynomial)
            {
                paramsListSize = 12; //面阵高精度标定
                offset = 4;
                areaScanPoly = true;
            }
            paramsListSize += (mCameraType == LineScan) ? 3 : 0;//是线阵相机参数多拼接3个
            campar = new HTuple(paramsListSize);
            campar[0] = (isTelecentric ? 0.0 : mFocalLength / 1000.0);//是否远心
            if (areaScanPoly) //面阵高精度标定
            {
                campar[1] = mK1;
                campar[2] = mK2;
                campar[3] = mK3;
                campar[4] = mP1;
                campar[5] = mP2;
            }
            else
            {
                campar[1] = mKappa;//面阵普通标定
            }
            campar[2 + offset] = mCellWidth / 1000000.0;   // Sx -width   -> * 10^ -6 
            campar[3 + offset] = mCellHeight / 1000000.0;  // Sy -height  -> * 10^ -6 
            campar[4 + offset] = (double)mWidth * 0.5;                  // x -principal point 
            campar[5 + offset] = (double)Height * 0.5;                 // y -principal point 
            campar[6 + offset] = mWidth;                      // imagewidth 
            campar[7 + offset] = mHeight;                     // imageheight 
            if (paramsListSize == 11)
            {
                campar[8] = mMotionVx / 1000000.0;
                campar[9] = mMotionVy / 1000000.0;
                campar[10] = mMotionVz / 1000000.0;
                campar[5 + offset] = 0;     // y -principal point = 0 for line scan camera 
            }
            return campar;
        }

        private void lvCalibImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "";
            ListView.SelectedListViewItemCollection items = lvCalibImg.SelectedItems;

            foreach (ListViewItem item in items)
            {
                path = item.SubItems[1].Text;
                if (path != "")
                {
                    lvCalibImg.Items[currIdx].BackColor = System.Drawing.SystemColors.Window;
                    currIdx = lvCalibImg.Items.IndexOf(item);
                    lvCalibImg.Items[currIdx].BackColor = System.Drawing.SystemColors.Control;
                    ho_image.Dispose();
                    HOperatorSet.ReadImage(out ho_image, currIdx);
                    item.SubItems.Add(calibrationTool.updateCaltab(ho_image, currIdx));
                    break;
                }//if
            }//foreach
        }
    }
}
