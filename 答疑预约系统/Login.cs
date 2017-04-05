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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox1_UserName.Text.Trim() == "" || textBox2_Password.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码", "提示");
            }
            else 
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = dbConnection.connection;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("", conn);               
                if (radioButton1_Student.Checked == true) 
                {
                    string sql = "select * from Student where UserName = '" 
                        + textBox1_UserName.Text.Trim() + "' and Password = '" 
                        + textBox2_Password.Text.Trim() + "'";
                    cmd.CommandText = sql;
                    if (null != cmd.ExecuteScalar())
                    {
                        globalvariables.f = 1;
                        this.Visible = false;
                        globalvariables.name = textBox1_UserName.Text.Trim();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("用户名或密码错误","警告");
                    }
                }
                else if (radioButton2_Teacher.Checked == true) 
                {
                    string sql = "select * from Teacher where UserName = '" 
                        + textBox1_UserName.Text.Trim() + "' and Password = '" 
                        + textBox2_Password.Text.Trim() + "'";
                    cmd.CommandText = sql;
                    if (null != cmd.ExecuteScalar())
                    {
                        globalvariables.f = 2;
                        this.Visible = false;
                        globalvariables.name = textBox1_UserName.Text.Trim();
                        Main main = new Main();                       
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "警告");
                    }
                }
                else if (radioButton3_Manager.Checked == true)
                {
                    string sql = "select * from Manager where UserName = '" 
                        + textBox1_UserName.Text.Trim() + "' and Password = '" 
                        + textBox2_Password.Text.Trim() + "'";
                    cmd.CommandText = sql;
                    if (null != cmd.ExecuteScalar())
                    {
                        globalvariables.f = 3;
                        this.Visible = false;
                        globalvariables.name = textBox1_UserName.Text.Trim();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "警告");
                    }
                }
                else 
                {
                    MessageBox.Show("没有选择用户类型", "提示");
                }
                conn.Close();
            }
        }

        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
