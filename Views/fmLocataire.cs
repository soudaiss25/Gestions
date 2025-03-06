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

namespace Gestions.Views
{
    public partial class fmLocataire : Form
    {
        public fmLocataire()
        {
            InitializeComponent();
        }
        Dbgestionscontext db = new Dbgestionscontext();
        private void ResetForm()
        {
            tfPrenom.Text = string.Empty;
            tfNom.Text = string.Empty;
            tfEmail.Text = string.Empty;
            tf_Telphone.Text = string.Empty;
            tfCni.Text = string.Empty;
            dgLocataire.DataSource = db.Locataires.Select(a => new { a.IdPersonne, a.Nom, a.Prenom, a.Email, a.Telephonehone, a.CNI }).ToList();
            tfPrenom.Focus();

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
                    string.IsNullOrWhiteSpace(tfCni.Text))
                {
                    MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Locataire l = new Locataire();
                l.Nom = tfNom.Text.Trim();
                l.Prenom = tfPrenom.Text.Trim();
                l.Email = tfEmail.Text.Trim();
                l.Telephonehone = tf_Telphone.Text.Trim();
                l.CNI = tfCni.Text.Trim();
                db.Locataires.Add(l);
                db.SaveChanges();
                MessageBox.Show("Locataire ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fmLocataire_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            tfNom.Text = dgLocataire.CurrentRow.Cells[2].Value.ToString();
            tfPrenom.Text = dgLocataire.CurrentRow.Cells[1].Value.ToString();
            tf_Telphone.Text = dgLocataire.CurrentRow.Cells[3].Value.ToString();
            tfEmail.Text = dgLocataire.CurrentRow.Cells[5].Value.ToString();
            tfCni.Text = dgLocataire.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var l = db.Locataires.Find(id);
            if (l != null)
            {
                l.Nom = tfNom.Text.Trim();
                l.Prenom = tfPrenom.Text.Trim();

                l.Telephonehone = tf_Telphone.Text.Trim();
                l.Email = tfEmail.Text.Trim();
                l.CNI = tfCni.Text.Trim();

                db.SaveChanges();


                MessageBox.Show("Propriétaire modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var l = db.Locataires.Find(id);
            if (l != null)
            {
                db.Locataires.Remove(l);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btn_Contrat_Click(object sender, EventArgs e)
        {
            if (dgLocataire.CurrentRow != null)
            {
                int idLocataire = Convert.ToInt32(dgLocataire.CurrentRow.Cells[0].Value);
                string nomLocataire = dgLocataire.CurrentRow.Cells[1].Value.ToString();

                fmContratLocation contratForm = new fmContratLocation(idLoc: idLocataire, nom: nomLocataire);
                contratForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un locataire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

