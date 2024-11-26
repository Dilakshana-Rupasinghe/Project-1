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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thilakshana\Documents\MYDB1.mdf;Integrated Security=True;Connect Timeout=30");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sad = new SqlDataAdapter("select count(*) from Stafftbl where User_Name= '"+tbUserName.Text+"' and Password= '"+tbPassword.Text+ " ' ",con);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                Form8 obj = new Form8();
                obj.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Worng User name or password");
            }
            con.Close();
           // if (tbUserName.Text=="Malindu" && tbPassword.Text=="1234") 
            //{
            //    new Form2().Show();
             //   this.Hide();
            //}

            //else
            //{
            //    MessageBox.Show("Your User Name or Password is incorrect , Please try agine");
             //   tbUserName.Clear();
             //   tbPassword.Clear();
              //  tbUserName.Focus();
         //   }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }
    }
}
