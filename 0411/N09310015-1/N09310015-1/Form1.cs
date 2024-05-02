using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310015_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";

            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
            label1.Text = "按鈕被按過了";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String count = label2.Text;
            int sum = Int32.Parse(count) + 1;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String count = label2.Text;
            int sum = Int32.Parse(count) - 1;
            label2.Text = sum.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int sum = a + b;
            label6.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 formBTN = new Form2();
            formBTN.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formTimer = new TimerForm();
            formTimer.Show();
        }
    }
}
