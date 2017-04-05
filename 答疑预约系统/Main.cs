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
    public partial class Main : Form
    {
        private DataSet ds;

        private string sql1 = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 1 and Date > #"
            + DateTime.Now.ToShortDateString() + "# and QAID not in ( select QAID from QAS where StudentID in ( select StudentID from Student where UserName = '"
            + globalvariables.name + "' ) )";
        private string sql2 = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 1 and Teacher.TeacherID in ( select TeacherID from Teacher where UserName = '"
            + globalvariables.name + "' ) ";
        private string sql3 = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 1 and QAID in ( select QAID from QAS where StudentID in ( select StudentID from Student where UserName = '"
            + globalvariables.name + "' ) )";
        private string sql4 = "select * from Student where UserName = '" + globalvariables.name + "'";
        private string sql5 = "select * from Teacher where UserName = '" + globalvariables.name + "'";

        public Main()
        {
            InitializeComponent();

            checkrefresh();
            
            if (globalvariables.f == 0) 
            {
                this.系统管理ToolStripMenuItem.Visible = false;
                this.用户管理ToolStripMenuItem.Visible = false;
                this.用户登出ToolStripMenuItem.Visible = false;
                this.dataGrid1.Visible = false;
                this.toolStrip1.Visible = false;
                this.label1.Text = globalvariables.name;
            }
            if (globalvariables.f == 1) 
            {
                this.系统管理ToolStripMenuItem.Visible = false;
                this.用户登录ToolStripMenuItem.Visible = false;
                this.toolStripLabel7.Visible = false;
                this.toolStripLabel8.Visible = false;
                this.toolStripLabel9.Visible = false;
                this.toolStripLabel10.Visible = false;
                this.toolStripLabel11.Visible = false;
                this.toolStripLabel12.Visible = false;
                this.toolStripLabel13.Visible = false;
                this.toolStripLabel14.Visible = false;
                this.toolStripLabel5.Enabled = false;
                this.toolStripLabel6.Enabled = false;
                this.label1.Text = globalvariables.name;
             }
            if (globalvariables.f == 2) 
            {
                this.系统管理ToolStripMenuItem.Visible = false;
                this.用户登录ToolStripMenuItem.Visible = false;
                this.toolStripLabel1.Visible = false;
                this.toolStripLabel2.Visible = false;
                this.toolStripLabel3.Visible = false;
                this.toolStripLabel4.Visible = false;
                this.toolStripLabel5.Visible = false;
                this.toolStripLabel6.Visible = false;
                this.toolStripLabel10.Enabled = false;
                this.toolStripLabel12.Enabled = false;
                this.toolStripLabel13.Enabled = false;
                this.toolStripLabel14.Enabled = false;
                this.label1.Text = globalvariables.name;
            }
            if (globalvariables.f == 3) 
            {
                this.用户登录ToolStripMenuItem.Visible = false;
                this.dataGrid1.Visible = false;
                this.toolStrip1.Visible = false;
                this.label1.Text = globalvariables.name;
            }
        }

        private void checkrefresh()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sqlcheckdate = "update QA set Flag = 0 where Date < #" + DateTime.Now.ToShortDateString() + "#";
            OleDbCommand cmd = new OleDbCommand(sqlcheckdate, conn); ;
            cmd.ExecuteNonQuery();
        }

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.ShowDialog();           
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void 用户登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定登出？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                globalvariables.f = 0;
                globalvariables.name = "游客请登陆";
                MessageBox.Show("已登出", "提示");
                this.Visible = false;
                this.Close();
                Main main = new Main();
                main.ShowDialog();
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如有任何问题请联系本系统开发人员\n邮箱：proletarianguan@163.com\n电话：086-15026877328", "帮助");
        }

        private void 修改用户名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModifyUserName modifyusername = new ModifyUserName();
            modifyusername.ShowDialog();
        }

        private void 查看用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserInformation checkuserinformation = new CheckUserInformation();
            checkuserinformation.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModifyPassword modifypassword = new ModifyPassword();
            modifypassword.ShowDialog();
        }

        private void datagridrefresh1()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            if (globalvariables.f == 1)
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql1, conn);
                ds = new DataSet();
                ds.Clear();
                adp.Fill(ds, "QA");
                dataGrid1.ReadOnly = true;
                dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
                dataGrid1.CaptionText = "可申请的预约如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
            }
            if (globalvariables.f == 2)
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql2, conn);
                ds = new DataSet();
                ds.Clear();
                adp.Fill(ds, "QA");
                dataGrid1.ReadOnly = true;
                dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
                dataGrid1.CaptionText = "从即日起已发布的预约信息如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
            }        
        }

        private void datagridrefresh2()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            if (globalvariables.f == 1)
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql3, conn);
                ds = new DataSet();
                ds.Clear();
                adp.Fill(ds, "QA");
                dataGrid1.ReadOnly = true;
                dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
                dataGrid1.CaptionText = "已申请的预约如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            datagridrefresh1();
            this.toolStripLabel1.Enabled = true;
            this.toolStripLabel2.Enabled = true;
            this.toolStripLabel4.Enabled = true;
            this.toolStripLabel3.Enabled = true;
            this.toolStripLabel5.Enabled = true;
            this.toolStripLabel6.Enabled = false;          
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            datagridrefresh2();
            this.toolStripLabel1.Enabled = true;
            this.toolStripLabel2.Enabled = true;
            this.toolStripLabel4.Enabled = true;
            this.toolStripLabel3.Enabled = true;
            this.toolStripLabel6.Enabled = true;
            this.toolStripLabel5.Enabled = false;
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.toolStripLabel1.Enabled = true;
            this.toolStripLabel2.Enabled = true;
            this.toolStripLabel4.Enabled = true;
            this.toolStripLabel3.Enabled = true;
            this.toolStripLabel5.Enabled = false;
            this.toolStripLabel6.Enabled = false;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sqldeletedqa = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 0 and Date > #"
                + DateTime.Now.ToShortDateString() + "# and QAID in ( select QAID from QAS where StudentID in ( select StudentID from Student where UserName = '" 
                + globalvariables.name + "' ) )";
            OleDbDataAdapter adp = new OleDbDataAdapter(sqldeletedqa, conn);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "QA");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
            dataGrid1.CaptionText = "被删除的预约信息如下 共有" + ds.Tables["QA"].Rows.Count + "条记录 如有任何疑问，请联系教师";
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.toolStripLabel1.Enabled = true;
            this.toolStripLabel2.Enabled = true;
            this.toolStripLabel4.Enabled = true;
            this.toolStripLabel3.Enabled = true;
            this.toolStripLabel5.Enabled = false;
            this.toolStripLabel6.Enabled = false;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sqltoday = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 1 and Date = #"
                + DateTime.Now.ToShortDateString() + "# and QAID in ( select QAID from QAS where StudentID in ( select StudentID from Student where UserName = '"
                + globalvariables.name + "' ) )";
            OleDbDataAdapter adp = new OleDbDataAdapter(sqltoday, conn);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "QA");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
            dataGrid1.CaptionText = "今天要完成的预约如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("确实要申请此次答疑预约吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();                    
                    OleDbDataAdapter adp1 = new OleDbDataAdapter(sql1, conn);
                    OleDbDataAdapter adp2 = new OleDbDataAdapter(sql4, conn);
                    OleDbCommand cmd = new OleDbCommand("", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp2.Fill(ds, "Student");
                    string sid = ds.Tables["Student"].Rows[0]["StudentID"].ToString();
                    ds.Clear();
                    adp1.Fill(ds, "QA");
                    string qaid = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString();
                    string sqlinsert = "insert into QAS (QAID, StudentID) values ('" + qaid + "','" + sid + "')";
                    cmd.CommandText = sqlinsert;
                    cmd.ExecuteNonQuery();
                    string sqlcount = "select * from QAS where QAID = '" + qaid + "'";
                    OleDbDataAdapter adp3 = new OleDbDataAdapter(sqlcount, conn);
                    ds.Clear();
                    adp3.Fill(ds, "QAS");
                    string sqlupdate = "update QA set Num = " + ds.Tables["QAS"].Rows.Count + " where QAID = '" + qaid + "'";
                    cmd.CommandText = sqlupdate;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("预约成功", "提示");
                    datagridrefresh1();
                }
            }
            else
            {
                MessageBox.Show("没有可申请的预约！", "提示");
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("确实要删除此申请记录吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();
                    OleDbDataAdapter adp1 = new OleDbDataAdapter(sql3, conn);
                    OleDbDataAdapter adp2 = new OleDbDataAdapter(sql4, conn);
                    OleDbCommand cmd = new OleDbCommand("", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp2.Fill(ds, "Student");
                    string sid = ds.Tables["Student"].Rows[0]["StudentID"].ToString();
                    ds.Clear();
                    adp1.Fill(ds, "QA");
                    string qaid = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString();
                    string sqldelete = "delete * from QAS where QAID = '" + qaid + "' and StudentID = '" + sid  + "'";
                    cmd.CommandText = sqldelete;
                    cmd.ExecuteNonQuery();
                    string sqlcount = "select * from QAS where QAID = '" + qaid + "'";
                    OleDbDataAdapter adp3 = new OleDbDataAdapter(sqlcount, conn);
                    ds.Clear();
                    adp3.Fill(ds, "QAS");
                    string sqlupdate = "update QA set Num = " + ds.Tables["QAS"].Rows.Count + " where QAID = '" + qaid + "'";                   
                    cmd.CommandText = sqlupdate;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功", "提示");
                    datagridrefresh2();
                }
            }
            else
            {
                MessageBox.Show("没有可删除的记录！", "提示");
            }
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            datagridrefresh1();
            this.toolStripLabel7.Enabled = true;
            this.toolStripLabel8.Enabled = true;
            this.toolStripLabel9.Enabled = true;
            this.toolStripLabel10.Enabled = true;
            this.toolStripLabel11.Enabled = true;
            this.toolStripLabel12.Enabled = true;
            this.toolStripLabel13.Enabled = true;
            this.toolStripLabel14.Enabled = false;
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            this.toolStripLabel7.Enabled = true;
            this.toolStripLabel8.Enabled = true;
            this.toolStripLabel9.Enabled = true;
            this.toolStripLabel10.Enabled = true;
            this.toolStripLabel11.Enabled = true;
            this.toolStripLabel12.Enabled = false;
            this.toolStripLabel13.Enabled = false;
            this.toolStripLabel14.Enabled = false;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sqltoday = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 1 and Date = #"
                + DateTime.Now.ToShortDateString() + "# and Teacher.TeacherID in ( select TeacherID from Teacher where UserName = '"
                + globalvariables.name + "' ) ";
            OleDbDataAdapter adp = new OleDbDataAdapter(sqltoday, conn);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "QA");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
            dataGrid1.CaptionText = "今天要完成的预约如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            this.toolStripLabel7.Enabled = true;
            this.toolStripLabel8.Enabled = true;
            this.toolStripLabel9.Enabled = true;
            this.toolStripLabel10.Enabled = false;
            this.toolStripLabel11.Enabled = true;
            this.toolStripLabel12.Enabled = false;
            this.toolStripLabel13.Enabled = false;
            this.toolStripLabel14.Enabled = true;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sqldeletedqa = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 0 and Date > #"
                + DateTime.Now.ToShortDateString() + "# and Teacher.TeacherID in ( select TeacherID from Teacher where UserName = '"
                + globalvariables.name + "' ) ";
            OleDbDataAdapter adp = new OleDbDataAdapter(sqldeletedqa, conn);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "QA");
            dataGrid1.ReadOnly = true;
            dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
            dataGrid1.CaptionText = "已删除的预约信息如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            this.toolStripLabel7.Enabled = true;
            this.toolStripLabel8.Enabled = true;
            this.toolStripLabel9.Enabled = true;
            this.toolStripLabel10.Enabled = false;
            this.toolStripLabel11.Enabled = true;
            this.toolStripLabel12.Enabled = false;
            this.toolStripLabel13.Enabled = false;
            this.toolStripLabel14.Enabled = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = dbConnection.connection;
                conn.Open();
                string sqlshow = "select QAID as 预约编号, QAS.StudentID as 学号, StudentName as 姓名 from QAS, Student where QAS.StudentID = Student.StudentID and QAID = '"
                    + ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString() + "'";
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlshow, conn);
                ds = new DataSet();
                ds.Clear();
                adp.Fill(ds, "QA");
                dataGrid1.ReadOnly = true;
                dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
                dataGrid1.CaptionText = "申请预约的名单如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
            }
            else
            {
                MessageBox.Show("没有可查看的记录！", "提示");
            }
        }

        private void toolStripLabel11_Click(object sender, EventArgs e)
        {
            Release release = new Release();
            release.ShowDialog();
        }

        private void toolStripLabel12_Click(object sender, EventArgs e)
        {
            ModifyQA modifyqa = new ModifyQA();
            if (ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("不可以修改当日的预约信息", "提示");
            }
            else
            {
                modifyqa.label2.Text = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString();
                modifyqa.comboBox1_Course.Text = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString();
                modifyqa.comboBox2_Place.Text = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString();
                modifyqa.comboBox3_Time.Text = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString();
                modifyqa.dateTimePicker1.Text = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString();
                modifyqa.ShowDialog();
                datagridrefresh1();
            }
        }

        private void toolStripLabel13_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("确实要删除此预约信息吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = dbConnection.connection;
                    conn.Open();
                    OleDbDataAdapter adp = new OleDbDataAdapter(sql2, conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "QA");
                    string qaid = ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString();
                    string sqlupdate = "update QA set Flag = 0 where QAID = '" + qaid + "'";
                    string sqldelete = "delete * from QAS where QAID = '" + qaid + "'";
                    if (ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString() == DateTime.Now.Date.ToString())
                    {
                        MessageBox.Show("不可以删除当日的预约信息", "提示");
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand("", conn);
                        cmd.CommandText = sqlupdate;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功", "提示");
                    }
                    datagridrefresh1();
                }
            }
            else
            {
                MessageBox.Show("没有可删除的预约信息！", "提示");
            }
        }

        private void toolStripLabel14_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("确实要恢复此预约信息吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlupdate = "update QA set Flag = 1 where QAID = '"
                        + ds.Tables["QA"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand("", conn);
                    cmd.CommandText = sqlupdate;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("恢复成功", "提示");
                    string sqldeletedqa = "select QAID as 预约编号, TeacherName as 教师, Course as 课程, Place as 地点, Date as 日期, Time as 时间, Num as 预约人数 from Teacher, QA where Teacher.TeacherID = QA.TeacherID and Flag = 0 and Date > #"
                        + DateTime.Now.ToShortDateString() + "# and Teacher.TeacherID in ( select TeacherID from Teacher where UserName = '"
                        + globalvariables.name + "' ) ";
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqldeletedqa, conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "QA");
                    dataGrid1.ReadOnly = true;
                    dataGrid1.DataSource = ds.Tables["QA"].DefaultView;
                    dataGrid1.CaptionText = "已删除的预约信息如下 共有" + ds.Tables["QA"].Rows.Count + "条记录";
                }
            }
            else
            {
                MessageBox.Show("没有可恢复的预约信息！", "提示");
            }
            
        }

        private void 添加学生用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.ShowDialog();
        }

        private void 添加教师用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher addteacher = new AddTeacher();
            addteacher.ShowDialog();
        }

        private void 删除学生用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deletestudent = new DeleteStudent();
            deletestudent.ShowDialog();
        }

        private void 删除教师用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTeacher deleteteacher = new DeleteTeacher();
            deleteteacher.ShowDialog();
        }

    }
}
