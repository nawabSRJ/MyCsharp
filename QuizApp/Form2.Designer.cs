namespace QuizApp
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
            TreeNode treeNode1 = new TreeNode("Q1");
            TreeNode treeNode2 = new TreeNode("Q2");
            TreeNode treeNode3 = new TreeNode("Q3");
            groupBox1 = new GroupBox();
            button3 = new Button();
            option4 = new RadioButton();
            option3 = new RadioButton();
            option2 = new RadioButton();
            option1 = new RadioButton();
            label1 = new Label();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(option4);
            groupBox1.Controls.Add(option3);
            groupBox1.Controls.Add(option2);
            groupBox1.Controls.Add(option1);
            groupBox1.Location = new Point(595, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Answers";
            // 
            // button3
            // 
            button3.Location = new Point(72, 219);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.Location = new Point(77, 164);
            option4.Name = "option4";
            option4.Size = new Size(70, 19);
            option4.TabIndex = 3;
            option4.TabStop = true;
            option4.Text = "Answer4";
            option4.UseVisualStyleBackColor = true;
            option4.CheckedChanged += option4_CheckedChanged;
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.Location = new Point(77, 121);
            option3.Name = "option3";
            option3.Size = new Size(70, 19);
            option3.TabIndex = 2;
            option3.TabStop = true;
            option3.Text = "Answer3";
            option3.UseVisualStyleBackColor = true;
            option3.CheckedChanged += option3_CheckedChanged;
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.Location = new Point(77, 85);
            option2.Name = "option2";
            option2.Size = new Size(70, 19);
            option2.TabIndex = 1;
            option2.TabStop = true;
            option2.Text = "Answer2";
            option2.UseVisualStyleBackColor = true;
            option2.CheckedChanged += option2_CheckedChanged;
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.Location = new Point(77, 41);
            option1.Name = "option1";
            option1.Size = new Size(70, 19);
            option1.TabIndex = 0;
            option1.TabStop = true;
            option1.Text = "Answer1";
            option1.UseVisualStyleBackColor = true;
            option1.CheckedChanged += option1_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(655, 144);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Q1";
            treeNode1.Text = "Q1";
            treeNode2.Name = "Q2";
            treeNode2.Text = "Q2";
            treeNode3.Name = "Q3";
            treeNode3.Text = "Q3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1.Size = new Size(121, 450);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton option4;
        private RadioButton option3;
        private RadioButton option2;
        private RadioButton option1;
        private Label label1;
        private Button button3;
        private TreeView treeView1;
    }
}