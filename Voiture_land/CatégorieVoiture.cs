using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture_land
{
    class CatégorieVoiture
    {
        public string Nom { get; set; }
        public double PrixJour { get; set; }
        public List<Voiture> ListeVoiture { get; set; }
    }
}
