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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp5
{
    public partial class Armstrong : Form
    {
        public Armstrong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Enabled = true;
            int n = Convert.ToInt32(txtBox1.Text);
            int d = 0;
            int g = Convert.ToInt32(n);
            while (g > 0)
            {
                d++;
                g = g / 10;
            }
            int s = 0;
            while (n > 0)
            {
                s = s + Convert.ToInt32(Math.Pow(n % 10, d));
                n = n / 10;
            }
            n = Convert.ToInt32(txtBox1.Text);
            if (n == s)
            {
                lbl1.Text = "Armstrong number";
                lbl1.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbl1.Text = "Not armstrong";
                lbl1.ForeColor = Color.Red;
            }
            
        }
    }
}
