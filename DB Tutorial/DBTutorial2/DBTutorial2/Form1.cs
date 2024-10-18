using System.Data.SqlClient;
namespace DBTutorial2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sqlQuery;



        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True;Trust Server Certificate=True";
            cmd = new SqlCommand(str);
            sqlQuery = "select id from customers";
            conn.Open();
            dr = cmd.ExecuteReader();
            // here will be coding for listBox

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
