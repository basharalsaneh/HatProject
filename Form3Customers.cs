using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatProject1
{
    public partial class Form3Customers : Form
    {
        public Form3Customers()
        {
            InitializeComponent();
        }

        private void btnBackCustomers_Click(object sender, EventArgs e)
        {
            Form1Start openForm = new Form1Start();
            openForm.Show();
            this.Hide();
        }
    }
}
