using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineBookStore
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private async void timer1_Tick1(object sender, EventArgs e)
        {
            progressBar.Value++;
            perLabel.Text = progressBar.Value + "%";
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                await Task.Delay(1000);
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

    }
}
