using System;
using System.IO;
using System.Threading;
using clsLib;

using System.Data.SqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, b;

            i = int.Parse("1");
            b = int.Parse(this.textBox1.Text.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.userControl11.GetData);

            clsTest LibTest = new clsTest();
            MessageBox.Show(LibTest.RunTest(1, 2).ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection DB = new SqlConnection();
            DB.ConnectionString = "Server=.; Database=master; User Id=sa; Password=vision21!;";

            SqlCommand CMD = DB.CreateCommand();

            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "SELECT GETDATE()";

            try
            {
                DB.Open();
                try
                {
                    MessageBox.Show(CMD.ExecuteScalar().ToString());
                }
                catch (Exception ex)
                {

                }
                DB.Close();

            } catch (Exception ex)
            {

            }

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
