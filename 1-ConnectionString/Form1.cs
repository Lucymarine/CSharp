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
            // sqlbaðlantisi sýnýfýmýzdan "bgl" nesnesi ürettik 
            SqlBaglantisi bgl = new SqlBaglantisi();
            // bgl nesnesin den de baglan fonksiyonunu kullanarak  
            // sql datadapter "da" nesnesini üreterek sorgumuzu oluþturduk ve baglanti fonksiyonunu çaðýrdýk
            SqlDataAdapter da = new SqlDataAdapter("Select * from kitaplar",bgl.baglanti());
            //SqlDataAdapter "da" sayesinde Sorgumuzu gerçekleþtirerek
            // DataSet "ds" sayesinde da sorgumuzu doldurduk 
            DataSet ds = new DataSet();
            da.Fill(ds); // fill komutu ile da sorgumuzu fill(doldur)(dataset)
            //formumuza eklediðimiz DGV e veri kaynaðýmýzý çaðýrarak = da dan ds ye gelen datasetimizi tabloya [0] indexten itibaren çaðýrdýk.
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}