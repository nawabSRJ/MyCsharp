
namespace WinFormsApp1
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
            tabPage1 = new TabPage();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_quantity = new DataGridViewTextBoxColumn();
            product_price = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dashLbl = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            productSearchBox = new GroupBox();
            productListBox = new ListBox();
            button18 = new Button();
            button13 = new Button();
            button12 = new Button();
            searchProdBox = new TextBox();
            custRegisterBox = new GroupBox();
            newCustPhone = new MaskedTextBox();
            newCustAddress = new TextBox();
            newCustPassword = new TextBox();
            newCustEmail = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            button21 = new Button();
            label17 = new Label();
            label18 = new Label();
            newCustName = new TextBox();
            customerLoginBox = new GroupBox();
            button20 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            cust_password = new TextBox();
            cust_email = new TextBox();
            button19 = new Button();
            orderDetailsBox = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            receiptBox = new ListBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            button10 = new Button();
            button11 = new Button();
            panel4 = new Panel();
            button6 = new Button();
            button9 = new Button();
            panel3 = new Panel();
            button7 = new Button();
            button8 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage4 = new TabPage();
            label19 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            productSearchBox.SuspendLayout();
            custRegisterBox.SuspendLayout();
            customerLoginBox.SuspendLayout();
            orderDetailsBox.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(dashLbl);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1342, 701);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PapayaWhip;
            button1.Location = new Point(925, 6);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Red;
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(3, 463);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1007, 235);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stock Alert";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LimeGreen;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(698, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7);
            groupBox1.Size = new Size(313, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Most Selling Products";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(19, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_id, product_name, product_quantity, product_price });
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(701, 211);
            dataGridView1.TabIndex = 0;
            // 
            // product_id
            // 
            product_id.HeaderText = "ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Resizable = DataGridViewTriState.True;
            product_id.Width = 50;
            // 
            // product_name
            // 
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            product_name.Resizable = DataGridViewTriState.True;
            product_name.Width = 260;
            // 
            // product_quantity
            // 
            product_quantity.HeaderText = "Current Quantity";
            product_quantity.Name = "product_quantity";
            product_quantity.ReadOnly = true;
            product_quantity.Resizable = DataGridViewTriState.True;
            product_quantity.Width = 175;
            // 
            // product_price
            // 
            product_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            product_price.HeaderText = "Price (per unit)";
            product_price.Name = "product_price";
            product_price.ReadOnly = true;
            product_price.Resizable = DataGridViewTriState.True;
            product_price.Width = 175;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PapayaWhip;
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1010, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(329, 654);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Weekly Report";
            // 
            // dashLbl
            // 
            dashLbl.BackColor = Color.PapayaWhip;
            dashLbl.Dock = DockStyle.Top;
            dashLbl.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dashLbl.Location = new Point(3, 3);
            dashLbl.Name = "dashLbl";
            dashLbl.Size = new Size(1336, 41);
            dashLbl.TabIndex = 3;
            dashLbl.Text = "Dashboard";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 729);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PapayaWhip;
            tabPage2.Controls.Add(productSearchBox);
            tabPage2.Controls.Add(custRegisterBox);
            tabPage2.Controls.Add(customerLoginBox);
            tabPage2.Controls.Add(button19);
            tabPage2.Controls.Add(orderDetailsBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1342, 701);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            // 
            // productSearchBox
            // 
            productSearchBox.Controls.Add(productListBox);
            productSearchBox.Controls.Add(button18);
            productSearchBox.Controls.Add(button13);
            productSearchBox.Controls.Add(button12);
            productSearchBox.Controls.Add(searchProdBox);
            productSearchBox.Enabled = false;
            productSearchBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSearchBox.Location = new Point(22, 63);
            productSearchBox.Name = "productSearchBox";
            productSearchBox.Size = new Size(325, 431);
            productSearchBox.TabIndex = 6;
            productSearchBox.TabStop = false;
            productSearchBox.Text = "Product Search";
            productSearchBox.Visible = false;
            // 
            // productListBox
            // 
            productListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 21;
            productListBox.Location = new Point(19, 92);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(279, 256);
            productListBox.TabIndex = 2;
            // 
            // button18
            // 
            button18.Location = new Point(165, 358);
            button18.Name = "button18";
            button18.Size = new Size(133, 34);
            button18.TabIndex = 7;
            button18.Text = "Refresh List";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button13
            // 
            button13.Location = new Point(20, 358);
            button13.Name = "button13";
            button13.Size = new Size(133, 34);
            button13.TabIndex = 6;
            button13.Text = "Add to Cart";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(254, 45);
            button12.Name = "button12";
            button12.Size = new Size(44, 33);
            button12.TabIndex = 5;
            button12.Text = "Go";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // searchProdBox
            // 
            searchProdBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchProdBox.Location = new Point(19, 45);
            searchProdBox.Name = "searchProdBox";
            searchProdBox.Size = new Size(229, 35);
            searchProdBox.TabIndex = 4;
            // 
            // custRegisterBox
            // 
            custRegisterBox.BackColor = Color.LightSkyBlue;
            custRegisterBox.Controls.Add(newCustPhone);
            custRegisterBox.Controls.Add(newCustAddress);
            custRegisterBox.Controls.Add(newCustPassword);
            custRegisterBox.Controls.Add(newCustEmail);
            custRegisterBox.Controls.Add(label16);
            custRegisterBox.Controls.Add(label14);
            custRegisterBox.Controls.Add(label15);
            custRegisterBox.Controls.Add(button21);
            custRegisterBox.Controls.Add(label17);
            custRegisterBox.Controls.Add(label18);
            custRegisterBox.Controls.Add(newCustName);
            custRegisterBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            custRegisterBox.Location = new Point(420, 133);
            custRegisterBox.Name = "custRegisterBox";
            custRegisterBox.Size = new Size(502, 435);
            custRegisterBox.TabIndex = 9;
            custRegisterBox.TabStop = false;
            custRegisterBox.Text = "Customer Register";
            custRegisterBox.Visible = false;
            // 
            // newCustPhone
            // 
            newCustPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustPhone.Location = new Point(162, 233);
            newCustPhone.Mask = "0000000000";
            newCustPhone.Name = "newCustPhone";
            newCustPhone.Size = new Size(279, 33);
            newCustPhone.TabIndex = 19;
            // 
            // newCustAddress
            // 
            newCustAddress.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustAddress.Location = new Point(162, 295);
            newCustAddress.Name = "newCustAddress";
            newCustAddress.Size = new Size(279, 33);
            newCustAddress.TabIndex = 18;
            // 
            // newCustPassword
            // 
            newCustPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustPassword.Location = new Point(162, 179);
            newCustPassword.Name = "newCustPassword";
            newCustPassword.Size = new Size(279, 33);
            newCustPassword.TabIndex = 16;
            // 
            // newCustEmail
            // 
            newCustEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustEmail.Location = new Point(162, 121);
            newCustEmail.Name = "newCustEmail";
            newCustEmail.Size = new Size(279, 33);
            newCustEmail.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(65, 298);
            label16.Name = "label16";
            label16.Size = new Size(80, 25);
            label16.TabIndex = 14;
            label16.Text = "Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(79, 240);
            label14.Name = "label14";
            label14.Size = new Size(66, 25);
            label14.TabIndex = 12;
            label14.Text = "Phone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(86, 124);
            label15.Name = "label15";
            label15.Size = new Size(59, 25);
            label15.TabIndex = 11;
            label15.Text = "Email";
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.Location = new Point(135, 362);
            button21.Name = "button21";
            button21.Size = new Size(236, 42);
            button21.TabIndex = 8;
            button21.Text = "Register New Customer";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(54, 182);
            label17.Name = "label17";
            label17.Size = new Size(91, 25);
            label17.TabIndex = 3;
            label17.Text = "Password";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(81, 68);
            label18.Name = "label18";
            label18.Size = new Size(64, 25);
            label18.TabIndex = 2;
            label18.Text = "Name";
            // 
            // newCustName
            // 
            newCustName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustName.Location = new Point(162, 63);
            newCustName.Name = "newCustName";
            newCustName.Size = new Size(279, 33);
            newCustName.TabIndex = 0;
            // 
            // customerLoginBox
            // 
            customerLoginBox.BackColor = Color.LightSkyBlue;
            customerLoginBox.Controls.Add(button20);
            customerLoginBox.Controls.Add(label13);
            customerLoginBox.Controls.Add(label12);
            customerLoginBox.Controls.Add(label11);
            customerLoginBox.Controls.Add(button3);
            customerLoginBox.Controls.Add(label4);
            customerLoginBox.Controls.Add(label3);
            customerLoginBox.Controls.Add(cust_password);
            customerLoginBox.Controls.Add(cust_email);
            customerLoginBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerLoginBox.Location = new Point(424, 118);
            customerLoginBox.Name = "customerLoginBox";
            customerLoginBox.Size = new Size(495, 465);
            customerLoginBox.TabIndex = 0;
            customerLoginBox.TabStop = false;
            customerLoginBox.Text = "Customer Login";
            customerLoginBox.Enter += groupBox4_Enter;
            // 
            // button20
            // 
            button20.Location = new Point(184, 376);
            button20.Name = "button20";
            button20.Size = new Size(133, 49);
            button20.TabIndex = 8;
            button20.Text = "Register";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(238, 342);
            label13.Name = "label13";
            label13.Size = new Size(32, 21);
            label13.TabIndex = 7;
            label13.Text = "OR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(276, 338);
            label12.Name = "label12";
            label12.Size = new Size(103, 17);
            label12.TabIndex = 6;
            label12.Text = "___________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(130, 338);
            label11.Name = "label11";
            label11.Size = new Size(103, 17);
            label11.TabIndex = 5;
            label11.Text = "___________________";
            // 
            // button3
            // 
            button3.Location = new Point(183, 286);
            button3.Name = "button3";
            button3.Size = new Size(133, 49);
            button3.TabIndex = 4;
            button3.Text = "Log in";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(68, 190);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(85, 118);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // cust_password
            // 
            cust_password.Location = new Point(169, 182);
            cust_password.Name = "cust_password";
            cust_password.Size = new Size(279, 39);
            cust_password.TabIndex = 1;
            // 
            // cust_email
            // 
            cust_email.Location = new Point(169, 109);
            cust_email.Name = "cust_email";
            cust_email.Size = new Size(279, 39);
            cust_email.TabIndex = 0;
            // 
            // button19
            // 
            button19.BackColor = Color.Black;
            button19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = Color.PapayaWhip;
            button19.Location = new Point(1253, 7);
            button19.Name = "button19";
            button19.Size = new Size(79, 31);
            button19.TabIndex = 8;
            button19.Text = "Logout";
            button19.UseVisualStyleBackColor = false;
            button19.Visible = false;
            button19.Click += button19_Click;
            // 
            // orderDetailsBox
            // 
            orderDetailsBox.Controls.Add(label10);
            orderDetailsBox.Controls.Add(label9);
            orderDetailsBox.Controls.Add(label8);
            orderDetailsBox.Controls.Add(label7);
            orderDetailsBox.Controls.Add(label6);
            orderDetailsBox.Controls.Add(button17);
            orderDetailsBox.Controls.Add(button16);
            orderDetailsBox.Controls.Add(button15);
            orderDetailsBox.Controls.Add(button14);
            orderDetailsBox.Controls.Add(receiptBox);
            orderDetailsBox.Enabled = false;
            orderDetailsBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderDetailsBox.Location = new Point(392, 63);
            orderDetailsBox.Name = "orderDetailsBox";
            orderDetailsBox.Size = new Size(817, 604);
            orderDetailsBox.TabIndex = 7;
            orderDetailsBox.TabStop = false;
            orderDetailsBox.Text = "Order Details";
            orderDetailsBox.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(582, 41);
            label10.Name = "label10";
            label10.Size = new Size(188, 25);
            label10.TabIndex = 14;
            label10.Text = "Price (per unit)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(311, 41);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 13;
            label9.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 41);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 12;
            label8.Text = "Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(461, 495);
            label7.Name = "label7";
            label7.Size = new Size(309, 25);
            label7.TabIndex = 11;
            label7.Text = "Actions for Complete List :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 495);
            label6.Name = "label6";
            label6.Size = new Size(287, 25);
            label6.TabIndex = 10;
            label6.Text = "Actions for Single Item :";
            // 
            // button17
            // 
            button17.Location = new Point(636, 537);
            button17.Name = "button17";
            button17.Size = new Size(148, 34);
            button17.TabIndex = 9;
            button17.Text = "Place Order";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(482, 537);
            button16.Name = "button16";
            button16.Size = new Size(148, 34);
            button16.TabIndex = 8;
            button16.Text = "Clear List";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Location = new Point(192, 537);
            button15.Name = "button15";
            button15.Size = new Size(148, 34);
            button15.TabIndex = 7;
            button15.Text = "Remove All";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(38, 537);
            button14.Name = "button14";
            button14.Size = new Size(148, 34);
            button14.TabIndex = 6;
            button14.Text = "Remove Once";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // receiptBox
            // 
            receiptBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptBox.FormattingEnabled = true;
            receiptBox.ItemHeight = 21;
            receiptBox.Location = new Point(19, 74);
            receiptBox.Name = "receiptBox";
            receiptBox.Size = new Size(765, 403);
            receiptBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.DeepSkyBlue;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(1336, 40);
            label5.TabIndex = 1;
            label5.Text = "Customer Services Portal";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(flowLayoutPanel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1342, 701);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Search Panel";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Location = new Point(5, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 39);
            panel1.TabIndex = 5;
            // 
            // button10
            // 
            button10.BackColor = Color.LightCoral;
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(-4, -20);
            button10.Name = "button10";
            button10.Size = new Size(233, 78);
            button10.TabIndex = 1;
            button10.Text = "Prediction";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.LightCoral;
            button11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(-11, -20);
            button11.Name = "button11";
            button11.Size = new Size(227, 78);
            button11.TabIndex = 0;
            button11.Text = "Stock";
            button11.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button9);
            panel4.Location = new Point(5, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 39);
            panel4.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCoral;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(-4, -20);
            button6.Name = "button6";
            button6.Size = new Size(233, 78);
            button6.TabIndex = 1;
            button6.Text = "Stock";
            button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightCoral;
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(-11, -20);
            button9.Name = "button9";
            button9.Size = new Size(227, 78);
            button9.TabIndex = 0;
            button9.Text = "Stock";
            button9.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Location = new Point(5, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 39);
            panel3.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = Color.LightCoral;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(-4, -20);
            button7.Name = "button7";
            button7.Size = new Size(233, 78);
            button7.TabIndex = 1;
            button7.Text = "Analytics";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCoral;
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(-11, -20);
            button8.Name = "button8";
            button8.Size = new Size(227, 78);
            button8.TabIndex = 0;
            button8.Text = "Stock";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(5, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 39);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCoral;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(-11, -9);
            button5.Name = "button5";
            button5.Size = new Size(214, 55);
            button5.TabIndex = 1;
            button5.Text = "Stock";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(-11, -20);
            button4.Name = "button4";
            button4.Size = new Size(227, 78);
            button4.TabIndex = 0;
            button4.Text = "Stock";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Snow;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(208, 701);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(flowLayoutPanel2);
            tabPage4.Controls.Add(label19);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1342, 701);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Purchase";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.BackColor = Color.DeepSkyBlue;
            label19.Dock = DockStyle.Top;
            label19.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(1342, 40);
            label19.TabIndex = 2;
            label19.Text = "Supplier and Purchase Data";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 118);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 187);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(193, 282);
            button2.Name = "button2";
            button2.Size = new Size(121, 44);
            button2.TabIndex = 4;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 661);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            productSearchBox.ResumeLayout(false);
            productSearchBox.PerformLayout();
            custRegisterBox.ResumeLayout(false);
            custRegisterBox.PerformLayout();
            customerLoginBox.ResumeLayout(false);
            customerLoginBox.PerformLayout();
            orderDetailsBox.ResumeLayout(false);
            orderDetailsBox.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_quantity;
        private DataGridViewTextBoxColumn product_price;
        private GroupBox groupBox3;
        private Label dashLbl;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox customerLoginBox;
        private Label label4;
        private Label label3;
        private TextBox cust_password;
        private TextBox cust_email;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label5;
        private TabPage tabPage3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button button4;
        private Panel panel3;
        private Button button7;
        private Button button8;
        private Button button5;
        private Panel panel1;
        private Button button10;
        private Button button11;
        private Panel panel4;
        private Button button6;
        private Button button9;
        private GroupBox productSearchBox;
        private ListBox productListBox;
        private Button button12;
        private TextBox searchProdBox;
        private Button button13;
        private GroupBox orderDetailsBox;
        private Button button14;
        private ListBox receiptBox;
        private Label label6;
        private Button button17;
        private Button button16;
        private Button button15;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button18;
        private Button button19;
        private Button button20;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox custRegisterBox;
        private Button button21;
        private Label label17;
        private Label label18;
        private TextBox newCustName;
        private TextBox newCustAddress;
        private TextBox newCustPassword;
        private TextBox newCustEmail;
        private Label label16;
        private Label label14;
        private Label label15;
        private MaskedTextBox newCustPhone;
        private TabPage tabPage4;
        private Label label19;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}