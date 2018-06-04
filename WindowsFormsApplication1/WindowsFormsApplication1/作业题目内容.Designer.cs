namespace WindowsFormsApplication1
{
    partial class 作业题目内容
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_题目 = new System.Windows.Forms.Label();
            this.textBox_内容 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_布置时间 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_教师 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "作业题目：";
            // 
            // label_题目
            // 
            this.label_题目.AutoSize = true;
            this.label_题目.Location = new System.Drawing.Point(249, 22);
            this.label_题目.Name = "label_题目";
            this.label_题目.Size = new System.Drawing.Size(41, 12);
            this.label_题目.TabIndex = 1;
            this.label_题目.Text = "label2";
            // 
            // textBox_内容
            // 
            this.textBox_内容.Enabled = false;
            this.textBox_内容.Location = new System.Drawing.Point(67, 88);
            this.textBox_内容.Multiline = true;
            this.textBox_内容.Name = "textBox_内容";
            this.textBox_内容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_内容.Size = new System.Drawing.Size(341, 214);
            this.textBox_内容.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "布置时间：";
            // 
            // label_布置时间
            // 
            this.label_布置时间.AutoSize = true;
            this.label_布置时间.Location = new System.Drawing.Point(136, 62);
            this.label_布置时间.Name = "label_布置时间";
            this.label_布置时间.Size = new System.Drawing.Size(41, 12);
            this.label_布置时间.TabIndex = 4;
            this.label_布置时间.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "布置人：";
            // 
            // label_教师
            // 
            this.label_教师.AutoSize = true;
            this.label_教师.Location = new System.Drawing.Point(338, 62);
            this.label_教师.Name = "label_教师";
            this.label_教师.Size = new System.Drawing.Size(41, 12);
            this.label_教师.TabIndex = 6;
            this.label_教师.Text = "label4";
            // 
            // 作业题目内容
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 372);
            this.Controls.Add(this.label_教师);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_布置时间);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_内容);
            this.Controls.Add(this.label_题目);
            this.Controls.Add(this.label1);
            this.Name = "作业题目内容";
            this.Text = "作业题目内容";
            this.Load += new System.EventHandler(this.作业题目内容_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_题目;
        private System.Windows.Forms.TextBox textBox_内容;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_布置时间;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_教师;
    }
}