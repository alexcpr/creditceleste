using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Credit
    {
        // On créer un objet dans le but que celui ci soit réutilisé, par exemple pour un héritage (un crédit, une LOA, une LOA-LLD, LOA-OA, crédit bail, etc.)
        // Pourra être utilisé par un écran, une tablette, une application web (aspx), Un service web, API

        // VARIABLE PRIVEE

        private double monMontant;
        private double monDuree;
        private double monTaux;
        private double monMensualite;
        private string maVoiture;

        public Credit() // constructeur vide
        {
        }

        public Credit(double montant, double duree, double taux) // constructeur avec paramètres
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
        }

        public Credit(double montant, double duree, double taux, string voiture)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            maVoiture = voiture;
        }

        public Credit(double montant, double duree, double taux, double mensualite)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monMensualite = mensualite;
        }

        public double getMontant()
        {
            return monMontant;
        }

        public double getDuree()
        {
            return monDuree;
        }

        public double getTaux()
        {
            return monTaux;
        }

        public double getMensualite()
        {
            // Formule : m = v0 * i / (1 - (1 + i)^-n
            double monTauxAnnuel;

            monTauxAnnuel = monTaux / 1200; // Taux mensuel en taux annuel (taux en %)

            monMensualite = Math.Round((monMontant * monTauxAnnuel) / (1 - Math.Pow(1 + monTauxAnnuel, -monDuree)), 2);

            return monMensualite;
        }

        public string afficheLeCredit()
        {
            string message;

            message = "Voiture concernée: " + maVoiture + Environment.NewLine;
            message += " | Prix: " + monMontant + "€" + Environment.NewLine;
            message += " | Durée: " + monDuree + "mois" + Environment.NewLine;
            message += " | Taux: " + monTaux + "%" + Environment.NewLine;
            message += " | Mensualité: " + monMensualite + "€";

            return message;
        }
    }
}
