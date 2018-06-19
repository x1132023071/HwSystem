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
    public partial class 操作窗口 : Form
    {
        private SQL sql;
        private string id;
        private DataSet ds;
        private string lx;
        private string banji;
        private string name;

        public 操作窗口(SQL sql, string id, string lx)
        {
            InitializeComponent();
            this.sql = sql;
            this.id = id;
            this.lx = lx;
        }
        public 操作窗口()
        {
            InitializeComponent();
        }

        private void 操作窗口_Load(object sender, EventArgs e)
        {
            int i;
            string get_banji = "";
            string get_name = "";
            get_banji = "select 班级 from "+lx+" where id = '"+id+"'";
            get_name = "select 姓名 from "+lx+" where id = '" + id + "'";
            banji = sql.sql_select(get_banji, "班级");
            name = sql.sql_select(get_name, "姓名");
            label_name.Text = name;
            this.label_班级.Text = banji;
            this.label_职业.Text = lx;
            listBox_学生.Items.Clear();
            listBox_作业.Items.Clear();
            string select_message;
            //
            if (lx == "学生")
            {
                button_作业.Text = "提交作业";
                label_学生.Text = "同班同学";

            }
            else
                if (lx == "教师")
                {
                    button_作业.Text = "布置作业";
                    label_学生.Text = "班级学生";
                }
            //
            if (banji.Length < 3)
            {
               // MessageBox.Show("请先设置你的班级");
            }
            else
            {
                try
                {
                    select_message = "select 布置作业题目 from 布置作业 where 作业班级='" + banji + "'";
                    ds = sql.sql_select(select_message);
                    for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        listBox_作业.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    }

                    select_message = "select 姓名 from 学生 where 班级=N'" + banji + "'";
                    ds = sql.sql_select(select_message);
                    for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        listBox_学生.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    }
                }
                catch (Exception zxa)
                {
                    MessageBox.Show(zxa.Message);
                }
            }
        }

        private void button_班级_Click(object sender, EventArgs e)
        {
            用户设置 set = new 用户设置(sql,id,name,lx);
            set.ShowDialog();
            操作窗口_Load(sender, e);
        }

        private void button_作业_Click(object sender, EventArgs e)
        {
            作业上交 f = new 作业上交(sql,id,banji);
            作业布置 b = new 作业布置(sql,id,banji);
            if (button_作业.Text == "布置作业")
            {
                b.ShowDialog();
            }
            else
                if (button_作业.Text == "提交作业")
                {
                    f.ShowDialog();
                }
            操作窗口_Load(sender, e);
        }
        //退出界面
        private void button_退出_Click(object sender, EventArgs e)
        {
            退出界面 tc = new 退出界面(this);
            tc.ShowDialog();
        }

        private void listBox_作业_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_message;
            作业题目内容 f;
            try
            {
                if (listBox_作业.SelectedItem!= null)
                {
                    select_message = "select 布置作业内容,布置作业时间,布置作业id from 布置作业 where 作业班级='" + banji + "' and 布置作业题目='" + listBox_作业.SelectedItem.ToString() + "'";
                    ds = sql.sql_select(select_message);
                    select_message = "select 姓名 from 教师 where id = '" + ds.Tables[0].Rows[0]["布置作业id"].ToString() + "'";
                    
                    f = new 作业题目内容(listBox_作业.SelectedItem.ToString(), ds.Tables[0].Rows[0].ItemArray[0].ToString(),ds.Tables[0].Rows[0]["布置作业时间"].ToString(),sql.sql_select(select_message,"姓名"));
                    f.ShowDialog();
                }
                操作窗口_Load(sender, e);
            }
            catch(Exception xz)
                {
                    MessageBox.Show(xz.Message);
                }
        }

        private void listBox_学生_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_message;
            //DataSet dg;
            学生上交作业 sj;
            string st_id;
            try
            {
                if (lx == "教师")
                {
                    if (listBox_学生.SelectedItem != null)
                    {
                        select_message = "select id from 学生 where 姓名='" + listBox_学生.SelectedItem.ToString() + "'";
                        st_id = sql.sql_select(select_message, "id");
                        select_message = "select 题目id,上交时间 from 上交作业 where 上交作业id=" + st_id + "";
                        ds = sql.sql_select(select_message);
                        sj = new 学生上交作业(sql, listBox_学生.SelectedItem.ToString(), ds);
                        sj.ShowDialog();
                        listBox_学生.ClearSelected();
                    }
                    操作窗口_Load(sender, e);
                }
                else
                {
                    if (listBox_学生.SelectedItem != null)
                    {
                        if (listBox_学生.SelectedItem.ToString().Equals(name))
                        {
                            select_message = "select id from 学生 where 姓名='" + listBox_学生.SelectedItem.ToString() + "'";
                            st_id = sql.sql_select(select_message, "id");
                            select_message = "select 题目id,上交时间 from 上交作业 where 上交作业id=" + st_id + "";
                            ds = sql.sql_select(select_message);
                            sj = new 学生上交作业(sql, listBox_学生.SelectedItem.ToString(), ds);
                            sj.ShowDialog();
                            listBox_学生.ClearSelected();
                        }
                    }
                    操作窗口_Load(sender, e);
                }
            }
            catch (Exception zxc)
            {
                MessageBox.Show(zxc.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            textBox_时间.Text = dt.ToString();
            操作窗口_Load(sender, e);
        }

    }
}
