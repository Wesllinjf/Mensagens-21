using Mensagemaula20.Classes;
using Mensagemaula20.ClassesInterface;
using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class MensagemSistema : Mensagem
    {
        public int Prioridade { get; set; }

        public override void Exibir()
        {
            Console.WriteLine($"\n[SISTEMA] - Prioridade {Prioridade} - {Remetente}: {Corpo}");
        }

        public static MensagemSistema CriarMensagem(string linha)
        {
            string[] campos = linha.Split('|');

            if (campos.Length < 4)
            {
                throw new ProtocoloInvalidoException(
                    $"Protocolo inválido! A linha enviada possui apenas {campos.Length} campos, mas o sistema exige no mínimo 4 campos [Tipo | Remetente | Corpo | Prioridade]"
                );
            }
            else
            {
                MensagemSistema msg = new MensagemSistema();
                msg.Remetente = campos[1].Trim();
                msg.Corpo = campos[2].Trim();
                msg.Prioridade = int.Parse(campos[3].Trim());
                msg.Data = DateTime.Now;
                return msg;
            }
        }
    }
