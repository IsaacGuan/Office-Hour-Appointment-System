using System;
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
    public partial class ModifyPassword : Form
    {
        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void button1_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox1_ID.Text.Trim() == "" || textBox2_UserName.Text.Trim() == "" || textBox3_NewPassword.Text.Trim() == "" || textBox4_PasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = dbConnection.connection;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("", conn);
                string sql1 = "select * from Student where StudentID = '"
                    + textBox1_ID.Text.Trim() + "' and UserName = '"
                    + textBox2_UserName.Text.Trim() + "'";
                string sql2 = "select * from Teacher where TeacherID = '"
                    + textBox1_ID.Text.Trim() + "' and UserName = '"
                    + textBox2_UserName.Text.Trim() + "'";
                string sql3 = "select * from Manager where ManagerID = '"
                    + textBox1_ID.Text.Trim() + "' and UserName = '"
                    + textBox2_UserName.Text.Trim() + "'";
                if (globalvariables.f == 1)
                {
                    cmd.CommandText = sql1;
                }
                else if (globalvariables.f == 2)
                {
                    cmd.CommandText = sql2;
                }
                else if (globalvariables.f == 3)
                {
                    cmd.CommandText = sql3;
                }
                if (null != cmd.ExecuteScalar()) 
                {
                    if (textBox3_NewPassword.Text.Trim() != textBox4_PasswordConfirm.Text.Trim())
                    {
                        MessageBox.Show("两次密码输入不一致", "警告");
                    }
                    else 
                    {
                        sql1 = "update Student set [Password] = '" 
                            + textBox3_NewPassword.Text.Trim() + "' where StudentID = '"
                            + textBox1_ID.Text.Trim() + "'";
                        sql2 = "update Teacher set [Password] = '"
                            + textBox3_NewPassword.Text.Trim() + "' where TeacherID = '"
                            + textBox1_ID.Text.Trim() + "'";
                        sql3 = "update Manager set [Password] = '"
                            + textBox3_NewPassword.Text.Trim() + "' where ManagerID = '"
                            + textBox1_ID.Text.Trim() + "'";
                        if (globalvariables.f == 1)
                        {
                            cmd.CommandText = sql1;
                        }
                        else if (globalvariables.f == 2)
                        {
                            cmd.CommandText = sql2;
                        }
                        else if (globalvariables.f == 3)
                        {
                            cmd.CommandText = sql3;
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("密码修改成功！", "提示");
                        this.Visible = false;
                        this.Close();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("学号/工号或用户名错误", "提示");
                }
                conn.Close();
            }
        }

        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Main main = new Main();
            main.ShowDialog();
        }

    }
}
