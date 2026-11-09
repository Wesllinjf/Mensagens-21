using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.Menssagens
{
    public class ProtocoloInvalidoException : Exception
    {
        public ProtocoloInvalidoException(string mensagem) : base(mensagem) { }
    }
}
