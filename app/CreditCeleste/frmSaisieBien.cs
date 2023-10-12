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
    public partial class frmSaisieBien : Form
    {
        private string provientDe;

        public frmSaisieBien()
        {
            InitializeComponent();
        }

        public frmSaisieBien(string source) : this()
        {
            this.provientDe = source;
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            if (provientDe == "frmCalculCredit")
            {
                // Ouvre le formulaire de calcul du crédit
                frmCalculCredit fenCalculCredit = new frmCalculCredit();
                fenCalculCredit.Show();
                this.Close();
            }
            else
            {
                // Ouvre le formulaire d'introduction
                frmIntroduction fenIntroduction = new frmIntroduction();
                fenIntroduction.Show();
                this.Close();
            }
        }

        // Initialisation de la ComboBox et des boutons Suivant et Précédent
        private void frmSaisieBien_Load(object sender, EventArgs e)
        {
            try
            {
                // Identifie l'application
                lblMonApplication.Text = Globals.monApplication;

                // Initialise la ComboBox
                SQLUtil.RemplirComboBoxVoitures(cboVoituresDisp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            // Sauvegarde les informations vers l'objet Voiture
            if (cboVoituresDisp.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une voiture !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Globals.uneVoiture == null)
                {
                    // Crée une nouvelle instance de Voiture
                    Globals.uneVoiture = new Voiture(int.Parse(lstDetailsVoiture.Items[0].ToString().Split(' ')[2].Trim()));
                    MessageBox.Show("Voiture choisie enregistrée !", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modifie l'instance existante de Voiture
                    Globals.uneVoiture.setVoiture(int.Parse(lstDetailsVoiture.Items[0].ToString().Split(' ')[2].Trim()));
                    MessageBox.Show("Voiture choisie modifiée !", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cboVoituresDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Efface les éléments précédents de la ListBox
                lstDetailsVoiture.Items.Clear();

                // Obtient les détails du véhicule sélectionné
                int indexPremierEspace = cboVoituresDisp.SelectedItem.ToString().IndexOf(' ');
                string texteApresPremierEspace = cboVoituresDisp.SelectedItem.ToString().Substring(indexPremierEspace + 1);
                List<string> details = SQLUtil.GetVehiculeDetails(texteApresPremierEspace.Trim());

                // Remplit la ListBox avec les détails du véhicule
                lstDetailsVoiture.Items.AddRange(details.ToArray());
                lblPrixVoiture.Text = details[details.Count - 1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des détails du véhicule : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
