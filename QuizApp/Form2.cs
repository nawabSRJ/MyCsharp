using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form2 : Form
    {
        public bool incomplete = false;
        public int ageGrp { get; set; } // for knowing the age group of the candidate
        // To store the user's selected answers
        private string[] userAnswers;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize userAnswers based on the length of questions array for the selected age group
            userAnswers = new string[GetQuestions().Length];
            // clear all selections on start
            // Clear previous selection
            option1.Checked = false;
            option2.Checked = false;
            option3.Checked = false;
            option4.Checked = false;


            changeState();
        }

        // Dynamically retrieve the questions based on the age group
        private string[] GetQuestions()
        {
            return ageGrp switch
            {
                1 => Game.ques1,
                2 => Game.ques2,
                3 => Game.ques3,
                _ => Game.ques1 // Default to ques1 if ageGrp is not valid
            };
        }

        // Dynamically retrieve the options based on the age group
        private string[,] GetOptions()
        {
            return ageGrp switch
            {
                1 => Game.opts1,
                2 => Game.opts2,
                3 => Game.opts3,
                _ => Game.opts1 // Default to opts1 if ageGrp is not valid
            };
        }

        // Dynamically retrieve the answers based on the age group
        private string[] GetAnswers()
        {
            return ageGrp switch
            {
                1 => Game.answers1,
                2 => Game.answers2,
                3 => Game.answers3,
                _ => Game.answers1 // Default to answers1 if ageGrp is not valid
            };
        }

        public void changeState()
        {
            string[] questions = GetQuestions();
            string[,] options = GetOptions();

            // Set question text
            label1.Text = questions[Game.currInd];

            // Set option texts
            option1.Text = options[Game.currInd, 0];
            option2.Text = options[Game.currInd, 1];
            option3.Text = options[Game.currInd, 2];
            option4.Text = options[Game.currInd, 3];

            // Pre-select previously chosen answer if it exists
            if (userAnswers[Game.currInd] == option1.Text) option1.Checked = true;
            else if (userAnswers[Game.currInd] == option2.Text) option2.Checked = true;
            else if (userAnswers[Game.currInd] == option3.Text) option3.Checked = true;
            else if (userAnswers[Game.currInd] == option4.Text) option4.Checked = true;
            else
            {
                // Clear previous selection
                option1.Checked = false;
                option2.Checked = false;
                option3.Checked = false;
                option4.Checked = false;
            }

            // Show submit button for the last question
            if (Game.currInd == questions.Length - 1)
            {
                button3.Enabled = true;
                button3.Visible = true;
            }
            else
            {
                button3.Enabled = false;
                button3.Visible = false;
            }
        }

        /* right arrow button
        private void button1_Click(object sender, EventArgs e)
        {
            saveAnswer();  // Save the answer before moving to the next question
            if (Game.currInd < GetQuestions().Length - 1)
            {
                Game.currInd++;
                changeState();
            }
        }
        
        // left arrow  button
        private void button2_Click(object sender, EventArgs e)
        {
            saveAnswer();  // Save the answer before moving to the previous question
            if (Game.currInd > 0)
            {
                Game.currInd--;
                changeState();
            }
        }
        */
        private void saveAnswer()
        {
            foreach (Control control in groupBox1.Controls)
            {


                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    userAnswers[Game.currInd] = radioButton.Text;  // Save the selected answer
                }
                else if (control is RadioButton radioBtn && !radioBtn.Checked)
                {
                    userAnswers[Game.currInd] = null;
                }
            }
        }

        // submit button
        private void button3_Click(object sender, EventArgs e)
        {

            int totalMarks = 0;
            string[] correctAnswers = GetAnswers();

            // Evaluate all the answers
            for (int i = 0; i < GetQuestions().Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    totalMarks += 3;  // Correct answer
                }
                else if (userAnswers[i] == null)
                {
                    totalMarks += 0; // do nothing
                }
                else
                {
                    totalMarks -= 2;  // Incorrect answer
                }
            }
            MessageBox.Show("Your total score is: " + totalMarks.ToString(), "Quiz Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Q1")
            {
                Game.currInd = 0;
                changeState();
            }
            else if (e.Node.Text == "Q2")
            {
                Game.currInd = 1;
                changeState();

            }
            else if (e.Node.Text == "Q3")
            {
                Game.currInd = 2;
                changeState();
            }
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }

        private void option4_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }
    }

    class Game
    {
        public static string[] ques1 = { "Capital of India", "Who won the 2011 ICC CWC", "Ronaldo or Messi" };
        public static string[] ques2 = {
            "What is the chemical symbol for water?",
            "What is the powerhouse of the cell?",
            "What is the acceleration due to gravity on Earth?"
        
        };
        public static string[] ques3 = { "Blockchain type?", "AI recognition algorithm?", "Purpose of analytics?" };

        public static string[,] opts1 = {
            { "New Delhi", "Mumbai", "Ahmedabad", "Lucknow" },
            { "India", "Australia", "New Zealand", "South Africa" },
            { "Mbaape", "Siuu", "Messi", "Ronaldo" }
        };

        public static string[,] opts2 = {
            { "H2O", "CO2", "O2", "N2" },
            { "Nucleus", "Mitochondria", "Ribosome", "Chloroplast" },
            { "9.8 m/s²", "5.5 m/s²", "10.5 m/s²", "8.1 m/s²" }
            
        };

        public static string[,] opts3 = {
            { "Public", "Private", "Consortium", "Hybrid" },
            { "Neural Networks", "Decision Trees", "K-Nearest Neighbors", "SVM" },
            { "Interpret data", "Store data", "Collect data", "Transfer data" }
        };

        public static string[] answers1 = { "New Delhi", "India", "Messi" };
        public static string[] answers2 = { "H2O", "Mitochondria", "9.8 m/s²", "Carbon Dioxide", "Alexander Fleming" };
        public static string[] answers3 = { "Public", "Neural Networks", "Interpret data" };

        public static int currInd = 0;
    }
}