using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_PROJECT
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thilakshana\Documents\MYDB1.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from Booktbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dvgitems.DataSource = ds.Tables[0];
            con.Close();
        }
        void Filter()
        {
            con.Open();
            string query = "select * from Booktbl where Category = '"+cmbfilter.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dvgitems.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {

            if (tbbookid.Text == "" || tbbookname.Text == "" || tbprice.Text == "" || tbquaint.Text == "" || cmbcategory.Text == "" )
            {
                MessageBox.Show("Complete the Form");
            }
            else
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Booktbl values (@Book_ID , @Book_Name,@Category ,@Quanti ,@Price  )", con);
                    cmd.Parameters.AddWithValue("@Book_ID", int.Parse(tbbookid.Text));
                    cmd.Parameters.AddWithValue("@Book_Name", tbbookname.Text);
                    cmd.Parameters.AddWithValue("@Category", cmbcategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Quanti", tbquaint.Text);
                    cmd.Parameters.AddWithValue("@Price", (tbprice.Text));
                    cmd.ExecuteNonQuery();
                    con.Close(); 
                    populate();             
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2btnupdate_Click(object sender, EventArgs e)
        {

            if (tbbookid.Text == "" || tbbookname.Text == "" || tbprice.Text == ""|| tbquaint.Text == "" || cmbcategory.SelectedIndex == -1 )
            {
                MessageBox.Show("Select the Item to be Update");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Booktbl set Book_Name=@Book_Name,Category=@Category , Quanti=@Quanti, Price=@Price where Book_ID=@Book_ID", con);

                cmd.Parameters.AddWithValue("@Book_ID", int.Parse(tbbookid.Text));
                cmd.Parameters.AddWithValue("@Book_Name", tbbookname.Text);
                cmd.Parameters.AddWithValue("@Category", cmbcategory.Text);
                cmd.Parameters.AddWithValue("@Quanti", tbquaint.Text);
                cmd.Parameters.AddWithValue("@Price", (tbprice.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                populate();
                MessageBox.Show("Successfully Update Item");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbbookid.Text == "")
            {
                MessageBox.Show("Select the Item to be Deleted");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" delete Booktbl where Book_ID = @Book_ID ", con);
                cmd.Parameters.AddWithValue("@Book_ID", int.Parse(tbbookid.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                populate();
                MessageBox.Show(" Successfully Delete Item");
            }
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void dvgitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbbookid.Text = dvgitems.SelectedRows[0].Cells[0].Value.ToString();
            tbbookname.Text = dvgitems.SelectedRows[0].Cells[1].Value.ToString();
            cmbcategory.Text = dvgitems.SelectedRows[0].Cells[2].Value.ToString();
            tbquaint.Text = dvgitems.SelectedRows[0].Cells[3].Value.ToString();
            tbprice.Text = dvgitems.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbbookname.Clear();
            tbbookid.Clear();
            tbprice.Clear();
            tbquaint.Clear();
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
