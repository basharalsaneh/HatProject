using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatProject1.Orders
{
    public partial class Form5CreateOrders : Form
    {
        public Form5CreateOrders()
        {
            InitializeComponent();
        }

        private void Form5CreateOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnBackCO_Click(object sender, EventArgs e)
        {
            Form4Orders openForm = new Form4Orders();
            openForm.Show();
            this.Hide();
        }
    }
}
