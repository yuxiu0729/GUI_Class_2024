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
    public partial class FormTimer : Form
    {
        public int second;
        public FormTimer()
        {
            InitializeComponent();
            second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", second);
            second++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = String.Format("{0}秒", second);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            second = 0;
            label1.Text = String.Format("{0}秒", second);
        }
    }
}
