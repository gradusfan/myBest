using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionTool.ImageToolDAL;
using XFF_Vision;

namespace XFF_vision.frm_Tool
{
    public partial class frm_9PointCalib : Form
    {

        static frm_9PointCalib frm;
        _9PointCalibTool _9pointCalibTool = new _9PointCalibTool();
        public delegate void HandledSetVal(_9PointCalibTool _9pointCalibTool);
        HandledSetVal handleSetval;

        /// <summary>
        /// 单实例
        /// </summary>
        /// <param name="fb"></param>
        public static frm_9PointCalib SingleShow(_9PointCalibTool _9pointCalibTool, HandledSetVal handleSetval)
        {
            if (frm == null)//
            {
                frm = new frm_9PointCalib(_9pointCalibTool, handleSetval);
            }
            return frm;
        }
        public frm_9PointCalib()
        {
            InitializeComponent();
        }
        public frm_9PointCalib(_9PointCalibTool _9pointCalibTool, HandledSetVal handleSetval)
        {
            InitializeComponent();
            this.handleSetval = handleSetval;
            DisplayVal(_9pointCalibTool);
            this._9pointCalibTool.HtRow = _9pointCalibTool.HtRow;
            this._9pointCalibTool.HtCol = _9pointCalibTool.HtCol;
            this._9pointCalibTool.HtAngle = _9pointCalibTool.HtAngle;
            this._9pointCalibTool.Image = _9pointCalibTool.Image;
            this._9pointCalibTool.SetdrawShape = _9pointCalibTool.SetdrawShape;
            this._9pointCalibTool.Circle = _9pointCalibTool.Circle;
            this._9pointCalibTool.Rectangle1 = _9pointCalibTool.Rectangle1;
            this._9pointCalibTool.Rectangle2 = _9pointCalibTool.Rectangle2;
            this._9pointCalibTool.HomMat2D = _9pointCalibTool.HomMat2D;
            this._9pointCalibTool.PixelX = _9pointCalibTool.PixelX;
            this._9pointCalibTool.PixelY = _9pointCalibTool.PixelY;
            this._9pointCalibTool.AxisX = _9pointCalibTool.AxisX;
            this._9pointCalibTool.AxisY = _9pointCalibTool.AxisY;
            this._9pointCalibTool.AngleName = _9pointCalibTool.AngleName;

            //this.fixtureTool.HtPhi = _9pointCalibTool.HtPhi;
            SetVal(ref this._9pointCalibTool);
        }

