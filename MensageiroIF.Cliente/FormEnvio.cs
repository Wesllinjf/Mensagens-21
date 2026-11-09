using Mensagemaula20.Classes;
using Mensagemaula20.ClassesInterface;
using Mensagemaula20.Menssagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensageiroIF.Cliente.Comunicacao;


namespace MensageiroIF.Cliente
{
    public partial class FormEnvio : Form
    {
        private readonly ServicoDeHistorico servico;
        private readonly Usuario usuarioAtual;
        private readonly CanalArquivo canal;

        private readonly System.Windows.Forms.Timer timerCanal;


        public FormEnvio(ServicoDeHistorico servico, Usuario usuarioAtual)
        {
            InitializeComponent();
            this.servico = servico;
            this.usuarioAtual = usuarioAtual;
            this.Text = "Mensagem IF - " + usuarioAtual.Apelido;
            AtualizarHistorico();

            canal = new CanalArquivo();

            timerCanal = new System.Windows.Forms.Timer();
            timerCanal.Interval = 2000;
            timerCanal.Tick += TimerCanal_Tick;

            try
            {
                canal.ReceberNovas();

            }
            catch (System.IO.IOException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            timerCanal.Start();

        }
        public void AtualizarHistorico()
        {
            lstHistorico.Items.Clear();
            foreach (Mensagem m in servico.ObterHistorico())
                lstHistorico.Items.Add(m.ToString());

        }

       



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtMensagem.Text;
                string destinatario = cboDestinatario.Text.Trim();
                
                if (string.IsNullOrWhiteSpace(texto))
                {
                    throw new ProtocoloInvalidoException("Mensagem vazia");
                }

                if (texto.Length > 250)
                {
                    throw new ProtocoloInvalidoException("Mensagem muito longa");
                }

                if (string.IsNullOrWhiteSpace(destinatario))
                {
                    throw new ProtocoloInvalidoException("Informe o destinatario");
                }

                MensagemTexto mensagem = new MensagemTexto(texto, usuarioAtual);

                mensagem.Destinatario = destinatario;

                servico.AdicionarMensagem(mensagem);

                canal.Enviar(mensagem);

                AtualizarHistorico();

                txtMensagem.Clear();



                    
            }

            catch (ProtocoloInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem inválida");
            }

            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar arquivo");
            }


        }
        private void FormEnvio_Load(object sender, EventArgs e){}

        private void chkUrgente_CheckedChanged(object sender, EventArgs e)
        {
            // A opção Urgente não deve enviar mensagens automaticamente.
        }

        private void TimerCanal_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (MensagemTexto mensagem in canal.ReceberNovas())
                {
                    if (string.Equals(
                        mensagem.Destinatario,
                        usuarioAtual.Apelido,
                        StringComparison.OrdinalIgnoreCase))

                    {
                        lstHistorico.Items.Add(mensagem.ToString());
                    }
                }
            }

            catch (System.IO.IOException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timerCanal.Stop();
            timerCanal.Dispose();

            base.OnFormClosed(e);
        }

    }
}
