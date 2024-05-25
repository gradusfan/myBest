using HalconDotNet;
using HOperatorSet_EX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ViewControl;
using VisionTool.ImageToolDAL;
using XFF_Vision.BLL;

namespace XFF_Vision.DAL
{
    public class ProgramDAL
    {
        /// <summary>
        /// 运行流程
        /// </summary>
        /// <param name="halconView">窗口</param>
        /// <param name="tool">工具</param>
        /// <param name="flowExecute">流程对象</param>
        public static int ProgramRun(HalconView halconView, ref HTuple acqHandle, List<ImageTool> tool, FlowExecuteDAL flowExecute, out long timer)
        {
            int step = 0;
            Stopwatch watch = new Stopwatch();
            try
            {
                timer = 0;
                flowExecute.Clear();
                watch.Start();//开始计时
                foreach (ImageTool it in tool)
                {
                    if (it is AcqFifoTool)
                    {
                        AcqFifoTool acqFifoTool = it as AcqFifoTool;
                        if (acqHandle != null && acqHandle > 0)
                        {

                            acqFifoTool.AcqHandle = acqHandle;
                        }
                    }
                    flowExecute.flowExecute(it);
                    //Thread.Sleep(2);
                    if (it is AcqFifoTool)
                    {
                        AcqFifoTool acqFifoTool = it as AcqFifoTool;
                        if (acqFifoTool.AcqHandle != null && acqFifoTool.AcqHandle > 0)
                        {
                            acqHandle = acqFifoTool.AcqHandle;
                        }
                    }
                    step++;
                }
                watch.Stop();
                timer = watch.ElapsedMilliseconds;
                foreach (var item in flowExecute.CollectiveImage.Keys)
                {
                    HObject img = flowExecute.CollectiveImage[item];
                    halconView.DispImage(img, false);
                }
                halconView.Image = flowExecute.CollectiveImage;
                halconView.ShowImg();
                return step;
            }
            catch (Exception e)
            {
                try
                {
                    foreach (var item in flowExecute.CollectiveImage.Keys)
                    {
                        HObject img = flowExecute.CollectiveImage[item];
                        halconView.DispImage(img, false);
                    }
                    halconView.Image = flowExecute.CollectiveImage;
                    halconView.ShowImg();
                }
                catch
                {
                    //timer = 0;
                    HSystem.SetSystem("flush_graphic", "true");
                    halconView.disp_message("运行流程" + (step + 1).ToString() + "错误！", ImageTool.CoordSystem.window.ToString(), 10, 10, ImageTool.ColorFul.yellow.ToString(), "false", ImageTool.ColorFul.orange.ToString());
                    HSystem.SetSystem("flush_graphic", "false");
                    //return 0;
                }
                timer = 0;
                //HSystem.SetSystem("flush_graphic", "true");
                //halconView.disp_message("运行流程" + (step + 1).ToString() + "错误！", ImageTool.CoordSystem.window.ToString(), 10, 10, ImageTool.ColorFul.yellow.ToString(), "false", ImageTool.ColorFul.orange.ToString());
                //HSystem.SetSystem("flush_graphic", "false");
                return 0;
            }

        }
        /// <summary>
        /// 关闭流程中的相机
        /// </summary>
        /// <param name="tool"></param>
        public static void CloseCamera(List<ImageTool> tool)
        {
            foreach (ImageTool t1 in tool)
            {
                if (t1 is AcqFifoTool)
                {
                    AcqFifoTool acqFifoTool = t1 as AcqFifoTool;//加载数据,关闭相机
                    acqFifoTool.CloseCamera();
                }
            }
        }
        /// <summary>
        /// 打开流程中的相机
        /// </summary>
        /// <param name="tool"></param>
        public static bool OpenCamera(List<ImageTool> tool, ref HTuple acqHandle)
        {
            if (tool == null)
                return false;
            foreach (ImageTool t1 in tool)
            {
                if (t1 is AcqFifoTool)
                {
                    AcqFifoTool acqFifoTool = t1 as AcqFifoTool;//加载数据,打开相机
                    bool b = false;
                    if (!acqFifoTool.IsUseImg)
                    {
                        acqFifoTool.recon();
                        b = acqFifoTool.OpenCamera();
                        acqHandle = acqFifoTool.AcqHandle;
                        return b;
                    }
                }
            }
            return true;
        }
        public static bool OpenCamera(int camNo, ref HTuple acqHandle)
        {
            List<ImageTool> tool = new List<ImageTool>();
            string toolPath = "";
            if (camNo==1)
                toolPath = Product.Instance.VisionPath + Product.Instance.CurrentModel + @"\RUN.vin";
            else
                toolPath = Product.Instance.VisionPath + Product.Instance.CurrentModel + @"\RUN"+camNo+".vin";
            tool.Clear();
            tool = SerializeBLL.Read(toolPath) as List<ImageTool>;//反序列化所有工具
            if (acqHandle == null)
                return OpenCamera(tool, ref acqHandle);//打开相机
            return false;
        }
    }
}
