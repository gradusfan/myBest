using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFF_Vision
{
    public class EventArgsDAL : EventArgs
    {
        public EventArgsDAL()
        { }
        /// <summary>
        /// 图像
        /// </summary>
        public HObject Image
        { get; set; }
        /// <summary>
        /// 图像句柄
        /// </summary>
        public HTuple AcqHandle
        { get; set; }
        public HTuple InfoList
        { get; set; }
        public HTuple DeviceList
        { get; set; }
        public HTuple FrameRate
        { get; set; }

    }
}
