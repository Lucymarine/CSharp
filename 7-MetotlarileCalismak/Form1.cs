namespace _7_MetotlarileCalismak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void metot1()
        {
            label1.Text = "Merhaba Dünya";
            label2.Text = "Hello world";
            label3.Text = "How are you";
            label4.Text = "I am fine you";
        }
        void metot2()
        {
            label1.BackColor = Color.Blue;
            label2.BackColor = Color.OrangeRed;
            label3.BackColor= Color.Crimson;
            label4.BackColor = Color.DarkRed;

        }
        void metot3()
        {
            label1.ForeColor = Color.White;
            this.Text = "C# Dersleri metot Kavrami";
            MessageBox.Show("Metotlar yapýldý.");
        }

        private int toplam (int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metot1();
            metot2();
            metot3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = toplam(7, 3).ToString();
            label6.Text = toplam(5,4).ToString();
            label7.Text = toplam(2,3).ToString();
        }
    }
}