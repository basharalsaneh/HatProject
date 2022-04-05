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

namespace HatProject1
{
    public partial class Form2Hat : Form
    {
        public Form2Hat()
        {
            InitializeComponent();
        }

        private void btnBackHat_Click(object sender, EventArgs e)
        {
            Form1Start openForm = new Form1Start();
            openForm.Show();
            this.Hide();
        }

        private void HatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHat_Click(object sender, EventArgs e)
        {
            //const string ConnectionString = "Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvko\source\repos\HatProject1\Data\Hats.mdf;Integrated Security = True";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //SqlCommand cmd = new SqlCommand("insert into (hName) values ('" + HatName.Text + "')", conn);
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anvko\\source\\repos\\HatProject1\\Data\\Hats.mdf;Integrated Security=True")) {
                SqlCommand cmd = new SqlCommand("insert into (Table.name) values ('" + HatName.Text + "')",con);
                cmd.Connection.Open();

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("new hat saved");

                }

                else
                {

                    MessageBox.Show("incorrect info");

                }
                cmd.Connection.Close();
            }

           


        }
    }
}
