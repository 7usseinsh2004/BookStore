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
using static Guna.UI2.Native.WinApi;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace OnlineBookStore
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        SqlConnection con;
        string query;
        SqlCommand cmd;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            string[] queries = new string[]
            {
        "SELECT COUNT(*) FROM customer",
        "SELECT COUNT(*) FROM _order",
        "SELECT SUM(quantity) FROM _order",
        "SELECT SUM(quantity) FROM books"
            };

            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (string query in queries)
                {
                    cmd= new SqlCommand(query, con);
                    var result = cmd.ExecuteScalar();  
                    if (query == "SELECT COUNT(*) FROM customer")
                    {
                        label1.Text += " : " + result.ToString();  
                    }
                    else if (query == "SELECT COUNT(*) FROM _order")
                    {
                        label2.Text += " : " + result.ToString();  
                    }
                    else if (query == "SELECT SUM(quantity) FROM _order")
                    {
                        label4.Text+=" : "+result.ToString();  
                    }
                    else if (query == "SELECT SUM(quantity) FROM books")
                    {
                        label3.Text += " : " + result.ToString();  
                    }
                }
            }
        }
    }
}
