using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VisionCon.ImageToolCon
{
    [Serializable]
    public class ImageTool
    {
        [NonSerialized]
        public long timer;
        [NonSerialized]
        HTuple halconWindow;
        [NonSerialized]
        HWindowControl windowControl;
        public HWindowControl WindowControl
        {
            get
            {
                return windowControl;
            }
            set
            {
                windowControl = value;
            }
        }
        public enum Roi
        {
            圆 = 0,
            矩形 = 1,
            方向矩形 = 2
        }
        public enum Set_draw
        {
            margin = 0,
            fill = 1
        }
        public enum ColorFul
        {
            black,
            blue,
            yellow,
            red,
            green,
            cyan,
            magenta,
            coral,
            pink,
            white,
            gray,
            orange,
        }
        public enum Tool
        {
           特征选择=0

        }
        public enum CoordSystem
        {
            window,
            image
        }
        public virtual string toolName()
        { return "";}
        public virtual long toolTimer()
        {  return 0; }
        public virtual void recon()
        { }
        public virtual void ini()
        { }
        public virtual void draw_roi()
        { }
        public virtual void run()
        { }
        public virtual void dispresult()
        { }
        public virtual long set_after()
        { return 0; }
    }
}
