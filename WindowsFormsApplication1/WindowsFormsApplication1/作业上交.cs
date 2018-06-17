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
            string ss="";
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
