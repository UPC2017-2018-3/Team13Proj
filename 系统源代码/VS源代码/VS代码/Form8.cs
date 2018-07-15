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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str3 = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn3 = new SqlConnection(str3);
            conn3.Open();
            try
            {

                string sqlstr = "insert into 会员表 (会员id,姓名,性别,联系方式,剩余积分) values(@会员id,@姓名,@性别,@联系方式,@剩余积分)";
                SqlCommand mycom = new SqlCommand(sqlstr,conn3);
                //添加参数 
                mycom.Parameters.Add(new SqlParameter("@会员id", SqlDbType.Char, 5));
                mycom.Parameters.Add(new SqlParameter("@姓名", SqlDbType.Char,10));
                mycom.Parameters.Add(new SqlParameter("@性别", SqlDbType.Char, 2));
                mycom.Parameters.Add(new SqlParameter("@联系方式", SqlDbType.VarChar, 11));
                mycom.Parameters.Add(new SqlParameter("@剩余积分", SqlDbType.VarChar, 11));


                //给参数赋值 
                mycom.Parameters["@会员id"].Value = textBox1.Text;
                mycom.Parameters["@姓名"].Value = textBox2.Text;
                mycom.Parameters["@性别"].Value = textBox3.Text;
                mycom.Parameters["@联系方式"].Value = textBox4.Text;
                mycom.Parameters["@剩余积分"].Value = textBox5.Text;
                //执行添加语句 
                mycom.ExecuteNonQuery();
                conn3.Close();

                MessageBox.Show("注册成功!");
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7= new Form7();
            f7.Show();
        }
    }
}
