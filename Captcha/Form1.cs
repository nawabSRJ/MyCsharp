using Microsoft.Data.SqlClient;

namespace Captcha
{
    public partial class Form1 : Form
    {
        Sql sql;
        Captcha captcha;
        public Form1()
        {
            InitializeComponent();
            sql = new Sql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captcha = sql.fetchRandomCaptcha();
            pictureBox1.Image = Image.FromFile(captcha.Path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userCaptcha = textBox3.Text;

            if (username != "admin" || password != "admin")
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }
            if (userCaptcha != captcha.Text)
            {
                MessageBox.Show("Wrong Captcha Text");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                this.Form1_Load(sender, e);
                return;
            }

            MessageBox.Show("Login Successful");
        }

        
        private void validateSubmission()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validateSubmission();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validateSubmission();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validateSubmission();
        }
    }

    public class Sql
    {
        SqlConnection conn;
        string _connString;
        public int totalCaptchas;

        public Sql()
        {
            //_connString = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;"; ghar wali conn str
            _connString = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;";
            conn = new SqlConnection(_connString);
            totalCaptchas = fetchNoOfCaptchas();
        }

        private int fetchNoOfCaptchas()
        {
            string query = "select COUNT(*) from captcha;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            cmd.Dispose();
            return count;
        }

        public Captcha fetchRandomCaptcha()
        {
            Random random = new Random();
            int id = random.Next(totalCaptchas) + 1; //+1 coz I don't want zero index;

            string query = $"select * from captcha where id = {id};";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string text = reader["text"].ToString()!;
            string path = reader["path"].ToString()!;

            Captcha captcha = new Captcha(id.ToString(), text, path);
            conn.Close();
            cmd.Dispose();

            return captcha;
        }
    }

    public class Captcha
    {
        public string id;
        public string Text;
        public string Path;

        public Captcha(string id, string text, string path)
        {
            this.id = id;
            this.Text = text;
            this.Path = path;
        }
    }
}
