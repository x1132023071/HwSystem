namespace WindowsFormsApplication1
{
    partial class 上交作业内容
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
            this.label2 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_上交时间 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "提交者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "作业题目：";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(448, 34);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "label3";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(280, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(41, 12);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 241);
            this.textBox1.TabIndex = 4;
            // 
            // button_返回
            // 
            this.button_返回.Location = new System.Drawing.Point(246, 312);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(75, 23);
            this.button_返回.TabIndex = 5;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "上交时间：";
            // 
            // label_上交时间
            // 
            this.label_上交时间.AutoSize = true;
            this.label_上交时间.Location = new System.Drawing.Point(180, 31);
            this.label_上交时间.Name = "label_上交时间";
            this.label_上交时间.Size = new System.Drawing.Size(41, 12);
            this.label_上交时间.TabIndex = 7;
            this.label_上交时间.Text = "label4";
            // 
            // 上交作业内容
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.label_上交时间);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "上交作业内容";
            this.Text = "上交作业内容";
            this.Load += new System.EventHandler(this.上交作业内容_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_上交时间;
    }
}