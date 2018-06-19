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
    class user
    {
        private SqlDataReader sdr;
        public user()
        {

        }
        //获取职业
        public string get_lx(SQL sq, string txt_name)
        {
            string lx="";
            string get_message;
            get_message = "select 类型 from 用户 where 用户名='" + txt_name.ToString() + "'";
            sdr = sq.sql_select_get(get_message);
            while (sdr.Read())
            {
                sdr.GetName(0);
                lx = sdr.GetValue(0).ToString();
            }
            sdr.Close();

            return lx;
        }
        //获取id
        public string  get_id(SQL sq,string txt_name)
        {
            string get_message;
            get_message = "select id from 用户 where 用户名='" + txt_name.ToString() + "'";
            sdr = sq.sql_select_get(get_message);
            string id="";
            while (sdr.Read())
            {
                sdr.GetName(0);
                id = sdr.GetValue(0).ToString();
            }
            sdr.Close();
            
            return id;
        }
        //用户存在
        public bool user_live(SQL sq, string name)
        {
            bool live=false;
            try
            {
                string live_message;
                live_message = "select 用户名 from 用户 where 用户名='"+name+"'";
                sdr = sq.sql_select_get(live_message);
                sdr.Read();
                if (sdr.HasRows)
                {
                    live = true;
                }
                else
                    live = false;
                sdr.Close();
            }
            catch (Exception eaz)
            {
                MessageBox.Show(eaz.Message);
            }
            return live;
        }
        //添加用户
        public void user_add(SQL sq,string name,string mima,string lx)
        {
            try
            {
                string add_message;
                SqlCommand cmd = new SqlCommand("select * from 用户", sq.sql_ct);
                SqlDataReader sdr = cmd.ExecuteReader();
                int x = 1;
                while (sdr.Read())
                {
                    x++;
                }
                sdr.Close();
                cmd.Dispose();
                add_message = "insert into 用户(id,用户名,密码,类型) values('"+x.ToString()+"','"+name+"','"+mima+"','"+lx+"')";
                SqlCommand sqs = new SqlCommand(add_message, sq.sql_ct);
                sqs.ExecuteNonQuery();
                if (lx.Equals("学生"))
                {
                    student s = new student();
                    s.student_add(sq, x.ToString());

                }
                else
                    if(lx=="教师")
                {
                    teacher t = new teacher();
                    t.teacher_add(sq, x.ToString());
                }
                sqs.Dispose();
                
                MessageBox.Show("注册成功");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //删除用户
        public void user_delete(SQL sq, string name,string leixing)
        {
            
        }
        //登陆用户
        public bool user_land(SQL sq, 登陆界面 form,string txt_name, string txt_mima)
        {
            //SqlCommand cmd = new SqlCommand("select * from 用户 where 用户名='" + txt_name.Trim() + "' and 密码='" + txt_mima.Trim() + "'", sq.sql_ct);
            //SqlDataReader sdr = cmd.ExecuteReader();
            string message;
            bool s = false;
            try
            {
                message ="select * from 用户 where 用户名='" + txt_name.Trim() + "' and 密码='" + txt_mima.Trim() + "'";
                sdr = sq.sql_select_get(message);
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("登录成功!", "提示");
                    s = true;
                }
                else
                    MessageBox.Show("提示：用户名或密码错误!", "警告");
                sdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return s;
        }
    }
}
