using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    class Connection
    {
        private static Connection connection = null;

        public Connection()
        {

        }

        public static Connection getInstance()
        {
            if (connection == null)
            {
                connection = new Connection();
            }
            return connection;
        }

        public SqlConnection ConnectionDB()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=ESTEBAN-PC\SQLEXPRESS; Initial Catalog=Inventario; User ID=usuarioinventario; Password=1234";
            return connection;
        }
    }
}
