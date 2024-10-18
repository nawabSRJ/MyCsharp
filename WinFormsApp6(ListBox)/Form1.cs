namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Lucknow");
            listBox1.Items.Add("Noida");
            listBox1.Items.Add("Mumbai");
            listBox1.Items.Add("Delhi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;


        }

        private void button2_Click(object sender, EventArgs e)//delete butoon
        {
            string remPlace = listBox1.Text;
            listBox1.Items.Remove(remPlace);
            label1.Text = "Item deleted successfully";
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)//add button
        {
            string addPlace = textBox1.Text;
            listBox1.Items.Add(addPlace);
            label1.Text = "Item added successfully";
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)//delete all
        {
            listBox1.Items.Clear();
        }
    }
}
