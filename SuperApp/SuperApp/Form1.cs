namespace SuperApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // sign in button
        private void button1_Click(object sender, EventArgs e)
        {
            if(userName.Text == "srj18" && userPass.Text == "123")
            {
                Form2 fm = new Form2();
                fm.ShowDialog();
            }
        }
    }
}
