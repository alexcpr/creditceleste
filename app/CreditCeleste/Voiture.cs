using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {
        private int monIdVehicule; 

        public Voiture() { }   // -- Constructeur vide

        public Voiture(int idVehicule)
        {
            monIdVehicule = idVehicule;
        }

        public void setVoiture(int idVehicule)
        {
            monIdVehicule = idVehicule;
        }

        public int getIdVoiture()
        {
            return monIdVehicule;
        }
    }
}
