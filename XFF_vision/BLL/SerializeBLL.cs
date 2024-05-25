using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFF_Vision.BLL
{
     public class SerializeBLL
    {
         /// <summary>
         /// 反序列化对象
         /// </summary>
         /// <param name="str_path"></param>
         /// <returns></returns>
         public static object Read(string str_path)
         {
             return SerializeDAL.Read(str_path);
         }
         /// <summary>
         /// 序列化对象
         /// </summary>
         /// <param name="o"></param>
         /// <param name="str_path"></param>
         /// <returns></returns>
          public static bool Write(object o,   string str_path)
         {
               return   SerializeDAL.Write(o,str_path);
          }
    }
}
