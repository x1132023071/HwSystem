using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked){
            mainSt mst = new mainSt();
            this.Visible = false;
            mst.ShowDialog();
            radioButton1.Checked = true;
            textBox2.Text = "";
            this.Visible = true;
            }
            else if(radioButton1.Checked){
                mainTe mte = new mainTe();
                this.Visible = false;
                mte.ShowDialog();
                radioButton1.Checked = true;
                textBox2.Text = "";
                this.Visible = true;
            }
        }

    }
}
