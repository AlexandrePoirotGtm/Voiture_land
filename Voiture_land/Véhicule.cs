using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture_land
{
    abstract class Véhicule
    {
        public string Marque { get; set; }
        public string Modèle { get; set; }

        public ContratLocation LeContrat { get; set; }


        public double GetPrix_Jour()
        {
            return 0;
        }
    }
}
