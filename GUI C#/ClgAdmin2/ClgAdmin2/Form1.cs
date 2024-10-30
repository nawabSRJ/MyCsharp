using System.Text.RegularExpressions;

namespace ClgAdmin2
{
    public partial class Form1 : Form
    {
        int loginAttempts = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // LOGIN BUTTON
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form2 fm2 = new Form2();
                //fm2.MdiParent = this;   
                //fm2.Show();

                fm2.ShowDialog();
                this.Close();
            }
            else if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter all the details.");
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Maximum login attempts reached. Close...");
                    Application.Exit(); // Closes the application after 3 failed attempts
                }
                else
                {
                    MessageBox.Show("Wrong Credentials");
                }
            }
        }
    }

    public class ValidationError : Exception
    {
        public ValidationError(string message) : base(message)
        {
        }

        //method to check if phone number is valid
        public static void IsValidPhNo(string number)
        {
            if (number.Length != 10) throw new ValidationError($"Phone number length should be 10 digits");
            if (!number.All(char.IsDigit)) throw new ValidationError("Invalid Number");
        }

        //method to check if email is valid
        public static void IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                throw new ValidationError("Invalid Email");
            }
        }
    }
}
