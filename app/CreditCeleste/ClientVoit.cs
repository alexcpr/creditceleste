using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class ClientVoit : Client
    {
        private string monVendeur;
        private string maPlaqueImmatriculation;
        private string monKilometrage;
        private string monAgeVehicule;

        public ClientVoit() : base()
        { }

        public ClientVoit(string nomCli, string prenomCli) : base(nomCli, prenomCli)
        { }

        public ClientVoit(string nomCli, string prenomCli, string vendeurCli) : base(nomCli, prenomCli)
        {
            monVendeur = vendeurCli;
        }

        public ClientVoit(string idtCli, string nomCli, string prenomCli, string vendeurCli) : base(idtCli, nomCli, prenomCli)
        {
            monVendeur = vendeurCli;
        }

        public ClientVoit(string idtCli, string nomCli, string prenomCli, string vendeurCli, string plaqueImmat, string kilometrage, string ageVehicule) : base(idtCli, nomCli, prenomCli)
        {
            monVendeur = vendeurCli;
            maPlaqueImmatriculation = plaqueImmat;
            monKilometrage = kilometrage;
            monAgeVehicule = ageVehicule;
        }

        public string getVendeurClient()
        {
            return monVendeur;
        }

        public void setVendeur(string unVendeur)
        {
            monVendeur = unVendeur;
        }

        public string GetMaPlaqueImmatriculation()

        {

            return maPlaqueImmatriculation;

        }

        public string GetMonKilometrage()

        {

            return monKilometrage;

        }

        public string GetMonAgeVehicule()

        {

            return monAgeVehicule;

        }

        public void setClient(string unIdt, string unNom, string unPrenom, string unVendeur)
        {
            setCidtClient(unIdt);
            setNomClient(unNom);
            setPrenomClient(unPrenom);
            monVendeur = unVendeur;
        }

        public void setClient(string unIdt, string unNom, string unPrenom, string vendeurCli, string plaqueImmat, string kilometrage, string ageVehicule)
        {
            setCidtClient(unIdt);
            setNomClient(unNom);
            setPrenomClient(unPrenom);
            monVendeur = vendeurCli;
            maPlaqueImmatriculation = plaqueImmat;
            monKilometrage = kilometrage;
            monAgeVehicule = ageVehicule;
        }

    }
}
