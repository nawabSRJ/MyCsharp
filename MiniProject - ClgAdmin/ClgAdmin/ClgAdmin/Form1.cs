namespace ClgAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form2 fm2 = new Form2();
                fm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }
    }
}
