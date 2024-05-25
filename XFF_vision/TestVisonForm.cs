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
using System.Reflection;
using static VisionCon.ImageToolCon.ImageTool;

namespace XFF_Vision
{
    public partial class TestVisonForm : Form
    {
        public TestVisonForm()
        {
            InitializeComponent();

        }





        #region 显示类方法
        private string CurrentTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        public void AddLog(int index, string log)
        {
            try
            {
                if (!this.lst_Info.InvokeRequired)
                {
                    ListViewItem lst = new ListViewItem("   " + CurrentTime, index);
                    lst.SubItems.Add(log);

                    this.lst_Info.Items.Insert(0, lst);
                    if (this.lst_Info.Items.Count == 200)
                    {
                        this.lst_Info.Items.RemoveAt(199);
                    }
                }
                else
                {
                    this.lst_Info.Invoke(new Action(() =>
                    {
                        ListViewItem lst = new ListViewItem("   " + CurrentTime, index);
                        lst.SubItems.Add(log);

                        this.lst_Info.Items.Insert(0, lst);
                        if (this.lst_Info.Items.Count == 200)
                        {
                            this.lst_Info.Items.RemoveAt(199);
                        }
                    }));
                }
            }
            catch (Exception)
            {
            }

        }






        #endregion





        private void bt_Readimage_Click(object sender, EventArgs e)
        {
            // 获取应用程序的执行目录
            string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // 图像文件相对路径
            string imagePathRelative = "HalconTestImage/01/002.jpeg";

            // 拼接得到完整的图像文件路径
            string imagePath = Path.Combine(appDirectory, imagePathRelative);

            // 读取彩色图像
            HObject colorImage;
            HOperatorSet.ReadImage(out colorImage, imagePath);
            AddLog(0, "读取一张图片");

            // 定义变量来存储灰度图像
            HObject grayImage;

            // 将彩色图像转换为灰度图像
            HOperatorSet.Rgb3ToGray(colorImage, colorImage, colorImage, out grayImage);
            AddLog(0, "转成灰度图");
            // 获取灰度图像的宽度和高度
            HTuple imageWidth, imageHeight;
            HOperatorSet.GetImageSize(grayImage, out imageWidth, out imageHeight);



            #region 网上找的方法填充显示

            // 调整Halcon窗口大小以适应图像
            hWindowControl1.Size = new Size(imageWidth.I, imageHeight.I);

            // 设置显示的图像区域，确保整个图像都可见
            hWindowControl1.HalconWindow.SetPart(0, 0, imageHeight.I - 1, imageWidth.I - 1);





            // 将灰度图像显示在HWindowControl上
            hWindowControl1.HalconWindow.DispObj(grayImage);



            #region 原生控件显示文字
            HTuple windowHandle = hWindowControl1.HalconWindow;
            HTuple stringVal = "Hello, Halcon!";
            HOperatorSet.WriteString(windowHandle, stringVal);
            //setfont 设置字体 setcolor 设置颜色

            #endregion


            #endregion

            // 释放图像对象的内存
            colorImage.Dispose();
            grayImage.Dispose();
        }

        private void bt_Control_readImage_Click(object sender, EventArgs e)
        {
            HObject ho_Image3 = null;

            // 获取应用程序的执行目录
            string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // 图像文件相对路径
            string imagePathRelative = "HalconTestImage/01/002.jpeg";

            // 拼接得到完整的图像文件路径
            string imagePath = Path.Combine(appDirectory, imagePathRelative);

            // 读取彩色图像
            HObject colorImage;
            HOperatorSet.ReadImage(out colorImage, imagePath);
            AddLog(0, "读取一张图片");

            // 定义变量来存储灰度图像
            HObject grayImage;

            // 将彩色图像转换为灰度图像
            HOperatorSet.Rgb3ToGray(colorImage, colorImage, colorImage, out grayImage);
            AddLog(0, "转成灰度图");
            // 获取灰度图像的宽度和高度
            HTuple imageWidth, imageHeight;
            HOperatorSet.GetImageSize(grayImage, out imageWidth, out imageHeight);


            // 将灰度图像显示在HWindowControl上
            //halconView1.HalconWindow.DispObj(grayImage);
            ho_Image3 = grayImage;

            //HTuple windowHandle = halconView1.HalconWindow;
            //HTuple stringVal = "Hello, Halcon!";
            //HOperatorSet.WriteString(windowHandle, stringVal);
            halconView1.DispImage(ho_Image3, true);



            #region 第三方控件显示文字
            HSystem.SetSystem("flush_graphic", "true");
            halconView1.disp_message("运行流程"  + "错误！", ImageTool.CoordSystem.window.ToString(), 10, 10, ImageTool.ColorFul.yellow.ToString(), "false", ImageTool.ColorFul.orange.ToString());

            HSystem.SetSystem("flush_graphic", "false");

            #endregion







            //halconView1.DispObject(ho_Image3);






            // 释放图像对象的内存
            colorImage.Dispose();
            grayImage.Dispose();


        }

