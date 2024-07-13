using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FanSwProject
{
    public partial class Form_Crama : Form
    {

        public BasicDemo.Form1 page = new BasicDemo.Form1(); 
        public Form_Crama()
        {
            InitializeComponent();
          
        }
        
       

     

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
                tabPage1.Controls.Add(page);
                page.Show();
                
            }
                

        }



       
    }
}
