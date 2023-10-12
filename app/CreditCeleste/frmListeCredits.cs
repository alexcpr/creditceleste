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
    public partial class frmListeCredits : Form
    {
        public frmListeCredits()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            // Crée une instance de la fenêtre frmCalculCredit
            frmCalculCredit fenCalculCredit = new frmCalculCredit();
            fenCalculCredit.Show();

            // Ferme la fenêtre actuelle (frmListeCredits)
            this.Close();
        }

        private void frmListeCredits_Load(object sender, EventArgs e)
        {
            // Identifie l'application dans le label lblMonApplication
            lblMonApplication.Text = Globals.monApplication;

            // Ajoute les crédits de la collection lesCredits à la ListBox lstCredits
            foreach (Credit xCredit in Globals.lesCredits)
            {
                lstCredits.Items.Add(xCredit.afficheLeCredit());
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // Efface tous les éléments de la ListBox lstCredits
            lstCredits.Items.Clear();
            // Le Clear supprime les éléments, mais pas l'objet lui-même
        }

        private void btnSupprimerHistorique_Click(object sender, EventArgs e)
        {
            // Efface tous les crédits de la collection lesCredits
            Globals.lesCredits.Clear();

            // Efface tous les éléments de la ListBox lstCredits
            lstCredits.Items.Clear();
        }
    }
}
