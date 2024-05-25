using Microsoft.Win32;
using System;
using System.Management;
using System.Security.Cryptography;
using System.Threading;

namespace XFF_Vision
{
    class RegClassDAL
    {
        
        #region 声明字段
        private string _CPU;                        //  CPU
        private string _DiskVolumeSerialNumber;     //  DiskVolumeSerialNumber
        private string _MachineNum;                 //  MachineNum
        private string _regKey;                     //  设置注册表的Key值
        RegistryKey LocalMachine = Registry.LocalMachine;
        #endregion

        #region 完成只读属性
        /// <summary>
        /// CPU 字符串
        /// </summary>
        public string CPU
        {
            get { return _CPU; }
        }
        /// <summary>
        /// HDD 硬盘字符串
        /// </summary>
        public string DiskVolumeSerialNumber
        {
            get { return _DiskVolumeSerialNumber; }
        }
        /// <summary>
        /// 密钥
        /// </summary>
        public string MachineNum
        {
            get { return _MachineNum; }
        }
        /// <summary>
        /// 注册表的Key值
        /// </summary>
        public string RegKey
        {
            get { return _regKey; }
        }
        #endregion

        #region 构造函数
        public RegClassDAL()
        {
            this._CPU = getCPU();
            this._DiskVolumeSerialNumber = GetDiskVolumeSerialNumber();
            this._MachineNum = GetMNum();
            GetRegistryKey();
        }
        #endregion
        #region 函数
        /// <summary>
        /// 获取CPU
        /// </summary>
        /// <returns>CPU字符串</returns>
        public string getCPU()
        {
            string strCPU = null;
            ManagementClass myCPU = new ManagementClass("win32_Processor");
            ManagementObjectCollection myCPUConnection = myCPU.GetInstances();
            foreach (ManagementObject myObject in myCPUConnection)
            {
                strCPU = myObject.Properties["Processorid"].Value.ToString();
                break;
            }
            return strCPU;
        }
        /// <summary>
        /// 获取卷轴字符串
        /// </summary>
        /// <returns>卷轴字符串</returns>
        public string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        /// <summary>
        /// 获取网卡硬件地址
        /// </summary>
        /// <returns></returns> 
        public string GetMacAddress()
        {
            var mac = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc = mc.GetInstances();
            mc.Get();
            return mac =mc["MacAddress"].ToString();
        }

        /// <summary>
        /// 获取密钥
        /// </summary>
        /// <returns>密钥</returns>
        public string GetMNum()
        {
            string strNum = getCPU() + GetDiskVolumeSerialNumber();     //获得24位Cpu和硬盘序列号
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(strNum);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("G");
            }
            return byte2String;
        }
 
        /// <summary>
        /// 注册表读值
        /// </summary>
        /// <returns></returns>
        public bool GetRegistryKey()
         {
            try
             {
                 using (RegistryKey software = LocalMachine.OpenSubKey("SOFTWARE\\Licence", true))
                 {
                   //  _regKey = software.GetValue("licence").ToString();
                     return true;
                 }
             }
             catch
             {
                 return false;
             }
         }
       /// <summary>
        /// 注册表设值
       /// </summary>
       /// <returns></returns>
        public bool SetRegistryKey()
         {
             try
             {
                 using (RegistryKey software = LocalMachine.OpenSubKey("SOFTWARE\\Licence", true))
                 {
                     software.SetValue("licence", _MachineNum, RegistryValueKind.String);
                     return true;
                 }
                 //注意该方法后面还可以有一个布尔型的参数，true表示可以写入。
             }
            catch
             {
                 return false;
             }
         }

       
        #endregion
    }
}