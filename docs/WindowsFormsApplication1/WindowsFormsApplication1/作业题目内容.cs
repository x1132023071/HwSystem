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
    public partial class 作业题目内容 : Form
    {
        private string tm;
        private string nr;
        private string bz_time,name;
        public 作业题目内容(string tm,string nr,string bz_time,string name)
        {
            InitializeComponent();
            this.tm = tm;
            this.nr = nr;
            this.bz_time = bz_time;
            this.name = name;
        }

        private void 作业题目内容_Load(object sender, EventArgs e)
        {
            label_题目.Text = tm;
            textBox_内容.Text = nr;
            label_布置时间.Text = bz_time;
            label_教师.Text = name;
        }

    }
}
