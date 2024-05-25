using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XFF_vision;
using HalconDotNet;
using System.IO;
using VisionTool.ImageToolDAL;
using XFF_Vision;

namespace XFF_vision.frm_Tool
{
    public partial class frm_AcqFifo : Form
    {
        static frm_AcqFifo frm;
        CameraDAL camera = new CameraDAL();
        AcqFifoTool acqFifoTool = new AcqFifoTool();
        public delegate void HandleaCanel();
        public static event HandleaCanel eventCancel;
        public delegate void HandledSetVal(AcqFifoTool acqFifoTool);
        HandledSetVal handledSetVal;
        string imgPath;
        /// <summary>
        ///  单实例
        /// </summary>
        /// <param name="am"></param>
        /// <param name="setVal"></param>
        /// <returns></returns>
        public static frm_AcqFifo SingleShow(AcqFifoTool acqFifoTool, HandledSetVal setVal)
        {
            if (frm == null)//
            {
                frm = new frm_AcqFifo(acqFifoTool, setVal);
            }
            return frm;
        }
        public frm_AcqFifo(AcqFifoTool acqFifoTool, HandledSetVal handledSetVal)
        {
            InitializeComponent();
            this.handledSetVal = handledSetVal;
            DisplayVal(acqFifoTool);//显示参数
            SetVal(ref this.acqFifoTool);//设置参数
        }
        /// <summary>
        /// 显示参数
        /// </summary>
        /// <param name="acqFifoTool">参数</param>
        void DisplayVal(AcqFifoTool acqFifoTool)
        {
            try
            {
                int nameIndex = acqFifoTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = acqFifoTool.Names.Substring(nameIndex + 1, acqFifoTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;//工具名
                }
                else
                {
                    this.Text = acqFifoTool.Names;
                    tbxToolName.Text = acqFifoTool.Names;//工具名
                }
                cbxInterface.Text = acqFifoTool.CameraInterface;//相机接口
                cbxDevice.Text = acqFifoTool.Device;//相机设备
                cebxUseImg.Checked = acqFifoTool.IsUseImg;//使用本地图片
                cebkUseLoopImg.Checked = acqFifoTool.IsUseLoopImg;//本地图片循环
                nudExposureTime.Value = Convert.ToDecimal(acqFifoTool.ExposureTime.D);//曝光
                cebxGrab.Checked = acqFifoTool.IsGrabAsync;
                //tbxImgPath.Text = acqFifoTool.ImgPath;//图片文件路径
                if (acqFifoTool.ImgPath != null)
                {
                    int Index = acqFifoTool.ImgPath.LastIndexOf("\\");
                    imgPath = acqFifoTool.ImgPath.Substring(0, Index);//截取图片文件路径
                    tbxImgPath.Text = imgPath;//图片文件路径
                    addListImg(acqFifoTool.ImgPath);//图片加载到列表中
                }
            }
            catch { }
        }
        void SetVal(ref AcqFifoTool acqFifoTool)
        {
            acqFifoTool.Names = AcqFifoTool.Tool.采集图像.ToString() + "_" + tbxToolName.Text;
            acqFifoTool.CameraInterface = cbxInterface.Text;
            acqFifoTool.Device = cbxDevice.Text;
            acqFifoTool.IsUseImg = cebxUseImg.Checked;
            acqFifoTool.IsUseLoopImg = cebkUseLoopImg.Checked;
            acqFifoTool.ExposureTime = (double)nudExposureTime.Value;
            acqFifoTool.IsGrabAsync = cebxGrab.Checked;
            //acqFifoTool.ImgPath = tbxImgPath.Text;
            cebxGrab.Text = "同步采集";
            if (acqFifoTool.IsGrabAsync)
                cebxGrab.Text = "异步采集";
        }
        private void frm_AcqFifo_Load(object sender, EventArgs e)
        {try
            {
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.CenterToScreen();
                HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "blue");
                this.FormClosing += frm_AcqFifo_FormClosing;//注册窗口关闭事件
                this.camera.GetDeviceEvent += camera_GetDeviceEvent;//注册获取相机事件
                this.acqFifoTool.GrapImageEvent += acqFifoTool_GrapImageEvent; //注册采集图像事件
                this.acqFifoTool.WindowControl = halconView1.HWindowControl;
                this.halconView1.DispImage(acqFifoTool.OutImage, false);
                if (lbx_Image.Items.Count > 1)
                    lbx_Image.SelectedIndex = 0;
            }
            catch { }
        }
        void frm_AcqFifo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.acqFifoTool.CloseCamera();//关闭当前实例相机
            frm = null;
            //eventCancel();   //当前没有相机先取消
        }
        // 获取相机事件
        void acqFifoTool_GrapImageEvent(object sender, EventArgsDAL e)
        {
            if (e.AcqHandle)
            {
                btnOpenCamera.Text = "关闭相机";
                halconView1.DispImage(e.Image, false);
                //halconView1.FitImage();
            }
        }
        // 采集图像事件
        void camera_GetDeviceEvent(object sender, EventArgsDAL e)
        {
            try
            {
                cbxDevice.Items.Clear();
                lbxDevInfo.Items.Clear();
                string[] devinfo = e.InfoList;
                string[] device = e.DeviceList;
                for (int i = 0; i < devinfo.Length; i++)
                {
                    lbxDevInfo.Items.Add(devinfo[i]);//相机信息
                }
                if (device != null)
                {
                    for (int i = 0; i < device.Length; i++)
                    {
                        cbxDevice.Items.Add(device[i]);
                        cbxDevice.Text = device[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_OpenCamera_Click(object sender, EventArgs e)
        {
            if (btnOpenCamera.Text == "打开相机" && cbxInterface.Text != "" && cbxDevice.Text != "")
            {
                acqFifoTool.CameraInterface = cbxInterface.Text;
                acqFifoTool.Device = cbxDevice.Text;
                acqFifoTool.OpenCamera();
                btnOpenCamera.Text = "关闭相机";
            }
            else
            {
                btnOpenCamera.Text = "打开相机";
                acqFifoTool.CloseCamera();
            }
        }
        private void btn_GrapImage_Click(object sender, EventArgs e)
        {
            acqFifoTool.CameraInterface = cbxInterface.Text;
            acqFifoTool.Device = cbxDevice.Text;
            acqFifoTool.Run();
            btnOpenCamera.Text = "关闭相机";
        }
        private void btn_SnapImage_Click(object sender, EventArgs e)
        {
            acqFifoTool.CameraInterface = cbxInterface.Text;
            acqFifoTool.Device = cbxDevice.Text;
            acqFifoTool.OnceRun();
            btnOpenCamera.Text = "关闭相机";
        }
        private void btn_getCamera_Click(object sender, EventArgs e)
        {
            camera.CameraInterface = cbxInterface.Text;
            camera.Device = cbxDevice.Text;
            camera.GetDevice();
        }
        private void btn_selectdir_Click(object sender, EventArgs e)
        {
            if (cebxUseImg.Checked == false)
            {
                MessageBox.Show("使用本地图片,请打钩！");
                return;
            }
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = Application.StartupPath;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(fb.SelectedPath))
                {
                    imgPath = fb.SelectedPath;
                    tbxImgPath.Text = fb.SelectedPath;
                    addListImg(fb.SelectedPath);
                }
                else
                {
                    MessageBox.Show("打开无图片！");
                }
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (cebxUseImg.Checked == false)
            {
                MessageBox.Show("使用本地图片,请打钩！");
                return;
            }
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "图片(*.bmp)|*.bmp|图片(*.jpg)|*.jpg|图片(*.jp2)|*.jp2|图片(*.gif)|*.gif|图片(*.png)|*.png|图片(*.tif)|*.tif";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                this.acqFifoTool.ImgPath = openImage.FileName;
                this.acqFifoTool.run();
                this.halconView1.DispImage(acqFifoTool.OutImage, false);
                halconView1.FitImage();
            }
        }
        void addListImg(string path)
        {
            int Debug = path.LastIndexOf("Debug");//是否是debug下的文件
            try
            {
                if (Debug != -1)
                {
                    string bugPath = path.Substring(Debug + 5, path.Length - (Debug + 5));//截取Debug下的文件,例如 原路径 C://Debug//1
                    string NewImagePath = Application.StartupPath + bugPath;//复制到不同的文件夹,复制到D盘,替换新的路径,例如 d://Debug//1
                    if (bugPath.LastIndexOf(".") > 0)
                    {
                        int Index = NewImagePath.LastIndexOf("\\");
                        string tempImgPath = NewImagePath.Substring(0, Index);
                        path = tempImgPath;
                    }
                    else
                        path = NewImagePath;
                }
                else
                {
                    if (path.LastIndexOf(".") > 0)
                    {
                        int Index = path.LastIndexOf("\\");
                        string tempImgPath = path.Substring(0, Index);
                        path = tempImgPath;
                    }
                }
                string imgtype = "*.BMP|*.JPG|*.JP2|*.GIF|*.PNG|*.TIF";
                lbx_Image.Items.Clear();
                string[] ImageType = imgtype.Split('|');
                for (int i = 0; i < ImageType.Length; i++)
                {
                    string[] dirs = Directory.GetFiles(path, ImageType[i]);
                    foreach (string s in dirs)
                    {
                        lbx_Image.Items.Add(new FileInfo(s).Name);
                    }
                }
                foreach (TabPage tp in tabControl1.TabPages)
                {
                    if (tp.Text == "本地图片")
                    {
                        tabControl1.SelectedTab = tp;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("文件夹不存在图片！");
            }
        }
        private void btn_sure_Click(object sender, EventArgs e)
        {
            AcqFifoTool acqFifoTool = new AcqFifoTool();// 参数传出,必须实例,this.acqFifoTool参数传出报错
            try
            {
                this.acqFifoTool.CloseCamera();//关闭当前实例相机
                SetVal(ref acqFifoTool);
                int imageIndex = lbx_Image.SelectedIndex;
                if (imageIndex != -1)
                {
                    string listBox1_path = lbx_Image.Items[imageIndex].ToString();
                    acqFifoTool.ImgPath = imgPath + "\\" + listBox1_path;
                }
                else
                {
                    string listBox1_path = lbx_Image.Items[0].ToString();
                    acqFifoTool.ImgPath = imgPath + "\\" + listBox1_path;
                  //acqFifoTool.ImgPath = this.acqFifoTool.ImgPath;
                }
                handledSetVal(acqFifoTool);//
                this.Hide();
                frm = null;
            }
            catch
            {
                this.acqFifoTool.CloseCamera();//关闭当前实例相机
                SetVal(ref acqFifoTool);
                handledSetVal(acqFifoTool);//参数传出
                this.Hide();
                frm = null;
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            long timer = this.acqFifoTool.set_after();
            lblResult.Text = "FAIL";
            lblResult.BackColor = Color.Red;
            halconView1.ToolLable2.Text = "FAIL";
            halconView1.ToolLable2.ForeColor = Color.Red;
            if (this.acqFifoTool.ResultLogic)
            {
                lblResult.Text = "PASS";
                lblResult.BackColor = Color.LimeGreen;
                halconView1.ToolLable2.Text = "PASS";
                halconView1.ToolLable2.ForeColor = Color.Lime;
            }
            lblTimer.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
            halconView1.ToolLable3.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
            halconView1.DispImage(acqFifoTool.OutImage, true);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.acqFifoTool.CloseCamera();
                this.Hide();
                frm = null;
                eventCancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void cbx_interface_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.acqFifoTool.CameraInterface = cbxInterface.Text;
        }
        private void cbx_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.acqFifoTool.Device = cbxDevice.Text;
        }
        private void cek_boxUseImg_CheckedChanged(object sender, EventArgs e)
        {
            this.acqFifoTool.IsUseImg = cebxUseImg.Checked;
        }
        private void cek_useLoopImg_CheckedChanged(object sender, EventArgs e)
        {
            this.acqFifoTool.IsUseLoopImg = cebkUseLoopImg.Checked;
        }
        private void tbx_toolName_TextChanged(object sender, EventArgs e)
        {
            this.acqFifoTool.Names = ImageTool.Tool.采集图像.ToString() + "_" + tbxToolName.Text;
            this.Text = tbxToolName.Text;
        }
        private void lbx_Image_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int imageIndex = lbx_Image.SelectedIndex;
                string listBox1_path = lbx_Image.Items[imageIndex].ToString();
                this.acqFifoTool.ImgPath = imgPath + "\\" + listBox1_path;
                this.acqFifoTool.run();
                this.halconView1.DispImage(acqFifoTool.OutImage, false);
                halconView1.FitImage();
            }
            catch { }
        }



        private void nudExposureTime_ValueChanged(object sender, EventArgs e)
        {
            acqFifoTool.ExposureTime = (double)nudExposureTime.Value;
            acqFifoTool._ExposureTime();
        }

        private void ceboxGrab_CheckedChanged(object sender, EventArgs e)
        {
            acqFifoTool.IsGrabAsync = cebxGrab.Checked;
            cebxGrab.Text = "同步采集";
            if (acqFifoTool.IsGrabAsync)
                cebxGrab.Text = "异步采集";

        }

        private void btnRegisterImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("是否注册当前图像", "注册前图像", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    write_image(acqFifoTool.OutImage);
                    MessageBox.Show("注册当前图像成功!");
                }
            }
            catch
            {
                MessageBox.Show("注册当前图像失败");
            }
        }
        /// <summary>
        ///  写图片
        /// </summary>
        /// <param name="ho_Image">图片变量</param>
        public void write_image(HObject ho_Image)
        {
            string AppPath = Application.StartupPath;
            string savepath = AppPath +  @"\" +"RegisterImg";
            string filepath = savepath + @"\" + "Register.bmp";
            if (!Directory.Exists(savepath))
                Directory.CreateDirectory(savepath);
            if (ho_Image != null)
                HOperatorSet.WriteImage(ho_Image, "bmp", 0, filepath);

        }
    }
}
