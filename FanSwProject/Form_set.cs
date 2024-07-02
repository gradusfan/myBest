using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FanSwProject.commonlib;


namespace FanSwProject
{
    public partial class Form_set : Form
    {

        
        
        public Form_set()
        {
            InitializeComponent();

            LoadserialParam();

            ComPort comPort1 = new ComPort();
            ComPort comPort2 = new ComPort();
            ComPort comPort3 = new ComPort();
            ComPort comPort4 = new ComPort();
            ComPort comPort5 = new ComPort();

        }

    


















        //保存界面UI参数

        private string iniFilePath  = @"d:\fanData\serialParam\Settings\Port.ini";
        private string iniFilePath2 = @"d:\fanData\serialParam\Settings\interPort.ini";
        private void btn_saveComPram_Click(object sender, EventArgs e)
        {


            Config.SetPageParam("设置参数参数", "端口号", cmbPortName_1.Text);
            Config.SetPageParam("设置参数参数", "波特率", cmbBaudRate_1.Text);
            Config.SetPageParam("设置参数参数", "数据位", cmbDataBits_1.Text);
            Config.SetPageParam("设置参数参数", "停止位", cmbStopBits_1.Text);
            Config.SetPageParam("设置参数参数", "校验位", cmbParity_1.Text);


            bool result1 = ReadandWriteINI.WriteIni("串口1", "端口号", cmbPortName_1.Text, iniFilePath);
            bool result2 = ReadandWriteINI.WriteIni("串口1", "波特率", cmbBaudRate_1.Text.ToString(), iniFilePath);
            bool result3 = ReadandWriteINI.WriteIni("串口1", "数据位", cmbDataBits_1.Text.ToString(), iniFilePath);
            bool result4 = ReadandWriteINI.WriteIni("串口1", "停止位", cmbStopBits_1.Text.ToString(), iniFilePath);
            bool result5 = ReadandWriteINI.WriteIni("串口1", "校验位", cmbParity_1.Text.ToString(), iniFilePath);

        
            bool result6 = ReadandWriteINI.WriteIni("串口2", "端口号", cmbPortName_2.Text, iniFilePath);
            bool result7 = ReadandWriteINI.WriteIni("串口2", "波特率", cmbBaudRate_2.Text.ToString(), iniFilePath);
            bool result8 = ReadandWriteINI.WriteIni("串口2", "数据位", cmbDataBits_2.Text.ToString(), iniFilePath);
            bool result9 = ReadandWriteINI.WriteIni("串口2", "停止位", cmbStopBits_2.Text.ToString(), iniFilePath);
            bool result10 = ReadandWriteINI.WriteIni("串口2", "校验位", cmbParity_2.Text.ToString(), iniFilePath);

            bool result11 = ReadandWriteINI.WriteIni("串口3", "端口号", cmbPortName_3.Text, iniFilePath);
            bool result12 = ReadandWriteINI.WriteIni("串口3", "波特率", cmbBaudRate_3.Text.ToString(), iniFilePath);
            bool result13 = ReadandWriteINI.WriteIni("串口3", "数据位", cmbDataBits_3.Text.ToString(), iniFilePath);
            bool result14 = ReadandWriteINI.WriteIni("串口3", "停止位", cmbStopBits_3.Text.ToString(), iniFilePath);
            bool result15 = ReadandWriteINI.WriteIni("串口3", "校验位", cmbParity_3.Text.ToString(), iniFilePath);


            bool result16 = ReadandWriteINI.WriteIni("串口4", "端口号", cmbPortName_4.Text, iniFilePath);
            bool result17 = ReadandWriteINI.WriteIni("串口4", "波特率", cmbBaudRate_4.Text.ToString(), iniFilePath);
            bool result18 = ReadandWriteINI.WriteIni("串口4", "数据位", cmbDataBits_4.Text.ToString(), iniFilePath);
            bool result19 = ReadandWriteINI.WriteIni("串口4", "停止位", cmbStopBits_4.Text.ToString(), iniFilePath);
            bool result20 = ReadandWriteINI.WriteIni("串口4", "校验位", cmbParity_4.Text.ToString(), iniFilePath);

            bool result21 = ReadandWriteINI.WriteIni("串口5", "端口号", cmbPortName_5.Text, iniFilePath);
            bool result22 = ReadandWriteINI.WriteIni("串口5", "波特率", cmbBaudRate_5.Text.ToString(), iniFilePath);
            bool result23 = ReadandWriteINI.WriteIni("串口5", "数据位", cmbDataBits_5.Text.ToString(), iniFilePath);
            bool result24 = ReadandWriteINI.WriteIni("串口5", "停止位", cmbStopBits_5.Text.ToString(), iniFilePath);
            bool result25 = ReadandWriteINI.WriteIni("串口5", "校验位", cmbParity_5.Text.ToString(), iniFilePath);




            if (!result1&&!result2&&!result3&&result4&&!result5&&!result6&& !result7 && !result8 && result9 && !result10&&
                !result11 && !result12 && !result13 && result14 && !result15 && !result16 && !result17 && !result18 && result19 && !result20 &&
                !result21 && !result22 && !result23 && result24 && !result25)
            {
                MessageBox.Show("保存失败，串口参数文件不存在");


            }
            else
            {
                MessageBox.Show("串口参数保存成功");
            }
        }


