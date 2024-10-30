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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ClgAdmin2
{
    // ------------------------------------- User Classes ---------------------------------------


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

        // add student button
        private void button1_Click(object sender, EventArgs e)
        {
            // validate -> push data to DB
            string name = stuName.Text;
            string email = stuEmail.Text;
            string phone = stuPhone.Text;
            if (stuGender.Text == "") throw new ValidationError("Select a Gender");
            string gender = stuGender.Text;
            string address = stuAddress.Text;
            DateTime dob = stuDOB.Value.Date;
            //string formattedDate = dob.ToString("dd-MM-yyyy"); // format the date 
            if (stuCourseBox.Text == "") throw new ValidationError("Select a Course");
            string course = stuCourseBox.Text;


            if (name == "" || address == "" || phone == "" || email == "")
            {
                throw new ValidationError("Fill out all details");
            }

            // push data :
            Sql dbops = new Sql();
            int id = dbops.insertStudent(new Student(name, phone, email, address, gender, dob, course));
            stuInfo.Visible = true;
            stuInfo.BackColor = Color.Green;
            stuInfo.Text = $"Student Added Successfully with id: {id}";

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // add values in different comboBoxes from DB

            // TASK 1 : adding courses in stuCourseBox from Courses Table
            Sql obj = new Sql();
            List<string> courseList = obj.getCourses();
            foreach (string course in courseList)
            {
                stuCourseBox.Items.Add(course);
            }

            // TASK 2 : adding courses in tchCourses groupBox from Courses Table
            int yPos = 10;  // Initial Y position for checkboxes inside the GroupBox
            foreach (string course in courseList)
            {
                CheckBox chkCourse = new CheckBox();
                chkCourse.Text = course;
                chkCourse.AutoSize = true;
                chkCourse.Location = new Point(10, yPos);
                yPos += 30;  // Increment Y position for the next checkbox

                tchCourses.Controls.Add(chkCourse);  // Add the CheckBox to the GroupBox
            }


        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            stuName.Clear();
            stuEmail.Clear();
            stuPhone.Clear();
            stuAddress.Clear();
            stuInfo.Text = "";
            stuInfo.Visible = false;
            // set ComboBox selections to -1 for reset
            stuGender.SelectedIndex = -1;
            stuCourseBox.SelectedIndex = -1;


            stuDOB.Value = DateTime.Now;

        }

        // Add teacher
        // Add teacher button
        private void button2_Click(object sender, EventArgs e)
        {
            // Validate and push data to DB for Teacher
            string name = tchName.Text;
            string email = tchEmail.Text;
            string phone = tchPhone.Text;
            if (tchGender.Text == "") throw new ValidationError("Select a Gender");
            string gender = tchGender.Text;
            string address = tchAddress.Text;
            DateTime dob = tchDOB.Value.Date;  // Only the date part needed

            if (name == "" || address == "" || phone == "" || email == "")
            {
                throw new ValidationError("Fill out all details");
            }

            // Get the selected courses from the groupBox (Task 1)
            List<string> selectedCourses = new List<string>();
            foreach (Control control in tchCourses.Controls)
            {
                if (control is CheckBox chkBox && chkBox.Checked)
                {
                    selectedCourses.Add(chkBox.Text);  // Add selected course to the list
                }
            }

            if (selectedCourses.Count == 0)
            {
                throw new ValidationError("Please select at least one course");
            }

            // Push teacher data into Teacher table (Task 2)
            Sql dbops = new Sql();
            int teacherId = dbops.insertTeacher(new Teacher(name, phone, email, address, gender, dob));

            // Automatically insert selected courses into TeacherCourses table (Task 3)
            dbops.insertTeacherCourses(teacherId, selectedCourses);  // Automatically handles the course insertion

            // Show success message
            teacherInfo.Visible = true;
            teacherInfo.BackColor = Color.Green;
            teacherInfo.Text = $"Teacher Added Successfully with ID: {teacherId}";
        }

        // clear button for Teacher
        private void button3_Click(object sender, EventArgs e)
        {
            tchName.Clear();
            tchEmail.Clear();
            tchPhone.Clear();
            tchAddress.Clear();
            teacherInfo.Text = "";
            teacherInfo.Visible = false;

            // set ComboBox selections to -1 for reset
            tchGender.SelectedIndex = -1;

            // Uncheck all checkboxes in the tchCourses groupBox
            foreach (Control control in tchCourses.Controls)
            {
                if (control is CheckBox chkBox)
                {
                    chkBox.Checked = false;  
                }
            }


            tchDOB.Value = DateTime.Now;

        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Course { get; set; }
        

        // constructor
        public Student(string name , string phone , string email , string address , string gender , DateTime dob , string course)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Gender = gender;
            this.DOB = dob;
            this.Course = course;
            
        }
    }

    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
       

        // constructor
        public Teacher(string name, string phone, string email, string address, string gender, DateTime dob)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Gender = gender;
            this.DOB = dob;
            
        }
    }

    public class Courses
    {
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        
        // constructor
        public Courses(int courseCode , string courseName) {
            this.CourseCode = courseCode;
            this.CourseName = courseName;
        }
    }
    public class TeacherCourses
    {
        public int TeacherID { get; set; }  // Foreign key from Teacher table
        public int CourseCode { get; set; }  // Foreign key from Courses table

        // constructor
        public TeacherCourses(int teacherId , int coursecode) {
            this .TeacherID = teacherId;
            this.CourseCode = coursecode;
        }
    }

    // ---------------------------------------------------------------------------------------

    class Sql
    {
        public string connStr = "";
        public SqlConnection conn;

        public Sql()
        {
            connStr = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
        }
        // get courses at form load
        public List<string> getCourses()
        {
            List<string> coursesList = new List<string>();  // Create a list to store course names
            string query = "SELECT CourseName FROM COURSES";  // SQL query to get course names
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();  

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coursesList.Add(reader["CourseName"].ToString());  // Add course name to the list
                }

                reader.Close();  
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();  
            }
            return coursesList;  
        }





        // add Records
        public int insertStudent(Student student)
        {
            //string dobFormatted = student.DOB.ToString("yyyy-MM-dd"); done direct
            string query = $"insert into Student (name, phone, email, address, gender, dob, course) values ('{student.Name}', '{student.Phone.ToString()}', '{student.Email}', '{student.Address}', '{student.Gender}', '{student.DOB.ToString("yyyy-MM-dd")}', '{student.Course}');" + "SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        public int insertTeacher(Teacher teacher)
        {
            string query = $"insert into Teacher (name, phone, email, address, gender, dob) values ('{teacher.Name}', '{teacher.Phone.ToString()}', '{teacher.Email}', '{teacher.Address}', '{teacher.Gender}', '{teacher.DOB.ToString("yyyy-MM-dd")}');" + "SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        // after teacher is added , then add the values in TeacherCourses Table:
        public void insertTeacherCourses(int teacherId, List<string> selectedCourses)
        {
            foreach (string courseName in selectedCourses)
            {
                // Insert the course into the Courses table if it doesn't exist
                string query = $"IF NOT EXISTS (SELECT 1 FROM Courses WHERE CourseName = '{courseName}') " +
                               $"INSERT INTO Courses (CourseName) VALUES ('{courseName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                // Get the CourseCode of the inserted course
                query = $"SELECT CourseCode FROM Courses WHERE CourseName = '{courseName}'";
                cmd = new SqlCommand(query, conn);
                int courseCode = (int)cmd.ExecuteScalar();

                // Insert into TeacherCourses table
                query = $"INSERT INTO TeacherCourses (TeacherID, CourseCode) VALUES ({teacherId}, {courseCode})";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        // search Records


    }

}
