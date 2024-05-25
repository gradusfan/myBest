using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XFF_Vision.BLL;

namespace XFF_Vision
{
    public partial class frm_Reg : Form
    {
        RegistryKey LocalMachine = Registry.LocalMachine;
        RegClassBLL reg = new RegClassBLL();
        public frm_Reg()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            workConfi_Licence1();
            //RGE();
        }

        void RGE()
        {
            RegistryKey regKey;
            try
            {
                using (RegistryKey software = LocalMachine.OpenSubKey("SOFTWARE", true))//打开software文件夹
                {
                    if (textBox2.Text.Equals(""))
                    {
                        MessageBox.Show("请输入密钥");
                        return;
                    }
                    if ((regKey = software.OpenSubKey("Licence", true)) == null)
                    {
                        software.CreateSubKey("Licence");//创建密钥文件夹
                        regKey = software.OpenSubKey("Licence", true);//打开密钥文件夹
                        regKey.SetValue("licence", textBox2.Text);//密钥赋值
                    }
                    else
                    {
                        regKey.SetValue("licence", textBox2.Text);//密钥赋值
                        reg.GetRegistryKey();//或取密钥注册表值
                    }
                    if (reg.MachineNum.Equals(reg.RegKey)) //密钥比较
                    {
                        this.Hide();
                        MessageBox.Show("注册软件成功！");
                        frm_Main fm = new frm_Main();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("注册软件失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public bool workConfi_Licence1()
        {//保存产品信息
            bool isok = false;
            try
            {
               //workConfi_Licence.Licence= textBox2.Text;              
                string path = Application.StartupPath + @"\files\Licence.txt";               
                BinaryFormatter bf = new BinaryFormatter();
                FileStream s = File.OpenWrite(path);
                bf.Serialize(s, null);
                s.Close();
                //this.SaveEWorldShape();
                if (reg.MachineNum.Equals(textBox2.Text)) //密钥比较
                {
                    //this.Hide();
                    MessageBox.Show("注册软件成功！");
                    //frm_Main fm = new frm_Main();
                    //fm.Show();
                }
                else
                {
                    MessageBox.Show("注册软件失败！");
                }
                isok = true;               
               

            }
            catch (Exception ce)
            {
                MessageBox.Show("注册软件失败!");
            }

            return isok;
        }
        private void frm_Reg_Load(object sender, EventArgs e)
        {


            textBox1.Text= reg.CPU + reg.DiskVolumeSerialNumber;
        }
    }
}
