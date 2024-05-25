using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;

namespace XFF_Vision.frm_Tool
{
    public partial class frm_Serial : Form
    {
        static frm_Serial frm;
        SerialPortTool serialPortTool = new SerialPortTool();
        public delegate void HandledSetVal(SerialPortTool fixtureTool);
        HandledSetVal handleSetval;
        /// <summary>
        /// 单实例
        /// </summary>
        /// <param name="fb"></param>
        public static frm_Serial SingleShow(SerialPortTool serialPortTool, HandledSetVal handleSetval)
        {
            if (frm == null)//
            {
                frm = new frm_Serial(serialPortTool, handleSetval);
            }
            return frm;
        }
        public frm_Serial()
        {
            InitializeComponent();
        }
        public frm_Serial(SerialPortTool serialPortTool, HandledSetVal handleSetval)
        {
            InitializeComponent();
            DisplayVal(serialPortTool);
            this.handleSetval = handleSetval;
            this.serialPortTool.SerialPort1 = serialPortTool.SerialPort1;
            this.SetVal( ref this.serialPortTool);
        }
        void DisplayVal(SerialPortTool serialPortTool)
        {
            try
            {
                int nameIndex = serialPortTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = serialPortTool.Names.Substring(nameIndex + 1, serialPortTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;
                }
                else
                {
                    this.Text = serialPortTool.Names;
                    tbxToolName.Text = serialPortTool.Names;
                }
                this.cbxPortName1.Text= serialPortTool.PortName;
                this.cbxBaudRate1.Text = serialPortTool.BaudRate;
                this.cbxParity1.Text = serialPortTool.Parity;
                this.cbxDataBits1.Text = serialPortTool.DataBits;
                this.cbxStopBits1.Text = serialPortTool.StopBits;
                this.textBox1.Text= serialPortTool.SendData;
          }
            catch { }
        }
        void SetVal(ref SerialPortTool serialPortTool)
        {
            serialPortTool.Names = SerialPortTool.Tool.串口设置.ToString() + "_" + tbxToolName.Text;
            serialPortTool.PortName = this.cbxPortName1.Text;
            serialPortTool.BaudRate = this.cbxBaudRate1.Text;
            serialPortTool.Parity = this.cbxParity1.Text;
            serialPortTool.DataBits = this.cbxDataBits1.Text;
            serialPortTool.StopBits = this.cbxStopBits1.Text;
            serialPortTool.SendData= this.textBox1.Text;
            if (serialPortTool.openSerial())
                ; //  ptbComState1.Image = Properties.Resources.low;
            else
                ;//  ptbComState1.Image = Properties.Resources.high;
        }
        void Cancel()
        { }
        void Register()
        { }
        private void tbxToolName_TextChanged(object sender, EventArgs e)
        {
            this.serialPortTool.Names = SerialPortTool.Tool.串口设置.ToString() + "_" + tbxToolName.Text;
            this.Text = tbxToolName.Text;
        }

        private void cbxPortName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortTool.PortName = this.cbxPortName1.Text;
        }
        private void cbxBaudRate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortTool.BaudRate = this.cbxBaudRate1.Text;
          
        }

        private void cbxParity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortTool.Parity = this.cbxParity1.Text;
          
        }

        private void cbxDataBits1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortTool.DataBits = this.cbxDataBits1.Text;
        
        }

        private void cbxStopBits1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortTool.StopBits = this.cbxStopBits1.Text;
        }
        
        private void btnCom1_Click(object sender, EventArgs e)
        {
           if(btnCom1.Text == "打开")
           {
               btnCom1.Text = "关闭";
             if(serialPortTool.openSerial())
             {
                    ;//  ptbComState1.Image = Properties.Resources.low;
             }
           }
            else
           {
               btnCom1.Text = "打开";
               if (serialPortTool.closeSerial())
               {
                    ;//  ptbComState1.Image = Properties.Resources.high;
               }
           }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPortTool.SendData =  textBox1.Text;
            serialPortTool.run();
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetVal(ref this.serialPortTool);
                this.Hide();
                frm = null;
                handleSetval(this.serialPortTool);
            }
            catch
            {
                this.Hide();
                frm = null;
                handleSetval(this.serialPortTool);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = null;
        }

        private void frm_Serial_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.FormClosing += frm_Serial_FormClosing;
        }

        void frm_Serial_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = null;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serialPortTool.SendData = this.textBox1.Text;
        }
    }
}
