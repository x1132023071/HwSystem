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
    class student
    {
        private SqlCommand sqs;
        private string[] st;
        public student()
        {
        }
        //添加学生数据
        public void student_add(SQL sq,string id)
        {
            string add_message;
            try
            {
                add_message = "insert into 学生(id) values(@0)";
                st = new string[]{id};
                sq.sql_insert(add_message, 1, st);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //更新学生数据
        public void student_update(SQL sq,string id,string name, string banji,string sex)
        {
            try
            {
                string update_message;
                update_message = "update 学生 set 姓名=@0,班级=@1,性别=@2 where id="+id+"";
                st = new string[] {name, banji,sex};
                sq.sql_update(update_message,3,st);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void student_class_add(SQL sq, string id, string banji)
        {
            string update_message = "";
            string[] st;
            try
            {
                update_message = "update 学生 set 班级=@0 where id=" + id + "";
                st = new string[]{banji};
                sq.sql_update(update_message, 1, st);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
