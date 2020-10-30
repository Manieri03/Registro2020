using System;
using System.Collections.Generic;
using System.Text;

namespace ElementiRegistro
{
    public class Materia
    {
        public string Nome { get; private set; }

        public Materia(string nome)
        {
            this.Nome = nome;
        }
    }
}
