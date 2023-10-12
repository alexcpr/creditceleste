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
    public partial class frmAchat : Form
    {
        public frmAchat()
        {
            InitializeComponent();
        }

        private void frmAchat_Load(object sender, EventArgs e)
        {
            try
            {
                // Identifier mon application
                lblMonApplication.Text = Globals.monApplication;

                // Obtenir le véhicule choisi et ses détails
                txtNouvVhc.Text = SQLUtil.GetVehiculeChoisi(Globals.uneVoiture.getIdVoiture());

                // Obtenir les détails du véhicule sélectionné
                int indexPremierEspace = txtNouvVhc.Text.IndexOf(' ');
                string texteApresPremierEspace = txtNouvVhc.Text.Substring(indexPremierEspace + 1);
                string vehiculeChoisi = texteApresPremierEspace.Trim();
                List<string> details = SQLUtil.GetVehiculeDetails(vehiculeChoisi);

                // Remplir la ListBox avec les détails du véhicule
                lstDetailsVoiture.Items.AddRange(details.ToArray());
                lblPrixVoiture.Text = details[details.Count - 1];

                // Renseigner les informations du véhicule actuel du client
                txtAncVhcPlaque.Text = Globals.unClient.GetMaPlaqueImmatriculation();
                txtAncVhcKilometrage.Text = Globals.unClient.GetMonKilometrage();

                // Cocher le RadioButton correspondant à l'âge du véhicule
                foreach (RadioButton rdb in gpbAgeAncVhc.Controls)
                {
                    if (rdb.Text == Globals.unClient.GetMonAgeVehicule())
                    {
                        rdb.Checked = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool verifSaisieDuree()
        {
            if (string.IsNullOrEmpty(cboDureeMois.Text))
            {
                MessageBox.Show("Veuillez indiquer une durée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDureeMois.Focus();
                return false;
            }
            return true;
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            string typePaiement = "";
            RadioButton selectedRadio = null;

            // Parcourir les RadioButtons pour trouver celui qui est coché
            foreach (RadioButton rdb in gpbMethodePaiement.Controls)
            {
                if (rdb.Checked)
                {
                    selectedRadio = rdb;
                    break;
                }
            }

            if (selectedRadio != null)
            {
                string methodePaiement = selectedRadio.Text;

                string prixTexte = lblPrixVoiture.Text;
                string prixNumeriqueTexte = prixTexte.Substring(prixTexte.IndexOf(':') + 2, prixTexte.Length - prixTexte.IndexOf(':') - 5);
                double prixNumerique = double.Parse(prixNumeriqueTexte);

                string civilite = "";

                // Déterminer la civilité du client
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
                }

                string merciAchat = "";
                merciAchat += "Merci " + civilite + " " + Globals.unClient.getNomClient() + " " + Globals.unClient.getPrenomClient() + " pour votre achat!" + Environment.NewLine;

                if (btnAcheter.Text == "Payer ma 1ère mensualité")
                {
                    typePaiement = "CRED";

                    // Calculer la mensualité
                    if (!verifSaisieDuree())
                    {
                        return;
                    }

                    double dureeMois = Convert.ToDouble(cboDureeMois.Text);
                    Credit unCredit = new Credit(prixNumerique, dureeMois, 10); // Taux annuel de 10% fixe

                    prixNumerique = unCredit.getMensualite();

                    merciAchat += "Votre 1ère mensualité s'élève à : " + prixNumerique.ToString() + "€";
                }
                else if (btnAcheter.Text == "Payer")
                {
                    typePaiement = "CASH";
                    merciAchat += "Votre achat s'élève à : " + prixNumerique.ToString() + "€";
                }

                merciAchat += Environment.NewLine;
                merciAchat += "Nous sommes heureux que notre vendeur " + Globals.unClient.getVendeurClient() + " ait pu vous aider lors de vos choix." + Environment.NewLine;
                merciAchat += "Vous avez choisi le moyen de paiement suivant : " + methodePaiement;

                string rdbName = "";
                foreach (RadioButton rdb in gpbAgeAncVhc.Controls)
                {
                    if (rdb.Text == Globals.unClient.GetMonAgeVehicule())
                    {
                        rdbName = rdb.Name;
                        break;
                    }
                }

                int kilometrage;

                // Vérifier si le kilométrage est un entier valide
                if (int.TryParse(Globals.unClient.GetMonKilometrage(), out kilometrage))
                {
                    try
                    {
                        // Insérer l'achat dans la base de données
                        SQLUtil.InsererAchat(typePaiement, Globals.unClient.getCidtClient(), Globals.unClient.getNomClient(), Globals.unClient.getPrenomClient(), Globals.uneVoiture.getIdVoiture(), prixNumerique, Globals.unClient.GetMaPlaqueImmatriculation(), kilometrage, rdbName);
                        MessageBox.Show(merciAchat, "Merci!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'insertion de l'achat : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Le kilométrage n'est pas un entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCredit.Checked)
            {
                btnAcheter.Text = "Payer ma 1ère mensualité";
                cboDureeMois.Enabled = true;
            }
            else
            {
                btnAcheter.Text = "Payer";
                cboDureeMois.Enabled = false;
            }
        }

        private void frmAchat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                frmIntroduction frmIntro = new frmIntroduction();
                frmIntro.Show(); // Affiche la fenêtre frmIntroduction
            }
        }
    }
}
