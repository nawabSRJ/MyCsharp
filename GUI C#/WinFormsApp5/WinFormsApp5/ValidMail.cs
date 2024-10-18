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
    public partial class ValidMail : Form
    {
        public ValidMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            string email = textBox1.Text;
            if (email.Contains("@"))
            {
                label1.Text = "Valid Email";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Invalid Email";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
