using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.ClassesInterface
{
    public interface IRepositorioDeMensagens
    {
        void Guardar(Mensagem m);
        List<Mensagem> Listar();
    }
}
