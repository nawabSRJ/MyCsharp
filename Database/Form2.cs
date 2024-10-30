using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string query = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            query = "SELECT ID FROM EMPLOYEES";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader records = cmd.ExecuteReader();
            if (records.HasRows)
            {
                while (records.Read())
                {
                    listBox1.Items.Add(records["ID"].ToString()); // Adding id to listbox
                }
            }
            else
            {
                listBox1.Items.Add("Empty");
            }
            records.Close();
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosen = listBox1.SelectedItem.ToString();
            query = $"SELECT ID,NAME,CITY FROM EMPLOYEES WHERE ID = {Convert.ToInt32(chosen)}";
            // PUT NAME
            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows) { 
                textBox1.Text = read["ID"].ToString();
                textBox2.Text = read["Name"].ToString();
                textBox3.Text = read["City"].ToString();
            }
            read.Close();
            conn.Close();
        }
    }
}
