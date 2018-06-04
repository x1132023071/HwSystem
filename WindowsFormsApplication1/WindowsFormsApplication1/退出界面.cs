using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class 退出界面 : Form
    {
        private 操作窗口 f;
        public 退出界面(操作窗口 c)
        {
            InitializeComponent();
            this.f = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Close();
            登陆界面 g = new 登陆界面();
            g.Show();
        }
    }
}
