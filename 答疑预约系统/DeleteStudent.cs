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
    public partial class DeleteStudent : Form
    {
        private DataSet ds;
        private string sql1 = "select StudentID as 学号, StudentName as 姓名, UserName as 用户名 from Student";

        public DeleteStudent()
        {
            InitializeComponent();
            refreshgrid();
        }

        private void refreshgrid()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            OleDbDataAdapter adp1 = new OleDbDataAdapter(sql1, conn);
            ds = new DataSet();
            ds.Clear();
            adp1.Fill(ds, "Student");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["Student"].DefaultView;
            dataGrid1.CaptionText = "学生信息如下 共有" + ds.Tables["Student"].Rows.Count + "条记录";
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
                    OleDbCommand cmd = new OleDbCommand("", conn);
                    string sid = ds.Tables["Student"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString();
                    string sqldelete1 = "delete * from Student where StudentID = '" + sid + "'";
                    cmd.CommandText = sqldelete1;
                    cmd.ExecuteNonQuery();                    
                    string sql2 = "select * from QAS where StudentID = '" + sid + "'";
                    OleDbDataAdapter adp2 = new OleDbDataAdapter(sql2, conn);
                    ds.Clear();
                    adp2.Fill(ds, "QAS");
                    string sqldelete2 = "delete * from QAS where StudentID = '" + sid + "'";                    
                    cmd.CommandText = sqldelete2;
                    cmd.ExecuteNonQuery();
                    int i = 0;
                    string qaid;
                    for (i = 0; i < ds.Tables["QAS"].Rows.Count; i++)
                    {
                        qaid = ds.Tables["QAS"].Rows[i]["QAID"].ToString();
                        string sqlcount = "select * from QAS where QAID = '" + qaid + "'";
                        OleDbDataAdapter adp3 = new OleDbDataAdapter(sqlcount, conn);
                        ds.Clear();
                        adp3.Fill(ds, "QAS");
                        string sqlupdate = "update QA set Num = " + ds.Tables["QAS"].Rows.Count + " where QAID = '" + qaid + "'";
                        cmd.CommandText = sqlupdate;
                        cmd.ExecuteNonQuery();
                    }
                    
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
