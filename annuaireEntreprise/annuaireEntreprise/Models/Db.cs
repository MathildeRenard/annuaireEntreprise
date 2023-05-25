using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace annuaireEntreprise.Models
{
    public class Db
    {
        private static string connectionString = "server=127.0.0.1;user=root;database=annuaire;port=3307;password=";
        public static MySqlConnection Connection { get => new MySqlConnection(connectionString); }
    }
   
}
