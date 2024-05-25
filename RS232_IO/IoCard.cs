using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS232_IO
{
    public class IoCard
    {

        #region //RS232 串口I/O 3入8出命令
        public static byte[] Y0_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 1, 0, 0, 0x9C };//Y0_ON
        public static byte[] Y1_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 2, 0, 0, 0x9D };//Y1_ON
        public static byte[] Y2_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 3, 0, 0, 0x9E };//Y2_ON
        public static byte[] Y3_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 4, 0, 0, 0x9F };//Y3_ON
        public static byte[] Y4_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 5, 0, 0, 0xA0 };//Y4_ON
        public static byte[] Y5_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 6, 0, 0, 0xA1 };//Y5_ON
        public static byte[] Y6_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 7, 0, 0, 0xA2 };//Y6_ON
        public static byte[] Y7_ON = new byte[] { 0, 0x5A, 0x40, 0, 1, 8, 0, 0, 0xA3 };//Y7_ON

        public static byte[] Y0_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 1, 0, 0, 0x9D };//Y0_OFF
        public static byte[] Y1_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 2, 0, 0, 0x9E };//Y1_OFF
        public static byte[] Y2_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 3, 0, 0, 0x9F };//Y2_OFF
        public static byte[] Y3_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 4, 0, 0, 0xA0 };//Y3_OFF
        public static byte[] Y4_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 5, 0, 0, 0xA1 };//Y4_OFF
        public static byte[] Y5_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 6, 0, 0, 0xA2 };//Y5_OFF
        public static byte[] Y6_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 7, 0, 0, 0xA3 };//Y6_OFF
        public static byte[] Y7_OFF = new byte[] { 0, 0x5A, 0x40, 0, 2, 8, 0, 0, 0xA4 };//Y7_OFF
        #endregion

        #region //RS232 串口I/O 8入8出命令
        public static byte[] Y0_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 01, 00, 00, 0xB2 };
        public static byte[] Y1_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 02, 00, 00, 0xB3 };
        public static byte[] Y2_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 03, 00, 00, 0xB4 };
        public static byte[] Y3_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 04, 00, 00, 0xB5 };
        public static byte[] Y4_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 05, 00, 00, 0xB6 };
        public static byte[] Y5_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 06, 00, 00, 0xB7 };
        public static byte[] Y6_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 07, 00, 00, 0xB8 };
        public static byte[] Y7_ON0 = new byte[] { 00, 0x5A, 0x56, 00, 01, 08, 00, 00, 0xB9 };

        public static byte[] Y0_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 01, 00, 00, 0xB3 };
        public static byte[] Y1_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 02, 00, 00, 0xB4 };
        public static byte[] Y2_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 03, 00, 00, 0xB5 };
        public static byte[] Y3_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 04, 00, 00, 0xB6 };
        public static byte[] Y4_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 05, 00, 00, 0xB7 };
        public static byte[] Y5_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 06, 00, 00, 0xB8 };
        public static byte[] Y6_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 07, 00, 00, 0xB9 };
        public static byte[] Y7_OFF0 = new byte[] { 00, 0x5A, 0x56, 00, 02, 08, 00, 00, 0xBA };
        #endregion
    }
}
