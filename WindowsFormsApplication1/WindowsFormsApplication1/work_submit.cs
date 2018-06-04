using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class work_submit
    {
        private SqlCommand sc;
        private SqlDataReader sdr;
        private string[] st;
        public work_submit()
        { }
        //获取作业数量
        public string get_work(SQL sq)
        {
            string x="";
            try
            {
                x = "上交作业";
                x = sq.get_sum(x);
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
            return x;
        }
        //添加提交作业
        public void work_add(SQL sq, string work_id, string subject_id, string work_content,DateTime dt)
        {
            string add_message="";
            try
            {
                add_message = "insert into 上交作业(上交作业id,题目id,上交作业内容,上交时间) values(@0,@1,@2,@3)";
                st = new string[]{work_id,subject_id,work_content};
                sq.sql_insert(add_message, 4, 4, st, dt);
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
