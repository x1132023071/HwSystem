namespace WindowsFormsApplication1
{
    partial class 班级设置
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
            this.button_确定 = new System.Windows.Forms.Button();
            this.radioButton_class_one = new System.Windows.Forms.RadioButton();
            this.radioButton_class_two = new System.Windows.Forms.RadioButton();
            this.radioButton_class_three = new System.Windows.Forms.RadioButton();
            this.radioButton_class_four = new System.Windows.Forms.RadioButton();
            this.label_班级 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_确定
            // 
            this.button_确定.Location = new System.Drawing.Point(62, 156);
            this.button_确定.Name = "button_确定";
            this.button_确定.Size = new System.Drawing.Size(184, 23);
            this.button_确定.TabIndex = 0;
            this.button_确定.Text = "确定设置";
            this.button_确定.UseVisualStyleBackColor = true;
            this.button_确定.Click += new System.EventHandler(this.button_确定_Click);
            // 
            // radioButton_class_one
            // 
            this.radioButton_class_one.AutoSize = true;
            this.radioButton_class_one.Location = new System.Drawing.Point(101, 57);
            this.radioButton_class_one.Name = "radioButton_class_one";
            this.radioButton_class_one.Size = new System.Drawing.Size(77, 16);
            this.radioButton_class_one.TabIndex = 2;
            this.radioButton_class_one.TabStop = true;
            this.radioButton_class_one.Text = "计算机151";
            this.radioButton_class_one.UseVisualStyleBackColor = true;
            this.radioButton_class_one.CheckedChanged += new System.EventHandler(this.radioButton_class_one_CheckedChanged);
            // 
            // radioButton_class_two
            // 
            this.radioButton_class_two.AutoSize = true;
            this.radioButton_class_two.Location = new System.Drawing.Point(193, 57);
            this.radioButton_class_two.Name = "radioButton_class_two";
            this.radioButton_class_two.Size = new System.Drawing.Size(77, 16);
            this.radioButton_class_two.TabIndex = 3;
            this.radioButton_class_two.TabStop = true;
            this.radioButton_class_two.Text = "计算机152";
            this.radioButton_class_two.UseVisualStyleBackColor = true;
            this.radioButton_class_two.CheckedChanged += new System.EventHandler(this.radioButton_class_two_CheckedChanged);
            // 
            // radioButton_class_three
            // 
            this.radioButton_class_three.AutoSize = true;
            this.radioButton_class_three.Location = new System.Drawing.Point(101, 104);
            this.radioButton_class_three.Name = "radioButton_class_three";
            this.radioButton_class_three.Size = new System.Drawing.Size(77, 16);
            this.radioButton_class_three.TabIndex = 4;
            this.radioButton_class_three.TabStop = true;
            this.radioButton_class_three.Text = "计算机153";
            this.radioButton_class_three.UseVisualStyleBackColor = true;
            this.radioButton_class_three.CheckedChanged += new System.EventHandler(this.radioButton_class_three_CheckedChanged);
            // 
            // radioButton_class_four
            // 
            this.radioButton_class_four.AutoSize = true;
            this.radioButton_class_four.Location = new System.Drawing.Point(193, 104);
            this.radioButton_class_four.Name = "radioButton_class_four";
            this.radioButton_class_four.Size = new System.Drawing.Size(77, 16);
            this.radioButton_class_four.TabIndex = 5;
            this.radioButton_class_four.TabStop = true;
            this.radioButton_class_four.Text = "计算机154";
            this.radioButton_class_four.UseVisualStyleBackColor = true;
            this.radioButton_class_four.CheckedChanged += new System.EventHandler(this.radioButton_class_four_CheckedChanged);
            // 
            // label_班级
            // 
            this.label_班级.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_班级.Location = new System.Drawing.Point(12, 57);
            this.label_班级.Name = "label_班级";
            this.label_班级.Size = new System.Drawing.Size(83, 29);
            this.label_班级.TabIndex = 6;
            this.label_班级.Text = "班级:";
            // 
            // 班级设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 209);
            this.Controls.Add(this.label_班级);
            this.Controls.Add(this.radioButton_class_four);
            this.Controls.Add(this.radioButton_class_three);
            this.Controls.Add(this.radioButton_class_two);
            this.Controls.Add(this.radioButton_class_one);
            this.Controls.Add(this.button_确定);
            this.Name = "班级设置";
            this.Text = "班级设置";
            this.Load += new System.EventHandler(this.班级设置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_确定;
        private System.Windows.Forms.RadioButton radioButton_class_one;
        private System.Windows.Forms.RadioButton radioButton_class_two;
        private System.Windows.Forms.RadioButton radioButton_class_three;
        private System.Windows.Forms.RadioButton radioButton_class_four;
        private System.Windows.Forms.Label label_班级;
    }
}