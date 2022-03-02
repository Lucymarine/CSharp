using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ConnectionString
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            // Sql Connection Bağlantısını baglan olarak tanımladık
            SqlConnection baglan = new SqlConnection("Server=LAPTOP-73TIA64R;" +
                "Database=Ders1;Trusted_Connection=True;");
            baglan.Open();
            //burada da balantımızı açtık ve sonuç olarak return baglan dedik.
            return baglan;
        }
    }
}
