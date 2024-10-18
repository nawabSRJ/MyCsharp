namespace WinFormsApp5
{
    public partial class Prime : Form
    {
        public Prime()
        {
            InitializeComponent();
        }

        private void Prime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Enabled = true;
            int num = Convert.ToInt32(txtBox1.Text);
            if (check(num))
            {
                lbl1.Text = "Prime Number";
                lbl1.ForeColor = Color.Green;
            }
            else
            {
                lbl1.Text = "Not prime";
                lbl1.ForeColor = Color.Red;
            }
        }
        public bool check(int n)
        {
            if (n < 1)
            {
                return false;
            }
            if (n == 1 || n == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i * i < n + 1; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
