﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 答疑预约系统
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_TeacherName.Text.Trim() == "" || textBox2_TeacherID.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = dbConnection.connection;
                conn.Open();
                string sql = "insert into Student (TeacherID, TeachertName, UserName, [Password]) values ('"
                    + textBox2_TeacherID.Text.Trim() + "','" + textBox1_TeacherName.Text.Trim() + "','"
                    + textBox2_TeacherID.Text.Trim() + "','" + textBox2_TeacherID.Text.Trim() + "')";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("学生信息添加成功", "提示");
                this.Visible = false;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
