using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoConsole
{
    class Candidato
    {
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Prova Prova { get; set; }

        public Candidato(int idCandidato, string nome, string email, Prova prova)
        {
            IdCandidato = idCandidato;
            Nome = nome;
            Email = email;
            Prova = prova;
        }
    }
}
