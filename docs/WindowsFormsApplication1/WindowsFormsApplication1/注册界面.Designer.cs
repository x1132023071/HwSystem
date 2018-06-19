namespace WindowsFormsApplication1
{
    partial class 注册界面
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
            this.button_注册 = new System.Windows.Forms.Button();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_学生 = new System.Windows.Forms.RadioButton();
            this.radioButton_教师 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button_显示 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_注册
            // 
            this.button_注册.Location = new System.Drawing.Point(43, 234);
            this.button_注册.Name = "button_注册";
            this.button_注册.Size = new System.Drawing.Size(100, 40);
            this.button_注册.TabIndex = 1;
            this.button_注册.Text = "注册";
            this.button_注册.UseVisualStyleBackColor = true;
            this.button_注册.Click += new System.EventHandler(this.button_注册_Click);
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户名.Location = new System.Drawing.Point(159, 51);
            this.textBox_用户名.Multiline = true;
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(180, 40);
            this.textBox_用户名.TabIndex = 2;
            // 
            // textBox_密码
            // 
            this.textBox_密码.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_密码.Location = new System.Drawing.Point(159, 116);
            this.textBox_密码.Multiline = true;
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(180, 40);
            this.textBox_密码.TabIndex = 3;
            // 
            // button_返回
            // 
            this.button_返回.Location = new System.Drawing.Point(239, 234);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(100, 40);
            this.button_返回.TabIndex = 7;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "密  码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_学生
            // 
            this.radioButton_学生.AutoSize = true;
            this.radioButton_学生.Location = new System.Drawing.Point(159, 186);
            this.radioButton_学生.Name = "radioButton_学生";
            this.radioButton_学生.Size = new System.Drawing.Size(47, 16);
            this.radioButton_学生.TabIndex = 10;
            this.radioButton_学生.TabStop = true;
            this.radioButton_学生.Text = "学生";
            this.radioButton_学生.UseVisualStyleBackColor = true;
            this.radioButton_学生.CheckedChanged += new System.EventHandler(this.radioButton_学生_CheckedChanged_1);
            // 
            // radioButton_教师
            // 
            this.radioButton_教师.AutoSize = true;
            this.radioButton_教师.Location = new System.Drawing.Point(267, 186);
            this.radioButton_教师.Name = "radioButton_教师";
            this.radioButton_教师.Size = new System.Drawing.Size(47, 16);
            this.radioButton_教师.TabIndex = 11;
            this.radioButton_教师.TabStop = true;
            this.radioButton_教师.Text = "教师";
            this.radioButton_教师.UseVisualStyleBackColor = true;
            this.radioButton_教师.CheckedChanged += new System.EventHandler(this.radioButton_教师_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "职  业:";
            // 
            // button_显示
            // 
            this.button_显示.Location = new System.Drawing.Point(355, 113);
            this.button_显示.Name = "button_显示";
            this.button_显示.Size = new System.Drawing.Size(43, 43);
            this.button_显示.TabIndex = 13;
            this.button_显示.Text = "显示密码";
            this.button_显示.UseVisualStyleBackColor = true;
            this.button_显示.Click += new System.EventHandler(this.button_显示_Click);
            // 
            // 注册界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 286);
            this.Controls.Add(this.button_显示);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_教师);
            this.Controls.Add(this.radioButton_学生);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.textBox_用户名);
            this.Controls.Add(this.button_注册);
            this.Name = "注册界面";
            this.Text = "注册界面";
            this.Load += new System.EventHandler(this.注册界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_注册;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_学生;
        private System.Windows.Forms.RadioButton radioButton_教师;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_显示;
    }
}