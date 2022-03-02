using System.Data.SqlClient;

namespace _2_SqlTabloManuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        private void btn_CreatTable_Click(object sender, EventArgs e)
        {
            
            try
            {
                bgl.dbconnect();
                SqlCommand komut = new SqlCommand
                    ("Create Table " + textBox1.Text + 
                    "(" +txt_SutunAdi.Text+" "+txt_VeriTipi.Text+","+
                    txt_SutunAdi2.Text+" "+ txt_VeriTipi2.Text+ " )", bgl.dbconnect());
                komut.ExecuteNonQuery();
                bgl.dbconnect().Close();

                MessageBox.Show("Tablo oluþturuldu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluþtu");
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}