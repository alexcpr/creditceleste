using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Concession
    {
        private string monNomConsession;        // -- Attributs de l'objet
        private string monAdresseConsession;
        

        // -- Traitement de la region
        public static string maRegion = "Alsace";       // -- Attributs de la classe

        // -- Collection des vendeurs
        private List<Vendeur> lesVendeurs = new List<Vendeur>();    //--> Créer la classe vendeur !
        //Créer des vendeurs dans la liste des vendeurs qui seront soit les membres du groupe soit inventé
        
        public Concession()
        {
            monNomConsession = "CIPOR";
            MonAdresseConsession = "4 rue Schoch, 67000 Strasbourg";
        }

        public Concession(string nomConsession, string adresseConsession)
        {
            monNomConsession = nomConsession;
            MonAdresseConsession = adresseConsession;
        }

        // -- Mutateurs // -- Propriétés
        public string MonAdresseConsession { get => monAdresseConsession; set => monAdresseConsession = value; }

        public void rajoutVendeur(Vendeur unVendeur)
        {
            lesVendeurs.Add(unVendeur);
        }

        public List<Vendeur> getListeVendeur()
        {
            return lesVendeurs;
        }
    }
}
