namespace ClgAdmin2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabOuter = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            clrBtn = new Button();
            stuInfo = new Label();
            stuPhone = new MaskedTextBox();
            stuDOB = new DateTimePicker();
            label30 = new Label();
            label9 = new Label();
            button1 = new Button();
            label8 = new Label();
            stuEmail = new TextBox();
            stuAddress = new TextBox();
            stuName = new TextBox();
            stuCourseBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            stuGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage4 = new TabPage();
            teacherInfo = new Label();
            tchPhone = new MaskedTextBox();
            tchCourses = new GroupBox();
            tchDOB = new DateTimePicker();
            label11 = new Label();
            tchEmail = new TextBox();
            tchAddress = new TextBox();
            tchName = new TextBox();
            label10 = new Label();
            button2 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tchGender = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            tabOuter.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabOuter
            // 
            tabOuter.Controls.Add(tabPage1);
            tabOuter.Controls.Add(tabPage2);
            tabOuter.Dock = DockStyle.Fill;
            tabOuter.Location = new Point(0, 0);
            tabOuter.Name = "tabOuter";
            tabOuter.SelectedIndex = 0;
            tabOuter.Size = new Size(800, 450);
            tabOuter.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Records";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(2, 2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(789, 419);
            tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(clrBtn);
            tabPage3.Controls.Add(stuInfo);
            tabPage3.Controls.Add(stuPhone);
            tabPage3.Controls.Add(stuDOB);
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(stuEmail);
            tabPage3.Controls.Add(stuAddress);
            tabPage3.Controls.Add(stuName);
            tabPage3.Controls.Add(stuCourseBox);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(stuGender);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(781, 391);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Student";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(692, 6);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(83, 23);
            clrBtn.TabIndex = 26;
            clrBtn.Text = "Clear Form";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // stuInfo
            // 
            stuInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            stuInfo.Location = new Point(205, 342);
            stuInfo.Name = "stuInfo";
            stuInfo.Size = new Size(426, 34);
            stuInfo.TabIndex = 25;
            stuInfo.Text = "label7";
            stuInfo.TextAlign = ContentAlignment.MiddleCenter;
            stuInfo.Visible = false;
            // 
            // stuPhone
            // 
            stuPhone.Location = new Point(362, 137);
            stuPhone.Mask = "0000000000";
            stuPhone.Name = "stuPhone";
            stuPhone.Size = new Size(121, 23);
            stuPhone.TabIndex = 24;
            // 
            // stuDOB
            // 
            stuDOB.Location = new Point(362, 237);
            stuDOB.Name = "stuDOB";
            stuDOB.Size = new Size(200, 23);
            stuDOB.TabIndex = 21;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(309, 241);
            label30.Name = "label30";
            label30.Size = new Size(31, 15);
            label30.TabIndex = 20;
            label30.Text = "DOB";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(310, 339);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(362, 279);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(309, 210);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // stuEmail
            // 
            stuEmail.Location = new Point(362, 206);
            stuEmail.Name = "stuEmail";
            stuEmail.Size = new Size(121, 23);
            stuEmail.TabIndex = 14;
            // 
            // stuAddress
            // 
            stuAddress.Location = new Point(362, 105);
            stuAddress.Name = "stuAddress";
            stuAddress.Size = new Size(121, 23);
            stuAddress.TabIndex = 6;
            // 
            // stuName
            // 
            stuName.Location = new Point(362, 47);
            stuName.Name = "stuName";
            stuName.Size = new Size(121, 23);
            stuName.TabIndex = 0;
            // 
            // stuCourseBox
            // 
            stuCourseBox.FormattingEnabled = true;
            stuCourseBox.Location = new Point(362, 170);
            stuCourseBox.Name = "stuCourseBox";
            stuCourseBox.Size = new Size(121, 23);
            stuCourseBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 175);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 143);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Ph.No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 111);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // stuGender
            // 
            stuGender.FormattingEnabled = true;
            stuGender.Items.AddRange(new object[] { "Male", "Female" });
            stuGender.Location = new Point(362, 76);
            stuGender.Name = "stuGender";
            stuGender.Size = new Size(121, 23);
            stuGender.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 81);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 51);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, -4);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 1;
            label1.Text = "Student Entry Form";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(teacherInfo);
            tabPage4.Controls.Add(tchPhone);
            tabPage4.Controls.Add(tchCourses);
            tabPage4.Controls.Add(tchDOB);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(tchEmail);
            tabPage4.Controls.Add(tchAddress);
            tabPage4.Controls.Add(tchName);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(tchGender);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label18);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(781, 391);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Teacher";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // teacherInfo
            // 
            teacherInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            teacherInfo.Location = new Point(201, 349);
            teacherInfo.Name = "teacherInfo";
            teacherInfo.Size = new Size(426, 34);
            teacherInfo.TabIndex = 46;
            teacherInfo.Text = "label7";
            teacherInfo.TextAlign = ContentAlignment.MiddleCenter;
            teacherInfo.Visible = false;
            // 
            // tchPhone
            // 
            tchPhone.Location = new Point(116, 165);
            tchPhone.Mask = "0000000000";
            tchPhone.Name = "tchPhone";
            tchPhone.Size = new Size(121, 23);
            tchPhone.TabIndex = 45;
            // 
            // tchCourses
            // 
            tchCourses.Location = new Point(388, 74);
            tchCourses.Name = "tchCourses";
            tchCourses.Size = new Size(347, 240);
            tchCourses.TabIndex = 44;
            tchCourses.TabStop = false;
            tchCourses.Text = "Courses";
            // 
            // tchDOB
            // 
            tchDOB.Location = new Point(116, 230);
            tchDOB.Name = "tchDOB";
            tchDOB.Size = new Size(200, 23);
            tchDOB.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 236);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 40;
            label11.Text = "DOB";
            // 
            // tchEmail
            // 
            tchEmail.Location = new Point(116, 194);
            tchEmail.Name = "tchEmail";
            tchEmail.Size = new Size(121, 23);
            tchEmail.TabIndex = 31;
            // 
            // tchAddress
            // 
            tchAddress.Location = new Point(116, 134);
            tchAddress.Name = "tchAddress";
            tchAddress.Size = new Size(121, 23);
            tchAddress.TabIndex = 23;
            // 
            // tchName
            // 
            tchName.Location = new Point(116, 76);
            tchName.Name = "tchName";
            tchName.Size = new Size(121, 23);
            tchName.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(306, 368);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 34;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(116, 276);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 33;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 200);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 27;
            label13.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 171);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 26;
            label14.Text = "Ph.No";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(63, 142);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 24;
            label15.Text = "Address";
            // 
            // tchGender
            // 
            tchGender.FormattingEnabled = true;
            tchGender.Items.AddRange(new object[] { "Male", "Female" });
            tchGender.Location = new Point(116, 105);
            tchGender.Name = "tchGender";
            tchGender.Size = new Size(121, 23);
            tchGender.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(63, 112);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 21;
            label16.Text = "Gender";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(63, 82);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 20;
            label17.Text = "Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(250, 13);
            label18.Name = "label18";
            label18.Size = new Size(280, 40);
            label18.TabIndex = 19;
            label18.Text = "Teacher Entry Form";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search Records";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(16, 16);
            button3.Name = "button3";
            button3.Size = new Size(83, 23);
            button3.TabIndex = 47;
            button3.Text = "Clear Form";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabOuter);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabOuter.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabOuter;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
        private Button button1;
        private Label label8;
        private TextBox stuEmail;
        private TextBox stuAddress;
        private TextBox stuName;
        private ComboBox comboBox3;
        private Label stuInfo;
        private ComboBox stuCourseBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox stuGender;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage4;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox5;
        //private Label label19;
        private ComboBox comboBox4;
        private TextBox textBox9;
        private TextBox tchEmail;
        private TextBox tchAddress;
        private TextBox tchName;
        private Label label10;
        private Button button2;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox tchGender;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label30;
        private DateTimePicker stuDOB;
        private DateTimePicker tchDOB;
        private Label label11;
        //private TextBox stuPhoto;
       // private Label label12;
        private GroupBox tchCourses;
        //private TextBox tchPhoto;
        private MaskedTextBox stuPhone;
        private Button clrBtn;
        private MaskedTextBox tchPhone;
        private Label teacherInfo;
        private Button button3;
    }
}