using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmIntroduction : Form
    {
        public frmIntroduction()
        {
            InitializeComponent();
        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            try
            {
                // -- Identifier mon application
                lblMonApplication.Text = Globals.monApplication;

                // Remplir les ComboBox avec les données de la base de données
                SQLUtil.RemplirComboBoxCivilite(cboIdt);
                SQLUtil.RemplirComboBoxVendeur(cboVendeur);

                // Vérifier s'il y a une voiture sélectionnée
                if (Globals.uneVoiture != null)
                {
                    // Afficher le nom du véhicule sélectionné
                    txtNouvVhc.Text = SQLUtil.GetVehiculeChoisi(Globals.uneVoiture.getIdVoiture());
                }

                // Vérifier s'il y a un client sélectionné
                if (Globals.unClient != null)
                {
                    string civilite = "";

                    // Convertir le code de civilité en texte lisible
                    switch (Globals.unClient.getCidtClient())
                    {
                        case "M":
                            civilite = "M.";
                            break;
                        case "MAD":
                            civilite = "Mme.";
                            break;
                        case "MLLE":
                            civilite = "Mademoiselle";
                            break;
                        default:
                            break;
                    }

                    // Afficher les informations du client sélectionné
                    cboIdt.Text = civilite;
                    txtNom.Text = Globals.unClient.getNomClient();
                    txtPrenom.Text = Globals.unClient.getPrenomClient();
                    cboVendeur.Text = Globals.unClient.getVendeurClient();
                    txtAncVhcPlaque.Text = Globals.unClient.GetMaPlaqueImmatriculation();
                    txtAncVhcKilometrage.Text = Globals.unClient.GetMonKilometrage();

                    // Cocher le bouton radio correspondant à l'âge du véhicule
                    foreach (RadioButton rdb in gpbAgeAncVhc.Controls)
                    {
                        if (rdb.Text == Globals.unClient.GetMonAgeVehicule())
                        {
                            rdb.Checked = true;
                        }
                    }
                }

                // -- Il faut également interdire d'instancier un Client (client sans voiture)
                // -- On ne veut que les clientVoit
                // -- Pour cela, on rajoute le mot clé "Abstract" dans la classe libClientCC !
                // -- Un classe abstraite ne peut plus créée d'objet directement
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVoiture_Click(object sender, EventArgs e)
        {
            // Rediriger vers la fenêtre de saisie des biens (voitures)
            frmSaisieBien frmSaisieBien = new frmSaisieBien();
            frmSaisieBien.Show();
            this.Close();
        }

        private bool verifSaisie()
        {
            // Vérifier si toutes les saisies obligatoires sont remplies

            if (string.IsNullOrEmpty(cboIdt.Text))
            {
                MessageBox.Show("Veuillez saisir votre civilité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboIdt.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Veuillez saisir votre nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez saisir votre prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenom.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboVendeur.Text))
            {
                MessageBox.Show("Veuillez choisir un vendeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboVendeur.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAncVhcPlaque.Text))
            {
                MessageBox.Show("Veuillez indiquer la plaque d'immatriculation de votre ancien véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAncVhcPlaque.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAncVhcKilometrage.Text))
            {
                MessageBox.Show("Veuillez indiquer le kilométrage de votre ancien véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAncVhcKilometrage.Focus();
                return false;
            }

            if (Globals.uneVoiture == null)
            {
                MessageBox.Show("Veuillez choisir une voiture pour passer à l'achat.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCalculCredit_Click(object sender, EventArgs e)
        {
            if (Globals.uneVoiture == null)
            {
                MessageBox.Show("Veuillez choisir une voiture pour faire une simulation de crédit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Rediriger vers la fenêtre de calcul du crédit
            frmCalculCredit fenCalculCredit = new frmCalculCredit();
            fenCalculCredit.Show();
            this.Close();
        }

        private void frmIntroduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            // -- sauvegarder les données dans l'objet au cas où l'utilisateur a oublié de cliquer sur enregistrer
            RadioButton radio;

            int i = 0;
            radio = (RadioButton)gpbAgeAncVhc.Controls[i];

            while ((radio.Checked == false) && (i < gpbAgeAncVhc.Controls.Count - 1))
            {
                i++;
                radio = (RadioButton)gpbAgeAncVhc.Controls[i];
            }

            string age = radio.Text;

            string codeCivilite = "";

            switch (cboIdt.Text)
            {
                case "M.":
                    codeCivilite = "M";
                    break;
                case "Mme.":
                    codeCivilite = "MAD";
                    break;
                case "Mademoiselle":
                    codeCivilite = "MLLE";
                    break;
                default:
                    break;
            }

            // Créer un nouvel objet ClientVoit avec les données saisies
            if (Globals.unClient == null)
            {
                Globals.unClient = new ClientVoit(codeCivilite, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtAncVhcPlaque.Text, txtAncVhcKilometrage.Text, age);
            }
            // Si le client existe déjà, mettre à jour ses données
            else
            {
                Globals.unClient.setClient(codeCivilite, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtAncVhcPlaque.Text, txtAncVhcKilometrage.Text, age);
            }
        }

        private bool enregistrerDonnees()
        {
            // Afficher les données saisies dans une boîte de dialogue récapitulative
            RadioButton radio;

            int i = 0;
            radio = (RadioButton)gpbAgeAncVhc.Controls[i];


            while ((radio.Checked == false) && (i < gpbAgeAncVhc.Controls.Count - 1))
            {
                i++;
                radio = (RadioButton)gpbAgeAncVhc.Controls[i];
            }

            string age = radio.Text;

            string affichage = "";

            affichage += "--- Vos coordonnées ---";
            affichage += Environment.NewLine;
            affichage += "Vous êtes: " + cboIdt.Text + " " + txtNom.Text + " " + txtPrenom.Text;
            affichage += Environment.NewLine;
            affichage += "Vendeur: " + cboVendeur.Text;
            affichage += Environment.NewLine;
            affichage += "--- Votre ancien véhicule ---";
            affichage += Environment.NewLine;
            affichage += "Plaque d'immatriculation: " + txtAncVhcPlaque.Text;
            affichage += Environment.NewLine;
            affichage += "État: " + age;
            affichage += Environment.NewLine;
            affichage += "Kilométrage: " + txtAncVhcKilometrage.Text + "km";
            affichage += Environment.NewLine;
            affichage += "--- Votre nouvelle véhicule ---";
            affichage += Environment.NewLine;
            affichage += "Nouveau véhicule: " + txtNouvVhc.Text;

            DialogResult resultat;
            resultat = MessageBox.Show(affichage, "Récapitulatif", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultat == DialogResult.OK)
            {
                // L'utilisateur a cliqué sur le bouton "OK"
                // On enregistre les données dans l'objet

                string codeCivilite = "";

                switch (cboIdt.Text)
                {
                    case "M.":
                        codeCivilite = "M";
                        break;
                    case "Mme.":
                        codeCivilite = "MAD";
                        break;
                    case "Mademoiselle":
                        codeCivilite = "MLLE";
                        break;
                    default:
                        break;
                }

                // Créer un nouvel objet ClientVoit avec les données saisies
                if (Globals.unClient == null)
                {
                    Globals.unClient = new ClientVoit(codeCivilite, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtAncVhcPlaque.Text, txtAncVhcKilometrage.Text, age);
                }
                // Si le client existe déjà, mettre à jour ses données
                else
                {
                    Globals.unClient.setClient(codeCivilite, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtAncVhcPlaque.Text, txtAncVhcKilometrage.Text, age);
                }
                MessageBox.Show("Données enregistrées !", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (resultat == DialogResult.Cancel)
            {
                // L'utilisateur a cliqué sur le bouton "Annuler"
                // On n'enregistre pas.
                MessageBox.Show("Enregistrement annulé !", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return false;
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            if (!verifSaisie())
            {
                return;
            }

            if (!enregistrerDonnees())
            {
                return;
            }
            // Rediriger vers la fenêtre d'achat
            frmAchat fenAchat = new frmAchat();
            fenAchat.Show();
            this.Close();
        }
    }
}
