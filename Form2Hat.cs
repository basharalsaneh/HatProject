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
using System.Configuration;
using System.IO;

namespace HatProject1
{
    public partial class Form2Hat : Form
    {
        public Form2Hat()
        {
            InitializeComponent();
            showDataGrid();
            Savebutton.Hide();
            btnDeleteHat.Hide();
        }

        //repos\HatProject1\HatProject1 => repos\HatProject1\DatabaseH.mdf
        //Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())). Ska refaktoriseras för att bli lättare att läsa.
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= "+ Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\DatabaseH.mdf;Integrated Security=True");

        void showDataGrid()
        {
            sc.Open();
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = "SELECT hId as ID, hName as Name, size as Size, category as Category from Hats";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, sc);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridViewHatModels.DataSource = bSource;
            sc.Close();
        }

        void clearTextBox()
        {
            HatName.Clear();    
            HatSize.Clear();    
            CategoryText.Clear();
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


            SqlCommand sm = new SqlCommand("insert into Hats values('"+HatName.Text+ "','" + HatSize.Text + "','" + CategoryText.Text + "')", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("new hat saved");
            showDataGrid();
            clearTextBox();

            //const string ConnectionString = "Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvko\source\repos\HatProject1\Data\Hats.mdf;Integrated Security = True";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //SqlCommand cmd = new SqlCommand("insert into (hName) values ('" + HatName.Text + "')", conn);
            //using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anvko\\source\\repos\\HatProject1\\HatProject1\\DatabaseH.mdf;Integrated Security=True")) {
            //    SqlCommand cmd = new SqlCommand("insert into (Hats.hName) values ('" + HatName.Text + "')",con);
            //    cmd.Connection.Open();

            //    int i = cmd.ExecuteNonQuery();
            //    if (i != 0)
            //    {
            //        MessageBox.Show("new hat saved");

            //    }

            //    else
            //    {

            //        MessageBox.Show("incorrect info");

            //    }
            //    cmd.Connection.Close();
            //}




        }

        private void dataGridViewHatModels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridViewHatModels.Rows[e.RowIndex];    
                HatName.Text = dgvRow.Cells[1].Value.ToString();
                HatSize.Text = dgvRow.Cells[2].Value.ToString();
                CategoryText.Text = dgvRow.Cells[3].Value.ToString();
                Savebutton.Show();
                btnDeleteHat.Show();

            }
        }

        private void btnToMaterial_Click(object sender, EventArgs e)
        {
            Form8Material ins = new Form8Material();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //int HattID = Convert.ToInt32(dataGridViewHatModels.SelectedCells[0].Value);

            //int HattId= dataGridViewHatModels.CurrentCell.RowIndex+1;
            int rowindex = dataGridViewHatModels.CurrentCell.RowIndex;
            int columnindex = dataGridViewHatModels.CurrentCell.ColumnIndex;

            int HattId = Convert.ToInt32(dataGridViewHatModels.Rows[rowindex].Cells[0].Value.ToString());

            SqlCommand sm = new SqlCommand("update Hats set hName ='" + HatName.Text + "', size='" + HatSize.Text + "', category ='" + CategoryText.Text + "' where hid= '"+ HattId +"'", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("The hat updated");
            showDataGrid();
            clearTextBox();
        }

        private void btnDeleteHat_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridViewHatModels.CurrentCell.RowIndex;
            int columnindex = dataGridViewHatModels.CurrentCell.ColumnIndex;


            int HattId = Convert.ToInt16(dataGridViewHatModels.Rows[rowindex].Cells[0].FormattedValue.ToString());

            SqlCommand sm = new SqlCommand("delete from Hats where hid= '" + HattId + "'", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("The hat deleted");
            showDataGrid();
            clearTextBox();
        }
    }
}
