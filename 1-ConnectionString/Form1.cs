using System.Data;
using System.Data.SqlClient;

namespace _1_ConnectionString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // sqlba�lantisi s�n�f�m�zdan "bgl" nesnesi �rettik 
            SqlBaglantisi bgl = new SqlBaglantisi();
            // bgl nesnesin den de baglan fonksiyonunu kullanarak  
            // sql datadapter "da" nesnesini �reterek sorgumuzu olu�turduk ve baglanti fonksiyonunu �a��rd�k
            SqlDataAdapter da = new SqlDataAdapter("Select * from kitaplar",bgl.baglanti());
            //SqlDataAdapter "da" sayesinde Sorgumuzu ger�ekle�tirerek
            // DataSet "ds" sayesinde da sorgumuzu doldurduk 
            DataSet ds = new DataSet();
            da.Fill(ds); // fill komutu ile da sorgumuzu fill(doldur)(dataset)
            //formumuza ekledi�imiz DGV e veri kayna��m�z� �a��rarak = da dan ds ye gelen datasetimizi tabloya [0] indexten itibaren �a��rd�k.
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}