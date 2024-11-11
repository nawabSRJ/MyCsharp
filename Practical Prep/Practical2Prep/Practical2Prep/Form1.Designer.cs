namespace Practical2Prep
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            col_id = new DataGridViewTextBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            showBtn = new Button();
            completeBtn = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            idBox = new ListBox();
            nameBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
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
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(idBox);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data Read";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_id, col_name });
            dataGridView1.Location = new Point(0, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(82, 100);
            dataGridView1.TabIndex = 4;
            // 
            // col_id
            // 
            col_id.DataPropertyName = "id";
            col_id.HeaderText = "ID";
            col_id.Name = "col_id";
            col_id.ReadOnly = true;
            // 
            // col_name
            // 
            col_name.DataPropertyName = "name";
            col_name.HeaderText = "Name";
            col_name.Name = "col_name";
            col_name.ReadOnly = true;
            col_name.Width = 300;
            // 
            // label4
            // 
            label4.BackColor = Color.LemonChiffon;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(792, 25);
            label4.TabIndex = 3;
            label4.Text = "Data From Table";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(3, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 107);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 30);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(388, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(249, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 31);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(showBtn);
            groupBox1.Controls.Add(completeBtn);
            groupBox1.Location = new Point(591, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // showBtn
            // 
            showBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBtn.Location = new Point(69, 61);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(84, 30);
            showBtn.TabIndex = 1;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            // 
            // completeBtn
            // 
            completeBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completeBtn.Location = new Point(64, 24);
            completeBtn.Name = "completeBtn";
            completeBtn.Size = new Size(96, 30);
            completeBtn.TabIndex = 0;
            completeBtn.Text = "Complete";
            completeBtn.UseVisualStyleBackColor = true;
            completeBtn.Click += completeBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Data Write";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Elements";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // idBox
            // 
            idBox.FormattingEnabled = true;
            idBox.ItemHeight = 15;
            idBox.Location = new Point(330, 252);
            idBox.Name = "idBox";
            idBox.Size = new Size(120, 94);
            idBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.FormattingEnabled = true;
            nameBox.ItemHeight = 15;
            nameBox.Location = new Point(456, 252);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(120, 94);
            nameBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button showBtn;
        private Button completeBtn;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_name;
        private ListBox nameBox;
        private ListBox idBox;
    }
}
