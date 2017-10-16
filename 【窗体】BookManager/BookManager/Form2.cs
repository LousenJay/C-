﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /*设置为子窗口*/
        public Form MdiParent { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BID.Text.Trim() == "")
            {
                MessageBox.Show("请输入编号！");
            }
            else {
                string str = "server=localhost;database=BookManager;user=Lousen;password=1135497143";
                SqlConnection conn = new SqlConnection(str);    //创建连接数据库对象
                conn.Open(); //打开数据库连接
                string sql = "insert into Book(BID,BName,BAuthor,Bpublish,Bprice) values('" + BID.Text.Trim() + "','" + BName.Text.Trim() + "','" + BAuthor.Text.Trim() + "','" + Bpublish.Text.Trim() + "','" + Bprice.Text.Trim() + "')";  //SQL新增语句
                string sql_2 = "select * from Book where BID='" + BID.Text.Trim() + "'";  //查重
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);     //创建执行SQl命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);     //创建执行SQl命令对象
                SqlDataReader reader = cmd_2.ExecuteReader(); //datareader对象提供只读单向数据的快速传递
                if (reader.Read())
                {
                    MessageBox.Show("已存在编号！");
                }
                else {

                    reader.Close();
                    int row = cmd.ExecuteNonQuery();    //通过判断其返回值是否大于0来判断操作时候成功
                    if (row > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                }
                conn.Close();   //关闭数据库连接
            }
        }
    }
}
