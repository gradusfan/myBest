using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionTool.ImageToolDAL
{   [Serializable]
    public class SerialPortTool : ImageTool
    {
    [NonSerialized]
    SerialPort serialPort1;
    public SerialPort SerialPort1
    {
        get { return serialPort1; }
        set { serialPort1 = value; }
    }
        /// <summary>
        /// 工具名称
        /// </summary>
        public string Names
        { get; set; }
        public string PortName
        {   get; set;  }
        public string BaudRate
        { get; set; }
        public string Parity
        { get; set; }
        public string DataBits
        { get; set; }
        public string StopBits
        { get; set; }
         public string SendData
        { get; set; }

        public override string toolName()
        {
            return Names;
        }
        public override long toolTimer()
        {
            return timer;
        }
        public override void recon()
        {
            if (!serialPort1.IsOpen)
                setSerial_Port();
        }
        public override void ini()
        {
            Names = Tool.串口设置.ToString();
            PortName = "COM1";
            BaudRate = "9600";
            Parity = "None";
            DataBits = "8";
            StopBits = "1";
            SendData = "00 01";
            if (!serialPort1.IsOpen)
                openSerial();
            setSerial_Port();
        }
        public override void draw_roi()
        { }
        /// <summary>
        /// 运行一次
        /// </summary>
        public override void run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            toolRun();
            dispresult();
            watch.Stop();
            timer = watch.ElapsedMilliseconds;
        }
        private void toolRun()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    strToHexByte(SendData);
                    serialPort1.Write(strToHexByte(SendData), 0, strToHexByte(SendData).Length);
                }
                else
                {
                    serialPort1.Open();
                    strToHexByte(SendData);
                    serialPort1.Write(strToHexByte(SendData), 0, strToHexByte(SendData).Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public override void dispresult()
        { }
        public override long set_after()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            run();
            dispresult();
            watch.Stop();
            timer = watch.ElapsedMilliseconds;
            return watch.ElapsedMilliseconds;
        }
        public bool openSerial()
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool closeSerial()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    return true;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        public void setSerial_Port()// 设置串口参数
        {
            try
            {
                int BaudRate, DataBits, StopBits;
                serialPort1.ReadBufferSize = 1024;
                serialPort1.ReceivedBytesThreshold = 1;
                serialPort1.RtsEnable = true;
                serialPort1.PortName = this.PortName;//串口名称
                BaudRate = int.Parse(this.BaudRate);//波特率
                serialPort1.BaudRate = BaudRate;//波特率
                switch (this.Parity)//无奇偶校验位
                {
                    case "None":
                        serialPort1.Parity = System.IO.Ports.Parity.None; break;//无校验位
                    case "Odd":
                        serialPort1.Parity = System.IO.Ports.Parity.Odd; break;//奇校验位
                    case "Even":
                        serialPort1.Parity = System.IO.Ports.Parity.Even; break;//偶校验位
                }
                DataBits = int.Parse(this.DataBits);//数据位转换
                serialPort1.DataBits = DataBits;//数据位
                StopBits = int.Parse(this.StopBits);//停止位
                switch (StopBits)//停止位
                {
                    case 1:
                        serialPort1.StopBits = System.IO.Ports.StopBits.One; break;
                    case 2:
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public override bool toolResult()
        //{
        //    return ResultLogic;
        //}
    }
}
