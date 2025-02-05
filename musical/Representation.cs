using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musical
{
    internal class Representation
    {
        private DateTime date;
        private string lieu;
        private int duree;

        public Representation(DateTime uneDate, string unLieu, int uneDuree)
        {
            this.date = uneDate;
            this.lieu = unLieu;
            this.duree = uneDuree;
        }
    }
}
