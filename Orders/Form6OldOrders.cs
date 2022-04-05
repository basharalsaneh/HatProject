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
    public partial class Form6OldOrders : Form
    {
        public Form6OldOrders()
        {
            InitializeComponent();
        }

        private void btnBackOldOrders_Click(object sender, EventArgs e)
        {
            Form4Orders openForm = new Form4Orders();
            openForm.Show();
            this.Hide();
        }
    }
}
