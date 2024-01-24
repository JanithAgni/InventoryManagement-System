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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void population()
        {
            try
            {
                con.Open();
                string myquery = "select * from categorytb";
                SqlDataAdapter sd = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(sd);
                var ds = new DataSet();
                sd.Fill(ds);
                gvCategory.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into categorytb values ('" + txtCategoryId.Text + "','" + txtCategoryName.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("succesfully enterd category");
                con.Close();
                population();
            }
            catch
            {

            }
        }

        private void gvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void category_Load(object sender, EventArgs e)
        {
            population();
        }

        private void lblexite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtCategoryId.Text == "")
            {
                MessageBox.Show("enter category id");
            }
            else
            {
                con.Open();
                string myquery = "delete from categorytb where catId = '"+ txtCategoryId.Text+ "'";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully deleted");
                con.Close();
                population();
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            dashbordform dashboardForm = new dashbordform();
            dashboardForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryId.Text = gvCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtCategoryName.Text = gvCategory.SelectedRows[0].Cells[1].Value.ToString();
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update categorytb set catId='" + txtCategoryId.Text + "',catname='" + txtCategoryName.Text +  "'where catId ='" + txtCategoryId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user sucessfully updated");
                con.Close();
                population();

            }
            catch
            {

            }
        }
    }
}
