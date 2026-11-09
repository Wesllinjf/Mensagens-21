
using Mensagemaula20.Classes;
using Mensagemaula20.ClassesInterface;
using System;
using System.Windows.Forms;

namespace MensageiroIF.Cliente
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Escolhe o usuário ao iniciar o programa.
            string apelido = args.Length > 0
                ? args[0]
                : "ana";

            var usuario = new Usuario(apelido);

            IRepositorioDeMensagens repositorio =
                new RepositorioEmArquivo();

            var servico =
                new ServicoDeHistorico(repositorio);

            Application.Run(
                new FormEnvio(servico, usuario));
        }
    }
}
