using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfil_Llibreria
{
    class Usuario
    {
        public String Username { get; set; }
        public String Password { get; set; }

        public Usuario(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Usuario()
        {
        }
    }
}
