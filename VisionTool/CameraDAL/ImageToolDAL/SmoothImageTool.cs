﻿using HalconDotNet;
using HOperatorSet_EX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionTool.ImageToolDAL
{
    [Serializable]
     public class SmoothImageTool :ImageTool
    {
        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName
        { get; set; }
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names
        { get; set; }
        public bool ResultLogic { get; set; }
        [NonSerialized]
         Dictionary<string, HObject> ho_Image = new  Dictionary<string, HObject>();
        [NonSerialized]
        HObject outImage;
        /// <summary>
        /// 输入图像
        /// </summary>
        public  Dictionary<string, HObject> Image
        {
            get { return ho_Image; }
            set { ho_Image = value; }
        }
        /// <summary>
        /// 图片
        /// </summary>
        public HObject OutImage
        {
            get { return outImage; }
            set { outImage = value; }
        }
        /// <summary>
        /// 滤波参数
        /// </summary>
        public HTuple Alpha
        { get; set; }
        /// <summary>
        /// 滤波器
        /// </summary>
        public string Filter
        { get; set; }
        public override string toolName()
        { return Names; }
        public override long toolTimer()
        {
            return timer;
        }
        public override void recon()
        { }
        public override void ini()
        {
            Names = Tool.平滑图像.ToString();
            Alpha = 0.5;
            Filter = "gauss";
        }
        public override void draw_roi()
        { }
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
            ResultLogic = true;
            try
            {
                HSystem.SetSystem("flush_graphic", "true");
                if (outImage != null)
                    outImage.Dispose();
                HOperatorSet.SmoothImage((HObject)ho_Image[ImageName], out outImage, Filter, Alpha);
                HSystem.SetSystem("flush_graphic", "false");
            }
            catch (HalconException ex)
            {
                HTuple hv_Exception;
                ex.ToHTuple(out  hv_Exception);
                HOperatorSet_Ex.disp_message(WindowControl.HalconWindow, Names + "{" + hv_Exception + "}", CoordSystem.window.ToString(), 10, 10, "red", "false");
                ResultLogic = false;//结果异常
                HSystem.SetSystem("flush_graphic", "false");
            }
        }
        public override void dispresult()
        {
            HSystem.SetSystem("flush_graphic", "true");
            //HOperatorSet.DispObj(outImage, WindowControl.HalconWindow);
            HSystem.SetSystem("flush_graphic", "false");
        }
        public override long set_after()
        {
            try
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                HOperatorSet.ClearWindow(WindowControl.HalconWindow);
                HSystem.SetSystem("flush_graphic", "true");
                //HOperatorSet.DispObj((HObject)ho_Image[ImageName], WindowControl.HalconWindow);
                HSystem.SetSystem("flush_graphic", "false");
                run();
                dispresult();
                HSystem.SetSystem("flush_graphic", "true");
                HOperatorSet.DispObj(outImage, WindowControl.HalconWindow);
                HSystem.SetSystem("flush_graphic", "false");
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
    }
}
