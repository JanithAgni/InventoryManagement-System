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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void fillcategory()
        {
            string query = "select * from categorytb";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("catname",typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                catcombo.ValueMember = "catname";
                catcombo.DataSource = dt;
                searchCombo.ValueMember = "catname";
                searchCombo.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }


     

        void filterbycategory()
        {
            try
            {
                con.Open();
                string myquery = "select * from producttb where prodCat='" + searchCombo.SelectedValue.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvProduct.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }


        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from producttb";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvProduct.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void products_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into producttb values('"+txtProductId.Text+"','"+txtProductName.Text+"','"+txtquentity.Text+"','"+txtprice.Text+"','"+txtdescription.Text+"','"+catcombo.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("succesfully enterd products");
            con.Close();
            populate();
        }

        private void lblexite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtProductId.Text == "")
            {
                MessageBox.Show("enter product id");
            }
            else
            {
                con.Open();
                string myquery = "delete from producttb where prodId ='" + txtProductId.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user secsussfully deleted");
                con.Close();
                populate();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            filterbycategory();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            dashbordform dashboardForm = new dashbordform();
            dashboardForm.Show();
            this.Hide();
        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = gvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = gvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtquentity.Text = gvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtprice.Text = gvProduct.SelectedRows[0].Cells[3].Value.ToString();
            txtdescription.Text = gvProduct.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update producttb set prodId='" + txtProductId.Text + "',prodName='" + txtProductName.Text + "',prodQty='" + txtquentity.Text + "',prodPrice='" + txtprice.Text + "',prodDesc='" + txtdescription.Text + "'where prodId ='" + txtProductId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user sucessfully updated");
                con.Close();
                populate();

            }
            catch
            {

            }
        }
    }
}
