namespace WindowsFormsApplication1
{
    partial class 登陆界面
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
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.button_登录 = new System.Windows.Forms.Button();
            this.label_注册账户 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_用户名 = new System.Windows.Forms.Label();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label_密码 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_用户名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_用户名.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户名.Location = new System.Drawing.Point(4, 5);
            this.textBox_用户名.Multiline = true;
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(250, 40);
            this.textBox_用户名.TabIndex = 0;
            // 
            // textBox_密码
            // 
            this.textBox_密码.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_密码.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_密码.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_密码.Location = new System.Drawing.Point(4, 4);
            this.textBox_密码.Multiline = true;
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(250, 40);
            this.textBox_密码.TabIndex = 3;
            // 
            // button_登录
            // 
            this.button_登录.BackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatAppearance.BorderSize = 0;
            this.button_登录.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_登录.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_登录.Location = new System.Drawing.Point(159, 266);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(150, 50);
            this.button_登录.TabIndex = 4;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = false;
            this.button_登录.Click += new System.EventHandler(this.button_登录_Click);
            // 
            // label_注册账户
            // 
            this.label_注册账户.AutoSize = true;
            this.label_注册账户.BackColor = System.Drawing.Color.Transparent;
            this.label_注册账户.Location = new System.Drawing.Point(483, 291);
            this.label_注册账户.Name = "label_注册账户";
            this.label_注册账户.Size = new System.Drawing.Size(53, 12);
            this.label_注册账户.TabIndex = 6;
            this.label_注册账户.Text = "注册账户";
            this.label_注册账户.Click += new System.EventHandler(this.label_注册账户_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 7;
            // 
            // label_用户名
            // 
            this.label_用户名.BackColor = System.Drawing.Color.Transparent;
            this.label_用户名.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_用户名.Location = new System.Drawing.Point(122, 107);
            this.label_用户名.Name = "label_用户名";
            this.label_用户名.Size = new System.Drawing.Size(100, 40);
            this.label_用户名.TabIndex = 9;
            this.label_用户名.Text = "用户名:";
            this.label_用户名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_退出
            // 
            this.button_退出.BackColor = System.Drawing.Color.Transparent;
            this.button_退出.FlatAppearance.BorderSize = 0;
            this.button_退出.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_退出.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_退出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_退出.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_退出.Location = new System.Drawing.Point(315, 266);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(150, 50);
            this.button_退出.TabIndex = 10;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = false;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label_密码
            // 
            this.label_密码.BackColor = System.Drawing.Color.Transparent;
            this.label_密码.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_密码.Location = new System.Drawing.Point(122, 187);
            this.label_密码.Name = "label_密码";
            this.label_密码.Size = new System.Drawing.Size(100, 40);
            this.label_密码.TabIndex = 11;
            this.label_密码.Text = "密  码:";
            this.label_密码.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("黑体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(243, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "作业提交系统";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_用户名);
            this.panel1.Location = new System.Drawing.Point(277, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 50);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_密码);
            this.panel2.Location = new System.Drawing.Point(277, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 49);
            this.panel2.TabIndex = 14;
            // 
            // 登陆界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.登陆界面1;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_密码);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.label_用户名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_注册账户);
            this.Controls.Add(this.button_登录);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "登陆界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.登陆界面_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.登陆界面_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.登陆界面_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.登陆界面_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Label label_注册账户;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_用户名;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Label label_密码;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}