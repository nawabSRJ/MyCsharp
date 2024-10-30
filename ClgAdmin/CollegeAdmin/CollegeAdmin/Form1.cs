namespace CollegeAdmin
{
    // info :
    // database name : SAMPLE
    // tables : students , teachers , Courses , TeacherCourses
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
                Form2 fm = new Form2();
                fm.ShowDialog();
                this.Close();
            }
        }
    }
}
