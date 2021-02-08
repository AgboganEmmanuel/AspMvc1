using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Vues_Controller.Models
{
    public class IVoitures
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Annee { get; set; }
        public string Couleur { get; set; }
        public string ChemeinPhoto { get; set; }
        public double Prix{ get; set; } 

    }
}