        private void TestVisonForm_Load(object sender, EventArgs e)
        {
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "cadet blue");
            halconView1.FitImage();
            

        }


        // 打开帧抓取器并进行图像采集
        HTuple AcqHandle;
        HObject Image;
        // 将RGB图像转换为灰度图像
        HObject ImageGray;
        // 对比度增强
        HObject ImageEmphasize;
        // 阈值化
        HObject Regions;
        // 连通域分析
        HObject ConnectedRegions;
        // 选择指定形状的区域
        HObject SelectedRegions1;
        // 计算所选区域的数量
        HTuple Number;

        private void bt_PaiZhao_Click(object sender, EventArgs e)
        {



            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb", -1, "false", "default", "[0] BisonCam,NB Pro", 0, -1, out AcqHandle);
            HOperatorSet.GrabImageStart(AcqHandle, -1);


            HOperatorSet.GrabImageAsync(out Image, AcqHandle, -1);

            // 关闭帧抓取器
            HOperatorSet.CloseFramegrabber(AcqHandle);

            // 在这里进行图像处理
            HOperatorSet.Rgb3ToGray(Image, Image, Image, out ImageGray);

            //增强图像对比度
            HOperatorSet.Emphasize(ImageGray, out ImageEmphasize, 7, 7, 5);

            //阈值分割
            HOperatorSet.Threshold(ImageEmphasize, out Regions, 0, 76);

            //连通域
            HOperatorSet.Connection(Regions, out ConnectedRegions);

            //形状筛选
            HOperatorSet.SelectShape(ConnectedRegions, out SelectedRegions1, "area", "and", 201393, 500000);

            //图像显示
            halconView1.DispImage(Image, true);




        }

        private void bt_reduce_pictrue_Click(object sender, EventArgs e)
        {

            halconView1.DispImage(ImageGray, true);
            halconView1.DispObject(SelectedRegions1);
            HOperatorSet.CountObj(SelectedRegions1, out Number);

            // 输出所选区域的数量
            AddLog(0, "当前贴胶状态" + Number.ToString());

        }