        void DisplayVal(_9PointCalibTool _9pointCalibTool)
        {
            try
            {
                int nameIndex = _9pointCalibTool.Names.LastIndexOf("_");
                if (nameIndex != -1)
                {
                    string name = _9pointCalibTool.Names.Substring(nameIndex + 1, _9pointCalibTool.Names.Length - (nameIndex + 1));
                    this.Text = name;
                    tbxToolName.Text = name;
                }
                else
                {
                    this.Text = _9pointCalibTool.Names;
                    tbxToolName.Text = _9pointCalibTool.Names;
                }

                cbxAngle.Text = _9pointCalibTool.AngleName;
                cbxImage.Text = _9pointCalibTool.ImageName;
                cbxModelName.Text = _9pointCalibTool.ModelName;
                cebxIsSelectedRegions.Checked = _9pointCalibTool.IsSelectedRegions;
                cebxIsRectangle.Checked = _9pointCalibTool.IsRectangle;
                cbxSetdraw.Text = _9pointCalibTool.Setdraw;
                ip.Text = _9pointCalibTool.IP;
                port.Text = _9pointCalibTool.Port;
                tbxWorldX1.Text = _9pointCalibTool.tbxWorldX1;
                tbxWorldX2.Text = _9pointCalibTool.tbxWorldX2;
                tbxWorldX3.Text = _9pointCalibTool.tbxWorldX3;
                tbxWorldrX.Text = _9pointCalibTool.tbxWorldrX;
                tbxWorldY1.Text = _9pointCalibTool.tbxWorldY1;
                tbxWorldY2.Text = _9pointCalibTool.tbxWorldY2;
                tbxWorldY3.Text = _9pointCalibTool.tbxWorldY3;
                tbxWorldrY.Text = _9pointCalibTool.tbxWorldrY;
                checkBox1.Checked = _9pointCalibTool.StationA;

                lblCalib.Text = "未标定!";
                if (_9pointCalibTool.HomMat2D != null)
                {
                    lblCalib.Text = "标定成功!";
                    lblCalib.BackColor = Color.Green;
                }
                //listview数据刷新
                listView1.BeginUpdate();
                listView1.Items.Clear();
                for (int i = 0; i < _9pointCalibTool.PixelX.Length; i++)
                {
                    ListViewItem i_Item = listView1.Items.Add("第" + (listView1.Items.Count + 1) + "点");
                    i_Item.SubItems.Add(_9pointCalibTool.PixelX[i].D.ToString());
                    i_Item.SubItems.Add(_9pointCalibTool.PixelY[i].D.ToString());
                    i_Item.SubItems.Add(_9pointCalibTool.AxisX[i].D.ToString());
                    i_Item.SubItems.Add(_9pointCalibTool.AxisY[i].D.ToString());
                }
                listView1.EndUpdate();

                if (_9pointCalibTool.Image != null)
                {
                    foreach (var item in _9pointCalibTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                halconView1.DispImage((HObject)_9pointCalibTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
                //
                foreach (var item in _9pointCalibTool.HtRow.Keys)
                {
                    cbxModelName.Items.Add(item); //加载图像到下拉箱
                }

                foreach (var item in _9pointCalibTool.HtAngle.Keys)
                {
                    cbxAngle.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                if (_9pointCalibTool.Image != null)
                {
                    foreach (var item in _9pointCalibTool.Image.Keys)
                    {
                        cbxImage.Items.Add(item); //加载图像到下拉箱
                    }
                }
                //2020.6.16开启报错
                //halconView1.DispImage((HObject)_9pointCalibTool.Image[cbxImage.Text], true);
                halconView1.FitImage();
                foreach (var item in _9pointCalibTool.HtRow.Keys)
                {
                    cbxModelName.Items.Add(item); //加载图像到下拉箱
                }
                foreach (var item in _9pointCalibTool.HtAngle.Keys)
                {
                    cbxAngle.Items.Add(item);
                }
            }
        }
        void SetVal(ref _9PointCalibTool _9pointCalibTool)
        {
            _9pointCalibTool.Names = FixtureTool.Tool.九点标定.ToString() + "_" + tbxToolName.Text;
            _9pointCalibTool.AngleName = cbxAngle.Text;
            _9pointCalibTool.ImageName = cbxImage.Text;
            _9pointCalibTool.ModelName = cbxModelName.Text;
            _9pointCalibTool.IsSelectedRegions = cebxIsSelectedRegions.Checked;
            _9pointCalibTool.IsRectangle = cebxIsRectangle.Checked;
            _9pointCalibTool.Setdraw = cbxSetdraw.Text;
            _9pointCalibTool.StationA = checkBox1.Checked;
            _9pointCalibTool.IP = ip.Text;
            _9pointCalibTool.Port = port.Text;
            _9pointCalibTool.tbxWorldX1 = tbxWorldX1.Text;
            _9pointCalibTool.tbxWorldX2 = tbxWorldX2.Text;
            _9pointCalibTool.tbxWorldX3 = tbxWorldX3.Text;
            _9pointCalibTool.tbxWorldrX = tbxWorldrX.Text;
            _9pointCalibTool.tbxWorldY1 = tbxWorldY1.Text;
            _9pointCalibTool.tbxWorldY2 = tbxWorldY2.Text;
            _9pointCalibTool.tbxWorldY3 = tbxWorldY3.Text;
            _9pointCalibTool.tbxWorldrY = tbxWorldrY.Text;
            int i = 0;
            foreach (ListViewItem i_Item in listView1.Items)
            {
                _9pointCalibTool.PixelX[i] = Convert.ToDouble(i_Item.SubItems[1].Text);
                _9pointCalibTool.PixelY[i] = Convert.ToDouble(i_Item.SubItems[2].Text);
                _9pointCalibTool.AxisX[i] = Convert.ToDouble(i_Item.SubItems[3].Text);
                _9pointCalibTool.AxisY[i] = Convert.ToDouble(i_Item.SubItems[4].Text);
                i++;
            }

        }
        void Cancel()
        { }
        void Register()
        { }

        private void tbxToolName_TextChanged(object sender, EventArgs e)
        {
            this._9pointCalibTool.Names = _9PointCalibTool.Tool.九点标定.ToString() + "_" + tbxToolName.Text;
            this.Text = tbxToolName.Text;
        }

        private void cbxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            halconView1.DispImage((HObject)this._9pointCalibTool.Image[cbxImage.Text], true);
            halconView1.FitImage();
            _9pointCalibTool.ImageName = cbxImage.Text;
        }
        private void tbxWorldX_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbxWorldY_TextChanged(object sender, EventArgs e)
        {

        }
        private void btndrawRoi_Click(object sender, EventArgs e)
        {
            halconView1.ContextMenuStripHide();
            halconView1.Focus();
            _9pointCalibTool.draw_roi();
        }

        private void btnPLC_Click(object sender, EventArgs e)
        {
            try
            {
                string index = (listView1.Items.Count + 1).ToString();
                //string str = QRCode(ip.Text, Convert.ToInt32(port.Text), "B;" + index, 5000, 5000);
                string str = QRCode(ip.Text, Convert.ToInt32(port.Text), "START\r\n", 5000, 5000);
                if (str == "")
                {
                    return;
                }
                string[] xyu = str.Split(',');
                tbxWorldX.Text = xyu[0];
                tbxWorldY.Text = xyu[1];
                //string strOK = QRCode(ip.Text, Convert.ToInt32(port.Text), "OK;" + index, 5000, 5000);
            }
            catch (Exception)
            {
                String index = (listView1.Items.Count + 1).ToString();
                // string strNG = QRCode(ip.Text, Convert.ToInt32(port.Text), "NG;" + index, 5000, 5000);
                MessageBox.Show("机械手数据为空,是否超出定义点数!");
                // throw;
            }

        }
        public string QRCode(string address = "192.168.3.101", int port = 10003, string code = "T", int contime = 5000, int temptime = 5000)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(address);
                IPEndPoint ipe = new IPEndPoint(ip, port);

                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(ipe);
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
                clientSocket.ReceiveTimeout = contime;
                byte[] sendBytes = Encoding.ASCII.GetBytes(code);
                clientSocket.Send(sendBytes);

                bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
                recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
                //List<string> resl = recStr.Split(',').ToArray().ToList();
                //if (show) Tools.Print(string.Join("",resl));

                clientSocket.Close();

                return recStr;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        private void btnGetImageCoord_Click(object sender, EventArgs e)
        {
            try
            {
                //查找模板并获取图像坐标
                if (_9pointCalibTool.CenterRow != null)
                {
                    tbxImageY.Text = _9pointCalibTool.CenterRow.ToString();
                    tbxImageX.Text = _9pointCalibTool.CenterCol.ToString();

                }
                else
                {

                    tbxImageY.Text = _9pointCalibTool.htRow[cbxModelName.Text].ToString().Substring(0, 6);
                    tbxImageX.Text = _9pointCalibTool.htCol[cbxModelName.Text].ToString().Substring(0, 6);
                }

            }
            catch (System.Exception ex)
            {

            }
        }
        //添加坐标
        private void btnAddImageCoord_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxImageX.Text == "" || tbxImageY.Text == "" || tbxWorldX.Text.Trim() == "" || tbxWorldY.Text.Trim() == "")
                {
                    MessageBox.Show("坐标不能为空！", "提示信息");
                    return;
                }

                ListViewItem i_Item = listView1.Items.Add("第" + (listView1.Items.Count + 1) + "点");
                i_Item.SubItems.Add(tbxImageX.Text);
                i_Item.SubItems.Add(tbxImageY.Text);
                i_Item.SubItems.Add(tbxWorldX.Text);
                i_Item.SubItems.Add(tbxWorldY.Text);
                i_Item.EnsureVisible();

                int i = 0;
                foreach (ListViewItem Item in listView1.Items)
                {
                    _9pointCalibTool.PixelX[i] = Convert.ToDouble(Item.SubItems[1].Text);
                    _9pointCalibTool.PixelY[i] = Convert.ToDouble(Item.SubItems[2].Text);
                    _9pointCalibTool.AxisX[i] = Convert.ToDouble(Item.SubItems[3].Text);
                    _9pointCalibTool.AxisY[i] = Convert.ToDouble(Item.SubItems[4].Text);
                    i++;
                }
            }
            catch (System.Exception ex)
            {

            }
        }
        //标定
        private void btnCalib_Click(object sender, EventArgs e)
        {
            try
            {
                //判断图像是否为空

                //MessageBox.Show("图像为空!");
                //return;

                //导出listview坐标数据
                int i = 0;
                foreach (ListViewItem i_Item in listView1.Items)
                {
                    _9pointCalibTool.PixelX[i] = Convert.ToDouble(i_Item.SubItems[1].Text);
                    _9pointCalibTool.PixelY[i] = Convert.ToDouble(i_Item.SubItems[2].Text);
                    _9pointCalibTool.AxisX[i] = Convert.ToDouble(i_Item.SubItems[3].Text);
                    _9pointCalibTool.AxisY[i] = Convert.ToDouble(i_Item.SubItems[4].Text);
                    i++;
                }
                //计算仿射变换矩阵
                _9pointCalibTool.gen_calib_data();
                if (_9pointCalibTool.HomMat2D != null)
                {
                    lblCalib.Text = "标定成功!";
                    lblCalib.BackColor = Color.Green;
                    MessageBox.Show("标定成功!");

                }
            }
            catch
            {
                MessageBox.Show("标定异常");
                lblCalib.Text = "未标定!";
                lblCalib.BackColor = Color.Red;
            }
        }
        //删除选中
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)       //判断选择行
                {
                    listView1.SelectedItems[0].Remove();     //删除选定行

                    //坐标重新赋值
                    _9pointCalibTool.PixelX = 0;
                    _9pointCalibTool.PixelY = 0;
                    _9pointCalibTool.AxisX = 0;
                    _9pointCalibTool.AxisY = 0;
                    int i = 0;
                    foreach (ListViewItem i_Item in listView1.Items)
                    {
                        _9pointCalibTool.PixelX[i] = Convert.ToDouble(i_Item.SubItems[1].Text);
                        _9pointCalibTool.PixelY[i] = Convert.ToDouble(i_Item.SubItems[2].Text);
                        _9pointCalibTool.AxisX[i] = Convert.ToDouble(i_Item.SubItems[3].Text);
                        _9pointCalibTool.AxisY[i] = Convert.ToDouble(i_Item.SubItems[4].Text);
                        i++;
                    }
                    //listview数据刷新
                    listView1.BeginUpdate();
                    listView1.Items.Clear();
                    for (i = 0; i < _9pointCalibTool.PixelX.Length; i++)
                    {
                        ListViewItem i_Item = listView1.Items.Add("第" + (listView1.Items.Count + 1) + "点");
                        i_Item.SubItems.Add(_9pointCalibTool.PixelX[i].D.ToString());
                        i_Item.SubItems.Add(_9pointCalibTool.PixelY[i].D.ToString());
                        i_Item.SubItems.Add(_9pointCalibTool.AxisX[i].D.ToString());
                        i_Item.SubItems.Add(_9pointCalibTool.AxisY[i].D.ToString());
                    }
                    listView1.EndUpdate();
                }
            }
            catch (System.Exception ex)
            {

            }
        }
        //删除所有
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _9pointCalibTool.PixelX = 0;
            _9pointCalibTool.PixelY = 0;
            _9pointCalibTool.AxisX = 0;
            _9pointCalibTool.AxisY = 0;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            long timer = this._9pointCalibTool.set_after();

            halconView1.ToolLable2.Text = "FAIL";
            halconView1.ToolLable2.ForeColor = Color.Red;
            if (this._9pointCalibTool.ResultLogic)
            {
                halconView1.ToolLable2.Text = "PASS";
                halconView1.ToolLable2.ForeColor = Color.Lime;
            }
            halconView1.ToolLable3.Text = string.Format("{0}{1}{2}", "耗时:", timer.ToString(), "ms");
        }
        private void btn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetVal(ref this._9pointCalibTool);
                this.Hide();
                frm = null;
                handleSetval(this._9pointCalibTool);
            }
            catch
            {
                this.Hide();
                frm = null;
                handleSetval(this._9pointCalibTool);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = null;
        }

        private void cbxModelName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void frm_9PointCalib_Load(object sender, EventArgs e)
        {
            this.FormClosing += Frm_9PointCalib_FormClosing;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            HOperatorSet.SetWindowParam(halconView1.HalconWindow, "background_color", "blue");
            this.CenterToScreen();
            string[] roi = new string[] { CaliperTool.Roi.方向矩形.ToString() };
            this._9pointCalibTool.WindowControl = halconView1.HWindowControl;
        }

        private void Frm_9PointCalib_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = null;
        }

        private void cebxIsSelectedRegions_CheckedChanged(object sender, EventArgs e)
        {
            _9pointCalibTool.IsSelectedRegions = cebxIsSelectedRegions.Checked;
        }

        private void cebxIsRectangle_CheckedChanged(object sender, EventArgs e)
        {
            _9pointCalibTool.IsRectangle = cebxIsRectangle.Checked;
        }

        private void cbxSetdraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            _9pointCalibTool.Setdraw = cbxSetdraw.Text;
        }

        private void btnGetImageCoord1_Click(object sender, EventArgs e)
        {
            _9pointCalibTool.toolRunr();
            tbxWorldX1.Text = _9pointCalibTool.Hv_Axis_X.ToString();
            tbxWorldY1.Text = _9pointCalibTool.Hv_Axis_Y.ToString();
        }

        private void btnGetImageCoord2_Click(object sender, EventArgs e)
        {

            _9pointCalibTool.toolRunr();
            tbxWorldX2.Text = _9pointCalibTool.Hv_Axis_X.ToString();
            tbxWorldY2.Text = _9pointCalibTool.Hv_Axis_Y.ToString();
        }

        private void btnGetImageCoord3_Click(object sender, EventArgs e)
        {
            _9pointCalibTool.toolRunr();
            tbxWorldX3.Text = _9pointCalibTool.Hv_Axis_X.ToString();
            tbxWorldY3.Text = _9pointCalibTool.Hv_Axis_Y.ToString();
        }

        private void btnCalib1_Click(object sender, EventArgs e)
        {
            //点定圆，计算圆心和半径
            try
            {
                PointF p2 = new PointF();
                PointF p3 = new PointF();
                double r = 30;

                p2.X = (float)(float.Parse(this.tbxWorldX2.Text));
                p2.Y = (float)(float.Parse(this.tbxWorldY2.Text));
                p3.X = (float)(float.Parse(this.tbxWorldX3.Text));
                p3.Y = (float)(float.Parse(this.tbxWorldY3.Text));

                PointF center = new PointF();
                r = r * Math.PI / 180;
                GetCircular(p2, p3, r, ref center);

                this.tbxWorldrX.Text = center.X + "";
                this.tbxWorldrY.Text = center.Y + "";
                // this.txtCirR.Text = r + "";
            }
            catch (Exception ce)
            {
                //this.showmesssageintxt(ce.Message + "");
            }

        }
        public void GetCircular(PointF p1, PointF p2, PointF p3, ref float r, ref PointF center)
        {//计算旋转中心
            try
            {
                float a = 2 * (p2.X - p1.X);
                float b = 2 * (p2.Y - p1.Y);
                float c = p2.X * p2.X + p2.Y * p2.Y - p1.X * p1.X - p1.Y * p1.Y;
                float d = 2 * (p3.X - p2.X);
                float e = 2 * (p3.Y - p2.Y);
                float f = p3.X * p3.X + p3.Y * p3.Y - p2.X * p2.X - p2.Y * p2.Y;

                float x = (b * f - e * c) / (b * d - e * a);
                float y = (d * c - a * f) / (b * d - e * a);
                float R = (float)Math.Sqrt((double)((x - p1.X) * (x - p1.X) + (y - p1.Y) * (y - p1.Y)));
                r = R;
                PointF pc = new PointF(x, y);
                center = pc;
            }
            catch (Exception ce)
            {
                //this.showmesssageintxt(ce.Message + "");
            }

        }

        /// <summary>
        /// 两点计算旋转中心
        /// </summary>
        /// <param name="p1">标定特征点</param>
        /// <param name="p2">旋转角度后的点</param>
        /// <param name="angle">旋转角度</param>
        /// <param name="center">旋转中心</param>
        public void GetCircular(PointF p1, PointF p2, double angle, ref PointF center)
        {
            double X = (p1.X + p2.X) / 2 + (p1.Y - p2.Y) / 2 * Math.Sin(angle) / (1 - Math.Cos(angle));
            double Y = (p1.Y + p2.Y) / 2 - (p1.X - p2.X) / 2 * Math.Sin(angle) / (1 - Math.Cos(angle));
            center = new PointF((float)X, (float)Y);

            double dx = Math.Cos(angle) * (X - p1.X) - Math.Sin(angle) * (Y - p1.Y) + p2.X - X;
            double dy = Math.Cos(angle) * (Y - p1.Y) + Math.Sin(angle) * (X - p1.X) + p2.Y - Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HslCommunication.Profinet.Keyence.KeyenceMcNet MelsecMcNet = new HslCommunication.Profinet.Keyence.KeyenceMcNet(ip.Text, Convert.ToInt32(port.Text)))
            {
                if (checkBox1.Checked)
                {
                    tbxWorldX.Text = (MelsecMcNet.ReadInt32("D5762").Content*0.01).ToString();
                    tbxWorldY.Text = (MelsecMcNet.ReadInt32("D5764").Content*0.01).ToString();
                }
                else
                {
                    tbxWorldX.Text = (MelsecMcNet.ReadInt32("D10762").Content*0.01).ToString();
                    tbxWorldY.Text = (MelsecMcNet.ReadInt32("D10764").Content*0.01).ToString();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _9pointCalibTool.StationA = checkBox1.Checked;
        }

        private void cbxAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _9pointCalibTool.AngleName = cbxAngle.Text;
            _9pointCalibTool.MyAngle = _9pointCalibTool.HtAngle[cbxAngle.Text];
        }
    }
}
