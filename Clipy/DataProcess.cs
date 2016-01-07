using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Clipy
{
    class DataProcess
    {
        SQLiteConnection conn;
        public static string DBPATH = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "data.db");

        public DataProcess()
        {
            using (conn = new SQLiteConnection("Data Source=" + DBPATH))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "CREATE TABLE Demo(id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE)";
                    command.ExecuteNonQuery();
                    command.CommandText = "DROP TABLE Demo";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
