namespace _5_StruckYapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         struct Kitap
        {
            public string KitapAd;
            public string tur;
            public string yazar;
            public int sayfasayisi;
            public double puan;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAd = "Beyaz Zambaklar Ülkesinde";
            kitap.yazar = "Grigory Petrov";
            kitap.sayfasayisi = 220;
            kitap.tur = "Roman";
            kitap.puan = 7.8;

            label6.Text = kitap.KitapAd;
            label7.Text = kitap.yazar;
            label8.Text = kitap.sayfasayisi.ToString();
            label9.Text = kitap.tur;
            label10.Text = kitap.puan.ToString();
        }
    }
}