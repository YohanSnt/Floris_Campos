using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floris_Campos.Model
{
    internal class Floricultor
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Estado { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Floricultor(int id, string senha)
        {
           Senha = senha;
        }
        public Floricultor(int id, string nome,string estado, string email,
            string senha) : this(nome,estado,email,senha)
        {
            Id = id;
        }

        public Floricultor(string nome,
            string estado, string email, string senha)
        {
            Nome = nome;
            Estado = estado;
            Email = email;
            Senha = senha;
        }
    }
}
    


