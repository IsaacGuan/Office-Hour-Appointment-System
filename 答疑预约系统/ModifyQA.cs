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
    public partial class ModifyQA : Form
    {
        public ModifyQA()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void button1_Confirm_Click(object sender, EventArgs e)
        {
            if (comboBox1_Course.Text.Trim() == "" || comboBox2_Place.Text.Trim() == "" || comboBox3_Time.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "提示");
            }
            else
            {
                if (MessageBox.Show("确定修改完成？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();
                    DataSet ds = new DataSet();
                    string sqlcheckplace = "select Place from QA where [Date] = #"
                        + dateTimePicker1.Value.ToShortDateString() + "# and [Time] = '"
                        + comboBox3_Time.Text.Trim() + "'";
                    OleDbDataAdapter adp3 = new OleDbDataAdapter(sqlcheckplace, conn);
                    ds.Clear();
                    adp3.Fill(ds, "QA");
                    if (ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Rows[0][0].ToString() != comboBox2_Place.Text.Trim())
                    {
                        string sqlupdate = "update QA set Course = '"
                            + comboBox1_Course.Text.Trim() + "', Place = '"
                            + comboBox2_Place.Text.Trim() + "', [Date] = #"
                            + dateTimePicker1.Value.ToShortDateString() + "#, [Time] = '"
                            + comboBox3_Time.Text.Trim() + "' where QAID ='"
                            + this.label2.Text + "'";
                        OleDbCommand cmd = new OleDbCommand(sqlupdate, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("预约修改成功", "提示");
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
