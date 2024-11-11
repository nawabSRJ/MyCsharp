namespace WinFormsApp1
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            label1 = new Label();
            orderNumBox = new TextBox();
            orderDateBox = new TextBox();
            custNameBox = new TextBox();
            totalAmtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            qrBox = new PictureBox();
            crossBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 0;
            label1.Text = "Order Summary";
            // 
            // orderNumBox
            // 
            orderNumBox.Enabled = false;
            orderNumBox.Location = new Point(319, 89);
            orderNumBox.Margin = new Padding(3, 4, 3, 4);
            orderNumBox.Name = "orderNumBox";
            orderNumBox.Size = new Size(195, 27);
            orderNumBox.TabIndex = 1;
            // 
            // orderDateBox
            // 
            orderDateBox.Enabled = false;
            orderDateBox.Location = new Point(319, 149);
            orderDateBox.Margin = new Padding(3, 4, 3, 4);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(195, 27);
            orderDateBox.TabIndex = 2;
            // 
            // custNameBox
            // 
            custNameBox.Enabled = false;
            custNameBox.Location = new Point(319, 213);
            custNameBox.Margin = new Padding(3, 4, 3, 4);
            custNameBox.Name = "custNameBox";
            custNameBox.Size = new Size(195, 27);
            custNameBox.TabIndex = 3;
            // 
            // totalAmtBox
            // 
            totalAmtBox.Enabled = false;
            totalAmtBox.Location = new Point(319, 273);
            totalAmtBox.Margin = new Padding(3, 4, 3, 4);
            totalAmtBox.Name = "totalAmtBox";
            totalAmtBox.Size = new Size(195, 27);
            totalAmtBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(214, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 5;
            label2.Text = "Order No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(206, 157);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 6;
            label3.Text = "Order Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(169, 215);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 7;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(187, 281);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 8;
            label5.Text = "Total Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(169, 344);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(333, 93);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Method";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(215, 45);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "UPI";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(46, 45);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(290, 460);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 40);
            button1.TabIndex = 10;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // qrBox
            // 
            qrBox.Image = (Image)resources.GetObject("qrBox.Image");
            qrBox.Location = new Point(155, 51);
            qrBox.Margin = new Padding(3, 4, 3, 4);
            qrBox.Name = "qrBox";
            qrBox.Size = new Size(377, 387);
            qrBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrBox.TabIndex = 11;
            qrBox.TabStop = false;
            qrBox.Visible = false;
            // 
            // crossBtn
            // 
            crossBtn.BackColor = Color.IndianRed;
            crossBtn.Location = new Point(489, 51);
            crossBtn.Margin = new Padding(3, 4, 3, 4);
            crossBtn.Name = "crossBtn";
            crossBtn.Size = new Size(43, 31);
            crossBtn.TabIndex = 12;
            crossBtn.Text = "❌";
            crossBtn.UseVisualStyleBackColor = false;
            crossBtn.Visible = false;
            crossBtn.Click += button2_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 523);
            Controls.Add(qrBox);
            Controls.Add(crossBtn);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(totalAmtBox);
            Controls.Add(custNameBox);
            Controls.Add(orderDateBox);
            Controls.Add(orderNumBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox orderNumBox;
        private TextBox orderDateBox;
        private TextBox custNameBox;
        private TextBox totalAmtBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private PictureBox qrBox;
        private Button crossBtn;
    }
}