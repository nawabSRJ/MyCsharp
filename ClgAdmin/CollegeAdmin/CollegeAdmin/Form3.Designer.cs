namespace CollegeAdmin
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idBox = new TextBox();
            nameBox = new TextBox();
            courseBox = new TextBox();
            label4 = new Label();
            nextBtn = new Button();
            prevBtn = new Button();
            recordNoLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 149);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 198);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 246);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Course";
            // 
            // idBox
            // 
            idBox.Location = new Point(350, 144);
            idBox.Name = "idBox";
            idBox.Size = new Size(158, 23);
            idBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(350, 193);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(158, 23);
            nameBox.TabIndex = 4;
            // 
            // courseBox
            // 
            courseBox.Location = new Point(349, 240);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(158, 23);
            courseBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(239, 22);
            label4.Name = "label4";
            label4.Size = new Size(322, 37);
            label4.TabIndex = 6;
            label4.Text = "Search Results";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nextBtn
            // 
            nextBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtn.Location = new Point(694, 211);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(94, 33);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            prevBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevBtn.Location = new Point(12, 211);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(94, 33);
            prevBtn.TabIndex = 8;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // recordNoLbl
            // 
            recordNoLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordNoLbl.Location = new Point(312, 361);
            recordNoLbl.Name = "recordNoLbl";
            recordNoLbl.Size = new Size(176, 23);
            recordNoLbl.TabIndex = 9;
            recordNoLbl.Text = "Record No. : ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(recordNoLbl);
            Controls.Add(prevBtn);
            Controls.Add(nextBtn);
            Controls.Add(label4);
            Controls.Add(courseBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox courseBox;
        private Label label4;
        private Button nextBtn;
        private Button prevBtn;
        private Label recordNoLbl;
    }
}