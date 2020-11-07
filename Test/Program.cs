using ElementiRegistro;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Scuola scuola = new Scuola("RosselliRasetti");

            Classe c = scuola.CreaClasse(4, "AI");
            Studente s1 = new Studente("Alessio", "Manieri");
            Studente s2 = new Studente("Filippo", "Pepe");

            Materia m1 = scuola.CreaMateria("Informatica");
            Materia m2 = scuola.CreaMateria("Italiano");
            Materia m3 = scuola.CreaMateria("Matematica");
            Materia m4 = scuola.CreaMateria("Religione");

            Votazione v1 = new Votazione(m1, s1, 8);
            Votazione v2 = new Votazione(m3, s1, 9);
            Votazione v3 = new Votazione(m2, s1, 6);
            Votazione v4 = new Votazione(m4, s1, 3);

            s1.AddVoto(v1);
            s1.AddVoto(v3);

            s2.AddVoto(v2);
            s2.AddVoto(v4);

            c.AddStudente(s1);
            c.AddStudente(s1);

            Console.WriteLine(s1.TrovaVotoMassimo());

        }
    }
}
