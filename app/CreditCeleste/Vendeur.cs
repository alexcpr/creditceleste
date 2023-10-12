using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Vendeur
    {
        private string nomVendeur;
        private string prenomVendeur;
        private string identVendeur;

        public Vendeur()
        { }

        public Vendeur(string unNom, string unPrenom, string unIdent)
        {
            nomVendeur = unNom;
            prenomVendeur = unPrenom;
            identVendeur = unIdent;
        }

        public string afficheLeVendeur()
        {
            return identVendeur + " " + nomVendeur + " " + prenomVendeur;
        }


    }
}
