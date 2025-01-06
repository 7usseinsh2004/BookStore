using Guna.UI2.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class Books : UserControl
    {
        string id;
        public Books(string cuId)
        {
            InitializeComponent();
            id= cuId;
        }

        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        private void dataBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBooks.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                    bTitle.Text = selectedRow.Cells["Book"].Value?.ToString() ?? string.Empty;
                    price.Text = selectedRow.Cells["Price"].Value?.ToString() ?? string.Empty;
                    quantity.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void orderDataGrid()
        {
            try
            {
                string bookTitle = bTitle.Text;
                int qty = int.Parse(quantity.Text);
                decimal unitPrice = decimal.Parse(price.Text) / qty;
                decimal totalPrice = unitPrice * qty;

                bool bookExists = false;

                foreach (DataGridViewRow row in dataItems.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == bookTitle)
                    {
                        int existingQty = int.Parse(row.Cells[1].Value.ToString());
                        int newQty = existingQty + qty;
                        row.Cells[1].Value = newQty.ToString();
                        row.Cells[3].Value = (unitPrice * newQty).ToString("0.00");
                        bookExists = true;
                        break;
                    }
                }

                if (!bookExists)
                {
                    dataItems.Rows.Add(bookTitle, qty.ToString(), unitPrice.ToString("0.00"), totalPrice.ToString("0.00"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = catCombo.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }
        private void Books_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategoriesIntoComboBox();
        }

        int qu = 0;
        decimal pric = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            qu = int.Parse(quantity.Text);
            Guna2Button b = (Guna2Button)sender;

            if (b == plusBtn)
            {
                if (dataBooks.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                    int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                    pric = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                    if (qu < currentQuantity)
                    {
                        qu++;
                        quantity.Text = qu.ToString();
                        decimal total = pric * qu;
                        price.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Entered quantity is greater than or equal to the available quantity.");
                    }
                }
            }
            else if (b == minusBtn)
            {
                if (dataBooks.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                    int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                    decimal pric = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                    if (qu > 1)
                    {
                        qu--;
                        quantity.Text = qu.ToString();
                        decimal total = pric * qu;
                        price.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Entered quantity is equal to one.");
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            orderDataGrid();
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataItems.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataItems.SelectedRows)
                    {
                        dataItems.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataItems.Rows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            dataReceipt.Rows.Clear();
                            decimal totalPrice = 0;

                            foreach (DataGridViewRow row in dataItems.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string bookTitle = row.Cells["Column1"].Value?.ToString() ?? string.Empty;
                                    int orderedQuantity = Convert.ToInt32(row.Cells["Column2"].Value);
                                    decimal unitPrice = Convert.ToDecimal(row.Cells["Column3"].Value);
                                    decimal totalRowPrice = orderedQuantity * unitPrice;

                                    dataReceipt.Rows.Add(bookTitle, unitPrice.ToString("0.00"), orderedQuantity);
                                    totalPrice += totalRowPrice;

                                    string getBookIdQuery = "SELECT bookId FROM books WHERE title = @Title";
                                    int bookId = 0;
                                    using (SqlCommand getBookIdCmd = new SqlCommand(getBookIdQuery, conn, transaction))
                                    {
                                        getBookIdCmd.Parameters.AddWithValue("@Title", bookTitle);
                                        object result = getBookIdCmd.ExecuteScalar();
                                        if (result != null)
                                        {
                                            bookId = Convert.ToInt32(result);
                                        }
                                        else
                                        {
                                            throw new Exception("Book not found in the database.");
                                        }
                                    }

                                    string insertOrderQuery = @"
                                INSERT INTO _order (quantity, customerId)
                                VALUES (@Quantity, @CustomerId);
                                SELECT SCOPE_IDENTITY();";

                                    int orderId = 0;
                                    using (SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, conn, transaction))
                                    {
                                        insertOrderCmd.Parameters.AddWithValue("@Quantity", orderedQuantity);
                                        insertOrderCmd.Parameters.AddWithValue("@CustomerId", id);
                                        orderId = Convert.ToInt32(insertOrderCmd.ExecuteScalar());
                                    }

                                    string insertOrderBooksQuery = @"
                                INSERT INTO order_books (orderId, bookId)
                                VALUES (@OrderId, @BookId);";

                                    using (SqlCommand insertOrderBooksCmd = new SqlCommand(insertOrderBooksQuery, conn, transaction))
                                    {
                                        insertOrderBooksCmd.Parameters.AddWithValue("@OrderId", orderId);
                                        insertOrderBooksCmd.Parameters.AddWithValue("@BookId", bookId);
                                        insertOrderBooksCmd.ExecuteNonQuery();
                                    }

                                    string updateBookQuantityQuery = @"
                                UPDATE books
                                SET quantity = quantity - @OrderQty
                                WHERE bookId = @BookId;

                                DELETE FROM books
                                WHERE bookId = @BookId AND quantity = 0;";

                                    using (SqlCommand updateBookCmd = new SqlCommand(updateBookQuantityQuery, conn, transaction))
                                    {
                                        updateBookCmd.Parameters.AddWithValue("@OrderQty", orderedQuantity);
                                        updateBookCmd.Parameters.AddWithValue("@BookId", bookId);
                                        updateBookCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();

                            totalL.Text = $"Total: {totalPrice:0.00}";

                            dataItems.Rows.Clear();

                            MessageBox.Show("Order placed and printed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error while processing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No items to print.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while printing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadBooks(string category = "All")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT
                           b.bookId AS ID,
                           b.title AS Book,
                           b.authorName AS Author,
                           cn.name AS Category,
                           b.price AS Price,
                           b.quantity AS Quantity
                           FROM
                               books b
                           JOIN
                               category c ON b.categoryId = c.categoryId
                           JOIN
                               category_name cn ON c.categoryId = cn.categoryId";

                    if (category != "All")
                    {
                        query += " WHERE cn.name = @Category";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (category != "All")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Category", category);
                    }

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataBooks.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No books found in category: " + category);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message);
                }
            }
        }

        private void LoadCategoriesIntoComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT DISTINCT cn.name AS Category
                             FROM category_name cn";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    catCombo.Items.Clear();
                    catCombo.Items.Add("All");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        catCombo.Items.Add(row["Category"].ToString());
                    }

                    if (catCombo.Items.Count > 0)
                    {
                        catCombo.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }
        }

    }
}  
