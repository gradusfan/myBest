using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFF_Vision.BLL
{
 
    public class RegClassBLL
    {
        RegClassDAL reg = new RegClassDAL();

        #region 完成只读属性
        /// <summary>
        /// CPU 字符串
        /// </summary>
        public string CPU
        {
            get
            {
                return reg.CPU;
            }
        }
        /// <summary>
        /// HDD 硬盘字符串
        /// </summary>
        public string DiskVolumeSerialNumber
        {
            get { return reg.DiskVolumeSerialNumber; }
        }
        /// <summary>
        /// 密钥
        /// </summary>
        public string MachineNum
        {
            get { return reg.MachineNum; }
        }
        /// <summary>
        /// 注册表的Key值
        /// </summary>
        public string RegKey
        {
            get { return reg.RegKey; }
        }
        #endregion
        /// <summary>
        /// 获取密钥
        /// </summary>
        /// <returns>密钥</returns>
        public string GetMNum()
        {
            return reg.GetMNum();
        }

        /// <summary>
        /// 注册表读值
        /// </summary>
        /// <returns></returns>
        public bool GetRegistryKey()
        {
            return reg.GetRegistryKey();
        }
        /// <summary>
        /// 注册表设值
        /// </summary>
        /// <returns></returns>
        public bool SetRegistryKey()
        {
            return reg.SetRegistryKey();
        }
    }
}
