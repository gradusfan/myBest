
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFF_Vision.DAL;

namespace XFF_Vision.BLL
{
    public class IoCtrlBLL
    {
        public static  string HexToBin(string str)
        {
            return IoCtrlDAL.HexToBin(str);
        }
        public static uint SetBitValue(int data, int index, bool flag)
        {
            return IoCtrlDAL.SetBitValue(data, index, flag);
        }
        public static void SetBitValue(short m_dev, ref uint out_value, int bitValue, bool isState)
        {
            IoCtrlDAL.SetBitValue(m_dev, ref out_value, bitValue, isState);
        }
        public static int GetBitValue(int data, int index)
        {
            return IoCtrlDAL.GetBitValue(data, index);
        }
        //  public static void  IoShow(short m_dev, IO_Ctrlcs iO_Ctrlcs)
        //{
        //    IoCtrlDAL.io_show(m_dev, iO_Ctrlcs);
        //}
    }
}
