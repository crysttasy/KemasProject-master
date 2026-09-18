using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    class conn
    {
        public static MySqlConnection connec = new MySqlConnection("server=127.0.0.1; username='root'; password=''; database='db_kemas' ");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string query)
        {
            Console.WriteLine(query);
            ds.Tables.Clear();
            perintah = new MySqlCommand(query, connec);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}
