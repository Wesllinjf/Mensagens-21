using Mensagemaula20.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagemaula20.Menssagens
{
    public class MensagemTexto : Mensagem
    {
        public string Destinatario { get; set; }

        public MensagemTexto() { }

        public MensagemTexto(string texto, Usuario de)
        {
            Corpo = texto;
            Remetente = de.Apelido;
            Data = DateTime.Now;
        }

        public override void Exibir()
        {
            Console.WriteLine($"\n[TEXTO] - {Remetente} ({Data:HH:mm}): {Corpo}");
        }
    }
}
