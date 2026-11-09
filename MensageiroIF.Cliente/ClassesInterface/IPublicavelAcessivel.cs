using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.ClassesInterface
{
    public interface IPublicavelAcessivel
    {
        void Publicar();
    }
    public class Aviso : IPublicavelAcessivel
    {
        public void Publicar() { Console.WriteLine("Publicando aviso...");/* publica o aviso */ }
    }
    public class Cardapio : IPublicavelAcessivel
    {
        public void Publicar() { Console.WriteLine("Publicando cardápio...");/* publica o cardapio */ }
    }
}
