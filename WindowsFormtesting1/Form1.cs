using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormtesting1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            usernametb.Text = "";
            passwordtb.Text = "";
        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {
            passwordtb.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametb.Text))
            {
                MessageBox.Show("Enter username");
            }
            else if (string.IsNullOrWhiteSpace(passwordtb.Text))
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                try
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand("SELECT * FROM logintb WHERE username = @username AND password = @password", con);
                    cmd.Parameters.AddWithValue("@username", usernametb.Text);
                    cmd.Parameters.AddWithValue("@password", passwordtb.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    da.Fill(ds);

                   
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Login successful");
                        dashbordform dashboardForm = new dashbordform();
                        dashboardForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("enter valid password and username");
                    }





                }
                catch
                {

                }
                }
        }
    }
}
