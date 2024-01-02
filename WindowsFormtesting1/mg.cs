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
    public partial class mg : Form
    {
        public mg()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lohitha\Documents\categorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void population()
        {
            try {

                con.Open();
                string myquery = "select * from customertb";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvCustomer.DataSource = ds.Tables[0];
                con.Close();
            }

            catch
            {

            }
        }
        private void mg_Load(object sender, EventArgs e)
        {
            population();
        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into customertb values('"+txtcusid.Text+"','"+txtcusname.Text+"','"+txtcusphone.Text+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("customer succesfully added");
                con.Close();
                population();
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblexite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtcusid.Text == "")
            {
                MessageBox.Show("enter customer id");
            }
            else
            {
                con.Open();
                string myquery = "delete from customertb where Cid ='" + txtcusid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("customer secsussfully deleted");
                con.Close();
                population();
            }
        }
    }
}
