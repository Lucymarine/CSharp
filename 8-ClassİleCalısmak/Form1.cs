namespace _8_ClassİleCalısmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            arabalar rb = new arabalar();
            rb.renk = "Mavi";
            rb.fiyat = 32.475;
            rb.durum = 's';
            rb.model = 2017;
            rb.hiz = 200;
            label1.Text = rb.renk;
            label2.Text = rb.fiyat.ToString();
            label3.Text = rb.durum.ToString();
            label4.Text = rb.model.ToString();
            label5.Text = rb.hiz.ToString();

            this.BackColor = Color.CadetBlue;
        }
    }
}