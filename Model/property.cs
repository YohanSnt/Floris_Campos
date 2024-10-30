using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floris_Campos
{
    internal class Property
    {
        public int CodUsuario{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Property (int codusuario, string name, string email, string password): 
            this(name, email, password)
        {
           CodUsuario = codusuario;
        }

        public Property(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
