using HalconDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFF_Vision
{
  public class ImageDAL
     {
        string Image_path;//文件路径
        public ImageDAL(string path)
        {
            Image_path = path;
        }
        /// <summary>
        ///  写图片
        /// </summary>
        /// <param name="ho_Image">图片变量</param>
        /// <param name="name">图片名</param>
        /// <param name="imagefomrat">图片格式</param>
        public void write_image(HObject ho_Image, string name, string imagefomrat)
        {   string Image_dirName = DateTime.Now.ToString("yyyy-MM-dd");//文件夹名
            string Image_fileName = DateTime.Now.ToString("HH时mm分ss秒");//文件名
            string savepath = Image_path + @"\" + Image_dirName + @"\" + name+"#_" + Image_fileName;
            if (!Directory.Exists(Image_path))
                Directory.CreateDirectory(Image_path);
            if (!Directory.Exists(Image_path + @"\" + Image_dirName))
                Directory.CreateDirectory(Image_path + @"\" + Image_dirName);
            HOperatorSet.WriteImage(ho_Image, imagefomrat, 0, savepath);
        }
       /// <summary>
       /// 读图片
       /// </summary>
       /// <param name="path"></param>
       /// <param name="pb"></param>
        public void Read_image(string path, PictureBox pb)
        {
            try
            {   pb.Load(path);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            { }
        }
    }
}
