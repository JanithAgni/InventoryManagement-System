using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormtesting1
{
    public partial class dashbordform : Form
    {
        public dashbordform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products dashboardForm = new products();
            dashboardForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 dashboardForm = new Form2();
            dashboardForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            category dashboardForm = new category();
            dashboardForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mg dashboardForm = new mg();
            dashboardForm.Show();
            this.Hide();
        }
    }
}
