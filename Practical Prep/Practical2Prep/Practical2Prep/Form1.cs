
using System.Data.SqlClient;
namespace Practical2Prep
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string query, str;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void readData()
        {
            str = "Data Source=SRJ18;Initial Catalog=SAMPLE;Integrated Security=True;";
            conn = new SqlConnection(str);
            query = "SELECT * FROM CUSTOMER";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        idBox.Items.Add(dr["id"].ToString());
                        nameBox.Items.Add(dr["name"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Rows");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Some error occured : {ex}");
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            readData();
        }
    }
}
