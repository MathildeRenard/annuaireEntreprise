using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace annuaireEntreprise.Models
{
    public class Service
    {
        private int idService;
        private string nameService;
        private List<Employee> employees;
        private Site site;
        private string request;
        private MySqlConnection connection = Db.Connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public int IdService { get => idService; set => idService = value; }
        public string NameService { get => nameService; set => nameService = value; }

        //Méthode qui permet la récupération de la liste des sites afin de les afficher
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            request = "SELECT id_service, name_service FROM service";

            command = new MySqlCommand(request, connection);

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Service service = new Service()
                {
                    IdService = reader.GetInt32(0),
                    NameService = reader.GetString(1),

                };
                services.Add(service);
            }

            reader.Close();
            command.Dispose();
            connection.Close();
            return services;
        }
        public void Create(string service)
        {
            request = "INSERT INTO service (name_service) VALUE(@nameService) ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nameService", service));

            command.ExecuteScalar();


            command.Dispose();
            connection.Close();
        }
        public void Update(string service, int id)
        {
            request = "UPDATE service SET name_service=@nameService WHERE id_service=@id ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nameService", service));
            command.Parameters.Add(new MySqlParameter("@id", id));
            command.ExecuteScalar();
            command.Dispose();
            connection.Close();

        }
        public void Delete(int id)
        {
            request = "DELETE FROM service WHERE id_service=@id";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            command.ExecuteScalar();
            command.Dispose();
            connection.Close();
        }
    }
}
