using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Avaliacao.Infra.Tests
{
  
    public class TipoQuestaoTests
    {
        [Fact(DisplayName = "Tipo Questao")]
        [Trait("Tipo", "TipoQuestao")]
        public void Cadastrar_DeveCadastrarTipoQuestao()
        {
            // Arrange
            var t = new Tipo(1, "boolean");
            var td = new TipoDAL();

            td.Cadastrar(t);


            // Act
            

            // Assert

        }
    }
}
