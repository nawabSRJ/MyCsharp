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
            label1.Location = new Point(226, 14);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Order Summary";
            // 
            // orderNumBox
            // 
            orderNumBox.Location = new Point(279, 67);
            orderNumBox.Name = "orderNumBox";
            orderNumBox.Size = new Size(171, 23);
            orderNumBox.TabIndex = 1;
            // 
            // orderDateBox
            // 
            orderDateBox.Location = new Point(279, 112);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(171, 23);
            orderDateBox.TabIndex = 2;
            // 
            // custNameBox
            // 
            custNameBox.Location = new Point(279, 160);
            custNameBox.Name = "custNameBox";
            custNameBox.Size = new Size(171, 23);
            custNameBox.TabIndex = 3;
            // 
            // totalAmtBox
            // 
            totalAmtBox.Location = new Point(279, 205);
            totalAmtBox.Name = "totalAmtBox";
            totalAmtBox.Size = new Size(171, 23);
            totalAmtBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(187, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 5;
            label2.Text = "Order No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(180, 118);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 6;
            label3.Text = "Order Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(148, 161);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 7;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(164, 211);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 8;
            label5.Text = "Total Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(148, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 70);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Method";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(188, 34);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 21);
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
            radioButton1.Location = new Point(40, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(254, 345);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 10;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // qrBox
            // 
            qrBox.Image = (Image)resources.GetObject("qrBox.Image");
            qrBox.Location = new Point(136, 38);
            qrBox.Name = "qrBox";
            qrBox.Size = new Size(330, 290);
            qrBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrBox.TabIndex = 11;
            qrBox.TabStop = false;
            qrBox.Visible = false;
            // 
            // crossBtn
            // 
            crossBtn.BackColor = Color.IndianRed;
            crossBtn.Location = new Point(428, 38);
            crossBtn.Name = "crossBtn";
            crossBtn.Size = new Size(38, 23);
            crossBtn.TabIndex = 12;
            crossBtn.Text = "❌";
            crossBtn.UseVisualStyleBackColor = false;
            crossBtn.Visible = false;
            crossBtn.Click += button2_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 392);
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
            Name = "PaymentForm";
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