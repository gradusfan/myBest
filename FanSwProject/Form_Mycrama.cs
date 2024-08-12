using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;

namespace FanSwProject
{
    public partial class Form_Mycrama : Form
    {
        public Form_Mycrama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VM Sol File|*.sol*";
            DialogResult openFileRes = openFileDialog.ShowDialog();
            if (DialogResult.OK == openFileRes)
            {
                textBox1.Text = openFileDialog.FileName;
            }
            listBox1.Items.Add("选择路径成功");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VmSolution.Load(textBox1.Text);
            listBox1.Items.Add("方案加载成功");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VmSolution.Instance.SyncRun();
            listBox1.Items.Add("方案执行一次成功");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VmSolution.Save();
            listBox1.Items.Add("方案保存成功");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }
    }
}
