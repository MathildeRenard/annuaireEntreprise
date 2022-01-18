using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public void Delete(int id)
        {
            request = "DELETE FROM person WHERE id_person=@id";
            connection.Open();
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            command.ExecuteScalar();
            command.Dispose();
            connection.Close();
        }
        //methode qui récupére les saisies du formulaire de connexion et verifie la validité des informations dans la base de données
        public Employee Login(string mail, string password)
        {
                Employee employee = null;
                //Faire un select si le mot de passe et le login correspondent à ceux dans la base de données.
                request = "SELECT Password,firstname,lastname FROM person WHERE mail = @mail";
                connection = Db.Connection;
                command = new MySqlCommand(request, connection);
                command.Parameters.Add(new MySqlParameter("@mail", mail));

                connection.Open();
                MySqlDataReader resultatRequete = command.ExecuteReader();
                resultatRequete.Read();

                //S'il y a eu une erreur lors de la saisie du login, le résultat de la requête sql lèvera une exception
                try
                {
                    String SavedPasswordHash = resultatRequete["Password"].ToString();
                    
                    //Vérifier si le mot de passe correspond à celui de la base de données
                    byte[] hashBytes = Convert.FromBase64String(SavedPasswordHash);
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] == hash[i])
                        {
                            employee = new Employee()
                            {
                                firstname= resultatRequete["firstname"].ToString(),
                                lastname = resultatRequete["lastname"].ToString(),

                            };

                        }
                }
                //En cas d'erreur sur le login saisi, la variable employee restera à sa valeur initiale "null" et la vue renverra un message d'erreur
                catch (MySqlException)
                {

                }
                catch (ArgumentNullException)
                {

                }
                command.Dispose();
                connection.Close();

                return employee;
            }


        //Méthode à utiliser et à appeller par le développeur dans le but de créer un nouvel administrateur
        
        public void CreateAdmin(string Password,string LastName,string FirstName,string Mail)
        {
            
            request = "INSERT INTO person ( firstname,lastname, Password, mail,phone,mobile_phone,id_site,id_service) values (@firstName, @lastName, @password, @mail,1,1,1,1)";
            
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            
            connection.Open();
           
                //Hashage du mot de passe
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                string PasswordHash = Convert.ToBase64String(hashBytes);

                command.Parameters.Add(new MySqlParameter("@password", PasswordHash));
                command.Parameters.Add(new MySqlParameter("@lastName", LastName));
                command.Parameters.Add(new MySqlParameter("@firstName", FirstName));
                
                command.Parameters.Add(new MySqlParameter("@mail", Mail));
            command.ExecuteScalar();
                
                connection.Close();
                connection.Open();
            }
    }
}
