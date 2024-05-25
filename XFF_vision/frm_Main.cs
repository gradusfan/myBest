using HalconDotNet;
using HOperatorSet_EX;
using HslCommunication;
using HslCommunication.Profinet.Keyence;
using System;
using HslCommunication.Profinet.Omron;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewControl;
using VisionTool.ImageToolDAL;
using XFF_Vision.BLL;
using XFF_Vision.frm_Tool;

namespace XFF_Vision
{
    public partial class frm_Main : Form
    {
        bool isFormClosing = false;
        public static TextBox textBoX;
        #region 相机工具9个
        List<ImageTool> tool1 = new List<ImageTool>();
        List<ImageTool> tool2 = new List<ImageTool>();
        List<ImageTool> tool3 = new List<ImageTool>();
        List<ImageTool> tool4 = new List<ImageTool>();
        List<ImageTool> tool5 = new List<ImageTool>();
        List<ImageTool> tool6 = new List<ImageTool>();
        List<ImageTool> tool7 = new List<ImageTool>();
        List<ImageTool> tool8 = new List<ImageTool>();
        List<ImageTool> tool9 = new List<ImageTool>();



        /// <summary>
        /// 正焊接相机工具
        /// </summary>
        FlowExecuteDAL flowExecute1 = new FlowExecuteDAL();
        /// <summary>
        /// 负焊相机工具
        /// </summary>
        FlowExecuteDAL flowExecute2 = new FlowExecuteDAL();
        /// <summary>
        /// 正焊相机1工具
        /// </summary>
        FlowExecuteDAL flowExecute3 = new FlowExecuteDAL();
        /// <summary>
        /// 正焊接相机2工具
        /// </summary>
        FlowExecuteDAL flowExecute4 = new FlowExecuteDAL();
        /// <summary>
        /// 负焊相机1工具
        /// </summary>
        FlowExecuteDAL flowExecute5 = new FlowExecuteDAL();
        /// <summary>
        /// 负焊相机2工具
        /// </summary>
        FlowExecuteDAL flowExecute6 = new FlowExecuteDAL();
        /// <summary>
        /// 纠偏相机1工具
        /// </summary>
        FlowExecuteDAL flowExecute7 = new FlowExecuteDAL();
        /// <summary>
        /// 纠偏相机2工具
        /// </summary>
        FlowExecuteDAL flowExecute8 = new FlowExecuteDAL();
        /// <summary>
        /// 裁剪相机工具
        /// </summary>
        FlowExecuteDAL flowExecute9 = new FlowExecuteDAL();


        SocketSer2 socketSer2 = new SocketSer2();//下位机通讯



        List<bool> allResultLogic1 = new List<bool>();
        List<bool> allResultLogic2 = new List<bool>();
        List<bool> allResultLogic3 = new List<bool>();
        List<bool> allResultLogic4 = new List<bool>();
        List<bool> allResultLogic5 = new List<bool>();
        List<bool> allResultLogic6 = new List<bool>();
        List<bool> allResultLogic7 = new List<bool>();
        List<bool> allResultLogic8 = new List<bool>();
        List<bool> allResultLogic9 = new List<bool>();

        #endregion
        //生产计数
        /// <summary>
        /// 触发数 amm
        /// </summary>
        long _touchnumber = 0;
        /// <summary>
        /// 实际收到的触发数 相机1 2 amm
        /// </summary>
        long _givetouchnumber = 0;
        /// <summary>
        /// 实际收到的触发数 相机3 5 amm
        /// </summary>
        long _givetouchnumberCam3 = 0;

        Dictionary<string, List<XFF_Vision.ResultInfo>> resultDit = new Dictionary<string, List<XFF_Vision.ResultInfo>>();
        Stopwatch watch11 = new Stopwatch();

        HTuple acqHandle1;//相机采集句柄1
        public HTuple AcqHandle
        {
            get { return acqHandle1; }
            set { acqHandle1 = value; }
        }

        HTuple acqHandle2;//相机采集句柄1
        public HTuple AcqHandle2
        {
            get { return acqHandle2; }
            set { acqHandle2 = value; }
        }

        HTuple acqHandle3;//相机采集句柄3 相机3句柄
        public HTuple AcqHandle3
        {
            get { return acqHandle3; }
            set { acqHandle3 = value; }
        }

        HTuple acqHandle4;//相机采集句柄4 相机4句柄
        public HTuple AcqHandle4
        {
            get { return acqHandle4; }
            set { acqHandle4 = value; }
        }


        HTuple acqHandle5;//相机采集句柄5 相机5句柄
        public HTuple AcqHandle5
        {
            get { return acqHandle5; }
            set { acqHandle5 = value; }
        }


        HTuple acqHandle6;//相机采集句柄6 相机6句柄
        public HTuple AcqHandle6
        {
            get { return acqHandle6; }
            set { acqHandle6 = value; }
        }

        HTuple acqHandle7;//相机采集句柄7 相机7句柄
        public HTuple AcqHandle7
        {
            get { return acqHandle7; }
            set { acqHandle7 = value; }
        }


        HTuple acqHandle8;//相机采集句柄7 相机7句柄
        public HTuple AcqHandle8
        {
            get { return acqHandle8; }
            set { acqHandle8 = value; }
        }


        HTuple acqHandle9;//相机采集句柄7 相机7句柄
        public HTuple AcqHandle9
        {
            get { return acqHandle9; }
            set { acqHandle9 = value; }
        }








        bool isBusy1 = false;
        bool isBusy2 = false;

        public string productName = "";//产品名

        delegate void Run1Handle1();

        short[] arrDeviceValue1 = new short[7];


        bool bc;
        public string pathluj;// 托盘保存路径
        public SaveImageTool SaveImageTool = new SaveImageTool();
        public frm_SaveImage frm_SaveImage = new frm_SaveImage();
        frm_VisionRun frmTool;
        Thread camThread1;
        Thread camThread2;
        Thread ThreadLoad;
        private object listAddItemLook = new object();
        private object drawItemLook = new object();


        /// <summary>
        /// 数据
        /// </summary>
        private void DateLoad(object lab)
        {
            frm_Load fl = new frm_Load();
            fl.Lblinfo = (string)lab;
            fl.FormBorderStyle = FormBorderStyle.None;
            fl.StartPosition = FormStartPosition.CenterScreen;
            //  Application.Run(fl);
        }

        public frm_Main()
        {
            InitializeComponent();
            ThreadLoad = new Thread(new ParameterizedThreadStart(DateLoad));
            ThreadLoad.Start("软件启动中。。。。。");
            ThreadLoad.Abort();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            SocketSer2.UIINFO += ShowLog1;
            LoadProduct();
            LoadCamData();
            socketSer2.sock();
            this.CenterToScreen();
            this.Text = "通用平台视觉系统网上找的框架";
            HOperatorSet.SetWindowParam(halconView11.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView12.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView13.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView14.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView15.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView16.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView17.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView18.HalconWindow, "background_color", "cadet blue");
            HOperatorSet.SetWindowParam(halconView19.HalconWindow, "background_color", "cadet blue");
            productName = lblProName.Text;
            lblProName.Text = Product.Instance.CurrentModel;
            productName = lblProName.Text;

            //链接PLC
            //ConnectionMelsec();
            //加载产品列表
            this.cbxProductList.Items.Clear();
            for (int i = 0; i < Product.Instance.Models.Count; i++)
            {
                this.cbxProductList.Items.Add(Product.Instance.Models[i].ModelName);
            }
            cbxProductList.SelectedIndex = Product.Instance.GetModeIndexlbyName(Product.Instance.CurrentModel);


            //优化启动加载界面开一个后台线程
            Thread thread = new Thread(() =>
            {

                //ini();
                this.Invoke(new Action(() =>
                {
                    //加入要操作的控件
                    #region 视觉窗体自适应
                    halconView11.FitImage();
                    halconView12.FitImage();
                    halconView13.FitImage();
                    halconView14.FitImage();
                    halconView15.FitImage();
                    halconView16.FitImage();
                    halconView17.FitImage();
                    halconView18.FitImage();
                    halconView19.FitImage();

                    #endregion

                }));

            });
            thread.IsBackground = true;
            thread.Start();







        }

        /// <summary>
        /// 窗体载入前初始化相机
        /// </summary>
        void ini()
        {
            try
            {
                HObject ho_Image1 = null;
                bool b1 = ProgramBLL.OpenCamera(1, ref acqHandle1);
                string str1 = (acqHandle1 != null) ? "相机1-打开!" : "相机1-打开失败!\n";
                if (acqHandle1 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image1, acqHandle1);
                    halconView11.DispImage(ho_Image1, true);
                }
                ShowLog(str1);

                Thread.Sleep(2);





                HObject ho_Image2 = null;
                bool b2 = ProgramBLL.OpenCamera(2, ref acqHandle2);
                string str2 = (acqHandle2 != null) ? "相机2-打开!" : "相机2-打开失败!\n";
                if (acqHandle2 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image2, acqHandle2);
                    halconView12.DispImage(ho_Image2, true);
                }
                ShowLog(str2);

                Thread.Sleep(2);

                HObject ho_Image3 = null;
                bool b3 = ProgramBLL.OpenCamera(3, ref acqHandle3);
                string str3 = (acqHandle3 != null) ? "相机3-打开!" : "相机3-打开失败!\n";
                if (acqHandle3 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image3, acqHandle3);
                    halconView13.DispImage(ho_Image3, true);
                }
                ShowLog(str3);
                Thread.Sleep(2);



