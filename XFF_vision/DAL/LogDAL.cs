using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace XFF_Vision
{
   public  class LogDAL
    {
        string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        string dir_path;//文件夹路径
        string file_path;//文件路径
        public LogDAL()
        {
        }
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="str"></param>
        public  void write_log(string str)
        {
            string file_name = DateTime.Now.ToString("yyyy-MM-dd");
            dir_path = this.path + @"\" + file_name + ".log";
            if (!Directory.Exists(dir_path))
                Directory.CreateDirectory(dir_path);
            using (StreamWriter sw = new StreamWriter(file_path, true))
            {
                if (!File.Exists(file_path))
                    File.Create(file_path);
                sw.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "    " + str + "\r\n");
            }
        }
        public  void write_run_log(string str)
        {
            string file_name = DateTime.Now.ToString("yyyy-MM-dd"); //系统日期创建文件夹
            dir_path = this.path + @"\run_log";
            file_path = dir_path + @"\" + file_name + ".log";
            if (!Directory.Exists(this.path))
                Directory.CreateDirectory(this.path);
            if (!Directory.Exists(dir_path))
                Directory.CreateDirectory(dir_path);
            using (StreamWriter sw = new StreamWriter(file_path, true))
            {
                if (!File.Exists(file_path))
                    File.Create(file_path);
                sw.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "    " + str + "\r\n");
            }
        }
        public  void write_sys_log(string str)
          {
              string file_name = DateTime.Now.ToString("yyyy-MM-dd"); //系统日期创建文件夹
              dir_path = this.path + @"\sys_log";
              file_path = dir_path + @"\" + file_name + ".log";
              if (!Directory.Exists(this.path))
                  Directory.CreateDirectory(this.path);
              if (!Directory.Exists(dir_path))
                  Directory.CreateDirectory(dir_path);
              using (StreamWriter sw = new StreamWriter(file_path, true))
              {
                  if (!File.Exists(file_path))
                      File.Create(file_path);
                  sw.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "    " + str + "\r\n");
              }
          }

        /// <summary>
        /// 读日志
        /// </summary>
        /// <returns></returns>
     public string Read_log(string path)
     {
         try
         {
             using (StreamReader sr = new StreamReader(path))
             {
                 return (sr.ReadToEnd());
             }
         }
         catch { return (""); }
        }
    }
}
