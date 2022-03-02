namespace _4_EnumYapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum sehirler
        {
            Adana=1,Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToByte(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label2.Text = s.ToString();
        }
    }
}