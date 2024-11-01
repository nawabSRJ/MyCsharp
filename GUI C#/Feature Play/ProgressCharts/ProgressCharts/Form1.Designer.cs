namespace ProgressCharts
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
            pBar1 = new ProgressBar();
            pBar2 = new ProgressBar();
            pBar4 = new ProgressBar();
            pBar3 = new ProgressBar();
            pBar6 = new ProgressBar();
            pBar5 = new ProgressBar();
            SuspendLayout();
            // 
            // pBar1
            // 
            pBar1.Location = new Point(105, 152);
            pBar1.Name = "pBar1";
            pBar1.Size = new Size(175, 20);
            pBar1.TabIndex = 0;
            // 
            // pBar2
            // 
            pBar2.Location = new Point(105, 178);
            pBar2.Name = "pBar2";
            pBar2.Size = new Size(175, 20);
            pBar2.TabIndex = 1;
            // 
            // pBar4
            // 
            pBar4.Location = new Point(105, 51);
            pBar4.Name = "pBar4";
            pBar4.Size = new Size(175, 25);
            pBar4.TabIndex = 3;
            pBar4.Click += pBar4_Click;
            // 
            // pBar3
            // 
            pBar3.Location = new Point(105, 82);
            pBar3.Name = "pBar3";
            pBar3.Size = new Size(175, 26);
            pBar3.TabIndex = 2;
            // 
            // pBar6
            // 
            pBar6.Location = new Point(750, 253);
            pBar6.Name = "pBar6";
            pBar6.Size = new Size(38, 185);
            pBar6.TabIndex = 5;
            // 
            // pBar5
            // 
            pBar5.Location = new Point(706, 294);
            pBar5.Name = "pBar5";
            pBar5.Size = new Size(38, 144);
            pBar5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pBar6);
            Controls.Add(pBar5);
            Controls.Add(pBar4);
            Controls.Add(pBar3);
            Controls.Add(pBar2);
            Controls.Add(pBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pBar1;
        private ProgressBar pBar2;
        private ProgressBar pBar4;
        private ProgressBar pBar3;
        private ProgressBar pBar6;
        private ProgressBar pBar5;
    }
}
