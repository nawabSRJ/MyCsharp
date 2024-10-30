namespace CollegeAdmin
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
            addBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            roleBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            searchBox2 = new GroupBox();
            metricLbl = new Label();
            searchBox = new TextBox();
            roleBox2 = new ComboBox();
            label5 = new Label();
            methodBox1 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            addBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            searchBox2.SuspendLayout();
            SuspendLayout();
            // 
            // addBox1
            // 
            addBox1.Controls.Add(button1);
            addBox1.Controls.Add(groupBox2);
            addBox1.Controls.Add(groupBox1);
            addBox1.Controls.Add(roleBox1);
            addBox1.Controls.Add(label3);
            addBox1.Controls.Add(label2);
            addBox1.Controls.Add(label1);
            addBox1.Controls.Add(nameBox);
            addBox1.Controls.Add(idBox);
            addBox1.Dock = DockStyle.Left;
            addBox1.Location = new Point(0, 0);
            addBox1.Name = "addBox1";
            addBox1.Size = new Size(385, 450);
            addBox1.TabIndex = 0;
            addBox1.TabStop = false;
            addBox1.Text = "Add Record";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(122, 398);
            button1.Name = "button1";
            button1.Size = new Size(111, 31);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 239);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Course Selection Student";
            groupBox2.Visible = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F);
            radioButton3.Location = new Point(28, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 25);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "B.Sc";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F);
            radioButton4.Location = new Point(28, 175);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(73, 25);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "B.Com";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(28, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "BBA";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(28, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "BCA";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 242);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Selection Teacher";
            groupBox1.Visible = false;
            // 
            // checkBox4
            // 
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(24, 162);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(117, 35);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "B.Com";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(24, 121);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(117, 35);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "B.Sc";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(24, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 35);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "BBA";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(24, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 35);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "BCA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // roleBox1
            // 
            roleBox1.AutoCompleteCustomSource.AddRange(new string[] { "Student", "Teacher" });
            roleBox1.FormattingEnabled = true;
            roleBox1.Items.AddRange(new object[] { "Student", "Teacher" });
            roleBox1.Location = new Point(52, 94);
            roleBox1.Name = "roleBox1";
            roleBox1.Size = new Size(121, 23);
            roleBox1.TabIndex = 5;
            roleBox1.Text = "Choose Role";
            roleBox1.SelectedIndexChanged += roleBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 39);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(171, 35);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(200, 23);
            nameBox.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Location = new Point(36, 35);
            idBox.Name = "idBox";
            idBox.Size = new Size(58, 23);
            idBox.TabIndex = 0;
            // 
            // searchBox2
            // 
            searchBox2.Controls.Add(metricLbl);
            searchBox2.Controls.Add(searchBox);
            searchBox2.Controls.Add(roleBox2);
            searchBox2.Controls.Add(label5);
            searchBox2.Controls.Add(methodBox1);
            searchBox2.Controls.Add(label4);
            searchBox2.Controls.Add(button2);
            searchBox2.Dock = DockStyle.Right;
            searchBox2.Location = new Point(391, 0);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(409, 450);
            searchBox2.TabIndex = 1;
            searchBox2.TabStop = false;
            searchBox2.Tag = "";
            searchBox2.Text = "Search Record";
            searchBox2.Enter += searchBox2_Enter;
            // 
            // metricLbl
            // 
            metricLbl.AutoSize = true;
            metricLbl.Location = new Point(59, 98);
            metricLbl.Name = "metricLbl";
            metricLbl.Size = new Size(79, 15);
            metricLbl.TabIndex = 11;
            metricLbl.Text = "Search Metric";
            // 
            // searchBox
            // 
            searchBox.Enabled = false;
            searchBox.Location = new Point(151, 93);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 23);
            searchBox.TabIndex = 9;
            // 
            // roleBox2
            // 
            roleBox2.AutoCompleteCustomSource.AddRange(new string[] { "Student", "Teacher" });
            roleBox2.FormattingEnabled = true;
            roleBox2.Items.AddRange(new object[] { "Student", "Teacher" });
            roleBox2.Location = new Point(53, 39);
            roleBox2.Name = "roleBox2";
            roleBox2.Size = new Size(121, 23);
            roleBox2.TabIndex = 10;
            roleBox2.Text = "Choose Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 42);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 9;
            label5.Text = "Role";
            // 
            // methodBox1
            // 
            methodBox1.AutoCompleteCustomSource.AddRange(new string[] { "Student", "Teacher" });
            methodBox1.FormattingEnabled = true;
            methodBox1.Items.AddRange(new object[] { "ID Wise", "Name Wise" });
            methodBox1.Location = new Point(254, 39);
            methodBox1.Name = "methodBox1";
            methodBox1.Size = new Size(121, 23);
            methodBox1.TabIndex = 10;
            methodBox1.Text = "Choose Role";
            methodBox1.SelectedIndexChanged += methodBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 42);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 9;
            label4.Text = "Method";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(173, 149);
            button2.Name = "button2";
            button2.Size = new Size(77, 34);
            button2.TabIndex = 0;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBox2);
            Controls.Add(addBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            addBox1.ResumeLayout(false);
            addBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            searchBox2.ResumeLayout(false);
            searchBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addBox1;
        private GroupBox searchBox2;
        private ComboBox roleBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nameBox;
        private TextBox idBox;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private ComboBox methodBox1;
        private Label label4;
        private Label metricLbl;
        private TextBox searchBox;
        private ComboBox roleBox2;
        private Label label5;
    }
}