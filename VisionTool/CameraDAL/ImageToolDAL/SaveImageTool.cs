using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using  XFF_Vision;

namespace VisionTool.ImageToolDAL
{

   
    [Serializable]
    public class SaveImageTool : ImageTool
    {
        [NonSerialized]
         Dictionary<string, HObject> ho_Image = new  Dictionary<string, HObject>();
        /// <summary>
        /// 输入图像
        /// </summary>
       
        public string ImagePath1;
        public  Dictionary<string, HObject> Image
        {
            get { return ho_Image; }
            set { ho_Image = value; }
        }
        //public string ImageNametm { get; set; }
        #region 参数
        public string ImageName { get; set; }

        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names1 { get; set; }
        public string Names { get; set; }
        /// <summary>
        /// 保存带文字图形的图片
        /// </summary>
        public bool IsDumpWindow { get; set; }
        /// <summary>
        /// 保持NG图片
        /// </summary>
        public bool IsDumpWindowNG { get; set; }
        /// <summary>
        /// 图片格式
        /// </summary>
        public string ImageFormat { get; set; }
        /// <summary>
        /// 保存路径
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 删除过期的文件夹
        /// </summary>
        public bool IsDeleteDir { get; set; }
        /// <summary>
        /// 保存天数
        /// </summary>
        public  string SaveDay { get; set; }
     

        #endregion
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
            Names = Tool.存储图像.ToString();
            ImageName = "采集图片0";
            ImageFormat = "bmp";
            IsDeleteDir = false;
            IsDumpWindow = false;
            IsDumpWindowNG = false;
            SaveDay = "1";
            ImagePath = "E:\\AOI\\Image";
        }
        /// <summary>
        /// 运行一次
        /// </summary>
        //public override void run()
        //{
        //    Stopwatch watch = new Stopwatch();
        //    watch.Start();
        //    toolRun();
        //    dispresult();
        //    watch.Stop();
        //    timer = watch.ElapsedMilliseconds;
        //}
        public override void run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            toolRun("");
            dispresult();
            watch.Stop();
            timer = watch.ElapsedMilliseconds;
        }
        public void toolRun(string str)
        {
            try
            {
                if (IsDeleteDir)
                    DeleteDir(ImagePath, Convert.ToInt16(SaveDay));
              
                if (IsDumpWindowNG && str == "NG")//保存NG图片
                {
                    dump_image(WindowControl.HalconWindow, str, ImageFormat);
                } 
                if (!IsDumpWindow && !IsDumpWindowNG)//保存原图
                {
                    write_image((HObject)ho_Image[ImageName], Names, ImageFormat);
                }
                if (IsDumpWindow )//保存带图形图片
                {
                    dump_image(WindowControl.HalconWindow, str, ImageFormat);
                }
                // write_image((HObject)ho_Image[ImageName], Names, ImageFormat);
                //else
                //    write_image((HObject)ho_Image[ImageName], Names, ImageFormat);
            }
            catch
            {
              //  ResultLogic = false;//结果异常
            }
        }
        public override void dispresult()
        { }
        public override long set_after()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            run();
            watch.Stop();
            timer = watch.ElapsedMilliseconds;
            return watch.ElapsedMilliseconds;
        }
        /// <summary>
        ///  写图片
        /// </summary>
        /// <param name="ho_Image">图片变量</param>
        /// <param name="name">图片名</param>
        /// <param name="imagefomrat">图片格式 "jpg"</param>
        public void write_image(HObject ho_Image, string name, string imagefomrat)
        {
            string Image_dirName = DateTime.Now.ToString("yyyy-MM-dd");//文件夹名
            string Image_fileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");//文件名
            string savepath = ImagePath + @"\" + Image_dirName + @"\" + name + "_" + Image_fileName;
            if (!Directory.Exists(ImagePath))
                Directory.CreateDirectory(ImagePath);
            if (!Directory.Exists(ImagePath + @"\" + Image_dirName))
                Directory.CreateDirectory(ImagePath + @"\" + Image_dirName);//
            if (ho_Image != null)
                HOperatorSet.WriteImage(ho_Image, imagefomrat, 0, savepath);
          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwin"></param>
        /// <param name="name">图片名</param>
        /// <param name="imagefomrat">图片格式 "jpg"</param>
        public void dump_image(HTuple hwin, string name, string imagefomrat)
        {
            try {
                string Image_dirName = DateTime.Now.ToString("yyyy-MM-dd");//文件夹名
                string Image_fileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");//文件名     
                
                string savepath = ImagePath + @"\" + Image_dirName + @"\" + name + "_" + Image_fileName;
                if (!Directory.Exists(ImagePath))
                    Directory.CreateDirectory(ImagePath);
                if (!Directory.Exists(ImagePath + @"\" + Image_dirName))
                    Directory.CreateDirectory(ImagePath + @"\" + Image_dirName);
                if(hwin != null)
                HOperatorSet.DumpWindow(hwin, imagefomrat, savepath);
             
            }
            catch
            {
                
            }
        }

      


        /// <summary>
        /// 删除超过时间的文件夹
        /// </summary>
        /// <param name="pathDirect">文件夹</param>
        /// <param name="saveDay">天数</param>
        public bool DeleteDir(string pathDirect, int saveDay)
        {
            try
            {
                DateTime nowTime = DateTime.Now;
                DirectoryInfo di = new DirectoryInfo(pathDirect);
                DirectoryInfo[] subDirectories = di.GetDirectories();//获得目录 
                foreach (DirectoryInfo dir in subDirectories)
                {
                    TimeSpan t = (nowTime - dir.CreationTime);  //当前时间减去文件夹创建时间
                    int day = t.Days;
                    if (day > saveDay-1)   //保存的时间 ；  单位：天
                    {
                        Directory.Delete(dir.FullName,true);
                    //  dir.Delete();//删除超过时间的文件夹
                    }
                }
                return true;
            }
            catch
            {
              return  false;
            }
        }
        public bool DeleteFile(string fileDirect, int saveDay)
        {
            DateTime nowTime = DateTime.Now;
            string[] files = Directory.GetFiles(fileDirect, "*.txt", SearchOption.AllDirectories);  //获取该目录下所有 .txt文件
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TimeSpan t = nowTime - fileInfo.CreationTime;  //当前时间  减去 文件创建时间
                int day = t.Days;
                if (day > saveDay)   //保存的时间 ；  单位：天
                {
                    File.Delete(file);  //删除超过时间的文件
                }
            }
            return true;
        }
        public string ImageNam(string ImageNam)
        {
            string Image_dirName = DateTime.Now.ToString("yyyy-MM-dd");//文件夹名
            string Image_fileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");//文件名     
            string savepath = ImagePath1 + @"\" + Image_dirName + @"\" + ImageNam + "_" + Image_fileName;
            //ImageNametm= ImageNam ;
            return (savepath);
        }

       
        //public override bool toolResult()
        //{
        //    return ResultLogic;
        //}
    }
}
