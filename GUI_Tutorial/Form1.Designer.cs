namespace GUI_Tutorial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SRJ = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            firstToolStripMenuItem = new ToolStripMenuItem();
            secondToolStripMenuItem = new ToolStripMenuItem();
            thirdToolStripMenuItem = new ToolStripMenuItem();
            fourthToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(71, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 138);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 8;
            label3.Text = "Subjects";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(128, 136);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(115, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 4;
            label2.Text = "Age";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(161, 356);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // SRJ
            // 
            SRJ.BalloonTipText = "Any1";
            SRJ.BalloonTipTitle = "Any2";
            SRJ.ContextMenuStrip = contextMenuStrip1;
            SRJ.Icon = (Icon)resources.GetObject("SRJ.Icon");
            SRJ.Text = "MyIcon";
            SRJ.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { firstToolStripMenuItem, secondToolStripMenuItem, thirdToolStripMenuItem, fourthToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 92);
            // 
            // firstToolStripMenuItem
            // 
            firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            firstToolStripMenuItem.Size = new Size(113, 22);
            firstToolStripMenuItem.Text = "First";
            // 
            // secondToolStripMenuItem
            // 
            secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            secondToolStripMenuItem.Size = new Size(113, 22);
            secondToolStripMenuItem.Text = "Second";
            // 
            // thirdToolStripMenuItem
            // 
            thirdToolStripMenuItem.Name = "thirdToolStripMenuItem";
            thirdToolStripMenuItem.Size = new Size(113, 22);
            thirdToolStripMenuItem.Text = "Third";
            // 
            // fourthToolStripMenuItem
            // 
            fourthToolStripMenuItem.Name = "fourthToolStripMenuItem";
            fourthToolStripMenuItem.Size = new Size(113, 22);
            fourthToolStripMenuItem.Text = "Fourth";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(421, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 403);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private NotifyIcon SRJ;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem firstToolStripMenuItem;
        private ToolStripMenuItem secondToolStripMenuItem;
        private ToolStripMenuItem thirdToolStripMenuItem;
        private ToolStripMenuItem fourthToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
