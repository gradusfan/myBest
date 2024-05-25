using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFF_Vision
{
   public class SerializeDAL
    {
       /// <summary>
       /// 序列化所有工具
       /// </summary>
       /// <param name="o">面對對象</param>
       /// <param name="str_path"></param>
       public static bool Write(object o,   string str_path)
       {
           try
           {
               using (FileStream fs = new FileStream(str_path, FileMode.Create, FileAccess.Write))//保存数据
               {
                   BinaryFormatter bf = new BinaryFormatter();
                   bf.Serialize(fs, o);//序列化所有工具
             }
               return true;
           }
           catch 
           {
               return false;
           }
       }
       /// <summary>
       /// 反序列化所有工具
       /// </summary>
       /// <param name="str_path"></param>
       /// <returns></returns>
       public static object Read(string str_path)
       {  try
           {
               using (FileStream fs = new FileStream(str_path, FileMode.Open, FileAccess.Read))
               {
                   BinaryFormatter bf = new BinaryFormatter();
                   return bf.Deserialize(fs);//反序列化所有工具
               }
           }
           catch (System.Exception ex)
           {
                MessageBox.Show("数据读取失败!" + ex.Message);
                return null;
           }
       }
    }
}
