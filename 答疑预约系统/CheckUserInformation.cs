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
    public partial class CheckUserInformation : Form
    {
        public CheckUserInformation()
        {
            InitializeComponent();
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = dbConnection.connection;
            conn.Open();
            string sql1 = "select * from Student where UserName = '" + globalvariables.name + "'";
            string sql2 = "select * from Teacher where UserName = '" + globalvariables.name + "'";
            string sql3 = "select * from Manager where UserName = '" + globalvariables.name + "'";
            if (globalvariables.f == 1) 
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql1, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Student");
                this.label4.Text = ds.Tables["Student"].Rows[0]["StudentName"].ToString();
                this.label5.Text = ds.Tables["Student"].Rows[0]["StudentID"].ToString();
                this.label6.Text = ds.Tables["Student"].Rows[0]["UserName"].ToString();
            }
            if (globalvariables.f == 2) 
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql2, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Teacher");
                this.label4.Text = ds.Tables["Teacher"].Rows[0]["TeacherName"].ToString();
                this.label5.Text = ds.Tables["Teacher"].Rows[0]["TeacherID"].ToString();
                this.label6.Text = ds.Tables["Teacher"].Rows[0]["UserName"].ToString();
            }
            if (globalvariables.f == 3)
            {
                OleDbDataAdapter adp = new OleDbDataAdapter(sql3, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Manager");
                this.label4.Text = ds.Tables["Manager"].Rows[0]["ManagerName"].ToString();
                this.label5.Text = ds.Tables["Manager"].Rows[0]["ManagerID"].ToString();
                this.label6.Text = ds.Tables["Manager"].Rows[0]["UserName"].ToString();
            }
        }
    }
}
