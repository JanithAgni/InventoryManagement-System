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
    public partial class manageOrders : Form
    {
        public manageOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from customertb";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customerGv.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }


            
        }

        void fillcategory()
        {
            string query = "select * from categorytb";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("catname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //catcombo.ValueMember = "catname";
                //catcombo.DataSource = dt;
                searchCombo.ValueMember = "catname";
                searchCombo.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

        void populateproduct()
        {
            try
            {
                con.Open();
                string myquery = "select * from producttb";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productgv.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;
        int flag = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId.Text = customerGv.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void manageOrders_Load(object sender, EventArgs e)
        {
             populate();
            populateproduct();
            fillcategory();

           
        }

        private void lblexite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (qtyTb.Text == "")
            {
                MessageBox.Show("Enter quantity of products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(qtyTb.Text);

                // Assuming you have a DataGridView named 'orderGv'
                orderGv.Rows.Add(num, product, qty, uprice, qty * uprice);

                // Reset flag and other variables if needed
                flag = 0;
                qtyTb.Text = "";
            }
        }


       

        private void orderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productgv_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void productgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string myquery = "select * from producttb where prodCat='" + searchCombo.SelectedValue.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productgv.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void productgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                product = productgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                uprice = Convert.ToInt32(productgv.Rows[e.RowIndex].Cells[3].Value.ToString());

                // Set flag to indicate that a product is selected
                flag = 1;

                // Optionally, update UI or perform other actions based on the selection
                // ...

                // Reset other variables if needed
                qtyTb.Text = "";
            }
        }


    }
}
