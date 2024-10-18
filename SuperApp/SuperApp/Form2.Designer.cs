namespace SuperApp
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ClearAllBtn = new Button();
            TasksBox = new GroupBox();
            AddTodoBtn = new Button();
            taskBox = new TextBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            tabPage3 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            stopWatchLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ClearAllBtn);
            tabPage1.Controls.Add(TasksBox);
            tabPage1.Controls.Add(AddTodoBtn);
            tabPage1.Controls.Add(taskBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ToDo";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // ClearAllBtn
            // 
            ClearAllBtn.BackColor = Color.LightCoral;
            ClearAllBtn.Location = new Point(584, 17);
            ClearAllBtn.Margin = new Padding(0);
            ClearAllBtn.Name = "ClearAllBtn";
            ClearAllBtn.Size = new Size(71, 31);
            ClearAllBtn.TabIndex = 3;
            ClearAllBtn.Text = "Clear All";
            ClearAllBtn.UseVisualStyleBackColor = false;
            ClearAllBtn.Click += ClearAllBtn_Click;
            // 
            // TasksBox
            // 
            TasksBox.Dock = DockStyle.Bottom;
            TasksBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TasksBox.Location = new Point(3, 75);
            TasksBox.Name = "TasksBox";
            TasksBox.Size = new Size(786, 344);
            TasksBox.TabIndex = 2;
            TasksBox.TabStop = false;
            TasksBox.Text = "Tasks";
            // 
            // AddTodoBtn
            // 
            AddTodoBtn.BackColor = Color.IndianRed;
            AddTodoBtn.Location = new Point(502, 18);
            AddTodoBtn.Margin = new Padding(0);
            AddTodoBtn.Name = "AddTodoBtn";
            AddTodoBtn.Size = new Size(71, 31);
            AddTodoBtn.TabIndex = 1;
            AddTodoBtn.Text = "Add Task";
            AddTodoBtn.UseVisualStyleBackColor = false;
            AddTodoBtn.Click += AddTodoBtn_Click;
            // 
            // taskBox
            // 
            taskBox.Location = new Point(139, 21);
            taskBox.Name = "taskBox";
            taskBox.Size = new Size(337, 23);
            taskBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(menuStrip1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Notepad";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(789, 392);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, clearToolStripMenuItem, copyToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(786, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(46, 20);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(47, 20);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(stopWatchLbl);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "StopWatch";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(453, 219);
            button3.Name = "button3";
            button3.Size = new Size(90, 40);
            button3.TabIndex = 3;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(348, 219);
            button2.Name = "button2";
            button2.Size = new Size(90, 40);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(243, 219);
            button1.Name = "button1";
            button1.Size = new Size(90, 40);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stopWatchLbl
            // 
            stopWatchLbl.Font = new Font("Segoe UI Symbol", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopWatchLbl.Location = new Point(90, 92);
            stopWatchLbl.Name = "stopWatchLbl";
            stopWatchLbl.Size = new Size(636, 91);
            stopWatchLbl.TabIndex = 0;
            stopWatchLbl.Text = "00:00:00";
            stopWatchLbl.TextAlign = ContentAlignment.MiddleCenter;
            stopWatchLbl.Click += stopWatchLbl_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private Label stopWatchLbl;
        private Button button2;
        private Button button1;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private TextBox taskBox;
        private GroupBox TasksBox;
        private Button AddTodoBtn;
        private Button ClearAllBtn;
    }
}