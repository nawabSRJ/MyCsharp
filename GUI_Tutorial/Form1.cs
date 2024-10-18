namespace GUI_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string sub1, sub2, sub3;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 25; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBox1.Text) < 10)
            {

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
