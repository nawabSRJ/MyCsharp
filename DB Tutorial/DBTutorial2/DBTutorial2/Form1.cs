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
        bool isUpdating = false;
        bool isInserting = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void setListBox1()
        {
            // also used to refresh the listbox after addition or deletion of records
            // clear initially
            listBox1.Items.Clear();
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            sqlQuery = "select id from employees";
            conn = new SqlConnection(str);
            cmd = new SqlCommand(sqlQuery, conn);


            conn.Open();
            dr = cmd.ExecuteReader();
            // here will be coding for listBox
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0]);
                }
            }
            dr.Close();
            conn.Close();
            cmd.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setListBox1();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // display details in textBoxes
            //string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;"; clg wli
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";  // ghar wli
            string id = Convert.ToString(listBox1.SelectedItem);
            sqlQuery = $"select * from employees where id = {id}";
            conn = new SqlConnection(str);
            cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) // Moves to the first row
            {
                // Populate text boxes with data from reader
                idBox.Text = dr["ID"].ToString();
                nameBox.Text = dr["NAME"].ToString();
                cityBox.Text = dr["CITY"].ToString();
            }
            else
            {
                MessageBox.Show("Data corresponding to ID clicked not found.");
            }


            // clean up
            dr.Close();
            conn.Close();
            cmd.Dispose();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // update button
        private void button3_Click(object sender, EventArgs e)
        {
            // only update name and city
            isUpdating = true;

            nameBox.Enabled = true;
            cityBox.Enabled = true;
            button3.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        // commit button
        private void CommitChanges(string operationType)
        {
            string currid = idBox.Text;
            string newName = nameBox.Text;
            string newCity = cityBox.Text;
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";  // Connection string
            string sqlQuery = "";

            if (operationType == "update")
            {
                sqlQuery = $"UPDATE employees SET name = '{newName}', city = '{newCity}' WHERE id = {currid}";
            }
            else if (operationType == "insert")
            {
                sqlQuery = $"INSERT INTO employees VALUES ({currid}, '{newName}', '{newCity}')";
            }
            else
            {
                MessageBox.Show("Invalid operation type.");
            }
            conn = new SqlConnection(str);
            cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show($"{r} record(s) {operationType} Changed.");
            }
            else
            {
                MessageBox.Show($"No Change");
            }
            conn.Close();
            cmd.Dispose();
            // Disable the buttons and text boxes after committing
            button6.Enabled = false; // commit btn
            button7.Enabled = false; // cancel btn
            idBox.Enabled = false;
            nameBox.Enabled = false;
            cityBox.Enabled=false;

            setListBox1(); // reset the listBox after addition / deletion
        }

        // commit button
        private void button7_Click(object sender, EventArgs e)
        {
            if (isUpdating) {
                CommitChanges("update");
                button3.Enabled = true;
                isUpdating = false;
            }
            if (isInserting)
            {
                CommitChanges("insert");
                isInserting = false;
            }
            
        }

        // cancel button
        private void button6_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex = -1;    // text boxes will automatically affect
            //listBox1.ClearSelected();
            idBox.Text = "";
            nameBox.Text = "";
            cityBox.Text = "";
            nameBox.Enabled = false;
            cityBox.Enabled = false;
            button3.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;



        }

        // delete button
        private void button4_Click(object sender, EventArgs e)
        {
            string currid = idBox.Text;
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";  // ghar wli
            sqlQuery = $"delete from employees WHERE id = {currid}";
            conn = new SqlConnection(str);
            cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show($"{r} record(s)updated");
            }
            else
            {
                MessageBox.Show($"No Change");
            }
            conn.Close();
            cmd.Dispose();

            // to change the list box items after deletion :
            setListBox1();


        }

        // new button
        private void button5_Click(object sender, EventArgs e)
        {
            isInserting = true;
            button6.Enabled = true;
            button7.Enabled = true;

            // Clear the text boxes for new entry
            idBox.Clear();
            nameBox.Clear();
            cityBox.Clear();

            // Enable the text boxes for input
            idBox.Enabled = true;
            nameBox.Enabled = true;
            cityBox.Enabled = true;

            //CommitChanges("insert");
        }
    }
}
