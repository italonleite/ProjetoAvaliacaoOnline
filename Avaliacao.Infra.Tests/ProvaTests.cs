using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace Avaliacao.Infra.Tests
{
    public class ProvaTests
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

        [Fact(DisplayName = "Buscar Prova por ID")]
        public void BuscarPorId_DeveEncontrar()
        {
            // Arrange
            var pd = new ProvaDAL();
            // Act
            pd.ConsultarPorId(1);


            //Assert


        }
        [Fact(DisplayName = "Lista todas provas")]
        public void BuscarTodos()
        {
            // Arrange
            var pd = new ProvaDAL();
            // Act
            pd.ListarTodos();


            //Assert


        }
    }
}
