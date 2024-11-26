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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thilakshana\Documents\MYDB1.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "select * from Stafftbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvstaff.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnSRSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stafftbl values (@User_ID , @NIC_Number,@Contact_Number ,@User_Name ,@Password , @Address)", con);
            cmd.Parameters.AddWithValue("@User_ID", int.Parse(tbSRuid.Text));
            cmd.Parameters.AddWithValue("@NIC_Number", tbSRNICNO.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", int.Parse(tbSRContactno.Text));
            cmd.Parameters.AddWithValue("@User_Name", tbSRUsername.Text);
            cmd.Parameters.AddWithValue("@Password", (tbSRPassword.Text));
            cmd.Parameters.AddWithValue("@Address", Addtb.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            populate();
            MessageBox.Show("Successfull saved");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
           populate();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(" delete Stafftbl where User_id = @User_ID " ,con );
            cmd.Parameters.AddWithValue("@User_ID", int.Parse(tbSRuid.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            populate();
            MessageBox.Show("User Successfully Deleted");

        }

        private void dgvstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSRuid.Text = dgvstaff.SelectedRows[0].Cells[0].Value.ToString();
            tbSRNICNO.Text = dgvstaff.SelectedRows[0].Cells[1].Value.ToString();
            tbSRContactno.Text = dgvstaff.SelectedRows[0].Cells[2].Value.ToString();
            tbSRUsername.Text = dgvstaff.SelectedRows[0].Cells[3].Value.ToString();
            tbSRPassword.Text = dgvstaff.SelectedRows[0].Cells[4].Value.ToString();
            Addtb.Text = dgvstaff.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Stafftbl set NIC_Number=@NIC_Number,Contact_Number=@Contact_Number , User_Name=@User_Name, Password=@Password , Address=@Address where USer_ID=@User_ID ", con);

            cmd.Parameters.AddWithValue("@User_ID", int.Parse(tbSRuid.Text));
            cmd.Parameters.AddWithValue("@NIC_Number", tbSRNICNO.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", int.Parse(tbSRContactno.Text));
            cmd.Parameters.AddWithValue("@User_Name", tbSRUsername.Text);
            cmd.Parameters.AddWithValue("@Password", (tbSRPassword.Text));
            cmd.Parameters.AddWithValue("@Address", Addtb.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            populate();
            MessageBox.Show("User Successfully Update");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbSRContactno.Clear();
            tbSRNICNO.Clear();
            tbSRPassword.Clear();
            tbSRuid.Clear();
            tbSRUsername.Clear();
            Addtb.Clear();
        }
    }
}
