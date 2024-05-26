
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FanSwProject.commonlib
{
   
   public class ReadandWriteINI
    {
        #region 引用系统自带的 Kenl32.dll

        [DllImport("kernel32")] //win32 dll 对应的命令

        //写配置文件ini 返回0 表示失败的 非0 表示成功（C# 掉用非托管类型的DLL）
        private static extern long WritePrivateProfileString(string section, string key1, string value1, string filePath);

        [DllImport("kernel32")] //win32 dll 对应的命令

        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 读取方法
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="NoText"></param>
        /// <param name="iniFilePath"></param>
        /// <returns></returns>
        public static string ReadIni(string Section, string Key, string NoText, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                return temp.ToString();


            }
            else
            {
                return string.Empty;
            }


        }



        public static bool WriteIni(string section, string key1, string value1, string iniFilePath)
        {

            if (File.Exists(iniFilePath))
            {

                return WritePrivateProfileString(section,key1, value1,iniFilePath) != 0;

            }
            else
            {
                CreateIniIfNotExists(iniFilePath);
                return false;

            }
           
        }

        public static void CreateIniIfNotExists(string iniFilePath)
        {
            if (!File.Exists(iniFilePath))
            {
                File.Create(iniFilePath).Close();
            }
        }



        #endregion
    }
}
