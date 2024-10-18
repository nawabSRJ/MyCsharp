namespace SuperApp
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
            userName = new TextBox();
            userPass = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(79, 57);
            userName.Name = "userName";
            userName.Size = new Size(138, 23);
            userName.TabIndex = 0;
            // 
            // userPass
            // 
            userPass.Location = new Point(79, 105);
            userPass.Name = "userPass";
            userPass.Size = new Size(138, 23);
            userPass.TabIndex = 1;
            userPass.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(userPass);
            groupBox1.Location = new Point(251, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // button1
            // 
            button1.Location = new Point(107, 160);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 27);
            label1.Name = "label1";
            label1.Size = new Size(391, 104);
            label1.TabIndex = 3;
            label1.Text = "Super App";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox userName;
        private TextBox userPass;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
    }
}
