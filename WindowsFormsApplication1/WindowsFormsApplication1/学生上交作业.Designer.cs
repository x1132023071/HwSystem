﻿namespace WindowsFormsApplication1
{
    partial class 学生上交作业
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
            this.label_学生姓名 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.listBox_作业 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_学生姓名
            // 
            this.label_学生姓名.AutoSize = true;
            this.label_学生姓名.Location = new System.Drawing.Point(91, 82);
            this.label_学生姓名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_学生姓名.Name = "label_学生姓名";
            this.label_学生姓名.Size = new System.Drawing.Size(75, 15);
            this.label_学生姓名.TabIndex = 0;
            this.label_学生姓名.Text = "学生姓名:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(217, 82);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "label2";
            // 
            // listBox_作业
            // 
            this.listBox_作业.FormattingEnabled = true;
            this.listBox_作业.ItemHeight = 15;
            this.listBox_作业.Location = new System.Drawing.Point(80, 124);
            this.listBox_作业.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_作业.Name = "listBox_作业";
            this.listBox_作业.Size = new System.Drawing.Size(332, 259);
            this.listBox_作业.TabIndex = 2;
            this.listBox_作业.SelectedIndexChanged += new System.EventHandler(this.listBox_作业_SelectedIndexChanged);
            // 
            // 学生上交作业
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 451);
            this.Controls.Add(this.listBox_作业);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_学生姓名);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "学生上交作业";
            this.Text = "学生作业";
            this.Load += new System.EventHandler(this.学生上交作业_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_学生姓名;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ListBox listBox_作业;
    }
}