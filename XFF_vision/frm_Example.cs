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
using WeifenLuo.WinFormsUI.Docking;

namespace XFF_Vision
{
    public partial class frm_Example : DockContent
    {
        public delegate void SelcetDelegate(string type);
        public static event SelcetDelegate SelcetToolEvent;
        static frm_Example _instance;
        string toolPath1;
        public frm_Example()
        {
            InitializeComponent();
        }
        public static frm_Example Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frm_Example();
                return _instance;
            }
        }
        private void frm_Example_Load(object sender, EventArgs e)
        {
            this.tvwExample.ImageList = this.imageList1;
            this.Text = "配置";
            string toolPath = Product.Instance.VisionPath+@"\"+ Product.Instance.CurrentModel;
            string[] exampleFile = Directory.GetFiles(toolPath, "*.vin");
            //string[] exampleFile = Directory.GetFiles(toolPath, "*.xffp");
            TreeNode tn = tvwExample.Nodes.Add("", "配置文件", 0, 0);
            for (int i = 0; i < exampleFile.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(exampleFile[i]);
                TreeNode tn1 = tn.Nodes.Add("", fileInfo.Name, 1, 1);
            }
        }

        public string productName3 { get; internal set; }

        private void frm_Example_FormClosing(object sender, FormClosingEventArgs e)
        {

            _instance = null;
        }

        private void tvwExample_DoubleClick(object sender, EventArgs e)
        {
            //string toolPath = Application.StartupPath + @"\"+lblProName2 + @"\ ";
            //string toolPath = Application.StartupPath + @"\配置文件\" + lblProName2 + @"\";
            string toolPath = frm_Job.Instance.toolPath + @"\";
            string nodePath = tvwExample.SelectedNode.Text;
            //nodePath = examplePath + nodePath;
            nodePath = toolPath + nodePath;
            if (File.Exists(nodePath))
            {
                SelcetToolEvent(nodePath);

            }
        }
    }
}
