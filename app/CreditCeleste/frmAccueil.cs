using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// -- Pour la connexion a la bdd
using System.Data.SqlClient;

namespace CreditCeleste
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            // -- On veut aller vers la fenêtre frmIntroduction -- 

            // -> Création d'un objet frmIntroduction de la classe frmIntroduction
            frmIntroduction fenIntroduction = new frmIntroduction();
            // -> Appel de la méthode Show() pour afficher la fênetre Introduction
            fenIntroduction.Show();
            // -> Ferme la fenêtre active et détruit l'application
            //this.Close();
            // ->  Hide pour juste cacher la fenêtre
            //this.Hide();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {

            // -- Identifier mon application
            lblMonApplication.Text = Globals.monApplication;

            // -- Identifier la region
            //lblNomRegion.Text = Concession.maRegion;

            //Globals.uneConcession = new Concession("Garage AlexLeoEthan", "66 rue des Voyages");

            //// -- Rajout du vendeur
            //Vendeur unVendeur = new Vendeur("PERREAUT", "Leo", "M.");

            //// -- Deuxieme vendeur
            //Vendeur un2Vendeur = new Vendeur("CIPOR", "Alexandre", "M.");

            //// -- Troisieme vendeur
            //Vendeur un3Vendeur = new Vendeur("OKEEF", "Ethan", "M.");

            //// -- Stockage dans la collection
            //Globals.uneConcession.rajoutVendeur(unVendeur);
            //Globals.uneConcession.rajoutVendeur(un2Vendeur);
            //Globals.uneConcession.rajoutVendeur(un3Vendeur);

        }

    }              
}
