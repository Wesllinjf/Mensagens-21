using Mensagemaula20.Menssagens;
using Mensagemaula20.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.ClassesInterface
{
    public class RepositorioEmMemoria : IRepositorioDeMensagens
    {
        private List<Mensagem> _mensagens = new List<Mensagem>();
        public void Guardar(Mensagem m)
        {
            _mensagens.Add(m);
        }
        public List<Mensagem> Listar()
        {
            return _mensagens;
        }
    }
    public class RepositorioFalso : IRepositorioDeMensagens
    {
        public int ContadorChamadas { get; private set; } = 0;

        public void Guardar(Mensagem m)
        {
            ContadorChamadas++;
        }

        public List<Mensagem> Listar()
        {
            List<Mensagem> fixas = new List<Mensagem>
            {
                new MensagemTexto { Remetente = "Teste1", Corpo = "Mensagem fixa 1" },
                new MensagemTexto { Remetente = "Teste2", Corpo = "Mensagem fixa 2" }
            };
            return fixas;
        }
    }
}
