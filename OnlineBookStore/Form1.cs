using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineBookStore
{
    public partial class Form1 : Form
    {
        bool side;
        public Form1()
        {
            nameChange = new Label();
            idChange = new Label();
            InitializeComponent();
            Home home = new Home(signBtn,addBookBtn,homeBtn,userBtn,dashBtn,bookBtn, signOutBtn, panel1, nameChange, idChange);
            add_form(home);

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
            homeBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            homeBtn.ForeColor = Color.White;
            signBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            signBtn.ForeColor = Color.White;
            addBookBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            addBookBtn.ForeColor = Color.White;
            bookBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            bookBtn.ForeColor = Color.White;
            userBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            userBtn.ForeColor = Color.White;
            dashBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dashBtn.ForeColor = Color.White;
            aboutBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            aboutBtn.ForeColor = Color.White;
            signOutBtn.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            signOutBtn.ForeColor = Color.White;


            Guna2Button btn = (Guna2Button)sender;
            if (panel1.Visible == true)
            {
                if (btn == homeBtn)
                {
                    containerPanel.Controls.Clear();
                    containerPanel.Controls.Add(panel1);
                    panel1.BringToFront();
                    homeBtn.FillColor = Color.White;
                    homeBtn.ForeColor = Color.Black;
                }
                else if (btn == userBtn)
                {
                    Users users = new Users();
                    add_form(users);
                    userBtn.FillColor = Color.White;
                    userBtn.ForeColor = Color.Black;
                }
                else if (btn == addBookBtn)
                {
                    AddBooks add = new AddBooks(addBookBtn,userBtn,dashBtn);
                    add_form(add);
                    addBookBtn.FillColor = Color.White;
                    addBookBtn.ForeColor = Color.Black;
                }
                else if (btn == bookBtn)
                {
                    Books books = new Books(idChange.Text);
                    add_form(books);
                    bookBtn.FillColor = Color.White;
                    bookBtn.ForeColor = Color.Black;
                }
                else if (btn == dashBtn)
                {
                    Dashboard dash = new Dashboard();
                    add_form(dash);
                    dashBtn.FillColor = Color.White;
                    dashBtn.ForeColor = Color.Black;
                }
                else if (btn == signOutBtn)
                {
                    userBtn.Visible = false;
                    dashBtn.Visible = false;
                    addBookBtn.Visible = false;
                    signOutBtn.Visible = false;
                    panel1.Visible = false;
                    signBtn.Visible = true;
                    bookBtn.Visible = false;

                    userBtn.Location = new Point(14, 348);
                    dashBtn.Location = new Point(14, 502);
                    addBookBtn.Location=new Point(14, 247);
                    Home home = new Home(signBtn, addBookBtn, homeBtn, userBtn, dashBtn, bookBtn, signOutBtn, panel1, nameChange, idChange);
                    add_form(home);
                    homeBtn.FillColor = Color.White;
                    homeBtn.ForeColor = Color.Black;
                }
                else if (btn == aboutBtn)
                {
                    About ab = new About();
                    add_form(ab);
                    aboutBtn.FillColor = Color.White;
                    aboutBtn.ForeColor = Color.Black;
                }
            }
            else
            {
                if (btn == homeBtn)
                {
                    Home home = new Home(signBtn, addBookBtn, homeBtn, userBtn, dashBtn, bookBtn, signOutBtn, panel1, nameChange, idChange);
                    add_form(home);
                    homeBtn.FillColor = Color.White;
                    homeBtn.ForeColor = Color.Black;
                }
                else if (btn == signBtn)
                {
                    Sign sign = new Sign(homeBtn);
                    add_form(sign);
                    signBtn.FillColor = Color.White;
                    signBtn.ForeColor = Color.Black;
                }
                else if (btn == aboutBtn)
                {
                    About ab = new About();
                    add_form(ab);
                    aboutBtn.FillColor = Color.White;
                    aboutBtn.ForeColor = Color.Black;
                }
                else if (btn == dashBtn)
                {
                    Dashboard dash = new Dashboard();
                    add_form(dash);
                    dashBtn.FillColor = Color.White;
                }
            }
        }
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (side)
            {
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width)
                {
                    side=false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    side = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.Red;
        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.DarkGray;
        }

        private void guna2Button2_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Button2.FillColor = Color.Red;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
