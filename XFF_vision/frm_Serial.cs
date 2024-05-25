using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using System.IO.Ports;

namespace XFF_Vision
{
    
    public partial class frm_Serial : Form
    {

        private static frm_Serial _instance;
      
        public delegate void setvalHandler();
        setvalHandler setval;
        string name1 = "", name2= "";
        SerialPort sp1, sp2 = new SerialPort();
        public frm_Serial(List<SerialPort> sp, List<string> name, setvalHandler setval)
        {
            InitializeComponent();
            this.sp1 = sp[0];
            this.name1 = name[0];
            this.sp2 = sp[1];
            this.name2 = name[1];
            this.setval = setval;
        }

        private void dmButtonCloseLight1_Click(object sender, EventArgs e)
        {
            this.Hide();
            setval();
        }

        private void comPort1_Load(object sender, EventArgs e)
        {

        }

        private void frm_serial_Load(object sender, EventArgs e)
        {
            comPort1.Ini(sp1, name1);
            comPort2.Ini(sp2, name2);
        }
         private void frm_serial_FormClosing(object sender, FormClosingEventArgs e)
        {
            setval();
        }
    }
}
