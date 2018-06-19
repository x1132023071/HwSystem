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
    class work_arrange
    {
        private SqlCommand cmd;
        private string[] st;
        private SqlDataReader sdr;
        public work_arrange()
        { 
        
        }
        //获取作业数量
        public string get_work(SQL sq)
        {
            string ms;
            string x="";
            try
            {
                ms = "布置作业";
                x = sq.get_sum(ms);
            }
            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }

            return x;
        }
        //添加布置作业
        public void work_add(SQL sq, string work_id, string subject_id, string work_subject, string work_content,string banji,DateTime dt)
        {
            string add_message;
            try
            {
                add_message = "insert into 布置作业(布置作业id,题目id,布置作业题目,布置作业内容,作业班级,布置作业时间) values(@0,@1,@2,@3,@4,@5)";
                st = new string[] { work_id, subject_id, work_subject, work_content,banji};
                sq.sql_insert(add_message, 6, 6, st, dt);
            }
            catch(Exception e)
            {
               MessageBox.Show(e.Message);
            }
        }
    }
}
