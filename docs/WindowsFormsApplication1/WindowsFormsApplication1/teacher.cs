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
    class teacher
    {
        private SqlCommand sqs;
        private string[] st;
        public teacher()
        {
        }
        //教师添加
        public void teacher_add(SQL sq,string id)
        {
            string add_message;
            try
            {
                add_message = "insert into 教师(id) values(@0)";
                st = new string[] { id};
                sq.sql_insert(add_message,1,st);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //更新教师数据
        public void teacher_update(SQL sq, string id, string name, string banji,string sex)
        {
            string update_message;
            try
            {
                update_message = "update 教师 set 姓名=@0,班级=@1,性别=@2 where id="+id+"";
                st = new string[] { name, banji,sex };
                sq.sql_update(update_message, 3, st);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
