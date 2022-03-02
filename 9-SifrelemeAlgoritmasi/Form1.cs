using System.Text;

namespace _9_SifrelemeAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifrelenecekmetin = textBox1.Text;
            byte [] veridizim = ASCIIEncoding.ASCII.GetBytes(sifrelenecekmetin);
            string sifrelimetin = Convert.ToBase64String(veridizim);
            textBox2.Text = sifrelimetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifrecoz = textBox2.Text;
            byte [] veridizimcoz = Convert.FromBase64String(sifrecoz);
            string anametin2 = ASCIIEncoding.ASCII.GetString(veridizimcoz);
            textBox1.Text = anametin2;
        }
    }
}