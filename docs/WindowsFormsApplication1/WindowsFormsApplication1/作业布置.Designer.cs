namespace WindowsFormsApplication1
{
    partial class 作业布置
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_题目 = new System.Windows.Forms.TextBox();
            this.textBox_内容 = new System.Windows.Forms.TextBox();
            this.button_布置 = new System.Windows.Forms.Button();
            this.button_清空 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "内容";
            // 
            // textBox_题目
            // 
            this.textBox_题目.Location = new System.Drawing.Point(111, 49);
            this.textBox_题目.Name = "textBox_题目";
            this.textBox_题目.Size = new System.Drawing.Size(315, 21);
            this.textBox_题目.TabIndex = 2;
            // 
            // textBox_内容
            // 
            this.textBox_内容.Location = new System.Drawing.Point(111, 121);
            this.textBox_内容.Multiline = true;
            this.textBox_内容.Name = "textBox_内容";
            this.textBox_内容.Size = new System.Drawing.Size(315, 98);
            this.textBox_内容.TabIndex = 3;
            // 
            // button_布置
            // 
            this.button_布置.Enabled = false;
            this.button_布置.Location = new System.Drawing.Point(42, 254);
            this.button_布置.Name = "button_布置";
            this.button_布置.Size = new System.Drawing.Size(120, 40);
            this.button_布置.TabIndex = 4;
            this.button_布置.Text = "布置";
            this.button_布置.UseVisualStyleBackColor = true;
            this.button_布置.Click += new System.EventHandler(this.button_布置_Click);
            // 
            // button_清空
            // 
            this.button_清空.Location = new System.Drawing.Point(279, 254);
            this.button_清空.Name = "button_清空";
            this.button_清空.Size = new System.Drawing.Size(120, 40);
            this.button_清空.TabIndex = 5;
            this.button_清空.Text = "清空";
            this.button_清空.UseVisualStyleBackColor = true;
            this.button_清空.Click += new System.EventHandler(this.button_清空_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 作业布置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 352);
            this.Controls.Add(this.button_清空);
            this.Controls.Add(this.button_布置);
            this.Controls.Add(this.textBox_内容);
            this.Controls.Add(this.textBox_题目);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "作业布置";
            this.Text = "作业布置";
            this.Load += new System.EventHandler(this.作业布置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_题目;
        private System.Windows.Forms.TextBox textBox_内容;
        private System.Windows.Forms.Button button_布置;
        private System.Windows.Forms.Button button_清空;
        private System.Windows.Forms.Timer timer1;
    }
}