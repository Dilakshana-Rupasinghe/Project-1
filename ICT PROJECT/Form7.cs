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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thilakshana\Documents\MYDB1.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
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
        void Updatebook()
        {
            int newQun = stock - Convert.ToInt32(tbqun.Text);//update item 
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Booktbl set  Quanti=@Quanti", con);

            cmd.Parameters.AddWithValue("@Quanti", newQun);
            //cmd.Parameters.AddWithValue("@Price", (tbpri.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            populate();
            MessageBox.Show("Successfully Update Item");//to get message
        }
        int n = 0 , Gredtotal = 0;
        private void btnaddbil_Click(object sender, EventArgs e)
        {
            if(tbqun.Text == ""||Convert.ToInt32(tbqun.Text)>stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(tbqun.Text) * Convert.ToInt32(tbpri.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvbl);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = tbbooknm.Text;
                newRow.Cells[2].Value = tbqun.Text;
                newRow.Cells[3].Value = tbpri.Text;
                newRow.Cells[4].Value = total;
                dgvbl.Rows.Add(newRow);
                n++;
                Updatebook();
                Gredtotal = Gredtotal + total;
                lbltotal.Text = "Rs" + Gredtotal;
            }
        }
        int key = 0 , stock = 0;

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int ID, quntiti, price, total, pos = 60;

        private void btndashbord_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        string name;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Sathsara Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(70));
            e.Graphics.DrawString("ID     PRODUCT     QUANTITY     PRICE      TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in dgvbl.Rows)
            {
                ID = Convert.ToInt32(row.Cells["Column1"].Value);
                name = "" + row.Cells["Column2"].Value;
                price = Convert.ToInt32(row.Cells["Column3"].Value);
                quntiti = Convert.ToInt32(row.Cells["Column4"].Value);
                total= Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + ID, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(30, pos));
                e.Graphics.DrawString("" + name, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(80, pos));
                e.Graphics.DrawString("" + quntiti, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(160, pos));
                e.Graphics.DrawString("" + price, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(240, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(300, pos));
                pos = pos+20;
            }
            e.Graphics.DrawString("Grand Total: RS  " + Gredtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(85, pos + 50));
            e.Graphics.DrawString("*********** Sathsara Book Shop ***********" , new Font("Century Gothic", 10, FontStyle.Bold),Brushes. Crimson, new Point (30, pos+ 80));
            dgvbl.Rows.Clear();
            dgvbl.Refresh();
            pos = 60;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 500, 600);
            if (printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dvgitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbbookid.Text = dvgitems.SelectedRows[0].Cells[0].Value.ToString();
            tbbooknm.Text = dvgitems.SelectedRows[0].Cells[1].Value.ToString();
            //cmbcategory.Text = dvgitems.SelectedRows[0].Cells[2].Value.ToString();
            //tbqun.Text = dvgitems.SelectedRows[0].Cells[3].Value.ToString();
            tbpri.Text = dvgitems.SelectedRows[0].Cells[4].Value.ToString(); 
            if (tbbooknm.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(dvgitems.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dvgitems.SelectedRows[0].Cells[3].Value.ToString());
            }
        }
        private void btnclean_Click(object sender, EventArgs e)
        {
            tbbooknm.Clear();
            tbqun.Clear();
            tbpri.Clear();
            tbclintnm.Clear();
        }
    }
}
