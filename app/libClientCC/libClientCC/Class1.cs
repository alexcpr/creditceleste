using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    public abstract class Client // -- > abstract empêche de créer un objet Client
    {

        private string cidtClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        public Client()
        {
            cidtClient = "";
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
        }

        public Client(string cidtCli)
        {
            cidtClient = cidtCli;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
        }

        public Client(string nomCli, string prenomCli)
        {
            cidtClient = "";
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = "";
        }

        public Client(string cidtCli, string nomCli, string prenomCli)
        {
            cidtClient = cidtCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = "";
        }

        public void setClient(string cidtCli, string nomCli, string prenomCli)
        {
            cidtClient = cidtCli;
            nomClient = nomCli;
            prenomClient = prenomCli;

        }
        public string getCidtClient()
        {
            return cidtClient;
        }

        public void setCidtClient(string cidtCli)
        {
            cidtClient = cidtCli;
        }

        public string getNomClient()
        {
            return nomClient;
        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        public string getPrenomClient()
        {
            return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public string getAdresseClient()
        {
            return adresseClient;
        }

        public void setAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

    }

}