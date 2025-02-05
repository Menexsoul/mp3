using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    internal class Tendance
    {
        private string libelle;
        private List<Groupe> Groupes;

        public Tendance(string unLibelle)
        {
            this.libelle = unLibelle;
        }

        public void AjouterGroupes(Groupe uneListeGroupes)
        {
            Groupes.Add(uneListeGroupes);
        }

        public void listeGroupes()
        {
            Console.WriteLine($"Liste de Groupes {libelle} :");
            foreach (var grp in Groupes)
            {
                Console.WriteLine($"- {grp}");
            }
        }
    }


}
