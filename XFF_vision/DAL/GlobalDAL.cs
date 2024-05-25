using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OperationIni;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Data;
using System.Data.OleDb;
using System.Collections;


namespace XFF_Vision
{

    public class GlobalDAL
    {
        /// <summary>
        /// 产品名
        /// </summary>
        public static string product_name;
        /// <summary>
        /// 绝对路径
        /// </summary>
        public static string app_path = Application.StartupPath;
        /// <summary>
        /// 产品参数路径
        /// </summary>
        public static string path_Product = Application.StartupPath + @"\Product\";
        /// <summary>
        /// 数据库参数路径
        /// </summary>
        public static string path_DataBase = Application.StartupPath + @"\DataBase\";
        /// <summary>
        /// 产品弹簧力检测参数路径
        /// </summary>
        public static string path_CheckVal = Application.StartupPath + @"\CheckVal\";
        /// <summary>
        /// 串口参数路径
        /// </summary>
        public static string path_Serial = Application.StartupPath + @"\Serial_Port\";
        /// <summary>
        /// 密码参数路径
        /// </summary>
        public static string path_password = Application.StartupPath + @"\Password\";
        /// <summary>
        /// 条码长度
        /// </summary>
        public static string lab_lenght;
        /// <summary>
        /// 管理员密码
        /// </summary>
        public static int password_admin;
        /// <summary>
        ///操作员密码
        /// </summary>
        public static int password_operator;
        /// <summary>
        /// 读ini文件
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">键值</param>
        /// <param name="noText">参数</param>
        /// <param name="iniFilePath">文件路径</param>
        /// <returns>返回参数</returns>
        public static string ReadIniString(string section, string key, string noText, string iniFilePath)
        {
            StringBuilder temp = new StringBuilder(1024);
            InitFile.ReadString(section, key, noText, temp, 1024, iniFilePath);
            return temp.ToString();
        }
        /// <summary>
        /// 写ini文件
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">键值</param>
        /// <param name="val">参数</param>
        /// <param name="iniFilePath">文件路径</param>
        public static void WriteIniString(string section, string key, string val, string iniFilePath)
        {
            InitFile.WriteString(section, key, val, iniFilePath);
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="iniFilePath">文件路径</param>
        public static void DelectIniString(string section,string iniFilePath)
        {
            InitFile.DelSection(section, iniFilePath);
        }
        /// <summary>
        /// 读取所有节点
        /// </summary>
        /// <param name="iniFilePath">文件路径</param>
        /// <returns></returns>
        public static ArrayList ReadIniSections(string iniFilePath)
        {
           return  InitFile.ReadSections(iniFilePath);
        }
        /// <summary>
        /// 十六进制转二进制
        /// </summary> 
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Hex_to_Bin(string str)
        {
            string[] h2b = {
              "0000",
              "0001",
              "0010",
              "0011",
              "0100",
              "0101",
              "0110",
              "0111",
              "1000",
              "1001",
              "1010",
              "1011",
              "1100",
              "1101",
              "1110",
              "1111",
            };

            if (string.Equals(str, null))
            {
                return "";
            }
            string[] b = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                b[i] = str[i] >= 'a' ? h2b[str[i] - 'a' + 10] : str[i] >= 'A' ? h2b[str[i] - 'A' + 10] : h2b[str[i] - '0'];
            }
            string B = string.Join("", b); // 
            return (B);
        }
        /// <summary>
        /// 字符倒叙
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }
            string str1 = new string(chars);
            return (str1);
        }

        /// <summary>
        /// 十六进制换算为十进制
        /// </summary>
        /// <param name="strColorValue"></param>
        /// <returns></returns>
        public static int GetHexadecimalValue(String strColorValue)
        {
            char[] nums = strColorValue.ToCharArray();
            int total = 0;
            try
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    String strNum = nums[i].ToString().ToUpper();
                    switch (strNum)
                    {
                        case "A":
                            strNum = "10";
                            break;
                        case "B":
                            strNum = "11";
                            break;
                        case "C":
                            strNum = "12";
                            break;
                        case "D":
                            strNum = "13";
                            break;
                        case "E":
                            strNum = "14";
                            break;
                        case "F":
                            strNum = "15";
                            break;
                        default:
                            break;
                    }
                    double power = Math.Pow(16, Convert.ToDouble(nums.Length - i - 1));
                    total += Convert.ToInt32(strNum) * Convert.ToInt32(power);
                }
            }
            catch (System.Exception ex)
            {
                String strErorr = ex.ToString();
                return 0;
            }
            return total;
        }
        /// <summary>
        ///  输入字符数据转4个字符数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] data_string(string str)
        {
            string[] STR = new string[4];
            STR[0] = str.Substring(0, 2);
            STR[1] = str.Substring(2, 2);
            STR[2] = str.Substring(4, 2);
            STR[3] = str.Substring(6, 2);
            return STR;
        }

       /// <summary>
       /// 输入PLC字符数据转4个字符数组
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
        public static string[] plc_string(string str)
        {
            string[] STR = new string[4];
            STR[0] = str.Substring(2, 2);
            STR[1] = str.Substring(0, 2);
            STR[2] = str.Substring(6, 2);
            STR[3] = str.Substring(4, 2);
            return STR;
        }
        /// <summary>
        /// 四字节16进制字节转浮点
        /// </summary>
        /// <param name="str"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <param name="str4"></param>
        /// <returns></returns>
        public static float hex4byte_to_float(string[] str)
        {
            byte[] bytes = new byte[4];
            Int32[] t = new Int32[4];
            t[0] = Convert.ToInt32(str[0], 16);
            t[1] = Convert.ToInt32(str[1], 16);
            t[2] = Convert.ToInt32(str[2], 16);
            t[3] = Convert.ToInt32(str[3], 16);

            bytes[0] = Convert.ToByte(t[0]);
            bytes[1] = Convert.ToByte(t[1]);
            bytes[2] = Convert.ToByte(t[2]);
            bytes[3] = Convert.ToByte(t[3]);
            return (BitConverter.ToSingle(bytes, 0));
        }

        /// <summary>
        /// 四字节10进制字节转浮点
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <param name="str4"></param>
        /// <returns></returns>
        public static float byte_to_float(string[] str)
        {
            byte[] bytes = new byte[4];
            bytes[0] = Convert.ToByte(str[0]);//
            bytes[1] = Convert.ToByte(str[1]);// 
            bytes[2] = Convert.ToByte(str[2]);//;
            bytes[3] = Convert.ToByte(str[3]);// ; 
            return (BitConverter.ToSingle(bytes, 0));
        }

        /// <summary>
        /// 浮点转换为四字节数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] float_to_byte(string str)
        {
            return (BitConverter.GetBytes(Convert.ToSingle(str)));
        }

        /// <summary>
        /// Exell追加文件行数
        /// </summary>
        /// <param name="fullFilename"></param>
        /// <param name="str_">输入信息字符组</param>
        /// <param name="lb">追加信息</param>
        ///  <param name="nums">信息长度</param>
        /// <returns></returns>
        public static string appendInfoToFile(string fullFilename, string[] str_, string lb, string nums)
        {
            int ini;
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object missingVal = System.Reflection.Missing.Value;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(
            Filename: fullFilename,
            ReadOnly: false,
            Origin: Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, //xlMacintosh/xlWindows/xlMSDOS
                //Delimiter: ",",  // usefule when is text file
            Editable: true,
            Notify: false,
                //Converter: missingVal, 
            AddToMru: true, //True to add this workbook to the list of recently used files
            Local: true,
            CorruptLoad: missingVal //xlNormalLoad/xlRepairFile/xlExtractData
            );
            //Get the first sheet 
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1); //also can get by sheet name
            Microsoft.Office.Interop.Excel.Range range = xlWorkSheet.UsedRange;
            //int usedColCount = range.Columns.Count;
            int usedRowCount = xlWorkSheet.UsedRange.CurrentRegion.Rows.Count;
            string str = ((Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1]).Text.ToString();
            if (usedRowCount <= 1 && string.IsNullOrEmpty(str.Trim()))//
            {
                ini = 0;
            }
            else
            {
                ini = 1;
            }

            if (usedRowCount == 1 && ini == 0)
            {
                Microsoft.Office.Interop.Excel.Range range1 = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[usedRowCount, 2];
                range1.NumberFormat = "@";
                xlWorkSheet.Cells[usedRowCount, 1] = DateTime.Now.ToString();
                xlWorkSheet.Cells[usedRowCount, 2] = lb;

            }
            else
            {
                Microsoft.Office.Interop.Excel.Range range1 = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[usedRowCount + 1, 2];
                range1.NumberFormat = "@";
                xlWorkSheet.Cells[usedRowCount + 1, 1] = DateTime.Now.ToString();
                xlWorkSheet.Cells[usedRowCount + 1, 2] = lb;
            }

            if (lb.Length != int.Parse(nums))
            {
                xlWorkSheet.Cells[usedRowCount + 1, 1] = DateTime.Now.ToString();
                xlWorkSheet.Cells[usedRowCount + 1, 2] = lb + "（" + str_[1] + ")";
                xlWorkBook.Close(SaveChanges: true);
                xlApp.Quit();
                foreach (Process p in Process.GetProcessesByName("Excel"))
                {
                    if (string.IsNullOrEmpty(p.MainWindowTitle))
                    {
                        p.Kill();
                    }
                }
                return str_[1];
            }

            for (int i = 1; i < usedRowCount + 1; i++)
            {
                if (ini == 0)
                {
                    continue;
                }
                string temp = ((Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[i, 2]).Text.ToString();
                if (temp == lb && temp != "NR" && !temp.Contains("条码信息不匹配"))
                {
                    xlWorkSheet.Cells[usedRowCount + 1, 1] = DateTime.Now.ToString();
                    xlWorkSheet.Cells[usedRowCount + 1, 2] = lb + "（" + str_[0] + ")";
                    xlWorkBook.Save();
                    xlWorkBook.Close(SaveChanges: true);
                    xlApp.Quit();
                    foreach (Process p in Process.GetProcessesByName("Excel"))
                    {
                        if (string.IsNullOrEmpty(p.MainWindowTitle))
                        {
                            p.Kill();
                        }
                    }
                    return str_[0];
                }

            }

            xlWorkBook.Save();
            xlWorkBook.Close(SaveChanges: true);
            xlApp.Quit();
            foreach (Process p in Process.GetProcessesByName("Excel"))
            {
                if (string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    p.Kill();
                }
            }
            return str_[2];
        }
        /// <summary>
        /// 创建excell文件
        /// </summary>
        /// <param name="path"></param>
        public static void creatnewfile(string path)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            worksheet.Cells.Select();
            worksheet.Cells.Columns.AutoFit();
            workbook.Saved = true;
            worksheet.SaveAs(path);
            workbook.Close();
            workbooks.Close();
            xlApp.Quit();
            foreach (Process p in Process.GetProcessesByName("Excel"))
            {
                if (string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    p.Kill();
                }
            }
        }


        
        /// <summary>
        /// 导出Excel表
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="title"></param>
        public static void Export_Excel(DataTable dt, string title)
        {
            //需要添加 Microsoft.Office.Interop.Excel引用 
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            if (app == null) { MessageBox.Show("本机未安装EXCEL软件！"); return; }
            app.Visible = false;
            app.UserControl = true;
            Microsoft.Office.Interop.Excel.Workbooks workbooks = app.Workbooks;
            Microsoft.Office.Interop.Excel._Workbook workbook = workbooks.Add(Missing.Value);
            Microsoft.Office.Interop.Excel.Sheets sheets = workbook.Sheets;
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)sheets.get_Item(1);
            #region fill data
            int cols = dt.Columns.Count;
            int rows = dt.Rows.Count;
            worksheet.Cells[1, 1] = title;//表名
            for (int i = 1; i <= cols; i++)//表头
            {
                worksheet.Cells[2, i] = dt.Columns[i - 1].ColumnName;
            }
            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, cols]];
            range.Merge(0);
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            range.Interior.ColorIndex = 44;//黄色
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    worksheet.Cells[i + 3, j] = dt.Rows[i][j - 1];
                }
            }
            worksheet.Columns.AutoFit(); //自动调整列宽。
            #endregion

            SaveFileDialog sfd = new SaveFileDialog();
            string path = "";
            sfd.Filter = "2007EXCEL文件(*.xlsx)|*.xlsx|2003EXCEL文件(*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                //string savaPath = "~/Temp/T1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
                workbook.SaveAs(path, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                workbook.Close();
                app.Quit();
                GC.Collect();
                MessageBox.Show("保存成功！");
            }
        }

        /// <summary>
        /// 创建文件 http://blog.sina.com.cn/s/blog_6d86f755019s92.html
        /// </summary>
        public static void Create_Dir()
        {
            string dt_str = DateTime.Now.Year.ToString("0000") + "-"
                          + DateTime.Now.Month.ToString("00") + "-"
                          + DateTime.Now.Day.ToString("00");
            //string Path = Application.StartupPath + "/Data/" + dt_str;
            string Path = "D:" + "/Scan_Data/" + dt_str;
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            if (!Directory.Exists(Path))
            {
                directoryInfo.Create();
                for (int i = 1; i <= 1; i++)
                {
                    //String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "/Data/" + dt_str + "/" + "S" + i + ".xls;" + "Extended Properties=Excel 8.0;";
                    String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + "D:" + "/Scan_Data/" + dt_str + "/" + "Temp" + i + ".xls;" + "Extended Properties=Excel 8.0;";
                    OleDbConnection cn = new OleDbConnection(sConnectionString);
                    //string sqlCreate = "CREATE TABLE TestSheet ([站号] INTEGER,[Is] VarChar,[Ie] VarChar,[检测结果] VarChar,[检测时间] VarChar)";
                    string sqlCreate = string.Format("CREATE TABLE TestSheet ([{0}] VarChar,[{1}] VarChar)", "扫描时间", "扫描结果");
                    OleDbCommand cmd = new OleDbCommand(sqlCreate, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        /// <summary>
        /// Excel 数据追加写入
        /// </summary>
        /// <param name="s"></param>
        /// <param name="Result"></param>lalel

        private static void Excel_Write(string Lalel_Result)
        {
            string dt_str = DateTime.Now.Year.ToString("0000") + "-"
                          + DateTime.Now.Month.ToString("00") + "-"
                          + DateTime.Now.Day.ToString("00");

            string dt_str1 = DateTime.Now.Year.ToString("0000") + "-"
                       + DateTime.Now.Month.ToString("00") + "-"
                       + DateTime.Now.Day.ToString("00") + " "
                       + DateTime.Now.Hour.ToString("00") + ":"
                       + DateTime.Now.Minute.ToString("00") + ":"
                       + DateTime.Now.Second.ToString("00");

            //String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "/Data/" + dt_str + "/" + "S" + s + ".xls;" + "Extended Properties=Excel 8.0;";
            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + "D:" + "/Scan_Data/" + dt_str + "/" + "Temp1.xls;" + "Extended Properties=Excel 8.0;";
            OleDbConnection cn = new OleDbConnection(sConnectionString);
            string sqlCreate = string.Format("INSERT INTO TestSheet VALUES('{0}','{1}')", dt_str1, Lalel_Result);
            OleDbCommand cmd = new OleDbCommand(sqlCreate, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        /// <summary>
        ///  OleDb数据库追加信息,信息是否正确
        /// </summary>
        /// <param name="fullFilename"></param>
        /// <param name="str_"></param>
        /// <param name="lb"></param>
        /// <param name="nums"></param>
        public static string Excel_appendInfoToFile(string fullFilename, string[] str_, string lb, string nums)
        {
            List<String> list = new List<String>();
            string dt_str = DateTime.Now.Year.ToString("0000") + "-"
                         + DateTime.Now.Month.ToString("00") + "-"
                         + DateTime.Now.Day.ToString("00");

            string dt_str1 = DateTime.Now.Year.ToString("0000") + "-"
                       + DateTime.Now.Month.ToString("00") + "-"
                       + DateTime.Now.Day.ToString("00") + " "
                       + DateTime.Now.Hour.ToString("00") + ":"
                       + DateTime.Now.Minute.ToString("00") + ":"
                       + DateTime.Now.Second.ToString("00");

            if (lb.Length != int.Parse(nums))
            {
                //  MessageBox.Show("条码信息不匹配！", "提示！");
                Excel_Write(lb + "（" + str_[1] + ")");
                return str_[1];

            }

            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + "D:" + "/Scan_Data/" + dt_str + "/" + "Temp1.xls;" + "Extended Properties=Excel 8.0;";
            using (OleDbConnection cn = new OleDbConnection(sConnectionString))
            {
                string objCmdSelect = "SELECT * FROM TestSheet";
                using (OleDbCommand cmd = new OleDbCommand(objCmdSelect, cn))
                {
                    cn.Open();//OleDb数据库打开
                    using (OleDbDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            list.Clear();
                            while (Reader.Read())//判断是否读完数据
                            {
                                string str = Reader["扫描结果"].ToString();
                                list.Add(str);//把一条条记录封装成对象，添加到list集合中
                            }
                        }
                        else
                        {
                            //  MessageBox.Show("没读到任何数据！！！", "警告！");
                            //  MessageBox.Show("扫描成功！", "提示！");
                            Excel_Write(lb);
                            return str_[2];
                        }
                    }
                    foreach (String i in list) //遍历列表中数据
                    {
                        if (i == lb)
                        { // MessageBox.Show("发现重码！", "警告！");
                            Excel_Write(lb + "（" + str_[0] + ")");
                            return str_[0];//跳出方法
                        }
                    }
                    //  MessageBox.Show("扫描成功！", "提示！");
                    Excel_Write(lb);
                    return str_[2];
                }

            }

        }

    }
    }





