using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace ClgAdmin
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

        private void roleBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roleBox1.SelectedItem == "Student")
            {
                // set this false : 
                teacherBox.Enabled = false;
                teacherBox.Visible = false;

                // set this true : 
                studentBox.Enabled = true;
                studentBox.Visible = true;

            }
            else if (roleBox1.SelectedItem == "Teacher")
            {
                // set this false : 
                studentBox.Enabled = false;
                studentBox.Visible = false;

                // set this true : 
                teacherBox.Enabled = true;
                teacherBox.Visible = true;
            }
        }

        // submit button in add records
        // ? add validation of all entries done
        private void button1_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string name = nameBox.Text;
            string course = "";
            // string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;"; ghar wali conn str
            string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;";  //clg wli conn str 
            conn = new SqlConnection(str);
            conn.Open();


            // based on role box value -> entry is done
            if (roleBox1.SelectedItem == "Student")
            {
                // entry in student table

                // course selected: 
                foreach (Control control in studentBox.Controls)
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
                foreach (Control control in teacherBox.Controls)
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


        // --------------------------------- Search Records Logic ---------------------------------

        // common function for comboBox state change
        private void changeState()
        {
            
            if (roleBoxSearch.SelectedItem != null && methodBoxSearch.SelectedItem != null)
            {
                searchBox.Enabled = true;  // Enable searchBox

                
                if (methodBoxSearch.SelectedItem.ToString() == "ID")
                {
                    searchMetricLbl.Text = "ID:";
                }
                else if (methodBoxSearch.SelectedItem.ToString() == "NAME")
                {
                    searchMetricLbl.Text = "Name:";
                }
            }
        }
        private void methodBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeState();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            changeState();
        }


        

        // search function button
        private void button2_Click(object sender, EventArgs e)
        {

            //string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            string str = "Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=SAMPLE;Integrated Security=True;";  //clg wli conn str 

            string role = roleBoxSearch.SelectedItem?.ToString(); // gets selected role
            string searchMethod = methodBoxSearch.SelectedItem?.ToString(); // gets search method 
            string searchValue = searchBox.Text;

            // Validation :  if all values are selected
            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(searchMethod) || string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please select role, method, and enter a search value.");
                return;
            }

            // SQL query and table selection based on role
            string query = "";
            if (role == "Student")
            {
                if (searchMethod == "ID")
                {
                    query = "SELECT ID, NAME, COURSE FROM Student WHERE ID = @SearchValue";
                }
                else if (searchMethod == "Name")
                {
                    // discuss : 
                    // query = "SELECT ID, NAME, COURSE FROM Student WHERE NAME = @SearchValue";
                    query = "SELECT ID, NAME FROM Student WHERE NAME LIKE @SearchValue";
                }
            }
            else if (role == "Teacher")
            {
                if (searchMethod == "ID")
                {
                    query = "SELECT ID, NAME FROM Teachers WHERE ID = @SearchValue";
                }
                else if (searchMethod == "Name")
                {
                    // discuss : 
                    //query = "SELECT ID, NAME FROM Teachers WHERE NAME = @SearchValue";
                    query = "SELECT ID, NAME FROM Teachers WHERE NAME LIKE @SearchValue";
                }
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please select a valid role (Student or Teacher).");
                return;
            }

            // DB Operations :
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                if (role == "Student")
                                {
                                    idResult.Text = reader["ID"].ToString();
                                    nameResult.Text = reader["NAME"].ToString();
                                    courseResult.Text = reader["COURSE"].ToString();
                                }

                                else if (role == "Teacher")
                                {
                                    idResult.Text = reader["ID"].ToString();
                                    nameResult.Text = reader["NAME"].ToString();
                                    courseResult.Text = getCourses(Convert.ToInt32(idResult.Text)); // passing teacher ID
                                }
                            }
                            else
                            {

                                MessageBox.Show("No records found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        // Function to retrieve the courses of the teacher
        private static string getCourses(int teacherId)
        {
            string connectionString = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            string courses = "";

            // SQL query to join TeacherCourses with Courses to get course names
            string query = "SELECT c.CourseName FROM TeacherCourses tc JOIN Courses c ON tc.CourseID = c.CourseID WHERE tc.TeacherID = @TeacherID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", teacherId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> courseList = new List<string>();

                            
                            while (reader.Read())
                            {
                                courseList.Add(reader["CourseName"].ToString());
                            }

                            
                            courses = string.Join(", ", courseList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return courses;
        }



    }
}
