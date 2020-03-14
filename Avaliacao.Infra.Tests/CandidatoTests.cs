using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Avaliacao.Infra.Tests
{
    public class CandidatoTests
    {
        [Fact(DisplayName = "Cadastrar Candidato")]
        public void Cadastrar_DeveAdicionar()
        {
            //Arrange
            var p = new Prova(1, "Prova");
            var c = new Candidato(1, "ItaloCandidato", "sdas@gmail.com", p);
            
            var cd = new CandidatoDAL();

            //Act
            cd.Cadastrar(c);


            //Assert


        }


     

    }
}
