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
    public partial class Form1Start : Form
    {
        public Form1Start()
        {
            InitializeComponent();
        }

        private void btnHatProjects_Click(object sender, EventArgs e)
        {
            Form4Orders ins = new Form4Orders();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void btnHatModels_Click(object sender, EventArgs e)
        {
            Form2Hat ins = new Form2Hat();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form3Customers ins = new Form3Customers();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
