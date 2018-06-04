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
    public partial class 作业布置 : Form
    {
        private SQL sql;
        private string id, banji;
        public 作业布置(SQL sql,string id,string banji)
        {
            InitializeComponent();
            this.sql = sql;
            this.banji = banji;
            this.id = id;
        }

        private void button_清空_Click(object sender, EventArgs e)
        {
            textBox_内容.Text = "";
            textBox_题目.Text = "";
        }

        private void button_布置_Click(object sender, EventArgs e)
        {
            string subject_id="";
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            subject_id = DateTime.Now.Year.ToString() + id;
            while (true)
            {
                if (sql.sql_live("select 题目id from 布置作业 where 题目id='" + subject_id + "'"))
                {
                    subject_id =(int.Parse(subject_id)+1).ToString();
                }
                else
                    break;
            }
            work_arrange wa = new work_arrange();
            wa.work_add(sql,id,subject_id, textBox_题目.Text.Trim(), textBox_内容.Text.Trim(),banji,dt);
            MessageBox.Show("成功布置题目");
        }

        private void 作业布置_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox_题目.Text.Trim() != string.Empty && textBox_内容.Text.Trim() != string.Empty)
            {
                button_布置.Enabled = true;
            }
        }
    }
}
