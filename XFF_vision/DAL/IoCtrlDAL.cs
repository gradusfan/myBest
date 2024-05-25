
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFF_Vision.DAL
{
    public class IoCtrlDAL
    {

        /// <summary>
        /// 十六进制转二进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
      public static  string HexToBin(string str)
        {
            string[] h2b = {
              "0000",
              "0001",
              "0010",
              "0011",
              "0100",
              "0101",
              "0110",
              "0111",
              "1000",
              "1001",
              "1010",
              "1011",
              "1100",
              "1101",
              "1110",
              "1111",
            };
            if (string.Equals(str, null))
            {
                return "";
            }
            string[] b = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                b[i] = str[i] >= 'a' ? h2b[str[i] - 'a' + 10] : str[i] >= 'A' ? h2b[str[i] - 'A' + 10] : h2b[str[i] - '0'];
            }
            string B = string.Join("", b); // 
            return (B);
        }
        /// <summary>
        /// 设置某位为1
        /// </summary>
        /// <param name="data">原始数据</param>
        /// <param name="index">目标位</param>
        /// <param name="flag">目标值</param>
        /// <returns></returns>
      public static uint SetBitValue(int data, int index, bool flag)
        {
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (uint)(data | v) : (uint)(data & ~v);
        }
      public static void SetBitValue(short m_dev, ref uint out_value, int bitValue, bool isState)
      {
          short ret;
          if (bitValue == 0)//复位所有输出
              out_value = 0;
          out_value = SetBitValue((int)out_value, bitValue, isState);//设置位
          ret = DASK.DO_WritePort((ushort)m_dev, 0, out_value);
          if (ret < 0)
          {
              MessageBox.Show("DO_WritePort error!");
          }
      }
        /// <summary>
        /// 获取某位值
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index">目标位</param>
        /// <returns></returns>
      public static int GetBitValue(int data, int index)
        {
            int value;
            value = index > 0 ? data >> index - 1 : data;
            return value &= 1;
        }

      //public static void io_show(short m_dev, IO_Ctrlcs iO_Ctrlcs)
      //{
      //    uint in_value,out_value;
      //    while (true)
      //    {
      //        short ret;
      //        ret = DASK.DI_ReadPort((ushort)m_dev, 0, out in_value);
      //        if (ret < 0)
      //        {
      //            MessageBox.Show("DI_ReadPort error!");
      //            return;
      //        }
      //        ret = DASK.DO_ReadPort((ushort)m_dev, 0, out out_value);
      //        if (ret < 0)
      //        {
      //            MessageBox.Show("DI_ReadPort error!");
      //            return;
      //        }
      //        iO_Ctrlcs.IO_Show(in_value, out_value);

      //    }
      //}
      public const int IDO_0 = 1;
      public const int IDO_1 = 2;
      public const int IDO_2 = 3;
      public const int IDO_3 = 4;
      public const int IDO_4 = 5;
      public const int IDO_5 = 6;
      public const int IDO_6 = 7;
      public const int IDO_7 = 8;
      public const int IDO_8 = 9;
      public const int IDO_9 = 10;
      public const int IDO_10 = 11;
      public const int IDO_11 = 12;
      public const int IDO_12 = 13;
      public const int IDO_13 = 14;
      public const int IDO_14 = 15;
      public const int IDO_15 = 16;
      public const int IDO_16 = 17;
      public const int IDO_17 = 18;
      public const int IDO_18 = 19;
      public const int IDO_19 = 20;
      public const int IDO_20 = 21;
      public const int IDO_21 = 22;
      public const int IDO_22 = 23;
      public const int IDO_23 = 24;
      public const int IDO_24 = 25;
      public const int IDO_25 = 26;
      public const int IDO_26 = 27;
      public const int IDO_27 = 28;
      public const int IDO_28 = 29;
      public const int IDO_29 = 30;
      public const int IDO_30 = 31;
      public const int IDO_31 = 32;
      public const int IDO_OFF = 0;

    }
}
