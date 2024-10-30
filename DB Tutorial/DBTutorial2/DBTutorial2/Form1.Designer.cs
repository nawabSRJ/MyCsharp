namespace DBTutorial2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idBox = new TextBox();
            cityBox = new TextBox();
            nameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(123, 67);
            idBox.Name = "idBox";
            idBox.Size = new Size(194, 23);
            idBox.TabIndex = 0;
            // 
            // cityBox
            // 
            cityBox.Enabled = false;
            cityBox.Location = new Point(123, 172);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(194, 23);
            cityBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Location = new Point(123, 119);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(194, 23);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 69);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 173);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 5;
            label3.Text = "City";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(31, 239);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 184);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 23);
            textBox4.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(idBox);
            groupBox1.Controls.Add(cityBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(399, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 284);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(202, 233);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "Commit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(121, 233);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(399, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 71);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(14, 25);
            button5.Name = "button5";
            button5.Size = new Size(85, 29);
            button5.TabIndex = 3;
            button5.Text = "New";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(202, 25);
            button4.Name = "button4";
            button4.Size = new Size(85, 29);
            button4.TabIndex = 2;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(111, 25);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 1;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 210);
            button2.Name = "button2";
            button2.Size = new Size(31, 23);
            button2.TabIndex = 10;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idBox;
        private TextBox cityBox;
        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        //private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button button6;
    }
}
