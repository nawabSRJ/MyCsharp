using System.Data.SqlClient;


namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;";
            conn = new SqlConnection(str);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eid;
            string uname, ucity;
            eid = Convert.ToInt32(textBox1.Text);
            uname = textBox2.Text;
            ucity = textBox3.Text;
            string sql = $"insert into customers(id,name,city) values({eid},'{ uname}','{ ucity }')";
            // if something in string will be in string as same in sql, you need to add '' for varchar or other in sql
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Saved Successfully");

            }
            conn.Close();
            cmd.Dispose();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
