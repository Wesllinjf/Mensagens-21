using Mensagemaula20.ClassesInterface;
using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<IPublicavelAcessivel> fila = new List<IPublicavelAcessivel>();
        fila.Add(new Aviso());
        fila.Add(new Cardapio());

        foreach (IPublicavelAcessivel item in fila)
        {
            item.Publicar();
        }

        Console.WriteLine("=== ATENDIMENTO DO SISTEMA ===");

        List<Mensagem> historico = new List<Mensagem>();
        historico.Add(new MensagemTexto { Remetente = "Rafael", Data = DateTime.Now, Corpo = "Olá, gostaria de agendar uma manutenção" });
        historico.Add(new MensagemSistema { Remetente = "Sistema", Data = DateTime.Now, Corpo = "Manutenção agendada!", Prioridade = 1 });
        historico.Add(new MensagemTexto { Remetente = "Carlos", Data = DateTime.Now, Corpo = "Adiar a reunião" });
        historico.Add(new MensagemSistema { Remetente = "Sistema", Data = DateTime.Now, Corpo = "Reunião Adiada!", Prioridade = 2 });
        foreach (Mensagem m in historico)
        {
            m.Exibir();
            if (m is MensagemSistema s)
            {
                Console.WriteLine($"Prioridade do Sistema: {s.Prioridade}");
            }
        }
        try
        {
            string linhaInvalida = "Ana | Preciso de suporte técnico";
            MensagemSistema novaMsg = MensagemSistema.CriarMensagem(linhaInvalida);
            historico.Add(novaMsg);
        }
        catch (ProtocoloInvalidoException ex)
        {
            Console.WriteLine($"\nErro de Protocolo: {ex.Message}");
        }

        try
        {
            Mensagem msgRafael = historico[0];
            Mensagem msgCarlos = historico[2];
            bool saoIguais = msgRafael.Equals(msgCarlos);
            Console.WriteLine($"\nAs mensagens são do mesmo remetente? {saoIguais}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao comparar: {ex.Message}");
        }
    }
}