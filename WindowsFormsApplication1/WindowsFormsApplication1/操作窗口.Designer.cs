namespace WindowsFormsApplication1
{
    partial class 操作窗口
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_name = new System.Windows.Forms.Label();
            this.button_退出 = new System.Windows.Forms.Button();
            this.button_作业 = new System.Windows.Forms.Button();
            this.button_班级 = new System.Windows.Forms.Button();
            this.listBox_作业 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_学生 = new System.Windows.Forms.Label();
            this.listBox_学生 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_时间 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_班级 = new System.Windows.Forms.Label();
            this.label_职业 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(226, 38);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "label4";
            // 
            // button_退出
            // 
            this.button_退出.Location = new System.Drawing.Point(12, 376);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(275, 88);
            this.button_退出.TabIndex = 2;
            this.button_退出.Text = "退出用户";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // button_作业
            // 
            this.button_作业.Location = new System.Drawing.Point(12, 276);
            this.button_作业.Name = "button_作业";
            this.button_作业.Size = new System.Drawing.Size(275, 89);
            this.button_作业.TabIndex = 1;
            this.button_作业.Text = "上交(布置)作业";
            this.button_作业.UseVisualStyleBackColor = true;
            this.button_作业.Click += new System.EventHandler(this.button_作业_Click);
            // 
            // button_班级
            // 
            this.button_班级.Location = new System.Drawing.Point(12, 181);
            this.button_班级.Name = "button_班级";
            this.button_班级.Size = new System.Drawing.Size(275, 89);
            this.button_班级.TabIndex = 0;
            this.button_班级.Text = "用户设置";
            this.button_班级.UseVisualStyleBackColor = true;
            this.button_班级.Click += new System.EventHandler(this.button_班级_Click);
            // 
            // listBox_作业
            // 
            this.listBox_作业.FormattingEnabled = true;
            this.listBox_作业.ItemHeight = 12;
            this.listBox_作业.Location = new System.Drawing.Point(320, 110);
            this.listBox_作业.Name = "listBox_作业";
            this.listBox_作业.Size = new System.Drawing.Size(187, 160);
            this.listBox_作业.TabIndex = 1;
            this.listBox_作业.SelectedIndexChanged += new System.EventHandler(this.listBox_作业_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作业题目：";
            // 
            // label_学生
            // 
            this.label_学生.AutoSize = true;
            this.label_学生.Location = new System.Drawing.Point(318, 287);
            this.label_学生.Name = "label_学生";
            this.label_学生.Size = new System.Drawing.Size(65, 12);
            this.label_学生.TabIndex = 2;
            this.label_学生.Text = "班级学生：";
            // 
            // listBox_学生
            // 
            this.listBox_学生.FormattingEnabled = true;
            this.listBox_学生.ItemHeight = 12;
            this.listBox_学生.Location = new System.Drawing.Point(320, 316);
            this.listBox_学生.Name = "listBox_学生";
            this.listBox_学生.Size = new System.Drawing.Size(187, 148);
            this.listBox_学生.TabIndex = 0;
            this.listBox_学生.SelectedIndexChanged += new System.EventHandler(this.listBox_学生_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_时间
            // 
            this.textBox_时间.Enabled = false;
            this.textBox_时间.Location = new System.Drawing.Point(320, 38);
            this.textBox_时间.Name = "textBox_时间";
            this.textBox_时间.Size = new System.Drawing.Size(187, 21);
            this.textBox_时间.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "时    间：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.pt_user;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(42, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 151);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "班级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "职业：";
            // 
            // label_班级
            // 
            this.label_班级.AutoSize = true;
            this.label_班级.Location = new System.Drawing.Point(228, 84);
            this.label_班级.Name = "label_班级";
            this.label_班级.Size = new System.Drawing.Size(41, 12);
            this.label_班级.TabIndex = 12;
            this.label_班级.Text = "label6";
            // 
            // label_职业
            // 
            this.label_职业.AutoSize = true;
            this.label_职业.Location = new System.Drawing.Point(228, 131);
            this.label_职业.Name = "label_职业";
            this.label_职业.Size = new System.Drawing.Size(41, 12);
            this.label_职业.TabIndex = 13;
            this.label_职业.Text = "label7";
            // 
            // 操作窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 474);
            this.Controls.Add(this.label_职业);
            this.Controls.Add(this.label_班级);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_时间);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_作业);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_班级);
            this.Controls.Add(this.label_学生);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_学生);
            this.Controls.Add(this.listBox_作业);
            this.Name = "操作窗口";
            this.Text = "操作窗口";
            this.Load += new System.EventHandler(this.操作窗口_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Button button_作业;
        private System.Windows.Forms.Button button_班级;
        private System.Windows.Forms.ListBox listBox_作业;
        private System.Windows.Forms.ListBox listBox_学生;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_学生;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_时间;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_班级;
        private System.Windows.Forms.Label label_职业;



    }
}