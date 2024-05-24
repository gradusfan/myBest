using System.IO.Ports;

namespace FanSwProject
{
    public class PortParameter
    {
        //
        // 摘要:
        //     名称
        public string tag_name;
        //
        // 摘要:
        //     端口
        public string tag_portName;
        //
        // 摘要:
        //     波特率
        public int tag_baudRate;
        //
        // 摘要:
        //     奇偶校验位
        public Parity tag_Parity;
        //
        // 摘要:
        //     数据位
        public int tag_databits;
        //
        // 摘要:
        //     停止位
        public StopBits tag_stopBits;
        //
        // 摘要:
        //     是否启用
        public bool tag_enable;
        //
        // 摘要:
        //     默认返回值
        public string tag_DefintRet;
    }
}