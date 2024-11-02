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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // set the values for stock alert and most selling products
            // set the values for the listBoxes : productListBoxes

            // set what comes first :
            setVisibilityStatus();

            // for productListBox : 
            LoadProductListBox();


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


        /* Remove All from cart
        private void button15_Click(object sender, EventArgs e)
        {
            if (receiptBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            // Remove the selected item entirely from receiptBox
            receiptBox.Items.RemoveAt(receiptBox.SelectedIndex);
            totalAmount -= totalItemPrice;
        }*/

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

        // Add New Customer Button (in customer Register Form)
        private void button21_Click(object sender, EventArgs e)
        {

            // get all the values from the text boxes -> Validate
            // call the DBOperations func
            string newName = newCustName.Text;
            string newEmail = newCustEmail.Text;
            string newPasswd = newCustPassword.Text;
            decimal newPhone = Convert.ToDecimal(newCustPhone.Text);
            string newAddress = newCustAddress.Text;

            // please validate here

            ops.NewCustomer(new Customer(newName, newEmail, newPasswd, newPhone, newAddress));

            // make visibility changes
            custRegisterBox.Visible = false;
            customerLoginBox.Visible= true;

        }

        // Register btn in Customer Login Form
        private void button20_Click(object sender, EventArgs e)
        {
            custRegisterBox.Visible = true;
            customerLoginBox.Visible = false;
        }
    } // Form 2 class ends
}
