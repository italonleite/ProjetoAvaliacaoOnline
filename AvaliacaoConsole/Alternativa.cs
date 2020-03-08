using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoConsole
{
    public class Alternativa
    {
        public int IdAlternativa { get; set; }
        public string Opcao { get; set; }
        public Questao Questao { get; set; }
        public bool Correta { get; set; }

        public Alternativa(int idAlternativa, string opcao, Questao questao, bool correta)
        {
            IdAlternativa = idAlternativa;
            Opcao = opcao;
            Questao = questao;
            Correta = correta;
        }
    }
}
