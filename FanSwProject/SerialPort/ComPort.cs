using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FanSwProject
{
    public class ComPort
    {
        public SerialPort serialPort;
        public PortParameter portParameter;
        public Action<string, string> RecEvent;

        //端口是否打开
        public bool IsOpen()
        {
            if (serialPort != null)
                return serialPort.IsOpen;
            else
                return false;
        }
        public ComPort()
            : this(new PortParameter())
        {

        }
        public ComPort(PortParameter portParame)
        {
            portParameter = portParame;
            if (portParameter == null)
                serialPort = new SerialPort();
            else
                try
                {
                    serialPort = new SerialPort(portParameter.tag_portName, portParameter.tag_baudRate, portParameter.tag_Parity, portParameter.tag_databits, portParameter.tag_stopBits);
                }
                catch
                {

                    portParameter.tag_baudRate = 9600;
                    portParameter.tag_Parity = Parity.None;
                    portParameter.tag_databits = 8;
                    portParameter.tag_stopBits = StopBits.One;
                    serialPort = new SerialPort(portParameter.tag_portName, portParameter.tag_baudRate, portParameter.tag_Parity, portParameter.tag_databits, portParameter.tag_stopBits);
                }
        }


        public void BindEvent()
        {
            try
            {
                if (!this.serialPort.IsOpen)
                {
                    this.serialPort.Open();
                }
                this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string str = "";
            DateTime start = DateTime.Now;
            try
            {
                do
                {
                    if ((DateTime.Now - start).TotalMilliseconds > 10000)
                    {
                        str = "error";
                        break;
                    }
                    int count = serialPort.BytesToRead;
                    byte[] readBuffer = new byte[count];
                    serialPort.Read(readBuffer, 0, count);
                    str += System.Text.Encoding.Default.GetString(readBuffer);
                }
                while (!str.Contains("$"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            str = str.Replace("$", "");
            if (RecEvent != null)
                RecEvent(portParameter.tag_name, str);
            //LZF_MakeFile.TcpLogText("Receive: " + str, serialPort.PortName, false);
        }


        /// <summary>
        /// 打开串口
        /// </summary>
        public bool CtrlOpenCom()
        {
            try
            {
                if (!IsOpen())
                {
                    serialPort.Open();
                    serialPort.DiscardInBuffer();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(("串口打开失败"));
                return false;
            }

        }
        /// <summary>
        /// 发送字符串
        /// </summary>
        /// <param name="strSend"></param>
        /// <returns></returns>
        public bool CtrlSend(string strSend)
        {
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.WriteLine(strSend);
                //LZF_MakeFile.TcpLogText("Send: " + strSend, serialPort.PortName, false);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 发送Byte数据
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public bool CtrlSend(byte[] by)
        {
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                RecordLog(by);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 发送并读取串口数据，等待有数据后，连续2次10毫秒失败后 终止读取
        /// </summary>
        /// <param name="by"></param>
        /// <returns>空为异常</returns>
        public byte[] CtrlSendAndRead(byte[] by)
        {
            byte[] ReadBuffer = new byte[1024];
            int nLen = 0;
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                RecordLog(by);
                DateTime dt = DateTime.Now;
                int failCount = 0;
                int copyStart = 0;
                while (true)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(5);
                    }
                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        return null;
                    }
                }
                serialPort.ReadTimeout = 10;
                byte[] read = new byte[256];
                while (true)
                {
                    if (failCount > 1)
                    {
                        break;
                    }
                    try
                    {
                        nLen = serialPort.Read(read, 0, read.Length);
                        if (nLen > 0)
                        {
                            if (copyStart + nLen < ReadBuffer.Length)
                            {
                                Array.Copy(read, 0, ReadBuffer, copyStart, nLen);
                                copyStart = copyStart + nLen;
                            }
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    catch
                    {
                        failCount++;
                    }

                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        RecordLog(ReadBuffer, true);
                        return ReadBuffer;
                    }
                }
            }
            catch
            {
                return null;
            }
            RecordLog(ReadBuffer, true);
            return ReadBuffer;
        }

        /// <summary>
        /// 发送并读取串口数据，等待有数据后，连续2次10毫秒失败后 终止读取
        /// </summary>
        /// <param name="by"></param>
        /// <returns>空为异常</returns>
        public byte[] CtrlSendAndReadByCRC(byte[] by)
        {
            byte[] ReadBuffer = new byte[1024];
            int nLen = 0;
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                bool bReSend = true;
                bool bReceData = false;
                DateTime dtReceTime = DateTime.Now;
                int copyStart = 0;
                DateTime dt = DateTime.Now;
                while (true)
                {
                    if (bReSend)
                    {
                        copyStart = 0;
                        ReadBuffer = null;
                        bReSend = false;
                        serialPort.DiscardInBuffer();
                        serialPort.Write(by, 0, by.Length);
                        RecordLog(by);
                    }

                    if (serialPort.BytesToRead > 0)
                    {
                        byte[] read = new byte[serialPort.BytesToRead];
                        nLen = 0;
                        nLen = serialPort.Read(read, 0, read.Length);
                        if (nLen > 0)
                        {
                            Array.Resize(ref ReadBuffer, copyStart + nLen);
                            Array.Copy(read, 0, ReadBuffer, copyStart, nLen);
                            copyStart = copyStart + nLen;
                        }
                        if (CheckCRC(ReadBuffer))
                        {
                            break;
                        }
                        dtReceTime = DateTime.Now;
                        bReceData = true;
                    }
                    if ((DateTime.Now - dtReceTime).TotalSeconds > 0.04)
                    {
                        bReceData = false;
                        bReSend = true;
                        dtReceTime = DateTime.Now;
                    }

                    if ((DateTime.Now - dt).TotalSeconds > 1.5)
                    {
                        if (CheckCRC(ReadBuffer))
                        {
                            RecordLog(ReadBuffer, true);
                            return ReadBuffer;
                        }
                        else
                        {
                            RecordLog(ReadBuffer, true);
                            return ReadBuffer;
                        }
                    }
                    Thread.Sleep(2);
                }
            }
            catch
            {
                return null;
            }
            RecordLog(ReadBuffer, true);
            return ReadBuffer;
        }
        /// <summary>
        /// 发送并读取串口数据，等待有数据后，连续2次10毫秒失败后 终止读取
        /// </summary>
        /// <param name="strSend"></param>
        /// <returns>空为异常</returns>
        public byte[] CtrlSendAndRead(string strSend)
        {
            byte[] by = Encoding.ASCII.GetBytes(strSend);
            byte[] ReadBuffer = new byte[1024];
            int nLen = 0;
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                RecordLog(by);
                DateTime dt = DateTime.Now;
                int failCount = 0;
                int copyStart = 0;
                while (true)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(5);
                    }
                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        return null;
                    }
                }
                serialPort.ReadTimeout = 10;
                byte[] read = new byte[256];
                while (true)
                {
                    if (failCount > 1)
                    {
                        break;
                    }
                    try
                    {
                        nLen = serialPort.Read(read, 0, read.Length);
                        if (nLen > 0)
                        {
                            if (copyStart + nLen < ReadBuffer.Length)
                            {
                                Array.Copy(read, 0, ReadBuffer, copyStart, nLen);
                                copyStart = copyStart + nLen;
                            }
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    catch
                    {
                        failCount++;
                    }

                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        RecordLog(ReadBuffer, true);
                        return ReadBuffer;
                    }
                }
            }
            catch
            {
                return null;
            }
            RecordLog(ReadBuffer, true);
            return ReadBuffer;
        }
        /// <summary>
        /// 发送后延时100毫秒读取一次数据，超时设定有参数传入
        /// </summary>
        /// <param name="by"></param>
        /// <param name="outtime"></param>
        /// <returns></returns>
        public byte[] CtrlSendAndRead(byte[] by, int outtime)
        {
            byte[] ReadBuffer = new byte[256];
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                RecordLog(by);
                Thread.Sleep(100);
                serialPort.ReadTimeout = outtime;
                int nLen;
                nLen = serialPort.Read(ReadBuffer, 0, ReadBuffer.Length);

            }
            catch
            {
                return null;
            }
            RecordLog(ReadBuffer, true);
            return ReadBuffer;
        }

        /// <summary>
        /// 发送并读取串口数据，等待有数据后，连续2次10毫秒失败后 终止读取
        /// </summary>
        /// <param name="strSend"></param>
        /// <returns>空为异常</returns>
        public string CtrlSendAndRead1(string strSend)
        {
            byte[] by = Encoding.ASCII.GetBytes(strSend);
            byte[] ReadBuffer = new byte[1024];
            int nLen = 0;
            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                RecordLog(by);
                DateTime dt = DateTime.Now;
                int failCount = 0;
                int copyStart = 0;
                while (true)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(5);
                    }
                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        return null;
                    }
                }
                serialPort.ReadTimeout = 10;
                byte[] read = new byte[256];
                while (true)
                {
                    if (failCount > 1)
                    {
                        break;
                    }
                    try
                    {
                        nLen = serialPort.Read(read, 0, read.Length);
                        if (nLen > 0)
                        {
                            if (copyStart + nLen < ReadBuffer.Length)
                            {
                                Array.Copy(read, 0, ReadBuffer, copyStart, nLen);
                                copyStart = copyStart + nLen;
                            }
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    catch
                    {
                        failCount++;
                    }

                    if ((DateTime.Now - dt).TotalSeconds > 1)
                    {
                        RecordLog(ReadBuffer);
                        return Encoding.ASCII.GetString(ReadBuffer);
                    }
                }
            }
            catch
            {
                return null;
            }
            RecordLog(ReadBuffer);
            return Encoding.ASCII.GetString(ReadBuffer);
        }
        /// <summary>
        /// 读取到结束符或超时返回
        /// </summary>
        /// <param name="strSend"></param>
        /// <param name="stopvalue"></param>
        /// <param name="outtime"></param>
        /// <returns></returns>
        public string CtrlSendAndReadTo(string strSend, string stopvalue = "\r", int outtime = 300)
        {
            byte[] by = Encoding.ASCII.GetBytes(strSend);
            byte[] ReadBuffer = new byte[1024];

            try
            {
                if (IsOpen() == false)
                {
                    CtrlOpenCom();
                }
                serialPort.DiscardInBuffer();
                serialPort.Write(by, 0, by.Length);
                //LZF_MakeFile.TcpLogText("Send: " + strSend, serialPort.PortName, false);
                serialPort.ReadTimeout = outtime;
                string read = "";

                read = serialPort.ReadTo(stopvalue);
                //LZF_MakeFile.TcpLogText("Receive: " + read, serialPort.PortName, false);
                return read;

            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 检查返回数据的CRC是否正确
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CheckCRC(byte[] value)
        {
            try
            {
                if (value == null || value.Length < 1)
                    return false;
                int crc = 0xffff;
                for (int n = 0; n < value.Length - 2; n++)
                {
                    byte i;
                    crc = crc ^ value[n];
                    for (i = 0; i < 8; i++)
                    {
                        int tt;
                        tt = crc & 1;
                        crc = crc >> 1;
                        crc = crc & 0x7fff;
                        if (tt == 1)
                        {
                            crc = crc ^ 0xa001;
                        }
                        crc = crc & 0xffff;
                    }
                }
                byte low = (byte)((crc >> 8) & 0xff);
                byte height = (byte)(crc & 0xff);

                if (height == value[value.Length - 2] && low == value[value.Length - 1])
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void RecordLog(byte[] by, bool isReceive = false)
        {
            string str = "";
            foreach (var item in by)
            {
                str += item.ToString() + " ";
            }
            //str = Encoding.ASCII.GetString(by);
            if (isReceive)
            {
                str = System.Text.RegularExpressions.Regex.Replace(str, @"( 0)*$", "");
                //LZF_MakeFile.TcpLogText("Receive: " + str, serialPort.PortName, false);
            }
            else
            {
               // LZF_MakeFile.TcpLogText("Send: " + str, serialPort.PortName, false);
            }
        }
    }
}
