﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao.Domain
{
   public class Tipo
    {
        public int IdTipo { get; set; }
        public string TipoEnunciado { get; set; }

        public Tipo(int idtipo, string tipoenunciado)
        {
            IdTipo = idtipo;
            TipoEnunciado = tipoenunciado;
        }
    }
}
