using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    internal class Groupe
    {
        private string nom;
        private DateTime dateCreation;
        private List<Instrument> instruments;
        List<Representation> representations;

        public Groupe(string unNom, DateTime uneDateCreation)
        {
            this.nom = unNom;
            this.dateCreation = uneDateCreation;
            instruments = new List<Instrument>();
            representations = new List<Representation>();
        }

        public void AjouterInstruments(Instrument unInstruments)
        {
            instruments.Add(unInstruments);
        }

        public void AjouterRepresentations(Representation uneRepresentations)
        {
            representations.Add(uneRepresentations);
        }

        public void listeInstruments()
        {
            Console.WriteLine($"Instruments du groupe {nom} :");
            foreach (var instrument in instruments)
            {
                Console.WriteLine($"- {instrument}");
            }
        }

        public void listeRepresentations()
        {
            Console.WriteLine($"Représentations du groupe {nom} :");
            foreach (var rep in representations)
            {
                Console.WriteLine($"- {rep}");
            }
        }
    } 


}
