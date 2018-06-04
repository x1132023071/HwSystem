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
