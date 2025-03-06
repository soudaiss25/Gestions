using System;
using System.Linq;
using System.Windows.Forms;
using Gestions.Models; // Assurez-vous que c'est l'espace de noms de vos modèles
using System.Data.Entity; // Assurez-vous d'avoir Entity Framework

namespace Gestions.Views
{
    public partial class fmContratLocation : Form
    {
        Dbgestionscontext db = new Dbgestionscontext();

        private int? idAppartement;
        private int? idLocataire;// Remplace MyDbContext par ton contexte réel

        public fmContratLocation()
        {
            InitializeComponent();
           
        }
        public fmContratLocation(int? idAppart = null, string adresse = null, int? idLoc = null, string nom = null)
        {
            InitializeComponent();

            if (idAppart.HasValue)
            {
                idAppartement = idAppart;
                txtAppartement.Text = adresse;
            }

            if (idLoc.HasValue)
            {
                idLocataire = idLoc;
                txtLocataire.Text = nom;
            }
        }

        // Méthode pour enregistrer un contrat
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                var contrat = new ContratLocation
                {
                    Numero = tfNumero.Text,
                    DateDebut = dateTimePicker1.Value,
                    DateFin = dateTimePicker2.Value,
                    DateCreation = DateTime.Now,
               
                };

                db.contratLocation.Add(contrat);
                db.SaveChanges();
                MessageBox.Show("Contrat enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode pour valider un contrat
        private void btnValider_Click(object sender, EventArgs e)
        {
            //try
            //{
              
            //    var contrat = db.contratLocation.Find(idContrat);
            //    if (contrat != null)
            //    {
            //        contrat.DateDebut = dateTimePicker1.Value; // Mettre à jour si nécessaire
            //        contrat.DateFin = dateTimePicker2.Value;
            //        db.SaveChanges();
            //        MessageBox.Show("Contrat validé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadContrats();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Contrat introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erreur lors de la validation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        // Méthode pour révoquer un contrat (supprimer)
        private void btnRevoquer_Click(object sender, EventArgs e)
        {
            
        }

       
        private void fmContratLocation_Load(object sender, EventArgs e)
        {
            
        }

        // Charger les ComboBox avec les appartements et locataires
        
        private void LocataireChoisir_Click(object sender, EventArgs e)
        {

        }
    }
}
