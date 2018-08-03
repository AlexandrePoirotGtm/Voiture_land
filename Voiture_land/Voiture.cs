using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture_land
{
    class Voiture : Véhicule
    {
        public int NombrePortes { get; set; }

        CatégorieVoiture LaCatégorie { get; set; }

        public Voiture()
        {
            NombrePortes = 5;
        }
    }
}
