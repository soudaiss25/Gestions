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
using Mysqlx.Session;

namespace Gestions.Views
{
    public partial class fmAppartement : Form
    {
        public fmAppartement()
        {
            InitializeComponent();
        }
        Dbgestionscontext db = new Dbgestionscontext();

        private void ResetForm()
        {
            txtAdresse.Text = string.Empty;
            txtSurface.Text = string.Empty;
            txtNombrePlace.Text = string.Empty;
            txtCapacite.Text = string.Empty;
            dgAppartement.DataSource = db.Appartements.Select(a => new { a.IdAppartement, a.AdresseAppartement, a.Surface, a.NombrePiece, a.IdProprietaire, a.Disponible}).ToList();
            ChargerProprietaires();
            txtAdresse.Focus();
        }

        private void ChargerProprietaires()
        {
            try
            {
                var proprietaires = db.Proprietaires
                    .Select(a => new
                    {
                        a.IdPersonne,
                        Nom = a.Nom// Texte affiché dans le ComboBox
                    })
                    .ToList();

                CbProprietaire.DataSource = proprietaires;
                CbProprietaire.DisplayMember = "NomComplet"; // Texte affiché
                CbProprietaire.ValueMember = "IdPersonne";  // Valeur sélectionnée
                CbProprietaire.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void fmAppartement_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation des champs obligatoires
                if (string.IsNullOrWhiteSpace(txtAdresse.Text) || CbProprietaire.SelectedIndex == null)
                {
                    MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Appartement a = new Appartement();
                a.AdresseAppartement = txtAdresse.Text.Trim();
                db.Appartements.Add(a);
                db.SaveChanges();
                MessageBox.Show("Appartements ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CbProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtAdresse.Text = dgAppartement.CurrentRow.Cells[1].Value.ToString();
            txtSurface.Text = dgAppartement.CurrentRow.Cells[2].Value.ToString();
            txtNombrePlace.Text = dgAppartement.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            if (dgAppartement.CurrentRow != null)
            {
                int idAppartement = Convert.ToInt32(dgAppartement.CurrentRow.Cells[0].Value);
                string adresseAppartement = dgAppartement.CurrentRow.Cells[1].Value.ToString();

                fmContratLocation contratForm = new fmContratLocation(idAppart: idAppartement, adresse: adresseAppartement);
                contratForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un appartement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChoisir_Click_1(object sender, EventArgs e)
        {
            txtAdresse.Text = dgAppartement.CurrentRow.Cells[1].Value.ToString();
            txtSurface.Text = dgAppartement.CurrentRow.Cells[2].Value.ToString();
            txtNombrePlace.Text = dgAppartement.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
