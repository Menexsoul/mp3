using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    abstract class Instrument
    {
        protected string Nom;

        public Instrument(string unNom)
        {
            this.Nom = unNom;
        }

        public override string ToString()
        {
            return Nom;
        }

        public void Jouer()
        {
            Console.WriteLine("Je joue de la musique DO RE MI FA SOL LA SI DO.");
        }

        public void Accorder()
        {
            Console.WriteLine("J'accorde mon instrument : DO MI SOL DO DO SOL MI DO");
        }

    }

   
}
