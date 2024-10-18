namespace WinFormsApp5
{
    partial class Armstrong
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
            lbl1 = new Label();
            txtBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Enabled = false;
            lbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(330, 277);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(137, 33);
            lbl1.TabIndex = 0;
            lbl1.Text = "Answer Here";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(316, 154);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(175, 23);
            txtBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(361, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Armstrong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBox1);
            Controls.Add(lbl1);
            Name = "Armstrong";
            Text = "Armstrong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBox1;
        private Button button1;
    }
}