using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        private Role role;
        private Db db;

        public string Mail { get => mail; }

        public void Create()
        {

        }
        public void Update()
        {

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