        private void LoadserialParam()
        {
            cmbPortName_1.Text = ReadandWriteINI.ReadIni("串口1", "端口号","",iniFilePath);
            cmbBaudRate_1.Text = ReadandWriteINI.ReadIni("串口1", "波特率", "", iniFilePath);
            cmbDataBits_1.Text = ReadandWriteINI.ReadIni("串口1", "数据位", "", iniFilePath);
            cmbStopBits_1.Text = ReadandWriteINI.ReadIni("串口1", "停止位", "", iniFilePath);
            cmbParity_1.Text = ReadandWriteINI.ReadIni("串口1", "校验位", "", iniFilePath);

            cmbPortName_2.Text = ReadandWriteINI.ReadIni("串口2", "端口号", "", iniFilePath);
            cmbBaudRate_2.Text = ReadandWriteINI.ReadIni("串口2", "波特率", "", iniFilePath);
            cmbDataBits_2.Text = ReadandWriteINI.ReadIni("串口2", "数据位", "", iniFilePath);
            cmbStopBits_2.Text = ReadandWriteINI.ReadIni("串口2", "停止位", "", iniFilePath);
            cmbParity_2.Text = ReadandWriteINI.ReadIni("串口2", "校验位", "", iniFilePath);

            cmbPortName_3.Text = ReadandWriteINI.ReadIni("串口3", "端口号", "", iniFilePath);
            cmbBaudRate_3.Text = ReadandWriteINI.ReadIni("串口3", "波特率", "", iniFilePath);
            cmbDataBits_3.Text = ReadandWriteINI.ReadIni("串口3", "数据位", "", iniFilePath);
            cmbStopBits_3.Text = ReadandWriteINI.ReadIni("串口3", "停止位", "", iniFilePath);
            cmbParity_3.Text = ReadandWriteINI.ReadIni("串口3", "校验位", "", iniFilePath);

            cmbPortName_4.Text = ReadandWriteINI.ReadIni("串口4", "端口号", "", iniFilePath);
            cmbBaudRate_4.Text = ReadandWriteINI.ReadIni("串口4", "波特率", "", iniFilePath);
            cmbDataBits_4.Text = ReadandWriteINI.ReadIni("串口4", "数据位", "", iniFilePath);
            cmbStopBits_4.Text = ReadandWriteINI.ReadIni("串口4", "停止位", "", iniFilePath);
            cmbParity_4.Text = ReadandWriteINI.ReadIni("串口4", "校验位", "", iniFilePath);

            cmbPortName_5.Text = ReadandWriteINI.ReadIni("串口5", "端口号", "", iniFilePath);
            cmbBaudRate_5.Text = ReadandWriteINI.ReadIni("串口5", "波特率", "", iniFilePath);
            cmbDataBits_5.Text = ReadandWriteINI.ReadIni("串口5", "数据位", "", iniFilePath);
            cmbStopBits_5.Text = ReadandWriteINI.ReadIni("串口5", "停止位", "", iniFilePath);
            cmbParity_5.Text = ReadandWriteINI.ReadIni("串口5", "校验位", "", iniFilePath);

        }

        private void button_saveParam2_Click(object sender, EventArgs e)
        {
            Config.SetPageParam("设置网口参数", "IP", cmbPortName_1.Text);
            Config.SetPageParam("设置参数参数", "波特率", cmbBaudRate_1.Text);
            Config.SetPageParam("设置参数参数", "数据位", cmbDataBits_1.Text);
            Config.SetPageParam("设置参数参数", "停止位", cmbStopBits_1.Text);
            Config.SetPageParam("设置参数参数", "校验位", cmbParity_1.Text);

            ReadandWriteINI.WriteIni("网口1", "IP", textBox_IP1.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口1", "Port", textBox_Port1.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口2", "IP", textBox_IP2.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口2", "Port", textBox_Port2.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口3", "IP", textBox_IP3.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口3", "Port", textBox_Port3.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口4", "IP", textBox_IP4.Text, iniFilePath2);
            ReadandWriteINI.WriteIni("网口4", "Port", textBox_Port4.Text, iniFilePath2);





        }
    }
}
