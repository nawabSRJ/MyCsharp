using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperApp
{
    public partial class Form2 : Form
    {
        // ---------------------------- Stopwatch
        public bool isActive = false;
        public int timeMs, timeS, timeMin;
        // ---------------------------------- Todo : 
        public int taskCount = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("Enter the file name:", "File Name", "default.txt");
            StreamWriter sw = new StreamWriter($"E:\\C# SEM 5\\SuperApp\\{fileName}");
            string data = richTextBox1.Text;
            sw.WriteLine(data);
            sw.Flush();// To write in output stream
            sw.Close();// To close the stream

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        // start button
        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            timeMs = 0;
            timeS = 0;
            timeMin = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isActive = false;
            stopWatchLbl.Text = "00:00:00";
        }

        private void stopWatchLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeMs++; // in milliseconds
                if (timeMs >= 100)
                {
                    timeS++; // in seconds
                    timeMs = 0;

                    if (timeS >= 60)
                    {
                        timeMin++;
                        timeS = 0;
                    }
                }
            }

            // change time in label
            stopWatchLbl.Text = String.Format("{00:00:00}", timeMin, timeS, timeMs);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddTodoBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(taskBox.Text))
            {
                taskCount++;
                Label tasklbl = new Label();
                tasklbl.Text = taskBox.Text;
                tasklbl.Name = $"Task No. {taskCount}";
                tasklbl.AutoSize = true;
                tasklbl.Location = new System.Drawing.Point(10, 50 + (taskCount * 10));

                // delete button
                // Create a new Button for marking the task as done
                Button doneButton = new Button();
                doneButton.Text = "Done";
                doneButton.Name = "doneButton" + taskCount;
                doneButton.AutoSize = true;
                doneButton.Location = new System.Drawing.Point(200, 30 + (taskCount * 12));

                // Event handler for the Done button click
                doneButton.Click += (s, args) =>
                {
                    TasksBox.Controls.Remove(tasklbl); // Remove the task label
                    TasksBox.Controls.Remove(doneButton); // Remove the done button
                };

                // Add the task label and done button to the group box
                TasksBox.Controls.Add(tasklbl);
                TasksBox.Controls.Add(doneButton);

                // Clear the task text box for the next input
                taskBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            taskCount = 0;
            taskBox.Controls.Clear();
           // don't know why this is not working?!!
        }
    }
}
