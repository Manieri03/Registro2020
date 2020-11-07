using System;
using System.Collections.Generic;
using System.Text;

namespace ElementiRegistro
{
    class Docente
    {
        public string nome { get; private set; }
        public string cognome { get; private set; }
        List<Materia> materie = new List<Materia>();
        List<Votazione> voti = new List<Votazione>();

        public Docente(string n, string c, Materia materia)
        {
            nome = n;
            cognome = c;
            materie.Add(materia);
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }
        public void AssegnaVoto(Studente s, Votazione v)
        {
            s.AddVoto(v);
            voti.Add(v);
        }


    }
}
