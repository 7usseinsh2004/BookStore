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
    public partial class Sign : UserControl
    {
        Guna2Button homeBtn;
        public Sign(Guna2Button homeButton)
        {
            InitializeComponent();
            homeBtn = homeButton;
        }
        private void fnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnameTb.Focus();
            }
        }
        private void lnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailTb.Focus();
            }
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
                phoneTb.Focus();
            }
        }
        private void phoneTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cityTb.Focus();
            }
        }
        private void cityTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                codeTb.Focus();
            }
        }
        private void codeTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                streetTb.Focus();
            }
        }
        private void streetTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }
        private void fnameTb_Enter(object sender, EventArgs e)
        {
            if (fnameTb.Text == "First name") fnameTb.Text = "";
        }
        private void fnameTb_Leave(object sender, EventArgs e)
        {
            if (fnameTb.Text == "") fnameTb.Text = "First name";
        }
        private void lnameTb_Enter(object sender, EventArgs e)
        {
            if (lnameTb.Text == "Last name") lnameTb.Text = "";
        }

        private void lnameTb_Leave(object sender, EventArgs e)
        {
            if (lnameTb.Text == "") lnameTb.Text = "Last name";
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
        private void phoneTb_Enter(object sender, EventArgs e)
        {
            if (phoneTb.Text == "Phone") phoneTb.Text = "";
        }

        private void phoneTb_Leave(object sender, EventArgs e)
        {
            if (phoneTb.Text == "") phoneTb.Text = "Phone";
        }
        private void cityTb_Enter(object sender, EventArgs e)
        {
            if (cityTb.Text == "City") cityTb.Text = "";
        }

        private void cityTb_Leave(object sender, EventArgs e)
        {
            if (cityTb.Text == "") cityTb.Text = "City";
        }
        private void codeTb_Enter(object sender, EventArgs e)
        {
            if (codeTb.Text == "Zip code") codeTb.Text = "";
        }

        private void codeTb_Leave(object sender, EventArgs e)
        {
            if (codeTb.Text == "") codeTb.Text = "Zip code";
        }
        private void streetTb_Enter(object sender, EventArgs e)
        {
            if (streetTb.Text == "Street") streetTb.Text = "";
        }

        private void streetTb_Leave(object sender, EventArgs e)
        {
            if (streetTb.Text == "") streetTb.Text = "Street";
        }
        string connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        SqlConnection con;
        string query;
        SqlCommand cmd;
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (fnameTb.Text != "" && fnameTb.Text != "First name" &&
                lnameTb.Text != "" && lnameTb.Text != "Last name" &&
                emailTb.Text != "" && emailTb.Text != "E-mail" &&
                passTb.Text != "" && passTb.Text != "Password" &&
                phoneTb.Text != "" && phoneTb.Text != "Phone" &&
                cityTb.Text != "" && cityTb.Text != "City" &&
                codeTb.Text != "" && codeTb.Text != "Zip code" &&
                streetTb.Text != "" && streetTb.Text != "Street")
            {
                try
                {
                    using (con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        query = "INSERT INTO Customer (fName, lName, eMail, pass, phone, city, zipCode, street) " +
                                       "VALUES (@fName, @lName, @eMail, @pass, @phone, @city, @zipCode, @street)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@fName", fnameTb.Text);
                            cmd.Parameters.AddWithValue("@lName", lnameTb.Text);
                            cmd.Parameters.AddWithValue("@eMail", emailTb.Text);
                            cmd.Parameters.AddWithValue("@pass", passTb.Text);
                            cmd.Parameters.AddWithValue("@phone", phoneTb.Text);
                            cmd.Parameters.AddWithValue("@city", cityTb.Text);
                            cmd.Parameters.AddWithValue("@zipCode", codeTb.Text);
                            cmd.Parameters.AddWithValue("@street", streetTb.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Customer created successfully!");
                    homeBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                fillL.Visible = true;
            }
        }

    }
}
