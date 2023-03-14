using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Data
{
    public static class Database
    {

        private static string connectionString = "Server=.\\SQLEXPRESS; Database=product; Integrated Security=true";
            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        
    }
}
