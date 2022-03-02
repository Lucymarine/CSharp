using System.Data;
using System.Data.SqlClient;

namespace _6_DışarıdanBağlantıAdresiAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sqlbaglantiadresi;

        public object SqlConnection { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader("c:\\adress.txt");

            string satir = oku.ReadLine();

            while (satir != null)
            {
                sqlbaglantiadresi = satir;
                satir = oku.ReadLine();
            }

            SqlConnection sqlConnection = new SqlConnection(sqlbaglantiadresi);
            SqlDataAdapter da = new SqlDataAdapter("Select*From Tbl_Filmler",sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
        }
    }
}