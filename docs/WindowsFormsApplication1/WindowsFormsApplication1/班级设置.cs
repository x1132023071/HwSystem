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
    public partial class 班级设置 : Form
    {
        private SQL sql;
        private string banji;
        private string id;
        public 班级设置(SQL sql,string id)
        {
            InitializeComponent();
            this.banji = "";
            this.sql = sql;
            this.id = id;
        }

        private void 班级设置_Load(object sender, EventArgs e)
        {
            
            
        }
        //单选按钮的设置
        private void radioButton_class_one_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_class_one.Checked)
            {
                banji = radioButton_class_one.Text.Trim();
            }
        }
        private void radioButton_class_two_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_class_two.Checked)
            {
                banji = radioButton_class_two.Text.Trim();
            }
        }
        private void radioButton_class_three_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_class_three.Checked)
            {
                banji = radioButton_class_three.Text.Trim();
            }
        }

        private void radioButton_class_four_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_class_four.Checked)
            {
                banji = radioButton_class_four.Text.Trim();
            }
        }
        ////
        private void button_确定_Click(object sender, EventArgs e)
        {
            id = "2";
            student s = new student();
            s.student_class_add(sql, id, banji);
        }
        

    }
}
