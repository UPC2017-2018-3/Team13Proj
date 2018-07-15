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
    public partial class Form1 : Form
    {
        public Form1()
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
                string sql = "select * from 员工 where 员工id='" + textBox1.Text + "'and 密码='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                { MessageBox.Show("账户或密码有误！"); }
            }
            catch(Exception a)
            {
                Console.WriteLine("{0} Second exception caught.", a); //发生错误后，抛出出错原因
                Console.ReadLine();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

    }

        private void button2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
