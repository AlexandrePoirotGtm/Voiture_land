using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture_land
{
    class ContratLocation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int KilométrageMaximum { get; set; }

        public List<Véhicule> ListVéhicule { get; set; }

        public double CalculerMontantLocation(DateTime dateD,DateTime dateF)
        {
            return 0;
        }
    }
}
