using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class AddBooks : UserControl
    {
        private Guna2Button addbookBtn;
        private Guna2Button userBtn;
        private Guna2Button dashBtn;

        public AddBooks(Guna2Button addbookButton, Guna2Button usersButton, Guna2Button dashButton)
        {
            InitializeComponent();
            this.addbookBtn = addbookButton;
            this.userBtn = usersButton;
            this.dashBtn = dashButton;
        }
        private void add_form(UserControl us)
        {
            containerPanel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            containerPanel.Controls.Add(us);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn == saveBtn)
            {
                SaveDataToDatabase();
            }
            else if (btn == delBtn)
            {
                DeleteDataFromDatabase();
            }
            else if (btn == userBtn)
            {
                Users users = new Users();
                add_form(users);
                userBtn.FillColor = Color.White;
                userBtn.ForeColor = Color.Black;
            }

        }
        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        SqlConnection con;
        string query;
        SqlCommand cmd;
        private void SaveDataToDatabase()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string categoryQuery = @"
                DECLARE @categoryId INT;
                IF NOT EXISTS (SELECT 1 FROM category_name WHERE name = @categoryName)
                BEGIN
                    INSERT INTO category DEFAULT VALUES;
                    SET @categoryId = SCOPE_IDENTITY();
                    
                    INSERT INTO category_name (categoryId, name)
                    VALUES (@categoryId, @categoryName);
                END
                ELSE
                BEGIN
                    SELECT @categoryId = categoryId
                    FROM category_name
                    WHERE name = @categoryName;
                END";

                    SqlCommand categoryCmd = new SqlCommand(categoryQuery, con);
                    categoryCmd.Parameters.AddWithValue("@categoryName", category.Text);
                    categoryCmd.ExecuteNonQuery();

                    string checkQuery = "SELECT COUNT(*) FROM books WHERE title = @title";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@title", bTitle.Text);

                    int rowsAffected = 0;
                    int count = (int)checkCmd.ExecuteScalar();
                    int f = 0;
                    if (count > 0)
                    {
                        f = 1;
                        string updateQuery = "UPDATE books SET quantity = quantity + @quantity WHERE title = @title";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@title", bTitle.Text);
                        updateCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));
                        updateCmd.ExecuteNonQuery();

                    }
                    else
                    {
                        string bookQuery = @"
                INSERT INTO books (title, authorName, quantity, price, categoryId)
                VALUES (@title, @authorName, @quantity, @price,
                        (SELECT categoryId FROM category_name WHERE name = @categoryName))";

                        SqlCommand bookCmd = new SqlCommand(bookQuery, con);
                        bookCmd.Parameters.AddWithValue("@title", bTitle.Text);
                        bookCmd.Parameters.AddWithValue("@authorName", author.Text);
                        bookCmd.Parameters.AddWithValue("@quantity", quantity.Text);
                        bookCmd.Parameters.AddWithValue("@price", decimal.Parse(price.Text));
                        bookCmd.Parameters.AddWithValue("@categoryName", category.Text);

                        rowsAffected = bookCmd.ExecuteNonQuery();
                    }

                    if (rowsAffected > 0)
                    {
                        if (f==1)
                            MessageBox.Show("Book data alredy stored, quantity was updated!");
                        else
                        MessageBox.Show("Book data saved successfully!");
                        LoadBooks();
                        LoadCategoriesIntoComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save book data.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
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
                    dataGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message);
                }
            }
        }

        private void DeleteDataFromDatabase()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedBookId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["ID"].Value);

                    using (con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string deleteQuery = "DELETE FROM books WHERE bookId = @bookId";

                        using (cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@bookId", selectedBookId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!");
                                LoadBooks();
                                LoadCategoriesIntoComboBox();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the book.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = catCombo.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }
        private void AddBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategoriesIntoComboBox();
        }
    }
}
