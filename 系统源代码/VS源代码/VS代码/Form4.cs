﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str3 = "Server =192.168.137.1;database = 会员管理系统1.0;uid = muyeweixi;pwd =muyeweixi";
            SqlConnection conn3 = new SqlConnection(str3);
            conn3.Open();
            try
            {

                string sqlstr = "insert into 员工 (员工id,姓名,性别,密码,联系方式) values(@员工id,@姓名,@性别,@密码,@联系方式)";
                SqlCommand mycom = new SqlCommand(sqlstr, conn3);
                //添加参数 
                mycom.Parameters.Add(new SqlParameter("@员工id", SqlDbType.VarChar, 50));
                mycom.Parameters.Add(new SqlParameter("@姓名", SqlDbType.VarChar, 50));
                mycom.Parameters.Add(new SqlParameter("@性别", SqlDbType.Char, 8));
                mycom.Parameters.Add(new SqlParameter("@密码", SqlDbType.Char, 10));
                mycom.Parameters.Add(new SqlParameter("@联系方式", SqlDbType.Char, 20));


                //给参数赋值 
                mycom.Parameters["@员工id"].Value = textBox1.Text;
                mycom.Parameters["@姓名"].Value = textBox2.Text;
                mycom.Parameters["@性别"].Value = textBox3.Text;
                mycom.Parameters["@密码"].Value = textBox4.Text;
                mycom.Parameters["@联系方式"].Value = textBox5.Text;
                //执行添加语句 
                mycom.ExecuteNonQuery();
                conn3.Close();
           
                MessageBox .Show ("注册成功!");
                Form1 f1 = new Form1();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

       
    }
}


