using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeAdmin
{
    // class for display records thing : 
    public class Record
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string query = "";

        // for form3 to display records : 
        List<Record> records = new List<Record>();
        public int currentRecordIndex = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void roleBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleBox1.SelectedItem == "Student")
            {
                // set this false : 
                groupBox1.Enabled = false;
                groupBox1.Visible = false;

                // set this true : 
                groupBox2.Enabled = true;
                groupBox2.Visible = true;

            }
            else if (roleBox1.SelectedItem == "Teacher")
            {
                // set this false : 
                groupBox2.Enabled = false;
                groupBox2.Visible = false;

                // set this true : 
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
            }
        }

        // for choosing course : 
        // groupBox2 -> Student
        // groupBox1 -> Teacher
        private void button1_Click(object sender, EventArgs e)
        {
            // here goes the add record submit
            string id = idBox.Text;
            string name = nameBox.Text;
            string course = "";
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            conn.Open();


            // based on role box value -> entry is done
            if (roleBox1.SelectedItem == "Student")
            {
                // entry in student table

                // course selected: 
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is RadioButton rdBtn && rdBtn.Checked)
                    {
                        course = rdBtn.Text;
                    }
                }

                query = $"INSERT INTO STUDENT VALUES ({id},'{name}','{course}')";
                cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Record Saved Successfully", "Information");
                }
            }
            else if (roleBox1.SelectedItem == "Teacher")
            {
                // entry in teacher table + courses + teacherCourses table

                query = $"INSERT INTO TEACHERS VALUES ({id},'{name}')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                // Task 1: Create a list to store selected courses
                List<string> selectedCourses = new List<string>();

                // Task 2: Check each checkbox in groupBox1 to see which courses are selected
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox chkBox && chkBox.Checked)
                    {
                        selectedCourses.Add(chkBox.Text);  // Add the course name (from checkbox text) to the list
                    }
                }

                // Task 3: Insert records into Courses and TeacherCourses tables
                foreach (string selectedCourse in selectedCourses)
                {
                    // this will insert iff the course dosen't exist
                    query = $"IF NOT EXISTS (SELECT 1 FROM COURSES WHERE CourseName = '{selectedCourse}') " +
                            $"INSERT INTO COURSES (CourseName) VALUES ('{selectedCourse}')";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    // get the courseID for Next table insertion 
                    query = $"SELECT CourseID FROM COURSES WHERE CourseName = '{selectedCourse}'";
                    cmd = new SqlCommand(query, conn);
                    int courseId = (int)cmd.ExecuteScalar();

                    // Insert into TeacherCourses table to link the teacher and course
                    query = $"INSERT INTO TeacherCourses (TeacherID, CourseID) VALUES ({id}, {courseId})";
                    cmd = new SqlCommand(query, conn);

                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Record Saved Successfully", "Information");
                    }

                }
            }

            conn.Close();

        }

        // ---------------------------------------------------------------------------------------
        // search button
        private void searchBox2_Enter(object sender, EventArgs e)
        {
            string searchMetric = searchBox.Text;
            string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);

            string table = "", method = "";
            string query = "";

            // For method selection (set method before constructing the query):
            if (methodBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a search method (ID Wise or Name Wise)");
                return;
            }

            if (methodBox1.SelectedItem.ToString() == "ID Wise")
            {
                method = "ID";
            }
            else if (methodBox1.SelectedItem.ToString() == "Name Wise")
            {
                method = "Name";
            }

            // For table selection (construct query only after method is set):
            if (roleBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a role (Student or Teacher)");
                return;
            }

            if (roleBox2.SelectedItem.ToString() == "Student")
            {
                table = "Student";
                query = $"SELECT ID, Name, Course FROM {table} WHERE {method} = @searchMetric";
            }
            else if (roleBox2.SelectedItem.ToString() == "Teacher")
            {
                table = "Teachers";
                query = $"SELECT ID, Name FROM {table} WHERE {method} = @searchMetric";
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Query could not be constructed.");
                return;
            }

            try
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchMetric", searchMetric);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string courses = "";
                            if (roleBox2.SelectedItem.ToString() == "Student")
                            {
                                courses = dr["Course"].ToString();
                            }

                            records.Add(new Record
                            {
                                ID = dr["ID"].ToString(),
                                Name = dr["Name"].ToString(),
                                Course = courses
                            });
                        }
                        put_records(currentRecordIndex);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to open the connection.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (NullReferenceException nullEx)
            {
                MessageBox.Show("Null Reference Error: " + nullEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }





        // Function to display records on Form3
        private void put_records(int index)
        {
            if (index >= 0 && index < records.Count)
            {
                Form3 form3 = new Form3();

                // Set the text fields with the record values
                form3.Controls["idBox"].Text = records[index].ID;
                form3.Controls["nameBox"].Text = records[index].Name;
                form3.Controls["courseBox"].Text = records[index].Course;
                form3.Controls["recordNoLbl"].Text = $"Record No: {index + 1} / {records.Count}";

                // Enable or disable Prev/Next buttons based on the current index
                form3.Controls["prevBtn"].Enabled = index > 0;
                form3.Controls["nextBtn"].Enabled = index < records.Count - 1;

                form3.ShowDialog();
            }
        }

        // Event for Next button on Form3
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentRecordIndex < records.Count - 1)
            {
                currentRecordIndex++;
                put_records(currentRecordIndex);
            }
        }

        // Event for Prev button on Form3
        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentRecordIndex > 0)
            {
                currentRecordIndex--;
                put_records(currentRecordIndex);
            }
        }

        // on form load : 
        private void Form2_Load(object sender, EventArgs e)
        {
            if (methodBox1.SelectedItem != null)
            {
                searchBox.Enabled = true;
                // now change the label acc. to method : 

                if (methodBox1.SelectedItem == "ID Wise")
                {
                    metricLbl.Text = "ID : ";
                }
                else if (methodBox1.SelectedItem == "Name Wise")
                {
                    metricLbl.Text = "Name : ";
                }
            }
        }

        private void methodBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Enabled = true;
        }
    }
}
