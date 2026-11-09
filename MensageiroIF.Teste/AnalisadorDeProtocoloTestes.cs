using MensageiroIF.Cliente.Menssagens;
using Mensagemaula20.Menssagens;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MensageiroIF.Teste
{
    [TestClass]
    public sealed class AnalisadorDeProtocoloTestes
    {
        [TestMethod]
        public void Analisar_LinhaValida_DevolveRemetenteCorreto()
        {
            // Preparar
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            string linha =
                "ENVIAR|ana|bruno|2026-10-20T14:32|bom dia";

            // Agir
            MensagemTexto mensagem = analisador.Analisar(linha);

            // Conferir
            Assert.AreEqual("ana", mensagem.Remetente);
        }

        [TestMethod]
        public void Analisar_LinhaComCampoFaltando_LancaProtocoloInvalidoException()
        {
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            try
            {
                analisador.Analisar("ENVIAR|ana|bruno");

                Assert.Fail("Era esperada uma ProtocoloInvalidoException, e nada foi lançado.");
            }
            catch (ProtocoloInvalidoException)
            {
                // Exceção esperada: o teste passa.
            }
        }


        [TestMethod]
        public void Analisar_LinhaVazia_LancaProtocoloInvalidoException()
        {
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            try
            {
                analisador.Analisar("");

                Assert.Fail("Era esperada uma ProtocoloInvalidoException, e nada foi lançado.");
            }
            catch (ProtocoloInvalidoException)
            {
                // Exceção esperada: o teste passa.
            }
        }


        [TestMethod]
        public void Analisar_DestinatarioVazio_LancaProtocoloInvalidoException()
        {
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            try
            {
                analisador.Analisar(
                    "ENVIAR|ana||2026-10-20T14:32|bom dia"
                );

                Assert.Fail(
                    "Era esperada uma ProtocoloInvalidoException."
                );
            }
            catch (ProtocoloInvalidoException)
            {
                // Exceção esperada.
            }
        }


        [TestMethod]
        public void Analisar_TextoComBarraVertical_PreservaConteudo()
        {
            // Preparar
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            string linha =
                "ENVIAR|ana|bruno|2026-10-20T14:32|bom dia|tudo bem?";

            // Agir
            MensagemTexto mensagem = analisador.Analisar(linha);

            // Conferir
            Assert.AreEqual(
                "bom dia|tudo bem?",
                mensagem.Corpo
            );
        }


        [TestMethod]
        public void Analisar_DataInvalida_LancaProtocoloInvalidoException()
        {
            // Preparar
            AnalisadorDeProtocolo analisador =
                new AnalisadorDeProtocolo();

            string linha =
                "ENVIAR|ana|bruno|data-invalida|bom dia";

            // Agir
            try
            {
                analisador.Analisar(linha);

                // Conferir
                Assert.Fail(
                    "Era esperada uma ProtocoloInvalidoException."
                );
            }
            catch (ProtocoloInvalidoException)
            {
                // Exceção esperada: o teste passa.
            }
        }


    }
}
