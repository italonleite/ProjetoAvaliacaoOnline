using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao.Domain
{
    public class Questao
    {
        public int IdQuestao { get; set; }
        public string Enunciado { get; set; }
        public decimal Pontos { get; set; }
        public Prova Prova { get; set; }
        public Tipo Tipo { get; set; }

        public Questao(int idQuestao, string enunciado, decimal pontos, Prova prova, Tipo tipo)
        {
            IdQuestao = idQuestao;
            Enunciado = enunciado;
            Pontos = pontos;
            Prova = prova;
            Tipo = tipo;
        }
    }
}
