namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()  // constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e) // event 
        {
            int a, b, c;
            button1.Text = "Add";
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter Value 1 ";
            label2.Text = "Enter Value 2 ";
        }
    }
}
