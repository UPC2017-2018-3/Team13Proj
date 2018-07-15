using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EducationSystem
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn = new SqlConnection(str);


            try
            {
                conn.Open();
                string sql = "select *  from 记录表 ";//where 员工id=" + textBox1.Text + "'and 密码='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;


            }
            catch (Exception a)
            {

            }
        }
    }
}
