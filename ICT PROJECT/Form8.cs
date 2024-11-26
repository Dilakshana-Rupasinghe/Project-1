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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            //new Form6().Show();
            //this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
