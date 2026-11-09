using Mensagemaula20.Menssagens;
using Mensagemaula20.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.Classes
{
    public class Usuario
    {
        public string Apelido { get; set; } = string.Empty;
        private List<Usuario> contatos = new List<Usuario>();
        public void AdicionarContato(Usuario outro)
        {
            contatos.Add(outro);
        }
    }
}
