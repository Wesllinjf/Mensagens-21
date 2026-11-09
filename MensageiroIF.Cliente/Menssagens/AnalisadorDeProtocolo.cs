using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Mensagemaula20.Menssagens;

namespace MensageiroIF.Cliente.Menssagens
{
    public class AnalisadorDeProtocolo
    {
        private const string PADRAO =
             @"^ENVIAR\|[^|]+\|[^|]+\|\d\d\d\d-\d\d-\d\dT\d\d:\d\d\|.*$";

        // Passo 5
        public MensagemTexto Analisar(string linha)
        {
            // Passo 6
            if (linha == null)
                throw new ProtocoloInvalidoException("Linha nula");

            linha = linha.Trim();

            // Passo 7
            if (!Regex.IsMatch(linha, PADRAO))
            {
                throw new ProtocoloInvalidoException(linha);
            }

            string[] campos = linha.Split(new[] { '|' }, 5);

            DateTime data;
            try
            {
                data = DateTime.Parse(campos[3]);
            }
            catch (FormatException)
            {
                throw new ProtocoloInvalidoException(linha);
            }

            return new MensagemTexto
            {
                Remetente = campos[1],
                Destinatario = campos[2],
                Data = data,
                Corpo = campos[4]
            };

        }
    }
}
