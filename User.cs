using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        private static int autoIncId = 1;

        public User(string name, string email, string password)
        {
            this.Id = autoIncId;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            autoIncId++;
        }

        // Properties
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
