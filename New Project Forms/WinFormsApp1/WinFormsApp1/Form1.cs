using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string sql, str;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            long d = r.NextInt64(4);
            int d1= Convert.ToInt32(d);
            MessageBox.Show(d1.ToString());
            str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;"; // connection string
            conn = new SqlConnection(str);
            sql = "select id , imgPath from ImgTab where id = " + d1 + " ";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read()) {
                string x = dr[1].ToString();    // ?
                pictureBox1.Image = Image.FromFile(x);
            }
            dr.Close();
            conn.Close();
            cmd.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
