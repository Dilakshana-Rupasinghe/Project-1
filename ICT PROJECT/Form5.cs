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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thilakshana\Documents\MYDB1.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "select * from Categorytbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvcategor.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Categorytbl values (@Category_Number, @Category_Name )", con);
            cmd.Parameters.AddWithValue("@Category_Number", int.Parse(tbcategoryno.Text));
            cmd.Parameters.AddWithValue("@Category_Name", tbcategoryname.Text);
            
            cmd.ExecuteNonQuery();

            con.Close();
            populate();
            MessageBox.Show("Successfull saved Category");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbcategoryno.Text == "" )
            {
                MessageBox.Show("Select the Category to be Deleted");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" delete Categorytbl where Category_Number = @Category_Number ", con);
                cmd.Parameters.AddWithValue("@Category_Number", int.Parse(tbcategoryno.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                populate();
                MessageBox.Show("Successfully Deleted Category");
            }
        }

        private void dgvcategor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcategoryno.Text = dgvcategor.SelectedRows[0].Cells[0].Value.ToString();
            tbcategoryname.Text = dgvcategor.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbcategoryname.Text == "" || tbcategoryno.Text == "")
            {
                MessageBox.Show("Select the Category to be Update");
            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Categorytbl set Category_Name= @Category_Name where Category_Number=@Category_Number", con);

                cmd.Parameters.AddWithValue("@Category_Number", int.Parse(tbcategoryno.Text));
                cmd.Parameters.AddWithValue("@Category_Name", tbcategoryname.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                populate();
                MessageBox.Show("Successfully Update Category");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            tbcategoryname.Clear();
            tbcategoryno.Clear();
        }
    }
}
