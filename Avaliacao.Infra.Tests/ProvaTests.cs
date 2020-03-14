using Avaliacao.Domain;
using System;
using Xunit;

namespace Avaliacao.Infra.Tests
{
    public class ProvadDALTests
    {

        [Fact(DisplayName = "Cadastrar Prova")]
        public void Cadastrar_DeveAdicionar()
        {
            // Arrange
            var p = new Prova(153, "abc");
            var pd = new ProvaDAL();
            
            // Act
            pd.Cadastrar(p);
                
            //Assert
            Assert.Equal("abc", p.Titulo);

        }

        [Fact(DisplayName = "Atualizar Prova")]
        public void Atualizar_DeveAtualizar()
        {
            // Arrange
            var p = new Prova(1009, "abcatualizado");

            var pd = new ProvaDAL();
            // Act
            pd.Atualizar(p.IdProva, p.Titulo);


            //Assert


        }
    }
}
