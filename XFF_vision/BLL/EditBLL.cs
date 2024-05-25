using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;
using XFF_Vision.DAL;


namespace XFF_Vision.BLL
{
    public  class EditBLL
    {
        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        public static void UpEdit(ListView listView, List<ImageTool> tool)
        { EditDAL.UpEdit(listView, tool); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        public static void DownEdit(ListView listView, List<ImageTool> tool)
        { EditDAL.DownEdit(listView, tool); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        public static void RemoveAt(ListView listView, List<ImageTool> tool)
        { EditDAL.RemoveAt(listView, tool); }

        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool">工具表</param>
        public static void Clear(ListView listView, List<ImageTool> tool)
        { EditDAL.Clear(listView, tool); }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool">工具表</param>
        /// <param name="it">工具</param>
        /// <param name="str">工具名</param>
        public static void Add(ListView listView, List<ImageTool> tool, ImageTool it, string[] str, HWindowControl hwin)
        {
            EditDAL.Add(listView, tool, it, str, hwin);
        }
        /// <summary>
        /// 指定位置插入工具
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        /// <param name="it"></param>
        /// <param name="str"></param>
        /// <param name="hwin"></param>
        public static void Insert(ListView listView, List<ImageTool> tool, ImageTool it, string[] str, HWindowControl hwin)
        {
            EditDAL.Insert(listView, tool, it, str, hwin);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool">工具表</param>
        /// <param name="it">工具</param>
        /// <param name="str">工具名</param>
        public static void Add(ListView listView, List<ImageTool> tool, ImageTool it, string[] str, HTuple hwin)
        {
            EditDAL.Add(listView, tool, it, str, hwin);
        }
        /// <summary>
        /// 指定位置插入工具
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        /// <param name="it"></param>
        /// <param name="str"></param>
        /// <param name="hwin"></param>
        public static void Insert(ListView listView, List<ImageTool> tool, ImageTool it, string[] str, HTuple hwin)
        {
            EditDAL.Insert(listView, tool, it, str, hwin);
        }



        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="listbox"></param>
        /// <param name="tool">工具表</param>
        public static void UpEdit(ListBox listbox, List<ImageTool> tool)
     {  EditDAL.UpEdit(listbox, tool); }
        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="listbox"></param>
     /// <param name="tool">工具表</param>
     public static void DownEdit(ListBox listbox, List<ImageTool> tool)
     {  EditDAL.DownEdit(listbox, tool);}
       /// <summary>
       /// 移除
       /// </summary>
       /// <param name="listbox"></param>
     /// <param name="tool">工具表</param>
     public static void RemoveAt(ListBox listbox, List<ImageTool> tool)
     { EditDAL.RemoveAt(listbox, tool);}
     /// <summary>
     /// 清除
     /// </summary>
     /// <param name="listbox"></param>
     /// <param name="tool">工具表</param>
        public static void Clear(ListBox listbox, List<ImageTool> tool)
        {  EditDAL.Clear(listbox, tool); }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="listbox"></param>
        /// <param name="tool">工具表</param>
        /// <param name="it">工具</param>
        /// <param name="str">工具名</param>
        public static void Add(ListBox listbox, List<ImageTool> tool, ImageTool it, string str, HTuple hwin)
        {
            EditDAL.Add(listbox, tool, it, str, hwin);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="listbox"></param>
        /// <param name="tool">工具表</param>
        /// <param name="it">工具</param>
        /// <param name="str">工具名</param>
        public static void Add(ListBox listbox, List<ImageTool> tool, ImageTool it, string str, HWindowControl hwin)
        {
            EditDAL.Add(listbox, tool, it, str, hwin);
        }
        /// <summary>
        /// 指定位置插入工具
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="tool"></param>
        /// <param name="it"></param>
        /// <param name="str"></param>
        /// <param name="hwin"></param>
        public static void Insert(ListBox listbox, List<ImageTool> tool, ImageTool it, string str,HTuple hwin)
        {
            EditDAL.Insert(listbox, tool, it, str,hwin);
        }
        /// <summary>
        /// 插入工具
        /// </summary>
        /// <param name="listbox"></param>
        /// <param name="tool"></param>
        /// <param name="it"></param>
        /// <param name="str"></param>
        /// <param name="hwin"></param>
        public static void Insert(ListBox listbox, List<ImageTool> tool, ImageTool it, string str, HWindowControl hwin)
        {
            EditDAL.Insert(listbox, tool, it, str, hwin);
        }
    }
  
}
