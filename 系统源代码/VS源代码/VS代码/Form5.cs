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
    public partial class Form5 : Form
    {
        public Form5()
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
                string sql = "select *  from 会员表 where 会员id='" + textBox1.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn = new SqlConnection(str);
            string sqltxt = string.Format("select 剩余积分 from 会员表");
            
            string sqlupdate = "update 会员表 set 剩余积分='"+textBox2.Text +"'where 会员id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";

            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            conn.Open();
            int n = 0;
            n = cmd.ExecuteNonQuery();
            if (n == 0)
            {
                MessageBox.Show("修改操作失败！");
                conn.Close();
                return;
            }
            else if (n > 0)
            {
                MessageBox.Show("修改操作成功!");
            }
           
            Refresh();
            string sqlstr = "insert into 记录表 (时间,会员id,事件类型,积分增减) values(@时间,@会员id,@事件类型,@积分增减)";
            SqlCommand mycom = new SqlCommand(sqlstr, conn);
            //添加参数 
            mycom.Parameters.Add(new SqlParameter("@时间", SqlDbType.DateTime, 5));
            mycom.Parameters.Add(new SqlParameter("@会员id", SqlDbType.Char, 10));
            mycom.Parameters.Add(new SqlParameter("@事件类型", SqlDbType.Char,100));
            mycom.Parameters.Add(new SqlParameter("@积分增减", SqlDbType.VarChar, 11));
            


            //给参数赋值 
           
            mycom.Parameters["@时间"].Value =DateTime.Now.ToString();
            mycom.Parameters["@会员id"].Value = textBox1.Text;
            mycom.Parameters["@事件类型"].Value = "消费";
            mycom.Parameters["@积分增减"].Value = textBox2.Text;
            
            //执行添加语句 
            mycom.ExecuteNonQuery();
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
