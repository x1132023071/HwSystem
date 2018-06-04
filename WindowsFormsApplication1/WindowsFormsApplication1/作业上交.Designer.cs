namespace WindowsFormsApplication1
{
    partial class 作业上交
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
            this.button_提交作业 = new System.Windows.Forms.Button();
            this.textBox_作业内容 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_作业题目 = new System.Windows.Forms.ComboBox();
            this.button_打开作业 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_自己作业 = new System.Windows.Forms.TextBox();
            this.button_保存 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_提交作业
            // 
            this.button_提交作业.Enabled = false;
            this.button_提交作业.Location = new System.Drawing.Point(144, 282);
            this.button_提交作业.Name = "button_提交作业";
            this.button_提交作业.Size = new System.Drawing.Size(150, 48);
            this.button_提交作业.TabIndex = 0;
            this.button_提交作业.Text = "提交作业";
            this.button_提交作业.UseVisualStyleBackColor = true;
            this.button_提交作业.Click += new System.EventHandler(this.button_提交作业_Click);
            // 
            // textBox_作业内容
            // 
            this.textBox_作业内容.Enabled = false;
            this.textBox_作业内容.Location = new System.Drawing.Point(117, 65);
            this.textBox_作业内容.Multiline = true;
            this.textBox_作业内容.Name = "textBox_作业内容";
            this.textBox_作业内容.Size = new System.Drawing.Size(291, 44);
            this.textBox_作业内容.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作业内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "作业题目";
            // 
            // comboBox_作业题目
            // 
            this.comboBox_作业题目.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_作业题目.FormattingEnabled = true;
            this.comboBox_作业题目.Location = new System.Drawing.Point(117, 21);
            this.comboBox_作业题目.Name = "comboBox_作业题目";
            this.comboBox_作业题目.Size = new System.Drawing.Size(291, 20);
            this.comboBox_作业题目.TabIndex = 4;
            this.comboBox_作业题目.SelectedIndexChanged += new System.EventHandler(this.comboBox_作业题目_SelectedIndexChanged);
            // 
            // button_打开作业
            // 
            this.button_打开作业.Location = new System.Drawing.Point(144, 230);
            this.button_打开作业.Name = "button_打开作业";
            this.button_打开作业.Size = new System.Drawing.Size(75, 23);
            this.button_打开作业.TabIndex = 5;
            this.button_打开作业.Text = "打开作业";
            this.button_打开作业.UseVisualStyleBackColor = true;
            this.button_打开作业.Click += new System.EventHandler(this.button_打开作业_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "自己的作业";
            // 
            // textBox_自己作业
            // 
            this.textBox_自己作业.Location = new System.Drawing.Point(117, 137);
            this.textBox_自己作业.Multiline = true;
            this.textBox_自己作业.Name = "textBox_自己作业";
            this.textBox_自己作业.Size = new System.Drawing.Size(291, 87);
            this.textBox_自己作业.TabIndex = 7;
            // 
            // button_保存
            // 
            this.button_保存.Location = new System.Drawing.Point(266, 230);
            this.button_保存.Name = "button_保存";
            this.button_保存.Size = new System.Drawing.Size(75, 23);
            this.button_保存.TabIndex = 8;
            this.button_保存.Text = "保存作业";
            this.button_保存.UseVisualStyleBackColor = true;
            this.button_保存.Click += new System.EventHandler(this.button_保存_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 作业上交
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 367);
            this.Controls.Add(this.button_保存);
            this.Controls.Add(this.textBox_自己作业);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_打开作业);
            this.Controls.Add(this.comboBox_作业题目);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_作业内容);
            this.Controls.Add(this.button_提交作业);
            this.Name = "作业上交";
            this.Text = "作业";
            this.Load += new System.EventHandler(this.作业上交_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_提交作业;
        private System.Windows.Forms.TextBox textBox_作业内容;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_作业题目;
        private System.Windows.Forms.Button button_打开作业;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_自己作业;
        private System.Windows.Forms.Button button_保存;
        private System.Windows.Forms.Timer timer1;
    }
}