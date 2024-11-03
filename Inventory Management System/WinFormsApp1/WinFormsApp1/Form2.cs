using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Formats.Tar;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string query, str;
        string customerName = "";
        DBOperations ops = new DBOperations();

        List<Image> images = new List<Image>();
        int imageIndex;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Start();
            setDateDay();
            // set the values for stock alert and most selling products
            // set the values for the listBoxes : productListBoxes
            setStockAlert();
            addImagesCarousel();
            // set what comes first :
            setVisibilityStatus();

            // for productListBox : 
            LoadProductListBox();


        }
        public void addImagesCarousel()
        {
            // absolute path
            images.Add(Image.FromFile("F:\\C# SEM 5\\Inventory Management System\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\feedback3.jpg"));
            images.Add(Image.FromFile("F:\\C# SEM 5\\Inventory Management System\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\feedback1.jpg"));
            images.Add(Image.FromFile("F:\\C# SEM 5\\Inventory Management System\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\feedback2.jpg"));
            images.Add(Image.FromFile("F:\\C# SEM 5\\Inventory Management System\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\feedback4.jpg"));
            imageIndex = 0;
            pictureBox1.Image = images[imageIndex];
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            imageIndex++;
            imageIndex %= images.Count; // returns len of list<>
            pictureBox1.Image = images[imageIndex];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            setDateDay();
            timer1.Start();
        }
        private void setDateDay()
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            dayLbl.Text = DateTime.Now.ToLongDateString();
        }
        private void setVisibilityStatus()
        {
            // initially only login
            customerLoginBox.Visible = true;
            customerLoginBox.Enabled = true;
            //custRegisterBox.Visible = true;
            //custRegisterBox.Enabled = true;


            // disable these :
            orderDetailsBox.Visible = false;
            orderDetailsBox.Enabled = false;

            productSearchBox.Visible = false;
            productSearchBox.Enabled = false;
        }
        private void LoadProductListBox()
        {

            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            // only loading products in stock
            query = "SELECT product_name, product_quantity FROM STOCK WHERE product_quantity > 0";
            cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(); // Initialize data reader

                while (dr.Read())
                {
                    productListBox.Items.Add(dr["product_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dr.Close();       // Close the reader
                conn.Close();      // Close the connection
                cmd.Dispose();     // Dispose of the command
            }

        } // Load Product List Box func ends


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        // CUSTOMER LOGIN click button
        private void button3_Click(object sender, EventArgs e)
        {
            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            string custEmail = cust_email.Text;
            string custPasswd = cust_password.Text;
            query = $"SELECT customer_name , customer_email , customer_password from CUSTOMER where customer_email = '{custEmail}' AND customer_password = '{custPasswd}' ";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows && dr.Read())
                {
                    // record exists

                    customerName = dr["customer_name"].ToString();
                    MessageBox.Show("Logged In Successfully");
                    customerLoginBox.Visible = false;
                    customerLoginBox.Enabled = false;

                    // display + enable the Customer Services Portal
                    productSearchBox.Visible = true;
                    productSearchBox.Enabled = true;
                    orderDetailsBox.Visible = true;
                    orderDetailsBox.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Wrong Credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured : {ex}");
            }
            finally
            {

                dr.Close();
                conn.Close();
                cmd.Dispose();
                button19.Visible = true; // show logout button 
            }


        } // customer login func ends


        // logout button form2 (dashboard)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        // search product in  Button (Go Button) [all edge case covered]
        private void button12_Click(object sender, EventArgs e)
        {
            // refresh list :
            refreshList();

            string searchProd = searchProdBox.Text;
            List<string> matchedItems = new List<string>();


            foreach (var item in productListBox.Items)
            {
                // case-sensitive search
                if (item.ToString().IndexOf(searchProd, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchedItems.Add(item.ToString());  // adding all matching items
                }
            }

            // Display results
            if (matchedItems.Count > 0)
            {
                productListBox.Items.Clear();
                foreach (string matchedItem in matchedItems)
                {
                    productListBox.Items.Add(matchedItem);  // Display all matched items
                }
            }
            else
            {
                MessageBox.Show("Product not found.");
            }

        } // search product func ends



        // add to cart

        // Add to cart
        private void button13_Click(object sender, EventArgs e)
        {
            // Selected item -> get details from name -> place in the group box
            if (productListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            string prodName = productListBox.SelectedItem.ToString();
            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            conn = new SqlConnection(str);
            query = $"SELECT product_quantity, product_price FROM STOCK WHERE product_name = '{prodName}'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            try
            {
                if (dr.HasRows && dr.Read())
                {
                    int prodQuantity = Convert.ToInt32(dr["product_quantity"]);
                    decimal prodPrice = Convert.ToDecimal(dr["product_price"]);
                    bool itemExists = false;

                    // Check if the product already exists in receiptBox
                    for (int i = 0; i < receiptBox.Items.Count; i++)
                    {
                        string item = receiptBox.Items[i].ToString();
                        if (item.IndexOf(prodName, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            itemExists = true;
                            string[] details = item.Split('\t', StringSplitOptions.RemoveEmptyEntries);

                            if (details.Length < 3 || !int.TryParse(details[1].Trim(), out int existingQuantity))
                            {
                                MessageBox.Show("Invalid item format.");
                                return;
                            }

                            int updatedQuantity = existingQuantity + 1; // Increment quantity
                            if (updatedQuantity <= prodQuantity)
                            {
                                // Update existing entry with new quantity
                                decimal updatedPrice = prodPrice * updatedQuantity;
                                receiptBox.Items[i] = $"{prodName}\t{updatedQuantity}\t{updatedPrice:F2}";

                            }
                            else
                            {
                                MessageBox.Show("Insufficient stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        // Add new entry to receiptBox if it doesn't exist
                        receiptBox.Items.Add($"{prodName}\t1\t{prodPrice:F2}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                dr.Close();
                conn.Close();
                cmd.Dispose();
            }
        } // add to cart ends


        // Remove once from cart
        private void button14_Click(object sender, EventArgs e)
        {
            if (receiptBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            string selectedItem = receiptBox.SelectedItem.ToString();
            string[] details = selectedItem.Split('\t', StringSplitOptions.RemoveEmptyEntries);

            if (details.Length < 3)
            {
                MessageBox.Show("Invalid item format.");
                return;
            }

            string prodName = details[0].Trim();
            if (!int.TryParse(details[1].Trim(), out int currentQuantity) || currentQuantity <= 0 ||
                !decimal.TryParse(details[2].Trim(), out decimal totalPrice))
            {
                MessageBox.Show("Invalid quantity or price format.");
                return;
            }

            decimal unitPrice = totalPrice / currentQuantity;

            if (currentQuantity > 1)
            {
                int updatedQuantity = currentQuantity - 1;
                decimal updatedPrice = unitPrice * updatedQuantity;

                // Update the selected item with the new quantity and price
                receiptBox.Items[receiptBox.SelectedIndex] = $"{prodName}\t{updatedQuantity}\t{updatedPrice:F2}";
            }
            else
            {
                // Remove the item if quantity becomes 0
                receiptBox.Items.RemoveAt(receiptBox.SelectedIndex);
            }
        }


        // Remove All from cart
        private void button15_Click(object sender, EventArgs e)
        {
            if (receiptBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            string selectedItem = receiptBox.SelectedItem.ToString();
            string[] details = selectedItem.Split('\t', StringSplitOptions.RemoveEmptyEntries);

            if (details.Length < 3)
            {
                MessageBox.Show("Invalid item format.");
                return;
            }

            if (int.TryParse(details[1].Trim(), out int quantity) && decimal.TryParse(details[2].Trim(), out decimal totalItemPrice))
            {
                receiptBox.Items.RemoveAt(receiptBox.SelectedIndex);

            }
        }


        // clear list button
        private void button16_Click(object sender, EventArgs e)
        {
            receiptBox.Items.Clear();

        }

        // refresh list button
        private void button18_Click(object sender, EventArgs e)
        {
            refreshList();
        }
        private void refreshList()  // function to refresh list
        {
            productListBox.Items.Clear();
            LoadProductListBox();
        }
        private decimal getTotalAmount()
        {
            decimal totalAmount = 0;

            // Loop through each item in receiptBox
            foreach (var item in receiptBox.Items)
            {
                string itemText = item.ToString();
                string[] details = itemText.Split('\t', StringSplitOptions.RemoveEmptyEntries);

                // The last element in details is the price
                if (decimal.TryParse(details[^1], out decimal price))
                {
                    totalAmount += price;
                }
            }
            return totalAmount;
        }


        // place order
        private void button17_Click(object sender, EventArgs e)
        {
            //Algo : 
            // Confirm Order using MessageBox -> make a form to display the payable amount and
            // the method to pay -> Click on Done -> Make changes in Order + Stock

            DialogResult result = MessageBox.Show("Are you sure you want to place the order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Code to place the order
                decimal totalAmount = getTotalAmount();
                MessageBox.Show("Order placed successfully!"); // show Payment Form
                PaymentForm pfm = new PaymentForm(customerName, totalAmount);
                pfm.ShowDialog(); //  Customer Name Total Amount to be sent to Payment Form


                Dictionary<string, int> ItemsBought = new Dictionary<string, int>();

                // Iterate over each item in the receiptBox
                foreach (var item in receiptBox.Items)
                {
                    // Split the string by tabs to extract prodName and updatedQuantity
                    string[] parts = item.ToString().Split('\t');

                    if (parts.Length >= 2)
                    {
                        string prodName = parts[0];
                        int quantity = int.Parse(parts[1]); // Directly parse the quantity as an integer

                        // Add to the dictionary
                        ItemsBought[prodName] = quantity;
                    }
                }

                ops.DecreaseStock(ItemsBought);
            }
            else
            {
                // Code if the user selects "No"
                MessageBox.Show("Order canceled.");
            }



        }

        // Logout button at Customer Services Portal
        private void button19_Click(object sender, EventArgs e)
        {
            orderDetailsBox.Visible = false;
            orderDetailsBox.Enabled = false;
            productSearchBox.Visible = false;
            productSearchBox.Enabled = false;


            cust_email.Text = "";
            cust_password.Text = "";
            customerLoginBox.Visible = true;
            customerLoginBox.Enabled = true;

            button19.Visible = false; // hide this button as well
        }

        private bool validPhoneNumber(string phn)
        {
            if (phn.Length != 10) { return false; }
            foreach (char s in phn)
            {
                if (!char.IsDigit(s))
                {
                    return false;
                }
            }
            return true;
        }

        // Add New Customer Button (in customer Register Form)
        private void button21_Click(object sender, EventArgs e)
        {
            // Validate inputs 
            if (string.IsNullOrWhiteSpace(newCustName.Text) ||
                string.IsNullOrWhiteSpace(newCustAddress.Text) ||
                string.IsNullOrWhiteSpace(newCustEmail.Text) ||
                string.IsNullOrWhiteSpace(newCustPassword.Text) ||
                !validPhoneNumber(newCustPhone.Text.ToString()))
            {
                MessageBox.Show("Please enter all details properly");
                return;
            }


            decimal newPhone;
            try
            {
                newPhone = Convert.ToDecimal(newCustPhone.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid phone number.");
                newCustPhone.Focus(); // Set focus back to the masked text box
                return;
            }

            // get all the values from the text boxes -> Validate
            // call the DBOperations func
            string newName = newCustName.Text;
            string newEmail = newCustEmail.Text;
            string newPasswd = newCustPassword.Text;
            string newAddress = newCustAddress.Text;

            // please validate here

            ops.NewCustomer(new Customer(newName, newEmail, newPasswd, newPhone, newAddress));

            // make visibility changes
            custRegisterBox.Visible = false;
            customerLoginBox.Visible = true;

        }

        // Register btn in Customer Login Form
        private void button20_Click(object sender, EventArgs e)
        {
            custRegisterBox.Visible = true;
            customerLoginBox.Visible = false;
        }

        // no use
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        // no use
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // New Stock Entry Click
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            stockEntryForm.Visible = true;
            stockEntryForm.Enabled = true;

            purchaseHistoryForm.Visible = false;
            purchaseHistoryForm.Enabled = false;
        }
        // New Stock Entry Click
        private void label20_Click(object sender, EventArgs e)
        {
            stockEntryForm.Visible = true;
            stockEntryForm.Enabled = true;

            purchaseHistoryForm.Visible = false;
            purchaseHistoryForm.Enabled = false;
        }
        // Purchase History Click
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            stockEntryForm.Visible = false;
            stockEntryForm.Enabled = false;

            purchaseHistoryForm.Visible = true;
            purchaseHistoryForm.Enabled = true;


        }
        // Purchase History
        private void label22_Click(object sender, EventArgs e)
        {
            stockEntryForm.Visible = false;
            stockEntryForm.Enabled = false;

            purchaseHistoryForm.Visible = true;
            purchaseHistoryForm.Enabled = true;
        }


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }


        // Purchase Button 
        private void button23_Click(object sender, EventArgs e)
        {
            // check if all values are filled
            // validate


            // commit (2 tables)
            string supplierName = textBox3.Text;
            DateTime supplyDate = supDate.Value;
            decimal totalAmt = Convert.ToDecimal(textBox5.Text);

            int latestPurchaseId = ops.NewPurchase(new Purchase(supplierName, supplyDate, totalAmt));

            // commit in PurchaseDetails (validate at start only)

            // Task : get latest purchase id -> get data from data grid view
            // Commit to PurchaseDetails for each product in the DataGridView
            foreach (DataGridViewRow row in stockDataGrid.Rows)
            {
                // Ensure the row is not empty
                if (!row.IsNewRow)
                {
                    string productName = row.Cells["ProductName"].Value?.ToString();
                    int productQuantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                    decimal productPrice = Convert.ToDecimal(row.Cells["ProductPrice"].Value);
                    string productDescription = row.Cells["ProductDescription"].Value?.ToString();

                    // Call NewPurchaseDetails for each product in the DataGridView
                    ops.NewPurchaseDetails(new PurchaseDetails(latestPurchaseId, productName, productQuantity, productPrice, productDescription));
                }
            }

            MessageBox.Show("Purchase and product details added successfully.");


        }

        // Submit button to append products 
        private void stockSubmitBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs 
            if (string.IsNullOrWhiteSpace(textBox8.Text) ||
                numericUpDown1.Value <= 0 ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Please enter all product details.");
                return;
            }

            // get data from inputs 
            string productName = textBox8.Text;
            int productQuantity = (int)numericUpDown1.Value;
            decimal productPrice = Convert.ToDecimal(textBox6.Text);
            string productDescription = textBox9.Text;


            // Add a new row to the DataGridView + increase total Payment textBox
            stockDataGrid.Rows.Add(productName, productQuantity, productPrice, productDescription);
            textBox5.Text = (Convert.ToInt32(textBox5.Text) + (productQuantity * productPrice)).ToString();
            // Clear input fields for the next entry
            textBox8.Clear();
            numericUpDown1.Value = 0;
            textBox6.Clear();
            textBox9.Clear();

            //MessageBox.Show("Product added to the list.");
        }

        // clear filters button in purchase history form
        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        // no use
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Search button Stock section
        private void button28_Click(object sender, EventArgs e)
        {
            // Take parameter type and value from stockParameterBox and stockParameter
            if (string.IsNullOrWhiteSpace(stockParameterBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(stockParameter.Text))
            {
                MessageBox.Show("Please select a parameter and enter the values");
                return;
            }

            string paraType = stockParameterBox.Text;
            string paraEntry = stockParameter.Text;
            DataTable stockData = ops.ShowStockData(paraType, paraEntry);

            stockSearchGrid.DefaultCellStyle.ForeColor = Color.Black;
            stockSearchGrid.DefaultCellStyle.BackColor = Color.White;


            if (stockData.Rows.Count > 0)
            {
                stockSearchGrid.DataSource = stockData;
                MessageBox.Show("Data loaded successfully.");
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }


        private void stockParameterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockParameterBox.SelectedItem.ToString() == "Complete Stock")
            {
                stockParameter.Text = "All";
                stockParameter.Enabled = false;
            }
            else
            {
                stockParameter.Text = "";
                stockParameter.Enabled = true;
            }
        }

        // Stock Button in Searh Panel
        private void button5_Click(object sender, EventArgs e)
        {
            stockDataForm.Visible = true;
            stockDataForm.Enabled = true;
        }

        // Analytics Button Click
        private void button7_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the disable and enable things here

            if (comboBox1.SelectedItem.ToString() == "Supplier")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                textBox4.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Date")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                dateTimePicker1.Enabled = true;
                label34.Text = "Pick Date : ";
            }
            else if (comboBox1.SelectedItem.ToString() == "Minimum Price")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                textBox7.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Maximum Price")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                textBox10.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Date Range")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                label34.Text = "Start Date";
                label35.Text = "End Date";
            }
            else if (comboBox1.SelectedItem.ToString() == "Price Range")
            {
                foreach (Control ctrl in purchaseFilters.Controls)
                {
                    if (ctrl is TextBox || ctrl is DateTimePicker)
                    {
                        ctrl.Enabled = false;
                    }
                }
                textBox7.Enabled = true;
                textBox10.Enabled = true;
            }
        }

        // Purchase Tab Search Button
        private void button27_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a parameter and enter the values");
                return;
            }

            string paraType = comboBox1.Text;
            string paraEntry = "";
            // supplier -> date , min , max 
            if (paraType == "Supplier")
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please enter the Supplier Name");
                    return;
                }
                paraEntry = textBox4.Text;
            }
            else if (paraType == "Date")
            {
                DateTime startDate = dateTimePicker1.Value;
                paraEntry = startDate.ToString("yyyy-MM-dd");

            }
            else if (paraType == "Minimum Price")
            {
                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Please enter the Min Price");
                    return;
                }
                paraEntry = textBox7.Text; // later convert to decimal
            }
            else if (paraType == "Maximum Price")
            {
                if (string.IsNullOrWhiteSpace(textBox10.Text))
                {
                    MessageBox.Show("Please enter the Max Price");
                    return;
                }
                paraEntry = textBox10.Text;  // later convert to decimal
            }
            else if (paraType == "Date Range")
            {
                DateTime startDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;
                DataTable ans = ops.ShowPurchaseData(paraType, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
                if (ans.Rows.Count > 0)
                {
                    dataGridView2.DataSource = ans;
                    return;
                }
                else
                {
                    MessageBox.Show("No data found.");
                    return;
                }
            }
            else if (paraType == "Price Range")
            {
                string minPrice = textBox7.Text;
                string maxPrice = textBox10.Text;   // later convert to decimal
                DataTable ans = ops.ShowPurchaseData(paraType, minPrice, maxPrice);
                if (ans.Rows.Count > 0)
                {
                    dataGridView2.DataSource = ans;
                    return;
                }
                else
                {
                    MessageBox.Show("No data found.");
                    return;
                }
            }



            DataTable purchaseData = ops.ShowPurchaseData(paraType, paraEntry);

            if (purchaseData.Rows.Count > 0)
            {
                dataGridView2.DataSource = purchaseData;
                MessageBox.Show("Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("No data found.");
            }

        }

        // Show Complete History Button in Purchase Tab
        private void button25_Click(object sender, EventArgs e)
        {
            //ops.ShowPurchaseData("All" , "*");
            DataTable purchaseData = ops.ShowPurchaseData("All", "*");

            if (purchaseData.Rows.Count > 0)
            {
                dataGridView2.DataSource = purchaseData;
                MessageBox.Show("Data Loaded Successfully");
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        // clear button in Stock Entry Form
        private void button22_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in stockEntryForm.Controls)
            {
                if (ctrl is TextBox textBox)
                {

                    textBox.Clear();
                }
                else if (ctrl is DateTimePicker dateTimePicker)
                {

                    dateTimePicker.Value = DateTime.Now;
                }
                else if (ctrl is NumericUpDown numericUpDown)
                {

                    numericUpDown.Value = numericUpDown.Minimum; // reset
                }
                else if (ctrl is DataGridView dataGridView)
                {

                    dataGridView.Rows.Clear();
                }
            }

        }

        // load the stock alert , 
        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Set the Stock Alert
            setStockAlert();

            // set the most selling product

        }
        private void setStockAlert()
        {
            DataTable stockAlertData = ops.StockAlert();
            stockAlertGrid.DataSource = stockAlertData;
        }
        private void mostSellingProduct()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            custRegisterBox.Visible = false;
            customerLoginBox.Visible = true;
        }

        
    } // Form 2 class ends
}
