using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestions.Models;
using Gestions.utils;

namespace Gestions.Views
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrer le form
            this.Size = new Size(800, 500);
        }
        Dbgestionscontext db = new Dbgestionscontext();

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    string motDePasseClair = "Passer@123"; // 🔹 Mot de passe fixe

                    User ut = new User();
                    ut.Email = txtEmail.Text;
                    ut.MotDePasse = CryptApp.GetMd5Hash(md5Hash, motDePasseClair); // 🔹 Hachage avant stockage
                    ut.Nom = txtNom.Text;
                    ut.Prenom = txtPrenom.Text;
                    ut.Telephonehone = txtTelephone.Text;
                    ut.identifiant = txtIdentifiant.Text;
                    ut.status = statutColletcion.SelectedItem.ToString();

                    db.Users.Add(ut);
                    db.SaveChanges();
                    ResetForm();

                    // 🔽 Envoi du mot de passe en clair par email
                    try
                    {
                        GMailer.senMail(ut.Email, "Création de compte",
                            $"Bonjour {ut.Prenom},\n\nVotre compte a bien été créé.\n\n🆔 Identifiant : {ut.identifiant}\n🔑 Mot de passe : {motDePasseClair}\n\nVeuillez changer votre mot de passe après connexion.");

                        MessageBox.Show("Compte créé et email envoyé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Compte créé, mais l'email n'a pas pu être envoyé.\nErreur : {ex.Message}",
                            "Erreur d'envoi d'email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ResetForm()
        {
            txtEmail.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgUtilisateur.DataSource = db.Users.Select(a => new { a.IdPersonne,a.Prenom,a.Nom,a.Telephonehone,a.identifiant,a.Email}).ToList(); ;
            
        }

        private void txtIdentifiant_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_MouseLeave(object sender, EventArgs e)
        {
            txtIdentifiant.Text = GenererIdentifiant(txtNom.Text, txtPrenom.Text);
        }
        private string GenererIdentifiant(string nom, string prenom)
        {
            Random rand = new Random();

            string partNom = nom.Length >= 3 ? nom.Substring(0, 3) : nom;
            string partPrenom = prenom.Length >= 3 ? prenom.Substring(0, 3) : prenom;

            return $"{partNom}{partPrenom}{rand.Next(1000, 9999)}".ToUpper();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée
                if (dgUtilisateur.SelectedRows.Count > 0)
                {
                    // Récupérer l'ID de l'utilisateur sélectionné
                    int id = Convert.ToInt32(dgUtilisateur.SelectedRows[0].Cells[0].Value);

                    // Trouver l'utilisateur dans la base de données
                    User utilisateur = db.Users.FirstOrDefault(u => u.IdPersonne == id);

                    if (utilisateur != null)
                    {
                        // Confirmer la suppression
                        DialogResult dialogResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'utilisateur {utilisateur.Prenom} {utilisateur.Nom} ?",
                            "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                           
                            db.Users.Remove(utilisateur);
                            db.SaveChanges();

                           
                            ResetForm();

                            MessageBox.Show("Utilisateur supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chosir_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dgUtilisateur.SelectedRows.Count > 0)
                {
                    
                    int id = Convert.ToInt32(dgUtilisateur.SelectedRows[0].Cells[0].Value);

                    
                    User utilisateur = db.Users.FirstOrDefault(u => u.IdPersonne == id);

                    if (utilisateur != null)
                    {
                 
                        txtEmail.Text = utilisateur.Email;
                        txtIdentifiant.Text = utilisateur.identifiant;
                        txtNom.Text = utilisateur.Nom;
                        txtPrenom.Text = utilisateur.Prenom;
                        txtTelephone.Text = utilisateur.Telephonehone;

                        
                        statutColletcion.SelectedItem = utilisateur.status;
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur dans le tableau.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
