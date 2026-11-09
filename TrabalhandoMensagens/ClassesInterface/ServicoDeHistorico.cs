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
    }
}
