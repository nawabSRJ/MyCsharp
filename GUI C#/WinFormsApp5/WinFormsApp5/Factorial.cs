using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int ans = factorialCheck(n);
            label1.Enabled = true;
            label1.ForeColor = Color.Green;
            label1.Text = ans.ToString();
        }
        int factorialCheck(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorialCheck(n-1);
            }
        }
    }
}
