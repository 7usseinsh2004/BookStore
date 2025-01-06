namespace OnlineBookStore
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.fillL = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dontBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.containerPanel.Controls.Add(this.fillL);
            this.containerPanel.Controls.Add(this.loginBtn);
            this.containerPanel.Controls.Add(this.dontBtn);
            this.containerPanel.Controls.Add(this.pictureBox3);
            this.containerPanel.Controls.Add(this.pictureBox2);
            this.containerPanel.Controls.Add(this.pictureBox1);
            this.containerPanel.Controls.Add(this.passTb);
            this.containerPanel.Controls.Add(this.label2);
            this.containerPanel.Controls.Add(this.emailTb);
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(952, 721);
            this.containerPanel.TabIndex = 2;
            // 
            // fillL
            // 
            this.fillL.AutoSize = true;
            this.fillL.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Bold);
            this.fillL.ForeColor = System.Drawing.Color.Red;
            this.fillL.Location = new System.Drawing.Point(340, 495);
            this.fillL.Name = "fillL";
            this.fillL.Size = new System.Drawing.Size(84, 17);
            this.fillL.TabIndex = 41;
            this.fillL.Text = "Fill all fields";
            this.fillL.Visible = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 18;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.loginBtn.IndicateFocus = true;
            this.loginBtn.Location = new System.Drawing.Point(367, 514);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(273, 42);
            this.loginBtn.TabIndex = 25;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // dontBtn
            // 
            this.dontBtn.Animated = true;
            this.dontBtn.BackColor = System.Drawing.Color.Transparent;
            this.dontBtn.BorderRadius = 8;
            this.dontBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dontBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dontBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dontBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dontBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dontBtn.FillColor = System.Drawing.Color.Brown;
            this.dontBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.dontBtn.ForeColor = System.Drawing.Color.White;
            this.dontBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dontBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.dontBtn.IndicateFocus = true;
            this.dontBtn.Location = new System.Drawing.Point(421, 562);
            this.dontBtn.Name = "dontBtn";
            this.dontBtn.Size = new System.Drawing.Size(176, 20);
            this.dontBtn.TabIndex = 18;
            this.dontBtn.Text = "Don\'t Have an Account ?";
            this.dontBtn.Click += new System.EventHandler(this.dontBtn_Click);
            // 
            // passTb
            // 
            this.passTb.Animated = true;
            this.passTb.AutoRoundedCorners = true;
            this.passTb.BorderRadius = 23;
            this.passTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTb.DefaultText = "Password";
            this.passTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Location = new System.Drawing.Point(334, 447);
            this.passTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '●';
            this.passTb.PlaceholderText = "";
            this.passTb.SelectedText = "";
            this.passTb.Size = new System.Drawing.Size(354, 48);
            this.passTb.TabIndex = 21;
            this.passTb.UseSystemPasswordChar = true;
            this.passTb.Enter += new System.EventHandler(this.passTb_Enter);
            this.passTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTb_KeyDown);
            this.passTb.Leave += new System.EventHandler(this.passTb_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(441, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Login";
            // 
            // emailTb
            // 
            this.emailTb.Animated = true;
            this.emailTb.AutoRoundedCorners = true;
            this.emailTb.BorderRadius = 23;
            this.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTb.DefaultText = "E-mail";
            this.emailTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTb.Location = new System.Drawing.Point(334, 374);
            this.emailTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTb.Name = "emailTb";
            this.emailTb.PasswordChar = '\0';
            this.emailTb.PlaceholderText = "";
            this.emailTb.SelectedText = "";
            this.emailTb.Size = new System.Drawing.Size(354, 48);
            this.emailTb.TabIndex = 19;
            this.emailTb.Enter += new System.EventHandler(this.emailTb_Enter);
            this.emailTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTb_KeyDown);
            this.emailTb.Leave += new System.EventHandler(this.emailTb_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OnlineBookStore.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(263, 437);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::OnlineBookStore.Properties.Resources.Email;
            this.pictureBox2.Location = new System.Drawing.Point(272, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OnlineBookStore.Properties.Resources.prof;
            this.pictureBox1.Location = new System.Drawing.Point(408, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerPanel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(952, 721);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Button dontBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox passTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox emailTb;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.Label fillL;
    }
}
