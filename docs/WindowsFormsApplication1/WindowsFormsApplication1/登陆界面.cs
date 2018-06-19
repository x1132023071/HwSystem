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
    public partial class 登陆界面 : Form
    {
        Point mouse;
        bool leftclick;
        private SQL sql;
        public 登陆界面()
        {
            InitializeComponent();
        }
        //载入数据库
        private void 登陆界面_Load(object sender, EventArgs e)
        {
            sql = new SQL();
            sql.sql_start();
        }
        //退出程序
        private void button_退出_Click(object sender, EventArgs e)
        {
            sql.sql_end();
            System.Environment.Exit(0);
        }
        ////
        //设置窗口的移动
        private void 登陆界面_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse = new Point(-e.X, -e.Y); 
                leftclick = true;                
            }
        }

        private void 登陆界面_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftclick)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouse.X, mouse.Y);  
                Location = mouseSet;
            }
        }

        private void 登陆界面_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftclick)
                leftclick = false;

        }
        ////
        //注册按钮
        private void label_注册账户_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            注册界面 f = new 注册界面(sql);
            f.ShowDialog();
            this.Visible = true;
        }
        public bool live(string lx,string id)
        {
            string message="";

            if (lx == "学生")
            {
                message = "select * from 学生 where id='" + id + "'";
                
            }
            else
                if (lx == "教师")
                {
                    message = "select * from 教师 where id ='" + id + "'";
                }

                    return sql.sql_live(message); ;
        }
        public void add(string lx, string id)
        {
            string message = "";
            string[] st;
            if (lx == "学生")
            {
                message = "insert into 学生(id,姓名,类型) values(@0,@1,@2)";

            }
            else
                if (lx == "教师")
                {
                    message = "insert into 教师(id,姓名,类型) values(@0,@1,@2)";
                }
            st = new string[] { id, id, lx };
            sql.sql_insert(message,3,st);
        }
        //登陆用户
        private void button_登录_Click(object sender, EventArgs e)
        { 
            user us = new user();
            try
            {
                if (textBox_用户名.Text.Length <= 0)
                {
                    MessageBox.Show("请输入用户名");
                }
                else
                    if (us.user_live(sql, textBox_用户名.Text.Trim()) == false)
                    {
                        MessageBox.Show("该用户不存在");
                    }
                    else
                        if(us.user_land(sql, this, textBox_用户名.Text.Trim(), textBox_密码.Text.Trim()))
                    {
                        if (!this.live(us.get_lx(sql, textBox_用户名.Text.Trim()), us.get_id(sql, textBox_用户名.Text.Trim())))
                        {
                            add(us.get_lx(sql, textBox_用户名.Text.Trim()), us.get_id(sql, textBox_用户名.Text.Trim()));
                        }
                        this.Visible = false;
                        操作窗口 f = new 操作窗口(sql,us.get_id(sql,textBox_用户名.Text.Trim()),us.get_lx(sql,textBox_用户名.Text.Trim()));
                        f.ShowDialog();
                    }
            }
            catch (Exception cv)
            {
                MessageBox.Show(cv.Message);
            }
        }

       
    }
}
