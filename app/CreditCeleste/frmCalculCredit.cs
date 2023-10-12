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
    public partial class frmCalculCredit : Form
    {
        public frmCalculCredit()
        {
            InitializeComponent();
        }

        // Bouton pour choisir une voiture
        private void btnVoiture_Click(object sender, EventArgs e)
        {
            frmSaisieBien frmSaisieBien = new frmSaisieBien("frmCalculCredit");
            frmSaisieBien.Show();
            this.Close();
        }

        // Bouton pour afficher l'introduction
        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            frmIntroduction fenIntroduction = new frmIntroduction();
            fenIntroduction.Show();
            this.Close();
        }

        // Vérifie la saisie de l'utilisateur
        private bool verifSaisie()
        {
            if (string.IsNullOrEmpty(cboDureeMois.Text))
            {
                MessageBox.Show("Veuillez indiquer une durée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDureeMois.Focus();
                return false;
            }
            return true;
        }

        // Bouton pour effectuer le calcul du crédit
        private void btnCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                // Permet de calculer la mensualité
                // L'utilisateur saisit le montant (coût de la voiture) et la durée du prêt

                if (!verifSaisie())
                {
                    return;
                }

                // Crée un nouvel objet crédit en utilisant les valeurs saisies par l'utilisateur
                // et récupère les informations sur le véhicule choisi à partir de la base de données
                Credit unCredit = new Credit(Convert.ToDouble(txtMontantCredit.Text), Convert.ToDouble(cboDureeMois.Text), 10, SQLUtil.GetVehiculeChoisi(Globals.uneVoiture.getIdVoiture()));

                // Affiche la mensualité calculée
                txtMensualite.Text = unCredit.getMensualite().ToString() + "€";

                // Ajoute le crédit à la collection des crédits
                Globals.lesCredits.Add(unCredit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du calcul du crédit : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Bouton pour afficher la liste des crédits
        private void btnListeCredits_Click(object sender, EventArgs e)
        {
            // Ouvre la fenêtre qui présente les crédits pour que l'utilisateur puisse en choisir un
            frmListeCredits fenListeCredits = new frmListeCredits();
            fenListeCredits.Show();
            this.Close();
        }

        // Chargement du formulaire de calcul de crédit
        private void frmCalculCredit_Load(object sender, EventArgs e)
        {
            try
            {
                // Identifie l'application
                lblMonApplication.Text = Globals.monApplication;

                // Récupère le prix du véhicule choisi à partir de la base de données
                txtMontantCredit.Text = SQLUtil.GetPrixVehiculeChoisi(Globals.uneVoiture.getIdVoiture()).ToString();

                // Met le focus sur la liste déroulante de la durée du prêt
                cboDureeMois.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
