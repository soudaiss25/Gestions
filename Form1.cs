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
using Gestions.Views;


namespace Gestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Dbgestionscontext db = new Dbgestionscontext();

        private void btn_seConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                string identifiant = txtIdentifiant.Text.ToLower().Trim();
                string motDePasse = txtMotDePasse.Text.Trim();

                if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(motDePasse))
                {
                    MessageBox.Show("Veuillez entrer un identifiant et un mot de passe.");
                    return;
                }

                var leuser = db.Users.FirstOrDefault(a => a.identifiant.ToLower() == identifiant);

                if (leuser == null)
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect !");
                    return;
                }

                string hash = leuser.MotDePasse;
                bool isPasswordCorrect = false;

                using (MD5 md5Hash = MD5.Create())
                {
                    isPasswordCorrect = CryptApp.VerifyMd5Hash(md5Hash, motDePasse, hash);
                }

                if (!isPasswordCorrect)
                {
                    MessageBox.Show("Mot de passe incorrect !");
                    return;
                }

               
                if (string.IsNullOrEmpty(leuser.status))
                {
                    frmResetPassword resetForm = new frmResetPassword();
                    resetForm.idUser = leuser.IdPersonne;
                    resetForm.Show();
                    this.Hide();
                    return;
                }

               
                Form2 form2 = new Form2();
                var le = db.Users.Find(leuser.IdPersonne);

                if (le.role == "Admin" || le.role == null)
                {
                    form2.profil = "Admin";
                }
                else
                {
                    form2.profil = "Gestionnaire";
                }
              

                MessageBox.Show($"Connexion réussie en tant que {form2.profil}");
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MotDepasseOublié_Click(object sender, EventArgs e)
        {

        }
    }
}
