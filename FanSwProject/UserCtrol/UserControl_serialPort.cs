using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FanSwProject.commonlib;

namespace FanSwProject
{
    public partial class UserControl_serialPort : UserControl
    {
        public const string errRet = "err";
        public string name;
        public ComPort comPort;
        private bool isLoadPara = false;

     
        public UserControl_serialPort(ComPort _comPort)
        {
            InitializeComponent();
            comPort = _comPort;
            if(comPort == null)
            {
                comPort = new ComPort();
                //获取存在的串口号
                getSpName();
                //记载界面端口号信息
                LoadPortPara();
            }
        }
        //加载界面端口的参数
        private void LoadPortPara()
        {
            try
            {
                if (comPort == null)
                    comPort = new ComPort();

                textBox_name.Text = comPort.portParameter.tag_name;
                cmbBaudRate.Text = comPort.portParameter.tag_baudRate.ToString();
                cmbPortName.Text = comPort.portParameter.tag_portName;
                cmbDataBits.Text = comPort.portParameter.tag_databits.ToString();

                switch (comPort.portParameter.tag_Parity)
                {
                    case Parity.Even:
                        cmbParity.Text = "EVEN"; break;
                    case Parity.Odd:
                        cmbParity.Text = "ODD"; break;
                    case Parity.None:
                        cmbParity.Text = "NONE"; break;
                }
                switch (comPort.portParameter.tag_stopBits)
                {
                    case System.IO.Ports.StopBits.None:
                        cmbStopBits.Text = "NONE"; break;
                    case System.IO.Ports.StopBits.One:
                        cmbStopBits.Text = "One"; break;
                    case System.IO.Ports.StopBits.Two:
                        cmbStopBits.Text = "Two"; break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(("获取串口配置参数异常"));
                return;
            }

        }

        //获取端口参数
        public void GetPortPara()
        {
            try
            {
                if (comPort == null)
                    comPort = new ComPort();

                comPort.portParameter.tag_name = textBox_name.Text;
                comPort.portParameter.tag_baudRate = Convert.ToInt32(cmbBaudRate.Text);
                comPort.portParameter.tag_portName = cmbPortName.Text;
                comPort.portParameter.tag_databits = Convert.ToInt32(cmbDataBits.Text);



                switch (cmbParity.Text)
                {
                    case "EVEN":
                        comPort.portParameter.tag_Parity = Parity.Even; break;
                    case "ODD":
                        comPort.portParameter.tag_Parity = Parity.Odd; break;
                    case "NONE":
                        comPort.portParameter.tag_Parity = Parity.None; break;
                }
                switch (cmbStopBits.Text)
                {
                    case "NONE":
                        comPort.portParameter.tag_stopBits = System.IO.Ports.StopBits.None; break;
                    case "One":
                        comPort.portParameter.tag_stopBits = StopBits.One; break;
                    case "Two":
                        comPort.portParameter.tag_stopBits = StopBits.Two; break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show(("获取串口配置参数异常"));
                return;
            }
        }

        //获取存在的串口号
        private void getSpName()
        {

            string[] sp = SerialPort.GetPortNames();
            if (sp == null)
                return;
            for (int i = 0; i < sp.Length; i++)
            {
                if (cmbPortName.Items.Contains(sp[i]) == false)
                {
                    cmbPortName.Items.Add(sp[i]);
                }
            }
            cmbPortName.Sorted = true;

        }


        //串口打开，关闭
        public void ctrlOpenCom()
        {
            if (!comPort.serialPort.IsOpen)
            {
                try
                {
                    //if (!isLoadPara)
                    //{
                    //    LoadPara();
                    //    isLoadPara = true;
                    //}
                    comPort.serialPort.PortName = cmbPortName.Text.ToString(); ;
                    comPort.serialPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    comPort.serialPort.DataBits = Convert.ToInt16(cmbDataBits.Text);

                    switch (cmbParity.Text)
                    {
                        case "EVEN":
                            comPort.serialPort.Parity = Parity.Even; break;
                        case "ODD":
                            comPort.serialPort.Parity = Parity.Odd; break;
                        case "NONE":
                            comPort.serialPort.Parity = Parity.None; break;
                    }
                    switch (cmbStopBits.Text)
                    {
                        case "NONE":
                            comPort.serialPort.StopBits = System.IO.Ports.StopBits.None; break;
                        case "One":
                            comPort.serialPort.StopBits = StopBits.One; break;
                        case "Two":
                            comPort.serialPort.StopBits = StopBits.Two; break;
                    }
                    comPort.serialPort.Open();
                    comPort.serialPort.DiscardOutBuffer();
                }
                catch (Exception)
                {
                    MessageBox.Show(("串口打开失败"));
                    lblPortInd.BackColor = Color.Red;
                    return;
                }
            }
            else// close port
            {

                lblPortInd.BackColor = Color.Red;
                comPort.serialPort.Close();
            }
            UpfrushPortStatus();
        }

        private void UpfrushPortStatus()
        {
            if (!comPort.serialPort.IsOpen)
            {
                bool bSetCtrl = true;
                cmbPortName.Enabled = bSetCtrl;
                cmbBaudRate.Enabled = bSetCtrl;
                cmbDataBits.Enabled = bSetCtrl;
                cmbParity.Enabled = bSetCtrl;
                cmbStopBits.Enabled = bSetCtrl;
                btnSend.Enabled = !bSetCtrl;
                btnClear.Enabled = !bSetCtrl;
                lblPortInd.BackColor = Color.Maroon;
                btnSPopen.Text = "打开串口";
            }
            else
            {
                bool bSetCtrl = false;
                cmbPortName.Enabled = bSetCtrl;
                cmbBaudRate.Enabled = bSetCtrl;
                cmbDataBits.Enabled = bSetCtrl;
                cmbParity.Enabled = bSetCtrl;
                cmbStopBits.Enabled = bSetCtrl;
                btnSend.Enabled = !bSetCtrl;
                btnClear.Enabled = !bSetCtrl;
                lblPortInd.BackColor = Color.Green;
                btnSPopen.Text = "关闭串口";
            }
        }
        //打开串口
        private void btnSPopen_Click(object sender, EventArgs e)
        {
            GetPortPara();
            //StationManage._Config.Save();
            ctrlOpenCom();

        }

    
        private void btnSend_Click(object sender, EventArgs e)
        {
            string strSend = txtSendPort1.Text;
            byte[] send = Encoding.ASCII.GetBytes(strSend);
            byte[] read = comPort.CtrlSendAndRead(send);
            if (read != null)
                txtRecPort1.Text = txtRecPort1.Text + Encoding.ASCII.GetString(read);
            timer1.Start();
        }
        delegate void DelSetTxt(TextBox paTxtBox, object write);

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecPort1.Clear();
        }



        void savePara()
        {
            WritePara();
        }


      

        //串口参数保存路径
        private string strSavePath = "D:\\运行日志\\参数\\+\\串口" + DateTime.Now.ToString("yyyyMM")+ "\\Setting232.ini";

        private void WritePara()
        {
            ////串口参数new一个对象，用这个对象来接收界面参数的值，然后保存INI文件
            //serialParam serialParam = new serialParam();
            //serialParam.Name = this.textBox_name.Text.ToString();
            //serialParam.PortName = this.cmbPortName.TabIndex.ToString();
            //serialParam.Baudrate = this.cmbBaudRate.TabIndex;
            //serialParam.DataBit = this.cmbDataBits.TabIndex;
            //serialParam.Stopbit = this.cmbStopBits.TabIndex;
            //serialParam.parity = this.cmbParity.TabIndex;
            
            //ReadandWriteINI.WriteIni(this.Name.ToString(), serialParam, strSavePath);
        }





    }
}
