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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                con.Open();
                string Myquery = "select * from UserTb1";
                SqlDataAdapter daa = new SqlDataAdapter(Myquery,con);
                SqlCommandBuilder cb = new SqlCommandBuilder(daa);
                var ds = new DataSet();
                daa.Fill(ds);
                gvUser.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {


            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void lblexite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTb1 values('" + txtusername.Text + "','" + txtfullname.Text + "','" + txtpassword.Text + "','" + txttelephone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added");
                con.Close();

                populate();
            }
            catch
            {
               
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
          
                if (txttelephone.Text == "")
                {
                    MessageBox.Show("enter the user phone number");
                }
                else
                {
                    con.Open();
                    string myquery = "delete from UserTb1 where Uphone ='" + txttelephone.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("user secsussfully deleted");
                    con.Close();
                     populate();
                }
            

        }

        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            dashbordform dashboardForm = new dashbordform();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand("update UserTb1 set Uname='" + txtusername.Text + "',Ufullname='" + txtfullname.Text + "',Upassword='" + txtpassword.Text + "',Uphone='" + txttelephone.Text + "'where Uphone ='" + txttelephone.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user sucessfully updated");
                con.Close();
                populate();
            
            }
            catch
            {

            }
        }

        private void gvUser_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = gvUser.SelectedRows[0].Cells[0].Value.ToString();
            txtfullname.Text = gvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtpassword.Text = gvUser.SelectedRows[0].Cells[2].Value.ToString();
            txttelephone.Text = gvUser.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
