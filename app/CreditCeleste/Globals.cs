using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// -- Pour la connexion à la bdd
using System.Data.SqlClient;
using System.Data;

namespace CreditCeleste
{
    static class Globals
    {
        // -- Pas besoin de new en static, les données existent à la déclaration

        // -- Création d'un concession
        public static Concession uneConcession;

        // -- Pour identifier mon application
        public static string monApplication = "Crédits: Alexandre CIPOR";

        // -- Pour gérer les voitures communes aux différents écrans 
        public static Voiture uneVoiture;       // -- > C'est la voiture courrante !

        // -- Pour gérer les Clients
        public static ClientVoit unClient;      // --> C'est le client courrant !

        // -- Pour la collection des crédits
        public static List<Credit> lesCredits = new List<Credit>();

        // -- String connexion
        public static string strConnexion = "Data Source=192.168.1.86;Initial Catalog=creditceleste;User ID=creditceleste;Password=jQ8!H2n5hMB&;";
        //public static string strConnexion = "Data Source=10.129.189.112;Initial Catalog=creditceleste;User ID=creditceleste;Password=jQ8!H2n5hMB&;";
        //public static string strConnexion = "Data Source=10.129.189.112;Initial Catalog=creditceleste;Integrated Security=True;"; // connexion via l'AD
    }
}
