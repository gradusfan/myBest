using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFF_Vision
{
    [Serializable]
    public class sysConfig
    {
        public int curproindex = 1;
        public double cx = 1;
        public double cy = 1;
        public double angle = 0.0;

        //左边位置
        public double leftx = 0.0;
        public double lefty = 0.0;
        public double leftz = 0.0;
        public double leftu = 0.0;

        public double leftxp = 0.0;
        public double leftyp = 0.0;

        //右边位置
        public double rightx = 0.0;
        public double righty = 0.0;
        public double rightz = 0.0;
        public double rightu = 0.0;

        public double rightxp = 0.0;
        public double rightyp = 0.0;
    }
}
