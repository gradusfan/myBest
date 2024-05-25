using DMSkin.Controls;
using HalconDotNet;
using RS232_IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;
using WeifenLuo.WinFormsUI.Docking;
using XFF_Vision.BLL;
using XFF_Vision.frm_Tool;

namespace XFF_Vision
{
    public partial class frm_VisionRun : Form
    {
        public frm_VisionRun fmain;
        public frm_Main fmain1;
        public CameraDAL cameraDAL = new CameraDAL();
        /// <summary>
        /// 虚拟键盘进程
        /// </summary>
        internal Process processKeyBoard;
        private static frm_VisionRun _instance;
        public static frm_VisionRun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frm_VisionRun();
                }

                return _instance;
            }
        }

        public frm_VisionRun()
        {
            InitializeComponent();
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            //Load_config();
        }
        /// <summary>
        /// 反序列化Dock控件对象
        /// </summary>
        public DeserializeDockContent m_deserializeDockContent;
        /// <summary>
        /// 图像窗体集合
        /// </summary>
        public Dictionary<string, frm_ImageWindow> D_imageWindow = new Dictionary<string, frm_ImageWindow>();
        public delegate void OpencamHanle();
        public event OpencamHanle OpencamEvent;
        //Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();

        public HTuple hv_AcqHandle2;
        public HTuple AcqHandle2
        {
            get { return hv_AcqHandle2; }
            set { hv_AcqHandle2 = value; }
        }
        public HTuple hv_AcqHandle;
        public List<HTuple> hv_AcqHandle3 = new List<HTuple>();
        public HTuple[] hv_AcqHandle1;
        public HTuple AcqHandle
        {
            get { return hv_AcqHandle; }
            set { hv_AcqHandle = value; }
        }

        string IO_data, X_show, Y_show;//IO卡数据
        SerialPortDAL sp1 = new SerialPortDAL();
        SerialPortDAL sp2 = new SerialPortDAL();
        string Serial_path = GlobalDAL.path_Serial + @"\Serial_Port.ini";//串口参数

        private string tool_Path = "";
        public string Tool_Path
        {
            get => tool_Path;
            set
            {
                tool_Path = value;
                frm_Job.Instance.toolPath = tool_Path;
            }
        }
        string msg;//串口信息
        /// <summary>
        /// 
        /// </summary>
        /// <param name="persistString"></param>
        /// <returns></returns>
        private IDockContent GetContentFromPersistString(string persistString)
        {
            try
            {

                if (persistString == typeof(frm_Job).ToString())

                    return frm_Job.Instance;
                else if (persistString == typeof(frm_Tools).ToString())
                    return frm_Tools.Instance;
                else if (persistString == typeof(frm_ImageWindow).ToString())
                {
                    D_imageWindow.Add("图像", frm_ImageWindow.Instance);
                    return frm_ImageWindow.Instance;
                }
                if (persistString == typeof(frm_Result).ToString())
                    return frm_Result.Instance;
                if (persistString == typeof(frm_Example).ToString())
                    return frm_Example.Instance;
                if (persistString == typeof(frm_Output).ToString())

                    return frm_Output.Instance;
                //else
                //{
                //    string[] parsedStrings = persistString.Split(new char[] { ',' });
                //    if (parsedStrings[0] != typeof(frm_ImageWindow).ToString())
                //        return null;
                //    frm_ImageWindow dummyDoc = new frm_ImageWindow();
                //    dummyDoc.Text = "图像";
                //    D_imageWindow.Add( "图像" , dummyDoc);
                //    return dummyDoc;
                //}
                return frm_Tools.Instance;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void DateLoad(object lab)
        {
            try
            {

                frm_Load fl = new frm_Load();
                fl.Lblinfo = (string)lab;
                fl.FormBorderStyle = FormBorderStyle.None;
                fl.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(fl);
            }
            catch { }
        }
        private void tStripMenu_ReadSetting_Click(object sender, EventArgs e)
        {
            frm_Job.Instance.ReadFile();
            frm_Job.Instance.recon(frm_Job.Instance.tool);
        }
        private void tStripMenu_SaveSetting_Click(object sender, EventArgs e)
        {
            frm_Job.Instance.SaveFile();
        }
        private void tStripMenu_SaveAs_Click(object sender, EventArgs e)
        {
            frm_Job.Instance.SaveAs_file();
        }

        private void frm_tool_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (acqHandle1 != null)
            //{
            //    HOperatorSet.CloseFramegrabber(acqHandle1);
            //    //acqHandle1 = null;
            //}
            if (OpencamEvent != null)
                OpencamEvent();
        }
        private void tStripMenu_New_Click(object sender, EventArgs e)
        {
            if (frm_Job.Instance.tool == null)
                frm_Job.Instance.tool = new List<ImageTool>();
            frm_Job.Instance.tool.Clear();
            frm_Job.Instance.listView1.Items.Clear();
            frm_Job.Instance.toolPath = null;
            MessageBox.Show("新建成功!", "新建成功!");
        }
        private void tStripMenu_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Hide();
                //ThreadLoad = new Thread(DateLoad);//
                //ThreadLoad.Start();
                //if (acqHandle1 != null)
                //{
                //    HOperatorSet.CloseFramegrabber(acqHandle1);
                //    //acqHandle1 = null;
                //}
                if (OpencamEvent != null)
                    OpencamEvent();
                //ThreadLoad.Abort();
                //Environment.Exit(0);
                Application.Exit();
            }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke((EventHandler)(delegate
            {
                Thread.Sleep(10);//9600/Bit/S/10ms 接受12个字节
                try
                {  //Comm.BytesToRead中为要读入的字节长度
                    int len = serialPort1.BytesToRead;
                    Byte[] readBuffer = new Byte[len];
                    serialPort1.Read(readBuffer, 0, len); //将数据读入缓存
                    //处理readBuffer中的数据，自定义处理过程
                    string inStr = "";
                    for (int i = 0; i < len; i++)
                        inStr += readBuffer[i].ToString("X2") + "";//拼接字符
                    if (inStr == "01")
                        frm_Job.Instance.run();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                serialPort1.DiscardInBuffer();//丢弃接收缓冲区数据
            }));
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.Invoke就是跨线程访问ui，的方法，
            this.Invoke((EventHandler)(delegate
            {
                try
                {  //Comm.BytesToRead中为要读入的字节长度
                    int len = serialPort2.BytesToRead;
                    Byte[] readBuffer = new Byte[len];
                    serialPort2.Read(readBuffer, 0, len); //将数据读入缓存
                    //处理readBuffer中的数据，自定义处理过程
                    string returnStr = "";
                    for (int i = 0; i < len; i++)
                    {
                        returnStr += readBuffer[i].ToString("X2") + "";
                    }
                    IO_data = returnStr;
                    X_show = IO_data.Substring(14, 2);
                    Y_show = IO_data.Substring(12, 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                serialPort2.DiscardInBuffer();//丢弃接收缓冲区数据
            }));
        }

        /// <summary>
        /// 运行侦查输入
        /// </summary>
        void input()
        {
            string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string X0_0 = GlobalDAL.Hex_to_Bin(X_show);//16-2
            string X0_Rev = GlobalDAL.Reverse(X0_0);
            for (int i = 0; i < X0_Rev.Length; i++)//遍历IO输入
            {
                string X0_index = X0_Rev.Substring(i, 1);
                if (X0_index == "0")
                {
                    switch (i)
                    {
                        case 0:
                            break;
                        case 1:
                            ;
                            break;
                        case 2:
                            ;
                            break;
                        case 3:
                            ;
                            break;
                        case 4:
                            ;
                            break;
                        case 5:
                            ;
                            break;
                        case 6:
                            ;
                            break;
                        case 7:
                            ;
                            break;
                    }
                }
                if (X0_index == "1")
                {
                    switch (i)
                    {
                        case 0:

                            break;
                        case 1:
                            ;
                            break;
                        case 2:
                            ;
                            break;
                        case 3:
                            ;
                            break;
                        case 4:
                            ;
                            break;
                        case 5:
                            ;
                            break;
                        case 6:
                            ;
                            break;
                        case 7:
                            ;
                            break;
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!frm_Job.Instance.isFlowExecute)
                frm_Job.Instance.run();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            input();
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            string st = fmain1.productName;
            if (timer1.Enabled != false)
            {
                btnRun.Enabled = true;
                timer1.Enabled = false;
                frm_Job.Instance.listView1.Enabled = true;
            }
            else
            {
                btnOnce.Enabled = false;
                btnOnce.Enabled = true;
                frm_Job.Instance.run();
                if (hv_AcqHandle != frm_Job.Instance.AcqHandle)
                //运行后关闭相机
                {

                    hv_AcqHandle = frm_Job.Instance.AcqHandle;
                    //cameraDAL.CloseCamera(hv_AcqHandle);  
                    hv_AcqHandle3.Add(hv_AcqHandle);
                    hv_AcqHandle = frm_Job.Instance.AcqHandle;
                }
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            frm_Job.Instance.listView1.Enabled = false;
            timer1.Enabled = true;
        }
        /// <summary>
        /// 创建新的图像窗体
        /// </summary>
        /// <returns></returns>
        internal frm_ImageWindow CreateNewImageWindow()
        {
            try
            {
                frm_ImageWindow dummyDoc = new frm_ImageWindow();
                int count = 1;
                string text = "图像" + count.ToString();
                while (FindImageWindow(text) != null)
                {
                    count++;
                }
                dummyDoc.Text = text;
                return dummyDoc;
            }
            catch (Exception ex)
            {
                return new frm_ImageWindow();
            }
        }
        /// <summary>
        /// 获取图像窗体
        /// </summary>
        /// <param name="text">窗体名</param>
        /// <returns></returns>
        private IDockContent FindImageWindow(string text)
        {
            try
            {



                if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    foreach (Form form in MdiChildren)
                        if (form.Text == text)
                            return form as IDockContent;
                    return null;
                }
                else
                {
                    foreach (IDockContent content in dockPanel1.Documents)
                        if (content.DockHandler.TabText == text)
                            return content;
                    return null;
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        private void toolStripTool_Click(object sender, EventArgs e)
        {
            frm_Tools.Instance.Show(dockPanel1, DockState.DockLeft);

        }
        //加载布局
        private void frm_VisionRun_Load(object sender, EventArgs e)
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
                frm_ImageWindow.Instance.Show();
            else
                frm_ImageWindow.Instance.Show(dockPanel1);
            frm_Tools.Instance.Show(dockPanel1, DockState.DockLeft);
            frm_Example.Instance.Show(dockPanel1, DockState.DockLeft);
            frm_Job.Instance.Show(dockPanel1, DockState.DockRight);
            frm_Result.Instance.Show(dockPanel1, DockState.DockRight);
            frm_Output.Instance.Show(dockPanel1, DockState.DockBottom);
        }
        //保存布局
        private void frm_VisionRun_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存布局
            //string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            //dockPanel1.SaveAsXml(configFile);
            //Application.Exit();
            //Environment.Exit(0);
            //关闭相机打开 
            cameraDAL.CloseCamera(AcqHandle);
            cameraDAL.CloseCamera(AcqHandle2);


        }

        private frm_ImageWindow CreateNewDocument()
        {
            frm_ImageWindow dummyDoc = new frm_ImageWindow();
            int count = 1;
            string text = $"图像{count}";
            while (FindImageWindow(text) != null)
            {
                count++;
                text = $"图像{count}";
            }
            dummyDoc.Text = text;
            return dummyDoc;
        }

        private void 重置窗口布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
                frm_ImageWindow.Instance.Show();
            else
                frm_ImageWindow.Instance.Show(dockPanel1);
            frm_Tools.Instance.Show(dockPanel1, DockState.DockLeft);
            frm_Example.Instance.Show(dockPanel1, DockState.DockLeft);
            frm_Job.Instance.Show(dockPanel1, DockState.DockRight);
            frm_Result.Instance.Show(dockPanel1, DockState.DockRight);
            frm_Output.Instance.Show(dockPanel1, DockState.DockBottom);
        }

        private void metroToolBar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroToolBar metroToolBar = (MetroToolBar)sender;
            int p = metroToolBar.SelectedIndex;
            switch (p)
            {
                case 0:  //客户端通讯
                    MessageBox.Show("待添加客户端");
                    break;
                case 1:  //服务端通讯
                    MessageBox.Show("待添加服务器");
                    break;
                case 2:  //RS232
                    List<SerialPort> sp = new List<SerialPort>();
                    List<string> str = new List<string>();
                    str.Add("PLC串口");
                    str.Add("IO卡串口");
                    sp.Add(serialPort1);
                    sp.Add(serialPort2);
                    sp1.OpenCom(serialPort1, "PLC串口", tsslbl_comlink1);
                    sp2.OpenCom(serialPort1, "IO卡串口", tsslbl_comlink2);
                    frm_Serial fs = new frm_Serial(sp, str, Load_config);
                    fs.StartPosition = FormStartPosition.CenterParent;
                    fs.ShowDialog();
                    break;

                case 3:  //服务端通讯
                    MessageBox.Show("待添加Hsl通信Demo！");
                    break;

                default:

                    break;

            }
        }

        private void metroToolBar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroToolBar metroToolBar = (MetroToolBar)sender;
            int p = metroToolBar.SelectedIndex;
            switch (p)
            {
                case 0:  //运行记录
                    if (frm_Output.Instance.DockState == DockState.Hidden || frm_Output.Instance.DockState == DockState.Unknown)
                        frm_Output.Instance.Show(dockPanel1, DockState.DockBottom);
                    else
                        frm_Output.Instance.Activate();
                    break;
                case 1:  //IO监控
                    MessageBox.Show("IO监控");
                    break;
                case 2:     //例程
                    if (frm_Example.Instance.DockState == DockState.Hidden || frm_Output.Instance.DockState == DockState.Unknown)
                        frm_Example.Instance.Show(dockPanel1, DockState.DockLeft);
                    else
                        frm_Example.Instance.Activate();
                    break;
                case 3:
                    //图像窗口
                    if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
                        frm_ImageWindow.Instance.Show();
                    else
                        frm_ImageWindow.Instance.Show(dockPanel1);
                    break;
                case 4:     //流程编辑
                    if (frm_Job.Instance.DockState == DockState.Hidden || frm_Output.Instance.DockState == DockState.Unknown)
                        frm_Job.Instance.Show(dockPanel1, DockState.DockRight);
                    else
                        frm_Job.Instance.Activate();
                    break;
                case 5:     //工具箱
                    if (frm_Tools.Instance.DockState == DockState.Hidden || frm_Output.Instance.DockState == DockState.Unknown)
                        frm_Tools.Instance.Show(dockPanel1, DockState.DockLeft);
                    else
                        frm_Tools.Instance.Activate();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            //dockPanel1.SaveAsXml(configFile);

            this.Close();
        }

        private void metroToolBar3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroToolBar metroToolBar = (MetroToolBar)sender;
            int p = metroToolBar.SelectedIndex;
            switch (p)
            {
                case 0:     //键盘
                    processKeyBoard = Process.Start("osk.exe");
                    break;
                case 1:     //截屏
                    SCreenCut();
                    break;

                case 2:     //运行notepad++编辑器
                    string exePath = Application.StartupPath + "\\Notepad++\\notepad++.exe";// 替换为你要运行的exe文件的完整路径
                    RunExeFile(exePath);

                    break;


                default: 
                    
                    break;
            }
        }
        private void Load_config()
        {
            try
            {   //扫码串口打开失败,请检查连接"
                msg = "";
                string errmsg;
                bool State1, State2;
                sp1.serialPort = serialPort1;
                sp1.Colse_Serial_Port();
                sp1.SetSerial_Port(Serial_path, "PLC串口");
                sp1.Open_Serial_Port(out State1, out errmsg);
                tsslbl_comlink1.ForeColor = Color.Green;
                tsslbl_comlink1.Text = "PLC串口已连接<" + serialPort1.PortName + "-" + serialPort1.BaudRate.ToString() + ">";
                if (State1 == false)
                {
                    msg += errmsg + ">PLC串口打开失败,请检查连接" + "\r\n";
                    tsslbl_comlink1.ForeColor = Color.Red;
                    tsslbl_comlink1.Text = "串口未连接";
                }

                //IO串口打开失败,请检查连接"
                sp2.serialPort = serialPort2;
                sp2.Colse_Serial_Port();
                sp2.SetSerial_Port(Serial_path, "IO卡串口");
                sp2.Open_Serial_Port(out State2, out errmsg);
                tsslbl_comlink2.ForeColor = Color.Green;
                tsslbl_comlink2.Text = "IO卡串口已连接<" + serialPort2.PortName + "-" + serialPort2.BaudRate.ToString() + ">";
                if (State2 == false)
                {
                    msg += errmsg + ">IO卡串口打开失败,请检查连接" + "\r\n";
                    tsslbl_comlink2.ForeColor = Color.Red;
                    tsslbl_comlink2.Text = "串口未连接";
                }
                //串口打开失败提示！
                if (State1 == false || State2 == false)
                {
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString()); 
            }
        }



        #region 自己写的一些优化方法用于优化框架
        /// <summary>
        /// 执行exe文件
        /// </summary>
        /// <param name="filePath"></param>
        private void RunExeFile(string filePath)
        {
            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("出现错误: " + ex.Message);
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 屏幕截图功能
        /// </summary>
        private void SCreenCut()
        {

            try
            {
                //屏幕宽
                int iWidth = Screen.PrimaryScreen.Bounds.Width;
                //屏幕高
                int iHeight = Screen.PrimaryScreen.Bounds.Height;
                //按照屏幕宽高创建位图
                Image img = new Bitmap(iWidth, iHeight);
                //从一个继承自Image类的对象中创建Graphics对象
                Graphics gc = Graphics.FromImage(img);
                //抓屏并拷贝到myimage里
                gc.CopyFromScreen(new System.Drawing.Point(0, 0), new System.Drawing.Point(0, 0), new Size(iWidth, iHeight));
                //this.BackgroundImage = img;
                //保存
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                System.Windows.Forms.SaveFileDialog dig_saveImage = new System.Windows.Forms.SaveFileDialog();
                dig_saveImage.Title = "请选择图像保存路径";
                dig_saveImage.Filter = "Image File|*.tif|Image File(*.png)|*.png|Image File(*.jpg)|*.jpg|Image File(*.bmp)|*.bmp";
                dig_saveImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                dig_saveImage.FileName = DateTime.Now.ToString("yyyy_MM_dd");
                if (dig_saveImage.ShowDialog() == DialogResult.OK)
                    img.Save(dig_saveImage.FileName);       //保存位图
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }



        #endregion



    }
}


