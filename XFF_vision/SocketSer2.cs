using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI;

namespace XFF_Vision
{
    public class SocketSer2
    {
        string IP;
        string sockerend = String.Empty;
        public string Sockerend
        {
            get { return sockerend; }
            set { sockerend = value; }
        }

        /// <summary>
        /// 信息委托UI
        /// </summary>
        public static event Func<string, string> UIINFO;

        public static void INFO(string info)
        {
            UIINFO.Invoke(info);
        }
        // public static string sockerend;
        public void sock()
        {
            //当点击开始监听的时候，在服务器端创建一个负责监听IP地址跟端口号的Socket  
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Any:提供一个 IP 地址，指示服务器应侦听所有网络接口上的客户端活动。此字段为只读。  
           
            //创建端口号对象；将txtPort.Text控件的值设为服务端的端口号  
            IPEndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32(9004));
            //监听  
            socketWatch.Bind(point);
            socketWatch.Listen(20);//连接队列的最大长度 ;即：一个时间点内最大能让几个客户端连接进来，超过长度就进行排队  
            //等待客户端连接;Accept()这个方法能接收客户端的连接，并为新连接创建一个负责通信的Socket  
            Thread th = new Thread(Listen); //被线程执行的方法如果有参数的话,参数必须是object类型  
                                            // Control.CheckForIllegalCrossThreadCalls = false; //因为.net不允许跨线程访问的，所以这里取消跨线程的检查。.net不检查是否有跨线程访问了，所有就不会报： “从不是创建控件“txtLog”的线程访问它” 这个错误了，从而实现了跨线程访问  
            th.IsBackground = true; //将th这个线程设为后台线程。  
            //Start(object parameter); parameter:一个对象，包含线程执行的方法要使用的数据,即线程执行Listen方法，Listen的参数  
            th.Start(socketWatch);  //这个括号里的参数其实是Listen()方法的参数。因为Thread th = new Thread(Listen)这个括号里
        }
        void Listen(object o) //这里为什么不直接传递Socket类型的参数呢？ 原因是：被线程执行的方法如果有参数的话,参数必须是object类型  
        {
            Socket socketWatch = o as Socket;
            //为什么这里要有个while循环？因为当一个人连接进来的时候创建了与之通信的Socket后就程序就会往下执行了，就不会再回来为第二个人的连接创建负责通信的Socket了。（应该是每个人(每个客户端)创建一个与之通信的Socket）所以要写在循环里。  

            while (true)     //等待客户端连接;Accept()这个方法能接收客户端的连接，并为新连接创建一个负责通信的Socket  
            {
                Socket socketSend = socketWatch.Accept();
                dic.Add(socketSend.RemoteEndPoint.ToString(), socketSend); //（根据客户端的IP地址和端口号找负责通信的Socket，每个客户端对应一个负责通信的Socket），ip地址及端口号作为键，将负责通信的Socket作为值填充到dic键值对中。  
                                                                           //我们通过负责通信的这个socketSend对象的一个RemoteEndPoint属性，能够拿到远程连过来的客户端的Ip地址跟端口号        
                IP = socketSend.RemoteEndPoint.ToString();
                INFO(socketSend.RemoteEndPoint.ToString() + "已连接");
                string[] S = socketSend.RemoteEndPoint.ToString().Split(new char[] { ':' });
                //客户端连接成功后，服务器应该接收客户端发来的消息。   
                Thread getdata = new Thread(GetData);
                getdata.IsBackground = true;
                getdata.Start(socketSend);
            }
        }
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        void GetData(object o)
        {
            while (true)
            {
                if (0 == 0)
                {
                    Socket socketSend = o as Socket;
                    //GetData1( o);
                    try
                    {
                        //将客户端发过来的数据先放到一个字节数组里面去  
                        byte[] buffer = new byte[1024 * 1024 * 2]; //创建一个字节数组，字节数组的长度为2M  
                        int r = socketSend.Receive(buffer);
                        try
                        {
                            if (r == 0) //如果接收到的有效字节数为0 说明客户端已经关闭了。这时候就跳出循环了。  
                            {
                                dic.Remove(socketSend.RemoteEndPoint.ToString());
                                return;
                                //只有客户端给用户发消息，不可能是发0个长度的字节。即便发空消息，空消息也是有过个长度的。所有接收到的有效字节长度为0就代表客户端已经关闭了  
                            }
                        }
                        catch (Exception ex)
                        {
                            dic.Remove(socketSend.RemoteEndPoint.ToString());
                        }
                        //将buffer这个字节数组里面的数据按照UTF8的编码，解码成我们能够读懂的的string类型，因为buffer这个数组的实际存储数据的长度是r个 ，所以从索引为1的字节开始解码，总共解码r个字节长度。  
                        string str = Encoding.UTF8.GetString(buffer, 0, r);
                        //(socketSend.RemoteEndPoint.ToString() + " 读取信息  :" + str);
                        if (str.ToUpper().Contains("GETPOS"))
                            sockerend = str;
                        string str1 = socketSend.RemoteEndPoint.ToString();
                        string[] Str = socketSend.RemoteEndPoint.ToString().Split(new char[] { ':' });
                        //pc(dic[socketSend.RemoteEndPoint.ToString()] as Socket, str);
                        //byte[] strByte = Encoding.Default.GetBytes("nihao"); //将信息转换成二进制字节数组  
                        ////string getIp = comboBox1.SelectedItem as string; //comboBox存储的是客户端的（ip+端口号）  
                        //Socket socketSend1 = dic[socketSend.RemoteEndPoint.ToString()] as Socket; //根据这个（ip及端口号）去dic键值对中找对应 赋值与客户端通信的Socket【每个客户端都有一个负责与之通信的Socket】  
                        //socketSend1.Send(strByte); //将信息发送到客户端  
                    }
                    catch (Exception ce)
                    {
                    }
                }
            }
        }
        /// <summary>
        /// 根接收到的内容给客户端发送数据
        /// </summary>
        /// <param name="socketSend"></param>客户端
        /// <param name="str"></param>接收到的内容
        public void pc(Socket socketSend, string str)
        {
            try
            {
                //if (ArgsSingle.Instance.Args.jcw2标示)
                //{
                //    computevalue(ArgsSingle.Instance.Args.Axis2_ShowComputeValueInfo.zmax);
                //    computevalue(ArgsSingle.Instance.Args.Axis2_ShowComputeValueInfo.hmax);
                //    computevalue(ArgsSingle.Instance.Args.Axis2_ShowComputeValueInfo.zavg);
                //    computevalue(ArgsSingle.Instance.Args.Axis2_ShowComputeValueInfo.havg);
                //}
                //if (ArgsSingle.Instance.Args.jcw1标示)
                //{
                //    computevalue(ArgsSingle.Instance.Args.Axis1_ShowComputeValueInfo.zmax);
                //    computevalue(ArgsSingle.Instance.Args.Axis1_ShowComputeValueInfo.hmax);
                //    computevalue(ArgsSingle.Instance.Args.Axis1_ShowComputeValueInfo.zavg);
                //    computevalue(ArgsSingle.Instance.Args.Axis1_ShowComputeValueInfo.havg);
                //}
                //根据接收到的内容发送相应的数据

                byte[] strByte = Encoding.Default.GetBytes("nihao"); //将信息转换成二进制字节数组  
                                                                     //string getIp = comboBox1.SelectedItem as string; //comboBox存储的是客户端的（ip+端口号）  
                                                                     // Socket socketSend1 = dic[socketSend.RemoteEndPoint.ToString()] as Socket; //根据这个（ip及端口号）去dic键值对中找对应 赋值与客户端通信的Socket【每个客户端都有一个负责与之通信的Socket】  
                socketSend.Send(strByte); //将信息发送到客户端  
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 给客户端发送数据
        /// </summary>
        /// <param name="str"></param>
        public void pc(string ip, string str)
        {
            try
            {
                string IP = string.Empty;
                byte[] strByte = Encoding.Default.GetBytes(str); //将信息转换成二进制字节数组      
                foreach (var item in dic)
                {
                    if (item.Key.Split(':')[0] == ip)
                    {
                        IP = item.Key;
                    }
                }
                // Socket socketSend1 = dic[socketSend.RemoteEndPoint.ToString()] as Socket; //根据这个（ip及端口号）去dic键值对中找对应 赋值与客户端通信的Socket【每个客户端都有一个负责与之通信的Socket】  
                (dic[IP] as Socket).Send(strByte); //将信息发送到客户端  
            }
            catch (Exception)
            {
            }

        }

        public void pc()
        {
            //  ArgsSingle.Instance.Args.peizhi = "222";
        }
        private string computevalue(double value)
        {
            return (Math.Floor(value * 1000) / 1000).ToString();
        }

    }
}
