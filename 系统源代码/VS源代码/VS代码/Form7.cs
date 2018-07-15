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
    public partial class Form7 : Form
    {
        public Form7()
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
                string sql = "select *  from 会员表";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn = new SqlConnection(str);


            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("所提供的数据不完整，请填写完整数据");
                return;
            }
            
            int n = 0;

             string sqlupdate = "update 会员表 set 姓名='" + textBox2.Text + "',性别='" +textBox3.Text + "',联系方式=" +textBox4.Text + ",剩余积分='" + textBox5.Text + "'where 会员id='" +  dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
             
             SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            conn.Open();
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
           conn.Close();
            Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "delete from 会员表 where 1=1";
             //如果选中某行则执行
            if (dataGridView1.CurrentRow.Selected)
            {
                 sql = sql + " and 会员id=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            int n = 0;
            //创建连接数据库对象
            string str = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn = new SqlConnection(str);
             //创建操作数据库对象
             SqlCommand cmd = new SqlCommand(sql, conn);
            //打开数据库
           conn.Open();
            //取得ExecuteNonQuery返回的受影响行数，无影响则为0
           n = cmd.ExecuteNonQuery();
             if (n == 0)
             {
                 MessageBox.Show("删除操作失败!不存在的ID");
                conn.Close();
                return;
           }
            else if (n > 0)
          {
             MessageBox.Show("删除操作成功!");
         }
         //关闭数据库连接
          conn.Close();
            //刷新数据界面
          Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
