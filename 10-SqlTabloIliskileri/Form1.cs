using System.Data.SqlClient;

namespace _10_SqlTabloIliskileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-73TIA64R;" +
                "Database=Dbo_Sehirler;" +
            "Trusted_Connection=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select SehirAdi from Tbl_Sehirler",sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            sqlConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Select IlceAdi from Tbl_Ilceler where SehirId=@p1",sqlConnection);
            sqlCommand2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex+1);
            SqlDataReader dr2 = sqlCommand2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]);
            }
            sqlConnection.Close();
        }
    }
}