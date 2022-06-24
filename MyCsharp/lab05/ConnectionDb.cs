using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace lab05
{
    public class ConnectionDb
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = DbTest ; User = sa ; password = sa;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
