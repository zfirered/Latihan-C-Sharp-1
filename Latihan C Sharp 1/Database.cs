using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Latihan_C_Sharp_1
{
    class Database
    {
        public SQLiteConnection conn;
        public Database()
            {
            conn = new SQLiteConnection("Data Source=Database/Database1.db;version=3;Password=Pokemon400");
            }
    }
}
