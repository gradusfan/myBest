using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BasicDemo;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace FanSwProject
{
    public partial class Form_main : MetroForm
    {


        private Form currentForm;
        private Form_set form_setParam = new Form_set();
        private BasicDemo.Form1 form1 = new Form1();

        private Form_Mycrama form_Mycrama = new Form_Mycrama();
        public Form_main()
        {
            InitializeComponent();

            // 初始化Panel
         
        }


        private void LoadForm(object page)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.Clear();
            }
            if (page is Form form)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.panel2.Controls.Add(form);
                this.panel2.Tag = form;
                form.Show();
            }

        }


        //主页
        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadForm(new Form_set());
        }



        //手动按钮
        private void btn_hand_Click(object sender, EventArgs e)
        {
           
        }

        

        private void btn_stop_Click(object sender, EventArgs e)
        {
            form_Mycrama.Show();
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {

        }

        private void btn_camera_Click(object sender, EventArgs e)
        {

            LoadForm(new BasicDemo.Form1());

        }




        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            LoadForm(form_setParam);
            AddLog(1, "加载设置参数页面");
            LogRecord.WriteOperLog("加载设置参数页面成功");
        }


        private void btn_quite_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出软件吗?", "WARNING", MessageBoxButtons.OKCancel);
            AddLog(1, "确定要退出软件吗?");
            LogRecord.WriteOperLog("确定要退出软件吗");
            if (result == DialogResult.OK)
                Application.Exit();
            else
                return;
        }















        private string CurrentTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        public void AddLog(int index, string log)
        {
            try
            {
                if (!this.lst_Info.InvokeRequired)
                {
                    ListViewItem lst = new ListViewItem(log + CurrentTime, index);
                    lst.SubItems.Add(log);

                    this.lst_Info.Items.Insert(0, lst);
                    if (this.lst_Info.Items.Count == 200)
                    {
                        this.lst_Info.Items.RemoveAt(199);
                    }
                }
                else
                {
                    this.lst_Info.Invoke(new Action(() =>
                    {
                        ListViewItem lst = new ListViewItem("   " + CurrentTime, index);
                        lst.SubItems.Add(log);

                        this.lst_Info.Items.Insert(0, lst);
                        if (this.lst_Info.Items.Count == 200)
                        {
                            this.lst_Info.Items.RemoveAt(199);
                        }
                    }));
                }
            }
            catch (Exception)
            {
            }

        }


    }
}
