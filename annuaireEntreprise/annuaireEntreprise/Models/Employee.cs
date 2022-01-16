using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace annuaireEntreprise.Models
{
    public class Employee
    {
        private int idEmployee;
        private string firstname;
        private string lastname;
        private string mail;
        private int phone;
        private int mobilePhone;
        private Service service;
        private Site site;
        private string password;
        private Db db;
        private string request;
        private MySqlConnection connection = Db.Connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public string Mail { get => mail; set => mail = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Phone { get => phone; set => phone = value; }
        public int MobilePhone { get => mobilePhone; set => mobilePhone = value; }
        public Service Service { get => service; set => service = value; }
        public Site Site { get => site; set => site = value; }
        public string Password { get => password; set => password = value; }
   
        public List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            request = "SELECT id_person, firstname,lastname,phone,mobile_phone,mail,person.id_site,name_site,person.id_service,name_service FROM person left join site on(site.id_site= person.id_site) join service on(service.id_service = person.id_service)";

            command = new MySqlCommand(request, connection);

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee()
                {
                    IdEmployee = reader.GetInt32(0),
                    Firstname = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Phone = reader.GetInt32(3),
                    MobilePhone = reader.GetInt32(4),
                    Mail = reader.GetString(5),
                    Site = new Site()
                    {
                        
                       IdSite = reader.GetInt32(6),
                       NameSite = reader.GetString(7),
                    },
                    Service = new Service()
                    {
                        IdService = reader.GetInt32(8),
                        NameService = reader.GetString(9),  
                    },
            
                };
                employees.Add(employee);
            }

            reader.Close();
            command.Dispose();
            connection.Close();
            return employees;
        }
        public void Create(string firstname, string lastname, int phone, int mobilePhone, string mail, int idEmployee, int idservice, int idsite)
        {

            request = "INSERT INTO person (firstname,lastname,phone,mobile_phone,mail,id_site,id_service) VALUE(@firstname,@lastname,@phone,@mobilePhone,@mail,@idSite,@idService) ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@firstname", firstname));
            command.Parameters.Add(new MySqlParameter("@lastname", lastname));
            command.Parameters.Add(new MySqlParameter("@phone", phone));
            command.Parameters.Add(new MySqlParameter("@mobilePhone", mobilePhone));
            command.Parameters.Add(new MySqlParameter("@mail", mail));
            command.Parameters.Add(new MySqlParameter("@idSite", idsite));
            command.Parameters.Add(new MySqlParameter("@idService", idservice));
            command.Parameters.Add(new MySqlParameter("@idPerson", idEmployee));


            command.ExecuteScalar();


            command.Dispose();
            connection.Close();
        }
        public void Update(string firstname, string lastname, int phone, int mobilePhone, string mail, int idEmployee, int idservice, int idsite)
        {
            request = "UPDATE person SET firstname=@firstname,lastname=@lastname,phone=@phone,mobile_phone=@mobilePhone,mail=@mail,id_site=@idSite,id_service=@idService WHERE id_person=@idPerson ";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@firstname", firstname));
            command.Parameters.Add(new MySqlParameter("@lastname", lastname));
            command.Parameters.Add(new MySqlParameter("@phone", phone));
            command.Parameters.Add(new MySqlParameter("@mobilePhone", mobilePhone));
            command.Parameters.Add(new MySqlParameter("@mail", mail));
            command.Parameters.Add(new MySqlParameter("@idSite", idsite));
            command.Parameters.Add(new MySqlParameter("@idService", idservice));
            command.Parameters.Add(new MySqlParameter("@idPerson", idEmployee));


            command.ExecuteScalar();


            command.Dispose();
            connection.Close();
        }
        public void Delete()
        {

        }
        public void Login()
        {

        }
        public void Logout()
        {

        }
    }
}
