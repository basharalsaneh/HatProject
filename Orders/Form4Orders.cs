using HatProject1.Orders;
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
    public partial class Form4Orders : Form
    {
        public Form4Orders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5CreateOrders ins = new Form5CreateOrders();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7CurrentOrders ins = new Form7CurrentOrders();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6OldOrders ins = new Form6OldOrders();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void btnGoBackO_Click(object sender, EventArgs e)
        {
            Form1Start openForm = new Form1Start();
            openForm.Show();
            this.Hide();
        }

        private void Form4Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
