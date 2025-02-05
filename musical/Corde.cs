using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    class Corde : Instrument
    {
        private int nbCorde;
        public Corde(int unNbCorde, string unNom) : base(unNom)
        {
            this.nbCorde = 0;
            this.Nom = unNom;
        }


    }
}
