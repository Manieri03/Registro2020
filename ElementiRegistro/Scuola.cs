using System;
using System.Collections.Generic;
using System.Text;

namespace ElementiRegistro
{
    public class Scuola
    {
        public string Nome { get; private set; }

        public List<Classe> Classi { get; private set; }
        public List<Materia>Materie { get; private set; }

        public Scuola(string nome)
        {
            this.Nome = nome;
            Classi = new List<Classe>();
        }
        public Classe CreaClasse(int anno, string sezione)
        {
            Classe c = new Classe(anno, sezione);
            Classi.Add(c);
            return c;
        }
        public Materia CreaMateria(string nome)
        {
            Materia m = new Materia(nome);
            Materie.Add(m);
            return m;
        }

        //public Votazione TrovaVotoMassimo()
        //{
         
        //}
    }
}
