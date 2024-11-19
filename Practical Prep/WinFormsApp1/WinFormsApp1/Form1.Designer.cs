namespace WinFormsApp1
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
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            button1 = new Button();
            btn2 = new Button();
            lbl2 = new Label();
            phoneText = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(94, 125);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(117, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(117, 217);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 4;
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(396, 43);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "label2";
            lbl2.Click += lbl2_Click;
            // 
            // phoneText
            // 
            phoneText.Location = new Point(94, 96);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(146, 23);
            phoneText.TabIndex = 6;
            phoneText.TextChanged += phoneText_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(396, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(399, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 94);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(400, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(564, 290);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(phoneText);
            Controls.Add(lbl2);
            Controls.Add(btn2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button button1;
        private Button btn2;
        private Label lbl2;
        private TextBox phoneText;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
    }
}
