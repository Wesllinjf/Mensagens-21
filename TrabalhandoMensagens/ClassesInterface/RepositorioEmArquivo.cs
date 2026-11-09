using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mensagemaula20.ClassesInterface
{
    public class RepositorioEmArquivo : IRepositorioDeMensagens
    {
        private const string CAMINHO = "historico.txt";

        public void Guardar(Mensagem m)
        {
            MensagemTexto mensagem = m as MensagemTexto;

            if (mensagem == null)
            {
                throw new ArgumentException("Mensagem inváilida");
            }

            string linha = "ENVIAR|" +
            mensagem.Remetente + "|" +
            mensagem.Destinatario + "|" +
            mensagem.Data.ToString("yyyy-MM-ddTHH:mm") + "|" +
            mensagem.Corpo;

            using (Stream arquivo = File.Open(CAMINHO, FileMode.Append))
            using (StreamWriter escritor = new StreamWriter(arquivo))
            {
                escritor.WriteLine(linha);
            }
        }

        public List<Mensagem> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

