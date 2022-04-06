using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HatProject1
{
    public partial class Form8Material : Form
    {
        public Form8Material()
        {
            InitializeComponent();
        }

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\DatabaseH.mdf;Integrated Security=True");

        private void btnBackMaterial_Click(object sender, EventArgs e)
        {
            Form2Hat openForm = new Form2Hat();
            openForm.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {

            SqlCommand sm = new SqlCommand("insert into Material values('" + textBoxMNamn.Text + "','" + textBoxCost.Text + "','" + textBoxAmmount.Text + "')", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("new material saved");
        }

        private void textBoxMNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
