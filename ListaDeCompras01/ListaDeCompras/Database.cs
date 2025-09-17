using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ListaDeCompras
{
    public static class Database

    {

        public static string ConnectionString = "Server=localhost;Database=db_lista_compras;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection() => new MySqlConnection(ConnectionString);

    }
}
