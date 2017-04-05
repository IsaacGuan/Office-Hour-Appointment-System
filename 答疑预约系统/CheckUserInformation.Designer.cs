namespace 答疑预约系统
{
    partial class CheckUserInformation
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
            this.label1_Name = new System.Windows.Forms.Label();
            this.label2_ID = new System.Windows.Forms.Label();
            this.label3_UserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Name
            // 
            this.label1_Name.AutoSize = true;
            this.label1_Name.Font = new System.Drawing.Font("宋体", 10F);
            this.label1_Name.Location = new System.Drawing.Point(29, 50);
            this.label1_Name.Name = "label1_Name";
            this.label1_Name.Size = new System.Drawing.Size(35, 14);
            this.label1_Name.TabIndex = 0;
            this.label1_Name.Text = "姓名";
            // 
            // label2_ID
            // 
            this.label2_ID.AutoSize = true;
            this.label2_ID.Font = new System.Drawing.Font("宋体", 10F);
            this.label2_ID.Location = new System.Drawing.Point(29, 92);
            this.label2_ID.Name = "label2_ID";
            this.label2_ID.Size = new System.Drawing.Size(70, 14);
            this.label2_ID.TabIndex = 1;
            this.label2_ID.Text = "学号/工号";
            // 
            // label3_UserName
            // 
            this.label3_UserName.AutoSize = true;
            this.label3_UserName.Font = new System.Drawing.Font("宋体", 10F);
            this.label3_UserName.Location = new System.Drawing.Point(29, 134);
            this.label3_UserName.Name = "label3_UserName";
            this.label3_UserName.Size = new System.Drawing.Size(49, 14);
            this.label3_UserName.TabIndex = 2;
            this.label3_UserName.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(129, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(129, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(129, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // CheckUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 216);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3_UserName);
            this.Controls.Add(this.label2_ID);
            this.Controls.Add(this.label1_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckUserInformation";
            this.Text = "用户信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Name;
        private System.Windows.Forms.Label label2_ID;
        private System.Windows.Forms.Label label3_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}