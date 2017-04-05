namespace 答疑预约系统
{
    partial class Release
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_Course = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2_Place = new System.Windows.Forms.ComboBox();
            this.labe5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3_Time = new System.Windows.Forms.ComboBox();
            this.button1_Confirm = new System.Windows.Forms.Button();
            this.button2_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "课程";
            // 
            // comboBox1_Course
            // 
            this.comboBox1_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_Course.FormattingEnabled = true;
            this.comboBox1_Course.Items.AddRange(new object[] {
            "数据库",
            "计算机网络",
            "编译原理",
            "操作系统",
            "数据结构"});
            this.comboBox1_Course.Location = new System.Drawing.Point(108, 66);
            this.comboBox1_Course.Name = "comboBox1_Course";
            this.comboBox1_Course.Size = new System.Drawing.Size(121, 20);
            this.comboBox1_Course.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "地点";
            // 
            // comboBox2_Place
            // 
            this.comboBox2_Place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_Place.FormattingEnabled = true;
            this.comboBox2_Place.Items.AddRange(new object[] {
            "松1134",
            "松1138",
            "松1142",
            "松1146",
            "松1150",
            "松1154"});
            this.comboBox2_Place.Location = new System.Drawing.Point(108, 102);
            this.comboBox2_Place.Name = "comboBox2_Place";
            this.comboBox2_Place.Size = new System.Drawing.Size(121, 20);
            this.comboBox2_Place.TabIndex = 3;
            // 
            // labe5
            // 
            this.labe5.AutoSize = true;
            this.labe5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labe5.Location = new System.Drawing.Point(276, 70);
            this.labe5.Name = "labe5";
            this.labe5.Size = new System.Drawing.Size(35, 14);
            this.labe5.TabIndex = 4;
            this.labe5.Text = "日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(276, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "时间";
            // 
            // comboBox3_Time
            // 
            this.comboBox3_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3_Time.FormattingEnabled = true;
            this.comboBox3_Time.Items.AddRange(new object[] {
            "08:15",
            "09:00",
            "10:05",
            "10:50",
            "13:00",
            "13:45",
            "14:50",
            "15:35",
            "16:20"});
            this.comboBox3_Time.Location = new System.Drawing.Point(348, 102);
            this.comboBox3_Time.Name = "comboBox3_Time";
            this.comboBox3_Time.Size = new System.Drawing.Size(121, 20);
            this.comboBox3_Time.TabIndex = 7;
            // 
            // button1_Confirm
            // 
            this.button1_Confirm.Location = new System.Drawing.Point(168, 152);
            this.button1_Confirm.Name = "button1_Confirm";
            this.button1_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button1_Confirm.TabIndex = 8;
            this.button1_Confirm.Text = "确认发布";
            this.button1_Confirm.UseVisualStyleBackColor = true;
            this.button1_Confirm.Click += new System.EventHandler(this.button1_Confirm_Click);
            // 
            // button2_Cancel
            // 
            this.button2_Cancel.Location = new System.Drawing.Point(334, 152);
            this.button2_Cancel.Name = "button2_Cancel";
            this.button2_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancel.TabIndex = 9;
            this.button2_Cancel.Text = "取消";
            this.button2_Cancel.UseVisualStyleBackColor = true;
            this.button2_Cancel.Click += new System.EventHandler(this.button2_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "预约编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(105, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // Release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_Cancel);
            this.Controls.Add(this.button1_Confirm);
            this.Controls.Add(this.comboBox3_Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labe5);
            this.Controls.Add(this.comboBox2_Place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_Course);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Release";
            this.Text = "发布预约信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1_Course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2_Place;
        private System.Windows.Forms.Label labe5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3_Time;
        private System.Windows.Forms.Button button1_Confirm;
        private System.Windows.Forms.Button button2_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}