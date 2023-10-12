using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CreditCeleste
{
    static class SQLUtil
    {
        // -- Connexion vers la BDD --
        public static SqlConnection connexionBdd()
        {
            try
            {
                SqlConnection oConnexion = new SqlConnection(Globals.strConnexion);
                oConnexion.Open();
                return oConnexion;
                
            }
            catch (Exception ex)
            {
                // Afficher un message box pour informer que la connexion a échoué et pourquoi
                string message = "La connexion à la base de données a échoué : " + ex.Message;
                MessageBox.Show(message);
                return null;
            }
        }

        public static void RemplirComboBoxVoitures(ComboBox cboVoituresDisp)
        {
            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL
                string requete = "SELECT V.id, V.modele, V.marque, V.plaqueImma, V.puissance, B.libelle AS boite, T.libelle AS type, E.libelle AS essence, V.annee, V.kilometrage, V.couleur, Et.libelle AS etat, V.prix FROM VEHICULES V INNER JOIN BOITES B ON V.codeBoite = B.codeBoite INNER JOIN TYPES T ON V.codeType = T.codeType LEFT JOIN ESSENCES E ON V.codeEssence = E.codeEssence INNER JOIN ETATS Et ON V.codeEtat = Et.codeEtat";

                // Exécuter la requête SQL et récupérer les résultats
                SqlCommand commande = new SqlCommand(requete, connexion);
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir le ComboBox avec les résultats de la requête
                while (lecteur.Read())
                {
                    string voiture = lecteur["marque"].ToString() + " " + lecteur["modele"].ToString();
                    cboVoituresDisp.Items.Add(voiture);
                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }
        }


        public static List<string> GetVehiculeDetails(string modele)
        {
            List<string> details = new List<string>();

            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL avec une clause WHERE en fonction de l'élément sélectionné
                string requete = "SELECT V.id, V.modele, V.marque, V.plaqueImma, V.puissance, B.libelle AS boite, T.libelle AS type, E.libelle AS essence, V.annee, V.kilometrage, V.couleur, Et.libelle AS etat, V.prix FROM VEHICULES V INNER JOIN BOITES B ON V.codeBoite = B.codeBoite INNER JOIN TYPES T ON V.codeType = T.codeType LEFT JOIN ESSENCES E ON V.codeEssence = E.codeEssence INNER JOIN ETATS Et ON V.codeEtat = Et.codeEtat WHERE modele = @modele";
                SqlCommand commande = new SqlCommand(requete, connexion);
                commande.Parameters.AddWithValue("@modele", modele);

                // Exécuter la requête SQL et récupérer les résultats
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir la liste avec les résultats de la requête
                while (lecteur.Read())
                {
                    int id = lecteur.GetInt32(0);
                    string idVoiture = "ID : " + id.ToString();
                    details.Add(idVoiture);

                    string modeleVoiture = "Modèle : " + lecteur.GetString(1);
                    details.Add(modeleVoiture);

                    string marque = "Marque : " + lecteur.GetString(2);
                    details.Add(marque);

                    string plaqueImmatriculation = "Plaque d'immatriculation : " + lecteur.GetString(3);
                    details.Add(plaqueImmatriculation);

                    string puissance = "Puissance : " + lecteur.GetInt32(4).ToString();
                    details.Add(puissance);

                    string boite = "Boîte : " + lecteur.GetString(5);
                    details.Add(boite);

                    string type = "Type : " + lecteur.GetString(6);
                    details.Add(type);

                    string essence = "Essence : " + (lecteur.IsDBNull(7) ? "N/A" : lecteur.GetString(7));
                    details.Add(essence);

                    string annee = "Année : " + lecteur.GetInt32(8).ToString();
                    details.Add(annee);

                    string kilometrage = "Kilométrage : " + lecteur.GetInt32(9).ToString() + "km";
                    details.Add(kilometrage);

                    string couleur = "Couleur : " + lecteur.GetString(10);
                    details.Add(couleur);

                    string etat = "État : " + lecteur.GetString(11);
                    details.Add(etat);

                    string prix = "Prix : " + lecteur.GetDecimal(12).ToString() + " €";
                    details.Add(prix);

                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }

            return details;
        }

        public static string GetVehiculeChoisi(int id)
        {
            string modeleVoiture = "";
            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL avec une clause WHERE en fonction de l'élément sélectionné
                string requete = "SELECT * FROM VEHICULES WHERE id = @id";
                SqlCommand commande = new SqlCommand(requete, connexion);
                commande.Parameters.AddWithValue("@id", id);

                // Exécuter la requête SQL et récupérer les résultats
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir la liste avec les résultats de la requête
                while (lecteur.Read())
                {
                    modeleVoiture = lecteur.GetString(2) + " " + lecteur.GetString(1);
                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }

            return modeleVoiture;
        }

        public static double GetPrixVehiculeChoisi(int id)
        {
            double prix = new double();
            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL avec une clause WHERE en fonction de l'élément sélectionné
                string requete = "SELECT prix FROM VEHICULES WHERE id = @id";
                SqlCommand commande = new SqlCommand(requete, connexion);
                commande.Parameters.AddWithValue("@id", id);

                // Exécuter la requête SQL et récupérer les résultats
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir la liste avec les résultats de la requête
                while (lecteur.Read())
                {
                    prix = Convert.ToDouble(lecteur["prix"]);
                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }

            return prix;
        }


        public static void RemplirComboBoxCivilite(ComboBox cboIdt)
        {
            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL
                string requete = "SELECT libelle FROM civilites";

                // Exécuter la requête SQL et récupérer les résultats
                SqlCommand commande = new SqlCommand(requete, connexion);
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir le ComboBox avec les résultats de la requête
                while (lecteur.Read())
                {
                    cboIdt.Items.Add(lecteur["libelle"].ToString());
                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }
        }

        public static void RemplirComboBoxVendeur(ComboBox cboVendeur)
        {
            // Obtenir la connexion à la base de données
            using (SqlConnection connexion = connexionBdd())
            {
                // Préparer la requête SQL
                string requete = "SELECT C.libelle, V.nom, V.prenom FROM VENDEURS V JOIN CIVILITES C ON V.codeCivilite = C.codeCivilite;";

                // Exécuter la requête SQL et récupérer les résultats
                SqlCommand commande = new SqlCommand(requete, connexion);
                SqlDataReader lecteur = commande.ExecuteReader();

                // Remplir le ComboBox avec les résultats de la requête
                while (lecteur.Read())
                {
                    cboVendeur.Items.Add(lecteur["libelle"].ToString() + " " + lecteur["nom"].ToString() + " " + lecteur["prenom"].ToString());
                }

                // Fermer le lecteur et la connexion
                lecteur.Close();
                connexion.Close();
            }
        }

        public static void InsererAchat(string typePaiement, string civiliteUser, string nomUser, string prenomUser, int idVehicule, double montant, string plaqueImmaAncienVehicule, int kilometrageAncienVehicule, string ageAncienVehicule)
        {
            int idUtilisateur = ObtenirIdUtilisateur(civiliteUser, nomUser, prenomUser);
            DateTime dateAchat = DateTime.Today;

            using (SqlConnection connection = connexionBdd())
            {
                string query = "INSERT INTO ACHATS (typePaiement, idUtilisateur, idVehicule, dateAchat, montant, plaqueImmaAncienVehicule, kilometrageAncienVehicule, ageAncienVehicule) VALUES (@typePaiement, @idUtilisateur, @idVehicule, @dateAchat, @montant, @plaqueImmaAncienVehicule, @kilometrageAncienVehicule, @ageAncienVehicule)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@typePaiement", typePaiement);
                    command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                    command.Parameters.AddWithValue("@idVehicule", idVehicule);
                    command.Parameters.AddWithValue("@dateAchat", dateAchat);
                    command.Parameters.AddWithValue("@montant", montant);
                    command.Parameters.AddWithValue("@plaqueImmaAncienVehicule", plaqueImmaAncienVehicule);
                    command.Parameters.AddWithValue("@kilometrageAncienVehicule", kilometrageAncienVehicule);
                    command.Parameters.AddWithValue("@ageAncienVehicule", ageAncienVehicule);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private static int ObtenirIdUtilisateur(string civilite, string nom, string prenom)
        {
            int idUtilisateur = 0;

            using (SqlConnection connection = connexionBdd())
            {
                string query = "SELECT id FROM UTILISATEUR WHERE codeCivilite = @civilite AND nom = @nom AND prenom = @prenom";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@civilite", civilite);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idUtilisateur = reader.GetInt32(0);
                    }
                    else
                    {
                        reader.Close();

                        query = "INSERT INTO UTILISATEUR (codeCivilite, nom, prenom) VALUES (@civilite, @nom, @prenom); SELECT SCOPE_IDENTITY();";

                        using (SqlCommand insertCommand = new SqlCommand(query, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@civilite", civilite);
                            insertCommand.Parameters.AddWithValue("@nom", nom);
                            insertCommand.Parameters.AddWithValue("@prenom", prenom);

                            idUtilisateur = Convert.ToInt32(insertCommand.ExecuteScalar());
                        }
                    }
                }
                connection.Close();
            }

            return idUtilisateur;
        }


    }
}
