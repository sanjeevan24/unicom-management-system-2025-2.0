using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicom_management_system_2025.Repositories
{
    internal class db_conn
    {
        private static string connectionString = "Data Sourse=DB S.db; Version=3;";
        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
