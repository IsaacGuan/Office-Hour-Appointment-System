namespace 答疑预约系统
{
    partial class ModifyUserName
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
            this.label2_UserName = new System.Windows.Forms.Label();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox3_Password = new System.Windows.Forms.TextBox();
            this.label3_Password = new System.Windows.Forms.Label();
            this.label4_NewUserName = new System.Windows.Forms.Label();
            this.textBox4_NewUserName = new System.Windows.Forms.TextBox();
            this.button1_Confirm = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.label1_ID = new System.Windows.Forms.Label();
            this.textBox2_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2_UserName
            // 
            this.label2_UserName.AutoSize = true;
            this.label2_UserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_UserName.Location = new System.Drawing.Point(35, 88);
            this.label2_UserName.Name = "label2_UserName";
            this.label2_UserName.Size = new System.Drawing.Size(49, 14);
            this.label2_UserName.TabIndex = 0;
            this.label2_UserName.Text = "用户名";
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(123, 39);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(165, 21);
            this.textBox1_ID.TabIndex = 8;
            // 
            // textBox3_Password
            // 
            this.textBox3_Password.Location = new System.Drawing.Point(123, 121);
            this.textBox3_Password.Name = "textBox3_Password";
            this.textBox3_Password.Size = new System.Drawing.Size(165, 21);
            this.textBox3_Password.TabIndex = 9;
            this.textBox3_Password.UseSystemPasswordChar = true;
            // 
            // label3_Password
            // 
            this.label3_Password.AutoSize = true;
            this.label3_Password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3_Password.Location = new System.Drawing.Point(35, 128);
            this.label3_Password.Name = "label3_Password";
            this.label3_Password.Size = new System.Drawing.Size(35, 14);
            this.label3_Password.TabIndex = 10;
            this.label3_Password.Text = "密码";
            // 
            // label4_NewUserName
            // 
            this.label4_NewUserName.AutoSize = true;
            this.label4_NewUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4_NewUserName.Location = new System.Drawing.Point(35, 169);
            this.label4_NewUserName.Name = "label4_NewUserName";
            this.label4_NewUserName.Size = new System.Drawing.Size(63, 14);
            this.label4_NewUserName.TabIndex = 11;
            this.label4_NewUserName.Text = "新用户名";
            // 
            // textBox4_NewUserName
            // 
            this.textBox4_NewUserName.Location = new System.Drawing.Point(123, 162);
            this.textBox4_NewUserName.Name = "textBox4_NewUserName";
            this.textBox4_NewUserName.Size = new System.Drawing.Size(165, 21);
            this.textBox4_NewUserName.TabIndex = 12;
            // 
            // button1_Confirm
            // 
            this.button1_Confirm.Location = new System.Drawing.Point(65, 218);
            this.button1_Confirm.Name = "button1_Confirm";
            this.button1_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button1_Confirm.TabIndex = 13;
            this.button1_Confirm.Text = "确认";
            this.button1_Confirm.UseVisualStyleBackColor = true;
            this.button1_Confirm.Click += new System.EventHandler(this.button1_Confirm_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(187, 218);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancel.TabIndex = 14;
            this.button2_Cancel.Text = "取消";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // label1_ID
            // 
            this.label1_ID.AutoSize = true;
            this.label1_ID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_ID.Location = new System.Drawing.Point(35, 46);
            this.label1_ID.Name = "label1_ID";
            this.label1_ID.Size = new System.Drawing.Size(70, 14);
            this.label1_ID.TabIndex = 15;
            this.label1_ID.Text = "学号/工号";
            // 
            // textBox2_UserName
            // 
            this.textBox2_UserName.Location = new System.Drawing.Point(123, 81);
            this.textBox2_UserName.Name = "textBox2_UserName";
            this.textBox2_UserName.Size = new System.Drawing.Size(165, 21);
            this.textBox2_UserName.TabIndex = 16;
            // 
            // ModifyUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 266);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2_UserName);
            this.Controls.Add(this.label1_ID);
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_Confirm);
            this.Controls.Add(this.textBox4_NewUserName);
            this.Controls.Add(this.label4_NewUserName);
            this.Controls.Add(this.label3_Password);
            this.Controls.Add(this.textBox3_Password);
            this.Controls.Add(this.textBox1_ID);
            this.Controls.Add(this.label2_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyUserName";
            this.Text = "修改用户名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2_UserName;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.TextBox textBox3_Password;
        private System.Windows.Forms.Label label3_Password;
        private System.Windows.Forms.Label label4_NewUserName;
        private System.Windows.Forms.TextBox textBox4_NewUserName;
        private System.Windows.Forms.Button button1_Confirm;
        private System.Windows.Forms.Button button2_Cancel;
        private System.Windows.Forms.Label label1_ID;
        private System.Windows.Forms.TextBox textBox2_UserName;
    }
}