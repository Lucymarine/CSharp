using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SqlTabloManuel
{
     class baglanti
    {
        public SqlConnection dbconnect()
        {
            SqlConnection sqlcon = new SqlConnection("Server=LAPTOP-73TIA64R;Database=Ders2Sinema;Trusted_Connection=True;");
            sqlcon.Open();
            return sqlcon;
        }
    }
}