        private void bt_get_Result_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Number.ToString()) >=1)
            {
                Light_State3.Text = "有贴胶！";
                Light_State3.BackColor = Color.Green;
                MessageBox.Show("目标相机检测有贴胶，发送OK信号给PLC");

            }
            else
            {
                Light_State3.Text = "无贴胶！";
                Light_State3.BackColor = Color.Red;
                MessageBox.Show("目标相机检测无贴胶，发送NG信号给PLC");

            }
            //用完最好清理一下
            Number = 0;
            // 释放图像对象
            Image.Dispose();
            ImageGray.Dispose();
            ImageEmphasize.Dispose();
            Regions.Dispose();
            ConnectedRegions.Dispose();
            SelectedRegions1.Dispose();


        }

        private void bt_ZengQiang_Click(object sender, EventArgs e)
        {
            HalconAPI.CancelDraw();
        }


         double row, col, radius;
        private void button26_Click(object sender, EventArgs e)
        {
           

            hWindowControl1.Focus();
            hWindowControl1.HalconWindow.DrawCircle(out row, out col, out radius);
            hWindowControl1.HalconWindow.SetColor("red");
            HRegion region01 = new HRegion();
            region01.GenCircle(row, col, radius);
            region01.DispRegion(hWindowControl1.HalconWindow);








        }

        private void bt_Blob_Click_1(object sender, EventArgs e)
        {

            // 获取应用程序的执行目录
            string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // 图像文件相对路径
            //OK
            //string imagePathRelative = "HalconTestImage/02/01.png";
            //NG1
            //string imagePathRelative = "HalconTestImage/02/02.jpg";
            //NG3
            string imagePathRelative = "HalconTestImage/02/03.png";
            // 拼接得到完整的图像文件路径
            string imagePath = Path.Combine(appDirectory, imagePathRelative);

            int num =DetectBlobs(imagePath);

            if (num>5)
            {
                Light_State3.Text = "焊盘数量OK！"+ num.ToString();
                Light_State3.BackColor = Color.Green;
            }
            else
            {
                Light_State3.Text = "焊盘数量NG！"+num.ToString();
                Light_State3.BackColor = Color.Red;
            }
        }


        /// <summary>
        /// 封装Halcon方法图像处理
        /// </summary>
        /// <param name="imagePath"></param>
        public int DetectBlobs(string imagePath)
        {

            // 定义变量来存储图像和区域
            HObject Bond, Bright, Die, DieGrey, Wires, WiresFilled, Balls, SingleBalls, IntermediateBalls, FinalBalls;
            HTuple Row, Column, Radius;

            // 读取图像
            HOperatorSet.ReadImage(out Bond, imagePath);

            // 阈值化图像
            HOperatorSet.Threshold(Bond, out Bright, 100, 255);

            // 形状变换
            HOperatorSet.ShapeTrans(Bright, out Die, "rectangle2");

            // 限制图像域
            HOperatorSet.ReduceDomain(Bond, Die, out DieGrey);

            // 再次阈值化
            HOperatorSet.Threshold(DieGrey, out Wires, 0, 50);

            // 填充形状
            HOperatorSet.FillUpShape(Wires, out WiresFilled, "area", 1, 100);

            // 圆形开运算
            HOperatorSet.OpeningCircle(WiresFilled, out Balls, 15.5);

            // 连接区域
            HOperatorSet.Connection(Balls, out SingleBalls);

            // 选择形状
            HOperatorSet.SelectShape(SingleBalls, out IntermediateBalls, "circularity", "and", 0.85, 1.0);

            // 排序区域
            HOperatorSet.SortRegion(IntermediateBalls, out FinalBalls, "first_point", "true", "column");

            // 计算最小包围圆
            HOperatorSet.SmallestCircle(FinalBalls, out Row, out Column, out Radius);

            // 在这里可以使用 Row、Column、Radius 来做进一步的处理


            halconView1.DispImage(Bond, true);
            halconView1.DispObject(IntermediateBalls);


            #region 第三方控件显示文字
            HSystem.SetSystem("flush_graphic", "true");
            halconView1.disp_message("运行流程面积测量", ImageTool.CoordSystem.window.ToString(), 10, 10, ImageTool.ColorFul.green.ToString(), "false", ImageTool.ColorFul.orange.ToString());

            HSystem.SetSystem("flush_graphic", "false");

            #endregion

            // 将 Radius 转换为数组
            double[] radiusArray = Radius.DArr; // 将 HTuple 转换为 double 数组

            // 遍历并打印 radiusArray 的每个值
            // 遍历并打印 radiusArray 的每个值和下标
            for (int i = 0; i < radiusArray.Length; i++)
            {
                double radius = radiusArray[i];
                Console.WriteLine($"Radius at index {i}: {radius}");
                AddLog(0, $"检测圆 {i}面积为: {radius * 3.14 * radius}");
            }





            // 释放图像和区域对象的内存
            Bond.Dispose();
            Bright.Dispose();
            Die.Dispose();
            DieGrey.Dispose();
            Wires.Dispose();
            WiresFilled.Dispose();
            Balls.Dispose();
            SingleBalls.Dispose();
            IntermediateBalls.Dispose();
            FinalBalls.Dispose();


            return radiusArray.Length;

        }

        #region 显示文字方法二封

        public void DisplayMessage(string text, int x, int y, ColorFul color)
        {
            HSystem.SetSystem("flush_graphic", "true");
            halconView1.disp_message(text, ImageTool.CoordSystem.window.ToString(), x, y, color.ToString(), "false", ImageTool.ColorFul.orange.ToString());
            HSystem.SetSystem("flush_graphic", "false");
        }


        #endregion



        private void bt_color_check_Click(object sender, EventArgs e)
        {
            // 定义变量来存储图像和区域
            HObject Image, Red, Green, Blue, Hue, Saturation, Intensity, HighSaturation, HueHighSaturation, Yellow, ConnectedRegions, YellowClosing, SelectedRegions;
            HTuple Number;

            // 创建文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件路径
                string imagePath = openFileDialog.FileName;

                // 读取图像
                HOperatorSet.ReadImage(out Image, imagePath);



                // 分离成红黄绿蓝三通道
                HOperatorSet.Decompose3(Image, out Red, out Green, out Blue);

                // 将RGB颜色空间中的颜色转换为HSV颜色空间中的
                HOperatorSet.TransFromRgb(Red, Green, Blue, out Hue, out Saturation, out Intensity, "hsv");

                // 阈值化饱和度通道
                HOperatorSet.Threshold(Saturation, out HighSaturation, 100, 255);

                // 限制色调通道
                HOperatorSet.ReduceDomain(Hue, HighSaturation, out HueHighSaturation);

                // 阈值化色调通道
                HOperatorSet.Threshold(HueHighSaturation, out Yellow, 20, 50);

                // 连接区域
                HOperatorSet.Connection(Yellow, out ConnectedRegions);

                // 使用圆形封闭
                HOperatorSet.ClosingCircle(ConnectedRegions, out YellowClosing, 3.5);

                // 选择形状
                HOperatorSet.SelectShape(YellowClosing, out SelectedRegions, "area", "and", 150, 99999);

                // 计算选定区域数量
                HOperatorSet.CountObj(SelectedRegions, out Number);


                halconView1.DispImage(Image, true);
                halconView1.DispObject(SelectedRegions);


                // 在这里可以使用 Number 或其他结果进行进一步处理

                int num = Number;

                Light_State3.Text = "检测的黄线数量为：" + num.ToString();
                Light_State3.BackColor = Color.Green;


                AddLog(0, "检测黄线数量为:" + num.ToString());

                #region 第三方控件显示文字
                HSystem.SetSystem("flush_graphic", "true");
                halconView1.disp_message("运行流颜色检测", ImageTool.CoordSystem.window.ToString(), 10, 10, ImageTool.ColorFul.blue.ToString(), "false", ImageTool.ColorFul.orange.ToString());

                HSystem.SetSystem("flush_graphic", "false");

                #endregion


                // 释放图像和区域对象的内存
                Image.Dispose();
                Red.Dispose();
                Green.Dispose();
                Blue.Dispose();
                Hue.Dispose();
                Saturation.Dispose();
                Intensity.Dispose();
                HighSaturation.Dispose();
                HueHighSaturation.Dispose();
                Yellow.Dispose();
                ConnectedRegions.Dispose();
                YellowClosing.Dispose();
                SelectedRegions.Dispose();


            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            frm_Main frm_Main = new frm_Main();
            frm_Main.Show();
        }

        private void bt_Celiang_Click(object sender, EventArgs e)
        {


            // 创建文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;


                // 读取图像
                HObject Image;
                HOperatorSet.ReadImage(out Image, imagePath);

                // 获取图像大小
                HTuple Width, Height;
                HOperatorSet.GetImageSize(Image, out Width, out Height);

                // 生成矩形
                HObject Rectangle;
                HOperatorSet.GenRectangle2(out Rectangle, 102.342, 271.868, 0.0423081, 27.0935, 10.7725);

                // 生成测量矩形
                HTuple WidthMeasure = Width, HeightMeasure = Height, MeasureHandle;
                HOperatorSet.GenMeasureRectangle2(102.342, 271.868, 0.0423081, 27.0935, 10.7725, WidthMeasure, HeightMeasure, "nearest_neighbor", out MeasureHandle);

                // 复制图像
                HObject DupImage;
                HOperatorSet.CopyImage(Image, out DupImage);

                // 测量位置
                HTuple RowEdge, ColumnEdge, Amplitude, Distance;
                HOperatorSet.MeasurePos(DupImage, MeasureHandle, 1, 40, "all", "all", out RowEdge, out ColumnEdge, out Amplitude, out Distance);

                // 标记一个点用于观察
                HObject Cross;
                HOperatorSet.GenCrossContourXld(out Cross, RowEdge, ColumnEdge, 20, 0.785398);

                halconView1.DispImage(Image, true);
                halconView1.DispObject(Cross);
                DisplayMessage("运行流程测量", 10, 10, ColorFul.green);

                double[] DistanceArray = Distance.DArr; // 将 HTuple 转换为 double 数组

                for (int i = 0; i < DistanceArray.Length; i++)
                {
                    double radius = DistanceArray[i];

                    AddLog(0, $"检测到 {i}距离为: {Distance}");
                }

                // 关闭测量
                HOperatorSet.CloseMeasure(MeasureHandle);

                // 释放图像和对象的内存
                Image.Dispose();
                Rectangle.Dispose();
                DupImage.Dispose();
                Cross.Dispose();

            }

        }

        private void bt_Code_Click(object sender, EventArgs e)
        {


            // 创建文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                // Create a data code 2D model for QR Code
                HTuple dataCodeHandle;
                HOperatorSet.CreateDataCode2dModel("QR Code", new HTuple(), new HTuple(), out dataCodeHandle);

                // Read an image
                HObject image;
                HOperatorSet.ReadImage(out image, imagePath);

                // Find symbols in the image
                HObject symbolXLDs;
                HTuple resultHandles, decodedDataStrings;
                HOperatorSet.FindDataCode2d(image, out symbolXLDs, dataCodeHandle, new HTuple(), new HTuple(), out resultHandles, out decodedDataStrings);
                HOperatorSet.SetColor(halconView1.HalconWindow, "red"); // Change "red" to your desired color
                halconView1.DispImage(image, true);
                halconView1.DispObject(symbolXLDs);
                
                DisplayMessage("运行条码识别", 10, 10, ColorFul.green);

                // Clear the data code 2D model
                HOperatorSet.ClearDataCode2dModel(dataCodeHandle);


                AddLog(0, "读取到的条码为：" + decodedDataStrings[0]);


                image.Dispose();
                symbolXLDs.Dispose();
            }

        }





    }
}
