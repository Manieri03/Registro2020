using System;

namespace ElementiRegistro
{
    public class Classe
    {
        private int Anno;
        private string Sezione;

        public Classe(int anno, string sezione)
        {
            this.Anno = anno;
            this.Sezione = sezione;
        }

        public string GetNome()
        {
            string annostring = Anno.ToString();
            return annostring + Sezione;

        }


        //public Votazione TrovaVotoMassimo()
        //{

        //}
        
            


    }
}
