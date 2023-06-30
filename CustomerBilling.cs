using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace customer_billing
{
    public partial class CustomerBilling : Form
    {
        public CustomerBilling()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-THUJOG27\MSSQLNM;Initial Catalog=ScorVigo;Integrated Security=True";

            string customerName = txtCustomerName.Text;
            string customerCellNumber = txtCustomerCellNumber.Text;
            DateTime billingDateTime = BillingDateTimePicker.Value;
            string itemsPurchased = txtItemsPurchased.Text;
            int quantity;
            decimal rate;
            decimal discount;
            decimal billAmount;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerCellNumber) || string.IsNullOrEmpty(itemsPurchased) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtRate.Text) || string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtRate.Text, out rate))
            {
                MessageBox.Show("Invalid rate. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Invalid discount. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate bill amount
            billAmount = quantity * rate * (1 - (discount / 100));

            string query = "INSERT INTO CustomerBilling (CustomerName, CustomerCellNumber, BillingDateTime, ItemsPurchased, Quantity, Rate, Discount, BillAmount) VALUES (@CustomerName, @CustomerCellNumber, @BillingDateTime, @ItemsPurchased, @Quantity, @Rate, @Discount, @BillAmount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@CustomerCellNumber", customerCellNumber);
                    command.Parameters.AddWithValue("@BillingDateTime", billingDateTime);
                    command.Parameters.AddWithValue("@ItemsPurchased", itemsPurchased);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Rate", rate);
                    command.Parameters.AddWithValue("@Discount", discount);
                    command.Parameters.AddWithValue("@BillAmount", billAmount);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Information has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        private void btnBillAmount_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal rate;
            decimal discount;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtRate.Text, out rate))
            {
                MessageBox.Show("Invalid rate. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Invalid discount. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal subtotal = quantity * rate;
            decimal discountedAmount = subtotal * (1 - (discount / 100));

            txtBillAmount.Text = discountedAmount.ToString();
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-THUJOG27\MSSQLNM;Initial Catalog=ScorVigo;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM CustomerBilling";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    CustomerGridView.DataSource = dataTable;
                }

                connection.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-THUJOG27\MSSQLNM;Initial Catalog=ScorVigo;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM CustomerBilling";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    CustomerGridView.DataSource = dataTable;
                }

                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerCellNumber.Text = string.Empty;
            BillingDateTimePicker.Value = DateTime.Now; // Set to default value if needed
            txtItemsPurchased.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtBillAmount.Text = string.Empty;
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtRate.Text, out decimal rate) || txtRate.Text.Contains(","))
            {
                MessageBox.Show("Invalid rate. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Invalid quantity. Only decimal values are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Text = string.Empty;
            }
        }
    }
}
