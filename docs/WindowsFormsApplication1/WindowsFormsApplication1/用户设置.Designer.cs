namespace WindowsFormsApplication1
{
    partial class 用户设置
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
            this.button_完成 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_性别 = new System.Windows.Forms.ComboBox();
            this.comboBox_班级 = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_编辑 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_完成
            // 
            this.button_完成.Location = new System.Drawing.Point(61, 318);
            this.button_完成.Name = "button_完成";
            this.button_完成.Size = new System.Drawing.Size(75, 23);
            this.button_完成.TabIndex = 0;
            this.button_完成.Text = "完成";
            this.button_完成.UseVisualStyleBackColor = true;
            this.button_完成.Click += new System.EventHandler(this.button_完成_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "班级";
            // 
            // textBox_name
            // 
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(130, 80);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(121, 21);
            this.textBox_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "性别";
            // 
            // comboBox_性别
            // 
            this.comboBox_性别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_性别.Enabled = false;
            this.comboBox_性别.FormattingEnabled = true;
            this.comboBox_性别.Location = new System.Drawing.Point(130, 229);
            this.comboBox_性别.Name = "comboBox_性别";
            this.comboBox_性别.Size = new System.Drawing.Size(121, 20);
            this.comboBox_性别.TabIndex = 8;
            // 
            // comboBox_班级
            // 
            this.comboBox_班级.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_班级.Enabled = false;
            this.comboBox_班级.FormattingEnabled = true;
            this.comboBox_班级.Items.AddRange(new object[] {
            "计算机151",
            "计算机152",
            "计算机153",
            "计算机154"});
            this.comboBox_班级.Location = new System.Drawing.Point(130, 156);
            this.comboBox_班级.Name = "comboBox_班级";
            this.comboBox_班级.Size = new System.Drawing.Size(121, 20);
            this.comboBox_班级.TabIndex = 9;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(176, 318);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "返回";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_编辑
            // 
            this.button_编辑.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_编辑.FlatAppearance.BorderSize = 0;
            this.button_编辑.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_编辑.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_编辑.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_编辑.ForeColor = System.Drawing.Color.Transparent;
            this.button_编辑.Image = global::WindowsFormsApplication1.Properties.Resources.按钮_编辑1;
            this.button_编辑.Location = new System.Drawing.Point(258, 26);
            this.button_编辑.Name = "button_编辑";
            this.button_编辑.Size = new System.Drawing.Size(30, 26);
            this.button_编辑.TabIndex = 10;
            this.button_编辑.UseVisualStyleBackColor = true;
            this.button_编辑.Click += new System.EventHandler(this.button_编辑_Click);
            // 
            // 用户设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 380);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_编辑);
            this.Controls.Add(this.comboBox_班级);
            this.Controls.Add(this.comboBox_性别);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_完成);
            this.Name = "用户设置";
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.用户设置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_完成;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_性别;
        private System.Windows.Forms.ComboBox comboBox_班级;
        private System.Windows.Forms.Button button_编辑;
        private System.Windows.Forms.Button button_back;
    }
}