using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture_land
{
    class Agence
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Véhicule> ListVéhicules { get; set; }
        public List<Employé> ListEmployés { get; set; }
    }
}
