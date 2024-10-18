using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMenu_Play
{
    public partial class Form2 : Form
    {
        public int num;
        public Form2(int num)
        {
            InitializeComponent();
            this.num = 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = num.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label1.Visible = false;
            }
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                num--;
                label1.Visible = true;
                label1.Text = num.ToString();
            }
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
    }
}
