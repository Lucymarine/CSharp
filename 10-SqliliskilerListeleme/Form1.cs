using System.Data.SqlClient;

namespace _10_SqliliskilerListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-73TIA64R;Initial Catalog=Dbo_Sehirler;Integrated Security=True;");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            sqlConnection.Open();
            SqlCommand cmd2 = new SqlCommand("Select*From Tbl_Ilceler where SehirID=@p1", sqlConnection);
            cmd2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2[1]);
            }
            sqlConnection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}