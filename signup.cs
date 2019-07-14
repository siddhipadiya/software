using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ab = new Form1();
            ab.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ac = new login();
            ac.Show();
        }
    }
}
