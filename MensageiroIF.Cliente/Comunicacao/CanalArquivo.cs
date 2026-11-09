using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mensagemaula20.Menssagens;
using MensageiroIF.Cliente.Menssagens;

namespace MensageiroIF.Cliente.Comunicacao
{
    public class CanalArquivo : ICanalDeComunicacao
    {
        private readonly string CAMINHO;
        private int linhasProcessadas = 0;

        public CanalArquivo()
        {
            string pasta = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "MensageiroIF");

            Directory.CreateDirectory(pasta);

            CAMINHO = Path.Combine(pasta, "canal.txt");
        }



        public void Enviar(MensagemTexto mensagem)
        {
            string linha = "ENVIAR|" +
                mensagem.Remetente + "|" +
                mensagem.Destinatario + "|" +
                mensagem.Data.ToString("yyyy-MM-ddTHH:mm") + "|" +
                mensagem.Corpo;

            for (int tentativa = 1; tentativa <= 5; tentativa++)
            {
                try
                {
                    using (FileStream arquivo = new FileStream(
                        CAMINHO,
                        FileMode.Append,
                        FileAccess.Write,
                        FileShare.Read))
                    using (StreamWriter escritor =
                        new StreamWriter(arquivo, new UTF8Encoding(false)))
                    {
                        escritor.WriteLine(linha);
                    }

                    return;
                }
                catch (IOException)
                {
                    if (tentativa == 5)
                    {
                        throw;
                    }

                    System.Threading.Thread.Sleep(100);
                }
            }
        }


        public List<MensagemTexto> ReceberNovas()
        {
            List<MensagemTexto> novas =
                new List<MensagemTexto>();

    
            if (!File.Exists(CAMINHO))
            {

                linhasProcessadas = 0;
                return novas;

            }


            List<string> linhas = new List<string>();

            using (FileStream arquivo = new FileStream(
                CAMINHO,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite))
            using (StreamReader leitor =
                new StreamReader(arquivo))
            {
                string linha;

                while ((linha = leitor.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }


            }

            if (linhas.Count < linhasProcessadas)
            {
                linhasProcessadas = 0;
            }

            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            while (linhasProcessadas < linhas.Count)
            {
                string linha = linhas[linhasProcessadas];

                if (!string.IsNullOrWhiteSpace(linha))
                {
                    try
                    {
                        MensagemTexto mensagem =
                            analisador.Analisar(linha);

                        novas.Add(mensagem);
                    }
                    catch (ProtocoloInvalidoException)
                    {
                        // Tenta novamente no próximo ciclo.
                        break;
                    }
                }

                linhasProcessadas++;
            }

            return novas;
        }


    }
        
    

}
