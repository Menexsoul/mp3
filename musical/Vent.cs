using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    class Vent : Instrument
    {
        private int nbNotes;
        public Vent (string unNom, int unNbnotes) : base(unNom)
        {
            this.Nom = unNom;
            this.nbNotes = unNbnotes;
        }


    }
}
