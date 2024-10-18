namespace WinFormsAppMenu_Play
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            firstToolStripMenuItem = new ToolStripMenuItem();
            secondToolStripMenuItem = new ToolStripMenuItem();
            thirdToolStripMenuItem = new ToolStripMenuItem();
            fourthToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, newToolStripMenuItem, projectToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(56, 20);
            projectToolStripMenuItem.Text = "Project";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ActiveCaption;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { firstToolStripMenuItem, secondToolStripMenuItem, thirdToolStripMenuItem, fourthToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
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
            // button1
            // 
            button1.Location = new Point(351, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem firstToolStripMenuItem;
        private ToolStripMenuItem secondToolStripMenuItem;
        private ToolStripMenuItem thirdToolStripMenuItem;
        private ToolStripMenuItem fourthToolStripMenuItem;
        private Button button1;
    }
}
