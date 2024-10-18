namespace QuizApp
{
    public partial class Form1 : Form
    {
        string[] subjects = new string[3];  // array to store subject names
        int setFlag = 0;
        int setAgeGrp = -1; // by default
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 25; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFlag++;
            if (Convert.ToInt32(comboBox1.Text) >= 1 && Convert.ToInt32(comboBox1.Text) <= 10)
            {
                subjects[0] = "English";
                subjects[1] = "EVS";
                subjects[2] = "SST";
                setAgeGrp = 1;
            }
            else if (Convert.ToInt32(comboBox1.Text) > 10 && Convert.ToInt32(comboBox1.Text) <= 20)
            {
                subjects[0] = "Organic Chem";
                subjects[1] = "Physics";
                subjects[2] = "Biology";
                setAgeGrp = 2;
            }
            else if (Convert.ToInt32(comboBox1.Text) > 20 && Convert.ToInt32(comboBox1.Text) <= 25)
            {
                subjects[0] = "Data Analytics";
                subjects[1] = "Blockchain";
                subjects[2] = "Artificial Intelligence";
                setAgeGrp = 3;
            }

            if (setFlag == 1)
            {
                foreach (string s in subjects)
                {
                    comboBox2.Items.Add(s);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fill = 0;
            // display Form2 on submit 
            Form2 fm2 = new Form2();
            fm2.ageGrp = setAgeGrp;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                fill++;
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                fill++;
            }
            if (fill == 2)
            {
                fm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill the form", "Warning!!");
            }
        }
    }
}
