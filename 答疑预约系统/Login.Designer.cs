namespace 答疑预约系统
{
    partial class Login
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
            this.label1_Title = new System.Windows.Forms.Label();
            this.label2_Type = new System.Windows.Forms.Label();
            this.label3_UserName = new System.Windows.Forms.Label();
            this.label4_Password = new System.Windows.Forms.Label();
            this.radioButton1_Student = new System.Windows.Forms.RadioButton();
            this.radioButton2_Teacher = new System.Windows.Forms.RadioButton();
            this.radioButton3_Manager = new System.Windows.Forms.RadioButton();
            this.textBox1_UserName = new System.Windows.Forms.TextBox();
            this.textBox2_Password = new System.Windows.Forms.TextBox();
            this.button1_Confirm = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Title
            // 
            this.label1_Title.AutoSize = true;
            this.label1_Title.Font = new System.Drawing.Font("黑体", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Title.Location = new System.Drawing.Point(83, 33);
            this.label1_Title.Name = "label1_Title";
            this.label1_Title.Size = new System.Drawing.Size(174, 25);
            this.label1_Title.TabIndex = 0;
            this.label1_Title.Text = "预约答疑系统";
            // 
            // label2_Type
            // 
            this.label2_Type.AutoSize = true;
            this.label2_Type.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_Type.Location = new System.Drawing.Point(42, 89);
            this.label2_Type.Name = "label2_Type";
            this.label2_Type.Size = new System.Drawing.Size(67, 14);
            this.label2_Type.TabIndex = 1;
            this.label2_Type.Text = "用户类型";
            // 
            // label3_UserName
            // 
            this.label3_UserName.AutoSize = true;
            this.label3_UserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3_UserName.Location = new System.Drawing.Point(43, 131);
            this.label3_UserName.Name = "label3_UserName";
            this.label3_UserName.Size = new System.Drawing.Size(52, 14);
            this.label3_UserName.TabIndex = 2;
            this.label3_UserName.Text = "用户名";
            // 
            // label4_Password
            // 
            this.label4_Password.AutoSize = true;
            this.label4_Password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4_Password.Location = new System.Drawing.Point(44, 173);
            this.label4_Password.Name = "label4_Password";
            this.label4_Password.Size = new System.Drawing.Size(37, 14);
            this.label4_Password.TabIndex = 3;
            this.label4_Password.Text = "密码";
            // 
            // radioButton1_Student
            // 
            this.radioButton1_Student.AutoSize = true;
            this.radioButton1_Student.Location = new System.Drawing.Point(127, 89);
            this.radioButton1_Student.Name = "radioButton1_Student";
            this.radioButton1_Student.Size = new System.Drawing.Size(47, 16);
            this.radioButton1_Student.TabIndex = 4;
            this.radioButton1_Student.TabStop = true;
            this.radioButton1_Student.Text = "学生";
            this.radioButton1_Student.UseVisualStyleBackColor = true;
            // 
            // radioButton2_Teacher
            // 
            this.radioButton2_Teacher.AutoSize = true;
            this.radioButton2_Teacher.Location = new System.Drawing.Point(180, 89);
            this.radioButton2_Teacher.Name = "radioButton2_Teacher";
            this.radioButton2_Teacher.Size = new System.Drawing.Size(47, 16);
            this.radioButton2_Teacher.TabIndex = 5;
            this.radioButton2_Teacher.TabStop = true;
            this.radioButton2_Teacher.Text = "教师";
            this.radioButton2_Teacher.UseVisualStyleBackColor = true;
            // 
            // radioButton3_Manager
            // 
            this.radioButton3_Manager.AutoSize = true;
            this.radioButton3_Manager.Location = new System.Drawing.Point(233, 89);
            this.radioButton3_Manager.Name = "radioButton3_Manager";
            this.radioButton3_Manager.Size = new System.Drawing.Size(59, 16);
            this.radioButton3_Manager.TabIndex = 6;
            this.radioButton3_Manager.TabStop = true;
            this.radioButton3_Manager.Text = "管理员";
            this.radioButton3_Manager.UseVisualStyleBackColor = true;
            // 
            // textBox1_UserName
            // 
            this.textBox1_UserName.Location = new System.Drawing.Point(127, 129);
            this.textBox1_UserName.Name = "textBox1_UserName";
            this.textBox1_UserName.Size = new System.Drawing.Size(165, 21);
            this.textBox1_UserName.TabIndex = 7;
            // 
            // textBox2_Password
            // 
            this.textBox2_Password.Location = new System.Drawing.Point(127, 171);
            this.textBox2_Password.Name = "textBox2_Password";
            this.textBox2_Password.Size = new System.Drawing.Size(165, 21);
            this.textBox2_Password.TabIndex = 8;
            this.textBox2_Password.UseSystemPasswordChar = true;
            // 
            // button1_Confirm
            // 
            this.button1_Confirm.Location = new System.Drawing.Point(88, 227);
            this.button1_Confirm.Name = "button1_Confirm";
            this.button1_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button1_Confirm.TabIndex = 9;
            this.button1_Confirm.Text = "确认";
            this.button1_Confirm.UseVisualStyleBackColor = true;
            this.button1_Confirm.Click += new System.EventHandler(this.button1_Confirm_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(182, 227);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancel.TabIndex = 10;
            this.button2_Cancel.Text = "取消";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 277);
            this.ControlBox = false;
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_Confirm);
            this.Controls.Add(this.textBox2_Password);
            this.Controls.Add(this.textBox1_UserName);
            this.Controls.Add(this.radioButton3_Manager);
            this.Controls.Add(this.radioButton2_Teacher);
            this.Controls.Add(this.radioButton1_Student);
            this.Controls.Add(this.label4_Password);
            this.Controls.Add(this.label3_UserName);
            this.Controls.Add(this.label2_Type);
            this.Controls.Add(this.label1_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Title;
        private System.Windows.Forms.Label label2_Type;
        private System.Windows.Forms.Label label3_UserName;
        private System.Windows.Forms.Label label4_Password;
        private System.Windows.Forms.RadioButton radioButton1_Student;
        private System.Windows.Forms.RadioButton radioButton2_Teacher;
        private System.Windows.Forms.RadioButton radioButton3_Manager;
        private System.Windows.Forms.TextBox textBox1_UserName;
        private System.Windows.Forms.TextBox textBox2_Password;
        private System.Windows.Forms.Button button1_Confirm;
        private System.Windows.Forms.Button button2_Cancel;
    }
}