                HObject ho_Image4 = null;
                bool b4 = ProgramBLL.OpenCamera(4, ref acqHandle4);
                string str4 = (acqHandle4 != null) ? "相机4-打开!" : "相机4-打开失败!\n";
                if (acqHandle4 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image4, acqHandle4);
                    halconView14.DispImage(ho_Image4, true);
                }
                ShowLog(str4);



                HObject ho_Image5 = null;
                bool b5 = ProgramBLL.OpenCamera(5, ref acqHandle5);
                string str5 = (acqHandle5 != null) ? "相机5-打开!" : "相机5-打开失败!\n";
                if (acqHandle5 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image5, acqHandle5);
                    halconView15.DispImage(ho_Image5, true);
                }
                ShowLog(str5);
                Thread.Sleep(2);



                HObject ho_Image6 = null;
                bool b6 = ProgramBLL.OpenCamera(6, ref acqHandle6);
                string str6 = (acqHandle6 != null) ? "相机6-打开!" : "相机6-打开失败!\n";
                if (acqHandle6 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image6, acqHandle6);
                    halconView16.DispImage(ho_Image6, true);
                }
                ShowLog(str6);
                Thread.Sleep(2);


                HObject ho_Image7 = null;
                bool b7 = ProgramBLL.OpenCamera(7, ref acqHandle7);
                string str7 = (acqHandle7 != null) ? "相机7-打开!" : "相机7-打开失败!\n";
                if (acqHandle7 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image7, acqHandle7);
                    halconView17.DispImage(ho_Image7, true);
                }
                ShowLog(str7);
                Thread.Sleep(2);


                HObject ho_Image8 = null;
                bool b8 = ProgramBLL.OpenCamera(8, ref acqHandle8);
                string str8 = (acqHandle8 != null) ? "相机8-打开!" : "相机8-打开失败!\n";
                if (acqHandle8 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image8, acqHandle8);
                    halconView18.DispImage(ho_Image8, true);
                }
                ShowLog(str8);
                Thread.Sleep(2);

                HObject ho_Image9 = null;
                bool b9 = ProgramBLL.OpenCamera(9, ref acqHandle9);
                string str9 = (acqHandle9 != null) ? "相机9-打开!" : "相机9-打开失败!\n";
                if (acqHandle9 != null)
                {
                    HOperatorSet.GrabImage(out ho_Image9, acqHandle9);
                    halconView19.DispImage(ho_Image9, true);
                }
                ShowLog(str9);
                Thread.Sleep(2);




            }
            catch
            {
                MessageBox.Show("初始化失败!");
            }
        }

        private void ini1()
        {
            txt_AX.Text = Product.Instance.A_model_X;
            txt_AY.Text = Product.Instance.A_model_Y;
            txt_BX.Text = Product.Instance.B_model_X;
            txt_BY.Text = Product.Instance.B_model_Y;

        
        
        }








        void frmTool_OpencamEvent()
        {
            ThreadLoad = new Thread(DateLoad);
            ThreadLoad.Start();
            //ThreadLoad.Start("流程退出中>>>>>");
            ProgramBLL.OpenCamera(1, ref acqHandle1);
            //ProgramBLL.OpenCamera(2, ref acqHandle2);
            //ProgramBLL.OpenCamera(3, ref acqHandle3);
            //ProgramBLL.OpenCamera(4, ref acqHandle4);
            //ProgramBLL.OpenCamera(5, ref acqHandle5);
            //ProgramBLL.OpenCamera(6, ref acqHandle6);
            //ProgramBLL.OpenCamera(7, ref acqHandle7);
            //ProgramBLL.OpenCamera(8, ref acqHandle8);
            start();
            ThreadLoad.Abort();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "启动")
            {
                if (acqHandle1 == null)
                { ProgramBLL.OpenCamera(1, ref acqHandle1); }
                //if (acqHandle2 == null)
                //{ ProgramBLL.OpenCamera(2, ref acqHandle2); }
                //if (acqHandle3 == null)
                //{ ProgramBLL.OpenCamera(3, ref acqHandle3); }
                //if (acqHandle4 == null)
                //{ ProgramBLL.OpenCamera(4, ref acqHandle4); }
                //if (acqHandle5 == null)
                //{ ProgramBLL.OpenCamera(5, ref acqHandle5); }
                //if (acqHandle6 == null)
                //{ ProgramBLL.OpenCamera(6, ref acqHandle6); }
                //if (acqHandle7 == null)
                //{ ProgramBLL.OpenCamera(7, ref acqHandle7); }
                //if (acqHandle8 == null)
                //{ ProgramBLL.OpenCamera(8, ref acqHandle8); }    


                #region 清空基恩士PLC寄存器旧代码
                //MelsecMcNet.Write("D10756", 0);

                //MelsecMcNet.Write("D10758", 0);

                //MelsecMcNet.Write("D10760", 0);
                //MelsecMcNet.Write("D10754", 0); MelsecMcNet.Write("D10752", 0); MelsecMcNet.Write("D10750", (Int16)0);

                //MelsecMcNet.Write("D5756", 0);
                //MelsecMcNet.Write("D5758", 0);
                //MelsecMcNet.Write("D5760", 0);
                //MelsecMcNet.Write("D5754", 0); MelsecMcNet.Write("D5752", 0); MelsecMcNet.Write("D5750", (Int16)0);
                #endregion
                start();
            }
            else
            {
                stop();
            }
        }

        private void btnFlowEdit_Click(object sender, EventArgs e)
        {
            frmTool = new frm_VisionRun();

            if (btnRun.Text == "停止")
            {
                MessageBox.Show("相机运行中！禁止操作！");
                return;
            }

            ThreadLoad = new Thread(DateLoad);
            ThreadLoad.Start("流程编辑打开中>>>>>>>");
            //流程编辑打开关闭相机句柄，后期流程连不上
            if (acqHandle1 != null)
            {

                frmTool.hv_AcqHandle = acqHandle1;
                HOperatorSet.CloseFramegrabber(acqHandle1);
                acqHandle1 = null;
            }
            if (acqHandle2 != null)
            {

                frmTool.hv_AcqHandle = acqHandle2;
                HOperatorSet.CloseFramegrabber(acqHandle2);
                acqHandle2 = null;
            }

            if (acqHandle3 != null)
            {

                frmTool.hv_AcqHandle = acqHandle3;
                HOperatorSet.CloseFramegrabber(acqHandle3);
                acqHandle3 = null;
            }

            if (acqHandle4 != null)
            {

                frmTool.hv_AcqHandle = acqHandle4;
                HOperatorSet.CloseFramegrabber(acqHandle4);
                acqHandle4 = null;
            }

            if (acqHandle5 != null)
            {

                frmTool.hv_AcqHandle = acqHandle5;
                HOperatorSet.CloseFramegrabber(acqHandle5);
                acqHandle5 = null;
            }


            if (acqHandle6 != null)
            {

                frmTool.hv_AcqHandle = acqHandle6;
                HOperatorSet.CloseFramegrabber(acqHandle6);
                acqHandle6 = null;
            }

            if (acqHandle7 != null)
            {

                frmTool.hv_AcqHandle = acqHandle7;
                HOperatorSet.CloseFramegrabber(acqHandle7);
                acqHandle7 = null;
            }

            if (acqHandle8 != null)
            {

                frmTool.hv_AcqHandle = acqHandle8;
                HOperatorSet.CloseFramegrabber(acqHandle8);
                acqHandle8 = null;
            }

            if (acqHandle9 != null)
            {

                frmTool.hv_AcqHandle = acqHandle9;
                HOperatorSet.CloseFramegrabber(acqHandle9);
                acqHandle9 = null;
            }




            frmTool.OpencamEvent += frmTool_OpencamEvent;
            frmTool.fmain1 = this;
            frmTool.Tool_Path = Product.Instance.VisionPath + productName;
            frmTool.Show();
            ShowLog("打开-流程编辑!");
            ThreadLoad.Abort();
        }
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "停止")
            {
                MessageBox.Show("相机运行中！禁止操作！");
                return;
            }
            ProgramBLL.CloseCamera(tool1);

            ShowLog("打开-料号编辑!");
            new frm_EditProduct().ShowDialog();
            cbxProductList.Items.Clear();
            productName = "";
            for (int i = 0; i < Product.Instance.Models.Count; i++)
            {
                cbxProductList.Items.Add(Product.Instance.Models[i].ModelName);
            }

        }
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {

            #region 加入相机句柄检测 关闭软件时不让相机占用
            if (camThread1 != null && isBusy1 == true)
                camThread1.Abort();
            if (camThread2 != null && isBusy2 == true)
                camThread2.Abort();
            if (acqHandle1 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle1);
                acqHandle1 = null;
            }
            if (acqHandle2 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle2);
                acqHandle2 = null;
            }

            if (acqHandle3 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle3);
                acqHandle3 = null;
            }

            if (acqHandle4 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle4);
                acqHandle4 = null;
            }

            if (acqHandle5 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle5);
                acqHandle5 = null;
            }

            if (acqHandle6 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle6);
                acqHandle6 = null;
            }

            if (acqHandle7 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle7);
                acqHandle7 = null;
            }

            if (acqHandle8 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle8);
                acqHandle8 = null;
            }

            if (acqHandle9 != null)
            {
                HOperatorSet.CloseFramegrabber(acqHandle9);
                acqHandle9 = null;
            }

            //HOperatorSet.CloseFramegrabber(acqHandle3);
            //acqHandle3 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle4);
            //acqHandle4 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle5);
            //acqHandle5 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle6);
            //acqHandle6 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle7);
            //acqHandle7 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle8);
            //acqHandle8 = null;
            //HOperatorSet.CloseFramegrabber(acqHandle9);
            //acqHandle9 = null;

            SaveProduct();

            Application.Exit();

            #endregion

        }
        private void cbxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveProduct();

            lblProName.Text = cbxProductList.Text;
            productName = lblProName.Text;
            Product.Instance.CurrentModel = lblProName.Text;
            bc = true;
            //加载模板位置
            if (Product.Instance != null)
            {
                ModelConfig temp = Product.Instance.GetModelbyName(productName);

                txt_TemplateX.Text = temp.Template_X;
                txt_TemplateY.Text = temp.Template_Y;
                txt_TemplateU.Text = temp.Template_U;
                txt_tempRbt_X.Text = temp.Rbt_TemplateX;
                txt_tempRbt_Y.Text = temp.Rbt_TemplateY;
                txt_tempRbt_U.Text = temp.Rbt_TemplateU;
            }
        }
        int CamX, CamY;

        /// <summary>
        /// 相机
        /// </summary>
        /// <param name="camNo">相机编号</param>
        /// <param name="inval">IO输入信号BIN</param>
        private void progrom_run(int camNo, string inval)
        {
            switch (camNo)//
            {
                case 1:

                    string str_trigger1 = "1";//截取1#相机拍照            
                    if (str_trigger1 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView11, tool1, flowExecute1, camNo, productName, inval, CamX, CamY, ref acqHandle1);
                    }

                    break;
                case 2:

                    string str_trigger2 = "1";//截取1#相机拍照            
                    if (str_trigger2 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView12, tool2, flowExecute2, camNo, productName, inval, CamX, CamY, ref acqHandle2);
                    }

                    break;

                case 3:

                    string str_trigger3 = "1";//截取1#相机拍照            
                    if (str_trigger3 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView13, tool3, flowExecute3, camNo, productName, inval, CamX, CamY, ref acqHandle3);
                    }

                    break;

                case 4:

                    string str_trigger4 = "1";//截取1#相机拍照            
                    if (str_trigger4 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView14, tool4, flowExecute4, camNo, productName, inval, CamX, CamY, ref acqHandle4);
                    }

                    break;


                case 5:

                    string str_trigger5 = "1";//截取1#相机拍照            
                    if (str_trigger5 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView15, tool5, flowExecute5, camNo, productName, inval, CamX, CamY, ref acqHandle5);
                    }

                    break;

                case 6:

                    string str_trigger6 = "1";//截取1#相机拍照            
                    if (str_trigger6 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView16, tool6, flowExecute6, camNo, productName, inval, CamX, CamY, ref acqHandle6);
                    }

                    break;

                case 7:

                    string str_trigger7 = "1";//截取1#相机拍照            
                    if (str_trigger7 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView17, tool7, flowExecute7, camNo, productName, inval, CamX, CamY, ref acqHandle7);
                    }

                    break;

                case 8:

                    string str_trigger8 = "1";//截取1#相机拍照            
                    if (str_trigger8 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView18, tool8, flowExecute8, camNo, productName, inval, CamX, CamY, ref acqHandle8);
                    }

                    break;


                case 9:

                    string str_trigger9 = "1";//截取1#相机拍照            
                    if (str_trigger9 == "1")
                    {
                        //保存图片名称
                        //if (step1 == 1)
                        //    flowExecute1.ImageName = tPName.Text;
                        //摸版释放
                        flowExecute1.Imagetoo = "1";
                        progrom_run(halconView19, tool9, flowExecute9, camNo, productName, inval, CamX, CamY, ref acqHandle9);
                    }

                    break;


                default:
                    break;
            }
        }
        /// <summary>
        /// 程序运行
        /// </summary>
        /// <param name="tool">工具</param>
        /// <param name="productName">产品名</param>
        /// <param name="camNo">相机号</param>
        /// <param name="step">拍照步数</param>
        /// <param name="lblTimer">耗时标签</param>
        /// <param name="lblResult">结果输出标签</param>
        /// <param name="acqHandle">相机句柄</param>
        private void progrom_run(HalconView halconView, List<ImageTool> tool, FlowExecuteDAL flowExecute, int camNo, string productName, string step, int x, int y, ref HTuple acqHandle)
        {
            try
            {

                string imgKey = "";
                string imgKey1 = "";
                bool resultLogic = true;

                bool resultLogic1 = false;
                bool resultLogic2 = true;
                HTuple hv_Width = null, hv_Height = null;
                long timer;

                string toolPath = Product.Instance.VisionPath + productName + @"\" + step + ".vin";
                tool.Clear();
                tool = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具
                if (tool == null)
                    return;
                upDate(tool, halconView);//
                //开始检测
                ProgramBLL.Run(halconView, ref acqHandle, tool, flowExecute, out timer).ToString();
                if (timer > 190)
                {
                    if (camNo == 2 || camNo == 1)
                    {
                    }
                    //ShowLog(lbxInfo, string.Format("{0}{1}", "耗时:", timer.ToString()));
                    //MessageBox.Show("检测超时");
                    if (camNo == 3 || camNo == 4)
                    {
                    }
                }
                string str_timer = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");

                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet_Ex.set_display_font(halconView.HalconWindow, 12, "sans", "true", "false");//mono', 'sans', 'serif
                foreach (var item in flowExecute.CollectiveImage.Keys)
                {
                    imgKey = item.ToString();
                }
                HObject img = (HObject)flowExecute.CollectiveImage[imgKey];
                HOperatorSet.GetImageSize(img, out hv_Width, out hv_Height);

                string camno = camNo.ToString();
                if (!resultDit.ContainsKey(camno))
                    resultDit.Add(camno, new List<XFF_Vision.ResultInfo>());
                List<string> names = (from res in resultDit[camno]
                                      where res.Name != null
                                      select res.Name).ToList();
                foreach (var item1 in flowExecute.AllResultLogic1)
                {
                    string name = item1.Key.Split('_')[0];
                    bool havname = names.Exists(n => n.Equals(name));

                    if (item1.Value == false)
                    {
                        string temp = "";
                        if (!havname)
                        {
                            resultDit[camno].Add(new XFF_Vision.ResultInfo
                            {
                                Name = name,
                                UIName = item1.Key,
                                IsNum = true,
                                Num = 0
                            });
                            temp = "0";
                        }
                        else
                        {
                            foreach (var item in resultDit[camno])
                            {
                                if (item.Name.Equals(name))
                                {
                                    ++item.Num;
                                    temp = item.Num.ToString();
                                }
                            }
                        }

                        imgKey1 = imgKey1 + item1.Key + ":" + "NG".PadRight(15, ' ') + string.Format(" NG数: {0}", temp) + "\r\n";
                    }
                    if (item1.Value == true)
                    {
                        imgKey1 = imgKey1 + item1.Key + ":" + "OK" + "\r\n";
                    }
                }



                if (flowExecute.AllResultLogic.Count < 1)
                {

                    if (camNo == 1)

                        if (camNo == 2)

                            if (camNo == 3)

                                if (camNo == 4)



                                    halconView.ToolLable2.ForeColor = Color.Red;
                    halconView.ToolLable2.Text = " NG ";

                }
                foreach (bool item in flowExecute.AllResultLogic) //遍历工具bool结果
                {
                    if (item)  // 等于true
                        resultLogic = true;
                    else
                    {
                        resultLogic = false;
                        break;
                    }
                }
                string SS = string.Empty;
                foreach (var item in flowExecute.AllResultLogic2) //遍历工具s数据结果
                {
                    if (item.Value != "")  // 等于true
                        SS += item.Value;
                    // OutputMsg(listView11, item.Value, Color.Red);
                }
                if (resultLogic)              //结果OK实行
                {
                    if (camNo == 1)
                    {
                        foreach (var item in flowExecute.AllResultLogic2) //遍历工具s数据结果
                        {
                            if (item.Value != "")  // 等于true
                                SS += item.Value;
                            // OutputMsg(listView11, item.Value, Color.Red);
                        }

                    }
                    if (camNo == 2)
                    {

                    }
                    if (camNo == 3)
                    {



                    }
                    if (camNo == 4)
                    {


                    }
                    if (camNo == 5)
                    {



                    }
                    if (camNo == 6)
                    {


                    }
                    if (camNo == 7)
                    {



                    }
                    if (camNo == 8)
                    {



                    }
                    halconView.ToolLable2.ForeColor = Color.Lime;
                    halconView.ToolLable2.Text = " OK ";
                    HOperatorSet_Ex.disp_message(halconView.HalconWindow, imgKey1, ImageTool.CoordSystem.image.ToString(), y, x, ImageTool.ColorFul.red.ToString(), "false");

                    img.Dispose();
                    flowExecute.CollectiveImage[imgKey].Dispose();
                    halconView.Refresh();

                }
                else            //结果NG实行
                {
                    if (camNo == 1)
                    {



                    }



                    halconView.ToolLable2.ForeColor = Color.Red;
                    halconView.ToolLable2.Text = " NG ";
                    HOperatorSet_Ex.disp_message(halconView.HalconWindow, imgKey1, ImageTool.CoordSystem.image.ToString(), y, x, ImageTool.ColorFul.red.ToString(), "false");

                    img.Dispose();
                    flowExecute.CollectiveImage[imgKey].Dispose();
                    halconView.Refresh();

                }
                if (allResultLogic1.Count >= 2)
                {
                    if (allResultLogic1.Contains(false)) resultLogic1 = false; else resultLogic1 = true;
                    allResultLogic1.Clear();
                }
                if (allResultLogic2.Count >= 2)
                {
                    if (allResultLogic2.Contains(false)) resultLogic2 = false; else resultLogic2 = true;
                    allResultLogic2.Clear();
                }
                HOperatorSet_Ex.set_display_font(halconView.HalconWindow, 0, "sans", "true", "false");//mono', 'sans', 'serif
                                                                                                      //  HOperatorSet_Ex.disp_message(halconView.HalconWindow, string.Format("相机{0}>位置{1}>", camNo.ToString(), step.ToString()), ImageTool.CoordSystem.window.ToString(), halconView.Height - 50, 10, ImageTool.ColorFul.white.ToString(), ImageTool.ColorFul.blue.ToString());
                HSystem.SetSystem("flush_graphic", "false");
                flowExecute.CollectiveImage[imgKey].Dispose();
                img.Dispose();

            }
            catch
            {
                //MessageBox.Show("Task error!");
            }
        }

        private string ShowLog1(string str)
        {
            lock (listAddItemLook)
            {
                string dataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                lbxInfo.Items.Add(str.ToString().PadRight(15, ' ') + dataTime);
                lbxInfo.Refresh();
                if (lbxInfo.Items.Count > 2000)
                    lbxInfo.Items.Clear();
                //listbox.Items.RemoveAt(0);
                if (lbxInfo.Items.Count > 0)
                    lbxInfo.Scrollable = false;
                return "";
            }
        }
        void start()
        {
            try
            {
                if (lblProName.Text.Length < 0) /*(lblProName.Text.Length == 0)*/
                {
                    MessageBox.Show("选料号选择!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                btnRun.Text = "停止";

                #region MyRegion
                //if (acqHandle4 != null)
                //{
                //    //camThread4 = new Thread(cam_run4);
                //    //camThread4.IsBackground = true;
                //    ////camThread2.Priority = ThreadPriority.Highest;
                //    //camThread4.Start();
                //}
                //if (acqHandle5 != null)
                //{
                //    //camThread5 = new Thread(cam_run5);
                //    //camThread5.IsBackground = true;
                //    // camThread5.Priority = ThreadPriority.Lowest;
                //    // camThread5.Start();
                //}
                //if (acqHandle6 != null)
                //{
                //    camThread6 = new Thread(cam_run6);
                //    camThread6.IsBackground = true;
                //    camThread6.Priority = ThreadPriority.Lowest;
                //    camThread6.Start();
                //}
                //if (acqHandle7 != null)
                //{
                //    camThread7 = new Thread(cam_run7);
                //    camThread7.IsBackground = true;
                //    // camThread7.Start();
                //}
                //if (acqHandle8 != null)
                //{
                //    camThread8 = new Thread(cam_run8);
                //    camThread8.IsBackground = true;
                //    camThread8.Start();
                //}
                #endregion
                ShowLog("开始运行!");
            }
            catch
            {
                MessageBox.Show("开始运行 error!");
            }
        }
        void stop()
        {
            btnRun.Text = "启动";
            isBusy1 = false;
            ShowLog("停止运行!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="halconView"></param>
        void upDate(List<ImageTool> tool, HalconView halconView)
        {
            try
            {
                foreach (ImageTool it in tool)
                {


                    it.WindowControl = halconView.HWindowControl;
                    it.recon();
                }
                //if (it.WindowControl.HalconWindow == null)
                //{
                //    it.WindowControl= halconView.HWindowControl;
                //    it.recon();
                //}

            }
            catch { MessageBox.Show("数据读取失败!", "数据读取失败", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        void ioShow()
        {
            //IoCtrlBLL.IoShow(m_dev, iO_Ctrlcs1);
        }
        public bool SaveProduct()
        {
            //保存产品信息
            bool isok = false;
            try
            {
                Product.Instance.A_model_X = txt_AX.Text;
                Product.Instance.A_model_Y = txt_AY.Text;
                Product.Instance.B_model_X = txt_BX.Text;
                Product.Instance.B_model_Y = txt_BY.Text;



                //Product.Instance.Sever_IP = tPName.Text;
                Product.Instance.Robot_IP = txt_rbtIP.Text;
                Product.Instance.Robot_Prot = txt_rbtPort.Text;
                //Product.Instance.RotationCenter_X = txt_RCenterX.Text;
                //Product.Instance.RotationCenter_Y = txt_RCenterY.Text;

                int index = Product.Instance.GetModeIndexlbyName(productName);
                Product.Instance.Models[index].Template_X = txt_TemplateX.Text;
                Product.Instance.Models[index].Template_Y = txt_TemplateY.Text;
                Product.Instance.Models[index].Template_U = txt_TemplateU.Text;
                Product.Instance.Models[index].Rbt_TemplateX = txt_tempRbt_X.Text;
                Product.Instance.Models[index].Rbt_TemplateY = txt_tempRbt_Y.Text;
                Product.Instance.Models[index].Rbt_TemplateU = txt_tempRbt_U.Text;
                //B区
                Product.Instance.Models[index].BTemplate_X = txt_BTemplateX.Text;
                Product.Instance.Models[index].BTemplate_Y = txt_BTemplateY.Text;
                Product.Instance.Models[index].BTemplate_U = txt_BTemplateU.Text;
                Product.Instance.Models[index].BRbt_TemplateX = txt_BtempRbt_X.Text;
                Product.Instance.Models[index].BRbt_TemplateY = txt_BtempRbt_Y.Text;
                Product.Instance.Models[index].BRbt_TemplateU = txt_BtempRbt_U.Text;

                string path = @"D:\VisionConfig\Config.ztm";
                SerializeBLL.Write(Product.Instance, path);
                //BinaryFormatter bf = new BinaryFormatter();
                //FileStream s = File.OpenWrite(path);
                //bf.Serialize(s, Product.Instance);
                //s.Close();

                //保存检测记录
                string InfoPath = @"D:\VisionConfig\Info.ztm";
                SerializeBLL.Write(resultDit, InfoPath);

                //BinaryFormatter bf1 = new BinaryFormatter();
                //FileStream s1 = File.OpenWrite(InfoPath);
                //bf1.Serialize(s1, resultDit);
                //s1.Close();
                isok = true;
                bc = false;

            }
            catch (Exception ce)
            {
                MessageBox.Show("保产存品数据失败!");
            }

            return isok;
        }
        public bool LoadProduct()
        {
            if (!Directory.Exists(Product.Instance.VisionPath))
                Directory.CreateDirectory(Product.Instance.VisionPath);


            //读取产品信息
            bool isok = false;
            try
            {
                string path = @"D:\VisionConfig\";// Application.StartupPath + @"\files\11";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string ProductPath = path + @"Config.ztm";

                if (File.Exists(ProductPath))
                {
                    Product.Instance = (Product)SerializeBLL.Read(ProductPath);
                    //FileStream s = File.OpenRead(ProductPath);
                    //BinaryFormatter bf = new BinaryFormatter();
                    //Product.Instance = (Product)bf.Deserialize(s);
                    //s.Close();
                }

                string InfoPath = path + @"Info.ztm";
                if (File.Exists(InfoPath))
                {
                    resultDit = (Dictionary<string, List<XFF_Vision.ResultInfo>>)SerializeBLL.Read(InfoPath);

                    //FileStream s = File.OpenRead(InfoPath);
                    //BinaryFormatter bf = new BinaryFormatter();
                    //resultDit = (Dictionary<string, List<VisionPro.ResultInfo>>)bf.Deserialize(s);
                    //s.Close();
                }

                isok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载产品信息异常!" + ex);
                isok = false;
            }

            return isok;
        }

        private void lbxInfo_DrawItem(object sender, DrawItemEventArgs e)
        {
            drawItem(sender, e);
        }
        private void lbxLog1_DrawItem(object sender, DrawItemEventArgs e)
        {
            drawItem(sender, e);
        }

        /// <summary>
        /// 工具点坐标类
        /// </summary>
        public class Point
        {
            /// <summary>
            /// X坐标
            /// </summary>
            public double X { get; set; }
            /// <summary>
            /// Y坐标
            /// </summary>
            public double Y { get; set; }
        }
        //public string str
        //{
        //    get { return tPName.Text; }

        //    set { tPName.Text = value; }

        //}
        void drawItem(object sender, DrawItemEventArgs e)
        {
            lock (drawItemLook)
            {
                ListBox listBox = (ListBox)sender;
                if (e.Index >= 0)
                {
                    e.DrawBackground();
                    Brush mybsh = Brushes.Black;
                    // 判断是什么类型的标签  

                    if (listBox.Items[e.Index].ToString().IndexOf("NG") != -1)
                    {
                        mybsh = Brushes.Red;
                    }
                    else if (listBox.Items[e.Index].ToString().IndexOf("异常") != -1)
                    {
                        mybsh = Brushes.Red;
                    }
                    else if (listBox.Items[e.Index].ToString().IndexOf("失败") != -1)
                    {
                        mybsh = Brushes.Red;
                    }
                    else if (listBox.Items[e.Index].ToString().IndexOf("OK") != -1)
                    {
                        mybsh = Brushes.Green;
                    }
                    else if (listBox.Items[e.Index].ToString().IndexOf("打开") != -1)
                    {
                        mybsh = Brushes.Green;
                    }
                    else if (listBox.Items[e.Index].ToString().IndexOf("成功") != -1)
                    {
                        mybsh = Brushes.Green;
                    }
                    // 焦点框  
                    e.DrawFocusRectangle();
                    //文本   
                    e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, mybsh, e.Bounds, StringFormat.GenericDefault);
                }
            }
        }

        /*****2022/09/19 阿涛新增方法****/
        private void LoadCamData()
        {
            if (Product.Instance != null)
            {
                //tPName.Text = Product.Instance.Sever_IP;
                txt_rbtIP.Text = Product.Instance.Robot_IP;
                txt_rbtPort.Text = Product.Instance.Robot_Prot;
                ini1();


                //txt_RCenterX.Text = Product.Instance.RotationCenter_X;
                //txt_RCenterY.Text = Product.Instance.RotationCenter_Y;

                //dataGridView.Rows.Clear();

                //for (int i = 0; i < Product.Instance.Robot_X.Count; i++)
                //{
                //    dataGridView.Rows.Add();
                //    dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
                //    dataGridView.Rows[i].Cells[1].Value = Product.Instance.Robot_X[i];
                //    dataGridView.Rows[i].Cells[2].Value = Product.Instance.Robot_Y[i];
                //    dataGridView.Rows[i].Cells[3].Value = Product.Instance.Pixel_X[i];
                //    dataGridView.Rows[i].Cells[4].Value = Product.Instance.Pixel_Y[i];
                //}
                int index = Product.Instance.GetModeIndexlbyName(Product.Instance.CurrentModel);
                if (index < 0)
                    return;
                txt_TemplateX.Text = Product.Instance.Models[index].Template_X;
                txt_TemplateY.Text = Product.Instance.Models[index].Template_Y;
                txt_TemplateU.Text = Product.Instance.Models[index].Template_U;
                txt_tempRbt_X.Text = Product.Instance.Models[index].Rbt_TemplateX;
                txt_tempRbt_Y.Text = Product.Instance.Models[index].Rbt_TemplateY;
                txt_tempRbt_U.Text = Product.Instance.Models[index].Rbt_TemplateU;

                txt_BTemplateX.Text = Product.Instance.Models[index].BTemplate_X;
                txt_BTemplateY.Text = Product.Instance.Models[index].BTemplate_Y;
                txt_BTemplateU.Text = Product.Instance.Models[index].BTemplate_U;
                txt_BtempRbt_X.Text = Product.Instance.Models[index].BRbt_TemplateX;
                txt_BtempRbt_Y.Text = Product.Instance.Models[index].BRbt_TemplateY;
                txt_BtempRbt_U.Text = Product.Instance.Models[index].BRbt_TemplateU;
            }
        }

        private void btn_StartAutoCal_Click(object sender, EventArgs e)
        {
            //AutoCalibration();
        }

        /// <summary>
        /// 机械手短连接
        /// </summary>
        /// <param name="address">机械手IP</param>
        /// <param name="port">端口</param>
        /// <param name="code">内容</param>
        /// <param name="contime">超时</param>
        /// <returns></returns>
        public string GetRobot_Pos(string address = "192.168.3.101", int port = 10003, string code = "T", int contime = 5000)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(address);
                IPEndPoint ipe = new IPEndPoint(ip, port);

                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.ReceiveTimeout = contime;
                clientSocket.Connect(ipe);
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
                byte[] sendBytes = Encoding.ASCII.GetBytes(code);
                clientSocket.Send(sendBytes);

                bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
                recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
                //List<string> resl = recStr.Split(',').ToArray().ToList();
                //if (show) Tools.Print(string.Join("",resl));

                clientSocket.Close();

                return recStr;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        private void CS2_Click(object sender, EventArgs e)
        {
            progrom_run(1, "RUN");
            //progrom_run(2, "RUN2");
        }

        #region 相机自动标定流程

        /// <summary>
        /// 相机自动标定
        /// </summary>
        //public void AutoCalibration()
        //{
        //    try
        //    {
        //        #region 初始化变量
        //        Product.Instance.Robot_X.Clear();
        //        Product.Instance.Robot_Y.Clear();
        //        Product.Instance.Pixel_X.Clear();
        //        Product.Instance.Pixel_Y.Clear();
        //        dataGridView.Rows.Clear();
        //        List<ImageTool> temp = new List<ImageTool>();
        //        string toolPath = Product.Instance.VisionPath + productName + @"\RUN.vin";
        //        temp = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具
        //        _9PointCalibTool _9PointCalibTool = null;
        //        #endregion

        //        foreach (var item in temp)
        //        {
        //            if (item is _9PointCalibTool)
        //            {
        //                _9PointCalibTool = (_9PointCalibTool)item;
        //            }
        //        }
        //        _9PointCalibTool.PixelX = new HTuple();
        //        _9PointCalibTool.PixelY = new HTuple();
        //        _9PointCalibTool.AxisX = new HTuple();
        //        _9PointCalibTool.AxisY = new HTuple();
        //        for (int i = 0; i < 11; i++)
        //        {
        //            string pos = GetRobot_Pos(Product.Instance.Robot_IP, Convert.ToInt32(Product.Instance.Robot_Prot), "START\r\n");
        //            if (pos != "" && pos.Contains(','))
        //            {
        //                string[] tempPos = pos.Split(',');
        //                Product.Instance.Robot_X.Add(tempPos[0]);
        //                Product.Instance.Robot_Y.Add(tempPos[1]);
        //                progrom_run(1, "AutoCal");
        //                foreach (var item in flowExecute1.AllResultLogic2.Values)
        //                {
        //                    if (item == "")
        //                    {
        //                        MessageBox.Show("相机未能找到模板,请在流程编辑设定模板轮廓后重新标定!");
        //                        return;
        //                    }
        //                    string[] tempArray = item.Split(':');
        //                    string x = Convert.ToDouble(tempArray[4].Split(' ')[0]).ToString("0.000");
        //                    string y = Convert.ToDouble(tempArray[3].Split(' ')[0]).ToString("0.000");

        //                    Product.Instance.Pixel_X.Add(x);
        //                    Product.Instance.Pixel_Y.Add(y);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("机械手未返回坐标,请排除错误后重新点击自动标定!");
        //                return;
        //            }
        //            //九点标定数据
        //            if (i < 9)
        //            {
        //                _9PointCalibTool.PixelX = _9PointCalibTool.PixelX.TupleConcat(Convert.ToDouble(Product.Instance.Pixel_X[i]));
        //                _9PointCalibTool.PixelY = _9PointCalibTool.PixelY.TupleConcat(Convert.ToDouble(Product.Instance.Pixel_Y[i]));
        //                _9PointCalibTool.AxisX = _9PointCalibTool.AxisX.TupleConcat(Convert.ToDouble(Product.Instance.Robot_X[i]));
        //                _9PointCalibTool.AxisY = _9PointCalibTool.AxisY.TupleConcat(Convert.ToDouble(Product.Instance.Robot_Y[i]));
        //            }

        //            dataGridView.Rows.Add();
        //            dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
        //            dataGridView.Rows[i].Cells[1].Value = Product.Instance.Robot_X[i];
        //            dataGridView.Rows[i].Cells[2].Value = Product.Instance.Robot_Y[i];
        //            dataGridView.Rows[i].Cells[3].Value = Product.Instance.Pixel_X[i];
        //            dataGridView.Rows[i].Cells[4].Value = Product.Instance.Pixel_Y[i];

        //            Thread.Sleep(300);
        //            Application.DoEvents();
        //        }

        //        //标定
        //        _9PointCalibTool.gen_calib_data();
        //        if (_9PointCalibTool.HomMat2D == null)
        //        {
        //            MessageBox.Show("标定数据错误,无法完成标定!");
        //            return;
        //        }

        //        //计算旋转中心
        //        PointF template = new PointF(Convert.ToSingle(Product.Instance.Pixel_X[9]), Convert.ToSingle(Product.Instance.Pixel_Y[9]));
        //        PointF R_template = new PointF(Convert.ToSingle(Product.Instance.Pixel_X[10]), Convert.ToSingle(Product.Instance.Pixel_Y[10]));
        //        PointF Rotate = new PointF();

        //        double tempR = 30 / Math.PI * 180;

        //        GetCircular(template, R_template, tempR, ref Rotate);

        //        HTuple Rotate_X, Rotate_Y;
        //        HOperatorSet.AffineTransPoint2d(_9PointCalibTool.HomMat2D, Rotate.X, Rotate.Y, out Rotate_X, out Rotate_Y);
        //        HTuple template_X, template_Y;
        //        HOperatorSet.AffineTransPoint2d(_9PointCalibTool.HomMat2D, template.X, template.Y, out template_X, out template_Y);
        //        HTuple Rtemplate_X, Rtemplate_Y;
        //        HOperatorSet.AffineTransPoint2d(_9PointCalibTool.HomMat2D, R_template.X, R_template.Y, out Rtemplate_X, out Rtemplate_Y);


        //        //double newX = Convert.ToDouble(Product.Instance.Robot_X[9]) - template_X.D + Rotate_X.D;
        //        //double newY = Convert.ToDouble(Product.Instance.Robot_Y[9]) - template_Y.D + Rotate_Y.D;



        //        _9PointCalibTool.tbxWorldX2 = template_X.D.ToString();
        //        _9PointCalibTool.tbxWorldX3 = Rtemplate_X.D.ToString();
        //        _9PointCalibTool.tbxWorldrX = Rotate_X.D.ToString();
        //        _9PointCalibTool.tbxWorldY2 = template_Y.D.ToString();
        //        _9PointCalibTool.tbxWorldY3 = Rtemplate_Y.D.ToString();
        //        _9PointCalibTool.tbxWorldrY = Rotate_Y.D.ToString();

        //        for (int i = 0; i < temp.Count; i++)
        //        {
        //            if (temp[i] is _9PointCalibTool)
        //            {
        //                temp[i] = _9PointCalibTool;
        //                break;
        //            }
        //        }
        //        SerializeBLL.Write(temp, toolPath);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("自动标定异常:" + ex.Message);
        //    }
        //}
        /// <summary>
        /// 获取模板位置
        /// </summary>
        //public void GetTemplatePOS()
        //{
        //    try
        //    {
        //        progrom_run(1, "RUN");
        //        List<ImageTool> temp = new List<ImageTool>();
        //        string toolPath = Product.Instance.VisionPath + productName + @"\RUN.vin";
        //        temp = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具
        //        _9PointCalibTool _9PointCalibTool = null;
        //        foreach (var item in temp)
        //        {
        //            if (item is _9PointCalibTool)
        //            {
        //                _9PointCalibTool = (_9PointCalibTool)item;
        //            }
        //        }
        //        string x = "";
        //        string y = "";
        //        string u = "";
        //        foreach (var item in flowExecute1.AllResultLogic2.Values)
        //        {
        //            if (item != "" && item.Contains("匹配"))
        //            {
        //                string[] tempArray = item.Split(':');
        //                u = Convert.ToDouble(tempArray[5].Split(' ')[0]).ToString("0.000");
        //            }
        //            if (item != "" && item.Contains("交点"))
        //            {
        //                string[] tempArray = item.Split(':');
        //                x = Convert.ToDouble(tempArray[2].Split(' ')[0]).ToString("0.000");
        //                y = Convert.ToDouble(tempArray[3].Split(' ')[0]).ToString("0.000");

        //                HTuple temp_X, temp_Y;
        //                HOperatorSet.AffineTransPoint2d(_9PointCalibTool.HomMat2D, Convert.ToDouble(x), Convert.ToDouble(y), out temp_X, out temp_Y);

        //                txt_TemplateX.Text = temp_X.D.ToString();
        //                txt_TemplateY.Text = temp_Y.D.ToString();
        //                txt_TemplateU.Text = u;

        //                _9PointCalibTool.tbxWorldX1 = temp_X.D.ToString();
        //                _9PointCalibTool.tbxWorldY1 = temp_Y.D.ToString();
        //                if (Product.Instance != null)
        //                {
        //                    ModelConfig tempmodels = Product.Instance.GetModelbyName(productName);
        //                    tempmodels.Template_X = temp_X.D.ToString(); ;
        //                    tempmodels.Template_Y = temp_Y.D.ToString(); ;
        //                    tempmodels.Template_U = u;
        //                }

        //            }
        //        }

        //        for (int i = 0; i < temp.Count; i++)
        //        {
        //            if (temp[i] is _9PointCalibTool)
        //            {
        //                temp[i] = _9PointCalibTool;
        //                break;
        //            }
        //        }
        //        SerializeBLL.Write(temp, toolPath);

        //        SaveProduct();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("获取模板位异常：" + ex.Message);
        //    }
        //}

        #endregion

        #region 获取PLC 当前位置
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //此处使用键值对的方式查询更好
                progrom_run(1, "RUN");
                string X = "0", Y = "0", U = "0";
                foreach (var item in flowExecute1.AllResultLogic2.Values)
                {
                    if (item.Contains("找线测量1") && !item.Contains("[]"))
                    {
                        string[] tempArray = item.Split(' ');
                        U = Convert.ToDouble(tempArray[5].Substring(1)).ToString("0.000");
                    }

                    if (item.Contains("九点标定") && !item.Contains("[]"))
                    {
                        string[] tempArray = item.Split(',');
                        X = Convert.ToDouble(tempArray[1].Substring(1)).ToString("0.000");
                        Y = Convert.ToDouble(tempArray[2].Substring(1)).ToString("0.000");
                    }
                }
                if (Product.Instance != null)
                {
                    ModelConfig tempmodels = Product.Instance.GetModelbyName(productName);
                    tempmodels.Template_X = X;
                    tempmodels.Template_Y = Y;
                    tempmodels.Template_U = U;
                }
                txt_TemplateX.Text = X;
                txt_TemplateY.Text = Y;
                txt_TemplateU.Text = U;
            }
            catch (Exception ex)
            {
                ShowLog("A区获取模板异常:" + ex.Message, Color.Red);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                progrom_run(2, "RUN2");
                string X = "0", Y = "0", U = "0";
                foreach (var item in flowExecute2.AllResultLogic2.Values)
                {
                    if (item.Contains("找线测量1") && !item.Contains("[]"))
                    {
                        string[] tempArray = item.Split(' ');
                        U = Convert.ToDouble(tempArray[5].Substring(1)).ToString("0.000");
                    }

                    if (item.Contains("九点标定") && !item.Contains("[]"))
                    {
                        string[] tempArray = item.Split(',');
                        X = Convert.ToDouble(tempArray[1].Substring(1)).ToString("0.000");
                        Y = Convert.ToDouble(tempArray[2].Substring(1)).ToString("0.000");
                    }
                }
                if (Product.Instance != null)
                {
                    ModelConfig tempmodels = Product.Instance.GetModelbyName(productName);
                    tempmodels.BTemplate_X = X;
                    tempmodels.BTemplate_Y = Y;
                    tempmodels.BTemplate_U = U;
                }
                txt_BTemplateX.Text = X;
                txt_BTemplateY.Text = Y;
                txt_BTemplateU.Text = U;
            }
            catch (Exception ex)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsConnect)
            {
                txt_tempRbt_X.Text = MelsecMcNet.ReadInt16("D5755").Content.ToString();
                txt_tempRbt_Y.Text = MelsecMcNet.ReadInt16("D5757").Content.ToString();
                txt_tempRbt_U.Text = MelsecMcNet.ReadInt16("D5759").Content.ToString();

                if (Product.Instance != null)
                {
                    ModelConfig temp = Product.Instance.GetModelbyName(productName);
                    temp.Rbt_TemplateX = txt_tempRbt_X.Text;
                    temp.Rbt_TemplateY = txt_tempRbt_Y.Text;
                    temp.Rbt_TemplateU = txt_tempRbt_U.Text;
                }
            }

            #endregion

            #region 删掉旧方法

            //string pos = GetRobot_Pos(Product.Instance.Robot_IP, Convert.ToInt32(Product.Instance.Robot_Prot), "GETCUR\r\n");
            //if (pos != "" && pos.Contains(','))
            //{
            //    string[] tempPos = pos.Split(',');
            //    txt_tempRbt_X.Text = tempPos[0];
            //    txt_tempRbt_Y.Text = tempPos[1];
            //    txt_tempRbt_U.Text = tempPos[2];

            //    if (Product.Instance != null)
            //    {
            //        ModelConfig temp = Product.Instance.GetModelbyName(productName);
            //        temp.Rbt_TemplateX = txt_tempRbt_X.Text;
            //        temp.Rbt_TemplateY = txt_tempRbt_Y.Text;
            //        temp.Rbt_TemplateU = txt_tempRbt_U.Text;
            //    }
            //    List<ImageTool> tempTool = new List<ImageTool>();
            //    string toolPath = Product.Instance.VisionPath + productName + @"\RUN.vin";
            //    tempTool = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具
            //    _9PointCalibTool _9PointCalibTool = null;
            //    foreach (var item in tempTool)
            //    {
            //        if (item is _9PointCalibTool)
            //        {
            //            _9PointCalibTool = (_9PointCalibTool)item;
            //        }
            //    }

            //    double newX = Convert.ToDouble(txt_tempRbt_X.Text) - Convert.ToDouble(_9PointCalibTool.tbxWorldX1) + Convert.ToDouble(_9PointCalibTool.tbxWorldrX);
            //    double newY = Convert.ToDouble(txt_tempRbt_Y.Text) - Convert.ToDouble(_9PointCalibTool.tbxWorldY1) + Convert.ToDouble(_9PointCalibTool.tbxWorldrY);

            //    _9PointCalibTool.tbxWorldrX = newX.ToString();
            //    _9PointCalibTool.tbxWorldrY = newY.ToString();

            //    //txt_RCenterX.Text = newX.ToString();
            //    //txt_RCenterY.Text = newY.ToString();

            //    for (int i = 0; i < tempTool.Count; i++)
            //    {
            //        if (tempTool[i] is _9PointCalibTool)
            //        {
            //            tempTool[i] = _9PointCalibTool;
            //            break;
            //        }
            //    }
            //    SerializeBLL.Write(tempTool, toolPath);
            //}

            #endregion
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (IsConnect)
            {
                txt_BtempRbt_X.Text = MelsecMcNet.ReadInt16("D10755").Content.ToString();
                txt_BtempRbt_Y.Text = MelsecMcNet.ReadInt16("D10757").Content.ToString();
                txt_BtempRbt_U.Text = MelsecMcNet.ReadInt16("D10759").Content.ToString();

                if (Product.Instance != null)
                {
                    ModelConfig temp = Product.Instance.GetModelbyName(productName);
                    temp.BRbt_TemplateX = txt_BtempRbt_X.Text;
                    temp.BRbt_TemplateY = txt_BtempRbt_Y.Text;
                    temp.BRbt_TemplateU = txt_BtempRbt_U.Text;
                }
            }
        }

        /// <summary>
        /// 两点计算旋转中心
        /// </summary>
        /// <param name="p1">标定特征点</param>
        /// <param name="p2">旋转角度后的点</param>
        /// <param name="angle">旋转角度</param>
        /// <param name="center">旋转中心</param>
        public void GetCircular(PointF p1, PointF p2, double angle, ref PointF center)
        {
            double X = (p1.X + p2.X) / 2 + (p1.Y - p2.Y) / 2 * Math.Sin(angle) / (1 - Math.Cos(angle));
            double Y = (p1.Y + p2.Y) / 2 - (p1.X - p2.X) / 2 * Math.Sin(angle) / (1 - Math.Cos(angle));
            center = new PointF((float)X, (float)Y);
        }

        #region 日志函数
        //public void ShowLog(string content, object color = null)
        //{
        //    try
        //    {
        //        if (color == null)
        //            color = Color.Black;
        //        ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
        //        //ListViewItem item = new ListViewItem();
        //        //item.Text = DateTime.Now.ToString("HH:mm:ss") ;
        //        item.SubItems.Add(content);
        //        //表示从第0行开始插入
        //        this.lbxInfo.Items.Insert(0, item);
        //        item.ForeColor = (Color)color;
        //        if (lbxInfo.Items.Count > 2000)
        //            lbxInfo.Items.Clear();
        //        //从最后开始加入内容
        //        //lbxInfo.Items.Add(item);
                
        //        if (!Directory.Exists(@"D:\日志Log"))
        //            Directory.CreateDirectory(@"D:\日志Log");

        //        File.AppendAllText(@"D:\日志Log\" + DateTime.Now.ToString("yyyy-MM-dd") + @".Log", DateTime.Now.ToString("HH:mm:ss") + "\t" + content+ "\r\n");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("日志写入异常:" + ex.Message);
        //    }
        //}
        #endregion

        #region 单独显示B区任务情况
        public void ShowLogB(string content, object color = null)
        {
            try
            {
                if (color == null)
                    color = Color.Black;
                ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                //item.Text = DateTime.Now.ToString("HH:mm:ss") ;
                item.SubItems.Add(content);
                //表示从第0行开始插入
                this.lbxInfo_B.Items.Insert(0, item);
                item.ForeColor = (Color)color;
                if (lbxInfo_B.Items.Count > 2000)
                    lbxInfo_B.Items.Clear();
                //lbxInfo_B.Items.Add(item);



            }
            catch (Exception ex)
            {
                MessageBox.Show("日志写入异常:" + ex.Message);
            }
        
        
        }



        public void ShowLogA(string content, object color = null)
        {
            try
            {
                if (color == null)
                    color = Color.Black;
                ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                //item.Text = DateTime.Now.ToString("HH:mm:ss") ;
                item.SubItems.Add(content);
                //表示从第0行开始插入
                this.lbxInfo_B.Items.Insert(0, item);
                item.ForeColor = (Color)color;
                if (lbxInfo_B.Items.Count > 2000)
                    lbxInfo_B.Items.Clear();
                //lbxInfo_B.Items.Add(item);



            }
            catch (Exception ex)
            {
                MessageBox.Show("日志写入异常:" + ex.Message);
            }


        }




        #endregion

        #region 优化日志函数加锁多线程调用
        private object locker = new object(); // 定义一个锁对象

        public void ShowLog(string content, object color = null)
        {
            try
            {
                if (color == null)
                    color = Color.Black;

                ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                item.SubItems.Add(content);

                // 对访问列表框和写日志文件的部分进行加锁
                lock (locker)
                {
                    this.lbxInfo.Items.Insert(0, item);
                    item.ForeColor = (Color)color;

                    if (lbxInfo.Items.Count > 2000)
                        lbxInfo.Items.Clear();

                    if (!Directory.Exists(@"D:\日志Log"))
                        Directory.CreateDirectory(@"D:\日志Log");

                    File.AppendAllText(@"D:\日志Log\" + DateTime.Now.ToString("yyyy-MM-dd") + @".Log", DateTime.Now.ToString("HH:mm:ss") + "\t" + content + "\r\n");

                    //if (!Directory.Exists(@"D:\日志Log"))
                    //{
                    //    Directory.CreateDirectory(@"D:\日志Log");
                    //}

                    //File.AppendAllText(@"D:\日志Log" + DateTime.Now.ToString("yyyy-MM-dd") + @".Log", DateTime.Now.ToString("HH:mm:ss") + "\t" + content + "\r\n");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("日志写入异常:" + ex.Message);
            }
        }

        #endregion









        #region 信号灯
        private Color SngGreen = Color.FromArgb(43, 213, 43);
        private Color SngRed = Color.FromArgb(255, 77, 59);
        object Lock_Color = new object();
        private void SwitchSignal(bool[] Sig)
        {
            try
            {
                lock (Lock_Color)
                {
                    for (int i = 0; i < Sig.Length; i++)
                    {
                        if (isFormClosing)
                            return;
                        this.Invoke(new EventHandler(delegate
                        {
                            string style = (i + 1).ToString();
                            Control[] controls = Controls.Find("lab_Signal" + style, true);
                            if (controls.Length != 0)
                            {
                                Control ss = controls[0];
                                if (Sig[i])
                                    ss.GetType().GetProperty("BackColor").SetValue(ss, SngGreen);
                                else
                                    ss.GetType().GetProperty("BackColor").SetValue(ss, SngRed);
                            }

                        }));
                    }
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("信号灯切换异常:" + ex.Message);
                stop();
            }
        }
        #endregion

        #region PLC相关
        KeyenceMcNet MelsecMcNet = null;
        //bool IsConnect = false;

        //欧姆龙PLC
        OmronFinsNet FinsTCP01 = null;
        OmronFinsNet FinsTCP = new OmronFinsNet();
        
        bool IsConnect = false;








        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <returns></returns>
        public bool ConnectionMelsec()
        {
            try
            {
                ShowLog("初始化PLC...");
                //MelsecMcNet = new KeyenceMcNet();


                if (Product.Instance.Robot_IP == "" || Product.Instance.Robot_Prot == "")
                {
                    IsConnect = false;
                    ShowLog("PLC配置缺失,初始化PLC失败!", Color.Red);
                    return false;
                }

                //MelsecMcNet.IpAddress = Product.Instance.Robot_IP;
                //MelsecMcNet.Port = Convert.ToInt32(Product.Instance.Robot_Prot);

                FinsTCP.IpAddress = Product.Instance.Robot_IP;
                FinsTCP.Port = Convert.ToInt32(Product.Instance.Robot_Prot);
                FinsTCP.ConnectTimeOut = 500;
                FinsTCP.SA1 = 192;
                FinsTCP.SA2 = 0;

                //判断通信是否成功
                //OperateResult result = MelsecMcNet.ConnectServer();

                OperateResult result = FinsTCP.ConnectServer();




                ShowLog("初始化PLC完成!");
                if (result.IsSuccess)
                {
                    IsConnect = true;
                    Task.Factory.StartNew(() => { ReadSignal(); });
                    return true;
                }
                else
                {
                    IsConnect = false;
                    ShowLog("PLC错误代码:" + result.ErrorCode + "\t" + result.Message, Color.Red);
                    return false;
                }
            }
            catch (Exception ex)
            {
                IsConnect = false;
                ShowLog("初始化PLC异常:" + ex.Message, Color.Red);
                return false;
            }
        }

        private string PrepareMRaddreesForMC(string kv8000address)
        {
            if (kv8000address.Trim() == "")
                throw new Exception("地址不能为空！");
            int tempValue = Convert.ToInt32(kv8000address.Substring(1));
            int word = tempValue / 100;
            int left = tempValue % 100;
            int last = word * 16 + left;
            return "M" + last.ToString();
        }

        private bool[] CombinationSig(short asig, short bsig, short[] aresult, short[] bresult)
        {
            try
            {
                List<bool> Signal = new List<bool>();
                Signal.Add(asig == 1 ? true : false);
                Signal.Add(aresult[0] == 1 ? true : false);
                Signal.Add(aresult[1] == 1 ? true : false);
                Signal.Add(aresult[1] == 2 ? true : false);
                Signal.Add(aresult[2] == 1 ? true : false);
                Signal.Add(asig == 2 ? true : false);
                Signal.Add(aresult[0] == 2 ? true : false);
                Signal.Add(aresult[1] == 3 ? true : false);
                Signal.Add(aresult[1] == 4 ? true : false);
                Signal.Add(aresult[2] == 2 ? true : false);
                Signal.Add(MelsecMcNet.ReadInt16("D5750").Content == 1 ? true : false);
                Signal.Add(bsig == 1 ? true : false);
                Signal.Add(bresult[0] == 1 ? true : false);
                Signal.Add(bresult[1] == 1 ? true : false);
                Signal.Add(bresult[1] == 2 ? true : false);
                Signal.Add(bresult[2] == 1 ? true : false);
                Signal.Add(bsig == 2 ? true : false);
                Signal.Add(bresult[0] == 2 ? true : false);
                Signal.Add(bresult[1] == 3 ? true : false);
                Signal.Add(bresult[1] == 4 ? true : false);
                Signal.Add(bresult[2] == 2 ? true : false);
                Signal.Add(MelsecMcNet.ReadInt16("D10750").Content == 1 ? true : false);

                return Signal.ToArray();
            }
            catch (Exception ex)
            {
                ShowLog("合并信号异常:" + ex.Message);
                return null;
            }
        }

        private bool[] ReadDMaddrees(string address)
        {
            try
            {
                short operateResult = MelsecMcNet.ReadInt16(address).Content;
                bool[] iArr = new bool[16];
                for (int i = 0; i < iArr.Length; i++)
                {
                    iArr[i] = ((operateResult >> i) & 1) > 0 ? true : false;
                }
                return iArr;
            }
            catch (Exception ex)
            {
                ShowLog("解析or读取PLC地址异常:" + ex.Message);
                return null;
            }
        }

        static volatile bool sig_task1 = false, sig_task2 = false, sig_task3 = false, sig_task4 = false;

        private void gycs_Click(object sender, EventArgs e)
        {

        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            lbxInfo.Items.Clear();
        }

        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
              


                string fileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");//文件名
                string savepath = Application.StartupPath + "\\Log\\" + fileName + ".txt";
                FileStream stream = new FileStream(savepath, FileMode.Create);//fileMode指定是读取还是写入
                StreamWriter writer = new StreamWriter(stream);
                for (int i = 0; i < lbxInfo.Items.Count - 1; i++)
                {
                    ListViewItem listView = lbxInfo.Items[i];


                    writer.WriteLine(listView.SubItems[0].Text+ listView.SubItems[1].Text);
                }

                writer.Close();
            }
            catch
            {

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MelsecMcNet.Write("D5756", 10);
            //MelsecMcNet.Write("D5758", 20);


        }

        private void btn_saveconfig_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void bt_camel3_Click(object sender, EventArgs e)
        {
            progrom_run(3, "RUN3");
        }

        private void bt_camel4_Click(object sender, EventArgs e)
        {
            progrom_run(4, "RUN4");
        }

        private void bt_camel5_Click(object sender, EventArgs e)
        {
            progrom_run(5, "RUN5");
        }

        private void bt_camel6_Click(object sender, EventArgs e)
        {
            progrom_run(6, "RUN6");
        }

        //private List<string> tool1111 = new List<string>();

        private string a="";
        private string a1 = "";

        private void bt_camel7_Click(object sender, EventArgs e)
        {
            //progrom_run(7, "RUN7");

            #region 纠偏相机1 功能测试
            try
            {
                //此处使用键值对的方式查询更好
                progrom_run(7, "RUN7");
                string X = "0", Y = "0", U = "0";
                string LX1 = "0", LY1 = "0", LU1 = "0";
                string JX1 = "0", JY1 = "0", JU1 = "0";
                double offX1 = 0.00, offY1 = 0.00, offU1 = 0.00;

                double DG;
                #region 通过找线计算角度
                ////string a = "";
                ////先判断是否包含这个工具名 使用 TryGetValue 方法获取返回值
                //if (flowExecute7.AllResultLogic2.ContainsKey("找线测量_找线测量"))
                //{
                //    a = "";
                //    //Console.WriteLine();
                //    flowExecute7.AllResultLogic2.TryGetValue("找线测量_找线测量",out a);
                //    string[] tempArray = a.Split(' ');
                //    //获取找线角度
                //    LU1 = Convert.ToDouble(tempArray[5].Substring(1)).ToString("0.000");
                //    //区分正负角度
                //    if (Convert.ToDouble(LU1) < 0)
                //    {
                //         DG = RadianToDegree(Convert.ToDouble(LU1)) + 180;
                //    }
                //    else
                //    {
                //         DG = RadianToDegree(Convert.ToDouble(LU1))- 179.622;
                //    }
                //    //MessageBox.Show("旋转角度 "+DG.ToString("0.000") +" 纠正");

                //}
                #endregion

                #region 旧方法迭代很慢可以考虑省略掉
                //foreach (var item in flowExecute7.AllResultLogic2.Values)
                //{

                //    if (item.Contains("模板匹配") && !item.Contains("[]"))
                //    {

                //        string[] tempArray = item.Split(' ');
                //        X = Convert.ToDouble(tempArray[2].Substring(1)).ToString("0.000");
                //        Y = Convert.ToDouble(tempArray[3].Substring(1)).ToString("0.000");
                //        U = Convert.ToDouble(tempArray[4].Substring(1)).ToString("0.000");

                //    }

                //}

                #endregion

                #region 求取两线交点用于计算定位
                //if (flowExecute7.AllResultLogic2.ContainsKey("两线交点测量_两线交点测量"))
                //{
                //    a1 = "";
                //    //Console.WriteLine();
                //    flowExecute7.AllResultLogic2.TryGetValue("两线交点测量_两线交点测量", out a1);
                //    string[] tempArray3 = a1.Split(' ');
                //    //获取找线角度
                //    JX1 = Convert.ToDouble(tempArray3[1].Substring(1)).ToString("0.000");
                //    JY1 = Convert.ToDouble(tempArray3[2].Substring(1)).ToString("0.000");

                //    //Console.WriteLine();

                //}

                ////偏移量=拍照交点-模板交点用比例法求解
                //offY1 = (Convert.ToDouble(JX1) - (2557.234))*0.026012*-1;
                //offX1 = (Convert.ToDouble(JY1) - (2835.302))* 0.026012;
                //offU1 = RadianToDegree(Convert.ToDouble(U));

                ////MessageBox.Show("偏移X："+offX1.ToString("0.000")+" 偏移Y："+offY1.ToString("0.000")+" 旋转U "+offU1.ToString("0.000"));
                ////提取三位数
                //string sssx1= offX1.ToString("0.000");
                //string sssy1= offY1.ToString("0.000");
                //string sssu1= offU1.ToString("0.000");

               
                ////保留三位小数不损失精度
                //double sssX11 = Convert.ToDouble(sssx1) * 1000;
                //double sssy11 = Convert.ToDouble(sssy1) * 1000;
                //double sssu11 = Convert.ToDouble(sssu1) * 1000;

                //int zh_sssX11 = Convert.ToInt32(sssX11);
                //int zh_sssy11 = Convert.ToInt32(sssy11);
                //int zh_sssu11 = Convert.ToInt32(sssu11);

                //#region 四舍五入第四位损失精度不使用这个方法
                ////int aaa =Convert.ToInt32(offX1 * 1000);
                ////int bbb = Convert.ToInt32(offY1 * 1000);
                ////int ccc = Convert.ToInt32(offU1 * 1000);
                //#endregion

                //#region 写入PLC 对应寄存器
                //FinsTCP.Write("D5000", zh_sssX11);//X轴分别对应寄存器地址 5000
                //FinsTCP.Write("D5002", zh_sssy11);//Y轴 5001
                //FinsTCP.Write("D5004", zh_sssu11);//U轴 5002 转化方法为个位数 *2

                //#endregion
                ////上料定位1完成
                //FinsTCP.Write("W10.06", true);
                ////上料定位1OK
                //FinsTCP.Write("W10.07", true);

                //if (Product.Instance != null)
                //{
                //    //ModelConfig tempmodels = Product.Instance.GetModelbyName(productName);
                //    //tempmodels.Template_X = X;
                //    //tempmodels.Template_Y = Y;
                //    //tempmodels.Template_U = U;
                //}
                ////txt_TemplateX.Text = X;
                ////txt_TemplateY.Text = Y;
                ////txt_TemplateU.Text = U;
            }
            catch (Exception ex)
            {
                ShowLog("A区获取模板异常:" + ex.Message, Color.Red);
            }



            #endregion


            #endregion

        }
        /// <summary>
        /// 弧度转角度
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static double RadianToDegree(double radian)
        {
            double degree = radian * (180.0 / Math.PI);
            return degree;
        }


        private void bt_camel8_Click(object sender, EventArgs e)
        {
            progrom_run(8, "RUN8");
        }

        private void bt_camel9_Click(object sender, EventArgs e)
        {
            progrom_run(9, "RUN9");
        }

        private void halconView11_Load(object sender, EventArgs e)
        {

        }

        private void Write_singel_Click(object sender, EventArgs e)
        {
            //short 类型对应地址为PLC对应 5000 5001 5002 上位机对应为 5000 5002 5004 
            int sssx1 = 1000, sssy2 = 2000, sssu3 = 3000;
            #region 调用XFF框架进行逻辑处理
            FinsTCP.Write("D5000", sssx1);//X轴分别对应寄存器地址 5000
            FinsTCP.Write("D5002", sssy2);//Y轴 5001
            FinsTCP.Write("D5004", sssu3);//U轴 5002
        }

        private void CS1_Click(object sender, EventArgs e)
        {
            progrom_run(2, "RUN2");
        }


        #region 线程及任务管控
        /// <summary>
        /// 定义CCD 软触发相机信号
        /// </summary>
        //static volatile short A_Sig, B_Sig;
        //static volatile short[] A_Result, B_Result;
        static volatile bool PCsig_task1 = false, PCsig_task2 = false, PCsig_task3 = false, PCsig_task4 = false, PCsig_task5 = false, PCsig_task6 = false;
        static volatile bool PCsig_task7 = false, PCsig_task8 = false, PCsig_task9 = false, PCsig_task10 = false, PCsig_task11 = false, PCsig_task12 = false, PCsig_task13 = false;
        static volatile bool PCsig_task14 = false, PCsig_task15 = false, PCsig_task16 = false, PCsig_task17 = false, PCsig_task18 = false, PCsig_task19 = false, PCsig_task20 = false;
        static volatile bool PCsig_heartbeat = false, PCsig_alarm = false, PCsig_task21 = false, PCsig_task22 = false;
        static volatile bool[] Sig = null;
        static volatile bool sig_UpOEE = false;

        #endregion



        /// <summary>
        /// 主流程运行
        /// </summary>
        private void ReadSignal()
        {
            try
            {
                //申明需要读取的参数(触发上位机执行流程功能)
                OperateResult<bool[]> W00 = new OperateResult<bool[]>();



                //!IsConnect 不进入线程 改为 IsConnect 为进入线程
                while (!IsConnect)
                {
                    #region 欧姆龙NJ系列逻辑处理

                    #region 实时刷新读取欧姆龙寄存器状态初定义50ms后期更改Thread.sleep()改变线扫周期
                    //OperateResult<bool[]> W00 = new OperateResult<bool[]>();
                    W00 = FinsTCP.ReadBool("W00.00", 16);
                    //写入信号测试
                    //FinsTCP.Write("W10.00", true);



                    #endregion

                    #region 视觉作为服务端，根据客户端发送的指令，发送至客户端相应的数据

                    //在此段 修改IP地址与端口号 IPEndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32(9004));

                    //socketSer2.Sockerend = "";
                    //if (socketSer2.Sockerend.ToUpper().Contains("GETPOS"))
                    //{
                    //    MessageBox.Show("Receive OK！");

                    //}
                    //socketSer2.Sockerend = "";

                    //往客户端发送数据
                    //socketSer2.pc("127.0.0.1", "555");


                    #endregion


                    #region 长时间没心跳断开服务重新连接一次
                    //if (W00.Content == null || D100.Content == null || DeviveData.Content == null)
                    //{
                    //    //OmronConnect = false;
                    //    LogHelper.Error("PLC连接异常,退出主线程!");
                    //    FinsTCP.ConnectClose();
                    //    FinsTCP = new OmronFinsNet();
                    //    FinsTCP.IpAddress = Product.Instance.DeviceConfig.PLC_IP;
                    //    FinsTCP.Port = Convert.ToInt32(Product.Instance.DeviceConfig.PLC_Port);
                    //    FinsTCP.ConnectTimeOut = 500;
                    //    FinsTCP.SA1 = 105;
                    //    OperateResult connect = FinsTCP.ConnectServer();
                    //    if (connect.IsSuccess)
                    //    {
                    //        LogHelper.Info("PLC重连成功！", LogHelper.LogType.RunLog);
                    //    }
                    //    else
                    //    {
                    //        LogHelper.Info("PLC重连失败！", LogHelper.LogType.RunLog);
                    //    }
                    //    Thread.Sleep(1000);
                    //    continue;
                    //}

                    #endregion

                    #region 上料扫码功能暂未确定逻辑没写



                    #endregion

                    #region 上料定位CCD W0.02 (Content[2]) 上料定位1
                    //上料定位暂时由PLC调用触发 后期改为用上位机走套接字方式触发
                    if (W00.Content[2] && !PCsig_task2)
                    {
                        PCsig_task2 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测，触发上料定位1", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入偏移量
                                int sssx1 = 100, sssy2 = 200, sssu3 = 500;
                                #region 调用XFF框架进行逻辑处理
                                FinsTCP.Write("D5000", sssx1);//X轴
                                FinsTCP.Write("D5002", sssy2);//X轴
                                FinsTCP.Write("D5004", sssu3);//X轴
                                #endregion
                                //上料定位1完成
                                FinsTCP.Write("W10.06", true);
                                //上料定位1OK
                                FinsTCP.Write("W10.07", true);

                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task2 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"上料定位耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task2)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }


                    #endregion

                    #region 上料定位 W0.03 上料定位2
                    if (W00.Content[3] && !PCsig_task3)
                    {
                        PCsig_task3 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测，触发上料定位2", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入偏移量
                                int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("D5006", sssx1);//X轴
                                FinsTCP.Write("D5008", sssy2);//X轴
                                FinsTCP.Write("D5010", sssu3);//X轴
                                #endregion
                                //上料定位2完成
                                FinsTCP.Write("W11.00", true);
                                //上料定位OK
                                FinsTCP.Write("W11.01",true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task3 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"上料2定位耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task3)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }


                    #endregion

                    #region W0.04 此功能待确认



                    #endregion

                    #region W0.05 触发CCD1(正极耳检测) 测量
                    if (W00.Content[5] && !PCsig_task5)
                    {
                        PCsig_task5 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发极耳检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W10.14", true);//写入测量OK
                                //FinsTCP.Write("W10.15", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W10.13", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task5 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"极耳检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task5)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }



                    #endregion

                    #region W0.06 触发负极焊接极耳1检测
                    if (W00.Content[6] && !PCsig_task6)
                    {
                        PCsig_task6 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发负极耳检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W11.07", true);//写入测量OK
                                //FinsTCP.Write("W10.08", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W11.06", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task6 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"极耳检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task6)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }



                    #endregion

                    #region W0.07 触发负极焊接极耳2检测

                    if (W00.Content[7] && !PCsig_task7)
                    {
                        PCsig_task7 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发负极耳2检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W11.10", true);//写入测量OK
                                //FinsTCP.Write("W11.11", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W11.09", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task7 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"负极耳2检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task7)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }


                    #endregion

                    #region W0.08触发负极焊接导电柄检测

                    if (W00.Content[8] && !PCsig_task8)
                    {
                        PCsig_task8 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，负极焊接电柄检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W11.12", true);//写入测量OK
                                //FinsTCP.Write("W11.11", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W11.13", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task8 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"负极焊接导电柄检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task8)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }

                    #endregion

                    #region W0.09 触发读负极焊接参数(超声波焊接测试仪)

                    if (W00.Content[9] && !PCsig_task9)
                    {
                        PCsig_task9 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("触发读负极焊接参数", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //读负极焊接参数完成
                                FinsTCP.Write("W11.15", true);


                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                //FinsTCP.Write("W11.12", true);//写入测量OK
                                //FinsTCP.Write("W11.11", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                //FinsTCP.Write("W11.13", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task9 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"负极焊接导电柄检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task9)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }



                    #endregion

                    #region W0.10 触发正极焊接极耳1检测

                    if (W00.Content[10] && !PCsig_task10)
                    {
                        PCsig_task10 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发正极焊接极耳检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W12.01", true);//写入测量OK
                                //FinsTCP.Write("W12.02", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W12.00", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task10 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"正极焊接极耳检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task10)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }

                    #endregion

                    #region W0.11 触发正极焊接极耳2检测


                    if (W00.Content[11] && !PCsig_task11)
                    {
                        PCsig_task11 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发正极焊接极耳2检测", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W12.07", true);//写入测量OK
                                //FinsTCP.Write("W12.08", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W12.06", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task11 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"正极焊接极耳2检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task11)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }




                    #endregion

                    #region W0.12 触发正极焊接导电柄检测

                    if (W00.Content[12] && !PCsig_task12)
                    {
                        PCsig_task12 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("接收触发CCD检测相机，触发正级焊接", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                FinsTCP.Write("W12.07", true);//写入测量OK
                                //FinsTCP.Write("W12.08", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                FinsTCP.Write("W12.06", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task12 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"正极焊接导电柄检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task12)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }


                    #endregion

                    #region W0.13 触发读正极焊接参数(超声波焊接测试仪)

                    if (W00.Content[13] && !PCsig_task13)
                    {
                        PCsig_task9 = true;
                        Task.Factory.StartNew(() =>
                        {
                            //LogHelper.Info("接收任务-来料拍照定位", LogHelper.LogType.RunLog);
                            ShowLog("触发读正极焊接参数", Color.Green);
                            Stopwatch my_timer = new Stopwatch();
                            my_timer.Start();
                            try
                            {
                                //读负极焊接参数完成
                                FinsTCP.Write("W12.09", true);


                                //模拟写入OK 
                                //int sssx1 = 111, sssy2 = 222, sssu3 = 333;
                                #region 模拟调用XFF视觉框架进行逻辑处理
                                //FinsTCP.Write("W11.12", true);//写入测量OK
                                //FinsTCP.Write("W11.11", true);//写入测量NG
                                #endregion
                                //测量检测完成
                                //FinsTCP.Write("W11.13", true);
                                //上料定位OK
                                //FinsTCP.Write("W11.01", true);



                                #region 开始抓图调用视觉逻辑处理算偏移量
                                ////后期改为套接字通讯触发即可
                                //SocketHelper.TcpClients client = DeviceTools.Instance.FindTCPDevice("视觉系统");
                                //string PosData = GetPos(client);//触发相机拍照
                                //if (PosData != "" && PosData.Split(',').Length == 3)
                                //{
                                //    string[] Pos = PosData.Split(',');
                                //    int sss1 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[0]), 3) * 1000);
                                //    int sss2 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[1]), 3) * 1000);
                                //    int sss3 = Convert.ToInt32(Math.Round(Convert.ToDouble(Pos[2]), 3) * 1000);
                                //    //PC 给来料机器人取料位地址
                                //    FinsTCP.Write("D10000", sss1);//X轴
                                //    FinsTCP.Write("D10002", sss2);//X轴
                                //    FinsTCP.Write("D10004", sss3);//X轴

                                //    FinsTCP.Write("W10.5", true);
                                //}
                                //else
                                //{
                                //    FinsTCP.Write("W10.6", true);
                                //    FinsTCP.Write("W10.7", true);

                                //}

                                #endregion


                            }
                            catch (Exception ex)
                            {
                                ShowLog("视觉处理发生异常", Color.Red);

                            }
                            #region 用 finally 处理小尾巴
                            finally
                            {
                                PCsig_task9 = false;
                            }
                            #endregion 
                            my_timer.Stop();
                            ShowLog($"正极焊接导电柄检测耗时：{my_timer.ElapsedMilliseconds}");

                        });
                    }
                    else if (!PCsig_task9)
                    {
                        //FinsTCP.Write("W10.5", false);
                        //FinsTCP.Write("W10.6", false);
                        //FinsTCP.Write("W10.7", false);
                    }




                    #endregion


                    #endregion


                    #region 旧代码

                    //#region 204代码屏蔽掉不使用作为参考

                    //A_Sig = MelsecMcNet.ReadInt16("D5751").Content;
                    //B_Sig = MelsecMcNet.ReadInt16("D10751").Content;
                    //if (B_Sig == 1) MelsecMcNet.Write("D10751", (Int16)0);

                    //A_Result = MelsecMcNet.ReadInt16("D5753", 3).Content;
                    //B_Result = MelsecMcNet.ReadInt16("D10753", 3).Content;


                    ////A区心跳
                    //if (MelsecMcNet.ReadInt16("D5750").Content == 0)
                    //    MelsecMcNet.Write("D5750", (Int16)1);
                    //else
                    //    MelsecMcNet.Write("D5750", (Int16)0);

                    ////B区心跳
                    //if (MelsecMcNet.ReadInt16("D10750").Content == 0)
                    //    MelsecMcNet.Write("D10750", (Int16)1);
                    //else
                    //    MelsecMcNet.Write("D10750", (Int16)0);

                    ////信号切换
                    //Task.Factory.StartNew(() =>
                    //{
                    //    SwitchSignal(CombinationSig(A_Sig, B_Sig, A_Result, B_Result));
                    //});


                    //#region A区来料触发CCD
                    //if (A_Sig == 1 && !sig_task1)
                    //{
                    //    sig_task1 = true;
                    //    Task.Factory.StartNew(() =>
                    //    {
                    //        ShowLog("A区接收触发CCD检测", Color.Green);
                    //        ShowLogA("A区接收触发CCD检测", Color.Green);
                    //        Stopwatch my_timer = new Stopwatch();
                    //        my_timer.Start();
                    //        try
                    //        {
                    //            MelsecMcNet.Write("D5753", (Int16)1);//CCD收到PLC启动信号
                    //            progrom_run(1, "RUN");
                    //            if (flowExecute1.AllResultLogic.Contains(false))// 检测NG
                    //                MelsecMcNet.Write("D5754", (Int16)1);
                    //            else
                    //                MelsecMcNet.Write("D5754", (Int16)1);//检测OK

                    //            string X = "0", Y = "0", U = "0";
                    //            foreach (var item in flowExecute1.AllResultLogic2.Values)
                    //            {
                    //                if (item.Contains("九点标定") && !item.Contains("[]"))
                    //                {
                    //                    string[] tempArray = item.Split(' ');
                    //                    X = Convert.ToDouble(tempArray[1].Substring(1)).ToString("0.000");
                    //                    Y = Convert.ToDouble(tempArray[2].Substring(1)).ToString("0.000");
                    //                    U = Convert.ToDouble(tempArray[3].Substring(1)).ToString("0.000");
                    //                }
                    //            }
                    //            //int offsetX = Convert.ToInt32((-86.29 - Convert.ToDouble(X)) * 100)*-1;
                    //            //int offsetY = Convert.ToInt32((56.2 - Convert.ToDouble(Y)) * 100)*-1;
                    //            //int offsetU = Convert.ToInt32(-Convert.ToDouble(U) * 100);

                    //            //偏差值=旋转后的偏移点位-模板位
                    //            //int offsetX = Convert.ToInt32((Convert.ToDouble(X) - (-328.468)) * 100) * 1;
                    //            //int offsetY = Convert.ToInt32((Convert.ToDouble(Y) - 74.131) * 100) * -1;

                    //            int offsetX = Convert.ToInt32((Convert.ToDouble(X) - (Convert.ToDouble(txt_AX.Text))) * 100) * 1;
                    //            int offsetY = Convert.ToInt32((Convert.ToDouble(Y) - (Convert.ToDouble(txt_AY.Text))) * 100) * -1;


                    //            int offsetU = Convert.ToInt32(-Convert.ToDouble(U) * 100)*0;
                    //            //int offsetU = 0;


                    //            if ((Math.Abs(offsetX) > 500) || (Math.Abs(offsetY) > 500) || (Math.Abs(offsetU) > 500))
                    //            {
                    //                // ShowLog(string.Format("A区触发CCD偏移补偿太大，已忽略补偿数值，补偿数设为0"));
                    //            }
                    //            if (Math.Abs(offsetX) > 500) offsetX = 0;
                    //            if (Math.Abs(offsetY) > 500) offsetY = 0;
                    //            if (Math.Abs(offsetU) > 500) offsetU = 0;
                    //            //offsetX = 0; offsetY = 0; offsetU = 0;
                    //            //写入偏移值
                    //            MelsecMcNet.Write("D5756", offsetX);
                    //            MelsecMcNet.Write("D5758", offsetY);
                    //            MelsecMcNet.Write("D5760", offsetU);
                    //            Console.WriteLine(offsetX);
                    //            Console.WriteLine(offsetY);
                    //            Console.WriteLine(offsetU);
                    //            ShowLog(string.Format("A区触发CCD偏移--X:{0} Y:{1}   U:{2}", (Convert.ToInt32(offsetX) / 100.0).ToString("0.000"), (Convert.ToInt32(offsetY) / 100.0).ToString("0.000"), (Convert.ToDouble(offsetU) * -1).ToString("0.000")));
                    //            ShowLogA(string.Format("A区触发CCD偏移--X:{0} Y:{1}   U:{2}", (Convert.ToInt32(offsetX) / 100.0).ToString("0.000"), (Convert.ToInt32(offsetY) / 100.0).ToString("0.000"), (Convert.ToDouble(offsetU) * -1).ToString("0.000")));
                    //            //     ShowLog(string.Format("A区触发CCD偏移--X:{0} Y:{1}   U:{2}", (Convert.ToInt32(offsetX)/100.0).ToString("0.000"), (Convert.ToInt32(offsetY)/100.0).ToString("0.000"), (Convert.ToDouble(U) * -1).ToString("0.000")));

                    //            MelsecMcNet.Write("D5755", (Int16)1);//写入完成信号
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            ShowLog("A区触发CCD检测异常:" + ex.Message, Color.Red);
                    //            MelsecMcNet.Write("D5754", (Int16)2);//检测NG
                    //            MelsecMcNet.Write("D5755", (Int16)1);//写入完成信号
                    //        }
                    //        my_timer.Stop();
                    //        ShowLog($"A区接收触发CCD检测-耗时：{my_timer.ElapsedMilliseconds}", Color.Green);
                    //        sig_task1 = false;
                    //    });
                    //}
                    //#endregion

                    //#region A区CCD检测有无
                    //if (A_Sig == 2 && !sig_task2)
                    //{
                    //    sig_task2 = true;
                    //    Task.Factory.StartNew(() =>
                    //    {
                    //        ShowLog("A区接收触发CCD检测有无", Color.Green);
                    //        Stopwatch my_timer = new Stopwatch();
                    //        my_timer.Start();
                    //        try
                    //        {
                    //            MelsecMcNet.Write("D5753", (Int16)2);//CCD收到PLC启动信号
                    //            //progrom_run(1, "RUN");
                    //            if (flowExecute1.AllResultLogic1["斑点分析"] == false)// 检测NG
                    //                MelsecMcNet.Write("D5754", (Int16)4);
                    //            else
                    //                MelsecMcNet.Write("D5754", (Int16)3);//检测OK

                    //            MelsecMcNet.Write("D5755", (Int16)2);//写入完成信号
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            ShowLog("触发CCD检测异常:" + ex.Message, Color.Red);
                    //            MelsecMcNet.Write("D5754", (Int16)4);//检测NG
                    //            MelsecMcNet.Write("D5755", (Int16)2);//写入完成信号
                    //        }
                    //        my_timer.Stop();
                    //        ShowLog($"A区接收触发CCD检测有无-耗时：{my_timer.ElapsedMilliseconds}", Color.Green);
                    //        sig_task2 = false;
                    //    });
                    //}
                    //#endregion

                    //#region B区 来料触发CCD
                    //if (B_Sig == 1 && !sig_task3)
                    //{
                    //    sig_task3 = true;
                    //    Task.Factory.StartNew(() =>
                    //    {
                    //        ShowLog("B区接收触发CCD检测", Color.Green);

                    //        ShowLogB("B区接收触发CCD检测", Color.Green);
                    //        Stopwatch my_timer = new Stopwatch();
                    //        my_timer.Start();
                    //        try
                    //        {
                    //            MelsecMcNet.Write("D10753", (Int16)1);//CCD收到PLC启动信号
                    //            progrom_run(2, "RUN2");
                    //            if (flowExecute2.AllResultLogic.Contains(false))// 检测NG
                    //                MelsecMcNet.Write("D10754", (Int16)1);
                    //            else
                    //                MelsecMcNet.Write("D10754", (Int16)1);//检测OK

                    //            string XB = "0", YB = "0", UB = "0";
                    //            foreach (var item in flowExecute2.AllResultLogic2.Values)
                    //            {
                    //                if (item.Contains("九点标定") && !item.Contains("[]"))
                    //                {
                    //                    string[] tempArray = item.Split(' ');
                    //                    XB = Convert.ToDouble(tempArray[1].Substring(1)).ToString("0.000");
                    //                    YB = Convert.ToDouble(tempArray[2].Substring(1)).ToString("0.000");
                    //                    UB = Convert.ToDouble(tempArray[3].Substring(1)).ToString("0.000");
                    //                }
                    //            }
                    //            //int offsetXB = Convert.ToInt32((15.5716- Convert.ToDouble(XB)) * 100) * -1;
                    //            //int offsetYB = Convert.ToInt32((47.9754-Convert.ToDouble(YB)) * 100) * -1;

                    //            //此处减去模板位的偏差
                    //            //int offsetXB = Convert.ToInt32(( Convert.ToDouble(XB) - (-347.183)) * 100);
                    //            //int offsetYB = Convert.ToInt32((Convert.ToDouble(YB)- 75.862) * 100 ) *1 ;

                    //            //此处减去模板位的偏差
                    //            int offsetXB = Convert.ToInt32((Convert.ToDouble(XB) - (Convert.ToDouble(txt_BX.Text))) * 100);
                    //            int offsetYB = Convert.ToInt32((Convert.ToDouble(YB) - (Convert.ToDouble(txt_BY.Text))) * 100) * 1;


                    //            int offsetUB = Convert.ToInt32(Convert.ToDouble(UB) * -100);
                    //            //if ((Math.Abs(offsetXB) > 500) || (Math.Abs(offsetYB) >500) || (Math.Abs(offsetUB) > 500))
                    //            if ((Math.Abs(offsetXB) > 300) || (Math.Abs(offsetYB) >300) || (Math.Abs(offsetUB) > 300))
                    //            {
                    //                ShowLog(string.Format("B区触发CCD偏移补偿太大，已忽略补偿数值，补偿数设为0"/*+ Math.Abs(offsetXB)+ "Y轴为"+Math.Abs(offsetYB)+"R轴为"+ Math.Abs(offsetUB)*/));
                    //                ShowLog(string.Format("补偿值 X轴为:" + Math.Abs(offsetXB) + " Y轴为:" + Math.Abs(offsetYB) + " R轴为" + Math.Abs(offsetUB)));


                    //                ShowLogB(string.Format("补偿值 X轴为:" + Math.Abs(offsetXB) + " Y轴为:" + Math.Abs(offsetYB) + " R轴为" + Math.Abs(offsetUB)));
                    //                ShowLogB(string.Format("超标补偿值设0->X轴为:" + Convert.ToDouble(XB) + " Y轴为:" + Convert.ToDouble(YB) + " R轴为" + Convert.ToDouble(UB)));
                    //            }
                    //            //if(Math.Abs(offsetXB) > 500)
                    //            //{
                    //            //    MessageBox.Show("X轴值为" + Math.Abs(offsetXB));
                    //            //}
                    //            //if(Math.Abs(offsetYB) > 500)
                    //            //{
                    //            //    MessageBox.Show ("Y轴为" + Math.Abs(offsetYB));
                    //            //}
                    //            // if((Math.Abs(offsetUB) > 500))
                    //            // {
                    //            //    MessageBox.Show ("R轴为" + Math.Abs(offsetUB));
                    //            //   }

                    //            //if (Math.Abs(offsetXB) > 500) offsetXB = 0; if (Math.Abs(offsetYB) > 500) offsetYB = 0; if (Math.Abs(offsetUB) > 500) offsetUB = 0;
                    //            if (Math.Abs(offsetXB) > 300) offsetXB = 50; if (Math.Abs(offsetYB) > 300) offsetYB = 50; if (Math.Abs(offsetUB) > 300) offsetUB = 50;

                    //            //写入偏移值
                    //            MelsecMcNet.Write("D10756", offsetXB);
                    //            MelsecMcNet.Write("D10758", offsetYB);
                    //            MelsecMcNet.Write("D10760", offsetUB);

                    //            ShowLog(string.Format("B区触发CCD偏移--X:{0} Y:{1}   U:{2}", (Convert.ToInt32(offsetXB) / 100.0).ToString("0.000"), (Convert.ToInt32(offsetYB) / 100.0).ToString("0.000"), (Convert.ToDouble(UB) * -1).ToString("0.000")));


                    //            ShowLogB(string.Format("B区触发CCD偏移--X:{0} Y:{1}   U:{2}", (Convert.ToInt32(offsetXB) / 100.0).ToString("0.000"), (Convert.ToInt32(offsetYB) / 100.0).ToString("0.000"), (Convert.ToDouble(UB) * -1).ToString("0.000")));


                    //            MelsecMcNet.Write("D10755", (Int16)1);//写入完成信号
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            ShowLog("B区触发CCD检测异常:" + ex.Message, Color.Red);
                    //            ShowLogB("B区触发CCD检测异常:" + ex.Message, Color.Red);
                    //            MelsecMcNet.Write("D10754", (Int16)2);//检测NG
                    //            MelsecMcNet.Write("D10755", (Int16)1);//写入完成信号
                    //        }
                    //        my_timer.Stop();
                    //        ShowLog($"B区接收触发CCD检测-耗时：{my_timer.ElapsedMilliseconds}", Color.Green);
                    //        sig_task3 = false;
                    //    });
                    //}

                    //#endregion

                    //#endregion


                    //#region B区 CCD检测有无
                    //if (B_Sig == 2 && !sig_task4)
                    //{
                    //    sig_task4 = true;
                    //    Task.Factory.StartNew(() =>
                    //    {
                    //        ShowLog("B区接收触发CCD检测有无", Color.Green);
                    //        Stopwatch my_timer = new Stopwatch();
                    //        my_timer.Start();
                    //        try
                    //        {
                    //            MelsecMcNet.Write("D10753", (Int16)2);//CCD收到PLC启动信号
                    //            if (flowExecute2.AllResultLogic1["斑点分析"] == false)// 检测NG
                    //                MelsecMcNet.Write("D10754", (Int16)4);
                    //            else
                    //                MelsecMcNet.Write("D10754", (Int16)3);//检测OK
                    //            MelsecMcNet.Write("D10755", (Int16)2);//写入完成信号
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            ShowLog("B区触发CCD检测异常:" + ex.Message, Color.Red);
                    //            MelsecMcNet.Write("D10754", (Int16)4);//检测NG
                    //            MelsecMcNet.Write("D10755", (Int16)2);//写入完成信号
                    //        }
                    //        my_timer.Stop();
                    //        ShowLog($"B区接收触发CCD检测有无-耗时：{my_timer.ElapsedMilliseconds}", Color.Green);
                    //        sig_task4 = false;
                    //    });
                    //}
                    //#endregion


                    #endregion

                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                ShowLog("PLC监控异常：" + ex.Message);
                IsConnect = false;
            }
        }
        #endregion
    }
}

#endregion
