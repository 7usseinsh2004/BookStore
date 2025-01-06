namespace OnlineBookStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideBar = new System.Windows.Forms.Panel();
            this.signBtn = new Guna.UI2.WinForms.Guna2Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idChange = new System.Windows.Forms.Label();
            this.nameChange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.signOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bookBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBookBtn = new Guna.UI2.WinForms.Guna2Button();
            this.aboutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sideBar.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideBar.Controls.Add(this.guna2Button1);
            this.sideBar.Controls.Add(this.signOutBtn);
            this.sideBar.Controls.Add(this.bookBtn);
            this.sideBar.Controls.Add(this.dashBtn);
            this.sideBar.Controls.Add(this.addBookBtn);
            this.sideBar.Controls.Add(this.aboutBtn);
            this.sideBar.Controls.Add(this.userBtn);
            this.sideBar.Controls.Add(this.signBtn);
            this.sideBar.Controls.Add(this.homeBtn);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(249, 721);
            this.sideBar.MinimumSize = new System.Drawing.Size(93, 721);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(249, 721);
            this.sideBar.TabIndex = 0;
            // 
            // signBtn
            // 
            this.signBtn.Animated = true;
            this.signBtn.BackColor = System.Drawing.Color.Transparent;
            this.signBtn.BorderRadius = 10;
            this.signBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.signBtn.ForeColor = System.Drawing.Color.White;
            this.signBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.signBtn.IndicateFocus = true;
            this.signBtn.Location = new System.Drawing.Point(14, 161);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(228, 63);
            this.signBtn.TabIndex = 1;
            this.signBtn.Text = "Sign up";
            this.signBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.signBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Location = new System.Drawing.Point(248, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(952, 721);
            this.containerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.idChange);
            this.panel1.Controls.Add(this.nameChange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(166, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 458);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // idChange
            // 
            this.idChange.AutoSize = true;
            this.idChange.BackColor = System.Drawing.Color.Transparent;
            this.idChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.idChange.ForeColor = System.Drawing.Color.Red;
            this.idChange.Location = new System.Drawing.Point(86, 164);
            this.idChange.Name = "idChange";
            this.idChange.Size = new System.Drawing.Size(61, 31);
            this.idChange.TabIndex = 27;
            this.idChange.Text = "ID :";
            // 
            // nameChange
            // 
            this.nameChange.AutoSize = true;
            this.nameChange.BackColor = System.Drawing.Color.Transparent;
            this.nameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.nameChange.ForeColor = System.Drawing.Color.Red;
            this.nameChange.Location = new System.Drawing.Point(132, 111);
            this.nameChange.Name = "nameChange";
            this.nameChange.Size = new System.Drawing.Size(107, 31);
            this.nameChange.TabIndex = 26;
            this.nameChange.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID :";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.BackColor = System.Drawing.Color.Transparent;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.nameL.ForeColor = System.Drawing.Color.Red;
            this.nameL.Location = new System.Drawing.Point(19, 111);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(107, 31);
            this.nameL.TabIndex = 24;
            this.nameL.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome to our Online Book Store";
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(1130, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(67, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            this.guna2Button2.MouseLeave += new System.EventHandler(this.guna2Button2_MouseLeave);
            this.guna2Button2.MouseHover += new System.EventHandler(this.guna2Button2_MouseHover);
            this.guna2Button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Button2_MouseMove);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::OnlineBookStore.Properties.Resources.menu;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(12, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(228, 63);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Menu";
            this.guna2Button1.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2Button1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.Animated = true;
            this.signOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.BorderRadius = 10;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signOutBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.signOutBtn.ForeColor = System.Drawing.Color.White;
            this.signOutBtn.Image = global::OnlineBookStore.Properties.Resources.signout;
            this.signOutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signOutBtn.ImageOffset = new System.Drawing.Point(-35, 0);
            this.signOutBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.signOutBtn.IndicateFocus = true;
            this.signOutBtn.Location = new System.Drawing.Point(14, 581);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(228, 63);
            this.signOutBtn.TabIndex = 7;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.signOutBtn.Visible = false;
            this.signOutBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Animated = true;
            this.bookBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookBtn.BorderRadius = 10;
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Image = global::OnlineBookStore.Properties.Resources._12;
            this.bookBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.bookBtn.ImageSize = new System.Drawing.Size(60, 70);
            this.bookBtn.IndicateFocus = true;
            this.bookBtn.Location = new System.Drawing.Point(14, 333);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(228, 63);
            this.bookBtn.TabIndex = 6;
            this.bookBtn.Text = "Books";
            this.bookBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.bookBtn.Visible = false;
            this.bookBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.Animated = true;
            this.dashBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashBtn.BorderRadius = 10;
            this.dashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dashBtn.ForeColor = System.Drawing.Color.White;
            this.dashBtn.Image = global::OnlineBookStore.Properties.Resources.Picsart_24_12_21_18_26_01_552;
            this.dashBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashBtn.ImageOffset = new System.Drawing.Point(-10, 0);
            this.dashBtn.ImageSize = new System.Drawing.Size(50, 40);
            this.dashBtn.IndicateFocus = true;
            this.dashBtn.Location = new System.Drawing.Point(14, 502);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(228, 63);
            this.dashBtn.TabIndex = 5;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dashBtn.Visible = false;
            this.dashBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Animated = true;
            this.addBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBookBtn.BorderRadius = 10;
            this.addBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBookBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.addBookBtn.ForeColor = System.Drawing.Color.White;
            this.addBookBtn.Image = global::OnlineBookStore.Properties.Resources._12;
            this.addBookBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addBookBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.addBookBtn.ImageSize = new System.Drawing.Size(60, 70);
            this.addBookBtn.IndicateFocus = true;
            this.addBookBtn.Location = new System.Drawing.Point(14, 247);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(228, 63);
            this.addBookBtn.TabIndex = 4;
            this.addBookBtn.Text = "Add Books";
            this.addBookBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addBookBtn.Visible = false;
            this.addBookBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Animated = true;
            this.aboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.BorderRadius = 10;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Image = global::OnlineBookStore.Properties.Resources.about;
            this.aboutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aboutBtn.ImageOffset = new System.Drawing.Point(-10, 0);
            this.aboutBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.aboutBtn.IndicateFocus = true;
            this.aboutBtn.Location = new System.Drawing.Point(14, 652);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(228, 63);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.aboutBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Animated = true;
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.BorderRadius = 10;
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = global::OnlineBookStore.Properties.Resources._13;
            this.userBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.userBtn.ImageSize = new System.Drawing.Size(60, 70);
            this.userBtn.IndicateFocus = true;
            this.userBtn.Location = new System.Drawing.Point(14, 419);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(228, 63);
            this.userBtn.TabIndex = 2;
            this.userBtn.Text = "Users";
            this.userBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.userBtn.Visible = false;
            this.userBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderRadius = 10;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.White;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.Image = global::OnlineBookStore.Properties.Resources.home;
            this.homeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.homeBtn.IndicateFocus = true;
            this.homeBtn.Location = new System.Drawing.Point(14, 76);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(228, 63);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.homeBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Book Store";
            this.sideBar.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button signBtn;
        private Guna.UI2.WinForms.Guna2Button aboutBtn;
        private Guna.UI2.WinForms.Guna2Button userBtn;
        private System.Windows.Forms.Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Button addBookBtn;
        private Guna.UI2.WinForms.Guna2Button dashBtn;
        private Guna.UI2.WinForms.Guna2Button bookBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idChange;
        private System.Windows.Forms.Label nameChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameL;
        private Guna.UI2.WinForms.Guna2Button signOutBtn;
        private System.Windows.Forms.Timer sideBarTimer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}