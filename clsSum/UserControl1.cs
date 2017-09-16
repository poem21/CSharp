using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clsSum
{
    public partial class UserControl1: UserControl
    {
        public string GetData
        {
            get { return this.textBox3.Text; }

        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text.ToString()) + int.Parse(textBox2.Text.ToString())).ToString();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
