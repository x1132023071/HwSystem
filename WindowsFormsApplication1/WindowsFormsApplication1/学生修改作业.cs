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
    public partial class 用户设置 : Form
    {
        private string name;
        private string lx;
        private SQL sq;
        private string id;
        public 用户设置(SQL sq,string id,string name,string lx)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.lx = lx;
            this.sq = sq;
        }

        private void 用户设置_Load(object sender, EventArgs e)
        {
            comboBox_性别.Items.Add("男");
            comboBox_性别.Items.Add("女");
            button_编辑.FlatStyle = FlatStyle.Flat;
            button_编辑.FlatAppearance.BorderColor = this.BackColor;
            
            comboBox_性别.Text = sq.sql_select("select 性别 from "+lx+" where id = '"+id+"'","性别");
            comboBox_班级.Text = sq.sql_select("select 班级 from " + lx + " where id = '" + id + "'", "班级");
            textBox_name.Text = name;
        }

        private void button_编辑_Click(object sender, EventArgs e)
        {
            textBox_name.Enabled = true;
            comboBox_性别.Enabled = true;
            comboBox_班级.Enabled = true;
        }

        private void button_完成_Click(object sender, EventArgs e)
        {
            textBox_name.Enabled = false;
            comboBox_性别.Enabled = false;
            comboBox_班级.Enabled = false;
            teacher tc;
            student sd;
            
                if (lx.Equals("教师"))
                {
                    tc = new teacher();
                    if (textBox_name.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("用户名不能空");
                    }
                    else
                        if (textBox_name.Text != name)
                        {
                            if (sq.sql_live("select 姓名 from 教师 where 姓名='" + textBox_name.Text.Trim().ToString() + "'"))
                            {
                                MessageBox.Show("该用户名已经存在，请重新输入");
                            }
                        }
                        else
                        {
                            tc.teacher_update(sq, id, textBox_name.Text.Trim(), comboBox_班级.Text, comboBox_性别.Text);
                            MessageBox.Show("修改信息成功");
                        }
                }
                else
                    if (lx.Equals("学生"))
                    {
                        sd = new student();
                        tc = new teacher();
                        if (textBox_name.Text.Trim() == string.Empty)
                        {
                            MessageBox.Show("用户名不能空");
                        }
                        else
                            if (textBox_name.Text != name)
                            {
                                if (sq.sql_live("select 姓名 from 学生 where 姓名='" + textBox_name.Text.Trim().ToString() + "'"))
                                {
                                    MessageBox.Show("该用户名已经存在，请重新输入");
                                }
                            }
                            else
                            {
                                sd.student_update(sq, id, textBox_name.Text.Trim(), comboBox_班级.Text, comboBox_性别.Text);
                                MessageBox.Show("修改信息成功");
                            }
                    }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class 注册界面 : Form
    {
        private SQL sql;
        private string lx;
        public 注册界面(SQL sql)
        {
            InitializeComponent();
            this.sql = sql;
            this.radioButton_学生.Checked = false;
            this.radioButton_教师.Checked = false;
            this.lx="";
        }
        //返回按钮点击事件
        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //注册按钮点击事件
        private void button_注册_Click(object sender, EventArgs e)
        {
            user us = new user();
            if (textBox_用户名.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空");
            }
            else
                if (sql.sql_live("select 用户名 from 用户 where 用户名='" + textBox_用户名.Text.Trim() + "'"))
            {
                MessageBox.Show("该用户已存在,请重新输入.");
            }
            else
                if (textBox_用户名.Text.Trim().Length > 20)
            {
                MessageBox.Show("您输入的用户名过长，请输入长度20一下的用户");
            }
                    else
                    if (textBox_密码.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("密码不能为空");
                    }
                    else
                        if (textBox_密码.Text.Trim().Length > 16)
                        {
                            MessageBox.Show("请输入长度为16以下的密码");
                        }
                        else
                            if (lx!= "学生" && lx != "教师")
                            {
                                MessageBox.Show("请选择您要注册用户的类型");
                            }
                            else
                            {
                                us.user_add(sql, textBox_用户名.Text.Trim(), textBox_密码.Text.Trim(), lx);
                                MessageBox.Show("注册成功");
                            }

        }

        //单选按钮功能的设置
        private void radioButton_教师_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_教师.Checked)
            {
                lx = "教师";
            }
        }

        private void radioButton_学生_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_学生.Checked)
            {
                lx = "学生";
            }
        }
        ////
        private void 注册界面_Load(object sender, EventArgs e)
        {

        }

        private void button_显示_Click(object sender, EventArgs e)
        {
            if (this.textBox_密码.PasswordChar == '*')
            {
                this.textBox_密码.PasswordChar = new char();
                button_显示.Text = "隐藏密码";
            }
            else
            {
                this.textBox_密码.PasswordChar = '*';
                button_显示.Text = "显示密码";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    
    public partial class 作业上交 : Form
    {
        private string filename;
        private SQL sq;
        private DataSet ds;
        private string st_id, banji;
        private string tc_id;

        public 作业上交(SQL  sq,string st_id,string banji)
        {
            InitializeComponent();
            this.sq = sq;
            this.st_id = st_id;
            this.banji = banji;
        }

        private void 作业上交_Load(object sender, EventArgs e)
        {
            //tc_id = sq.sql_select("select id from 教师 where 班级='" + banji + "'", "id");
            ds = sq.sql_select("select 布置作业题目,布置作业内容,题目id from 布置作业 where 作业班级 = '"+banji+"'");
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
                comboBox_作业题目.Items.Add(ds.Tables[0].Rows[i]["布置作业题目"].ToString());

        }

        private void button_打开作业_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;
            opf.Title = "选择您的作业文件";
            opf.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = opf.FileName;
                StreamReader sr = new StreamReader(filename);
                textBox_自己作业.Text = sr.ReadToEnd();
                sr.Close();

            }
        }

        private void button_保存_Click(object sender, EventArgs e)
        {
             OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;
            opf.Title = "选择您的作业文件";
            opf.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = opf.FileName;
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(textBox_自己作业.Text);
                sw.Close();
            }
        }

        private void comboBox_作业题目_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_作业题目.SelectedItem.ToString() != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
                {
                    if (ds.Tables[0].Rows[i]["布置作业题目"].ToString() == comboBox_作业题目.SelectedItem.ToString())
                    {
                        textBox_作业内容.Text = ds.Tables[0].Rows[i]["布置作业内容"].ToString();
                    }
                }
            }
        }

        private void button_提交作业_Click(object sender, EventArgs e)
        {
            work_submit ws = new work_submit();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string ss = "";
            try
            {
                ss = comboBox_作业题目.Text.Trim();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ss == ds.Tables[0].Rows[i]["布置作业题目"].ToString())
                    {
                        ss = ds.Tables[0].Rows[i]["题目id"].ToString();
                    }
                }
                if (ws.work_st_alive(sq, st_id, ss))
                {
                    DialogResult result = MessageBox.Show("已存在该作业是否修改", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ws.work_update(sq, st_id, ss, textBox_自己作业.Text.Trim(), dt);
                        MessageBox.Show("修改成功");
                    }
                    else
                    {

                    }
                }
                else
                {
                    ws.work_add(sq, st_id, ss, textBox_自己作业.Text.Trim(), dt);
                    MessageBox.Show("提交成功");
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox_作业题目.Text.Trim() != string.Empty && textBox_作业内容.Text.Trim() != string.Empty)
            {
                button_提交作业.Enabled = true;
            }
        }
    }
}
