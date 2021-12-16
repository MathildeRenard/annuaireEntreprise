using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace annuaireEntreprise.Models
{
    public class Db
    {
        private static string connectionString = "Server=127.0.0.1;DataBase=annuaire;UserId=root;password=";
        public static MySqlConnection Connection { get => new MySqlConnection(connectionString); }
    }
   
}
