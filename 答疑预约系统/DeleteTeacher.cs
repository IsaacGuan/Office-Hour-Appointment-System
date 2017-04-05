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
    public partial class DeleteTeacher : Form
    {
        private DataSet ds;
        private string sql = "select TeacherID as 工号, TeacherName as 姓名, UserName as 用户名 from Teacher";

        public DeleteTeacher()
        {
            InitializeComponent();
            refreshgrid();
        }

        private void refreshgrid()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "Teacher");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["Teacher"].DefaultView;
            dataGrid1.CaptionText = "教师信息如下 共有" + ds.Tables["Teacher"].Rows.Count + "条记录";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("确实要删除此信息吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();
                    string sqldelete = "delete * from Teacher where TeacherID = '"
                        + ds.Tables["Teacher"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand("", conn);
                    cmd.CommandText = sqldelete;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功", "提示");
                    refreshgrid();
                }
            }
            else
            {
                MessageBox.Show("没有可删除的记录！", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
