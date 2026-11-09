using Mensagemaula20.Classes;
using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.ClassesInterface
{
    public class ServicoDeHistorico
    {
        private IRepositorioDeMensagens repo;
        public ServicoDeHistorico(IRepositorioDeMensagens r)
        {
            repo = r;
        }
        public int Resumo()
        {
            return repo.Listar().Count;
        }

        public void AdicionarMensagem(Mensagem m)
        {
            repo.Guardar(m);
        }
        public void Registrar(string texto, Usuario autor)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ProtocoloInvalidoException("A mensagem esta vazia.");
            if (texto.Length > 250)
                throw new ProtocoloInvalidoException("A mensagem passa de 250 caracteres.");
            repo.Guardar(new MensagemTexto(texto, autor));
        }
        public List<Mensagem> ObterHistorico()
        {
            return repo.Listar();
        }
    }
}
