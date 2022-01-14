using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace annuaireEntreprise.Models
    
{
    public class Site
    {
        private int idSite;
        private string nameSite;
        private Db db;
        private string request;
        private  MySqlConnection connection = Db.Connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public int IdSite{ get => idSite; set => idSite = value; }
        public string NameSite { get => nameSite; set => nameSite = value; }

        //Méthode qui permet la récupération de la liste des sites afin de les afficher
        public List<Site>  GetSites()
        {
            
            List<Site> sites = new List<Site>();
            request = "SELECT id_site, name_site FROM site";
            
            command = new MySqlCommand(request, connection);
      
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Site site = new Site()
                {
                    IdSite = reader.GetInt32(0),
                    NameSite = reader.GetString(1),
                
                };
                sites.Add(site);
            }

            reader.Close();
            command.Dispose();
            connection.Close();
            return sites;
        }

        public void Create(string ville)
        {
            request = "INSERT INTO site (name_site) VALUE(@nameSite) ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nameSite", ville));

            command.ExecuteScalar();


            command.Dispose();
            connection.Close();
        }
        public void Delete(int id)
        {
            request = "DELETE FROM site WHERE id_site=@id";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            command.ExecuteScalar();
            command.Dispose();
            connection.Close();
        }
        public void Update(string ville, int id)
        {
            request = "UPDATE site SET name_site=@nameSite WHERE id_site=@id ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nameSite", ville));
            command.Parameters.Add(new MySqlParameter("@id", id));

            
            
            command.ExecuteScalar();
            
            
            command.Dispose();
            connection.Close();
            
        }
    }
    }

