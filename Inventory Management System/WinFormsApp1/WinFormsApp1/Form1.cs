using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string query, str;
        int carCount = 0, roadCount = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load captcha

        }
        private void LoadCaptcha()
        {
            long d = r.NextInt64(4);
            int d1 = Convert.ToInt32(d);
            
            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            query = "SELECT ImgName , ImgPath FROM ImageCaptcha";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            List<string> captchaImages = new List<string>();
            while (dr.Read())
            {
            
                string path = dr["ImgPath"].ToString();
                string name = dr["ImgName"].ToString();
                if (name == "Car")
                {
                    carCount++;
                    captchaImages.Add(path);
                    
                }
                else if (name == "Road")
                {
                    roadCount++;
                    captchaImages.Add(path);
                }
                if (carCount == 3 && roadCount == 3)
                {
                    break;
                }             

            }
            dr.Close();
            conn.Close();
            cmd.Dispose();

            // adding images to pictureBoxes
            pictureBox1.Image = Image.FromFile(captchaImages.ElementAt(0));
            pictureBox2.Image = Image.FromFile(captchaImages.ElementAt(1));
            pictureBox3.Image = Image.FromFile(captchaImages.ElementAt(2));
            pictureBox4.Image = Image.FromFile(captchaImages.ElementAt(3));
            pictureBox5.Image = Image.FromFile(captchaImages.ElementAt(4));
            pictureBox6.Image = Image.FromFile(captchaImages.ElementAt(5));
        }

        // submit button on the login page
        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "admin" && passwdBox.Text == "admin")
            {
                
                Form2 fm2 = new Form2();
                fm2.ShowDialog();
                

                // show captcha
                LoadCaptcha();
                captchaBox1.Visible = true;


            }
        }

        // show password checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwdBox.PasswordChar = '\0'; // null character
            }
            else if (!checkBox1.Checked)
            {
                passwdBox.PasswordChar = '*';
            }
        }

        // validate captcha answer
        private void button2_Click(object sender, EventArgs e)
        {
            int user_ans = Convert.ToInt32(captchaAnswer.Value);
            if(user_ans == carCount)
            {
                MessageBox.Show("Right Answer");
                // load Dashboard 
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                // One more chance and back to login
            }

        }
    }
}
