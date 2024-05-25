using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace XFF_Vision
{
     public  class SerialPortDAL
    {
        public SerialPort serialPort = new SerialPort();
        public SerialPortDAL()
        {
        }
        /// <summary>
        /// 设置串口参数—构造函数
        /// </summary>
        /// <param name="SP">串口资源</param>
        /// <param name="_PortName">串口号</param>
        /// <param name="_BaudRate">波特率</param>
        /// <param name="_Parity">校验位,"None","Odd","Even"</param>
        /// <param name="_DataBits">数据位</param>
        /// <param name="_StopBits">停止位</param>
        public SerialPortDAL(string _PortName, string _BaudRate, string _Parity, string _DataBits, string _StopBits)
        {
            try
            {
                int BaudRate, DataBits, StopBits;
                serialPort.ReadBufferSize = 1024;
                serialPort.ReceivedBytesThreshold = 9;
                serialPort.RtsEnable = true;
                serialPort.PortName = _PortName;//串口名称
                BaudRate = int.Parse(_BaudRate);//波特率
                serialPort.BaudRate = BaudRate;//波特率
                switch (_Parity)//无奇偶校验位
                {
                    case "None":
                        serialPort.Parity = System.IO.Ports.Parity.None; break;//无校验位
                    case "Odd":
                        serialPort.Parity = System.IO.Ports.Parity.Odd; break;//奇校验位
                    case "Even":
                        serialPort.Parity = System.IO.Ports.Parity.Even; break;//偶校验位
                }
                DataBits = int.Parse(_DataBits);//数据位转换
                serialPort.DataBits = DataBits;//数据位
                StopBits = int.Parse(_StopBits);//停止位
                switch (StopBits)//停止位
                {
                    case 1:
                        serialPort.StopBits = System.IO.Ports.StopBits.One; break;
                    case 2:
                        serialPort.StopBits = System.IO.Ports.StopBits.Two; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 设置串口参数
        /// </summary>
        /// <param name="_PortName">串口号</param>
        /// <param name="_BaudRate">波特率</param>
        /// <param name="_Parity">校验位,"None","Odd","Even"</param>
        /// <param name="_DataBits">数据位</param>
        /// <param name="_StopBits">停止位</param>
        public void SetSerial_Port(string _PortName, string _BaudRate, string _Parity, string _DataBits, string _StopBits) // 设置串口参数
        {
            try
            {
                int BaudRate, DataBits, StopBits;
                serialPort.ReadBufferSize = 18;
                serialPort.ReceivedBytesThreshold = 9;
                serialPort.RtsEnable = true;
                serialPort.DtrEnable = true;
                serialPort.PortName = _PortName;//串口名称
                BaudRate = int.Parse(_BaudRate);//波特率
                serialPort.BaudRate = BaudRate;//波特率
                switch (_Parity)//无奇偶校验位
                {
                    case "None":
                        serialPort.Parity = Parity.None; break;//无校验位
                    case "Odd":
                        serialPort.Parity = Parity.Odd; break;//奇校验位
                    case "Even":
                        serialPort.Parity = Parity.Even; break;//偶校验位
                }
                DataBits = int.Parse(_DataBits);//数据位转换
                serialPort.DataBits = DataBits;//数据位
                StopBits = int.Parse(_StopBits);//停止位
                switch (StopBits)//停止位
                {
                    case 1:
                        serialPort.StopBits = System.IO.Ports.StopBits.One; break;
                    case 2:
                        serialPort.StopBits = System.IO.Ports.StopBits.Two; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        public void Open_Serial_Port(out bool state, out string msg)//打开串口
        {
            try
            {
                msg = "";
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                }
                state = true;

            }
            catch (Exception ex)
            {

                state = false;
                msg = ex.Message.ToString();
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        public bool Colse_Serial_Port()//关闭串口
        {
            try
            {
                if (serialPort.IsOpen == true)
                {
                    serialPort.Close();
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 打开串口/关闭
        /// </summary>
        /// <param name="sp">串口号</param>
        /// <param name="str">按钮文本</param>
        /// <param name="btn">按钮</param>
        ///   <param name="ptb">图形灯</param>
        public void OpenCom(SerialPort sp, string str, ToolStripStatusLabel tssl1)
        {
            bool b = false; 
            Thread.Sleep(50);
            if (b)
            {
                bool State = false;
                string msg;
                Open_Serial_Port(out State, out msg);
                Com_State(sp,State, str, tssl1);
                if (State == false)
                    MessageBox.Show(msg + "连接失败！");
            }
            else
            {
                Colse_Serial_Port();
                tssl1.ForeColor = Color.Red;
                tssl1.Text = str+"未连接<" + sp.PortName + "-" + sp.BaudRate.ToString() + ">";
            }
        }
        /// <summary>
        /// 串口口连接状态
        /// </summary>
        /// <param name="State"></param>
        /// <param name="ptb"></param>
        public void Com_State(SerialPort sp,bool State, string str, ToolStripStatusLabel tssl1)
        {

            if (State)
            {
                tssl1.ForeColor = Color.Green;
                tssl1.Text = str+"串口已连接<" + sp.PortName + "-" + sp.BaudRate.ToString() + ">";
            }
            else
            {
                tssl1.ForeColor = Color.Red;
                tssl1.Text = str+"串口未连接<" + sp.PortName + "-" + sp.BaudRate.ToString() + ">";
            }
        }
        /// <summary>
        /// 读串口参数
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="name">设备名称</param>
        /// <param name="cbxPortName">串口号</param>
        /// <param name="cbxBaudRate">波特率</param>
        /// <param name="cbxParity">校验位</param>
        /// <param name="cbxDataBits">数据位</param>
        /// <param name="cbxStopBits">停止位</param>
        public void Read_SerialPort(string path, string name, ComboBox cbxPortName, ComboBox cbxBaudRate, ComboBox cbxParity, ComboBox cbxDataBits, ComboBox cbxStopBits) //读串口参数
        {
            cbxPortName.Text = GlobalDAL.ReadIniString(name, "串口", "", path);
            cbxBaudRate.Text = GlobalDAL.ReadIniString(name, "波特率", "", path);
            cbxParity.Text = GlobalDAL.ReadIniString(name, "校验位", "", path);
            cbxDataBits.Text = GlobalDAL.ReadIniString(name, "数据位", "", path);
            cbxStopBits.Text = GlobalDAL.ReadIniString(name, "停止位", "", path);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        public void SetSerial_Port(string path, string name)
        {  string PortName = GlobalDAL.ReadIniString(name, "串口", "", path);
           string BaudRate = GlobalDAL.ReadIniString(name, "波特率", "", path);
           string Parity = GlobalDAL.ReadIniString(name, "校验位", "", path);
           string DataBits = GlobalDAL.ReadIniString(name, "数据位", "", path);
           string StopBits = GlobalDAL.ReadIniString(name, "停止位", "", path);
           SetSerial_Port(PortName, BaudRate, Parity, DataBits, StopBits);
            
        }
        /// <summary>
        ///  写串口参数
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="name">设备名称</param>
        /// <param name="cbxPortName">串口号</param>
        /// <param name="cbxBaudRate">波特率</param>
        /// <param name="cbxParity">校验位</param>
        /// <param name="cbxDataBits">数据位</param>
        /// <param name="cbxStopBits">停止位</param>
        public void Write_SerialPort(string path, string name, ComboBox cbxPortName, ComboBox cbxBaudRate, ComboBox cbxParity, ComboBox cbxDataBits, ComboBox cbxStopBits) //写串口参数
        {
            GlobalDAL.WriteIniString(name, "串口", cbxPortName.Text, path);
            GlobalDAL.WriteIniString(name, "波特率", cbxBaudRate.Text, path);
            GlobalDAL.WriteIniString(name, "校验位", cbxParity.Text, path);
            GlobalDAL.WriteIniString(name, "数据位", cbxDataBits.Text, path);
            GlobalDAL.WriteIniString(name, "停止位", cbxStopBits.Text, path);
        }
    }
}
