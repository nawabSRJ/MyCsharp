namespace ClgAdmin
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            teacherBox = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            studentBox = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            roleBox1 = new ComboBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            tabPage2 = new TabPage();
            resultsBox = new GroupBox();
            label8 = new Label();
            courseResult = new TextBox();
            label6 = new Label();
            label7 = new Label();
            nameResult = new TextBox();
            idResult = new TextBox();
            button2 = new Button();
            searchMetricLbl = new Label();
            searchBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            methodBoxSearch = new ComboBox();
            roleBoxSearch = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            teacherBox.SuspendLayout();
            studentBox.SuspendLayout();
            tabPage2.SuspendLayout();
            resultsBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(teacherBox);
            tabPage1.Controls.Add(studentBox);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(roleBox1);
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(idBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Records";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // teacherBox
            // 
            teacherBox.Controls.Add(checkBox4);
            teacherBox.Controls.Add(checkBox3);
            teacherBox.Controls.Add(checkBox2);
            teacherBox.Controls.Add(checkBox1);
            teacherBox.Enabled = false;
            teacherBox.Location = new Point(375, 42);
            teacherBox.Name = "teacherBox";
            teacherBox.Size = new Size(375, 307);
            teacherBox.TabIndex = 8;
            teacherBox.TabStop = false;
            teacherBox.Text = "TeacherCourses";
            teacherBox.Visible = false;
            // 
            // checkBox4
            // 
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(34, 184);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(137, 39);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "B.Com";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(34, 139);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(137, 39);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "B.Sc";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(34, 94);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(137, 39);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "BBA";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(34, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 39);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "BCA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // studentBox
            // 
            studentBox.Controls.Add(radioButton3);
            studentBox.Controls.Add(radioButton4);
            studentBox.Controls.Add(radioButton2);
            studentBox.Controls.Add(radioButton1);
            studentBox.Enabled = false;
            studentBox.Location = new Point(381, 42);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(375, 307);
            studentBox.TabIndex = 7;
            studentBox.TabStop = false;
            studentBox.Text = "StudentCourses";
            studentBox.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(49, 179);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(129, 39);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "B.Com";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(49, 134);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(129, 39);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "B.Sc";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(49, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(129, 39);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "BBA";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(49, 44);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 39);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "BCA";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(85, 243);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 186);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 127);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // roleBox1
            // 
            roleBox1.FormattingEnabled = true;
            roleBox1.Items.AddRange(new object[] { "Student", "Teacher" });
            roleBox1.Location = new Point(74, 183);
            roleBox1.Name = "roleBox1";
            roleBox1.Size = new Size(121, 23);
            roleBox1.TabIndex = 2;
            roleBox1.SelectedIndexChanged += roleBox1_SelectedIndexChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(74, 119);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(120, 23);
            nameBox.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Location = new Point(74, 62);
            idBox.Name = "idBox";
            idBox.Size = new Size(72, 23);
            idBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(resultsBox);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(searchMetricLbl);
            tabPage2.Controls.Add(searchBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(methodBoxSearch);
            tabPage2.Controls.Add(roleBoxSearch);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search Records";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // resultsBox
            // 
            resultsBox.Controls.Add(label8);
            resultsBox.Controls.Add(courseResult);
            resultsBox.Controls.Add(label6);
            resultsBox.Controls.Add(label7);
            resultsBox.Controls.Add(nameResult);
            resultsBox.Controls.Add(idResult);
            resultsBox.Location = new Point(325, 0);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(459, 414);
            resultsBox.TabIndex = 7;
            resultsBox.TabStop = false;
            resultsBox.Text = "Results";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 183);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 10;
            label8.Text = "Course";
            // 
            // courseResult
            // 
            courseResult.Location = new Point(152, 177);
            courseResult.Name = "courseResult";
            courseResult.Size = new Size(120, 23);
            courseResult.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 128);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 75);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 7;
            label7.Text = "ID";
            // 
            // nameResult
            // 
            nameResult.Location = new Point(152, 121);
            nameResult.Name = "nameResult";
            nameResult.Size = new Size(120, 23);
            nameResult.TabIndex = 6;
            // 
            // idResult
            // 
            idResult.Location = new Point(152, 70);
            idResult.Name = "idResult";
            idResult.Size = new Size(72, 23);
            idResult.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(106, 231);
            button2.Name = "button2";
            button2.Size = new Size(90, 35);
            button2.TabIndex = 6;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // searchMetricLbl
            // 
            searchMetricLbl.AutoSize = true;
            searchMetricLbl.Font = new Font("Segoe UI", 9.75F);
            searchMetricLbl.Location = new Point(12, 174);
            searchMetricLbl.Name = "searchMetricLbl";
            searchMetricLbl.Size = new Size(88, 17);
            searchMetricLbl.TabIndex = 5;
            searchMetricLbl.Text = "Search Metric";
            // 
            // searchBox
            // 
            searchBox.Enabled = false;
            searchBox.Location = new Point(106, 171);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(161, 23);
            searchBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(14, 108);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 3;
            label5.Text = "Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(19, 46);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 2;
            label4.Text = "Role";
            // 
            // methodBoxSearch
            // 
            methodBoxSearch.FormattingEnabled = true;
            methodBoxSearch.Items.AddRange(new object[] { "ID", "NAME" });
            methodBoxSearch.Location = new Point(72, 106);
            methodBoxSearch.Name = "methodBoxSearch";
            methodBoxSearch.Size = new Size(121, 23);
            methodBoxSearch.TabIndex = 1;
            methodBoxSearch.SelectedIndexChanged += methodBoxSearch_SelectedIndexChanged;
            // 
            // roleBoxSearch
            // 
            roleBoxSearch.FormattingEnabled = true;
            roleBoxSearch.Items.AddRange(new object[] { "Student", "Teacher" });
            roleBoxSearch.Location = new Point(72, 43);
            roleBoxSearch.Name = "roleBoxSearch";
            roleBoxSearch.Size = new Size(121, 23);
            roleBoxSearch.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            teacherBox.ResumeLayout(false);
            studentBox.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            resultsBox.ResumeLayout(false);
            resultsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox nameBox;
        private TextBox idBox;
        private TabPage tabPage2;
        private GroupBox teacherBox;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private GroupBox studentBox;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox roleBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private ComboBox methodBoxSearch;
        private ComboBox roleBoxSearch;
        private GroupBox resultsBox;
        private Label label8;
        private TextBox courseResult;
        private Label label6;
        private Label label7;
        private TextBox nameResult;
        private TextBox idResult;
        private Button button2;
        private Label searchMetricLbl;
        private TextBox searchBox;
    }
}