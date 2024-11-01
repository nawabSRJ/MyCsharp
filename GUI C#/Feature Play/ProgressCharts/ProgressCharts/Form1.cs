namespace ProgressCharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // show different completion in progress bars
            pBar1.Minimum = 0;
            pBar1.Maximum = 100;
            pBar1.Value = 100;
            pBar1.Height = 20;

            pBar2.Minimum = 0;
            pBar2.Maximum = 100;
            pBar2.Value = 50;
            pBar1.Height = 40;


            pBar3.Height = 20;

            pBar3.Value = 100;

            pBar4.Height = 10;
        }

        private void pBar4_Click(object sender, EventArgs e)
        {

        }
    }
}
