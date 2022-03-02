using System.Data;
using System.Data.SqlClient;

namespace _3_VeriTabaninaResimEklemeSilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-73TIA64R;Initial Catalog=Ders2Sinema;Integrated Security=True;");


        private void btn_resim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosyagetir();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Filmler (FilmAd, FilmTur, FilmPuan, FilmKategori, FilmResim) values (@p1, @p2, @p3, @p4, @p5)",sqlConnection);
            cmd.Parameters.AddWithValue("@p1", txtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtTur.Text);
            cmd.Parameters.AddWithValue("@p3", float.Parse(txtPuan.Text));
            cmd.Parameters.AddWithValue("@p4", txtKategori.Text);
            cmd.Parameters.AddWithValue("@p5", txtResim.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayýt Eklendi");
        }
        private void dosyagetir()
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select*From Tbl_Filmler", sqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenhucre = dataGridView1.SelectedCells[0].RowIndex;
            // seçilen hücreyi deðiþkene atama 

            txtID.Text = dataGridView1.Rows[secilenhucre].Cells[0].Value.ToString();
            txtAdi.Text= dataGridView1.Rows[secilenhucre].Cells[1].Value.ToString();
            txtTur.Text= dataGridView1.Rows[secilenhucre].Cells[2].Value.ToString();
            txtPuan.Text= dataGridView1.Rows[secilenhucre].Cells[3].Value.ToString();
            txtKategori.Text= dataGridView1.Rows[secilenhucre].Cells[4].Value.ToString();
            txtResim.Text= dataGridView1.Rows[secilenhucre].Cells[5].Value.ToString();

            pictureBox1.ImageLocation= dataGridView1.Rows[secilenhucre].Cells[5].Value.ToString();
        }
    }

}