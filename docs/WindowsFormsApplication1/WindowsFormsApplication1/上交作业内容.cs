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
    public partial class 上交作业内容 : Form
    {
        private SQL sq;
        private string title;
        private string name, id, tm_id,time;
        public 上交作业内容(SQL sq,string id,string name,string tm_id,string title,string time)
        {
            InitializeComponent();
            this.sq = sq;
            this.title = title;
            this.name = name;
            this.id = id;
            this.tm_id = tm_id;
            this.time = time;
        }

        private void 上交作业内容_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string select_message = "";
            this.label_title.Text = title;
            this.label_name.Text = name;
            this.label_上交时间.Text = time;
            select_message = " select 上交作业内容 from 上交作业 where 上交作业id = '" + id + "' and 题目id = '" + tm_id + "'";

            try
            {
                ds = sq.sql_select(select_message);
                textBox1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception sac)
            {
                MessageBox.Show(sac.Message);
            }
        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
