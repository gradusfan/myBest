using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFF_Vision.BLL
{
    public class LogBLL
    {

        LogDAL log = new LogDAL();
        public LogBLL(string strPath)
        {
            log.Path = strPath;
        }
        /// <summary>
        /// 写运行日志
        /// </summary>
        /// <param name="str"></param>
        public void WriteRunLog(string str)
        {
            log.write_run_log(str);
        }
        /// <summary>
        /// 写系统日志
        /// </summary>
        /// <param name="str"></param>
        public void WriteSysLog(string str)
        {
            log.write_sys_log(str);
        }
        /// <summary>
        /// 读日志
        /// </summary>
        /// <param name="str"></param>
        public void ReadLog(string str)
        {
           log.Read_log(str);
        }

    }
}
   

