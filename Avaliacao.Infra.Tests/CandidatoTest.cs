using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Avaliacao.Infra.Tests
{
    public class CandidatoTest
    {
        [Fact(DisplayName = "Cadastrar Candidato")]
        public void Cadastrar_DeveAdicionar()
        {
            var p = new Prova(1, "Prova");
            var c = new Candidato(1, "ItaloCandidato", "italite@gmail.com", p);
            
            var cd = new CandidatoDAL();

            cd.Cadastrar(c);



        }


     

    }
}
