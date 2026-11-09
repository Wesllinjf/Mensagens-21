using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MensageiroIF.Cliente.Menssagens;

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
            List<Mensagem> mensagens = new List<Mensagem>();

            if (!File.Exists(CAMINHO))
            {
                return mensagens;
            }

            AnalisadorDeProtocolo analisador = new AnalisadorDeProtocolo();

            using (Stream arquivo = File.Open(CAMINHO, FileMode.Open))
            using (StreamReader leitor = new StreamReader(arquivo))
            {
                string linha = leitor.ReadLine();

                while (linha != null)
                {

                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        MensagemTexto mensagem = analisador.Analisar(linha);
                        mensagens.Add (mensagem);
                    }

                    linha = leitor.ReadLine();
                }
            }

            return mensagens;
        }


        // ANEXO A - EXERCÍCIO 3
        public void Apagar()
        {

            if (File.Exists(CAMINHO))
            {
                File.Delete(CAMINHO);
            }

        }


    }
}

