using System;
using System.Collections.Generic;
using System.Text;

namespace ElementiRegistro
{
    class Votazione
    {
        public double Valutazione{ get; private set; }
        public DateTime Data { get; private set; }

        private Studente Studente;
        public Materia M { get; private set; }
        

        public Votazione(Materia m,Studente studente, double valutazione)
        {
            this.Valutazione = valutazione;
            this.Studente = studente;
            this.M = m;
            
        }

        public bool IsSufficiente()
        {
            if (Valutazione >= 6)
            {
                return true;
            }
            else
                return false;
        }
    }
}
