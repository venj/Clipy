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
        }
    }
}
