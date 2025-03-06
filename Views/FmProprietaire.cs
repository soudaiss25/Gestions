using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestions.Models;
using Gestions.Views;

namespace Gestions
{
    public partial class FmProprietaire : Form
    {
        public FmProprietaire()
        {
            InitializeComponent();
        }

        Dbgestionscontext db = new Dbgestionscontext();

        public FrmPrintListeProprietaire FrmPrintListeProprietaire { get; private set; }

        private void ResetForm()
        {
            // Réinitialise les champs de texte
            tfPrenom.Text = string.Empty;
            tfNom.Text = string.Empty;
            tf_Telphone.Text = string.Empty;
            tfEmail.Text = string.Empty;
         
            tfNinea.Text = string.Empty;
            tfRccn.Text = string.Empty;
            dgProprietaire.DataSource = db.Proprietaires.Select(a => new { a.IdPersonne, a.Prenom, a.Nom, a.Telephonehone, a.Email, a.CNI, a.Ninea, a.Rccm }).ToList();
            tfPrenom.Focus();


        }


        private void FmProprietaire_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            tfPrenom.Text = dgProprietaire.CurrentRow.Cells[1].Value.ToString();
            tfNom.Text = dgProprietaire.CurrentRow.Cells[2].Value.ToString();
            tf_Telphone.Text = dgProprietaire.CurrentRow.Cells[3].Value.ToString();
            tfEmail.Text = dgProprietaire.CurrentRow.Cells[4].Value.ToString();
          
            tfNinea.Text = dgProprietaire.CurrentRow.Cells[5].Value.ToString();
            tfRccn.Text = dgProprietaire.CurrentRow.Cells[7].Value.ToString();
            btnAjouter.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation des champs obligatoires
                if (string.IsNullOrWhiteSpace(tfPrenom.Text) ||
                    string.IsNullOrWhiteSpace(tfNom.Text) ||
                    string.IsNullOrWhiteSpace(tf_Telphone.Text) ||
                    string.IsNullOrWhiteSpace(tfEmail.Text) ||
                   
                    string.IsNullOrWhiteSpace(tfNinea.Text) ||
                    string.IsNullOrWhiteSpace(tfRccn.Text))
                {
                    MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Création d'un nouvel objet Proprietaire
                Proprietaire p = new Proprietaire();

                p.Prenom = tfPrenom.Text.Trim();
                p.Nom = tfNom.Text.Trim();
                p.Telephonehone = tf_Telphone.Text.Trim();
                p.Email = tfEmail.Text.Trim();
            
                p.Ninea = tfNinea.Text.Trim();
                p.Rccm = tfRccn.Text.Trim();



                db.Proprietaires.Add(p);
                db.SaveChanges();


                MessageBox.Show("Propriétaire ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.Proprietaires.Find(id);
            if (p != null)
            {
                p.Prenom = tfPrenom.Text.Trim();
                p.Nom = tfNom.Text.Trim();
                p.Telephonehone = tf_Telphone.Text.Trim();
                p.Email = tfEmail.Text.Trim();
               
                p.Ninea = tfNinea.Text.Trim();
                p.Rccm = tfRccn.Text.Trim();
                db.SaveChanges();
                MessageBox.Show("Propriétaire modifier avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                btnAjouter.Enabled = true;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.Proprietaires.Find(id);
            if (p != null)
            {
                db.Proprietaires.Remove(p);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void tf_Telphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfCni_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfNinea_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfRccn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgProprietaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            FrmPrintListeProprietaire f = new FrmPrintListeProprietaire();
            f.Show();
            this.Enabled = false;

        }
    }
}
