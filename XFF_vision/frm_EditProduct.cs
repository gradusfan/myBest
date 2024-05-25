using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace XFF_Vision
{
    public partial class frm_EditProduct : Form
    {
        //string productName1 = Application.StartupPath ;
        public frm_EditProduct()
        {
            InitializeComponent();
        }

        private void frm_EditProduct_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.upDirectory();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 刷新料号
        /// </summary>
        private void upDirectory()//刷新料号
        {
            this.lbxProductName.Items.Clear();

            if (Product.Instance != null)
            {

                for (int i = 0; i < Product.Instance.Models.Count; i++)
                {
                    this.lbxProductName.Items.Add(Product.Instance.Models[i].ModelName);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定添加料号吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
                return;
            if (kBtbxName.Text != "")
            {
                if (kBtbxName.Text.Length == 1)
                {
                    MessageBox.Show("料号： " + kBtbxName.Text + " 添加料号名不得少于1个字！");
                    return;
                }

                string name = kBtbxName.Text;

                if (Product.Instance.GetModelbyName(name) == null)
                {
                    Product.Instance.Models.Add(new ModelConfig()
                    {
                        ModelName = name
                    });
                    if (!Directory.Exists(Product.Instance.VisionPath + @"\" + name))
                        Directory.CreateDirectory(Product.Instance.VisionPath + @"\" + name);
                    upDirectory();//刷新
                }
                else
                {
                    MessageBox.Show("料号添加失败，料号资料已存在！");
                }
            }
            else
            {
                MessageBox.Show("料号添加失败，请输入料号！");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除料号吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
                return;
            if (lbxProductName.Text != "")//
            {
                string name = kBtbxName.Text;
                ModelConfig temp = Product.Instance.GetModelbyName(name);
                if (temp != null)
                {
                    Product.Instance.Models.Remove(temp);
                    if (Directory.Exists(Product.Instance.VisionPath + @"\" + name))
                        DelectDir(Product.Instance.VisionPath + @"\" + name);
                    MessageBox.Show("料号  " + lbxProductName.Text + " 删除成功！");
                    upDirectory();//刷新
                }
                else
                {
                    MessageBox.Show("料号删除失败，料号资料不存在！");
                }
            }
            else
            {
                MessageBox.Show("料号删除失败，请输入料号！");
            }
        }

        private void lbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lbxProduct = (ListBox)sender;
            kBtbxName.Text = lbxProduct.Text;
        }

        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos(); //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo) //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true); //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName); //删除指定文件
                    }
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
