using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FanSwProject
{

    public class LogRecord
    {
        //ReaderWriterLockSlim是用于实现读写锁定功能的类，允许多个线程同时进行读操作，但只允许一个线程进行写操作
        static ReaderWriterLockSlim LogWriteLock1 = new ReaderWriterLockSlim();
        static ReaderWriterLockSlim LogWriteLock2 = new ReaderWriterLockSlim();
        static ReaderWriterLockSlim LogWriteLock3 = new ReaderWriterLockSlim();
        public static void WriteOperLog(string strLog)
        {
            try
            {
                LogWriteLock1.EnterWriteLock();
                string sFilePath = "D:\\运行日志\\操作日志\\" + DateTime.Now.ToString("yyyyMM") + "操作日志";
                string sFileName = "操作日志." + DateTime.Now.ToString("dd") + ".log";
                sFileName = sFilePath + "\\" + sFileName; //文件的绝对路径

                if (!Directory.Exists(sFilePath))//验证路径是否存在
                {
                    Directory.CreateDirectory(sFilePath);
                    //不存在则创建
                }
                FileStream fs;
                StreamWriter sw;
                if (File.Exists(sFileName))
                //验证文件是否存在，有则追加，无则创建
                {
                    fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
                }
                sw = new StreamWriter(fs);
                //sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   " + strLog);
                sw.WriteLine(string.Format("{0}\t{1,-16}\t", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   ", strLog));
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                LogWriteLock1.ExitWriteLock();
            }

        }

        public static void WriteMesLog(string strLog, string strLog1)
        {
            try
            {
                LogWriteLock2.EnterWriteLock();
                string sFilePath = "D:\\运行日志\\上传记录\\" + DateTime.Now.ToString("yyyyMM") + "上传信息";
                string sFileName = "上传信息." + DateTime.Now.ToString("dd") + ".log";
                sFileName = sFilePath + "\\" + sFileName; //文件的绝对路径

                if (!Directory.Exists(sFilePath))//验证路径是否存在
                {
                    Directory.CreateDirectory(sFilePath);
                    //不存在则创建
                }
                FileStream fs;
                StreamWriter sw;
                if (File.Exists(sFileName))
                //验证文件是否存在，有则追加，无则创建
                {
                    fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
                }
                sw = new StreamWriter(fs);
                //sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   " + strLog);
                sw.WriteLine(string.Format("{0}\t{1,-16}\t{2,-10}\t", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   ", strLog, strLog1));
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                LogWriteLock2.ExitWriteLock();
            }
        }

        public static void WriteErrorLog(string strLog)
        {
            try
            {
                LogWriteLock3.EnterWriteLock();
                string sFilePath = "D:\\运行日志\\报警记录\\" + DateTime.Now.ToString("yyyyMM") + "报警信息";
                string sFileName = "报警信息." + DateTime.Now.ToString("dd") + ".log";
                sFileName = sFilePath + "\\" + sFileName; //文件的绝对路径

                if (!Directory.Exists(sFilePath))//验证路径是否存在
                {
                    Directory.CreateDirectory(sFilePath);
                    //不存在则创建
                }
                FileStream fs;
                StreamWriter sw;
                if (File.Exists(sFileName))
                //验证文件是否存在，有则追加，无则创建
                {
                    fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
                }
                sw = new StreamWriter(fs);
                //sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   " + strLog);
                sw.WriteLine(string.Format("{0}\t{1,-16}", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   ", strLog));
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                LogWriteLock3.ExitWriteLock();
            }

        }

    }
}
