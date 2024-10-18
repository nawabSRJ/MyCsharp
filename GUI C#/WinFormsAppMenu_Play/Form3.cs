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
    public partial class Form3 : Form
    {
        int ticker = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticker++;
            
            if(ticker < 3 )
            {
                // RED
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;
                button1.BackColor = Color.Red;
            }else if(ticker > 3 && ticker < 6)
            {
                // YELLOW
                button2.Visible = true;
                button3.Visible = false;
                button1.Visible = false;
                button2.BackColor = Color.Yellow;
            }else if(ticker > 6 && ticker < 9)
            {
                // GREEN
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button3.BackColor = Color.Green;
                
            }
            else if(ticker > 10)
            {
                ticker = 0;
            }
        }
    }
}
