using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionTool.ImageToolDAL
{
    [Serializable]
    public  class BlockTool:ImageTool
    {
        List<ImageTool> tool1 = new List<ImageTool>();
        FlowExecuteDAL flowExecute1 = new FlowExecuteDAL();

        public override string toolName()
        {
            return "";
        }
        public override long toolTimer()
        {
            return 0;
        }
        public override void recon()
        { }
        public override void ini()
        {
        }
        public override void draw_roi()
        { }
        public override void run()
        { }
        public override void dispresult()
        { }
        public override long set_after()
        { return 0; }



    }
}
