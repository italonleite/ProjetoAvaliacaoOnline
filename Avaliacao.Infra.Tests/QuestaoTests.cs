using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Avaliacao.Infra.Tests
{
    public class QuestaoTests
    {
        [Fact(DisplayName = "Cadastrar Questão")]
        [Trait("Questão", "Cadastrar Questão")]
        public void Trocar_Nome_Metodo()
        {
            // Arrange
            var p = new Prova(10,"titulo");
            var t = new Tipo(1, "TipoXYZ");
            var q = new Questao(1, "EnunciadoX", 10, p, t);

            var qd = new QuestaoDAL();

            qd.Cadastrar(q, p, t);


            // Act

            // Assert

        }
    }
}
