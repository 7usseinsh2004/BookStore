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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        private void LoadCustomerData()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                string query = @"SELECT customerId AS ID, fName AS [First name], lName AS [Last name], eMail AS [E-mail], phone AS Phone, city AS City, zipCode AS [Zip code], street AS Street FROM Customer;";

                adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataBooks.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
