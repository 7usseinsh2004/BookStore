using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OnlineBookStore
{
    public partial class Home : UserControl
    {
        private Guna2Button addBookBtn; 
        private Label customerId;
        private Label customerName;
        private Guna2Button signBtn;
        private Guna2Button homeBtn;
        private Guna2Button userBtn;
        private Guna2Button dashBtn;
        private Guna2Button bookBtn;
        private Guna2Button signOutBtn;
        Panel p1;

        public Home(Guna2Button signupButton, Guna2Button addbookButton, Guna2Button homeButton, Guna2Button userButton, Guna2Button dashButton, Guna2Button bookButton, Guna2Button signoutButton, Panel p,Label cname,Label cid)
        {
            InitializeComponent();
            signBtn = signupButton;
            addBookBtn = addbookButton; 
            homeBtn = homeButton;
            userBtn = userButton;
            dashBtn = dashButton;
            bookBtn = bookButton;
            signOutBtn = signoutButton;
            p1 = p;
            customerName = cname;
            customerId = cid;
        }

        private void dontBtn_Click(object sender, EventArgs e)
        {
            signBtn.PerformClick();
        }
        public void add_form(UserControl us)
        {
            containerPanel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            containerPanel.Controls.Add(us);
        }
        private void emailTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passTb.Focus();
            }
        }
        private void passTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }
        private void emailTb_Enter(object sender, EventArgs e)
        {
            if (emailTb.Text == "E-mail") emailTb.Text = "";
        }

        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (emailTb.Text == "") emailTb.Text = "E-mail";
        }
        private void passTb_Enter(object sender, EventArgs e)
        {
            if (passTb.Text == "Password") passTb.Text = "";
        }

        private void passTb_Leave(object sender, EventArgs e)
        {
            if (passTb.Text == "") passTb.Text = "Password";
        }
        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        SqlConnection con;
        string query;
        SqlCommand cmd;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailTb.Text == "" || emailTb.Text == "E-mail" || passTb.Text == "" || passTb.Text == "Password")
            {
                fillL.Visible = true;
                return;
            }
            if (emailTb.Text == "admin" && passTb.Text == "admin")
            {
                Guna2Button btn = (Guna2Button)sender;
                
                //homeBtn.Visible = false;
                userBtn.Visible = true;
                dashBtn.Visible = true;
                addBookBtn.Visible = true;
                signOutBtn.Visible = true;
                p1.Visible = true;
                signBtn.Visible = false;
                bookBtn.Visible = false;

                customerName.Text = "admin";
                customerId.Text = "1000";

                containerPanel.Controls.Clear();
                containerPanel.Controls.Add(p1);
                
                addBookBtn.Location = new Point(14, 125);
                userBtn.Location = new Point(14, 185);
                dashBtn.Location = new Point(14, 240);

                return;
            }
            if (checkdatabase() == 1)
            {
                signBtn.Visible = false;
                addBookBtn.Visible= false;
                userBtn.Visible= false;
                dashBtn.Visible= false;
                bookBtn.Visible = true;
                signOutBtn.Visible = true;
                p1.Visible= true;
                containerPanel.Controls.Clear();
                containerPanel.Controls.Add(p1);
                bookBtn.Location = new Point(14, 125);
            }
            
        }
        private int checkdatabase()
        {
            int f = 0;
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT customerId, fName, lName FROM customer WHERE email = @Email AND pass = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailTb.Text);
                        cmd.Parameters.AddWithValue("@Password", passTb.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                customerId.Text = reader["customerId"].ToString();
                                customerName.Text = reader["fName"].ToString() + " " + reader["lName"].ToString();


                                f = 1;
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return f;
        }

    }
}
