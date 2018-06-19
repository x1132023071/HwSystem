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
