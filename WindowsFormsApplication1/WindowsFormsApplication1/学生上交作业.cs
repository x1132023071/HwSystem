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
    public partial class 学生上交作业 : Form
    {
        private DataSet ds,dg;
        private string name,id;
        private SQL sq;
        private string[] st,ss;
        private string zhiye;
        
        public 学生上交作业(SQL sq,string name,DataSet ds,string _zhiye)
        {
            InitializeComponent();
            this.ds = ds;
            this.name = name;
            this.sq = sq;
            zhiye = _zhiye;
        }

        private void 学生上交作业_Load(object sender, EventArgs e)
        {
            this.label_name.Text = name;
            string select_message;
            id = sq.sql_select("select id from 学生 where 姓名='" + name + "'", "id");
            listBox_作业.Items.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ss = new string[ds.Tables[0].Rows.Count];
                st = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    select_message = "select 布置作业题目,题目id from 布置作业 where 题目id=" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "";
                    dg = sq.sql_select(select_message);
                    ss[i] = dg.Tables[0].Rows[0]["布置作业题目"].ToString();
                    st[i] = dg.Tables[0].Rows[0]["题目id"].ToString();

                    listBox_作业.Items.Add(dg.Tables[0].Rows[0]["布置作业题目"].ToString());
                    //MessageBox.Show(dg.Tables[0].Rows[0]["题目id"].ToString());
                }
            }
            //MessageBox.Show(dg.Tables[0].Rows.Count.ToString());
        }

        private void listBox_作业_SelectedIndexChanged(object sender, EventArgs e)
        {
            上交作业内容 f;
            string tm_id="";
            string time = "";
            //MessageBox.Show(dg.Tables[0].Rows.Count.ToString());
            if (listBox_作业.SelectedItem!=null)
            {
                for(int i=0;i<ss.Length;i++)
                {
                    if(ss[i]==listBox_作业.SelectedItem.ToString())
                    {
                        tm_id = st[i];
                        time = ds.Tables[0].Rows[i]["上交时间"].ToString();
                    }
                }
                //MessageBox.Show(tm_id+id+name);
                f = new 上交作业内容(sq,id,name,tm_id,listBox_作业.SelectedItem.ToString(),time,zhiye);
                f.ShowDialog();
            
            }
            学生上交作业_Load(sender, e);
          
        }
    }
}
