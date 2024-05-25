using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewControl;
using VisionTool.ImageToolDAL;
using XFF_Vision.DAL;


namespace XFF_Vision.BLL
{
     public class ProgramBLL
    {
      
        /// <summary>
        /// 运行流程
        /// </summary>
        /// <param name="halconView">窗口</param>
        /// <param name="tool">工具</param>
        /// <param name="flowExecute">流程对象</param>
         public static int Run(HalconView halconView, ref HTuple acqHandle, List<ImageTool> tool, FlowExecuteDAL flowExecute, out long timer)
         {
              return  ProgramDAL.ProgramRun(halconView,ref acqHandle, tool, flowExecute,out timer);
         }
         /// <summary>
         /// 关闭流程中的相机
         /// </summary>
         /// <param name="tool"></param>
         public static void CloseCamera(List<ImageTool> tool)
         {
             ProgramDAL.CloseCamera(tool);
         }
         /// <summary>
         /// 打开流程中的相机
         /// </summary>
         /// <param name="tool"></param>
         public static bool OpenCamera(List<ImageTool> tool, ref HTuple acqHandle)
         {
             return ProgramDAL.OpenCamera(tool, ref acqHandle);
         }

         public static bool OpenCamera(int camNo, ref HTuple acqHandle)
         {
             return ProgramDAL.OpenCamera(camNo, ref  acqHandle);
         }

    }
}
