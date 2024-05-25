using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace XFF_Vision
{
    public partial class frm_Output : DockContent
    {
        public frm_Output()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static frm_Output _instance;
        public static frm_Output Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frm_Output();
                return _instance;
            }
        }
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="msg">信息内容</param>
        /// <param name="color">颜色显示</param>
        public void OutputMsg(string msg, Color color)
        {
            try
            {
                listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width-10 ;
                ListViewItem item = new ListViewItem();
                item.Text = DateTime.Now.ToString("HH:mm:ss");
                item.SubItems.Add(msg);
                item.ForeColor = color;
                listView1.Items.Insert(0, item);
                if (listView1.Items.Count > 100)
                    listView1.Items.RemoveAt(100);
            }
            catch (Exception ex)
            {
              //错误日志
            }
        }

        private void frm_Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }


        //internal static void IsDisposed()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
