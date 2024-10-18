namespace WinFormsApp5
{
    partial class Prime
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
            txtBox1 = new TextBox();
            button1 = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(333, 135);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(158, 23);
            txtBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 182);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Enabled = false;
            lbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(349, 284);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(131, 30);
            lbl1.TabIndex = 2;
            lbl1.Text = "Answer Here";
            // 
            // Prime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(button1);
            Controls.Add(txtBox1);
            Name = "Prime";
            Text = "Prime";
            Load += Prime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private Button button1;
        private Label lbl1;
    }
}