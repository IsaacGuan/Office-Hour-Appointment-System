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
    public partial class Release : Form
    {

        private DataSet ds;
        private string qaid;

        public Release()
        {            
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            ds = new DataSet();
            string sql1 = "select * from QA";
            string sql2 = "select top 1 * from QA order by ID desc";
            OleDbDataAdapter adp1 = new OleDbDataAdapter(sql1, conn);
            OleDbDataAdapter adp2 = new OleDbDataAdapter(sql2, conn);
            ds.Clear();
            adp1.Fill(ds, "QA");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Clear();
                adp2.Fill(ds, "QA");
                qaid = "00000000" + (int.Parse(ds.Tables["QA"].Rows[0]["QAID"].ToString()) + 1).ToString();
            }
            else
            {
                qaid = "000000001";
            }
            this.label2.Text = qaid;
        }

        private void button1_Confirm_Click(object sender, EventArgs e)
        {
            if (comboBox1_Course.Text.Trim() == "" || comboBox2_Place.Text.Trim() == "" || comboBox3_Time.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                if (MessageBox.Show("确实要发布此预约信息吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();
                    ds = new DataSet();
                    string sqlcheckplace = "select Place from QA where [Date] = #"
                        + dateTimePicker1.Value.ToShortDateString() + "# and [Time] = '"
                        + comboBox3_Time.Text.Trim() + "'";
                    OleDbDataAdapter adp3 = new OleDbDataAdapter(sqlcheckplace, conn);
                    ds.Clear();
                    adp3.Fill(ds, "QA");
                    if (ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Rows[0][0].ToString() != comboBox2_Place.Text.Trim())
                    {
                        string sqlinsert = "insert into QA(QAID, TeacherID, Course, Place, [Date], [Time], Num, Flag) values ('" + qaid + "', '"
                            + globalvariables.name + "','" + comboBox1_Course.Text.Trim() + "','" + comboBox2_Place.Text.Trim() + "', #"
                            + dateTimePicker1.Value.ToShortDateString() + "# ,'" + comboBox3_Time.Text.Trim() + "', 0, 1 )";
                        OleDbCommand cmd = new OleDbCommand(sqlinsert, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("预约发布成功", "提示");
                        this.Visible = false;
                        this.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("所选时段该教室已被占用，请重新选择", "提示");
                    }
                }
            }
        }

        private void button2_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

    }
}
