using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310015_1
{
    public partial class TimerForm : Form
    {
        int second;
        public TimerForm()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //labell.Text= second.ToString()+"秒";
            label1.Text=string.Format("{0}秒", this.second);
            this.second++;
        }
    }
}
