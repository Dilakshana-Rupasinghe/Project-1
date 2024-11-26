using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void btnCategorys_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void btnItemmanagement_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void btnBillcreation_Click(object sender, EventArgs e)
        {
            //new Form7().Show();
           // this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
