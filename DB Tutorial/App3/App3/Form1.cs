using System.Data.SqlClient;
namespace App3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string query = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True;";
            conn = new SqlConnection(str);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u, p;
            u = textBox1.Text;
            p = textBox2.Text;
            query = "select * from auth where uname = '" + u + "' and pwd = '" + p + "'";
            cmd = new SqlCommand(query, conn);
            conn.Open();

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

        }
    }
}
