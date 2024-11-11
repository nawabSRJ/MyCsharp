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
            label1 = new Label();
            usernameBox = new TextBox();
            passwdBox = new TextBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            captchaBox1 = new GroupBox();
            captchaAnswer = new NumericUpDown();
            button2 = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            captchaBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)captchaAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(506, 20);
            label1.Name = "label1";
            label1.Size = new Size(579, 54);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // usernameBox
            // 
            usernameBox.AccessibleDescription = "";
            usernameBox.BackColor = SystemColors.ButtonHighlight;
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Location = new Point(280, 129);
            usernameBox.Margin = new Padding(3, 4, 3, 4);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(228, 39);
            usernameBox.TabIndex = 1;
            // 
            // passwdBox
            // 
            passwdBox.BackColor = SystemColors.ButtonHighlight;
            passwdBox.BorderStyle = BorderStyle.FixedSingle;
            passwdBox.Location = new Point(280, 213);
            passwdBox.Margin = new Padding(3, 4, 3, 4);
            passwdBox.Name = "passwdBox";
            passwdBox.PasswordChar = '*';
            passwdBox.Size = new Size(228, 39);
            passwdBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCyan;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(passwdBox);
            groupBox1.Controls.Add(usernameBox);
            groupBox1.Font = new Font("Segoe UI Variable Small Semibol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(499, 269);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(545, 433);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credentials";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(147, 303);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 23);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Location = new Point(256, 356);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(109, 53);
            button1.TabIndex = 5;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 219);
            label3.Name = "label3";
            label3.Size = new Size(201, 32);
            label3.TabIndex = 4;
            label3.Text = "Admin Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 135);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 3;
            label2.Text = "Admin Email";
            // 
            // captchaBox1
            // 
            captchaBox1.BackColor = Color.LightGoldenrodYellow;
            captchaBox1.Controls.Add(captchaAnswer);
            captchaBox1.Controls.Add(button2);
            captchaBox1.Controls.Add(label4);
            captchaBox1.Controls.Add(pictureBox4);
            captchaBox1.Controls.Add(pictureBox5);
            captchaBox1.Controls.Add(pictureBox6);
            captchaBox1.Controls.Add(pictureBox3);
            captchaBox1.Controls.Add(pictureBox2);
            captchaBox1.Controls.Add(pictureBox1);
            captchaBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            captchaBox1.Location = new Point(491, 229);
            captchaBox1.Margin = new Padding(3, 4, 3, 4);
            captchaBox1.Name = "captchaBox1";
            captchaBox1.Padding = new Padding(3, 4, 3, 4);
            captchaBox1.Size = new Size(560, 512);
            captchaBox1.TabIndex = 4;
            captchaBox1.TabStop = false;
            captchaBox1.Text = "Captcha";
            captchaBox1.Visible = false;
            // 
            // captchaAnswer
            // 
            captchaAnswer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            captchaAnswer.Location = new Point(205, 457);
            captchaAnswer.Margin = new Padding(3, 4, 3, 4);
            captchaAnswer.Name = "captchaAnswer";
            captchaAnswer.Size = new Size(145, 39);
            captchaAnswer.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(358, 453);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 48);
            button2.TabIndex = 8;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 95);
            label4.Name = "label4";
            label4.Size = new Size(312, 28);
            label4.TabIndex = 6;
            label4.Text = "Enter how many images have car";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(370, 279);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(216, 279);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(147, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(62, 279);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(147, 131);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(370, 140);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 131);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(216, 140);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 140);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1543, 972);
            Controls.Add(captchaBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Inventory Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            captchaBox1.ResumeLayout(false);
            captchaBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)captchaAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameBox;
        private TextBox passwdBox;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private GroupBox captchaBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private NumericUpDown captchaAnswer;
        private PictureBox pictureBox1;
    }
}
