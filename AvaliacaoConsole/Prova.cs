using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoConsole
{
    public class Prova
    {
        public int IdProva { get; set; }
        public string Titulo { get; set; }

        public Prova(int idProva, string titulo)
        {
            IdProva = idProva;
            Titulo = titulo;
        }

    }
}
