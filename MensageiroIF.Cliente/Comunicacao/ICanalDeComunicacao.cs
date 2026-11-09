using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensagemaula20.Menssagens;


namespace MensageiroIF.Cliente.Comunicacao
{
    internal interface ICanalDeComunicacao
    {
        void Enviar(MensagemTexto mensagem);

        List<MensagemTexto> ReceberNovas();
    }
}
