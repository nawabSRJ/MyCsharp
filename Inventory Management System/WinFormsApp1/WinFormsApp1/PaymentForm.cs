﻿using System;
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
    public partial class PaymentForm : Form
    {
        DBOperations ops = new DBOperations();
        public string customerName;
        public decimal totalAmount;
        // Variable to store the next order number
        int nextOrderNumber = 1;  // Default to 1 in case there are no previous orders
        // Get current date
        DateTime currentDate = DateTime.Now;

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string query, str;
        public PaymentForm(string customerName, decimal totalAmount)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.totalAmount = totalAmount;

            //Display details on the form as needed
            custNameBox.Text = customerName.ToString();
            totalAmtBox.Text = totalAmount.ToString();
        }

        // get all the details from the Customer form and dislpay them
        // along with the payment method thing
        // get current date and 
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            getDetails();   // orderNo. + orderDate
        }
        private void getDetails()
        {
            
            orderDateBox.Text = currentDate.ToString("dd-MM-yyyy");

            // Connection string
            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";   // srj pc
            //str = "Data Source=pratham;Initial Catalog=sample;Integrated Security=True;"; // pratham
            conn = new SqlConnection(str);

            

            try
            {
                conn.Open();

                // SQL query to get the max order number
                query = "SELECT ISNULL(MAX(order_number), 0) FROM orders"; // ?
                SqlCommand cmd = new SqlCommand(query, conn);

                // Execute the query and retrieve the max order number
                int maxOrderNumber = Convert.ToInt32(cmd.ExecuteScalar());  // returns 1 value

                // Calculate the next order number
                nextOrderNumber = maxOrderNumber + 1;
                orderNumBox.Text = nextOrderNumber.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        } // get details function over


        // UPI radio Button in Payment Method Group Box
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // show the UPI QR
            if (radioButton2.Checked)
            {
                crossBtn.Visible = true;
                qrBox.Visible = true;
            }

        }

        // Done button in Payment Form
        private void button1_Click(object sender, EventArgs e)
        {
            // Check whether payment method is chosen and then commit the order table

            // Step 1: Validate that all entries are filled and one payment method is selected
            if (string.IsNullOrWhiteSpace(orderNumBox.Text) ||
                string.IsNullOrWhiteSpace(orderDateBox.Text) ||
                string.IsNullOrWhiteSpace(custNameBox.Text) ||
                string.IsNullOrWhiteSpace(totalAmtBox.Text) ||
                (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Order Summary Incomplete! Please select a Payment Method.");
                return;
            }

            // Step 2: Commit the order
            ops.NewOrder(new Orders(nextOrderNumber, customerName, totalAmount, currentDate));
            this.Close(); // close the payment form
        }


        // cross Btn
        private void button2_Click(object sender, EventArgs e)
        {
            qrBox.Visible = false; // close
            crossBtn.Visible=false;
            radioButton2.Checked=false;
        }
    }
}
