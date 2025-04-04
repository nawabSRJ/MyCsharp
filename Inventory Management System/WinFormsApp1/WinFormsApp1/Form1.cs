using System;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        //string query;
        string str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;"; // srj pc
        //string str = "Data Source=pratham;Initial Catalog=sample;Integrated Security=True;"; // pratham pc
        int carCount = 0, roadCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load captcha

        }

        private void LoadCaptcha()
        {
            Random r = new Random();
            int[] randomIds = new int[6];
            HashSet<int> generatedIds = new HashSet<int>(); // for random Ids
                                                            // Populate the array with random integers between 1 and 20
            for (int i = 0; i < 6; i++)
            {
                int newId;
                do
                {
                    newId = r.Next(1, 21); // Generates a number between 1 and 20
                } while (generatedIds.Contains(newId)); // Ensure no duplicates
                generatedIds.Add(newId);
                randomIds[i] = newId;
            }

            //str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            //str = "Data Source=pratham;Initial Catalog=sample;Integrated Security=True;";
            conn = new SqlConnection(str);
            string query = $"SELECT ImgName , ImgPath FROM ImageCaptcha WHERE ImgId in ({randomIds[0]},{randomIds[1]}, {randomIds[2]},{randomIds[3]},{randomIds[4]},{randomIds[5]})";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            List<string> captchaImages = new List<string>();
            while (dr.Read())
            {

                string path = dr["ImgPath"].ToString();
                string name = dr["ImgName"].ToString();
                if (name == "Car")
                {
                    carCount++;
                    captchaImages.Add(path);

                }
                else if (name == "Road")
                {
                    roadCount++;
                    captchaImages.Add(path);
                }
                if (carCount + roadCount == 6)
                {
                    break;
                }

            }
            dr.Close();
            conn.Close();
            cmd.Dispose();

            // adding images to pictureBoxes
            pictureBox1.Image = Image.FromFile(captchaImages.ElementAt(0));
            pictureBox2.Image = Image.FromFile(captchaImages.ElementAt(1));
            pictureBox3.Image = Image.FromFile(captchaImages.ElementAt(2));
            pictureBox4.Image = Image.FromFile(captchaImages.ElementAt(3));
            pictureBox5.Image = Image.FromFile(captchaImages.ElementAt(4));
            pictureBox6.Image = Image.FromFile(captchaImages.ElementAt(5));
        }


        // submit button on the login page

        private void button1_Click(object sender, EventArgs e)
        {
            DBOperations dbobj = new DBOperations();
            // read data from admin table
            //str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;";
            //str = "Data Source=pratham;Initial Catalog=sample;Integrated Security=True;";
            conn = new SqlConnection(str);
            string query = $"SELECT * FROM Admin where admin_email = '{usernameBox.Text}' and admin_password = '{passwdBox.Text}' ";
            string adminEmail = "", adminPassword = "";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    dr.Read(); // only one record to read
                    adminEmail = dr["admin_email"].ToString();
                    adminPassword = dr["admin_password"].ToString();
                    if (usernameBox.Text == adminEmail && passwdBox.Text == adminPassword)
                    {
                        dbobj.setAdminLogs(dr["admin_id"].ToString(), dr["admin_name"].ToString(), dr["admin_email"].ToString(), dr["admin_phone"].ToString(), DateTime.Now);
                        // show captcha
                        LoadCaptcha();
                        captchaBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials!! Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("No Admin Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
                dr.Close();
                cmd.Dispose();


            }

        }

        // show password checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwdBox.PasswordChar = '\0'; // null character
            }
            else if (!checkBox1.Checked)
            {
                passwdBox.PasswordChar = '*';
            }
        }

        // validate captcha answer
        private void button2_Click(object sender, EventArgs e)
        {
            int user_ans = Convert.ToInt32(captchaAnswer.Value);
            if (user_ans == carCount)
            {
                MessageBox.Show("Right Answer");
                // clear for correct calc next time
                carCount = 0;
                roadCount = 0;


                // load Dashboard 
                Form2 fm2 = new Form2();
                fm2.ShowDialog();
                //this.Close();
                captchaBox1.Visible = false;
                usernameBox.Clear();
                passwdBox.Clear();

            }
            else
            {
                MessageBox.Show("Wrong Answer");

            }

        }
    }

    // ------------------------------ IMS Entities --------------------------------------------
    public class Customer
    {
        public string cutomer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_password { get; set; }
        public decimal customer_phone { get; set; }  // change in SQL

        public string customer_address { get; set; }

        public Customer(string name, string email, string password, decimal phone, string address)
        {
            this.cutomer_name = name;
            this.customer_email = email;
            this.customer_password = password;
            this.customer_phone = phone;
            this.customer_address = address;
        }


    } // Customer Class ends

    class Admin
    {
        int admin_id { get; }
        string admin_name { get; set; }
        string admin_email { get; set; }
        string admin_password { get; set; }

        string admin_phone { get; set; }

        string admin_address { get; set; }

        public Admin(string name, string email, string password, string phone, string address)
        {
            this.admin_name = name;
            this.admin_email = email;
            this.admin_password = password;
            this.admin_phone = phone;
            this.admin_address = address;
        }


    } // Admin Class ends

    class Supplier  // change name to purchase
    {
        string supplier_name { get; set; }
        string product_name { get; set; }
        string product_quantity { get; set; }
        string product_price { get; set; }
        string product_description { get; set; }
        DateTime dateOfSupply { get; set; }   // think about this
        int total_payment { get; set; }

    } // Supplier class ends

    public class Orders
    {

        public int order_number { get; set; }
        public string customer_name { get; set; }
        public decimal order_amount { get; set; }
        public DateTime order_date { get; set; }

        // constructor
        public Orders(int orderNum, string custName, decimal orderAmt, DateTime orderDate)
        {
            this.order_number = orderNum;
            this.customer_name = custName;
            this.order_amount = orderAmt;
            this.order_date = orderDate;
        }

    } // Order class ends

    class Stock
    {
        int product_id { get; set; }    // automatically generated
        string product_name { get; set; }
        int product_quantity { get; set; }
        decimal product_price { get; set; }
        string product_description { get; set; }

        public Stock(int id, string name, int quantity, decimal price, string desc)
        {
            this.product_id = id;
            this.product_name = name;
            this.product_price = price;
            this.product_quantity = quantity;
            this.product_description = desc;
        }

    } // Stock class ends

    public class Purchase
    {
        public int purchase_id { get; }
        public string supplier_name { get; set; }
        public DateTime dateOfSupply { get; set; }
        public decimal totalPayment { get; set; }

        // Constructor
        public Purchase(string supplierName, DateTime supplyDate, decimal payment)
        {

            this.supplier_name = supplierName;
            this.dateOfSupply = supplyDate;
            this.totalPayment = payment;
        }

    }

    public class PurchaseDetails
    {
        public int purchase_id { get; set; } // you need to set purchase id here 
        public string product_name { get; set; }
        public int product_quantity { get; set; }
        public decimal product_price { get; set; }
        public string product_description { get; set; }

        public PurchaseDetails(int purId, string prodName, int prodQuantity, decimal prodPrice, string desc)
        {
            this.purchase_id = purId;
            this.product_name = prodName;
            this.product_quantity = prodQuantity;
            this.product_price = prodPrice;
            this.product_description = desc;
        }
    }


    // ----------------------------------- DB Operations Class
    public class DBOperations
    {
        // SQL Class
        private string str = "";
        public SqlConnection conn;
        public DBOperations()
        {
            str = "Server=localhost;Database=SAMPLE;Trusted_Connection=True;"; //srj pc
            //str = "Data Source=pratham;Initial Catalog=sample;Integrated Security=True;"; // pratham pc
            conn = new SqlConnection(str);
        }
        public void DecreaseStock(Dictionary<string, int> dict)
        {
            int affect = 0;
            try
            {
                conn.Open(); // Open the connection once for all updates

                foreach (var item in dict)
                {
                    string productName = item.Key;
                    int quantityToDecrease = item.Value;

                    // Update query to decrease the stock based on product_name
                    string query = $"UPDATE STOCK SET product_quantity = product_quantity - {quantityToDecrease} WHERE product_name = '{productName}'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    affect += cmd.ExecuteNonQuery(); // foreach execution
                }
                MessageBox.Show($"Rows Affected : {affect}");

                MessageBox.Show("Stock quantities have been updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating stock: {ex.Message}");
            }
            finally
            {
                conn.Close(); // Ensure the connection is closed
            }
        }

        public void IncreaseStock(string productName, int quantityToAdd, decimal productPrice, string productDescription)
        {
            try
            {
                conn.Open();

                // Check if the product already exists in the stock (case-insensitive)
                string checkQuery = $"SELECT COUNT(*) FROM STOCK WHERE LOWER(product_name) = '{productName.ToLower()}'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int productExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (productExists > 0)
                {
                    // Update existing product's quantity
                    string updateQuery = $"UPDATE STOCK SET product_quantity = product_quantity + {quantityToAdd} WHERE LOWER(product_name) = '{productName.ToLower()}'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    int rowsUpdated = updateCmd.ExecuteNonQuery();
                    MessageBox.Show($"Product '{productName}' quantity increased. Rows Affected: {rowsUpdated}");
                }
                else
                {
                    // Insert new product 
                    string insertQuery = $"INSERT INTO STOCK (product_name, product_quantity, product_price, product_description) VALUES ('{productName}', {quantityToAdd}, {productPrice}, '{productDescription}')";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    int rowsInserted = insertCmd.ExecuteNonQuery();
                    MessageBox.Show($"New product '{productName}' added to stock. Rows Affected: {rowsInserted}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating stock: {ex}");
            }
            finally
            {
                conn.Close();
            }
        }


        public void NewOrder(Orders obj)
        {
            // commit the order on click of Done button
            string query = $"INSERT INTO ORDERS  (customer_name, order_amount, order_date) VALUES ('{obj.customer_name}', {obj.order_amount}, '{obj.order_date.ToString("yyyy-MM-dd")}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
            MessageBox.Show("Order Commited Successfully");
        }

        public void NewCustomer(Customer obj)
        {
            try
            {
                string query = $"INSERT INTO CUSTOMER VALUES ('{obj.cutomer_name}', '{obj.customer_email}', '{obj.customer_password}', {obj.customer_phone}, '{obj.customer_address}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteScalar();

                MessageBox.Show("New Customer Created Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Exception Occured : {ex}");
            }
            finally
            {
                conn.Close();
            }
        }

        public int NewPurchase(Purchase obj)
        {
            int id = -1; // initially
            try
            {
                string query = $"INSERT INTO Purchase (supplier_name, date_of_supply, total_payment) VALUES ('{obj.supplier_name}', '{obj.dateOfSupply.ToString("yyyy-MM-dd")}' , {obj.totalPayment}); " + "SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();

            }
            return id; // latest purchase id
        }

        public void NewPurchaseDetails(PurchaseDetails obj)
        {
            try
            {
                string query = $"INSERT INTO PurchaseDetails (purchase_id, product_name, product_quantity, product_price, product_description) VALUES ({obj.purchase_id}, '{obj.product_name}', {obj.product_quantity}, {obj.product_price}, '{obj.product_description}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }

            // update stock table (increase stock)
            IncreaseStock(obj.product_name, obj.product_quantity, obj.product_price, obj.product_description);

        }

        public DataTable ShowStockData(string paraType, string paraEntry)
        {
            DataTable dt = new DataTable();  // Create a DataTable to hold the data
            try
            {
                string query = "";

                if (paraType == "Complete Stock")
                {
                    query = "SELECT * FROM STOCK";
                }
                else if (paraType == "Product Name")
                {
                    query = $"SELECT * FROM STOCK WHERE product_name LIKE '%{paraEntry}%'";
                }
                else if (paraType == "Product Quantity")
                {
                    query = $"SELECT * FROM STOCK WHERE product_quantity = '{paraEntry}'";
                }

                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // ------------------------------------ Orders --------------------------------------
        // overloaded function for order data
        public DataTable ShowOrderData(string paraType, string paraEntry)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "";
                if (paraType == "All")
                {
                    query = $"SELECT * FROM Orders";
                }
                else if (paraType == "Order Number")
                {
                    query = $"SELECT * FROM Orders WHERE order_number = {Convert.ToInt32(paraEntry)} ";
                }
                else if (paraType == "Customer Name")
                {
                    query = $"SELECT * FROM Orders WHERE customer_name LIKE '%{paraEntry}%' ";
                }
                else if (paraType == "Order Amount")
                {
                    query = $"SELECT * FROM Orders WHERE order_amount = {Convert.ToInt32(paraEntry)} ";
                }
                else if (paraType == "Date")
                {
                    query = $"SELECT * FROM Orders WHERE order_date = '{paraEntry}' ";
                }
                conn.Open();
                if(string.IsNullOrEmpty(query))
                {
                    MessageBox.Show("query empty");
                }
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occured\n : {ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable ShowOrderData(string paraType, string paraEntry1, string paraEntry2)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "";
                if (paraType == "Date Range")
                {
                    query = $"SELECT * FROM Orders WHERE order_date between '{paraEntry1}' AND '{paraEntry2}' ";
                }
                else if (paraType == "Price Range")
                {
                    query = $"SELECT * FROM Orders WHERE order_amount between {Convert.ToInt32(paraEntry1)} AND {Convert.ToInt32(paraEntry2)} ";
                }
                conn.Open();
                if (string.IsNullOrEmpty(query))
                {
                    MessageBox.Show("query empty");
                }
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        

        //----------------------------- Purchase ------------------------------------
        // overload this function for different paraEntries
        public DataTable ShowPurchaseData(string paraType, string paraEntry) // single paraEntry
        {
            DataTable dt = new DataTable();
            try
            {
                
                string query = ""; 
                if (paraType == "All")
                {
                    query = $"SELECT * FROM Purchase";
                }
                else if (paraType == "Date")
                {
                    query = $"SELECT * FROM Purchase WHERE date_of_supply = '{paraEntry}'";
                }
                else if (paraType == "Supplier")
                {
                    query = $"SELECT * FROM Purchase WHERE supplier_name LIKE '%{paraEntry}%' ";
                }
                else if (paraType == "Minimum Price")
                {
                    query = $"SELECT * FROM Purchase WHERE total_payment > {Convert.ToDecimal(paraEntry)} ";
                }
                else if (paraType == "Maximum Price")
                {
                    query = $"SELECT * FROM Purchase WHERE total_payment < {Convert.ToDecimal(paraEntry)} ";
                }
                conn.Open();
                
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable ShowPurchaseData(string paraType, string paraEntry1, string paraEntry2)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "";
                if (paraType == "Date Range")
                {
                    query = $"SELECT * FROM Purchase WHERE date_of_supply between '{paraEntry1}' AND '{paraEntry2}' ";
                }
                else if (paraType == "Price Range")
                {
                    query = $"SELECT * FROM Purchase WHERE total_payment between '{Convert.ToDecimal(paraEntry1)}' AND '{Convert.ToDecimal(paraEntry2)}' ";
                }
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable StockAlert()
        {
            DataTable dt = new DataTable();  // Create a DataTable to hold the data
            string query = "";
            try
            {
                query = "SELECT product_id , product_name , product_quantity, product_price FROM STOCK WHERE product_quantity < 30 ";
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void setAdminLogs(string id, string name, string email, string phone, DateTime loginTime)
        {
            string query = "";
            try
            {

                string formattedDate = loginTime.ToString("yyyy-MM-dd HH:mm:ss");

                query = $"INSERT INTO AdminLogs VALUES ({Convert.ToInt32(id)}, '{name}', '{email}', {Convert.ToDecimal(phone)}, '{formattedDate}')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable getAdminLogs()
        {
            DataTable dt = new DataTable();
            string query = "";
            try
            {
                query = "SELECT * FROM AdminLogs";
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, conn);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
