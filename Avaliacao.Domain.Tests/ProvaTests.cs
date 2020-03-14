using System;
using Xunit;

namespace Avaliacao.Domain.Tests
{
    public class ProvaTests
    {
        [Fact(DisplayName = "Objeto Tipo de Prova")]       
        public void Criar_DeveRetornarTipoProva()
        {
            // Arrange
           var p = new Prova(1, "ProvaTeste");

            Assert.IsType<Prova>(p);

        }

        [Fact(DisplayName = "Deve Ignorar Case")]
        public void Titulo_DeveIgnorarCase()
        {
            // Arrange
            var p = new Prova(1, "ProvaTeste");

            Assert.Equal("PROVATESTE", p.Titulo, true);

        }

        [Fact(DisplayName = "Deve Conter Trecho")]
        public void Titulo_DeveConterTrecho()
        {
            // Arrange
            var p = new Prova(1, "ProvaTeste");

            Assert.Contains("Teste", p.Titulo);

        }

        [Fact(DisplayName = "Erro ao inserir Titulo inválido")]
        public void Criar_DeveRetornarErroTituloVazio()
        {
            // Arrange
           var Exception = Assert.Throws<Exception>(() => new Prova(1, ""));

            Assert.Equal("Titulo Invalido", Exception.Message);
        }


    }
}
